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
		public DeckPrefab(Deck deck)
		{
			InitializeComponent();
			SetDeck(deck);
		}

		private void SetDeck(Deck deck)
		{
			lbl_name.Text = deck.GetName();
			lbl_description.Text = deck.GetDescription();
		}

	}
}
