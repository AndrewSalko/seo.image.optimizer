using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SEOImageOptimizer
{
	class PngOptimizer: BaseOptimizer
	{		
		public PngOptimizer(string fileName)
			: base(fileName)
		{
		}

		protected override void _OptimizeFile(string sourceFileName, string destFileName)
		{
			string optiPNG = Path.Combine(Application.StartupPath, "optipng.exe");
			ProcessStartInfo pi = new ProcessStartInfo(optiPNG, string.Format(" -o7 \"{0}\" -out \"{1}\"", sourceFileName, destFileName));
			pi.WindowStyle = ProcessWindowStyle.Hidden;

			Process proc = Process.Start(pi);
			proc.WaitForExit();
		}

	}
}
