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

		public frmSupplierEntry(int id = -1, string name = "Example Name", string contact = "Example Number", string purchases = "Example Purchases", string address = "Example Address")
		{
			InitializeComponent();

			entryId = id;

			this.lblSupplierNameEntry.Text = name;
			this.lblSupplierContactNumberEntry.Text = contact;
			this.lblSupplierContactNameEntry.Text = purchases;
			this.lblSupplierAddressEntry.Text = address;
			this.lblSupplierId.Text = $"{entryId}";

			if (entryId == -1)
			{
				using (SoftStocksDBContext db = new SoftStocksDBContext())
				{
					var namesQuery = db.Suppliers.SingleOrDefault(s => s.Name == this.lblSupplierNameEntry.Text);
					if (namesQuery == null)
					{
						Supplier newSupplier = new Supplier
						{
							Name = this.lblSupplierNameEntry.Text,
							ContactNumber = this.lblSupplierContactNumberEntry.Text,
							PrimaryContact = this.lblSupplierContactNameEntry.Text,
							BusinessAddress = this.lblSupplierAddressEntry.Text
						};

						db.Suppliers.Add(newSupplier);
						db.SaveChanges();

						var row = db.Suppliers.Single(s => s.Name == name);
						if (row != null)
						{
							entryId = row.Id;
							this.lblSupplierId.Text = $"{entryId}";
						}
					}
					else
					{
						MessageBox.Show("Must First Change Example Entry!");
						this.Close();
					}
				}
			}

		}

		private void btnSupplierDelete_Click(object sender, EventArgs e)
		{
			deleteRowFromDB();
		}

		private void btnSupplierSave_Click(object sender, EventArgs e)
		{

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{

				//Check For Same Names
				var namesQuery = db.Suppliers.SingleOrDefault(s => s.Name == this.lblSupplierNameEntry.Text);
				if (namesQuery == null)
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
				else
				{
					MessageBox.Show("Name Already In Use! Change Name And Try Again.");
				}


			}

		}

		private void removeRowifBlank(object sender, EventArgs e)
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

				//db.Suppliers.RemoveAll(s => s.Id == entryId);
				//var supplierRow = new Supplier { Id = entryId };
				Supplier supplierRow = db.Suppliers.Find(entryId);
				if (supplierRow != null)
				{
					db.Suppliers.Remove(supplierRow);
					db.SaveChanges();
				}
				else
				{
					MessageBox.Show($"Could not delete Supplier, could not find id: {entryId}");
				}
			}
			this.Close();
		}
	}
}