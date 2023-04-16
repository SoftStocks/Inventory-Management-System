using SoftStocksData;
using SoftStocksData.Entities.Purchases;
using SoftStocksData.Entities.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftStocksGUI.Widgets
{
	public partial class frmTaskCard : Form
	{

		private static int TaskID = 0;
		private static Boolean methodHasRun = false;
		private int tskId = 0;

		public static void getlastRowNo()
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				/*if (methodHasRun == false)
				{
					TaskID = db.PurchaseRequests.Count();
					methodHasRun = true;
				}*/

				var temp = db.PurchaseRequests.OrderByDescending(u => u.Id).FirstOrDefault();
				MessageBox.Show($"{temp}");

				if (temp == null)
				{
					TaskID = 1;
				}
				else
				{
					TaskID = temp.Id++;
				}
				
			}
		}

		public frmTaskCard(int taskId = -1, int keyboardModel = 0, int quantity = 0, string status = "New", string dateCreated = "")
		{
			InitializeComponent();


			if (dateCreated == "")
			{
				dateCreated = DateTime.Now.ToString();
			}


			if (taskId == -1)
			{
				getlastRowNo();
				taskId = TaskID;
			}

			tskId = taskId;

			this.txtTaskId.Text = $"ID {taskId}";
			this.txtKeyboardModel.Text = keyboardModel.ToString();
			this.txtQuantity.Text = quantity.ToString();
			this.cbbxStatus.Text = status;
			this.txtDateCreated.Text = dateCreated;
		}

		private void btnSaveCard_Click(object sender, EventArgs e)
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				var row = db.PurchaseRequests.FirstOrDefault(s => s.Id == tskId);
				if (row != null)
				{
					row.ModelNumber = Convert.ToInt32(this.txtKeyboardModel.Text);
					row.Quantity = Convert.ToInt32(this.txtQuantity.Text);
					row.Status = this.cbbxStatus.Text;
					row.DateCreated = Convert.ToDateTime(this.txtDateCreated.Text);
				}
				else
				{
					PurchaseRequest newPurReq = new PurchaseRequest
					{
						ModelNumber = Convert.ToInt32(this.txtKeyboardModel.Text),
						Quantity = Convert.ToInt32(this.txtQuantity.Text),
						Status = this.cbbxStatus.Text,
						DateCreated = Convert.ToDateTime(this.txtDateCreated.Text)
					};
					db.PurchaseRequests.Add(newPurReq);
				}

				db.SaveChanges();
			}
		}

		private void btnDeleteCard_Click(object sender, EventArgs e)
		{
			deleteRowFromDB();
		}

		private void deleteRowFromDB()
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				var TaskRow = new PurchaseRequest { Id = tskId };
				db.PurchaseRequests.Attach(TaskRow);
				db.PurchaseRequests.Remove(TaskRow);
				db.SaveChanges();
			}

			this.Close();
		}
	}
}
