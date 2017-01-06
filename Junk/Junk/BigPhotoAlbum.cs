using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class BigPhotoAlbum
	{
		private int numberOfPages;

		public BigPhotoAlbum()
		{
			NumberOfPages = 64;
			this.numberOfPages = NumberOfPages;
		}

		public int NumberOfPages {
			get
			{ return numberOfPages; }
			set
			{ numberOfPages = value; }
		}
	}
}
