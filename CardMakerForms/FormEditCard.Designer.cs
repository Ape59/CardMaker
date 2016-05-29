namespace CardMakerForms
{
	partial class FormEditCard
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
			this.pnlName = new System.Windows.Forms.Panel();
			this.edtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pnlDescription = new System.Windows.Forms.Panel();
			this.edtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.pnlApplyCancel = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlName.SuspendLayout();
			this.pnlDescription.SuspendLayout();
			this.pnlApplyCancel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlName
			// 
			this.pnlName.Controls.Add(this.edtName);
			this.pnlName.Controls.Add(this.lblName);
			this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlName.Location = new System.Drawing.Point(30, 30);
			this.pnlName.Name = "pnlName";
			this.pnlName.Size = new System.Drawing.Size(274, 40);
			this.pnlName.TabIndex = 4;
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
			this.pnlDescription.TabIndex = 5;
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
			// pnlApplyCancel
			// 
			this.pnlApplyCancel.Controls.Add(this.splitContainer1);
			this.pnlApplyCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlApplyCancel.Location = new System.Drawing.Point(30, 381);
			this.pnlApplyCancel.Name = "pnlApplyCancel";
			this.pnlApplyCancel.Size = new System.Drawing.Size(274, 50);
			this.pnlApplyCancel.TabIndex = 11;
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
			// FormEditCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.pnlApplyCancel);
			this.Controls.Add(this.pnlDescription);
			this.Controls.Add(this.pnlName);
			this.Name = "FormEditCard";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "FormEditCard";
			this.Load += new System.EventHandler(this.FormEditCard_Load);
			this.pnlName.ResumeLayout(false);
			this.pnlName.PerformLayout();
			this.pnlDescription.ResumeLayout(false);
			this.pnlDescription.PerformLayout();
			this.pnlApplyCancel.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.Panel pnlDescription;
		private System.Windows.Forms.TextBox edtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Panel pnlApplyCancel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnCancel;
	}
}