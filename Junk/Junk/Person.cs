using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Person
	{
		protected int age;
		public Person()
		{ }

		public void Greet ()
		{
			Console.WriteLine("Hello");
		}

		public int SetAge (int n)
		{
			return age = n;
		}
	}
}
