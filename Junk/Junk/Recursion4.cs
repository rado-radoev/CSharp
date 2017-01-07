using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Recursion4
	{
		public static int Sum(int n, int start)
		{
			if (n < start)
			{
				return n;
			}
			else
			{
				return n + Sum(n - 1, start);
			}

		}
	}
}


/*
Write a program in C# Sharp to find the sum of first n natural numbers using recursion. Go to the editor
Test Data :
How many numbers to sum : 10 
Expected Output : 
The sum of first 10 natural numbers is : 55  
*/
