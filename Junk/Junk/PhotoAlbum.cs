using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class PhotoAlbum
	{
		private int numberOfPages;

		public PhotoAlbum()
		{
			NumberOfPages = 16;
			this.numberOfPages = NumberOfPages;
		}

		public PhotoAlbum(int numberOfPages)
		{
			this.numberOfPages = numberOfPages;
		}

		public int NumberOfPages {
			get
			{
				return numberOfPages;
			}
			set
			{
				numberOfPages = value;
			}
		}

		public int GetNumberOfPages()
		{
			return NumberOfPages;
		}
	}
}
