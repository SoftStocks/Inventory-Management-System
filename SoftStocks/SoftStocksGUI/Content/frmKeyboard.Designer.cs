namespace SoftStocksGUI.Content
{
	partial class frmKeyboard
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
			btnAddKeyboard = new Button();
			pnlEntryLabels = new Panel();
			lblDescription = new Label();
			lblSupplier = new Label();
			lblQuantity = new Label();
			lblPrice = new Label();
			lblModelNumber = new Label();
			pnlScrollableKeyboard = new FlowLayoutPanel();
			pnlSupplierBanner.SuspendLayout();
			pnlEntryLabels.SuspendLayout();
			SuspendLayout();
			// 
			// pnlSupplierBanner
			// 
			pnlSupplierBanner.Controls.Add(btnAddKeyboard);
			pnlSupplierBanner.Dock = DockStyle.Top;
			pnlSupplierBanner.Location = new Point(0, 0);
			pnlSupplierBanner.Margin = new Padding(9, 10, 9, 10);
			pnlSupplierBanner.Name = "pnlSupplierBanner";
			pnlSupplierBanner.Size = new Size(2186, 211);
			pnlSupplierBanner.TabIndex = 1;
			// 
			// btnAddKeyboard
			// 
			btnAddKeyboard.BackColor = Color.FromArgb(73, 221, 254);
			btnAddKeyboard.Dock = DockStyle.Right;
			btnAddKeyboard.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddKeyboard.ForeColor = Color.White;
			btnAddKeyboard.Location = new Point(1629, 0);
			btnAddKeyboard.Margin = new Padding(9, 10, 9, 10);
			btnAddKeyboard.Name = "btnAddKeyboard";
			btnAddKeyboard.Size = new Size(557, 211);
			btnAddKeyboard.TabIndex = 0;
			btnAddKeyboard.Text = "Create New Keyboard";
			btnAddKeyboard.UseVisualStyleBackColor = false;
			btnAddKeyboard.Click += btnAddKeyboard_Click;
			// 
			// pnlEntryLabels
			// 
			pnlEntryLabels.Controls.Add(lblDescription);
			pnlEntryLabels.Controls.Add(lblSupplier);
			pnlEntryLabels.Controls.Add(lblQuantity);
			pnlEntryLabels.Controls.Add(lblPrice);
			pnlEntryLabels.Controls.Add(lblModelNumber);
			pnlEntryLabels.Dock = DockStyle.Top;
			pnlEntryLabels.Location = new Point(0, 211);
			pnlEntryLabels.Margin = new Padding(9, 10, 9, 10);
			pnlEntryLabels.Name = "pnlEntryLabels";
			pnlEntryLabels.Size = new Size(2186, 211);
			pnlEntryLabels.TabIndex = 2;
			// 
			// lblDescription
			// 
			lblDescription.Dock = DockStyle.Left;
			lblDescription.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblDescription.ForeColor = Color.White;
			lblDescription.Location = new Point(1144, 0);
			lblDescription.Margin = new Padding(9, 0, 9, 0);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(286, 211);
			lblDescription.TabIndex = 4;
			lblDescription.Text = "Description";
			lblDescription.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSupplier
			// 
			lblSupplier.Dock = DockStyle.Left;
			lblSupplier.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSupplier.ForeColor = Color.White;
			lblSupplier.Location = new Point(858, 0);
			lblSupplier.Margin = new Padding(9, 0, 9, 0);
			lblSupplier.Name = "lblSupplier";
			lblSupplier.Size = new Size(286, 211);
			lblSupplier.TabIndex = 3;
			lblSupplier.Text = "Supplier";
			lblSupplier.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblQuantity
			// 
			lblQuantity.Dock = DockStyle.Left;
			lblQuantity.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblQuantity.ForeColor = Color.White;
			lblQuantity.Location = new Point(572, 0);
			lblQuantity.Margin = new Padding(9, 0, 9, 0);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(286, 211);
			lblQuantity.TabIndex = 2;
			lblQuantity.Text = "Quantity";
			lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblPrice
			// 
			lblPrice.Dock = DockStyle.Left;
			lblPrice.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblPrice.ForeColor = Color.White;
			lblPrice.Location = new Point(286, 0);
			lblPrice.Margin = new Padding(9, 0, 9, 0);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(286, 211);
			lblPrice.TabIndex = 1;
			lblPrice.Text = "Price";
			lblPrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblModelNumber
			// 
			lblModelNumber.Dock = DockStyle.Left;
			lblModelNumber.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblModelNumber.ForeColor = Color.White;
			lblModelNumber.Location = new Point(0, 0);
			lblModelNumber.Margin = new Padding(9, 0, 9, 0);
			lblModelNumber.Name = "lblModelNumber";
			lblModelNumber.Size = new Size(286, 211);
			lblModelNumber.TabIndex = 0;
			lblModelNumber.Text = "Model No.";
			lblModelNumber.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlScrollableKeyboard
			// 
			pnlScrollableKeyboard.AutoScroll = true;
			pnlScrollableKeyboard.Dock = DockStyle.Fill;
			pnlScrollableKeyboard.FlowDirection = FlowDirection.TopDown;
			pnlScrollableKeyboard.Location = new Point(0, 422);
			pnlScrollableKeyboard.Margin = new Padding(9, 10, 9, 10);
			pnlScrollableKeyboard.Name = "pnlScrollableKeyboard";
			pnlScrollableKeyboard.Size = new Size(2186, 1018);
			pnlScrollableKeyboard.TabIndex = 3;
			pnlScrollableKeyboard.WrapContents = false;
			// 
			// frmKeyboard
			// 
			AutoScaleDimensions = new SizeF(20F, 48F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(2186, 1440);
			Controls.Add(pnlScrollableKeyboard);
			Controls.Add(pnlEntryLabels);
			Controls.Add(pnlSupplierBanner);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmKeyboard";
			StartPosition = FormStartPosition.CenterParent;
			Text = "frmKeyboard";
			Load += frmKeyboard_Load;
			pnlSupplierBanner.ResumeLayout(false);
			pnlEntryLabels.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlSupplierBanner;
		private Button btnAddKeyboard;
		private Panel pnlEntryLabels;
		private Label lblSupplier;
		private Label lblQuantity;
		private Label lblPrice;
		private Label lblModelNumber;
		private FlowLayoutPanel pnlScrollableKeyboard;
		private Label lblDescription;
	}
}