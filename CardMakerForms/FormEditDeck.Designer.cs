namespace CardMakerForms
{
	partial class FormEditDeck
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlName = new System.Windows.Forms.Panel();
			this.edtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pnlDescription = new System.Windows.Forms.Panel();
			this.edtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.pnlCards = new System.Windows.Forms.Panel();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.dgvCardsSource = new System.Windows.Forms.DataGridView();
			this.clmCardSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddCard = new System.Windows.Forms.Button();
			this.cmbGroup = new System.Windows.Forms.ComboBox();
			this.dgvCardsDeck = new System.Windows.Forms.DataGridView();
			this.btnRemoveCard = new System.Windows.Forms.Button();
			this.lblCards = new System.Windows.Forms.Label();
			this.pnlApplyCancel = new System.Windows.Forms.Panel();
			this.clmCardDeckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.pnlName.SuspendLayout();
			this.pnlDescription.SuspendLayout();
			this.pnlCards.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCardsSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCardsDeck)).BeginInit();
			this.pnlApplyCancel.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 10);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnApply);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
			this.splitContainer1.Size = new System.Drawing.Size(274, 40);
			this.splitContainer1.SplitterDistance = 137;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 6;
			// 
			// btnApply
			// 
			this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnApply.Location = new System.Drawing.Point(0, 0);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(137, 40);
			this.btnApply.TabIndex = 2;
			this.btnApply.Text = "OK";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(0, 0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(136, 40);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Abbrechen";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlName
			// 
			this.pnlName.Controls.Add(this.edtName);
			this.pnlName.Controls.Add(this.lblName);
			this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlName.Location = new System.Drawing.Point(30, 30);
			this.pnlName.Name = "pnlName";
			this.pnlName.Size = new System.Drawing.Size(274, 40);
			this.pnlName.TabIndex = 7;
			// 
			// edtName
			// 
			this.edtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.edtName.Location = new System.Drawing.Point(0, 13);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(274, 20);
			this.edtName.TabIndex = 4;
			// 
			// lblName
			// 
			this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblName.Location = new System.Drawing.Point(0, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(274, 13);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Name";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnlDescription
			// 
			this.pnlDescription.Controls.Add(this.edtDescription);
			this.pnlDescription.Controls.Add(this.lblDescription);
			this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDescription.Location = new System.Drawing.Point(30, 70);
			this.pnlDescription.Name = "pnlDescription";
			this.pnlDescription.Size = new System.Drawing.Size(274, 100);
			this.pnlDescription.TabIndex = 8;
			// 
			// edtDescription
			// 
			this.edtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.edtDescription.Location = new System.Drawing.Point(0, 13);
			this.edtDescription.Multiline = true;
			this.edtDescription.Name = "edtDescription";
			this.edtDescription.Size = new System.Drawing.Size(274, 87);
			this.edtDescription.TabIndex = 4;
			// 
			// lblDescription
			// 
			this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDescription.Location = new System.Drawing.Point(0, 0);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(274, 13);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Beschreibung";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnlCards
			// 
			this.pnlCards.Controls.Add(this.splitContainer2);
			this.pnlCards.Controls.Add(this.lblCards);
			this.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCards.Location = new System.Drawing.Point(30, 170);
			this.pnlCards.Name = "pnlCards";
			this.pnlCards.Size = new System.Drawing.Size(274, 211);
			this.pnlCards.TabIndex = 9;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 13);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dgvCardsSource);
			this.splitContainer2.Panel1.Controls.Add(this.btnAddCard);
			this.splitContainer2.Panel1.Controls.Add(this.cmbGroup);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.dgvCardsDeck);
			this.splitContainer2.Panel2.Controls.Add(this.btnRemoveCard);
			this.splitContainer2.Size = new System.Drawing.Size(274, 198);
			this.splitContainer2.SplitterDistance = 137;
			this.splitContainer2.SplitterWidth = 1;
			this.splitContainer2.TabIndex = 10;
			// 
			// dgvCardsSource
			// 
			this.dgvCardsSource.AllowUserToAddRows = false;
			this.dgvCardsSource.AllowUserToDeleteRows = false;
			this.dgvCardsSource.AllowUserToResizeColumns = false;
			this.dgvCardsSource.AllowUserToResizeRows = false;
			this.dgvCardsSource.BackgroundColor = System.Drawing.Color.White;
			this.dgvCardsSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvCardsSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCardsSource.ColumnHeadersVisible = false;
			this.dgvCardsSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCardSourceName});
			this.dgvCardsSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCardsSource.Location = new System.Drawing.Point(0, 21);
			this.dgvCardsSource.MultiSelect = false;
			this.dgvCardsSource.Name = "dgvCardsSource";
			this.dgvCardsSource.ReadOnly = true;
			this.dgvCardsSource.RowHeadersVisible = false;
			this.dgvCardsSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCardsSource.Size = new System.Drawing.Size(137, 137);
			this.dgvCardsSource.TabIndex = 12;
			this.dgvCardsSource.SelectionChanged += new System.EventHandler(this.dgvCardsSource_SelectionChanged);
			// 
			// clmCardSourceName
			// 
			this.clmCardSourceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmCardSourceName.HeaderText = "Name";
			this.clmCardSourceName.Name = "clmCardSourceName";
			this.clmCardSourceName.ReadOnly = true;
			// 
			// btnAddCard
			// 
			this.btnAddCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAddCard.Location = new System.Drawing.Point(0, 158);
			this.btnAddCard.Name = "btnAddCard";
			this.btnAddCard.Size = new System.Drawing.Size(137, 40);
			this.btnAddCard.TabIndex = 11;
			this.btnAddCard.Text = "Hinzufügen";
			this.btnAddCard.UseVisualStyleBackColor = true;
			this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
			// 
			// cmbGroup
			// 
			this.cmbGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.Location = new System.Drawing.Point(0, 0);
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.Size = new System.Drawing.Size(137, 21);
			this.cmbGroup.TabIndex = 10;
			this.cmbGroup.TextChanged += new System.EventHandler(this.cmbGroup_TextChanged);
			// 
			// dgvCardsDeck
			// 
			this.dgvCardsDeck.AllowUserToAddRows = false;
			this.dgvCardsDeck.AllowUserToDeleteRows = false;
			this.dgvCardsDeck.AllowUserToResizeColumns = false;
			this.dgvCardsDeck.AllowUserToResizeRows = false;
			this.dgvCardsDeck.BackgroundColor = System.Drawing.Color.White;
			this.dgvCardsDeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvCardsDeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCardsDeck.ColumnHeadersVisible = false;
			this.dgvCardsDeck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCardDeckName});
			this.dgvCardsDeck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCardsDeck.Location = new System.Drawing.Point(0, 0);
			this.dgvCardsDeck.MultiSelect = false;
			this.dgvCardsDeck.Name = "dgvCardsDeck";
			this.dgvCardsDeck.ReadOnly = true;
			this.dgvCardsDeck.RowHeadersVisible = false;
			this.dgvCardsDeck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCardsDeck.Size = new System.Drawing.Size(136, 158);
			this.dgvCardsDeck.TabIndex = 9;
			this.dgvCardsDeck.SelectionChanged += new System.EventHandler(this.dgvCardsDeck_SelectionChanged);
			// 
			// btnRemoveCard
			// 
			this.btnRemoveCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnRemoveCard.Location = new System.Drawing.Point(0, 158);
			this.btnRemoveCard.Name = "btnRemoveCard";
			this.btnRemoveCard.Size = new System.Drawing.Size(136, 40);
			this.btnRemoveCard.TabIndex = 4;
			this.btnRemoveCard.Text = "Entfernen";
			this.btnRemoveCard.UseVisualStyleBackColor = true;
			this.btnRemoveCard.Click += new System.EventHandler(this.btnRemoveCard_Click);
			// 
			// lblCards
			// 
			this.lblCards.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblCards.Location = new System.Drawing.Point(0, 0);
			this.lblCards.Name = "lblCards";
			this.lblCards.Size = new System.Drawing.Size(274, 13);
			this.lblCards.TabIndex = 3;
			this.lblCards.Text = "Karten";
			this.lblCards.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnlApplyCancel
			// 
			this.pnlApplyCancel.Controls.Add(this.splitContainer1);
			this.pnlApplyCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlApplyCancel.Location = new System.Drawing.Point(30, 381);
			this.pnlApplyCancel.Name = "pnlApplyCancel";
			this.pnlApplyCancel.Size = new System.Drawing.Size(274, 50);
			this.pnlApplyCancel.TabIndex = 10;
			// 
			// clmCardDeckName
			// 
			this.clmCardDeckName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmCardDeckName.HeaderText = "Name";
			this.clmCardDeckName.Name = "clmCardDeckName";
			this.clmCardDeckName.ReadOnly = true;
			// 
			// FormEditDeck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.pnlCards);
			this.Controls.Add(this.pnlApplyCancel);
			this.Controls.Add(this.pnlDescription);
			this.Controls.Add(this.pnlName);
			this.Name = "FormEditDeck";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "FormEditDeck";
			this.Load += new System.EventHandler(this.FormEditDeck_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.pnlName.ResumeLayout(false);
			this.pnlName.PerformLayout();
			this.pnlDescription.ResumeLayout(false);
			this.pnlDescription.PerformLayout();
			this.pnlCards.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCardsSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCardsDeck)).EndInit();
			this.pnlApplyCancel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlName;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Panel pnlDescription;
		private System.Windows.Forms.TextBox edtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Panel pnlCards;
		private System.Windows.Forms.Label lblCards;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ComboBox cmbGroup;
		private System.Windows.Forms.Button btnAddCard;
		private System.Windows.Forms.Button btnRemoveCard;
		private System.Windows.Forms.Panel pnlApplyCancel;
		private System.Windows.Forms.DataGridView dgvCardsSource;
		private System.Windows.Forms.DataGridView dgvCardsDeck;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCardSourceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCardDeckName;
	}
}