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

			entryId = id;

			this.lblKeyboardModelNumberEntry.Text = modelNo.ToString();
			this.lblKeyboardQuantityEntry.Text = quantity.ToString();
			this.lblKeyboardPriceEntry.Text = $"£{price}";
			this.lblKeyboardSupplierIdEntry.Text = supplierId.ToString();
			this.lblKeyboardDescriptionEntry.Text = description;
			this.lblKeyboardId.Text = $"{entryId}";

			if (entryId == -1)
			{
				using (SoftStocksDBContext db = new SoftStocksDBContext())
				{
					int ident = -1;
					var modelQuery = db.Keyboards.SingleOrDefault(s => s.Ident == ident);
					if (modelQuery == null)
					{
						Keyboard newKeyboard = new Keyboard
						{
							ModelNumber = Convert.ToInt32(this.lblKeyboardModelNumberEntry.Text),
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
				if (row == null)
				{
					row.ModelNumber = Convert.ToInt32(this.lblKeyboardModelNumberEntry.Text);
					row.Ident = 1;
					row.Quantity = Convert.ToInt32(this.lblKeyboardQuantityEntry.Text);
					row.Price = Convert.ToDecimal(this.lblKeyboardPriceEntry.Text.Replace("£", ""));
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

		}

		private void lblKeyboardPriceEntry_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
