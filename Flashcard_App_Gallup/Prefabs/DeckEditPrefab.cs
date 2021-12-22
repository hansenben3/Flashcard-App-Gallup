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
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			//Deck d = Data.GetDeck(deck);
		}
	}
}
