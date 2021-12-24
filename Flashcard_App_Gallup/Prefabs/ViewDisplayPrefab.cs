using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Prefabs
{
	public partial class ViewDisplayPrefab : UserControl
	{
		List<DeckViewPrefab> displayedPrefabs;
		Deck deck;

		public ViewDisplayPrefab(Deck d)
		{
			InitializeComponent();
			deck = d;
			displayedPrefabs = new List<DeckViewPrefab>();
			DisplayPrefabs();
		}

		private void DisplayPrefabs()
		{
			Flashcard[] cards = deck.GetCards();
			int height = 0;
			panel1.Height = cards.Length * 150; // 150 is the height of the DeckViewPrefab
			DeckViewPrefab[] notDisplayedPrefabs = new DeckViewPrefab[cards.Length];
			for( int i = 0; i < notDisplayedPrefabs.Length; i++)
			{
				if(i > 0)
				{
					height += 150; // 150 is the height of the DeckViewPrefab
				}

				notDisplayedPrefabs[i] = new DeckViewPrefab(cards[i]);
				displayedPrefabs.Add(notDisplayedPrefabs[i]);
				displayedPrefabs[i].Top = height;
				this.panel1.Controls.Add(displayedPrefabs[i]);
				displayedPrefabs[i].Show();
			}
		}
	}
}
