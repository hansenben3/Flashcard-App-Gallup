
namespace Flashcard_App_Gallup
{
	partial class Home
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_title = new System.Windows.Forms.Label();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_createDeck = new System.Windows.Forms.Button();
			this.lbl_decks = new System.Windows.Forms.Label();
			this.pnl_decklist = new System.Windows.Forms.Panel();
			this.lbl_deckcount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_title
			// 
			this.lbl_title.AutoSize = true;
			this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_title.Location = new System.Drawing.Point(280, 4);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(367, 72);
			this.lbl_title.TabIndex = 0;
			this.lbl_title.Text = "Flashcard App";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_exit
			// 
			this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_exit.Location = new System.Drawing.Point(12, 12);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(101, 37);
			this.btn_exit.TabIndex = 1;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// btn_createDeck
			// 
			this.btn_createDeck.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_createDeck.Location = new System.Drawing.Point(368, 79);
			this.btn_createDeck.Name = "btn_createDeck";
			this.btn_createDeck.Size = new System.Drawing.Size(168, 64);
			this.btn_createDeck.TabIndex = 2;
			this.btn_createDeck.Text = "Create Deck";
			this.btn_createDeck.UseVisualStyleBackColor = true;
			this.btn_createDeck.Click += new System.EventHandler(this.btn_createDeck_Click);
			// 
			// lbl_decks
			// 
			this.lbl_decks.AutoSize = true;
			this.lbl_decks.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_decks.Location = new System.Drawing.Point(12, 154);
			this.lbl_decks.Name = "lbl_decks";
			this.lbl_decks.Size = new System.Drawing.Size(86, 37);
			this.lbl_decks.TabIndex = 4;
			this.lbl_decks.Text = "Decks";
			// 
			// pnl_decklist
			// 
			this.pnl_decklist.AutoScroll = true;
			this.pnl_decklist.AutoSize = true;
			this.pnl_decklist.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pnl_decklist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnl_decklist.Location = new System.Drawing.Point(10, 200);
			this.pnl_decklist.Name = "pnl_decklist";
			this.pnl_decklist.Size = new System.Drawing.Size(870, 500);
			this.pnl_decklist.TabIndex = 5;
			// 
			// lbl_deckcount
			// 
			this.lbl_deckcount.AutoSize = true;
			this.lbl_deckcount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_deckcount.Location = new System.Drawing.Point(673, 79);
			this.lbl_deckcount.Name = "lbl_deckcount";
			this.lbl_deckcount.Size = new System.Drawing.Size(122, 28);
			this.lbl_deckcount.TabIndex = 6;
			this.lbl_deckcount.Text = "Deck Count :";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 711);
			this.Controls.Add(this.lbl_deckcount);
			this.Controls.Add(this.pnl_decklist);
			this.Controls.Add(this.lbl_decks);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.btn_createDeck);
			this.Name = "Home";
			this.Text = "Flashcard App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_createDeck;
		private System.Windows.Forms.Label lbl_decks;
		private System.Windows.Forms.Panel pnl_decklist;
		private System.Windows.Forms.Label lbl_deckcount;
	}
}

