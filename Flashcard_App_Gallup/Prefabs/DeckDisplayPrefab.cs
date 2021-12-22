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
				this.decks = new List<Deck>();
				this.displayedPrefabs = new List<DeckPrefab>();
				SetDecks(decks);
				DisplayPrefabs();
			}

		}

		private void DisplayPrefabs()
		{
			pnl_container.Height = decks.Count * 190; // 190 is the height of the DeckPrefab
			int height = 0;
			DeckPrefab[] notDisplayedPrefabs = new DeckPrefab[decks.Count];
			for ( int i = 0; i < notDisplayedPrefabs.Length; i++)
			{
				if(i > 0)
				{
					height += 190; // 190 is the height of the DeckPrefab
				}

				notDisplayedPrefabs[i] = new DeckPrefab(decks[i]);
				displayedPrefabs.Add(notDisplayedPrefabs[i]);
				displayedPrefabs[i].Top = height;
				this.pnl_container.Controls.Add(displayedPrefabs[i]);
				displayedPrefabs[i].Show();
			}
		}

		private void SetDecks(Deck[] decks)
		{
			for( int i = 0; i < decks.Length; i++)
			{
				this.decks.Add(decks[i]);
			}
		}

		private void pnl_container_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
