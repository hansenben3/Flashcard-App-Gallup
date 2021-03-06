
namespace Flashcard_App_Gallup
{
	partial class DeckPrefab
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
			this.lbl_name = new System.Windows.Forms.Label();
			this.btn_view = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_study = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.lbl_description = new System.Windows.Forms.RichTextBox();
			this.btn_addcard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_name.Location = new System.Drawing.Point(30, 11);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(88, 37);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Name";
			// 
			// btn_view
			// 
			this.btn_view.Location = new System.Drawing.Point(498, 12);
			this.btn_view.Name = "btn_view";
			this.btn_view.Size = new System.Drawing.Size(116, 48);
			this.btn_view.TabIndex = 2;
			this.btn_view.Text = "View";
			this.btn_view.UseVisualStyleBackColor = true;
			this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(652, 12);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(116, 48);
			this.btn_edit.TabIndex = 3;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_study
			// 
			this.btn_study.Location = new System.Drawing.Point(652, 72);
			this.btn_study.Name = "btn_study";
			this.btn_study.Size = new System.Drawing.Size(116, 48);
			this.btn_study.TabIndex = 4;
			this.btn_study.Text = "Study";
			this.btn_study.UseVisualStyleBackColor = true;
			this.btn_study.Click += new System.EventHandler(this.btn_study_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(652, 132);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(116, 48);
			this.btn_delete.TabIndex = 5;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// lbl_description
			// 
			this.lbl_description.Enabled = false;
			this.lbl_description.Location = new System.Drawing.Point(25, 65);
			this.lbl_description.Name = "lbl_description";
			this.lbl_description.Size = new System.Drawing.Size(589, 115);
			this.lbl_description.TabIndex = 6;
			this.lbl_description.Text = "";
			// 
			// btn_addcard
			// 
			this.btn_addcard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_addcard.Location = new System.Drawing.Point(343, 12);
			this.btn_addcard.Name = "btn_addcard";
			this.btn_addcard.Size = new System.Drawing.Size(116, 48);
			this.btn_addcard.TabIndex = 7;
			this.btn_addcard.Text = "Add Card";
			this.btn_addcard.UseVisualStyleBackColor = true;
			this.btn_addcard.Click += new System.EventHandler(this.btn_addcard_Click);
			// 
			// DeckPrefab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.btn_addcard);
			this.Controls.Add(this.lbl_description);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_study);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_view);
			this.Controls.Add(this.lbl_name);
			this.Name = "DeckPrefab";
			this.Size = new System.Drawing.Size(800, 200);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Button btn_view;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_study;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.RichTextBox lbl_description;
		private System.Windows.Forms.Button btn_addcard;
	}
}
