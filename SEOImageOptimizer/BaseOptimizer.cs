using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SEOImageOptimizer
{
	class BaseOptimizer: IDisposable
	{
		public const string TEMP_DIRECTORY = "SEO.Image.Optimizer";

		protected string _SourceFileName;
		protected string _TempDirectory;

		public BaseOptimizer(string fileName)
		{
			_SourceFileName = fileName;
		}

		protected virtual void _OptimizeFile(string sourceFileName, string destFileName)
		{
		}

		protected long _GetFileSize(string fileName)
		{
			FileInfo fi = new FileInfo(fileName);
			return fi.Length;
		}

		protected void _Prepare()
		{
			string tempFolder = Environment.GetEnvironmentVariable("TEMP");
			string guidPart = Guid.NewGuid().ToString();
			string resultFolder = Path.Combine(tempFolder, guidPart);

			var dir = Directory.CreateDirectory(resultFolder);
			_TempDirectory = dir.FullName;			
		}

		public long BytesOptimized
		{
			get;
			protected set;
		}

		public bool Optimize(out string newFileName)
		{
			bool result = false;
			newFileName = string.Empty;

			long srcLength = _GetFileSize(_SourceFileName);

			_Prepare();

			string fileName = Path.GetFileName(_SourceFileName);

			//применить оптимизатор:
			string destFileName = Path.Combine(_TempDirectory, fileName);

			_OptimizeFile(_SourceFileName, destFileName);
			if (File.Exists(destFileName))
			{
				long optLength = _GetFileSize(destFileName);

				if (optLength < srcLength)
				{
					newFileName = destFileName;
					BytesOptimized = srcLength - optLength;
					result = true;
				}
			}

			return result;
		}

		#region IDisposable Members

		public void Dispose()
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(_TempDirectory))
				{
					Directory.Delete(_TempDirectory, true);
				}
			}
			catch (Exception)
			{								
			}
		}

		#endregion
	}
}
