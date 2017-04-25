using System;
namespace HangMan
{
	public class HangManPrints
	{
		public HangManPrints()
		{
		}

		/// <summary>
		/// Not used, but calls all the possible prints.
		/// </summary>
		public void All()
		{
			Start();
			Mistake1();
			Mistake2();
			Mistake3();
			Mistake4();
			Mistake5();
			Mistake6();
			Mistake7();
			Dead();
		}

		/// <summary>
		/// Prints image corresponding to how many 
		/// wrong guesses the user has.
		/// </summary>
		/// <param name="input">
		/// How many wrong guesses the user has.
		/// </param>
		public void PrintArray(int input)
		{
			if (0 == input)
				Start();
			if (1 == input)
				Mistake1();
			if (2 == input)
				Mistake2();
			if (3 == input)
				Mistake3();
			if (4 == input)
				Mistake4();
			if (5 == input)
				Mistake5();
			if (6 == input)
				Mistake6();
			if (7 == input)
				Mistake7();
			if (8 == input)
				Dead();
		}

		/// <summary>
		/// Start image.
		/// </summary>
		public void Start()
		{
			Console.WriteLine($"You know what to do");
		
			Console.WriteLine("\n\n\n\n\n\n" +
			                  "   __________________\n" +
			                  "  /                 /|\n" +
			                  " /_________________/ /\n" +
			                  " |                 |/\n" +
			                  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// First miskake image.
		/// </summary>
		public void Mistake1()
		{
			Console.WriteLine("\n" +
							  "       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// Second mistake image.
		/// </summary>
		public void Mistake2()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// Third mistake image.
		/// </summary>
		public void Mistake3()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |       0\n" +
							  "       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// Fourth mistake image.
		/// </summary>
		public void Mistake4()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |       0\n" +
							  "       |       |\n" +
							  "       |\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// Fifth mistake image.
		/// </summary>
		public void Mistake5()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |       0\n" +
							  "       |      /|\n" +
							  "       |\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// Sixth mistake image.
		/// </summary>
		public void Mistake6()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |       0\n" +
							  "       |      /|\\\n" +
							  "       |\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// Seventh mistake image.
		/// </summary>
		public void Mistake7()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |       0\n" +
							  "       |      /|\\\n" +
							  "       |      /\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\n");
		}

		/// <summary>
		/// End game image.
		/// </summary>
		public void Dead()
		{
			Console.WriteLine("       _________\n" +
							  "       |       |\n" +
							  "       |       0\n" +
							  "       |      /|\\\n" +
							  "       |      / \\\n" +
							  "       |\n" +
							  "   ____|_____________\n" +
							  "  /    |            /|\n" +
							  " /_________________/ /\n" +
							  " |                 |/\n" +
							  " ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
		}

		public void Won()
		{ 
			Console.WriteLine("CONGRATULATIONS! YOU WON!");
		}

		public void Lost()
		{
			Console.WriteLine("     GAME OVER");
		}
	}
}
