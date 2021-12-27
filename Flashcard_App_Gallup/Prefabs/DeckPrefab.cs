using Flashcard_App_Gallup.Forms;
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
		private Form form;
		public DeckPrefab(Deck deck, Form f)
		{	
			InitializeComponent();
			this.form = f;
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
				ErrorPrompt err = new ErrorPrompt();
				err.Show();
			}
			else
			{
				Data.home.CustomRefresh();
			}
		}

		private void btn_view_Click(object sender, EventArgs e)
		{
			Data.home.Hide();
			Form form = new DeckView(deck);
			form.ShowDialog();
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			Data.home.Hide();
			Form form = new DeckEdit(deck);
			form.ShowDialog();
		}

		private void btn_study_Click(object sender, EventArgs e)
		{
			Data.home.Hide();
			Form form = new DeckStudy(deck);
			form.ShowDialog();
		}

		private void btn_addcard_Click(object sender, EventArgs e)
		{
			Form f = new AddCard(form, deck);
			f.ShowDialog();
		}
	}
}
