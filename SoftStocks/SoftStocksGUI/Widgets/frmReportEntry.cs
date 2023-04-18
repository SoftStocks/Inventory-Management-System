using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftStocksGUI.Widgets
{
	public partial class frmReportEntry : Form
	{

		string processName = "";
		public frmReportEntry(string reportId = "", DateTime creationDate = new DateTime(), string path="")
		{
			InitializeComponent();

			processName = Directory.GetCurrentDirectory() + "\\" + path;

			this.lblReportId.Text = reportId.Split("\\")[1];
			this.lblReportDateCreated.Text = creationDate.ToString();


		}

		private void btnReportView_Click(object sender, EventArgs e)
		{
			//Process.Start(processName);
			ProcessStartInfo startInfo = new ProcessStartInfo(processName)
			{
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}

		private void btnReportDelete_Click(object sender, EventArgs e)
		{
			File.Delete(processName);
			this.Close();
		}
	}
}
