using SoftStocksData.Entities.Suppliers;
using SoftStocksData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using SoftStocksData.Entities.Keyboards;

namespace SoftStocksGUI.Widgets
{
	public partial class frmKeyboardEntry : Form
	{
		private int entryId;

		public frmKeyboardEntry(int id = -1, int modelNo = 0, int quantity = 0, Decimal price = 0, int supplierId = 0, string description = "Example Desc.")
		{
			InitializeComponent();

			entryId = modelNo;

			this.lblKeyboardModelNumberEntry.Text = modelNo.ToString();
			this.lblKeyboardQuantityEntry.Text = quantity.ToString();
			this.lblKeyboardPriceEntry.Text = $"£{price}";
			this.lblKeyboardSupplierIdEntry.Text = supplierId.ToString();
			this.lblKeyboardDescriptionEntry.Text = description;

			if (id == -1)
			{
				using (SoftStocksDBContext db = new SoftStocksDBContext())
				{
					int ident = -1;
					var modelQuery = db.Keyboards.SingleOrDefault(s => s.Ident == ident);
					if (modelQuery == null)
					{
						Keyboard newKeyboard = new Keyboard
						{
							Ident = ident,
							Quantity = Convert.ToInt32(this.lblKeyboardQuantityEntry.Text),
							Price = Convert.ToDecimal(this.lblKeyboardPriceEntry.Text.Replace("£", "")),
							SupplierId = Convert.ToInt32(this.lblKeyboardSupplierIdEntry.Text),
							Description = this.lblKeyboardDescriptionEntry.Text
						};

						db.Keyboards.Add(newKeyboard);
						db.SaveChanges();

						var row = db.Keyboards.Single(s => s.Ident == ident);
						if (row != null)
						{
							entryId = row.ModelNumber;
							this.lblKeyboardModelNumberEntry.Text = $"{entryId}";
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

		public frmKeyboardEntry(int modelNumber, int quantity, int supplierId, string description)
		{

		}

		private void btnKeyboardSave_Click(object sender, EventArgs e)
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{

				//Check For Same Names

				var row = db.Keyboards.FirstOrDefault(s => s.ModelNumber == entryId);
				if (row != null)
				{
					row.Ident = 1;
					row.Quantity = Convert.ToInt32(this.lblKeyboardQuantityEntry.Text);
					row.Price = Convert.ToDecimal(this.lblKeyboardPriceEntry.Text.Replace("£", ""));
					row.SupplierId = Convert.ToInt32(this.lblKeyboardSupplierIdEntry.Text);
					row.Description = this.lblKeyboardDescriptionEntry.Text;

					db.SaveChanges();
				}
				else
				{
					MessageBox.Show("Model Number already exists!");
				}
			}
		}

		private void btnKeyboardDelete_Click(object sender, EventArgs e)
		{
			deleteRowFromDB();
		}

		private void removeRowifBlank(object sender, EventArgs e)
		{
			if (lblKeyboardQuantityEntry.Text == String.Empty && lblKeyboardPriceEntry.Text == String.Empty && lblKeyboardSupplierIdEntry.Text == String.Empty && lblKeyboardDescriptionEntry.Text == String.Empty)
			{
				deleteRowFromDB();
			}
		}

		private void deleteRowFromDB()
		{
			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				Keyboard keyboardRow = db.Keyboards.Find(entryId);
				if (keyboardRow != null)
				{
					db.Keyboards.Remove(keyboardRow);
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
