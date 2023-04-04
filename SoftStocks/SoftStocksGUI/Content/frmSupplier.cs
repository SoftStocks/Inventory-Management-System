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
			//this.pnlScrollableSupplier.Controls.Clear();

			for (int i = 0; i < 10; i++)
			{
				frmSupplierEntry frmSupplierEntry_Vrb = new frmSupplierEntry() { TopLevel = false, TopMost = true };
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
			frmSupplierEntry_Vrb.Show();

		}
	}
}
