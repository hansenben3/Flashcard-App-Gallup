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

		public static void SaveData()
		{
			if(decks.Count != 0)
			{
				string toBeSaved = CustomSerializer.Serialize(decks[0]);
				for ( int i = 1; i < decks.Count; i++)
				{
					toBeSaved += "?" + CustomSerializer.Serialize(decks[i]);
				}
				SaveManager.SaveData(toBeSaved);
			}
		}

		public static void LoadData()
		{
			string returnedString = SaveManager.LoadData();
			decks = new List<Deck>();
			if(returnedString != null)
			{
				string[] arr = returnedString.Split("?");
				for (int i = 0; i < arr.Length; i++)
				{
					decks.Add(CustomSerializer.Deserialize(arr[i]));
				}
			}
		}

	}
}
