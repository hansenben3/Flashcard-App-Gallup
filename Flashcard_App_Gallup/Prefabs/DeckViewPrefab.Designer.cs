
namespace Flashcard_App_Gallup.Prefabs
{
	partial class DeckViewPrefab
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
			this.lbl_front = new System.Windows.Forms.RichTextBox();
			this.lbl_back = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbl_front
			// 
			this.lbl_front.Enabled = false;
			this.lbl_front.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_front.Location = new System.Drawing.Point(5, 5);
			this.lbl_front.Name = "lbl_front";
			this.lbl_front.Size = new System.Drawing.Size(300, 100);
			this.lbl_front.TabIndex = 0;
			this.lbl_front.Text = "";
			// 
			// lbl_back
			// 
			this.lbl_back.Enabled = false;
			this.lbl_back.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_back.Location = new System.Drawing.Point(310, 5);
			this.lbl_back.Name = "lbl_back";
			this.lbl_back.Size = new System.Drawing.Size(300, 100);
			this.lbl_back.TabIndex = 1;
			this.lbl_back.Text = "";
			// 
			// DeckViewPrefab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbl_back);
			this.Controls.Add(this.lbl_front);
			this.Name = "DeckViewPrefab";
			this.Size = new System.Drawing.Size(615, 110);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox lbl_front;
		private System.Windows.Forms.RichTextBox lbl_back;
	}
}
