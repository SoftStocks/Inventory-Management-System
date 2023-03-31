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
	public partial class frmSupplierEntry : Form
	{
		public frmSupplierEntry(string name = "John Smiths", string contact = "0733846272", string purchases = "192")
		{
			InitializeComponent();

			this.lblSupplierNameEntry.Text = name;
			this.lblSupplierContactEntry.Text = contact;
			this.lblSupplierPurchasesEntry.Text = purchases;

		}

		private void btnSupplierDelete_Click(object sender, EventArgs e)
		{

			//delete from database

			this.Close();
		}
	}
}
