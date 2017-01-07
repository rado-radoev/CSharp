using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Recursion5
	{
		public static void separateDigits(int n)
		{
			if (n < 10)
			{
				Console.Write("{0}  ", n);
				return;
			}
			separateDigits(n / 10);
			Console.Write(" {0} ", n % 10);
		}
	}
}

/*
Write a program in C# Sharp to display the individual digits of a given number using recursion. Go to the editor
Test Data :
Input any number : 1234 
Expected Output : 
The digits in the number 1234 are : 1 2 3 4
*/
