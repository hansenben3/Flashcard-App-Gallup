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
		public CreateDeck()
		{
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
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

		private void btn_submit_Click(object sender, EventArgs e)
		{
			Data.AddDeck(new Deck(txt_name.Text, txt_description.Text));
			Data.SaveData();
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
	}
}
