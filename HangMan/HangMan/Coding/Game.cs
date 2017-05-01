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

		Menu 			m	= new Menu();
		GenerateWord 	gw 	= new GenerateWord();
		HangManPrints 	hp 	= new HangManPrints();
		CheckingIfMatch cm 	= new CheckingIfMatch();

		public int 	correctGuss = 0;    //How many correct letters are guessed.
		public int 	wrongGuess = 0;		//If the latest guess was wrong
		public int 	totalWrongGuess = 0;//How many total wrong guesses


		/// <summary>
		/// Starting the game
		/// </summary>
		public void Play()
		{
			bool _running = true;

			// The generated word that has to be guessed is "theWord".
			char[] theWord = gw.RandomWord().ToCharArray();
			cm.FillingAnswerLineWithUnderscore(theWord);

			while (_running)
			{
				//For each wrong letter, print new hangman picture.
				for (int i = 0; i < theWord.Length + totalWrongGuess; i += wrongGuess)
				{
					Console.Clear();

					hp.PrintArray(i);
					cm.PrintAnswerLine();

					if (cm.IsMatching(theWord) == false)
					{
						wrongGuess = 1;
						totalWrongGuess += 1;
					}
					else
						wrongGuess = 0;
					
					if (cm.CheckingIfWon(theWord) == true)
						Winning(i);

					if (i == 7)
						Loosing(i);
				}
			}
		}

		public void Winning(int i)
		{
			Console.Clear();
			hp.Won();
			hp.PrintArray(i);
			cm.PrintAnswerLine();
			Console.WriteLine();
			m.RunAgain();
		}

		public void Loosing(int i)
		{ 
			Console.Clear();
			hp.Dead();
			hp.Lost();
			Console.WriteLine();
			m.RunAgain();
		}
	}
}
