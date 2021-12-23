using Flashcard_App_Gallup.Forms;
using Flashcard_App_Gallup.Prefabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_App_Gallup
{
	public partial class Home : Form
	{
		private DeckDisplayPrefab display;
		public Home()
		{
			InitializeComponent();
			Data.home = this;
			CustomRefresh();
		}

		private void btn_createDeck_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form form = new CreateDeck();
			form.ShowDialog();
		}

		public void CustomRefresh()
		{
			if(display != null)
			{
				this.display.Hide();
			}
			this.lbl_deckcount.Text = "Deck Count : " + Data.GetDecks().Length;
			if (!this.Visible)
			{
				this.Show();
			}
			display = new DeckDisplayPrefab(Data.GetDecks()) {Dock = DockStyle.Fill};
			this.pnl_decklist.Controls.Add(display);
			this.display.Show();

		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void CreateError()
		{
			Form form = new ErrorPrompt();
			form.ShowDialog();
		}
	}
}
