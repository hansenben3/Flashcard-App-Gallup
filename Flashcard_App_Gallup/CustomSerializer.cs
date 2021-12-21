using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	public static class CustomSerializer
	{
		public static string Serialize(Deck deck)
		{
			Flashcard[] cards = deck.GetCards();
			string[] arr = new string[deck.GetCards().Length];
			string serializedString1 = deck.GetName() + ":" + deck.GetDescription() + ":" + cards.Length.ToString();
			if (deck.GetCards().Length != 0)
			{
				string serializedString2 = cards[0].GetFront() + ":" + cards[0].GetBack();
				for (int i = 1; i < cards.Length; i++)
				{
					serializedString2 += ":" + cards[i].GetFront() + ":" + cards[i].GetBack();
				}
				return serializedString1 + ";" + serializedString2;
			}
			else
			{
				return serializedString1 + ";";
			}
		}

		public static Deck Deserialize(string data)
		{
			string[] parts = data.Split(";");
			string[] part1 = parts[0].Split(":");
			string[] part2 = parts[1].Split(":");

			Deck deck = new Deck(part1[0], part1[1]);
			for( int i = 0; i < int.Parse(part1[2]); i+=2)
			{
				deck.AddFlashcard(new Flashcard(part2[i], part2[i + 1]));
			}
			return deck;
		}
	}
}
