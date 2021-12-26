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
		public DeckStudy(Deck d)
		{
			InitializeComponent();
			deck = d;
			InitView();
		}

		private void InitView()
		{

		}

	}
}
