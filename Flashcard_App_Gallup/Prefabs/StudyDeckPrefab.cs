using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Prefabs
{
	public partial class StudyDeckPrefab : UserControl
	{
		private Flashcard card;
		private bool flipped;
		public StudyDeckPrefab(Flashcard c, bool f)
		{
			InitializeComponent();
			card = c;
			flipped = f;
			InitView();
		}

		private void InitView()
		{
			if (flipped)
			{
				txt_cardtxt.Text = card.GetBack();
			}
			else
			{
				txt_cardtxt.Text = card.GetFront();
			}
		}
	}
}
