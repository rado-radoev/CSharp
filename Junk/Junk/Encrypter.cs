using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class Encrypter
	{
		public static string Encrypt (string message)
		{
			string outputMessage = null;
			foreach (char c in message)
			{
				int i = (int)c + 1;
				outputMessage += (char)i;
			}

			return outputMessage;
		}


		public static string Derypt(string message)
		{
			string decodedMessage = null;
			for (int i = 0; i < message.Length; i++)
			{
				int j = (int)message[i] - 1;
				decodedMessage += (char)j;
			}

			return decodedMessage;
		}
	}
}
