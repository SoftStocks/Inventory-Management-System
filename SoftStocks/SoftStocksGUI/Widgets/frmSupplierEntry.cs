using SoftStocksData;
using SoftStocksData.Entities.Suppliers;
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
		public frmSupplierEntry(string name = "", string contact = "", string purchases = "", string address = "")
		{
			InitializeComponent();

			this.lblSupplierNameEntry.Text = name;
			this.lblSupplierContactNumberEntry.Text = contact;
			this.lblSupplierContactNameEntry.Text = purchases;
			this.lblSupplierAddressEntry.Text = address;

		}

		private void btnSupplierDelete_Click(object sender, EventArgs e)
		{

			//dlete from database

			this.Close();
		}
		private void btnSupplierSave_Click(object sender, EventArgs e)
		{


			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{

				var queryResult = db.Suppliers.SqlQuery($"SELECT * FROM Supplier WHERE Name == {this.lblSupplierNameEntry.Text}");
				//MessageBox.Show(queryResult);   //need fixing this just to test what query result is

				Supplier newSupplier = new Supplier
				{
					Name = this.lblSupplierNameEntry.Text,
					ContactNumber = this.lblSupplierContactNumberEntry.Text,
					PrimaryContact = this.lblSupplierContactNameEntry.Text,
					BusinessAddress = this.lblSupplierAddressEntry.Text
				};
				db.Suppliers.Add(newSupplier);
				db.SaveChanges();

			}

		}


		private void lblSupplierNameEntry_TextChanged(object sender, EventArgs ge)
		{

		}

	}

}