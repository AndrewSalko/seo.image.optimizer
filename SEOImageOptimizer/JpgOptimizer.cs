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
		public JpgOptimizer(string fileName)
			: base(fileName)
		{
		}

		protected override void _OptimizeFile(string sourceFileName, string destFileName)
		{
			string optiJPG = Path.Combine(Application.StartupPath, "jpegtran.exe");
			ProcessStartInfo pi = new ProcessStartInfo(optiJPG, string.Format(" -copy none -optimize  \"{0}\" \"{1}\"", sourceFileName, destFileName));
			pi.WindowStyle = ProcessWindowStyle.Hidden;

			Process proc = Process.Start(pi);			
			proc.WaitForExit();
		}
	}
}
