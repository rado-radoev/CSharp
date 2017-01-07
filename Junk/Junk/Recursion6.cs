using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Recursion6
	{
		public static int getDigits(int n1, int nodigits)
		{
			if (n1 == 0)
				return nodigits;

			return getDigits(n1 / 10, ++nodigits);
		}
	}
}

/*
 Write a program in C# Sharp to count the number of digits in a number using recursion. Go to the editor
Test Data :
Input any number : 12345 
Expected Output : 
The number 12345 contains number of digits : 5 
*/
