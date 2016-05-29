namespace CardMakerForms
{
	partial class FormCards
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
			this.btnAddCard = new System.Windows.Forms.Button();
			this.cmbGroup = new System.Windows.Forms.ComboBox();
			this.pnlGroup = new System.Windows.Forms.Panel();
			this.lblGroup = new System.Windows.Forms.Label();
			this.btnRemoveCard = new System.Windows.Forms.Button();
			this.btnEditCard = new System.Windows.Forms.Button();
			this.pnlCards = new System.Windows.Forms.Panel();
			this.dgvCards = new System.Windows.Forms.DataGridView();
			this.clmCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblCards = new System.Windows.Forms.Label();
			this.pnlApplyCancel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlGroup.SuspendLayout();
			this.pnlCards.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
			this.pnlApplyCancel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddCard
			// 
			this.btnAddCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAddCard.Location = new System.Drawing.Point(30, 261);
			this.btnAddCard.Name = "btnAddCard";
			this.btnAddCard.Size = new System.Drawing.Size(274, 40);
			this.btnAddCard.TabIndex = 1;
			this.btnAddCard.Text = "Karte hinzufügen";
			this.btnAddCard.UseVisualStyleBackColor = true;
			this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
			// 
			// cmbGroup
			// 
			this.cmbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.Location = new System.Drawing.Point(0, 13);
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.Size = new System.Drawing.Size(274, 21);
			this.cmbGroup.TabIndex = 2;
			this.cmbGroup.TextChanged += new System.EventHandler(this.cmbGroup_TextChanged);
			// 
			// pnlGroup
			// 
			this.pnlGroup.Controls.Add(this.cmbGroup);
			this.pnlGroup.Controls.Add(this.lblGroup);
			this.pnlGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlGroup.Location = new System.Drawing.Point(30, 30);
			this.pnlGroup.Name = "pnlGroup";
			this.pnlGroup.Size = new System.Drawing.Size(274, 40);
			this.pnlGroup.TabIndex = 3;
			// 
			// lblGroup
			// 
			this.lblGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblGroup.Location = new System.Drawing.Point(0, 0);
			this.lblGroup.Name = "lblGroup";
			this.lblGroup.Size = new System.Drawing.Size(274, 13);
			this.lblGroup.TabIndex = 3;
			this.lblGroup.Text = "Gruppe";
			this.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnRemoveCard
			// 
			this.btnRemoveCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnRemoveCard.Location = new System.Drawing.Point(30, 341);
			this.btnRemoveCard.Name = "btnRemoveCard";
			this.btnRemoveCard.Size = new System.Drawing.Size(274, 40);
			this.btnRemoveCard.TabIndex = 5;
			this.btnRemoveCard.Text = "Karte löschen";
			this.btnRemoveCard.UseVisualStyleBackColor = true;
			this.btnRemoveCard.Click += new System.EventHandler(this.btnRemoveCard_Click);
			// 
			// btnEditCard
			// 
			this.btnEditCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnEditCard.Location = new System.Drawing.Point(30, 301);
			this.btnEditCard.Name = "btnEditCard";
			this.btnEditCard.Size = new System.Drawing.Size(274, 40);
			this.btnEditCard.TabIndex = 6;
			this.btnEditCard.Text = "Karte bearbeiten";
			this.btnEditCard.UseVisualStyleBackColor = true;
			this.btnEditCard.Click += new System.EventHandler(this.btnEditCard_Click);
			// 
			// pnlCards
			// 
			this.pnlCards.Controls.Add(this.dgvCards);
			this.pnlCards.Controls.Add(this.lblCards);
			this.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCards.Location = new System.Drawing.Point(30, 70);
			this.pnlCards.Name = "pnlCards";
			this.pnlCards.Size = new System.Drawing.Size(274, 191);
			this.pnlCards.TabIndex = 7;
			// 
			// dgvCards
			// 
			this.dgvCards.AllowUserToAddRows = false;
			this.dgvCards.AllowUserToDeleteRows = false;
			this.dgvCards.AllowUserToResizeColumns = false;
			this.dgvCards.AllowUserToResizeRows = false;
			this.dgvCards.BackgroundColor = System.Drawing.Color.White;
			this.dgvCards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCards.ColumnHeadersVisible = false;
			this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCardName});
			this.dgvCards.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCards.Location = new System.Drawing.Point(0, 13);
			this.dgvCards.MultiSelect = false;
			this.dgvCards.Name = "dgvCards";
			this.dgvCards.ReadOnly = true;
			this.dgvCards.RowHeadersVisible = false;
			this.dgvCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCards.Size = new System.Drawing.Size(274, 178);
			this.dgvCards.TabIndex = 8;
			this.dgvCards.SelectionChanged += new System.EventHandler(this.dgvCards_SelectionChanged);
			// 
			// clmCardName
			// 
			this.clmCardName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmCardName.HeaderText = "Name";
			this.clmCardName.Name = "clmCardName";
			this.clmCardName.ReadOnly = true;
			// 
			// lblCards
			// 
			this.lblCards.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblCards.Location = new System.Drawing.Point(0, 0);
			this.lblCards.Name = "lblCards";
			this.lblCards.Size = new System.Drawing.Size(274, 13);
			this.lblCards.TabIndex = 5;
			this.lblCards.Text = "Karten";
			this.lblCards.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnlApplyCancel
			// 
			this.pnlApplyCancel.Controls.Add(this.btnCancel);
			this.pnlApplyCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlApplyCancel.Location = new System.Drawing.Point(30, 381);
			this.pnlApplyCancel.Name = "pnlApplyCancel";
			this.pnlApplyCancel.Size = new System.Drawing.Size(274, 50);
			this.pnlApplyCancel.TabIndex = 12;
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
			// FormCards
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.pnlCards);
			this.Controls.Add(this.btnAddCard);
			this.Controls.Add(this.btnEditCard);
			this.Controls.Add(this.btnRemoveCard);
			this.Controls.Add(this.pnlGroup);
			this.Controls.Add(this.pnlApplyCancel);
			this.Name = "FormCards";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "FormCards";
			this.Load += new System.EventHandler(this.FormCards_Load);
			this.pnlGroup.ResumeLayout(false);
			this.pnlCards.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
			this.pnlApplyCancel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddCard;
		private System.Windows.Forms.ComboBox cmbGroup;
		private System.Windows.Forms.Panel pnlGroup;
		private System.Windows.Forms.Label lblGroup;
		private System.Windows.Forms.Button btnRemoveCard;
		private System.Windows.Forms.Button btnEditCard;
		private System.Windows.Forms.Panel pnlCards;
		private System.Windows.Forms.Label lblCards;
		private System.Windows.Forms.DataGridView dgvCards;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCardName;
		private System.Windows.Forms.Panel pnlApplyCancel;
		private System.Windows.Forms.Button btnCancel;
	}
}