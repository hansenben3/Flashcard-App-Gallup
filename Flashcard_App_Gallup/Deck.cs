using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public class Deck
	{

		private string deckName;
		private string deckDescription;
		private List<Flashcard> cards;

		public Deck(string name, string description)
		{
			deckName = name;
			deckDescription = description;
			cards = new List<Flashcard>();
		}

		public void AddFlashcard(Flashcard card)
		{
			if(cards == null)
			{
				cards = new List<Flashcard>();
			}

			cards.Add(card);
		}

		public Flashcard[] GetCards()
		{
			if (cards == null)
			{
				cards = new List<Flashcard>();
			}

			return cards.ToArray();
		}

		public string GetName()
		{
			return deckName;
		}

		public string GetDescription()
		{
			return deckDescription;
		}

		public int GetCount()
		{
			return cards.Count;
		}


	}
}
