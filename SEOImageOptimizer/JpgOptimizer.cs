using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEOImageOptimizer
{
	class JpgOptimizer: BaseOptimizer
	{
		public JpgOptimizer(string fileName, int quality)
			: base(fileName)
		{
			_Quality = quality;
		}

		int _Quality;

		protected override void _OptimizeFile(string sourceFileName, string destFileName)
		{
			if(_Quality==100)
			{
				_DoLosslessOptimization(sourceFileName, destFileName);
			}
			else
			{
				_DoOptimizationWithQuality(sourceFileName, destFileName);
			}
		}

		void _DoOptimizationWithQuality(string sourceFileName, string destFileName)
		{
			string djpeg = Path.Combine(Application.StartupPath, "djpeg.exe");
			string cjpeg = Path.Combine(Application.StartupPath, "cjpeg.exe");//cjpeg.exe -quality 84 -optimize -progressive  source.dat result.jpg

			string temp = Path.Combine(Path.GetTempPath(), "SEO.Image.Optimizer", Guid.NewGuid().ToString());
			Directory.CreateDirectory(temp);

			string tempDataFile = Path.Combine(temp, "source.dat");

			//uncompress jpg-file into temp folder
			string uncompressCommand = string.Format("{0} {1}", sourceFileName, tempDataFile);
			ProcessStartInfo pi = new ProcessStartInfo(djpeg, uncompressCommand);
			pi.WindowStyle = ProcessWindowStyle.Hidden;
			Process proc = Process.Start(pi);
			proc.WaitForExit();

			//compress into .jpg again, reduce quality for best compression
			string compressCommand = string.Format("-quality {0} -optimize -progressive  {1} {2}", _Quality, tempDataFile, destFileName);
			ProcessStartInfo pi2 = new ProcessStartInfo(cjpeg, compressCommand);
			pi2.WindowStyle = ProcessWindowStyle.Hidden;
			Process proc2 = Process.Start(pi2);
			proc2.WaitForExit();


		}

		void _DoLosslessOptimization(string sourceFileName, string destFileName)
		{
			string optiJPG = Path.Combine(Application.StartupPath, "jpegtran.exe");
			ProcessStartInfo pi = new ProcessStartInfo(optiJPG, string.Format(" -copy none -optimize -progressive \"{0}\" \"{1}\"", sourceFileName, destFileName));
			pi.WindowStyle = ProcessWindowStyle.Hidden;

			Process proc = Process.Start(pi);
			proc.WaitForExit();
		}

	}
}
