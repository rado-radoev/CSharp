using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Recursion8
	{
		public static void PrimeOrNot(int val)
		{
			
			int prime = 1;
			int notPrime = 0;
			if (val == prime)
			{
				Console.WriteLine("Number is prime");
				return;
			}
			else if (val == notPrime)
			{
				Console.WriteLine("Number is not prime");
				return;
			}
			PrimeOrNot(val % 2);
		}
	}
}

/*Write a program in C# Sharp to check whether a number is prime or not using recursion. Go to the editor
Test Data :
Input any positive number : 37 
Expected Output : 
The number 37 is a prime number. 
*/
