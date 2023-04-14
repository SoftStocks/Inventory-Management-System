﻿namespace SoftStocksGUI.Widgets
{
	partial class frmSupplierEntry
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
			btnSupplierDelete = new Button();
			btnSupplierSave = new Button();
			lblSupplierNameEntry = new TextBox();
			lblSupplierContactNumberEntry = new TextBox();
			lblSupplierContactNameEntry = new TextBox();
			lblSupplierAddressEntry = new TextBox();
			SuspendLayout();
			// 
			// btnSupplierDelete
			// 
			btnSupplierDelete.BackColor = Color.FromArgb(73, 221, 254);
			btnSupplierDelete.Dock = DockStyle.Right;
			btnSupplierDelete.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSupplierDelete.ForeColor = Color.White;
			btnSupplierDelete.Location = new Point(638, 0);
			btnSupplierDelete.Name = "btnSupplierDelete";
			btnSupplierDelete.Size = new Size(102, 66);
			btnSupplierDelete.TabIndex = 3;
			btnSupplierDelete.Text = "Delete";
			btnSupplierDelete.UseVisualStyleBackColor = false;
			btnSupplierDelete.Click += btnSupplierDelete_Click;
			// 
			// btnSupplierSave
			// 
			btnSupplierSave.BackColor = Color.FromArgb(73, 221, 254);
			btnSupplierSave.Dock = DockStyle.Right;
			btnSupplierSave.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSupplierSave.ForeColor = Color.White;
			btnSupplierSave.Location = new Point(536, 0);
			btnSupplierSave.Name = "btnSupplierSave";
			btnSupplierSave.Size = new Size(102, 66);
			btnSupplierSave.TabIndex = 4;
			btnSupplierSave.Text = "Save";
			btnSupplierSave.UseVisualStyleBackColor = false;
			btnSupplierSave.Click += btnSupplierSave_Click;
			// 
			// lblSupplierNameEntry
			// 
			lblSupplierNameEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierNameEntry.BorderStyle = BorderStyle.None;
			lblSupplierNameEntry.Dock = DockStyle.Left;
			lblSupplierNameEntry.Font = new Font("Verdana Pro Light", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierNameEntry.ForeColor = Color.White;
			lblSupplierNameEntry.Location = new Point(0, 0);
			lblSupplierNameEntry.Name = "lblSupplierNameEntry";
			lblSupplierNameEntry.PlaceholderText = "Name";
			lblSupplierNameEntry.Size = new Size(100, 18);
			lblSupplierNameEntry.TabIndex = 5;
			lblSupplierNameEntry.TextAlign = HorizontalAlignment.Center;
			lblSupplierNameEntry.TextChanged += lblSupplierNameEntry_TextChanged;
			// 
			// lblSupplierContactNumberEntry
			// 
			lblSupplierContactNumberEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierContactNumberEntry.BorderStyle = BorderStyle.None;
			lblSupplierContactNumberEntry.Dock = DockStyle.Left;
			lblSupplierContactNumberEntry.Font = new Font("Verdana Pro Light", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierContactNumberEntry.ForeColor = Color.White;
			lblSupplierContactNumberEntry.Location = new Point(100, 0);
			lblSupplierContactNumberEntry.Name = "lblSupplierContactNumberEntry";
			lblSupplierContactNumberEntry.PlaceholderText = "Number";
			lblSupplierContactNumberEntry.Size = new Size(100, 18);
			lblSupplierContactNumberEntry.TabIndex = 6;
			lblSupplierContactNumberEntry.TextAlign = HorizontalAlignment.Center;
			// 
			// lblSupplierContactNameEntry
			// 
			lblSupplierContactNameEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierContactNameEntry.BorderStyle = BorderStyle.None;
			lblSupplierContactNameEntry.Dock = DockStyle.Left;
			lblSupplierContactNameEntry.Font = new Font("Verdana Pro Light", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierContactNameEntry.ForeColor = Color.White;
			lblSupplierContactNameEntry.Location = new Point(200, 0);
			lblSupplierContactNameEntry.Name = "lblSupplierContactNameEntry";
			lblSupplierContactNameEntry.PlaceholderText = "Contact Name";
			lblSupplierContactNameEntry.Size = new Size(100, 18);
			lblSupplierContactNameEntry.TabIndex = 7;
			lblSupplierContactNameEntry.TextAlign = HorizontalAlignment.Center;
			// 
			// lblSupplierAddressEntry
			// 
			lblSupplierAddressEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierAddressEntry.BorderStyle = BorderStyle.None;
			lblSupplierAddressEntry.Dock = DockStyle.Left;
			lblSupplierAddressEntry.Font = new Font("Verdana Pro Light", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierAddressEntry.ForeColor = Color.White;
			lblSupplierAddressEntry.Location = new Point(300, 0);
			lblSupplierAddressEntry.Name = "lblSupplierAddressEntry";
			lblSupplierAddressEntry.PlaceholderText = "Address";
			lblSupplierAddressEntry.Size = new Size(100, 18);
			lblSupplierAddressEntry.TabIndex = 8;
			lblSupplierAddressEntry.TextAlign = HorizontalAlignment.Center;
			// 
			// frmSupplierEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(740, 66);
			Controls.Add(lblSupplierAddressEntry);
			Controls.Add(lblSupplierContactNameEntry);
			Controls.Add(lblSupplierContactNumberEntry);
			Controls.Add(lblSupplierNameEntry);
			Controls.Add(btnSupplierSave);
			Controls.Add(btnSupplierDelete);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmSupplierEntry";
			Text = "frmSupplierEntry";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnSupplierDelete;
		private Button btnSupplierSave;
		private TextBox lblSupplierNameEntry;
		private TextBox lblSupplierContactNumberEntry;
		private TextBox lblSupplierContactNameEntry;
		private TextBox lblSupplierAddressEntry;
	}
}