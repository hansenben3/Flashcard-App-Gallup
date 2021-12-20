
namespace Flashcard_App_Gallup.Prefabs
{
	partial class DeckDisplayPrefab
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
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.pnl_container = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(883, 25);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 450);
			this.vScrollBar1.TabIndex = 0;
			// 
			// pnl_container
			// 
			this.pnl_container.Location = new System.Drawing.Point(25, 25);
			this.pnl_container.Name = "pnl_container";
			this.pnl_container.Size = new System.Drawing.Size(850, 450);
			this.pnl_container.TabIndex = 1;
			// 
			// DisplayPrefab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.pnl_container);
			this.Name = "DisplayPrefab";
			this.Size = new System.Drawing.Size(900, 500);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.Panel pnl_container;
	}
}
