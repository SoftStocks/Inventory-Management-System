namespace SoftStocksGUI
{
	partial class frmTask
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
			pnlTaskBanner = new Panel();
			btnAddTask = new Button();
			pnlScrollableTask = new FlowLayoutPanel();
			pnlTaskBanner.SuspendLayout();
			SuspendLayout();
			// 
			// pnlTaskBanner
			// 
			pnlTaskBanner.Controls.Add(btnAddTask);
			pnlTaskBanner.Dock = DockStyle.Top;
			pnlTaskBanner.Location = new Point(0, 0);
			pnlTaskBanner.Margin = new Padding(9, 10, 9, 10);
			pnlTaskBanner.Name = "pnlTaskBanner";
			pnlTaskBanner.Size = new Size(2186, 211);
			pnlTaskBanner.TabIndex = 2;
			// 
			// btnAddTask
			// 
			btnAddTask.BackColor = Color.FromArgb(73, 221, 254);
			btnAddTask.Dock = DockStyle.Right;
			btnAddTask.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddTask.ForeColor = Color.White;
			btnAddTask.Location = new Point(1629, 0);
			btnAddTask.Margin = new Padding(9, 10, 9, 10);
			btnAddTask.Name = "btnAddTask";
			btnAddTask.Size = new Size(557, 211);
			btnAddTask.TabIndex = 0;
			btnAddTask.Text = "Create New Task";
			btnAddTask.UseVisualStyleBackColor = false;
			btnAddTask.Click += btnAddTask_Click;
			// 
			// pnlScrollableTask
			// 
			pnlScrollableTask.AutoScroll = true;
			pnlScrollableTask.Location = new Point(36, 211);
			pnlScrollableTask.Margin = new Padding(9, 10, 9, 10);
			pnlScrollableTask.Name = "pnlScrollableTask";
			pnlScrollableTask.Size = new Size(2132, 1229);
			pnlScrollableTask.TabIndex = 4;
			// 
			// frmTask
			// 
			AutoScaleDimensions = new SizeF(20F, 48F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(2186, 1440);
			Controls.Add(pnlScrollableTask);
			Controls.Add(pnlTaskBanner);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmTask";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SoftStocks Inventory Management System";
			pnlTaskBanner.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel pnlTaskBanner;
		private Button btnAddTask;
		private FlowLayoutPanel pnlScrollableTask;
	}
}