using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public static class Data
	{
		private static int idCount = 0;
		public static Home home;
		private static List<Deck> decks;
		private static string error;

		public static Deck[] GetDecks()
		{
			if(decks != null)
			{
				return decks.ToArray();
			}
			else
			{
				return new Deck[0];
			}
			
		}

		public static void AddDeck(Deck deck)
		{
			if(decks != null)
			{
				decks.Add(deck);
				SaveData();
			}
			else
			{
				decks = new List<Deck>();
				decks.Add(deck);
				SaveData();
			}

		}

		public static bool RemoveDeck(Deck deck)
		{
			if (decks.Contains(deck))
			{
				decks.Remove(deck);
				SaveData();
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

		public static void SaveData()
		{
			SaveManager.SaveData(decks.ToArray());
		}

		public static void LoadData()
		{
			Deck[] dks = SaveManager.LoadData();
			decks = new List<Deck>();
			if(dks != null)
			{
				for(int i = 0; i < dks.Length; i++)
				{
					decks.Add(dks[i]);
				}
			}
		}

		public static void UpdateDeck( Deck newDeck)
		{
			Deck toRemove = null;
			decks.ForEach((deck) => 
			{
				if(deck.GetID() == newDeck.GetID())
				{
					toRemove = deck;
				}
			});
			if(toRemove != null)
			{
				decks.Remove(toRemove);
				decks.Add(newDeck);
				SaveData();
			}		}

		public static int GetNextID()
		{
			return idCount++;
		}

	}
}
