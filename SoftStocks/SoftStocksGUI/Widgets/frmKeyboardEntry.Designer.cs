﻿namespace SoftStocksGUI.Widgets
{
	partial class frmKeyboardEntry
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
			lblKeyboardModelNumberEntry = new TextBox();
			lblKeyboardQuantityEntry = new TextBox();
			lblKeyboardPriceEntry = new TextBox();
			lblKeyboardSupplierIdEntry = new TextBox();
			lblKeyboardDescriptionEntry = new TextBox();
			btnKeyboardDelete = new Button();
			btnKeyboardSave = new Button();
			SuspendLayout();
			// 
			// lblKeyboardModelNumberEntry
			// 
			lblKeyboardModelNumberEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblKeyboardModelNumberEntry.BorderStyle = BorderStyle.None;
			lblKeyboardModelNumberEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblKeyboardModelNumberEntry.ForeColor = Color.White;
			lblKeyboardModelNumberEntry.Location = new Point(-4, 26);
			lblKeyboardModelNumberEntry.Name = "lblKeyboardModelNumberEntry";
			lblKeyboardModelNumberEntry.PlaceholderText = "Model No.";
			lblKeyboardModelNumberEntry.ReadOnly = true;
			lblKeyboardModelNumberEntry.Size = new Size(100, 17);
			lblKeyboardModelNumberEntry.TabIndex = 6;
			lblKeyboardModelNumberEntry.TextAlign = HorizontalAlignment.Center;
			// 
			// lblKeyboardQuantityEntry
			// 
			lblKeyboardQuantityEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblKeyboardQuantityEntry.BorderStyle = BorderStyle.None;
			lblKeyboardQuantityEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblKeyboardQuantityEntry.ForeColor = Color.White;
			lblKeyboardQuantityEntry.Location = new Point(102, 26);
			lblKeyboardQuantityEntry.Name = "lblKeyboardQuantityEntry";
			lblKeyboardQuantityEntry.PlaceholderText = "Quantity";
			lblKeyboardQuantityEntry.Size = new Size(100, 17);
			lblKeyboardQuantityEntry.TabIndex = 7;
			lblKeyboardQuantityEntry.TextAlign = HorizontalAlignment.Center;
			lblKeyboardQuantityEntry.TextChanged += removeRowifBlank;
			// 
			// lblKeyboardPriceEntry
			// 
			lblKeyboardPriceEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblKeyboardPriceEntry.BorderStyle = BorderStyle.None;
			lblKeyboardPriceEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblKeyboardPriceEntry.ForeColor = Color.White;
			lblKeyboardPriceEntry.Location = new Point(208, 26);
			lblKeyboardPriceEntry.Name = "lblKeyboardPriceEntry";
			lblKeyboardPriceEntry.PlaceholderText = "Price";
			lblKeyboardPriceEntry.Size = new Size(100, 17);
			lblKeyboardPriceEntry.TabIndex = 8;
			lblKeyboardPriceEntry.TextAlign = HorizontalAlignment.Center;
			lblKeyboardPriceEntry.TextChanged += removeRowifBlank;
			// 
			// lblKeyboardSupplierIdEntry
			// 
			lblKeyboardSupplierIdEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblKeyboardSupplierIdEntry.BorderStyle = BorderStyle.None;
			lblKeyboardSupplierIdEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblKeyboardSupplierIdEntry.ForeColor = Color.White;
			lblKeyboardSupplierIdEntry.Location = new Point(314, 26);
			lblKeyboardSupplierIdEntry.Name = "lblKeyboardSupplierIdEntry";
			lblKeyboardSupplierIdEntry.PlaceholderText = "Supplier ID";
			lblKeyboardSupplierIdEntry.ScrollBars = ScrollBars.Both;
			lblKeyboardSupplierIdEntry.Size = new Size(100, 17);
			lblKeyboardSupplierIdEntry.TabIndex = 9;
			lblKeyboardSupplierIdEntry.TextAlign = HorizontalAlignment.Center;
			lblKeyboardSupplierIdEntry.TextChanged += removeRowifBlank;
			// 
			// lblKeyboardDescriptionEntry
			// 
			lblKeyboardDescriptionEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblKeyboardDescriptionEntry.BorderStyle = BorderStyle.None;
			lblKeyboardDescriptionEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblKeyboardDescriptionEntry.ForeColor = Color.White;
			lblKeyboardDescriptionEntry.Location = new Point(420, 26);
			lblKeyboardDescriptionEntry.Name = "lblKeyboardDescriptionEntry";
			lblKeyboardDescriptionEntry.PlaceholderText = "Description";
			lblKeyboardDescriptionEntry.ScrollBars = ScrollBars.Both;
			lblKeyboardDescriptionEntry.Size = new Size(100, 17);
			lblKeyboardDescriptionEntry.TabIndex = 10;
			lblKeyboardDescriptionEntry.TextAlign = HorizontalAlignment.Center;
			lblKeyboardDescriptionEntry.TextChanged += removeRowifBlank;
			// 
			// btnKeyboardDelete
			// 
			btnKeyboardDelete.BackColor = Color.FromArgb(73, 221, 254);
			btnKeyboardDelete.Dock = DockStyle.Right;
			btnKeyboardDelete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnKeyboardDelete.ForeColor = Color.White;
			btnKeyboardDelete.Location = new Point(638, 0);
			btnKeyboardDelete.Name = "btnKeyboardDelete";
			btnKeyboardDelete.Size = new Size(102, 66);
			btnKeyboardDelete.TabIndex = 12;
			btnKeyboardDelete.Text = "Delete";
			btnKeyboardDelete.UseVisualStyleBackColor = false;
			btnKeyboardDelete.Click += btnKeyboardDelete_Click;
			// 
			// btnKeyboardSave
			// 
			btnKeyboardSave.BackColor = Color.FromArgb(73, 221, 254);
			btnKeyboardSave.Dock = DockStyle.Right;
			btnKeyboardSave.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnKeyboardSave.ForeColor = Color.White;
			btnKeyboardSave.Location = new Point(536, 0);
			btnKeyboardSave.Name = "btnKeyboardSave";
			btnKeyboardSave.Size = new Size(102, 66);
			btnKeyboardSave.TabIndex = 13;
			btnKeyboardSave.Text = "Save";
			btnKeyboardSave.UseVisualStyleBackColor = false;
			btnKeyboardSave.Click += btnKeyboardSave_Click;
			// 
			// frmKeyboardEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(740, 66);
			Controls.Add(btnKeyboardSave);
			Controls.Add(btnKeyboardDelete);
			Controls.Add(lblKeyboardDescriptionEntry);
			Controls.Add(lblKeyboardSupplierIdEntry);
			Controls.Add(lblKeyboardPriceEntry);
			Controls.Add(lblKeyboardQuantityEntry);
			Controls.Add(lblKeyboardModelNumberEntry);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(1);
			Name = "frmKeyboardEntry";
			Text = "frmKeyboardEntry";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox lblKeyboardModelNumberEntry;
		private TextBox lblKeyboardQuantityEntry;
		private TextBox lblKeyboardPriceEntry;
		private TextBox lblKeyboardSupplierIdEntry;
		private TextBox lblKeyboardDescriptionEntry;
		private Button btnKeyboardDelete;
		private Button btnKeyboardSave;
	}
}