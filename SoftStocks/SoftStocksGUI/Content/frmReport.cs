using SoftStocksData;
using SoftStocksData.Entities.StaffMember;
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
		Staff staffObject;
		public frmReport()
		{
			InitializeComponent();

			if (Directory.Exists("Reports"))
			{
				foreach (string reportPath in Directory.GetFiles("Reports"))
				{
					string[] reportPathSplit = reportPath.Split("_");
					string[] dateReportSplit = reportPathSplit[1].Split("-");
					DateTime dateFromPath = DateTime.Parse($"{dateReportSplit[2]}-{dateReportSplit[1]}-{dateReportSplit[0]} {dateReportSplit[3]}:{dateReportSplit[4]}:{dateReportSplit[5]}");
					int staffId = Int16.Parse(reportPathSplit[2].Split(".")[0]);
					MessageBox.Show(staffId.ToString());
					using (SoftStocksDBContext db = new SoftStocksDBContext())
					{
						staffObject = db.Staff.Single(c => c.Id == staffId);
					}
					string staffName = staffObject.FirstName + " " + staffObject.LastName;

					frmReportEntry frmReportEntry_Vrb = new frmReportEntry($"{reportPathSplit[0]} {staffName}", dateFromPath, reportPath) { TopLevel = false, TopMost = true };
					frmReportEntry_Vrb.FormBorderStyle = FormBorderStyle.None;
					this.pnlScrollableReport.Controls.Add(frmReportEntry_Vrb);
					frmReportEntry_Vrb.Show();
				}
			}

			
		}
	}
}
