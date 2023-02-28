using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
    public class StaffReport : Report
    {
        public string Title;
        public string FirstName;
        public string LastName;
        public string Role;
        public DateTime DateOfBirth;
        public float Salary;

        public StaffReport(string Title, string FirstName, string LastName, string Role, DateTime DateOfBirth, float Salary)
        {
            this.Title = Title;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Role = Role;
            this.DateOfBirth = DateOfBirth;
            this.Salary = Salary;

        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override string Generate(ReportFormat format)
        {
            switch (format)
            {
                case ReportFormat.Pdf:
                    PdfDocument pdfReport = new();
                    PdfPage page = pdfReport.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    XFont titleFont = new("Segoe UI", 24, XFontStyle.Bold);
                    XFont bodyFont = new("Segoe UI", 12, XFontStyle.Regular);

                    gfx.DrawString($"Directory - {LastName}, {FirstName} ({Id})", titleFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                    gfx.DrawString($"Staff member report, created on {CreationTimestamp.Date}", bodyFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                    gfx.DrawString($"Id: {Id}\nTitle: {Title}\nFirst name: {FirstName}", bodyFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

                    string fileName = "staff_report.pdf";
                    pdfReport.Save(fileName);

                    return fileName;

                default:
                    return "";
            }
        }
    }
}
