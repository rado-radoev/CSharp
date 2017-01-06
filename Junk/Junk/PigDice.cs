using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class PigDice
	{
		private static IDictionary<int, int> playersScores = new Dictionary<int, int>();

		public static void Main1()
		{
			Console.WriteLine("Enter number of players");
			int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
			int[] players = new int[numberOfPlayers];

			while (true)
			{
				for (int i = 0; i < players.Length; i++)
				{
					playersScores[i] = PlayerTurn(i);
				}

				foreach (var item in playersScores)
				{
					Console.WriteLine("Player 's {0} score is: {1}", item.Key, item.Value);
					if (item.Value > 100)
					{
						break;
					}
				}
			}
		}

		private static int RollDice()
		{
			Random rnd = new Random();
			int dice = rnd.Next(1, 7);
			return dice;
		}

		private static int PlayerTurn(int player)
		{
			int playerOverallScore;
			try
			{
				playerOverallScore = playersScores[player];
			}
			catch (KeyNotFoundException)
			{

				playerOverallScore = 0;
			}
			
			int playerCurrentScore = 0;
			bool playerHold = false;
			int dice1 = 0;
			int dice2 = 0;

			while (playerOverallScore < 100 && playerHold != true)
			{
				dice1 = RollDice();
				dice2 = RollDice();

				if (dice1 != 1 && dice2 != 1)
				{
					playerCurrentScore += (dice1 + dice2);
					Console.WriteLine("Player {0} current score is: {1}", player + 1, playerCurrentScore);
					Console.WriteLine("Do you want to hold or continue?");
					string userAnswer = Console.ReadLine();

					if (userAnswer.ToLower() == "hold")
					{
						playerHold = true;
					}
				}
				else
				{
					playerCurrentScore = 0;
					playerHold = true;
					Console.WriteLine("Player {0} overall score is: {1}", player + 1, playerOverallScore);
				}
			}
			playerOverallScore += playerCurrentScore;
			return playerOverallScore;
		}
	}
}
