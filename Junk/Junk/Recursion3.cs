using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
    class Recursion3
    {
        public static int SumOfTen (int min, int max)
        {
            return CalcuSum(min, max);
        }
        

        public static int CalcuSum (int min, int val)
        {
            if (val == min)
            {
                return val;
            }
            return val + CalcuSum(min, val - 1);
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
