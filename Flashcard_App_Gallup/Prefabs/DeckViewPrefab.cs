using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_App_Gallup.Prefabs
{
	public partial class DeckViewPrefab : UserControl
	{
		private Flashcard card;
		public DeckViewPrefab(Flashcard c)
		{
			InitializeComponent();
			card = c;
			lbl_front.Text = card.GetFront();
			lbl_back.Text = card.GetBack();
		}
	}
}
