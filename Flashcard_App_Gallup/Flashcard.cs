using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public class Flashcard
	{
		private bool showingFront = true;
		private string frontText;
		private string backText;

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
