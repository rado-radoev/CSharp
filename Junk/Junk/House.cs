﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class House
	{
		private int area;
		private Door door;
		
		public House(int area)
		{
			this.area = area;
			door = new Door();
		}

		public int Area
		{
			get
			{ return area; }
			set
			{ area = value; }
		}

		public Door Door
		{
			get
			{ return door; }
			set
			{ door = value; }
		}

		public virtual void ShowData()
		{
			Console.WriteLine("I am a {0}, my area is {1} m2", Area);
		}

		public void GetDoor()
		{
			Door.ShowData();
		}

	}
}
