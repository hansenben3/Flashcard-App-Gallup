
namespace Flashcard_App_Gallup.Forms
{
	partial class ErrorPrompt
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
			this.btn_confirm = new System.Windows.Forms.Button();
			this.lbl_error = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btn_confirm
			// 
			this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_confirm.Location = new System.Drawing.Point(285, 319);
			this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_confirm.Name = "btn_confirm";
			this.btn_confirm.Size = new System.Drawing.Size(171, 77);
			this.btn_confirm.TabIndex = 0;
			this.btn_confirm.Text = "Confirm";
			this.btn_confirm.UseVisualStyleBackColor = true;
			this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
			// 
			// lbl_error
			// 
			this.lbl_error.Enabled = false;
			this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_error.Location = new System.Drawing.Point(14, 17);
			this.lbl_error.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lbl_error.Name = "lbl_error";
			this.lbl_error.Size = new System.Drawing.Size(719, 271);
			this.lbl_error.TabIndex = 1;
			this.lbl_error.Text = "This is where the error goes...";
			// 
			// ErrorPrompt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 428);
			this.Controls.Add(this.lbl_error);
			this.Controls.Add(this.btn_confirm);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ErrorPrompt";
			this.Text = "ErrorPrompt";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_confirm;
		private System.Windows.Forms.RichTextBox lbl_error;
	}
}