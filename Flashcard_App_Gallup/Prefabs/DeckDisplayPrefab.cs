using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Prefabs
{
	public partial class DeckDisplayPrefab : UserControl
	{
		List<DeckPrefab> displayedPrefabs;
		List<Deck> decks;
		public DeckDisplayPrefab(Deck[] decks)
		{
			InitializeComponent();
			if(decks.Length != 0)
			{		
				SetDecks(decks);
				DisplayPrefabs();
			}

		}

		private void DisplayPrefabs()
		{
			pnl_container.Height = decks.Count * 200; // 200 is the height of the DeckPrefab
			int[] heights = new int[decks.Count];
			heights[0] = 0;
			for ( int i = 0; i < decks.Count; i++)
			{
				if(i > 0)
				{
					heights[i] = heights[i - 1] += 200;
				}
				displayedPrefabs[i] = new DeckPrefab(decks[i]);
				this.pnl_container.Controls.Add(displayedPrefabs[i]);
				displayedPrefabs[i].Show();
				//displayedPrefabs[i].Height = heights[i];
			}
		}

		public void AddDeck(Deck deck)
		{
			decks.Add(deck);
		}

		private void SetDecks(Deck[] decks)
		{
			displayedPrefabs = new List<DeckPrefab>();
			for( int i = 0; i < decks.Length; i++)
			{
				AddDeck(decks[i]);
			}
		}
	}
}
