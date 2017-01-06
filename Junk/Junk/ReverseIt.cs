using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class ReverseIt
	{
		private static Random rnd = new Random();

		public static void Mn ()
		{
			Console.WriteLine("Enter number from 1 to 9.");
			string userString = Console.ReadLine();
			int userNum = Convert.ToInt32(userString); ;
			int attempts = 0;

			int[] sortedArr = GenerateRandomArray();
			Array.Sort(sortedArr);

			while (true)
			{
				int[] modified = ModifiedArray(GenerateRandomArray(), userNum);

				if (modified == sortedArr)
				{
					Console.WriteLine("Array is now sorted. It took {0} attempts", attempts);
					break;
				}
				attempts++;
			}
		}

		private static int[] ModifiedArray (int[] array, int number)
		{

			for (int i = 0; i < number - 2; i++)
			{
				int temp = array[number - i - 1];
				array[number - i - 1] = array[i];
				array[i] = temp;
			}
			return array;
		}

		private static bool CheckRndInArray (int[] array, int number)
		{
			if (array.Contains(number))
			{
				return true;
			}
			return false;
		}


		private static int[] GenerateRandomArray ()
		{
			int[] arr = new int[9];
			int num;
			int i = 0;

			while (arr[8] == 0)
			{
				num = rnd.Next(1, 10);
				if (!CheckRndInArray(arr, num))
				{
					arr[i] = num;
					i++;
				}
			}
			return arr;
		}
	}
}
