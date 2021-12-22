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
	public partial class DeckEdit : Form
	{
		private Deck deck;
		private EditDisplayPrefab display;
		public DeckEdit(Deck d)
		{
			InitializeComponent();
			deck = d;
			InitView();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
			if(Data.home == null)
			{
				Data.home = new Home();
				Data.home.CustomRefresh();
			}
			else
			{
				Data.home.CustomRefresh();
			}
		}

		private void btn_addcard_Click(object sender, EventArgs e)
		{
			Form form = new AddCard(this, deck);
			form.ShowDialog();
		}

		private void InitView()
		{
			display = new EditDisplayPrefab(deck) { Dock = DockStyle.Fill };
			lbl_name.Text = deck.GetName();
			this.panel1.Controls.Add(display);
			this.display.Show();
		}
	}
}
