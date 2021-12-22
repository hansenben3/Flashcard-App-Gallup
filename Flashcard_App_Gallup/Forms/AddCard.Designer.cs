
namespace Flashcard_App_Gallup.Forms
{
	partial class AddCard
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
			this.lbl_front = new System.Windows.Forms.Label();
			this.lbl_back = new System.Windows.Forms.Label();
			this.txt_front = new System.Windows.Forms.RichTextBox();
			this.txt_back = new System.Windows.Forms.RichTextBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_submit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_front
			// 
			this.lbl_front.AutoSize = true;
			this.lbl_front.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_front.Location = new System.Drawing.Point(142, 13);
			this.lbl_front.Name = "lbl_front";
			this.lbl_front.Size = new System.Drawing.Size(59, 28);
			this.lbl_front.TabIndex = 0;
			this.lbl_front.Text = "Front";
			// 
			// lbl_back
			// 
			this.lbl_back.AutoSize = true;
			this.lbl_back.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_back.Location = new System.Drawing.Point(570, 13);
			this.lbl_back.Name = "lbl_back";
			this.lbl_back.Size = new System.Drawing.Size(52, 28);
			this.lbl_back.TabIndex = 1;
			this.lbl_back.Text = "Back";
			// 
			// txt_front
			// 
			this.txt_front.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_front.Location = new System.Drawing.Point(26, 50);
			this.txt_front.Name = "txt_front";
			this.txt_front.Size = new System.Drawing.Size(300, 110);
			this.txt_front.TabIndex = 2;
			this.txt_front.Text = "";
			// 
			// txt_back
			// 
			this.txt_back.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_back.Location = new System.Drawing.Point(452, 50);
			this.txt_back.Name = "txt_back";
			this.txt_back.Size = new System.Drawing.Size(300, 110);
			this.txt_back.TabIndex = 3;
			this.txt_back.Text = "";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_cancel.Location = new System.Drawing.Point(226, 197);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(100, 40);
			this.btn_cancel.TabIndex = 4;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_submit
			// 
			this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_submit.Location = new System.Drawing.Point(452, 197);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(100, 40);
			this.btn_submit.TabIndex = 5;
			this.btn_submit.Text = "Submit";
			this.btn_submit.UseVisualStyleBackColor = true;
			this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// AddCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 268);
			this.Controls.Add(this.btn_submit);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.txt_back);
			this.Controls.Add(this.txt_front);
			this.Controls.Add(this.lbl_back);
			this.Controls.Add(this.lbl_front);
			this.Name = "AddCard";
			this.Text = "AddCard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_front;
		private System.Windows.Forms.Label lbl_back;
		private System.Windows.Forms.RichTextBox txt_front;
		private System.Windows.Forms.RichTextBox txt_back;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_submit;
	}
}