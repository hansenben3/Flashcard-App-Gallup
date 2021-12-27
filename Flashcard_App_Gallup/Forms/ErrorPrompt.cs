using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Forms
{
	public partial class ErrorPrompt : Form
	{
		public ErrorPrompt()
		{
			InitializeComponent();
			SetError();
		}

		private void SetError()
		{
			lbl_error.Text = Data.GetError();
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			this.Close();
			Data.SetError(null);
			Data.home.CustomRefresh();
		}
	}
}
