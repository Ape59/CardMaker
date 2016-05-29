namespace CardMakerForms
{
	partial class FormMenu
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
			this.btnCards = new System.Windows.Forms.Button();
			this.btnDecks = new System.Windows.Forms.Button();
			this.btnGame = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCards
			// 
			this.btnCards.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCards.Location = new System.Drawing.Point(30, 110);
			this.btnCards.Name = "btnCards";
			this.btnCards.Size = new System.Drawing.Size(274, 40);
			this.btnCards.TabIndex = 2;
			this.btnCards.Text = "Karten";
			this.btnCards.UseVisualStyleBackColor = true;
			this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
			// 
			// btnDecks
			// 
			this.btnDecks.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDecks.Location = new System.Drawing.Point(30, 70);
			this.btnDecks.Name = "btnDecks";
			this.btnDecks.Size = new System.Drawing.Size(274, 40);
			this.btnDecks.TabIndex = 1;
			this.btnDecks.Text = "Decks";
			this.btnDecks.UseVisualStyleBackColor = true;
			this.btnDecks.Click += new System.EventHandler(this.btnDecks_Click);
			// 
			// btnGame
			// 
			this.btnGame.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnGame.Location = new System.Drawing.Point(30, 30);
			this.btnGame.Name = "btnGame";
			this.btnGame.Size = new System.Drawing.Size(274, 40);
			this.btnGame.TabIndex = 0;
			this.btnGame.Text = "Spielen";
			this.btnGame.UseVisualStyleBackColor = true;
			this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.btnCards);
			this.Controls.Add(this.btnDecks);
			this.Controls.Add(this.btnGame);
			this.Name = "FormMenu";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "FormMenu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCards;
		private System.Windows.Forms.Button btnDecks;
		private System.Windows.Forms.Button btnGame;
	}
}