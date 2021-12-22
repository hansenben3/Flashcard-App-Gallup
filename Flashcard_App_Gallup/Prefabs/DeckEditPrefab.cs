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
	public partial class DeckEditPrefab : UserControl
	{
		private Flashcard card;
		private Deck deck;
		public DeckEditPrefab(Deck d, Flashcard c)
		{
			InitializeComponent();
			deck = d;
			card = c;
			SetCard();
		}

		private void SetCard()
		{
			txt_back.Text = card.GetBack();
			txt_front.Text = card.GetFront();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			Deck before = deck;
			bool result = deck.DeleteCard(card);
			if (result)
			{
				Data.UpdateDeck(before, deck);

			}
			else
			{
				Data.SetError("Card was not deleted succesfully");
				ErrorPrompt err = new ErrorPrompt();
				err.Show();
			}
			
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			Flashcard newCard = new Flashcard(txt_front.Text, txt_back.Text);
			deck.UpdateCard(card, newCard);
			this.Refresh();
		}
	}
}
