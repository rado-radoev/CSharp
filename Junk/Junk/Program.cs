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
			SmallApartment apartment = new SmallApartment();
			ApartmentPerson person = new ApartmentPerson();

			person.Name = "Petar";
			person.House = apartment;
			person.ShowData();
		}
	}
}
