
namespace Flashcard_App_Gallup.Prefabs
{
	partial class DeckEditPrefab
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
			this.txt_front = new System.Windows.Forms.RichTextBox();
			this.txt_back = new System.Windows.Forms.RichTextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_front
			// 
			this.txt_front.Location = new System.Drawing.Point(5, 5);
			this.txt_front.Name = "txt_front";
			this.txt_front.Size = new System.Drawing.Size(300, 100);
			this.txt_front.TabIndex = 0;
			this.txt_front.Text = "";
			// 
			// txt_back
			// 
			this.txt_back.Location = new System.Drawing.Point(310, 5);
			this.txt_back.Name = "txt_back";
			this.txt_back.Size = new System.Drawing.Size(300, 100);
			this.txt_back.TabIndex = 1;
			this.txt_back.Text = "";
			// 
			// btn_save
			// 
			this.btn_save.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_save.Location = new System.Drawing.Point(650, 15);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(100, 35);
			this.btn_save.TabIndex = 2;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_delete.Location = new System.Drawing.Point(650, 60);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(100, 35);
			this.btn_delete.TabIndex = 3;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// DeckEditPrefab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.txt_back);
			this.Controls.Add(this.txt_front);
			this.Name = "DeckEditPrefab";
			this.Size = new System.Drawing.Size(800, 110);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txt_front;
		private System.Windows.Forms.RichTextBox txt_back;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_delete;
	}
}
