using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftStocksGUI.Widgets
{
	public partial class frmTaskEntry : Form
	{
		public frmTaskEntry(string name = "Buy", string date = "12/05/2002\n12:32:01", string status = "Pending")
		{
			InitializeComponent();

			this.lblTaskNameEntry.Text = name;
			this.lblTaskDateEntry.Text = date;
			this.lblTaskStatusEntry.Text = status;
		}

		private void btnTaskDelete_Click(object sender, EventArgs e)
		{
			//delete from database

			this.Close();
		}

		private void btnTaskDone_Click(object sender, EventArgs e)
		{
			this.lblTaskStatusEntry.Text = "Done";
		}
	}
}
