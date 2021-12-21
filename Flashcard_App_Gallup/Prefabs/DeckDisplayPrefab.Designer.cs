
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
			this.pnl_container = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// pnl_container
			// 
			this.pnl_container.AutoScroll = true;
			this.pnl_container.AutoSize = true;
			this.pnl_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.pnl_container.Location = new System.Drawing.Point(25, 25);
			this.pnl_container.Name = "pnl_container";
			this.pnl_container.Size = new System.Drawing.Size(850, 450);
			this.pnl_container.TabIndex = 1;
			this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_container_Paint);
			// 
			// DeckDisplayPrefab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.pnl_container);
			this.Name = "DeckDisplayPrefab";
			this.Size = new System.Drawing.Size(900, 500);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel pnl_container;
	}
}
