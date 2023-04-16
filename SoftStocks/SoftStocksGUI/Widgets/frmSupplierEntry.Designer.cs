namespace SoftStocksGUI.Widgets
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
			lblSupplierId = new Label();
			SuspendLayout();
			// 
			// btnSupplierDelete
			// 
			btnSupplierDelete.BackColor = Color.FromArgb(73, 221, 254);
			btnSupplierDelete.Dock = DockStyle.Right;
			btnSupplierDelete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSupplierDelete.ForeColor = Color.White;
			btnSupplierDelete.Location = new Point(1823, 0);
			btnSupplierDelete.Margin = new Padding(9, 10, 9, 10);
			btnSupplierDelete.Name = "btnSupplierDelete";
			btnSupplierDelete.Size = new Size(291, 211);
			btnSupplierDelete.TabIndex = 3;
			btnSupplierDelete.Text = "Delete";
			btnSupplierDelete.UseVisualStyleBackColor = false;
			btnSupplierDelete.Click += btnSupplierDelete_Click;
			// 
			// btnSupplierSave
			// 
			btnSupplierSave.BackColor = Color.FromArgb(73, 221, 254);
			btnSupplierSave.Dock = DockStyle.Right;
			btnSupplierSave.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSupplierSave.ForeColor = Color.White;
			btnSupplierSave.Location = new Point(1532, 0);
			btnSupplierSave.Margin = new Padding(9, 10, 9, 10);
			btnSupplierSave.Name = "btnSupplierSave";
			btnSupplierSave.Size = new Size(291, 211);
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
			lblSupplierNameEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierNameEntry.ForeColor = Color.White;
			lblSupplierNameEntry.Location = new Point(0, 0);
			lblSupplierNameEntry.Margin = new Padding(9, 10, 9, 10);
			lblSupplierNameEntry.Name = "lblSupplierNameEntry";
			lblSupplierNameEntry.PlaceholderText = "Name";
			lblSupplierNameEntry.Size = new Size(286, 49);
			lblSupplierNameEntry.TabIndex = 5;
			lblSupplierNameEntry.TextAlign = HorizontalAlignment.Center;
			lblSupplierNameEntry.TextChanged += lblSupplierNameEntry_TextChanged;
			// 
			// lblSupplierContactNumberEntry
			// 
			lblSupplierContactNumberEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierContactNumberEntry.BorderStyle = BorderStyle.None;
			lblSupplierContactNumberEntry.Dock = DockStyle.Left;
			lblSupplierContactNumberEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierContactNumberEntry.ForeColor = Color.White;
			lblSupplierContactNumberEntry.Location = new Point(286, 0);
			lblSupplierContactNumberEntry.Margin = new Padding(9, 10, 9, 10);
			lblSupplierContactNumberEntry.Name = "lblSupplierContactNumberEntry";
			lblSupplierContactNumberEntry.PlaceholderText = "Number";
			lblSupplierContactNumberEntry.Size = new Size(286, 49);
			lblSupplierContactNumberEntry.TabIndex = 6;
			lblSupplierContactNumberEntry.TextAlign = HorizontalAlignment.Center;
			lblSupplierContactNumberEntry.TextChanged += lblSupplierContactNumberEntry_TextChanged;
			// 
			// lblSupplierContactNameEntry
			// 
			lblSupplierContactNameEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierContactNameEntry.BorderStyle = BorderStyle.None;
			lblSupplierContactNameEntry.Dock = DockStyle.Left;
			lblSupplierContactNameEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierContactNameEntry.ForeColor = Color.White;
			lblSupplierContactNameEntry.Location = new Point(572, 0);
			lblSupplierContactNameEntry.Margin = new Padding(9, 10, 9, 10);
			lblSupplierContactNameEntry.Name = "lblSupplierContactNameEntry";
			lblSupplierContactNameEntry.PlaceholderText = "Contact Name";
			lblSupplierContactNameEntry.Size = new Size(286, 49);
			lblSupplierContactNameEntry.TabIndex = 7;
			lblSupplierContactNameEntry.TextAlign = HorizontalAlignment.Center;
			lblSupplierContactNameEntry.TextChanged += lblSupplierContactNameEntry_TextChanged;
			// 
			// lblSupplierAddressEntry
			// 
			lblSupplierAddressEntry.BackColor = Color.FromArgb(89, 89, 89);
			lblSupplierAddressEntry.BorderStyle = BorderStyle.None;
			lblSupplierAddressEntry.Dock = DockStyle.Left;
			lblSupplierAddressEntry.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierAddressEntry.ForeColor = Color.White;
			lblSupplierAddressEntry.Location = new Point(858, 0);
			lblSupplierAddressEntry.Margin = new Padding(9, 10, 9, 10);
			lblSupplierAddressEntry.Name = "lblSupplierAddressEntry";
			lblSupplierAddressEntry.PlaceholderText = "Address";
			lblSupplierAddressEntry.ScrollBars = ScrollBars.Both;
			lblSupplierAddressEntry.Size = new Size(286, 49);
			lblSupplierAddressEntry.TabIndex = 8;
			lblSupplierAddressEntry.TextAlign = HorizontalAlignment.Center;
			lblSupplierAddressEntry.TextChanged += lblSupplierAddressEntry_TextChanged;
			// 
			// lblSupplierId
			// 
			lblSupplierId.AutoSize = true;
			lblSupplierId.Location = new Point(1165, 0);
			lblSupplierId.Name = "lblSupplierId";
			lblSupplierId.Size = new Size(115, 48);
			lblSupplierId.TabIndex = 9;
			lblSupplierId.Text = "label1";
			lblSupplierId.Click += label1_Click;
			// 
			// frmSupplierEntry
			// 
			AutoScaleDimensions = new SizeF(20F, 48F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(2114, 211);
			Controls.Add(lblSupplierId);
			Controls.Add(lblSupplierAddressEntry);
			Controls.Add(lblSupplierContactNameEntry);
			Controls.Add(lblSupplierContactNumberEntry);
			Controls.Add(lblSupplierNameEntry);
			Controls.Add(btnSupplierSave);
			Controls.Add(btnSupplierDelete);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(9, 10, 9, 10);
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
		private Label lblSupplierId;
	}
}