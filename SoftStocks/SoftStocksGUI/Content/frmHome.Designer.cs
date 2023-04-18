namespace SoftStocksGUI
{
	partial class frmHome
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
			label1=new Label();
			dataGridView1=new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Font=new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor=Color.White;
			label1.Location=new Point(296, 48);
			label1.Name="label1";
			label1.Size=new Size(256, 41);
			label1.TabIndex=0;
			label1.Text="Current Stock";
			label1.TextAlign=ContentAlignment.TopCenter;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location=new Point(118, 122);
			dataGridView1.Name="dataGridView1";
			dataGridView1.RowHeadersWidth=51;
			dataGridView1.RowTemplate.Height=29;
			dataGridView1.Size=new Size(652, 360);
			dataGridView1.TabIndex=3;
			// 
			// frmHome
			// 
			AutoScaleDimensions=new SizeF(8F, 20F);
			AutoScaleMode=AutoScaleMode.Font;
			BackColor=Color.FromArgb(89, 89, 89);
			ClientSize=new Size(874, 600);
			Controls.Add(dataGridView1);
			Controls.Add(label1);
			FormBorderStyle=FormBorderStyle.None;
			Margin=new Padding(1);
			Name="frmHome";
			StartPosition=FormStartPosition.CenterScreen;
			Text="SoftStocks Inventory Management System";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dataGridView1;
	}
}