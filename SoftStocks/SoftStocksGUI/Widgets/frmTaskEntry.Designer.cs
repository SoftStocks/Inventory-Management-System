namespace SoftStocksGUI.Widgets
{
	partial class frmTaskEntry
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
			lblTaskNameEntry = new Label();
			lblTaskDateEntry = new Label();
			lblTaskStatusEntry = new Label();
			btnTaskDelete = new Button();
			btnTaskDone = new Button();
			SuspendLayout();
			// 
			// lblTaskNameEntry
			// 
			lblTaskNameEntry.Dock = DockStyle.Left;
			lblTaskNameEntry.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskNameEntry.ForeColor = Color.White;
			lblTaskNameEntry.Location = new Point(0, 0);
			lblTaskNameEntry.Name = "lblTaskNameEntry";
			lblTaskNameEntry.Size = new Size(155, 66);
			lblTaskNameEntry.TabIndex = 0;
			lblTaskNameEntry.Text = "Buy";
			lblTaskNameEntry.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTaskDateEntry
			// 
			lblTaskDateEntry.Dock = DockStyle.Left;
			lblTaskDateEntry.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskDateEntry.ForeColor = Color.White;
			lblTaskDateEntry.Location = new Point(155, 0);
			lblTaskDateEntry.Name = "lblTaskDateEntry";
			lblTaskDateEntry.Size = new Size(155, 66);
			lblTaskDateEntry.TabIndex = 1;
			lblTaskDateEntry.Text = "12/03/2002\r\n12:23:01";
			lblTaskDateEntry.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTaskStatusEntry
			// 
			lblTaskStatusEntry.Dock = DockStyle.Left;
			lblTaskStatusEntry.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTaskStatusEntry.ForeColor = Color.White;
			lblTaskStatusEntry.Location = new Point(310, 0);
			lblTaskStatusEntry.Name = "lblTaskStatusEntry";
			lblTaskStatusEntry.Size = new Size(155, 66);
			lblTaskStatusEntry.TabIndex = 2;
			lblTaskStatusEntry.Text = "Pending";
			lblTaskStatusEntry.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnTaskDelete
			// 
			btnTaskDelete.BackColor = Color.FromArgb(73, 221, 254);
			btnTaskDelete.Dock = DockStyle.Right;
			btnTaskDelete.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnTaskDelete.ForeColor = Color.White;
			btnTaskDelete.Location = new Point(638, 0);
			btnTaskDelete.Name = "btnTaskDelete";
			btnTaskDelete.Size = new Size(102, 66);
			btnTaskDelete.TabIndex = 3;
			btnTaskDelete.Text = "Delete";
			btnTaskDelete.UseVisualStyleBackColor = false;
			btnTaskDelete.Click += btnTaskDelete_Click;
			// 
			// btnTaskDone
			// 
			btnTaskDone.BackColor = Color.FromArgb(73, 221, 254);
			btnTaskDone.Dock = DockStyle.Right;
			btnTaskDone.Font = new Font("Verdana Pro Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnTaskDone.ForeColor = Color.White;
			btnTaskDone.Location = new Point(536, 0);
			btnTaskDone.Name = "btnTaskDone";
			btnTaskDone.Size = new Size(102, 66);
			btnTaskDone.TabIndex = 4;
			btnTaskDone.Text = "Mark Done";
			btnTaskDone.UseVisualStyleBackColor = false;
			btnTaskDone.Click += btnTaskDone_Click;
			// 
			// frmTaskEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(89, 89, 89);
			ClientSize = new Size(740, 66);
			Controls.Add(btnTaskDone);
			Controls.Add(btnTaskDelete);
			Controls.Add(lblTaskStatusEntry);
			Controls.Add(lblTaskDateEntry);
			Controls.Add(lblTaskNameEntry);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmTaskEntry";
			Text = "frmTaskEntry";
			ResumeLayout(false);
		}

		#endregion

		private Label lblTaskNameEntry;
		private Label lblTaskDateEntry;
		private Label lblTaskStatusEntry;
		private Button btnTaskDelete;
		private Button btnTaskDone;
	}
}