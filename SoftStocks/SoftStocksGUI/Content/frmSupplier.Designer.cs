namespace SoftStocksGUI
{
	partial class frmSupplier
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
			pnlSupplierBanner = new Panel();
			btnAddSupplier = new Button();
			pnlEntryLabels = new Panel();
			lblSupplierAddress = new Label();
			lblSupplierPrimaryContact = new Label();
			lblSupplierContact = new Label();
			lblSupplierName = new Label();
			pnlScrollableSupplier = new FlowLayoutPanel();
			pnlSupplierBanner.SuspendLayout();
			pnlEntryLabels.SuspendLayout();
			SuspendLayout();
			// 
			// pnlSupplierBanner
			// 
			pnlSupplierBanner.Controls.Add(btnAddSupplier);
			pnlSupplierBanner.Dock = DockStyle.Top;
			pnlSupplierBanner.Location = new Point(0, 0);
			pnlSupplierBanner.Name = "pnlSupplierBanner";
			pnlSupplierBanner.Size = new Size(765, 66);
			pnlSupplierBanner.TabIndex = 0;
			// 
			// btnAddSupplier
			// 
			btnAddSupplier.BackColor = Color.FromArgb(73, 221, 254);
			btnAddSupplier.Dock = DockStyle.Right;
			btnAddSupplier.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddSupplier.ForeColor = Color.White;
			btnAddSupplier.Location = new Point(570, 0);
			btnAddSupplier.Name = "btnAddSupplier";
			btnAddSupplier.Size = new Size(195, 66);
			btnAddSupplier.TabIndex = 0;
			btnAddSupplier.Text = "Create New Supplier";
			btnAddSupplier.UseVisualStyleBackColor = false;
			btnAddSupplier.Click += btnAddSupplier_Click;
			// 
			// pnlEntryLabels
			// 
			pnlEntryLabels.Controls.Add(lblSupplierAddress);
			pnlEntryLabels.Controls.Add(lblSupplierPrimaryContact);
			pnlEntryLabels.Controls.Add(lblSupplierContact);
			pnlEntryLabels.Controls.Add(lblSupplierName);
			pnlEntryLabels.Dock = DockStyle.Top;
			pnlEntryLabels.Location = new Point(0, 66);
			pnlEntryLabels.Name = "pnlEntryLabels";
			pnlEntryLabels.Size = new Size(765, 66);
			pnlEntryLabels.TabIndex = 1;
			// 
			// lblSupplierAddress
			// 
			lblSupplierAddress.Dock = DockStyle.Left;
			lblSupplierAddress.Font = new Font("Verdana Pro Light", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierAddress.ForeColor = Color.White;
			lblSupplierAddress.Location = new Point(300, 0);
			lblSupplierAddress.Name = "lblSupplierAddress";
			lblSupplierAddress.Size = new Size(100, 66);
			lblSupplierAddress.TabIndex = 3;
			lblSupplierAddress.Text = "Business Address";
			lblSupplierAddress.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSupplierPrimaryContact
			// 
			lblSupplierPrimaryContact.Dock = DockStyle.Left;
			lblSupplierPrimaryContact.Font = new Font("Verdana Pro Light", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierPrimaryContact.ForeColor = Color.White;
			lblSupplierPrimaryContact.Location = new Point(200, 0);
			lblSupplierPrimaryContact.Name = "lblSupplierPrimaryContact";
			lblSupplierPrimaryContact.Size = new Size(100, 66);
			lblSupplierPrimaryContact.TabIndex = 2;
			lblSupplierPrimaryContact.Text = "Primary Contact";
			lblSupplierPrimaryContact.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSupplierContact
			// 
			lblSupplierContact.Dock = DockStyle.Left;
			lblSupplierContact.Font = new Font("Verdana Pro Light", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierContact.ForeColor = Color.White;
			lblSupplierContact.Location = new Point(100, 0);
			lblSupplierContact.Name = "lblSupplierContact";
			lblSupplierContact.Size = new Size(100, 66);
			lblSupplierContact.TabIndex = 1;
			lblSupplierContact.Text = "Contact Number";
			lblSupplierContact.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSupplierName
			// 
			lblSupplierName.Dock = DockStyle.Left;
			lblSupplierName.Font = new Font("Verdana Pro Light", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplierName.ForeColor = Color.White;
			lblSupplierName.Location = new Point(0, 0);
			lblSupplierName.Name = "lblSupplierName";
			lblSupplierName.Size = new Size(100, 66);
			lblSupplierName.TabIndex = 0;
			lblSupplierName.Text = "Supplier Name";
			lblSupplierName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlScrollableSupplier
			// 
			pnlScrollableSupplier.AutoScroll = true;
			pnlScrollableSupplier.Dock = DockStyle.Fill;
			pnlScrollableSupplier.FlowDirection = FlowDirection.TopDown;
			pnlScrollableSupplier.Location = new Point(0, 132);
			pnlScrollableSupplier.Name = "pnlScrollableSupplier";
			pnlScrollableSupplier.Size = new Size(765, 318);
			pnlScrollableSupplier.TabIndex = 2;
			pnlScrollableSupplier.WrapContents = false;
			// 
			// frmSupplier
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(765, 450);
			Controls.Add(pnlScrollableSupplier);
			Controls.Add(pnlEntryLabels);
			Controls.Add(pnlSupplierBanner);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(1);
			Name = "frmSupplier";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SoftStocks Inventory Management System";
			pnlSupplierBanner.ResumeLayout(false);
			pnlEntryLabels.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlSupplierBanner;
		private Button btnAddSupplier;
		private Panel pnlEntryLabels;
		private Label lblSupplierName;
		private Label lblSupplierPrimaryContact;
		private Label lblSupplierContact;
		private FlowLayoutPanel pnlScrollableSupplier;
		private Label lblSupplierAddress;
	}
}