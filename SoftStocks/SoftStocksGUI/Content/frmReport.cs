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

namespace SoftStocksGUI
{
	public partial class frmReport : Form
	{
		public frmReport()
		{
			InitializeComponent();
			/*
			List<Keyboard> keyboardList;

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				keyboardList = db.Keyboards.ToList();
			}*/

			frmReportEntry frmReportEntry_Vrb = new frmReportEntry("StaffReport2", "Staff", DateTime.Now) { TopLevel = false, TopMost = true };
			frmReportEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
			this.pnlScrollableReport.Controls.Add(frmReportEntry_Vrb);
			frmReportEntry_Vrb.Show();
		}
	}
}
