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
		/// Fills the chararray "answerLine" with underscore -
		/// Since it has to look empty.
		/// </summary>
		/// <param name="input">Input.</param>
		public void FillingAnswerLineWithUnderscore(char[] input)
		{
			lengthOfWord = input.Length;
			for (int i = 0; i < lengthOfWord; i++)
				answerLine[i] = '_';
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
			var userInput = Console.ReadLine().ToCharArray();

			char theLetter = userInput[0];
			int checkingFail = 0;

			for (int i = 0; i < lengthOfWord; i++)
			{
				if (input[i] == theLetter)
				{
					answerLine[i] = input[i];
					checkingFail++;
				}
			}

			if (checkingFail == 0)
			{
				wrongAnswerLine[j++] = theLetter;
				return false;
			}
			else
				return true;
		}
		// boremaskine til vægge

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

		public bool CheckingIfWon()
		{
			int won = 0;

			for (int i = 0; i < lengthOfWord; i++)
			{
				if (answerLine[i] != '_')
					won++;
			}

			if (won == answerLine.Length)
				return true;
			else
				return false;	
		}
	}
}
