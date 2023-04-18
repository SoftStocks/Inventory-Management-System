namespace SoftStocksGUI.Widgets
{
	partial class frmTaskCard
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
			txtTaskId = new Label();
			txtKeyboardModel = new TextBox();
			txtQuantity = new TextBox();
			txtDateCreated = new TextBox();
			btnSaveCard = new Button();
			btnDeleteCard = new Button();
			cbbxStatus = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// txtTaskId
			// 
			txtTaskId.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtTaskId.ForeColor = Color.White;
			txtTaskId.Location = new Point(34, 29);
			txtTaskId.Margin = new Padding(9, 0, 9, 0);
			txtTaskId.Name = "txtTaskId";
			txtTaskId.Size = new Size(491, 86);
			txtTaskId.TabIndex = 0;
			txtTaskId.Text = "Task Id 1";
			txtTaskId.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtKeyboardModel
			// 
			txtKeyboardModel.BackColor = Color.FromArgb(89, 89, 89);
			txtKeyboardModel.ForeColor = Color.White;
			txtKeyboardModel.Location = new Point(60, 195);
			txtKeyboardModel.Margin = new Padding(9, 10, 9, 10);
			txtKeyboardModel.Name = "txtKeyboardModel";
			txtKeyboardModel.PlaceholderText = "Keyboard";
			txtKeyboardModel.Size = new Size(430, 55);
			txtKeyboardModel.TabIndex = 1;
			// 
			// txtQuantity
			// 
			txtQuantity.BackColor = Color.FromArgb(89, 89, 89);
			txtQuantity.ForeColor = Color.White;
			txtQuantity.Location = new Point(514, 195);
			txtQuantity.Margin = new Padding(9, 10, 9, 10);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.PlaceholderText = "Quantity";
			txtQuantity.Size = new Size(410, 55);
			txtQuantity.TabIndex = 3;
			// 
			// txtDateCreated
			// 
			txtDateCreated.BackColor = Color.FromArgb(89, 89, 89);
			txtDateCreated.ForeColor = Color.White;
			txtDateCreated.Location = new Point(514, 355);
			txtDateCreated.Margin = new Padding(9, 10, 9, 10);
			txtDateCreated.Name = "txtDateCreated";
			txtDateCreated.PlaceholderText = "Date Created";
			txtDateCreated.ReadOnly = true;
			txtDateCreated.Size = new Size(410, 55);
			txtDateCreated.TabIndex = 5;
			// 
			// btnSaveCard
			// 
			btnSaveCard.BackColor = Color.FromArgb(73, 221, 254);
			btnSaveCard.FlatStyle = FlatStyle.Flat;
			btnSaveCard.ForeColor = Color.White;
			btnSaveCard.Location = new Point(543, 29);
			btnSaveCard.Margin = new Padding(9, 10, 9, 10);
			btnSaveCard.Name = "btnSaveCard";
			btnSaveCard.Size = new Size(191, 86);
			btnSaveCard.TabIndex = 6;
			btnSaveCard.Text = "Save";
			btnSaveCard.UseVisualStyleBackColor = false;
			btnSaveCard.Click += btnSaveCard_Click;
			// 
			// btnDeleteCard
			// 
			btnDeleteCard.BackColor = Color.FromArgb(73, 221, 254);
			btnDeleteCard.FlatStyle = FlatStyle.Flat;
			btnDeleteCard.ForeColor = Color.White;
			btnDeleteCard.Location = new Point(740, 29);
			btnDeleteCard.Margin = new Padding(9, 10, 9, 10);
			btnDeleteCard.Name = "btnDeleteCard";
			btnDeleteCard.Size = new Size(191, 86);
			btnDeleteCard.TabIndex = 7;
			btnDeleteCard.Text = "Delete";
			btnDeleteCard.UseVisualStyleBackColor = false;
			btnDeleteCard.Click += btnDeleteCard_Click;
			// 
			// cbbxStatus
			// 
			cbbxStatus.BackColor = Color.FromArgb(89, 89, 89);
			cbbxStatus.ForeColor = Color.White;
			cbbxStatus.FormattingEnabled = true;
			cbbxStatus.Items.AddRange(new object[] { "New", "Pending", "In Progress", "Stalled", "Done" });
			cbbxStatus.Location = new Point(60, 355);
			cbbxStatus.Margin = new Padding(9, 10, 9, 10);
			cbbxStatus.Name = "cbbxStatus";
			cbbxStatus.Size = new Size(430, 56);
			cbbxStatus.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(60, 137);
			label1.Name = "label1";
			label1.Size = new Size(338, 48);
			label1.TabIndex = 9;
			label1.Text = "Keyboard Model No.";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(514, 137);
			label2.Name = "label2";
			label2.Size = new Size(157, 48);
			label2.TabIndex = 10;
			label2.Text = "Quantity";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(60, 297);
			label3.Name = "label3";
			label3.Size = new Size(116, 48);
			label3.TabIndex = 11;
			label3.Text = "Status";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(525, 297);
			label4.Name = "label4";
			label4.Size = new Size(230, 48);
			label4.TabIndex = 12;
			label4.Text = "Date Created";
			// 
			// frmTaskCard
			// 
			AutoScaleDimensions = new SizeF(20F, 48F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(120, 120, 120);
			ClientSize = new Size(1011, 467);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cbbxStatus);
			Controls.Add(btnDeleteCard);
			Controls.Add(btnSaveCard);
			Controls.Add(txtDateCreated);
			Controls.Add(txtQuantity);
			Controls.Add(txtKeyboardModel);
			Controls.Add(txtTaskId);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(9, 10, 9, 10);
			Name = "frmTaskCard";
			Text = "frmTaskCard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label txtTaskId;
		private TextBox txtKeyboardModel;
		private TextBox txtQuantity;
		private TextBox txtDateCreated;
		private Button btnSaveCard;
		private Button btnDeleteCard;
		private ComboBox cbbxStatus;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}