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
		public DeckEdit(Deck d)
		{
			InitializeComponent();
			deck = d;
		}
	}
}
