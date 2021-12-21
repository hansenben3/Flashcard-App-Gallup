using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Forms
{
	public partial class DeckView : Form
	{
		private Deck deck;

		public DeckView(Deck deck)
		{
			InitializeComponent();
			SetDeck(deck);
			InitView();
		}

		private void SetDeck(Deck deck)
		{
			this.deck = deck;
		}

		private void InitView()
		{

		}
	}
}
