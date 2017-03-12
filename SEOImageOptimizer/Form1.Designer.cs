namespace SEOImageOptimizer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this._TextBoxDir = new System.Windows.Forms.TextBox();
			this._ButtonBrowse = new System.Windows.Forms.Button();
			this._CheckBoxSubFoldersSearch = new System.Windows.Forms.CheckBox();
			this._ButtonStart = new System.Windows.Forms.Button();
			this._FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._BackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this._LabelTotal = new System.Windows.Forms.Label();
			this._ListBoxLog = new System.Windows.Forms.ListBox();
			this._ButtonStop = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._GroupBoxOptions = new System.Windows.Forms.GroupBox();
			this._RadioButtonLossLessOptimization = new System.Windows.Forms.RadioButton();
			this._RadioButtonOptimizeWithQuality = new System.Windows.Forms.RadioButton();
			this._Quality = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1.SuspendLayout();
			this._GroupBoxOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._Quality)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select directory with images:";
			// 
			// _TextBoxDir
			// 
			this._TextBoxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._TextBoxDir.Location = new System.Drawing.Point(15, 54);
			this._TextBoxDir.Name = "_TextBoxDir";
			this._TextBoxDir.Size = new System.Drawing.Size(469, 20);
			this._TextBoxDir.TabIndex = 1;
			// 
			// _ButtonBrowse
			// 
			this._ButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._ButtonBrowse.Location = new System.Drawing.Point(490, 52);
			this._ButtonBrowse.Name = "_ButtonBrowse";
			this._ButtonBrowse.Size = new System.Drawing.Size(58, 23);
			this._ButtonBrowse.TabIndex = 2;
			this._ButtonBrowse.Text = "...";
			this._ButtonBrowse.UseVisualStyleBackColor = true;
			this._ButtonBrowse.Click += new System.EventHandler(this._ButtonBrowse_Click);
			// 
			// _CheckBoxSubFoldersSearch
			// 
			this._CheckBoxSubFoldersSearch.AutoSize = true;
			this._CheckBoxSubFoldersSearch.Location = new System.Drawing.Point(15, 80);
			this._CheckBoxSubFoldersSearch.Name = "_CheckBoxSubFoldersSearch";
			this._CheckBoxSubFoldersSearch.Size = new System.Drawing.Size(158, 17);
			this._CheckBoxSubFoldersSearch.TabIndex = 3;
			this._CheckBoxSubFoldersSearch.Text = "Search images in subfolders";
			this._CheckBoxSubFoldersSearch.UseVisualStyleBackColor = true;
			// 
			// _ButtonStart
			// 
			this._ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._ButtonStart.Location = new System.Drawing.Point(437, 370);
			this._ButtonStart.Name = "_ButtonStart";
			this._ButtonStart.Size = new System.Drawing.Size(111, 23);
			this._ButtonStart.TabIndex = 4;
			this._ButtonStart.Text = "Start";
			this._ButtonStart.UseVisualStyleBackColor = true;
			this._ButtonStart.Click += new System.EventHandler(this._ButtonStart_Click);
			// 
			// _FolderBrowserDialog
			// 
			this._FolderBrowserDialog.Description = "Select folder with images to optimize";
			this._FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this._FolderBrowserDialog.ShowNewFolderButton = false;
			// 
			// _BackgroundWorker
			// 
			this._BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this._BackgroundWorker_DoWork);
			this._BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this._BackgroundWorker_ProgressChanged);
			this._BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._BackgroundWorker_RunWorkerCompleted);
			// 
			// _LabelTotal
			// 
			this._LabelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._LabelTotal.AutoSize = true;
			this._LabelTotal.Location = new System.Drawing.Point(12, 375);
			this._LabelTotal.Name = "_LabelTotal";
			this._LabelTotal.Size = new System.Drawing.Size(43, 13);
			this._LabelTotal.TabIndex = 6;
			this._LabelTotal.Text = "<Total>";
			// 
			// _ListBoxLog
			// 
			this._ListBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ListBoxLog.FormattingEnabled = true;
			this._ListBoxLog.Location = new System.Drawing.Point(15, 204);
			this._ListBoxLog.Name = "_ListBoxLog";
			this._ListBoxLog.Size = new System.Drawing.Size(533, 134);
			this._ListBoxLog.TabIndex = 7;
			// 
			// _ButtonStop
			// 
			this._ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._ButtonStop.Location = new System.Drawing.Point(334, 370);
			this._ButtonStop.Name = "_ButtonStop";
			this._ButtonStop.Size = new System.Drawing.Size(97, 23);
			this._ButtonStop.TabIndex = 8;
			this._ButtonStop.Text = "Stop";
			this._ButtonStop.UseVisualStyleBackColor = true;
			this._ButtonStop.Click += new System.EventHandler(this._ButtonStop_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(560, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// _GroupBoxOptions
			// 
			this._GroupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._GroupBoxOptions.Controls.Add(this._Quality);
			this._GroupBoxOptions.Controls.Add(this._RadioButtonOptimizeWithQuality);
			this._GroupBoxOptions.Controls.Add(this._RadioButtonLossLessOptimization);
			this._GroupBoxOptions.Location = new System.Drawing.Point(15, 103);
			this._GroupBoxOptions.Name = "_GroupBoxOptions";
			this._GroupBoxOptions.Size = new System.Drawing.Size(533, 85);
			this._GroupBoxOptions.TabIndex = 10;
			this._GroupBoxOptions.TabStop = false;
			this._GroupBoxOptions.Text = "Optimization options";
			// 
			// _RadioButtonLossLessOptimization
			// 
			this._RadioButtonLossLessOptimization.AutoSize = true;
			this._RadioButtonLossLessOptimization.Checked = true;
			this._RadioButtonLossLessOptimization.Location = new System.Drawing.Point(6, 28);
			this._RadioButtonLossLessOptimization.Name = "_RadioButtonLossLessOptimization";
			this._RadioButtonLossLessOptimization.Size = new System.Drawing.Size(123, 17);
			this._RadioButtonLossLessOptimization.TabIndex = 0;
			this._RadioButtonLossLessOptimization.TabStop = true;
			this._RadioButtonLossLessOptimization.Text = "Lossless optimization";
			this._RadioButtonLossLessOptimization.UseVisualStyleBackColor = true;
			// 
			// _RadioButtonOptimizeWithQuality
			// 
			this._RadioButtonOptimizeWithQuality.AutoSize = true;
			this._RadioButtonOptimizeWithQuality.Location = new System.Drawing.Point(6, 51);
			this._RadioButtonOptimizeWithQuality.Name = "_RadioButtonOptimizeWithQuality";
			this._RadioButtonOptimizeWithQuality.Size = new System.Drawing.Size(246, 17);
			this._RadioButtonOptimizeWithQuality.TabIndex = 1;
			this._RadioButtonOptimizeWithQuality.Text = "Optimize and reduce quality (best compression)";
			this._RadioButtonOptimizeWithQuality.UseVisualStyleBackColor = true;
			// 
			// _Quality
			// 
			this._Quality.Location = new System.Drawing.Point(258, 51);
			this._Quality.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this._Quality.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this._Quality.Name = "_Quality";
			this._Quality.Size = new System.Drawing.Size(67, 20);
			this._Quality.TabIndex = 2;
			this._Quality.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 405);
			this.Controls.Add(this._GroupBoxOptions);
			this.Controls.Add(this._ButtonStop);
			this.Controls.Add(this._ListBoxLog);
			this.Controls.Add(this._LabelTotal);
			this.Controls.Add(this._ButtonStart);
			this.Controls.Add(this._CheckBoxSubFoldersSearch);
			this.Controls.Add(this._ButtonBrowse);
			this.Controls.Add(this._TextBoxDir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "SEO Image optimization utility";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this._GroupBoxOptions.ResumeLayout(false);
			this._GroupBoxOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._Quality)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _TextBoxDir;
		private System.Windows.Forms.Button _ButtonBrowse;
		private System.Windows.Forms.CheckBox _CheckBoxSubFoldersSearch;
		private System.Windows.Forms.Button _ButtonStart;
		private System.Windows.Forms.FolderBrowserDialog _FolderBrowserDialog;
		private System.ComponentModel.BackgroundWorker _BackgroundWorker;
		private System.Windows.Forms.Label _LabelTotal;
		private System.Windows.Forms.ListBox _ListBoxLog;
		private System.Windows.Forms.Button _ButtonStop;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox _GroupBoxOptions;
		private System.Windows.Forms.RadioButton _RadioButtonOptimizeWithQuality;
		private System.Windows.Forms.RadioButton _RadioButtonLossLessOptimization;
		private System.Windows.Forms.NumericUpDown _Quality;
	}
}

