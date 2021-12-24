
namespace Flashcard_App_Gallup.Forms
{
	partial class DeckStudy
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_currcard = new System.Windows.Forms.Label();
			this.lbl_slash = new System.Windows.Forms.Label();
			this.lbl_cardct = new System.Windows.Forms.Label();
			this.btn_exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_currcard
			// 
			this.lbl_currcard.AutoSize = true;
			this.lbl_currcard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_currcard.Location = new System.Drawing.Point(379, 9);
			this.lbl_currcard.Name = "lbl_currcard";
			this.lbl_currcard.Size = new System.Drawing.Size(32, 37);
			this.lbl_currcard.TabIndex = 0;
			this.lbl_currcard.Text = "1";
			// 
			// lbl_slash
			// 
			this.lbl_slash.AutoSize = true;
			this.lbl_slash.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_slash.Location = new System.Drawing.Point(417, 9);
			this.lbl_slash.Name = "lbl_slash";
			this.lbl_slash.Size = new System.Drawing.Size(28, 37);
			this.lbl_slash.TabIndex = 1;
			this.lbl_slash.Text = "/";
			// 
			// lbl_cardct
			// 
			this.lbl_cardct.AutoSize = true;
			this.lbl_cardct.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_cardct.Location = new System.Drawing.Point(451, 9);
			this.lbl_cardct.Name = "lbl_cardct";
			this.lbl_cardct.Size = new System.Drawing.Size(32, 37);
			this.lbl_cardct.TabIndex = 2;
			this.lbl_cardct.Text = "5";
			// 
			// btn_exit
			// 
			this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_exit.Location = new System.Drawing.Point(13, 9);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 37);
			this.btn_exit.TabIndex = 3;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			// 
			// DeckStudy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 711);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.lbl_cardct);
			this.Controls.Add(this.lbl_slash);
			this.Controls.Add(this.lbl_currcard);
			this.Name = "DeckStudy";
			this.Text = "Flashcard App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_currcard;
		private System.Windows.Forms.Label lbl_slash;
		private System.Windows.Forms.Label lbl_cardct;
		private System.Windows.Forms.Button btn_exit;
	}
}