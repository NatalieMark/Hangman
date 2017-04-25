using System;
namespace HangMan
{
	public class Menu
	{

		public void Run()
		{
			Printchoice();
			Choose();
		}

		public void RunAgain()
		{
			PrintchoiceAgain();
			Choose();
		}

		public void Printchoice()
		{ 
			Console.WriteLine("Hello! Do you want to play Hangman?\n\n" +
				"· Yes\t= y\n" +
				"· No\t= n\n");
		}

		public void PrintchoiceAgain()
		{
			Console.WriteLine("Hello! Do you want to play Hangman again?\n\n" +
				"· Yes\t= y\n" +
				"· No\t= n\n");
		}

		public void Choose()
		{
			var choice = Console.ReadKey();

			if (choice.Key == ConsoleKey.Y)
			{
				Game g = new Game();
				g.Play();
			}
			else if (choice.Key == ConsoleKey.N)
			{
				Console.Clear();
				Printchoice();
				Console.WriteLine("Okay Bye!");
			}
			else
				Choose();
		}
	}
}
