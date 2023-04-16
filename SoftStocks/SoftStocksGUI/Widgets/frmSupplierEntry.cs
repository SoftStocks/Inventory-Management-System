using SoftStocksData;
using SoftStocksData.Entities.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SoftStocksGUI.Widgets
{
	public partial class frmSupplierEntry : Form
	{

		private int entryId;

		public frmSupplierEntry(string name = "", string contact = "", string purchases = "", string address = "", int id = 0)
		{
			InitializeComponent();

			entryId = id;

			this.lblSupplierNameEntry.Text = name;
			this.lblSupplierContactNumberEntry.Text = contact;
			this.lblSupplierContactNameEntry.Text = purchases;
			this.lblSupplierAddressEntry.Text = address;
			this.lblSupplierId.Text = $"{id}";

		}

		private void btnSupplierDelete_Click(object sender, EventArgs e)
		{
			deleteRowFromDB();
		}

		private void btnSupplierSave_Click(object sender, EventArgs e)
		{

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				var row = db.Suppliers.FirstOrDefault(s => s.Id == entryId);
				if (row != null)
				{
					row.Name = this.lblSupplierNameEntry.Text;
					row.ContactNumber = this.lblSupplierContactNumberEntry.Text;
					row.PrimaryContact = this.lblSupplierContactNameEntry.Text;
					row.BusinessAddress = this.lblSupplierAddressEntry.Text;
				}
				else
				{
					Supplier newSupplier = new Supplier
					{
						Name = this.lblSupplierNameEntry.Text,
						ContactNumber = this.lblSupplierContactNumberEntry.Text,
						PrimaryContact = this.lblSupplierContactNameEntry.Text,
						BusinessAddress = this.lblSupplierAddressEntry.Text
					};
					db.Suppliers.Add(newSupplier);
				}

				db.SaveChanges();
			}

		}


		private void lblSupplierNameEntry_TextChanged(object sender, EventArgs ge)
		{
			removeRowifBlank();
		}

		private void lblSupplierContactNumberEntry_TextChanged(object sender, EventArgs e)
		{
			removeRowifBlank();
		}


		private void lblSupplierContactNameEntry_TextChanged(object sender, EventArgs e)
		{
			removeRowifBlank();
		}

		private void lblSupplierAddressEntry_TextChanged(object sender, EventArgs e)
		{
			removeRowifBlank();
		}

		private void removeRowifBlank()
		{
			if (lblSupplierNameEntry.Text == String.Empty && lblSupplierContactNumberEntry.Text == String.Empty && lblSupplierContactNameEntry.Text == String.Empty && lblSupplierAddressEntry.Text == String.Empty)
			{
				deleteRowFromDB();
			}
		}

		private void deleteRowFromDB()
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				var supplierRow = new Supplier { Id = entryId };
				db.Suppliers.Attach(supplierRow);
				db.Suppliers.Remove(supplierRow);
				db.SaveChanges();
			}

			this.Close();
		}
	}
}