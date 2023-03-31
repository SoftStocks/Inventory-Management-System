using SoftStocksGUI.Widgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftStocksGUI
{
	public partial class frmTask : Form
	{
		public frmTask()
		{
			InitializeComponent();
			//this.pnlScrollableTask.Controls.Clear();

			for (int i = 0; i < 10; i++)
			{
				frmTaskEntry frmTaskEntry_Vrb = new frmTaskEntry() { TopLevel = false, TopMost = true };
				frmTaskEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
				this.pnlScrollableTask.Controls.Add(frmTaskEntry_Vrb);
				frmTaskEntry_Vrb.Show();
			}
		}

		private void btnAddTask_Click(object sender, EventArgs e)
		{
			frmTaskEntry frmTaskEntry_Vrb = new frmTaskEntry() { TopLevel = false, TopMost = true };
			frmTaskEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
			this.pnlScrollableTask.Controls.Add(frmTaskEntry_Vrb);
			frmTaskEntry_Vrb.Show();
		}
	}
}
