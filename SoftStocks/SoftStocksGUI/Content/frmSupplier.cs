using SoftStocksData;
using SoftStocksData.Entities.Suppliers;
using SoftStocksGUI.Content;
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
	public partial class frmSupplier : Form
	{
		public frmSupplier()
		{
			InitializeComponent();

			List<Supplier> supplierList;

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				supplierList = db.Suppliers.ToList();
			}

			foreach (Supplier supplierItem in supplierList)
			{
				frmSupplierEntry frmSupplierEntry_Vrb = new frmSupplierEntry(supplierItem.Id, supplierItem.Name, supplierItem.ContactNumber, supplierItem.PrimaryContact, supplierItem.BusinessAddress) { TopLevel = false, TopMost = true };
				frmSupplierEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
				this.pnlScrollableSupplier.Controls.Add(frmSupplierEntry_Vrb);
				frmSupplierEntry_Vrb.Show();
			}

		}

		private void btnAddSupplier_Click(object sender, EventArgs e)
		{

			frmSupplierEntry frmSupplierEntry_Vrb = new frmSupplierEntry() { TopLevel = false, TopMost = true };
			frmSupplierEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
			this.pnlScrollableSupplier.Controls.Add(frmSupplierEntry_Vrb);
			try
			{
				frmSupplierEntry_Vrb.Show();
			}
			catch (Exception)
			{
				//MessageBox.Show($"{ex}");  //If entry is deleted before being able to be shown then hides error
			}


		}
	}
}
