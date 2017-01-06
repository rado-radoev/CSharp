using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class SmallApartment : House
	{

		public SmallApartment()
			: base(50)

		{

		}

		public override void ShowData()
		{
			Console.WriteLine("I am an apartament, my area is: {0} m2", Area);
		}

	}
}
