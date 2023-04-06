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
			lblSupplierNameEntry = new Label();
			lblSupplierContactEntry = new Label();
			lblSupplierPurchasesEntry = new Label();
			btnSupplierDelete = new Button();
			btnSupplierEdit = new Button();
			SuspendLayout();
			// 
			// lblSupplierNameEntry
			// 
			lblSupplierNameEntry.Dock = DockStyle.Left;
			lblSupplierNameEntry.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierNameEntry.ForeColor = Color.White;
			lblSupplierNameEntry.Location = new Point(0, 0);
			lblSupplierNameEntry.Name = "lblSupplierNameEntry";
			lblSupplierNameEntry.Size = new Size(155, 66);
			lblSupplierNameEntry.TabIndex = 0;
			lblSupplierNameEntry.Text = "John Smiths";
			lblSupplierNameEntry.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSupplierContactEntry
			// 
			lblSupplierContactEntry.Dock = DockStyle.Left;
			lblSupplierContactEntry.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierContactEntry.ForeColor = Color.White;
			lblSupplierContactEntry.Location = new Point(155, 0);
			lblSupplierContactEntry.Name = "lblSupplierContactEntry";
			lblSupplierContactEntry.Size = new Size(155, 66);
			lblSupplierContactEntry.TabIndex = 1;
			lblSupplierContactEntry.Text = "0747937532";
			lblSupplierContactEntry.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSupplierPurchasesEntry
			// 
			lblSupplierPurchasesEntry.Dock = DockStyle.Left;
			lblSupplierPurchasesEntry.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierPurchasesEntry.ForeColor = Color.White;
			lblSupplierPurchasesEntry.Location = new Point(310, 0);
			lblSupplierPurchasesEntry.Name = "lblSupplierPurchasesEntry";
			lblSupplierPurchasesEntry.Size = new Size(155, 66);
			lblSupplierPurchasesEntry.TabIndex = 2;
			lblSupplierPurchasesEntry.Text = "192";
			lblSupplierPurchasesEntry.TextAlign = ContentAlignment.MiddleCenter;
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
			// btnSupplierEdit
			// 
			btnSupplierEdit.BackColor = Color.FromArgb(73, 221, 254);
			btnSupplierEdit.Dock = DockStyle.Right;
			btnSupplierEdit.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSupplierEdit.ForeColor = Color.White;
			btnSupplierEdit.Location = new Point(536, 0);
			btnSupplierEdit.Name = "btnSupplierEdit";
			btnSupplierEdit.Size = new Size(102, 66);
			btnSupplierEdit.TabIndex = 4;
			btnSupplierEdit.Text = "Edit";
			btnSupplierEdit.UseVisualStyleBackColor = false;
			// 
			// frmSupplierEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(740, 66);
			Controls.Add(btnSupplierEdit);
			Controls.Add(btnSupplierDelete);
			Controls.Add(lblSupplierPurchasesEntry);
			Controls.Add(lblSupplierContactEntry);
			Controls.Add(lblSupplierNameEntry);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmSupplierEntry";
			Text = "frmSupplierEntry";
			ResumeLayout(false);
		}

		#endregion

		private Label lblSupplierNameEntry;
		private Label lblSupplierContactEntry;
		private Label lblSupplierPurchasesEntry;
		private Button btnSupplierDelete;
		private Button btnSupplierEdit;
	}
}