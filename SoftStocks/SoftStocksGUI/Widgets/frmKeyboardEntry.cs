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

		public frmKeyboardEntry(int id = -1, int modelNo = 0, int quantity = 0, /*Decimal price = 0,*/ int supplierId = 0, string description = "Example Desc.")
		{
			InitializeComponent();

			entryId = id;

			this.lblKeyboardModelNumberEntry.Text = modelNo.ToString();
			this.lblKeyboardQuantityEntry.Text = quantity.ToString();
			//this.lblKeyboardPriceEntry.Text = price.ToString();
			this.lblKeyboardSupplierIdEntry.Text = supplierId.ToString();
			this.lblKeyboardDescriptionEntry.Text = description;
			this.lblKeyboardId.Text = $"{entryId}";

			if (entryId == -1)
			{
				using (SoftStocksDBContext db = new SoftStocksDBContext())
				{
					var modelQuery = db.Keyboards.SingleOrDefault(s => s.ModelNumber == Convert.ToInt32(this.lblKeyboardModelNumberEntry.Text));
					if (modelQuery == null)
					{
						Keyboard newKeyboard = new Keyboard
						{
							ModelNumber = Convert.ToInt32(this.lblKeyboardModelNumberEntry.Text),
							Quantity = Convert.ToInt32(this.lblKeyboardQuantityEntry.Text),
							Price = Convert.ToInt32(this.lblKeyboardPriceEntry.Text),
							SupplierId = Convert.ToInt32(this.lblKeyboardSupplierIdEntry.Text),
							Description = this.lblKeyboardDescriptionEntry.Text
						};

						db.Keyboards.Add(newKeyboard);
						db.SaveChanges();

						var row = db.Keyboards.Single(s => s.ModelNumber == modelNo);
						if (row != null)
						{
							entryId = row.Ident;
							this.lblKeyboardId.Text = $"{entryId}";
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

		}

		private void btnKeyboardDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
