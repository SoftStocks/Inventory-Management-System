using SoftStocksData;
using SoftStocksData.Entities.Purchases;
using SoftStocksData.Entities.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

		private int taskId;
		public frmTaskCard(int id = -1, int keyboardModel = 0, int quantity = 0, string status = "New", string dateCreated = "")
		{
			InitializeComponent();

			taskId = id;

			if (dateCreated == "")
			{
				dateCreated = DateTime.Now.ToString();
			}

			this.txtTaskId.Text = $"Task Id {taskId}";
			this.txtKeyboardModel.Text = keyboardModel.ToString();
			this.txtQuantity.Text = quantity.ToString();
			this.cbbxStatus.Text = status;
			this.txtDateCreated.Text = dateCreated;

			if (taskId == -1)
			{
				Random rnd = new Random();
				//long identifier = rnd.NextInt64(1, 999999999999999999);#
				long identifier = 999999999999999999;
				using (SoftStocksDBContext db = new SoftStocksDBContext())


				{
					var uniqueQuery = db.PurchaseRequests.SingleOrDefault(s => s.Identifier == identifier);
					if (uniqueQuery == null)
					{
						PurchaseRequest newPurchaseRequest = new PurchaseRequest
						{
							Identifier = identifier,
							ModelNumber = Convert.ToInt32(this.txtKeyboardModel.Text),
							Quantity = Convert.ToInt32(this.txtQuantity.Text),
							Status = this.cbbxStatus.Text,
							DateCreated = Convert.ToDateTime(this.txtDateCreated.Text)
						};

						db.PurchaseRequests.Add(newPurchaseRequest);
						db.SaveChanges();

						var row = db.PurchaseRequests.Single(s => s.Identifier == identifier);
						if (row != null)
						{
							taskId = row.Id;
							this.txtTaskId.Text = "New Task";
						}
					}
					else
					{
						MessageBox.Show("Must First Change and Save New Task!");
						this.Close();
					}
				}
			}
		}

		private void btnSaveCard_Click(object sender, EventArgs e)
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				var row = db.PurchaseRequests.FirstOrDefault(s => s.Id == taskId);
				if (row != null)
				{
					row.Identifier = taskId + 1;
					row.ModelNumber = Convert.ToInt32(this.txtKeyboardModel.Text);
					row.Quantity = Convert.ToInt32(this.txtQuantity.Text);
					row.Status = this.cbbxStatus.Text;
					row.DateCreated = Convert.ToDateTime(this.txtDateCreated.Text);
				}
				this.txtTaskId.Text = $"Task Id {taskId}";
				/*
				else
				{
					PurchaseRequest newPurReq = new PurchaseRequest
					{
						Identifier = taskId + 1,
						ModelNumber = Convert.ToInt32(this.txtKeyboardModel.Text),
						Quantity = Convert.ToInt32(this.txtQuantity.Text),
						Status = this.cbbxStatus.Text,
						DateCreated = Convert.ToDateTime(this.txtDateCreated.Text)
					};
					db.PurchaseRequests.Add(newPurReq);
				}
				*/

				db.SaveChanges();
			}
		}

		private void btnDeleteCard_Click(object sender, EventArgs e)
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				PurchaseRequest purchaseRow = db.PurchaseRequests.Find(taskId);
				db.PurchaseRequests.Remove(purchaseRow);
				db.SaveChanges();
			}
			this.Close();
		}
	}
}
