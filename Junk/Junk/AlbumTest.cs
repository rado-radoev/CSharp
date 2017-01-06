using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class AlbumTest
	{
		public static void Method()
		{
			int n = 24;
			PhotoAlbum album1 = new PhotoAlbum();
			PhotoAlbum album2 = new PhotoAlbum(n);
			BigPhotoAlbum bigalbum = new BigPhotoAlbum();

			Console.WriteLine("Album 1 has {0} pages. \n" +
				"Album 2 has {1} pages. \n" +
				"The big album has {2} pages.", album1.GetNumberOfPages(), album2.GetNumberOfPages(),
				bigalbum.NumberOfPages);
		}
		
		
	}
}
