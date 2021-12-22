using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public class Deck
	{
		private int deckId;
		private string deckName;
		private string deckDescription;
		private List<Flashcard> cards;

		public Deck(string name, string description)
		{
			deckId = Data.GetNextID();
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

		public bool DeleteCard(Flashcard card)
		{
			cards.Remove(card);
			return cards.Contains(card);
		}

		public void UpdateCard(Flashcard c, Flashcard newCard)
		{
			Deck before = this;

			cards.ForEach((card) =>
			{
				if(card == c)
				{
					card = newCard;
				}
			});

			Data.UpdateDeck(before, this);
		}


	}
}
