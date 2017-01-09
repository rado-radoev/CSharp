using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class DelegateEvents
	{
		public event MyDelegate mydelegate;
		public void Method2()
		{
			if (mydelegate != null)
				Method1();
		}

		public void Method1()
		{
			Console.WriteLine("Howdy");
		}
	}
}
