using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
    class Recursion1
    {
        public static int printNatural(int stval, int ctr)
        {
            if (ctr < 1)
            {
                return stval;
            }

            ctr--;
            Console.WriteLine("{0} ",stval);
            return printNatural(stval + 1, ctr);
        }

        /*
         Write a program in C# Sharp to print the first n natural number using recursion. Go to the editor
        Test Data :
        How many numbers to print : 10 
        Expected Output : 
        1 2 3 4 5 6 7 8 9 10 
         */

        /* Main Method
        Console.Write("\n\n Recursion : Print the first n natural number :\n");
            Console.Write("---------------------------------------------------\n");
            Console.Write(" How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());
        // Call recursive method with two parameters.	
        Recursion1.printNatural(1, ctr);
            Console.Write("\n\n");
        */
    }
}
