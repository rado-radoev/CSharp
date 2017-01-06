using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class ApartmentPerson
	{
		private string name;
		private House house;

		public ApartmentPerson()
		{
			name = "Radoslav";
			house = new House(150);
		}

		public ApartmentPerson(string name, House house)
		{
			this.name = name;
			this.house = house; 
		}
		
		public string Name
		{
			get
			{ return name; }
			set
			{ name = value; }
		}

		public House House
		{
			get
			{
				return house;
			}
			set
			{
				house = value;
			}
		}
		public void ShowData ()
		{
			Console.WriteLine("My name is {0}", Name);
			house.ShowData();
			house.GetDoor();
		}
	}
}
