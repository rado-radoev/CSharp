using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Program {
		static void Main(string[] args)
		{
			ComplexNumbers number = new ComplexNumbers(5, 2);
			Console.WriteLine("Number is: " + number.ToString());

			Console.WriteLine("Magnitude is: " + number.GetMagnitude());
		}
	}
}
