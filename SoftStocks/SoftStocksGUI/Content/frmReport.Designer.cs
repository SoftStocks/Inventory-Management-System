namespace SoftStocksGUI
{
	partial class frmReport
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
			pnlEntryLabels = new Panel();
			lblDateCreated = new Label();
			lblReportType = new Label();
			lblReportId = new Label();
			pnlScrollableReport = new FlowLayoutPanel();
			pnlEntryLabels.SuspendLayout();
			SuspendLayout();
			// 
			// pnlEntryLabels
			// 
			pnlEntryLabels.Controls.Add(lblDateCreated);
			pnlEntryLabels.Controls.Add(lblReportType);
			pnlEntryLabels.Controls.Add(lblReportId);
			pnlEntryLabels.Dock = DockStyle.Top;
			pnlEntryLabels.Location = new Point(0, 0);
			pnlEntryLabels.Margin = new Padding(9, 10, 9, 10);
			pnlEntryLabels.Name = "pnlEntryLabels";
			pnlEntryLabels.Size = new Size(2186, 211);
			pnlEntryLabels.TabIndex = 2;
			// 
			// lblDateCreated
			// 
			lblDateCreated.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblDateCreated.ForeColor = Color.White;
			lblDateCreated.Location = new Point(879, 0);
			lblDateCreated.Margin = new Padding(9, 0, 9, 0);
			lblDateCreated.Name = "lblDateCreated";
			lblDateCreated.Size = new Size(286, 211);
			lblDateCreated.TabIndex = 2;
			lblDateCreated.Text = "Date Created";
			lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblReportType
			// 
			lblReportType.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblReportType.ForeColor = Color.White;
			lblReportType.Location = new Point(455, 0);
			lblReportType.Margin = new Padding(9, 0, 9, 0);
			lblReportType.Name = "lblReportType";
			lblReportType.Size = new Size(286, 211);
			lblReportType.TabIndex = 1;
			lblReportType.Text = "Report Type";
			lblReportType.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblReportId
			// 
			lblReportId.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblReportId.ForeColor = Color.White;
			lblReportId.Location = new Point(46, 0);
			lblReportId.Margin = new Padding(9, 0, 9, 0);
			lblReportId.Name = "lblReportId";
			lblReportId.Size = new Size(286, 211);
			lblReportId.TabIndex = 0;
			lblReportId.Text = "Report ID";
			lblReportId.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlScrollableReport
			// 
			pnlScrollableReport.AutoScroll = true;
			pnlScrollableReport.Dock = DockStyle.Fill;
			pnlScrollableReport.FlowDirection = FlowDirection.TopDown;
			pnlScrollableReport.Location = new Point(0, 211);
			pnlScrollableReport.Margin = new Padding(9, 10, 9, 10);
			pnlScrollableReport.Name = "pnlScrollableReport";
			pnlScrollableReport.Size = new Size(2186, 1229);
			pnlScrollableReport.TabIndex = 4;
			pnlScrollableReport.WrapContents = false;
			// 
			// frmReport
			// 
			AutoScaleDimensions = new SizeF(20F, 48F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(2186, 1440);
			Controls.Add(pnlScrollableReport);
			Controls.Add(pnlEntryLabels);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmReport";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SoftStocks Inventory Management System";
			pnlEntryLabels.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlEntryLabels;
		private Label lblDateCreated;
		private Label lblReportType;
		private Label lblReportId;
		private FlowLayoutPanel pnlScrollableReport;
	}
}