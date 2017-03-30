using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;


namespace SEOImageOptimizer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void _ButtonBrowse_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(_TextBoxDir.Text))
			{
				_FolderBrowserDialog.SelectedPath = _TextBoxDir.Text;
			}

			if (_FolderBrowserDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			_TextBoxDir.Text = _FolderBrowserDialog.SelectedPath;
		}

		string _WorkFolder;
		bool _SearchRecursively;
		/// <summary>
		/// If 100, using lossless compression (different tools)
		/// </summary>
		int _CompressionQuality;
		volatile bool _Stop;

		private void _ButtonStart_Click(object sender, EventArgs e)
		{
			string startFolder = _TextBoxDir.Text;
			try
			{
				if (!Directory.Exists(startFolder))
				{
					string msg = string.Format("Folder '{0}' not found", startFolder);
					MessageBox.Show(this, msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (_BackgroundWorker.IsBusy)
				{
					MessageBox.Show(this, "Process not finished", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				
				int quality= _RadioButtonLossLessOptimization.Checked ? 100 : (int)_Quality.Value;

				_StartWork(startFolder, _CheckBoxSubFoldersSearch.Checked, quality);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void _EnableControls(bool enable)
		{
			_ButtonBrowse.Enabled = enable;
			_TextBoxDir.Enabled = enable;
			_ButtonStart.Enabled = enable;
			_CheckBoxSubFoldersSearch.Enabled = enable;

			_ButtonStop.Visible = !enable;
		}



		void _StartWork(string folder, bool recursive, int quality)
		{
			_EnableControls(false);

			_CompressionQuality = quality;
			_Stop = false;
			_WorkFolder = folder;
			_SearchRecursively = recursive;

			_ListBoxLog.Items.Clear();

			_BackgroundWorker.RunWorkerAsync();
		}

		private void _BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			SearchOption opt=_SearchRecursively ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
						
			int processedFiles=0;
			int totalFiles = 0;
			int optimized=0;


			Dictionary<string, object> files = new Dictionary<string, object>();
			
			var enumPNG=Directory.EnumerateFiles(_WorkFolder, "*.png", opt);
			if (enumPNG != null)
			{
				foreach (var pngFile in enumPNG)
				{
					if (_Stop)
						return;

					totalFiles++;
					files[pngFile] = null;					
				}
			}
						
			var enumJPG = Directory.EnumerateFiles(_WorkFolder, "*.jpg", opt);
			if (enumJPG != null)
			{
				foreach (var jpgFile in enumJPG)
				{
					if (_Stop)
						return;

					totalFiles++;
					files[jpgFile] = null;
				}
			}


			foreach (var file in files)
			{
				if (_Stop)
					return;

				string fName = file.Key;
				string ext = Path.GetExtension(fName).ToLower();

				if (ext == ".jpg")
				{
					if (_OptimizeJPG(fName, _CompressionQuality))
						optimized++;
				}
				else
				{
					if (ext == ".png")
					{
						if (_OptimizePNG(fName))
							optimized++;
					}
				}

				processedFiles++;

				_DisplayTotal(totalFiles, processedFiles, optimized);
			}
		}

		void _DisplayTotal(int totalFiles, int processed, int optimized)
		{
			_LogLabel("Processed {0} from {1} images, {2} optimized", processed, totalFiles, optimized);
		}

		bool _OptimizePNG(string pngFileName)
		{
			bool result = false;
			string shortName = Path.GetFileName(pngFileName);

			using (PngOptimizer opt = new PngOptimizer(pngFileName))
			{
				string optimizedFileName;
				if (opt.Optimize(out optimizedFileName))
				{
					_Log("{0} - optimized {1} bytes", shortName, opt.BytesOptimized);

					File.Copy(optimizedFileName, pngFileName, true);

					result = true;
				}
				else
				{
					_Log("{0}", shortName);
				}
			}

			return result;
		}

		bool _OptimizeJPG(string jpgFileName, int quality)
		{
			bool result = false;
			string shortName = Path.GetFileName(jpgFileName);

			using (JpgOptimizer opt = new JpgOptimizer(jpgFileName, quality))
			{
				string optimizedFileName;
				if (opt.Optimize(out optimizedFileName))
				{
					_Log("{0} - optimized {1} bytes", shortName, opt.BytesOptimized);

					File.Copy(optimizedFileName, jpgFileName, true);

					result = true;
				}
				else
				{
					_Log("{0}", shortName);
				}
			}

			return result;
		}

		void _LogLabel(string message, params object[] args)
		{
			if (InvokeRequired)
			{
				this.Invoke((MethodInvoker)delegate
				{
					_LogLabel(message, args);
				});
				return;
			}

			string res = string.Format(message, args);
			_LabelTotal.Text = res;
		}

		void _Log(string message, params object[] args)
		{
			if (InvokeRequired)
			{
				this.Invoke((MethodInvoker)delegate
					{
						_Log(message, args);
					});
				return;
			}

			string res = string.Format(message, args);

			int ind=_ListBoxLog.Items.Add(res);
			_ListBoxLog.SelectedIndex = ind;			
		}


		private void _BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			_EnableControls(true);

			if (e.Error != null)
			{
				MessageBox.Show(this, e.Error.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string temp = Path.Combine(Path.GetTempPath(), BaseOptimizer.TEMP_DIRECTORY);
				if(Directory.Exists(temp))
				{
					Directory.Delete(temp, true);
				}

				MessageBox.Show(this, "Optimization process completed successfully", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void _BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_LabelTotal.Text = string.Empty;
			_ButtonStop.Visible = false;

			//если в конфиге есть папка для работы, ставим ее по умолчанию
			string workFolder = ConfigurationManager.AppSettings["WorkFolder"];
			if (!string.IsNullOrWhiteSpace(workFolder))
			{
				_TextBoxDir.Text = workFolder;
			}
		}

		private void _ButtonStop_Click(object sender, EventArgs e)
		{
			_Stop = true;			
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAbout aboutForm = new FormAbout();
			aboutForm.ShowDialog(this);
		}

	}
}
