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
			btnReportDelete.Location = new Point(577, 0);
			btnReportDelete.Name = "btnReportDelete";
			btnReportDelete.Size = new Size(102, 66);
			btnReportDelete.TabIndex = 4;
			btnReportDelete.Text = "Delete";
			btnReportDelete.UseVisualStyleBackColor = false;
			btnReportDelete.Click += btnReportDelete_Click;
			// 
			// btnReportView
			// 
			btnReportView.BackColor = Color.FromArgb(73, 221, 254);
			btnReportView.Dock = DockStyle.Right;
			btnReportView.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnReportView.ForeColor = Color.White;
			btnReportView.Location = new Point(475, 0);
			btnReportView.Name = "btnReportView";
			btnReportView.Size = new Size(102, 66);
			btnReportView.TabIndex = 5;
			btnReportView.Text = "View";
			btnReportView.UseVisualStyleBackColor = false;
			btnReportView.Click += btnReportView_Click;
			// 
			// lblReportId
			// 
			lblReportId.BackColor = Color.FromArgb(89, 89, 89);
			lblReportId.BorderStyle = BorderStyle.None;
			lblReportId.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblReportId.ForeColor = Color.White;
			lblReportId.Location = new Point(12, 26);
			lblReportId.Name = "lblReportId";
			lblReportId.PlaceholderText = "ReportId";
			lblReportId.ReadOnly = true;
			lblReportId.Size = new Size(240, 17);
			lblReportId.TabIndex = 6;
			lblReportId.TextAlign = HorizontalAlignment.Center;
			// 
			// lblReportDateCreated
			// 
			lblReportDateCreated.BackColor = Color.FromArgb(89, 89, 89);
			lblReportDateCreated.BorderStyle = BorderStyle.None;
			lblReportDateCreated.Font = new Font("Microsoft Sans Serif", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblReportDateCreated.ForeColor = Color.White;
			lblReportDateCreated.Location = new Point(259, 26);
			lblReportDateCreated.Name = "lblReportDateCreated";
			lblReportDateCreated.PlaceholderText = "Date created";
			lblReportDateCreated.ReadOnly = true;
			lblReportDateCreated.Size = new Size(210, 17);
			lblReportDateCreated.TabIndex = 8;
			lblReportDateCreated.TextAlign = HorizontalAlignment.Center;
			// 
			// frmReportEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(679, 66);
			Controls.Add(lblReportDateCreated);
			Controls.Add(lblReportId);
			Controls.Add(btnReportView);
			Controls.Add(btnReportDelete);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(1);
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