using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class SumWithHighetLowest
	{
		public static int Sum(int[] numbers)
		{

			if (numbers.Length <= 1)
			{
				return 0;
			}

			int min = numbers.Min();
			int max = numbers.Max();
			int sum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] != min && numbers[i] != max)
				{
					sum += numbers[i];
				}
			}

			return sum;
		}
	}
}
