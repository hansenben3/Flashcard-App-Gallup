using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_App_Gallup
{
	/// <summary>
	/// This class Serializes and Deserializes the decks and cards...
	/// </summary>
	/// basic class that serializes and deserializes the decks so that the (Data) 
	/// class can save the data to a txt file
	/// converts all of the data to strings with specific separators
	/// separators at the moment are very simple and are (: ; ?) these would need to be 
	/// changed to something
	/// more specific in actual product due to (? : ;) not being able to be used in 
	/// the deck name descriptions
	/// or any of the cards;;;
	public static class CustomSerializer
	{

		public static string Serialize(Deck deck)
		{
			Flashcard[] cards = deck.GetCards();
			string[] arr = new string[deck.GetCards().Length];
			string serializedString1 = deck.GetName() + "<s>" + deck.GetDescription() + "<s>" + 
				deck.GetID().ToString() + "<s>" + cards.Length.ToString();
			if (deck.GetCards().Length != 0)
			{
				string serializedString2 = cards[0].GetFront() + "<s>" + cards[0].GetBack();
				for (int i = 1; i < cards.Length; i++)
				{
					serializedString2 += "<s>" + cards[i].GetFront() + "<s>" + cards[i].GetBack();
				}
				return serializedString1 + "<split>" + serializedString2;
			}
			else
			{
				return serializedString1 + "<split>";
			}
		}

		public static Deck Deserialize(string data)
		{
			string[] parts = data.Split("<split>");
			string[] part1 = parts[0].Split("<s>");
			string[] part2 = parts[1].Split("<s>");

			Deck deck = new Deck(part1[0], part1[1], int.Parse(part1[2]));
			for( int i = 0; i < int.Parse(part1[3]); i+=2)
			{
				deck.AddFlashcard(new Flashcard(part2[i], part2[i + 1]));
			}
			return deck;
		}
	}
}
