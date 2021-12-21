using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup
{
	public partial class DeckPrefab : UserControl
	{
		private Deck deck;
		public DeckPrefab(Deck deck)
		{
			InitializeComponent();
			SetDeck(deck);
		}

		private void SetDeck(Deck deck)
		{
			this.deck = deck;
			lbl_name.Text = deck.GetName();
			lbl_description.Text = deck.GetDescription();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			bool result = Data.RemoveDeck(deck);
			if (!result)
			{
				Data.SetError("Deck was not removed successfully : " + deck.GetName() );
			}
		}
	}
}
