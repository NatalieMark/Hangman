using System;

namespace HangMan
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			Game g = new Game();
			g.Play();

			//CheckingIfMatch c = new CheckingIfMatch();
			//c.IsMatching("hello");
		}
	}
}
