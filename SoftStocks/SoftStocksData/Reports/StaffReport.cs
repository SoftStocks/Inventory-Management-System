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

                    gfx.DrawString($"Directory - {LastName}, {FirstName} ({Id})", titleFont, XBrushes.Black, new XRect(50, -350, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Staff member listing for SoftStocks employee {FirstName} {LastName}", bodyFont, XBrushes.Black, new XRect(50, -300, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Id: {Id}", bodyFont, XBrushes.Black, new XRect(50, -250, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Title: {Title}", bodyFont, XBrushes.Black, new XRect(50, -225, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"First name: {FirstName}", bodyFont, XBrushes.Black, new XRect(50, -200, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Last name: {LastName}", bodyFont, XBrushes.Black, new XRect(50, -175, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Role: {Role}", bodyFont, XBrushes.Black, new XRect(50, -150, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Date of birth: {DateOfBirth.Date:dd/MM/yyyy}", bodyFont, XBrushes.Black, new XRect(50, -125, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Salary: £{Salary:N2}", bodyFont, XBrushes.Black, new XRect(50, -100, page.Width, page.Height), XStringFormats.CenterLeft);


                    string fileName = $"staff_report_{CreationTimestamp.Date.Year}{CreationTimestamp.Date.Month}{CreationTimestamp.Date.Day}{Id}.pdf";
                    pdfReport.Save(fileName);

                    return fileName;

                default:
                    return "";
            }
        }
    }
}
