using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
	static class Ext
	{
		public static bool Between<T>(this T source, T start, T end) where T : IComparable
		{
			return source.CompareTo(start) >= 0 && source.CompareTo(end) <= 0;
		}
	}
}
