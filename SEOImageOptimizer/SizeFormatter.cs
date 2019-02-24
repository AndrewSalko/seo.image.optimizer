using System;
using System.Collections.Generic;
using System.Text;

namespace SEOImageOptimizer
{
	/// <summary>
	/// Форматирует информацию о размере.
	/// </summary>
	public static class SizeFormatter
	{
		/// <summary>
		/// Преобразование к строке.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string ToString(long value)
		{
			string[] formats = 
				new string[]
				{
					"0 bytes",
					"0 Kb",
					"0 Mb",
					"0 Gb",
					"0 TB",
					"0 PB",
				};
			string format;
			int stage = 0;
			while (true)
			{
				format = formats[stage++];
				if (value >= 1024)
					value /= 1024;
				else
					break;
			}
			return value.ToString(format);
		}
	}
}
