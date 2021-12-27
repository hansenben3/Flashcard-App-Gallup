using Flashcard_App_Gallup.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Prefabs
{
	public partial class EditDisplayPrefab : UserControl
	{
		private Deck deck;
		private List<DeckEditPrefab> displayedPrefabs;
		private DeckEdit deckEdit;
		public EditDisplayPrefab(Deck d, DeckEdit de)
		{
			InitializeComponent();
			displayedPrefabs = new List<DeckEditPrefab>();
			deck = d;
			deckEdit = de;
			DisplayPrefabs();
		}

		public void DisplayPrefabs()
		{
			Flashcard[] cards = deck.GetCards();
			panel1.Height = cards.Length * 190; // 190 is the height of the DeckEditPrefab
			int height = 0;
			DeckEditPrefab[] notDisplayedPrefabs = new DeckEditPrefab[cards.Length];
			for ( int i = 0; i < cards.Length; i++)
			{
				if ( i > 0 )
				{
					height += 190; // 190 is the height of the DeckEditPrefab
				}

				notDisplayedPrefabs[i] = new DeckEditPrefab( deck, cards[i], deckEdit );
				displayedPrefabs.Add(notDisplayedPrefabs[i]);
				displayedPrefabs[i].Top = height;
				this.panel1.Controls.Add(displayedPrefabs[i]);
				displayedPrefabs[i].Show();
			}
		}

		public Deck GetDeck(string n, string d)
		{
			Deck newDeck = new Deck( n, d, deck.GetID() );
			for( int i = 0; i < displayedPrefabs.Count; i++)
			{
				newDeck.AddFlashcard(displayedPrefabs[i].GetCard());
			}
			return newDeck;
		}
	}
}
