using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Door
	{
		private string color;

		public Door()
		{
			this.color = "Brown";
		}

		public Door (string color)
		{
			this.color = Color;
		}

		public string Color
		{
			get
			{ return color; }
			set
			{ color = value; }
		}

		internal void ShowData ()
		{
			Console.WriteLine("I am a door, my color is {0}", Color);
		}
	}
}
