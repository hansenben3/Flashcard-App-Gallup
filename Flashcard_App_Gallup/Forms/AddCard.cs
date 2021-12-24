using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Forms
{
	public partial class AddCard : Form
	{
		private Deck deck;
		private Form form;
		public AddCard(Form f, Deck d)
		{
			InitializeComponent();
			form = f;
			deck = d;
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			deck.AddFlashcard(new Flashcard(txt_front.Text, txt_back.Text));
			Data.UpdateDeck(deck);
			this.Close();
			form.Close();
			Data.home.CustomRefresh();
		}
	}
}
