using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Forms
{
	public partial class CreateDeck : Form
	{
		private Home home;
		public CreateDeck(Home home)
		{
			this.home = home;
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
			if(home == null)
			{
				home = new Home();
				home.Show();
			}
			else
			{
				home.Show();
			}
			
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			Data.AddDeck(new Deck(lbl_name.Text, lbl_description.Text));
			Data.SaveData();
			this.Close();
			if (home == null)
			{
				home = new Home();
				home.Show();
			}
			else
			{
				home.Show();
			}
		}
	}
}
