using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
    class Recursion2
    {
        public static int ReverseNumber(int n, int toLimit)
        {
            if (n < toLimit)
            {
                return n;
            }

            Console.WriteLine("  {0} ", n);
            return ReverseNumber(n - 1, toLimit);
        }
    }
}

/*
Write a program in C# Sharp to print numbers from n to 1 using recursion. Go to the editor
Test Data :
How many numbers to print : 10 
Expected Output : 
10 9 8 7 6 5 4 3 2 1 
*/
