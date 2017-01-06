using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class FizzBuzz
	{
		public static void Method ()
		{
			for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(FizBuz(i));
			}
		}

		private static string FizBuz (int i)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				return "FizzBuzz";
			}
			else if (i % 3 == 0)
			{
				return "Fizz";
			}
			else if (i % 5 == 0)
			{
				return "Buzz";
			}
			else
			{
				return i.ToString();
			}
		}
	}
}
