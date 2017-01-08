using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Recursion9
	{
		public static bool IsPalindrome(string s)
		{
			int min = 0;
			int max = s.Length - 1;

			while (min < max)
			{
				if (s[min] != s[max])
				{
					return false;
				}

				min++;
				max--;
			}

			return true;
		}
	}
}
/*
Write a program in C# Sharp to Check whether a given String is Palindrome or not using recursion. Go to the editor
Test Data :
Input a string : RADAR 
Expected Output : 
The string is Palindrome.
*/
