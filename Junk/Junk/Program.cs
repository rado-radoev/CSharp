using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	public delegate void MyDelegate();
	class Program {
		static void Main(string[] args)
		{
			DelegateEvents eventExcercises = new DelegateEvents();
			eventExcercises.mydelegate += new MyDelegate(eventExcercises.Method1);
			eventExcercises.Method2();
			Console.ReadLine();
		}
	}
}
