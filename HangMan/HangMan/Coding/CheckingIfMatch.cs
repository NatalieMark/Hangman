using System;
using System.Diagnostics;
using System.Linq;



namespace HangMan
{
	public class CheckingIfMatch
	{
		public CheckingIfMatch()
		{
		}

		char[] answerLine = new char[100];
		char[] wrongAnswerLine = new char[100];
		int lengthOfWord;
		int j = 0;

		/// <summary>
		/// Fills the chararray "answerLine" with underscore 
		/// Since it has to look empty.
		/// But not where there is spaces.
		/// </summary>
		/// <param name="input">Input.</param>
		public void FillingAnswerLineWithUnderscore(char[] input)
		{
			lengthOfWord = input.Length;
			for (int i = 0; i < lengthOfWord; i++)
				answerLine[i] = '_';
			CheckingIfSpace(input);
		}

		/// <summary>
		/// Checking whether input char matches the string
		/// </summary>
		/// <returns>
		/// <c>true</c>, If the char input matches the 
		/// generated word, <c>false</c> otherwise.
		/// </returns>
		/// <param name="input">
		/// Generated word.
		/// </param>
		public bool IsMatching(char[] input)
		{
			var userInput = Console.ReadKey();
			if (userInput.Key == ConsoleKey.Enter)
				IsMatching(input);

			int checkingFail = 0;

			for (int i = 0; i < lengthOfWord; i++)
			{
				if (input[i] == userInput.KeyChar)
				{
					answerLine[i] = input[i];
					checkingFail++;
				}
			}

			if (checkingFail == 0)
			{
				wrongAnswerLine[j++] = userInput.KeyChar;
				return false;
			}
			else
				return true;
		}

		/// <summary>
		/// Prints the answer line.
		/// </summary>
		public void PrintAnswerLine()
		{
			Console.Write("Word: ");
			foreach (char letter in answerLine)
				Console.Write(letter);
			Console.WriteLine( );

			Console.Write("Wrong letters: ");
			foreach (char letter in wrongAnswerLine)
				Console.Write(letter);
			Console.WriteLine();
		}

		/// <summary>
		/// Checking if the player won.
		/// </summary>
		/// <returns>
		/// <c>true</c>, if the player won, <c>false</c> otherwise.
		/// </returns>
		public bool CheckingIfWon(char[] input)
		{
			int won = 0;

			for (int i = 0; i < lengthOfWord; i++)
			{
				if (answerLine[i] == input[i])
					won++;
				else
					won = 0;
			}

			if (won == lengthOfWord)
				return true;
			else
				return false;	
		}

		/// <summary>
		/// If the word contains a space, add that space.
		/// (So the user doesn't have to guess ' ')
		/// </summary>
		/// <param name="input">Input.</param>
		public void CheckingIfSpace(char[] input)
		{
			for (int i = 0; i < lengthOfWord; i++)
			{
				if (input[i] == ' ')
					answerLine[i] = input[i];
			} 
		}
	}
}
