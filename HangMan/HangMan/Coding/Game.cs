using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace HangMan
{
	public class Game
	{
		public Game()
		{
		}

		GenerateWord gw = new GenerateWord();
		HangManPrints hp = new HangManPrints();
		CheckingIfMatch cm = new CheckingIfMatch();

		private bool _running = true;	//The game will run until the dead or success.
		public string missingLetters;	//How many letters to guess are left.
		public int correctGuss = 0;     //How many correct letters are guessed.
		public int wrongGuess = 0;


		/// <summary>
		/// Starting the game
		/// </summary>
		public void Play()
		{
			// The generated word that has to be guessed is "theWord".
			char[] theWord = gw.RandomWord().ToCharArray();
			cm.FillingAnswerLineWithUnderscore(theWord);

			while (_running)
			{
				//For each wrong letter, print new hangman picture.
				for (int i = 0; i < theWord.Length; i += wrongGuess)
				{
					Console.Clear();
					//missingLetters = new String('_', theWord.Length-i);
					//Console.WriteLine($"Word: {missingLetters}\n");
					hp.PrintArray(i);
					cm.PrintAnswerLine();
					Console.Write("Take a guess, what letter is missing?: ");

					bool guess = cm.IsMatching(theWord);

					if (guess == false)
						wrongGuess = 1;
					else
						wrongGuess = 0;

					bool won = cm.CheckingIfWon();

					if (won == true)
					{
						hp.Won();
						_running = false;
					}
				}
			}
		}

		public void Winning()
		{
			
		}

		public void Loosing()
		{ }
	}
}
