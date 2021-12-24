
namespace Flashcard_App_Gallup.Prefabs
{
	partial class StudyDeckPrefab
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_flip = new System.Windows.Forms.Button();
			this.btn_next = new System.Windows.Forms.Button();
			this.txt_cardtxt = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btn_flip
			// 
			this.btn_flip.Location = new System.Drawing.Point(70, 182);
			this.btn_flip.Name = "btn_flip";
			this.btn_flip.Size = new System.Drawing.Size(111, 42);
			this.btn_flip.TabIndex = 1;
			this.btn_flip.Text = "Flip";
			this.btn_flip.UseVisualStyleBackColor = true;
			// 
			// btn_next
			// 
			this.btn_next.Location = new System.Drawing.Point(396, 182);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(110, 42);
			this.btn_next.TabIndex = 2;
			this.btn_next.Text = "Next";
			this.btn_next.UseVisualStyleBackColor = true;
			// 
			// txt_cardtxt
			// 
			this.txt_cardtxt.DetectUrls = false;
			this.txt_cardtxt.Enabled = false;
			this.txt_cardtxt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_cardtxt.Location = new System.Drawing.Point(70, 30);
			this.txt_cardtxt.Name = "txt_cardtxt";
			this.txt_cardtxt.Size = new System.Drawing.Size(436, 123);
			this.txt_cardtxt.TabIndex = 3;
			this.txt_cardtxt.Text = "Card";
			// 
			// StudyDeckPrefab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txt_cardtxt);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.btn_flip);
			this.Name = "StudyDeckPrefab";
			this.Size = new System.Drawing.Size(600, 250);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_flip;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.RichTextBox txt_cardtxt;
	}
}
