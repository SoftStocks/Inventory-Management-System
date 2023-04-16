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
			lblTaskId = new Label();
			textBox1 = new TextBox();
			textBox3 = new TextBox();
			textBox5 = new TextBox();
			btnSaveCard = new Button();
			btnDeleteCard = new Button();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// lblTaskId
			// 
			lblTaskId.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskId.ForeColor = Color.White;
			lblTaskId.Location = new Point(12, 9);
			lblTaskId.Name = "lblTaskId";
			lblTaskId.Size = new Size(172, 27);
			lblTaskId.TabIndex = 0;
			lblTaskId.Text = "Task Id 1";
			lblTaskId.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.FromArgb(89, 89, 89);
			textBox1.Location = new Point(21, 61);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Keyboard";
			textBox1.Size = new Size(153, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.FromArgb(89, 89, 89);
			textBox3.Location = new Point(180, 61);
			textBox3.Name = "textBox3";
			textBox3.PlaceholderText = "Quantity";
			textBox3.Size = new Size(146, 23);
			textBox3.TabIndex = 3;
			// 
			// textBox5
			// 
			textBox5.BackColor = Color.FromArgb(89, 89, 89);
			textBox5.Location = new Point(180, 111);
			textBox5.Name = "textBox5";
			textBox5.PlaceholderText = "Date Created";
			textBox5.ReadOnly = true;
			textBox5.Size = new Size(146, 23);
			textBox5.TabIndex = 5;
			// 
			// btnSaveCard
			// 
			btnSaveCard.BackColor = Color.FromArgb(73, 221, 254);
			btnSaveCard.FlatStyle = FlatStyle.Flat;
			btnSaveCard.ForeColor = Color.White;
			btnSaveCard.Location = new Point(190, 9);
			btnSaveCard.Name = "btnSaveCard";
			btnSaveCard.Size = new Size(67, 27);
			btnSaveCard.TabIndex = 6;
			btnSaveCard.Text = "Save";
			btnSaveCard.UseVisualStyleBackColor = false;
			// 
			// btnDeleteCard
			// 
			btnDeleteCard.BackColor = Color.FromArgb(73, 221, 254);
			btnDeleteCard.FlatStyle = FlatStyle.Flat;
			btnDeleteCard.ForeColor = Color.White;
			btnDeleteCard.Location = new Point(259, 9);
			btnDeleteCard.Name = "btnDeleteCard";
			btnDeleteCard.Size = new Size(67, 27);
			btnDeleteCard.TabIndex = 7;
			btnDeleteCard.Text = "Delete";
			btnDeleteCard.UseVisualStyleBackColor = false;
			// 
			// comboBox1
			// 
			comboBox1.BackColor = Color.FromArgb(89, 89, 89);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(21, 111);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(153, 23);
			comboBox1.TabIndex = 8;
			// 
			// frmTaskCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(120, 120, 120);
			ClientSize = new Size(354, 146);
			Controls.Add(comboBox1);
			Controls.Add(btnDeleteCard);
			Controls.Add(btnSaveCard);
			Controls.Add(textBox5);
			Controls.Add(textBox3);
			Controls.Add(textBox1);
			Controls.Add(lblTaskId);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmTaskCard";
			Text = "frmTaskCard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTaskId;
		private TextBox textBox1;
		private TextBox textBox3;
		private TextBox textBox5;
		private Button btnSaveCard;
		private Button btnDeleteCard;
		private ComboBox comboBox1;
	}
}