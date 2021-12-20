using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public static class Data
	{

		private static List<Deck> decks;
		private static string error;

		public static Deck[] GetDecks()
		{
			return decks.ToArray();
		}

		public static void AddDeck(Deck deck)
		{
			decks.Add(deck);
		}

		public static bool RemoveDeck(Deck deck)
		{
			if (decks.Contains(deck))
			{
				decks.Remove(deck);
				return true;
			}
			else
			{
				return false;
			}
		}

		public static void SetError(string newError)
		{
			error = newError;
		}

		public static string GetError()
		{
			return error;
		}


		// Save system to be implimented
		public static void SaveData()
		{

		}

		public static void LoadData()
		{
			decks = new List<Deck>();
		}

		// Save system to be implimented
	}
}
