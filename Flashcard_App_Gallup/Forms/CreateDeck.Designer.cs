
namespace Flashcard_App_Gallup.Forms
{
	partial class CreateDeck
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
			this.lbl_createDeck = new System.Windows.Forms.Label();
			this.lbl_name = new System.Windows.Forms.Label();
			this.lbl_description = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_submit = new System.Windows.Forms.Button();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_description = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbl_createDeck
			// 
			this.lbl_createDeck.AutoSize = true;
			this.lbl_createDeck.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_createDeck.Location = new System.Drawing.Point(266, 9);
			this.lbl_createDeck.Name = "lbl_createDeck";
			this.lbl_createDeck.Size = new System.Drawing.Size(316, 72);
			this.lbl_createDeck.TabIndex = 0;
			this.lbl_createDeck.Text = "Create Deck";
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_name.Location = new System.Drawing.Point(266, 104);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(88, 37);
			this.lbl_name.TabIndex = 1;
			this.lbl_name.Text = "Name";
			// 
			// lbl_description
			// 
			this.lbl_description.AutoSize = true;
			this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_description.Location = new System.Drawing.Point(266, 207);
			this.lbl_description.Name = "lbl_description";
			this.lbl_description.Size = new System.Drawing.Size(152, 37);
			this.lbl_description.TabIndex = 2;
			this.lbl_description.Text = "Description";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_cancel.Location = new System.Drawing.Point(266, 430);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(117, 48);
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_submit
			// 
			this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_submit.Location = new System.Drawing.Point(455, 430);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(127, 48);
			this.btn_submit.TabIndex = 4;
			this.btn_submit.Text = "Submit";
			this.btn_submit.UseVisualStyleBackColor = true;
			this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// txt_name
			// 
			this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_name.Location = new System.Drawing.Point(266, 153);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(316, 34);
			this.txt_name.TabIndex = 5;
			// 
			// txt_description
			// 
			this.txt_description.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_description.Location = new System.Drawing.Point(266, 267);
			this.txt_description.Name = "txt_description";
			this.txt_description.Size = new System.Drawing.Size(316, 126);
			this.txt_description.TabIndex = 7;
			this.txt_description.Text = "";
			// 
			// CreateDeck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(893, 584);
			this.Controls.Add(this.txt_description);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.btn_submit);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.lbl_description);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.lbl_createDeck);
			this.Name = "CreateDeck";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_createDeck;
		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Label lbl_description;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_submit;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.RichTextBox txt_description;
	}
}