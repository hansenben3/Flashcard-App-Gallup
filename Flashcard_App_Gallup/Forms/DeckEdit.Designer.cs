
namespace Flashcard_App_Gallup.Forms
{
	partial class DeckEdit
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
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_description = new System.Windows.Forms.RichTextBox();
			this.lbl_name = new System.Windows.Forms.Label();
			this.lbl_description = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_addcard = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_name
			// 
			this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_name.Location = new System.Drawing.Point(268, 90);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(207, 34);
			this.txt_name.TabIndex = 0;
			this.txt_name.Text = "Deck Name";
			this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_description
			// 
			this.txt_description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_description.Location = new System.Drawing.Point(481, 44);
			this.txt_description.Name = "txt_description";
			this.txt_description.Size = new System.Drawing.Size(391, 96);
			this.txt_description.TabIndex = 1;
			this.txt_description.Text = "Description";
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_name.Location = new System.Drawing.Point(312, 48);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(112, 28);
			this.lbl_name.TabIndex = 2;
			this.lbl_name.Text = "Deck Name";
			// 
			// lbl_description
			// 
			this.lbl_description.AutoSize = true;
			this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_description.Location = new System.Drawing.Point(528, 15);
			this.lbl_description.Name = "lbl_description";
			this.lbl_description.Size = new System.Drawing.Size(112, 28);
			this.lbl_description.TabIndex = 3;
			this.lbl_description.Text = "Description";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 150);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(860, 550);
			this.panel1.TabIndex = 4;
			// 
			// btn_exit
			// 
			this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_exit.Location = new System.Drawing.Point(2, 7);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(110, 35);
			this.btn_exit.TabIndex = 5;
			this.btn_exit.Text = "Cancel";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// btn_addcard
			// 
			this.btn_addcard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_addcard.Location = new System.Drawing.Point(45, 77);
			this.btn_addcard.Name = "btn_addcard";
			this.btn_addcard.Size = new System.Drawing.Size(145, 36);
			this.btn_addcard.TabIndex = 6;
			this.btn_addcard.Text = "Add Card";
			this.btn_addcard.UseVisualStyleBackColor = true;
			this.btn_addcard.Click += new System.EventHandler(this.btn_addcard_Click);
			// 
			// btn_save
			// 
			this.btn_save.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_save.Location = new System.Drawing.Point(126, 7);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(110, 35);
			this.btn_save.TabIndex = 7;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// DeckEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 711);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_addcard);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbl_description);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.txt_description);
			this.Controls.Add(this.txt_name);
			this.Name = "DeckEdit";
			this.Text = "Flashcard App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.RichTextBox txt_description;
		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Label lbl_description;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_addcard;
		private System.Windows.Forms.Button btn_save;
	}
}