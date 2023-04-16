using SoftStocksData.Entities.Suppliers;
using SoftStocksData;
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
using SoftStocksData.Entities.Purchases;

namespace SoftStocksGUI
{
	public partial class frmTask : Form
	{
		public frmTask()
		{
			InitializeComponent();
			//this.pnlScrollableTask.Controls.Clear();

			List<PurchaseRequest> TaskList;

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				TaskList = db.PurchaseRequests.ToList();
			}

			foreach (PurchaseRequest TaskItem in TaskList)
			{
				frmTaskCard frmTaskCard_Vrb = new frmTaskCard(TaskItem.Id, TaskItem.ModelNumber, TaskItem.Quantity, TaskItem.Status, TaskItem.DateCreated.ToString())
				{ TopLevel = false, TopMost = true };
				frmTaskCard_Vrb.FormBorderStyle = FormBorderStyle.None;
				this.pnlScrollableTask.Controls.Add(frmTaskCard_Vrb);
				frmTaskCard_Vrb.Show();
			}
		}

		private void btnAddTask_Click(object sender, EventArgs e)
		{
			frmTaskCard frmTaskCard_Vrb = new frmTaskCard() { TopLevel = false, TopMost = true };
			frmTaskCard_Vrb.FormBorderStyle = FormBorderStyle.None;
			this.pnlScrollableTask.Controls.Add(frmTaskCard_Vrb);
			frmTaskCard_Vrb.Show();
		}
	}
}
