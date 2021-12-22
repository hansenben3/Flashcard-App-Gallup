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

		}

		public Flashcard GetCard()
		{
			return new Flashcard(txt_front.Text, txt_back.Text);
		}
	}
}
