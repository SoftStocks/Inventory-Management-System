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
	public partial class frmReportEntry : Form
	{
		public frmReportEntry(string reportId = "", string reportType = "", DateTime creationDate = new DateTime())
		{
			InitializeComponent();

			this.lblReportId.Text = reportId;
			this.lblReportType.Text = reportType;
			this.lblReportDateCreated.Text = creationDate.ToString();
		}

		private void lblReportDateCreated_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
