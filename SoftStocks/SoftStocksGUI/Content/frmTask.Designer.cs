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
			pnlEntryLabels = new Panel();
			lblTaskStatus = new Label();
			lblTaskDate = new Label();
			lblTaskName = new Label();
			pnlTaskBanner = new Panel();
			btnAddTask = new Button();
			pnlScrollableTask = new FlowLayoutPanel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			panel1 = new Panel();
			panel2 = new Panel();
			pnlEntryLabels.SuspendLayout();
			pnlTaskBanner.SuspendLayout();
			pnlScrollableTask.SuspendLayout();
			SuspendLayout();
			// 
			// pnlEntryLabels
			// 
			pnlEntryLabels.Controls.Add(lblTaskStatus);
			pnlEntryLabels.Controls.Add(lblTaskDate);
			pnlEntryLabels.Controls.Add(lblTaskName);
			pnlEntryLabels.Dock = DockStyle.Top;
			pnlEntryLabels.Location = new Point(0, 66);
			pnlEntryLabels.Name = "pnlEntryLabels";
			pnlEntryLabels.Size = new Size(765, 66);
			pnlEntryLabels.TabIndex = 3;
			// 
			// lblTaskStatus
			// 
			lblTaskStatus.Dock = DockStyle.Left;
			lblTaskStatus.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskStatus.ForeColor = Color.White;
			lblTaskStatus.Location = new Point(310, 0);
			lblTaskStatus.Name = "lblTaskStatus";
			lblTaskStatus.Size = new Size(155, 66);
			lblTaskStatus.TabIndex = 2;
			lblTaskStatus.Text = "Status";
			lblTaskStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTaskDate
			// 
			lblTaskDate.Dock = DockStyle.Left;
			lblTaskDate.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskDate.ForeColor = Color.White;
			lblTaskDate.Location = new Point(155, 0);
			lblTaskDate.Name = "lblTaskDate";
			lblTaskDate.Size = new Size(155, 66);
			lblTaskDate.TabIndex = 1;
			lblTaskDate.Text = "Date Created";
			lblTaskDate.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTaskName
			// 
			lblTaskName.Dock = DockStyle.Left;
			lblTaskName.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskName.ForeColor = Color.White;
			lblTaskName.Location = new Point(0, 0);
			lblTaskName.Name = "lblTaskName";
			lblTaskName.Size = new Size(155, 66);
			lblTaskName.TabIndex = 0;
			lblTaskName.Text = "Task Name";
			lblTaskName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlTaskBanner
			// 
			pnlTaskBanner.Controls.Add(btnAddTask);
			pnlTaskBanner.Dock = DockStyle.Top;
			pnlTaskBanner.Location = new Point(0, 0);
			pnlTaskBanner.Name = "pnlTaskBanner";
			pnlTaskBanner.Size = new Size(765, 66);
			pnlTaskBanner.TabIndex = 2;
			// 
			// btnAddTask
			// 
			btnAddTask.BackColor = Color.FromArgb(73, 221, 254);
			btnAddTask.Dock = DockStyle.Right;
			btnAddTask.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddTask.ForeColor = Color.White;
			btnAddTask.Location = new Point(570, 0);
			btnAddTask.Name = "btnAddTask";
			btnAddTask.Size = new Size(195, 66);
			btnAddTask.TabIndex = 0;
			btnAddTask.Text = "Create New Task";
			btnAddTask.UseVisualStyleBackColor = false;
			btnAddTask.Click += btnAddTask_Click;
			// 
			// pnlScrollableTask
			// 
			pnlScrollableTask.AutoScroll = true;
			pnlScrollableTask.Controls.Add(panel2);
			pnlScrollableTask.Controls.Add(panel1);
			pnlScrollableTask.Dock = DockStyle.Left;
			pnlScrollableTask.Location = new Point(0, 132);
			pnlScrollableTask.Name = "pnlScrollableTask";
			pnlScrollableTask.Size = new Size(382, 318);
			pnlScrollableTask.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.Dock = DockStyle.Right;
			flowLayoutPanel1.Location = new Point(383, 132);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(382, 318);
			flowLayoutPanel1.TabIndex = 5;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(120, 120, 120);
			panel1.Location = new Point(12, 11);
			panel1.Name = "panel1";
			panel1.Size = new Size(354, 146);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(120, 120, 120);
			panel2.Location = new Point(12, 163);
			panel2.Name = "panel2";
			panel2.Size = new Size(354, 143);
			panel2.TabIndex = 1;
			// 
			// frmTask
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(765, 450);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(pnlScrollableTask);
			Controls.Add(pnlEntryLabels);
			Controls.Add(pnlTaskBanner);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(1);
			Name = "frmTask";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SoftStocks Inventory Management System";
			pnlEntryLabels.ResumeLayout(false);
			pnlTaskBanner.ResumeLayout(false);
			pnlScrollableTask.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlEntryLabels;
		private Label lblTaskStatus;
		private Label lblTaskDate;
		private Label lblTaskName;
		private Panel pnlTaskBanner;
		private Button btnAddTask;
		private FlowLayoutPanel pnlScrollableTask;
		private FlowLayoutPanel flowLayoutPanel1;
		private Panel panel2;
		private Panel panel1;
	}
}