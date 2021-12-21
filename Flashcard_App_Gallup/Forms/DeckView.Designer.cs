
namespace Flashcard_App_Gallup.Forms
{
	partial class DeckView
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
			this.lbl_name = new System.Windows.Forms.Label();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_study = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_name.Location = new System.Drawing.Point(388, 9);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(88, 37);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Name";
			// 
			// btn_exit
			// 
			this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_exit.Location = new System.Drawing.Point(12, 9);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 48);
			this.btn_exit.TabIndex = 1;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			// 
			// btn_study
			// 
			this.btn_study.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_study.Location = new System.Drawing.Point(136, 60);
			this.btn_study.Name = "btn_study";
			this.btn_study.Size = new System.Drawing.Size(100, 35);
			this.btn_study.TabIndex = 2;
			this.btn_study.Text = "Study";
			this.btn_study.UseVisualStyleBackColor = true;
			// 
			// btn_edit
			// 
			this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_edit.Location = new System.Drawing.Point(388, 60);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(100, 35);
			this.btn_edit.TabIndex = 3;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = true;
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_delete.Location = new System.Drawing.Point(635, 60);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(100, 35);
			this.btn_delete.TabIndex = 4;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			// 
			// DeckView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 711);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_study);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.lbl_name);
			this.Name = "DeckView";
			this.Text = "DeckView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_study;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_delete;
	}
}