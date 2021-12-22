using Flashcard_App_Gallup.Prefabs;
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
		private ViewDisplayPrefab display;

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
			display = new ViewDisplayPrefab(deck) { Dock = DockStyle.Fill };
			lbl_name.Text = deck.GetName();
			this.pnl_container.Controls.Add(display);
			this.display.Show();
			lbl_cardcount.Text = "Card Count: " + deck.GetCount().ToString();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
			if (Data.home == null)
			{
				Data.home = new Home();
				Data.home.CustomRefresh();
			}
			else
			{
				Data.home.CustomRefresh();
			}
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			this.Close();
			Form form = new DeckEdit(deck);
			form.ShowDialog();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			bool result = Data.RemoveDeck(deck);
			if (!result)
			{
				Data.SetError("Deck was not removed successfully : " + deck.GetName());
				ErrorPrompt err = new ErrorPrompt();
				err.Show();
			}
			else
			{
				Data.home.CustomRefresh();
			}
		}
	}
}
