namespace CardMakerForms
{
	partial class FormGame
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
			this.pnlApplyCancel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlCard = new System.Windows.Forms.Panel();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnPickCard = new System.Windows.Forms.Button();
			this.lblStackSize = new System.Windows.Forms.Label();
			this.pnlApplyCancel.SuspendLayout();
			this.pnlCard.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlApplyCancel
			// 
			this.pnlApplyCancel.Controls.Add(this.btnCancel);
			this.pnlApplyCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlApplyCancel.Location = new System.Drawing.Point(30, 381);
			this.pnlApplyCancel.Name = "pnlApplyCancel";
			this.pnlApplyCancel.Size = new System.Drawing.Size(274, 50);
			this.pnlApplyCancel.TabIndex = 14;
			// 
			// btnCancel
			// 
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnCancel.Location = new System.Drawing.Point(0, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(274, 40);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Hauptmenü";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlCard
			// 
			this.pnlCard.Controls.Add(this.lblDescription);
			this.pnlCard.Controls.Add(this.lblName);
			this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCard.Location = new System.Drawing.Point(30, 30);
			this.pnlCard.Name = "pnlCard";
			this.pnlCard.Size = new System.Drawing.Size(274, 271);
			this.pnlCard.TabIndex = 15;
			this.pnlCard.Visible = false;
			// 
			// lblDescription
			// 
			this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDescription.Location = new System.Drawing.Point(0, 40);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(274, 231);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblName
			// 
			this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblName.Location = new System.Drawing.Point(0, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(274, 40);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnPickCard
			// 
			this.btnPickCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnPickCard.Location = new System.Drawing.Point(30, 341);
			this.btnPickCard.Name = "btnPickCard";
			this.btnPickCard.Size = new System.Drawing.Size(274, 40);
			this.btnPickCard.TabIndex = 3;
			this.btnPickCard.Text = "Karte ziehen";
			this.btnPickCard.UseVisualStyleBackColor = true;
			this.btnPickCard.Click += new System.EventHandler(this.btnPickCard_Click);
			// 
			// lblStackSize
			// 
			this.lblStackSize.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblStackSize.Location = new System.Drawing.Point(30, 301);
			this.lblStackSize.Name = "lblStackSize";
			this.lblStackSize.Size = new System.Drawing.Size(274, 40);
			this.lblStackSize.TabIndex = 16;
			this.lblStackSize.Text = "Karten im Stapel: 0";
			this.lblStackSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.pnlCard);
			this.Controls.Add(this.lblStackSize);
			this.Controls.Add(this.btnPickCard);
			this.Controls.Add(this.pnlApplyCancel);
			this.Name = "FormGame";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "FormGame";
			this.Load += new System.EventHandler(this.FormGame_Load);
			this.pnlApplyCancel.ResumeLayout(false);
			this.pnlCard.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlApplyCancel;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlCard;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnPickCard;
		private System.Windows.Forms.Label lblStackSize;
	}
}