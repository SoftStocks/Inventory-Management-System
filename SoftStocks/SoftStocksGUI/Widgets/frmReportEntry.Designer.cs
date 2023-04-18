namespace SoftStocksGUI.Widgets
{
	partial class frmReportEntry
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
			btnReportDelete = new Button();
			btnReportView = new Button();
			lblReportId = new TextBox();
			lblReportDateCreated = new TextBox();
			SuspendLayout();
			// 
			// btnReportDelete
			// 
			btnReportDelete.BackColor = Color.FromArgb(73, 221, 254);
			btnReportDelete.Dock = DockStyle.Right;
			btnReportDelete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnReportDelete.ForeColor = Color.White;
			btnReportDelete.Location = new Point(1795, 0);
			btnReportDelete.Margin = new Padding(9, 10, 9, 10);
			btnReportDelete.Name = "btnReportDelete";
			btnReportDelete.Size = new Size(291, 211);
			btnReportDelete.TabIndex = 4;
			btnReportDelete.Text = "Delete";
			btnReportDelete.UseVisualStyleBackColor = false;
			// 
			// btnReportView
			// 
			btnReportView.BackColor = Color.FromArgb(73, 221, 254);
			btnReportView.Dock = DockStyle.Right;
			btnReportView.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnReportView.ForeColor = Color.White;
			btnReportView.Location = new Point(1504, 0);
			btnReportView.Margin = new Padding(9, 10, 9, 10);
			btnReportView.Name = "btnReportView";
			btnReportView.Size = new Size(291, 211);
			btnReportView.TabIndex = 5;
			btnReportView.Text = "View";
			btnReportView.UseVisualStyleBackColor = false;
			// 
			// lblReportId
			// 
			lblReportId.BackColor = Color.FromArgb(89, 89, 89);
			lblReportId.BorderStyle = BorderStyle.None;
			lblReportId.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblReportId.ForeColor = Color.White;
			lblReportId.Location = new Point(262, 85);
			lblReportId.Margin = new Padding(9, 10, 9, 10);
			lblReportId.Name = "lblReportId";
			lblReportId.PlaceholderText = "ReportId";
			lblReportId.Size = new Size(400, 49);
			lblReportId.TabIndex = 6;
			lblReportId.TextAlign = HorizontalAlignment.Center;
			// 
			// lblReportDateCreated
			// 
			lblReportDateCreated.BackColor = Color.FromArgb(89, 89, 89);
			lblReportDateCreated.BorderStyle = BorderStyle.None;
			lblReportDateCreated.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblReportDateCreated.ForeColor = Color.White;
			lblReportDateCreated.Location = new Point(725, 85);
			lblReportDateCreated.Margin = new Padding(9, 10, 9, 10);
			lblReportDateCreated.Name = "lblReportDateCreated";
			lblReportDateCreated.PlaceholderText = "Date created";
			lblReportDateCreated.Size = new Size(600, 49);
			lblReportDateCreated.TabIndex = 8;
			lblReportDateCreated.TextAlign = HorizontalAlignment.Center;
			lblReportDateCreated.TextChanged += lblReportDateCreated_TextChanged;
			// 
			// frmReportEntry
			// 
			AutoScaleDimensions = new SizeF(20F, 48F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(2086, 211);
			Controls.Add(lblReportDateCreated);
			Controls.Add(lblReportId);
			Controls.Add(btnReportView);
			Controls.Add(btnReportDelete);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmReportEntry";
			Text = "frmReportEntry";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnReportDelete;
		private Button btnReportView;
		private TextBox lblReportId;
		private TextBox lblReportDateCreated;
	}
}