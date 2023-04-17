using SoftStocksData.Entities.Suppliers;
using SoftStocksData;
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
using SoftStocksData.Entities.Keyboards;
using System.Diagnostics;

namespace SoftStocksGUI.Content
{
	public partial class frmKeyboard : Form
	{
		public frmKeyboard()
		{
			InitializeComponent();

			List<Keyboard> keyboardList;

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				keyboardList = db.Keyboards.ToList();
			}

			foreach (Keyboard keyboardItem in keyboardList)
			{
				frmKeyboardEntry frmKeyboardEntry_Vrb = new frmKeyboardEntry(keyboardItem.Ident, keyboardItem.ModelNumber, keyboardItem.Quantity, /*keyboardItem.Price,*/ keyboardItem.SupplierId, keyboardItem.Description) { TopLevel = false, TopMost = true };
				frmKeyboardEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
				this.pnlScrollableKeyboard.Controls.Add(frmKeyboardEntry_Vrb);
				frmKeyboardEntry_Vrb.Show();
			}
		}

		private void frmKeyboard_Load(object sender, EventArgs e)
		{

		}

		private void btnAddKeyboard_Click(object sender, EventArgs e)
		{
			frmKeyboardEntry frmKeyboardEntry_Vrb = new frmKeyboardEntry() { TopLevel = false, TopMost = true };
			frmKeyboardEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
			this.pnlScrollableKeyboard.Controls.Add(frmKeyboardEntry_Vrb);
			try
			{
				frmKeyboardEntry_Vrb.Show();
			}
			catch (Exception)
			{
				//MessageBox.Show($"{ex}");  //If entry is deleted before being able to be shown then hides error
			}
		}
	}
}
