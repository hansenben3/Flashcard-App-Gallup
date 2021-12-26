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
	public partial class DeckStudy : Form
	{
		private Deck deck;
		private StudyDeckPrefab display;
		private bool flipped;
		private int currentCard;
		public DeckStudy(Deck d)
		{
			InitializeComponent();
			deck = d;			
			flipped = false;
			currentCard = 0;
			InitView();

		}

		private void InitView()
		{
			lbl_cardct.Text = deck.GetCount().ToString();
			SetCard(deck.GetCards()[currentCard]);
		}



		private void SetCard(Flashcard c)
		{
			if(display != null)
			{
				display.Hide();
			}
			if (flipped)
			{
				lbl_side.Text = "Back";
			}
			else
			{
				lbl_side.Text = "Front";
			}
			lbl_currcard.Text = (currentCard + 1).ToString();
			display = new StudyDeckPrefab(c, flipped);
			panel1.Controls.Add(display);
			display.Show();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
			Data.home.CustomRefresh();
		}

		private void btn_next_Click(object sender, EventArgs e)
		{
			flipped = false;
			currentCard++;
			if(currentCard < deck.GetCount())
			{
				SetCard(deck.GetCards()[currentCard]);
			}
			else
			{
				currentCard = 0;
				SetCard(deck.GetCards()[currentCard]);
			}
		}

		private void btn_flip_Click(object sender, EventArgs e)
		{
			flipped = !flipped;
			SetCard(deck.GetCards()[currentCard]);
		}
	}
}
