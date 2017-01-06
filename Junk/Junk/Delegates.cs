using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Junk { 
delegate void Print();
delegate int UserNum();
delegate void PrintUserNum(int n);
delegate double CalculateNumber(int n);
delegate void PrintResults(double add, double mult, double sub);

	class Delegates
	{
		public static Random rnd = new Random();

		public static void PrintWelcome()
		{
			Console.WriteLine("Hello Gamer!");
		}

		public static void PrintGameConditions()
		{
			Console.WriteLine("These are the conditions: " +
			"Choose a number and I will do some cool things with it. " +
			"You like it? Let's play!\n");
		}

		public static void PrintUserChoice(int userNumber)
		{
			Console.WriteLine("You chose " + userNumber + " " +
			"Ready to see what we can do with it?");
		}

		public static void PrintResults(double add, double mult, double sub)
		{
			Console.WriteLine("After adding a random number to your number. " +
			"Your new number looks like this: {0}", add);
			Console.WriteLine("After multiplying a random number to your number. " +
			"Your number looks like this: {0}", mult);
			Console.WriteLine("After subtracting a random number from your number. " +
			"Your number looks like this: {0}", sub);
		}

		public static int GetUsersChoice()
		{
			bool convert = false;
			int num = 0;
			while (!convert)
			{
				Console.Write("What is your number?: ");
				string s = Console.ReadLine();
				convert = Int32.TryParse(s, out num);
				if (num == 0)
				{
					Console.WriteLine("You cannot choose 0!");
					convert = false;
				}
			}
			return num;
		}


		public static double AddNum(int n)
		{
			double random = rnd.Next(1, 101);
			return n + random;
		}

		public static double MultiplyNum(int n)
		{
			double random = rnd.Next(1, 200);
			return n * random;
		}

		public static double SubtractNum(int n)
		{
			double random = rnd.Next(1, 1000000);
			return n - random;
		}
	}
}


/*
 * Main method 

Print printOnScreen;
CalculateNumber calculateUserNumber;

// Delegates
Print printWelcome = new Print(Delegates.PrintWelcome);
Print printGameConditions = new Print(Delegates.PrintGameConditions);
UserNum userNumber = new UserNum(Delegates.GetUsersChoice);
PrintUserNum prntUserNumber = new PrintUserNum(Delegates.PrintUserChoice);
CalculateNumber addUserNumber = new CalculateNumber(Delegates.AddNum);
CalculateNumber multiplyUserNumber = new CalculateNumber(Delegates.MultiplyNum);
CalculateNumber subtractUserNumber = new CalculateNumber(Delegates.SubtractNum);
PrintResults prntResults = new PrintResults(Delegates.PrintResults);


printOnScreen = printWelcome;
printOnScreen += printGameConditions;
printOnScreen.Invoke();

int number = userNumber.Invoke();

prntUserNumber(number);

calculateUserNumber = addUserNumber;
calculateUserNumber += multiplyUserNumber;
calculateUserNumber += subtractUserNumber;
prntResults(addUserNumber(number), multiplyUserNumber(number), subtractUserNumber(number));
	 */
