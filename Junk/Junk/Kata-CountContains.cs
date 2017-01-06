using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{

	public class Kata
	{
		public static int stringCounter(string inputS, string charS)
		{
			#region myFunc
			//int index = inputS.IndexOf(charS);
			//int count = 0;

			//if (index != -1)
			//{
			//	while (index != -1)
			//	{
			//		count++;
			//		index = inputS.IndexOf(charS, index + 1);
			//	}

			//}
			//return count;
			#endregion

			// return inputS.Split(charS[0]).Length - 1;

			return inputS.Where(x => x == Convert.ToChar(charS)).Count();
		}
	}
}
