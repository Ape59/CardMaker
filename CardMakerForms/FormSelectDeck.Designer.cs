﻿namespace CardMakerForms
{
	partial class FormSelectDeck
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
			this.pnlDecks = new System.Windows.Forms.Panel();
			this.dgvDecks = new System.Windows.Forms.DataGridView();
			this.clmDeckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblDecks = new System.Windows.Forms.Label();
			this.pnlApplyCancel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.pnlDecks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDecks)).BeginInit();
			this.pnlApplyCancel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDecks
			// 
			this.pnlDecks.Controls.Add(this.dgvDecks);
			this.pnlDecks.Controls.Add(this.lblDecks);
			this.pnlDecks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDecks.Location = new System.Drawing.Point(30, 30);
			this.pnlDecks.Name = "pnlDecks";
			this.pnlDecks.Size = new System.Drawing.Size(274, 311);
			this.pnlDecks.TabIndex = 12;
			// 
			// dgvDecks
			// 
			this.dgvDecks.AllowUserToAddRows = false;
			this.dgvDecks.AllowUserToDeleteRows = false;
			this.dgvDecks.AllowUserToResizeColumns = false;
			this.dgvDecks.AllowUserToResizeRows = false;
			this.dgvDecks.BackgroundColor = System.Drawing.Color.White;
			this.dgvDecks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvDecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDecks.ColumnHeadersVisible = false;
			this.dgvDecks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDeckName,
            this.clmCardNumber});
			this.dgvDecks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDecks.Location = new System.Drawing.Point(0, 13);
			this.dgvDecks.MultiSelect = false;
			this.dgvDecks.Name = "dgvDecks";
			this.dgvDecks.ReadOnly = true;
			this.dgvDecks.RowHeadersVisible = false;
			this.dgvDecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDecks.Size = new System.Drawing.Size(274, 298);
			this.dgvDecks.TabIndex = 10;
			this.dgvDecks.SelectionChanged += new System.EventHandler(this.dgvDecks_SelectionChanged);
			// 
			// clmDeckName
			// 
			this.clmDeckName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmDeckName.HeaderText = "Name";
			this.clmDeckName.Name = "clmDeckName";
			this.clmDeckName.ReadOnly = true;
			// 
			// clmCardNumber
			// 
			this.clmCardNumber.HeaderText = "Anzahl";
			this.clmCardNumber.Name = "clmCardNumber";
			this.clmCardNumber.ReadOnly = true;
			// 
			// lblDecks
			// 
			this.lblDecks.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDecks.Location = new System.Drawing.Point(0, 0);
			this.lblDecks.Name = "lblDecks";
			this.lblDecks.Size = new System.Drawing.Size(274, 13);
			this.lblDecks.TabIndex = 9;
			this.lblDecks.Text = "Decks";
			this.lblDecks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			// btnStartGame
			// 
			this.btnStartGame.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnStartGame.Location = new System.Drawing.Point(30, 341);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(274, 40);
			this.btnStartGame.TabIndex = 15;
			this.btnStartGame.Text = "Spiel starten";
			this.btnStartGame.UseVisualStyleBackColor = true;
			this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
			// 
			// FormSelectDeck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.pnlDecks);
			this.Controls.Add(this.btnStartGame);
			this.Controls.Add(this.pnlApplyCancel);
			this.Name = "FormSelectDeck";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "FormSelectDeck";
			this.Load += new System.EventHandler(this.FormSelectDeck_Load);
			this.pnlDecks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDecks)).EndInit();
			this.pnlApplyCancel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlDecks;
		private System.Windows.Forms.DataGridView dgvDecks;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmDeckName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCardNumber;
		private System.Windows.Forms.Label lblDecks;
		private System.Windows.Forms.Panel pnlApplyCancel;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnStartGame;
	}
}