using System;
namespace HangMan
{
	public class GenerateWord
	{
		public GenerateWord()
		{
		}

		/// <summary>
		/// Random choosing a word or sentence 
		/// from the string-array "words"
		/// </summary>
		/// <returns>The word</returns>
		public string RandomWord()
		{
			Random rnd = new Random();
			string[] words = new string[]
			{ 
				"apple", 
				"mango", 
				"computer", 
				"human", 
				"goat", 
				"cat", 
				"hello", 
				"how are you today", 
				"i am great thanks for asking", 
				"can i get you something?", 
				"no i am fine", 
				"how do you do", 
				"i like trains", 
				"santa claus exists", 
				"i like playing tennis",
				"girls and boys", 
				"picture frame", 
				"teddy bear or not", 
				"i like horses", 
				"campus", 
				"boxes are square", 
				"often", 
				"likable", 
				"how to spell", 
				"no questions asked", 
				"i forgot to stuff", 
				"this is just a test", 
				"testing", 
				"this i exausting", 
				"i hate typing", 
				"but it is not that bad", 
				"i dont type slow", 
				"why do you wanna know", 
				"i like music", 
				"please dont hang me", 
				"dont kill me please", 
				"please", 
				"dont", 
				"this is a sentence", 
				"sentences" 
			};
			return words[rnd.Next(0,words.Length)];
		}
	}
}
