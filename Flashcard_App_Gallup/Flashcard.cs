using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public class Flashcard
	{
		private bool showingFront;
		private string frontText;
		private string backText;

		public Flashcard(string front, string back)
		{
			showingFront = true;
			frontText = front;
			backText = back;
		}

		public string GetFront()
		{
			return frontText;
		}

		public string GetBack()
		{
			return backText;
		}
		
		public void FlipCard()
		{
			showingFront = !showingFront;
		}
	}
}
