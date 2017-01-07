using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Recursion7
	{
		public static void EvenAndOdd(int stVal, int n)
		{
			if (stVal > n)
				return;
			Console.Write(" {0}  ", stVal);
			EvenAndOdd(stVal + 2, n);
		}
	}
}

/*
Write a program in C to print even or odd numbers in a given range using recursion. Go to the editor
Test Data :
Input the range to print starting from 1 : 20 
Expected Output : 
All even numbers from 1 to 20 are : 
2 4 6 8 10 12 14 16 18 20 
*/
