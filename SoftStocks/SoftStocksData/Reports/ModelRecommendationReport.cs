using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
    internal class ModelRecommendationReport : Report
    {
        public Keyboard Model;
        public int Quantity;
        public Supplier Supplier;
        public float Accuracy;
        
        public ModelRecommendationReport() {
            // consume ML model
            // save data in variables
        }
        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override string Generate(ReportFormat format)
        {
            PdfDocument pdfReport = new();
            PdfPage page = pdfReport.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont titleFont = new("Segoe UI", 24, XFontStyle.Bold);
            XFont bodyFont = new("Segoe UI", 12, XFontStyle.Regular);
            XFont footerFont = new("Segoe UI", 11, XFontStyle.Italic);

            // title
            gfx.DrawString($"Directory - {LastName}, {FirstName} ({Id})", titleFont, XBrushes.Black, new XRect(50, -350, page.Width, page.Height), XStringFormats.CenterLeft);

            // header
            gfx.DrawString($"Staff member listing for SoftStocks employee {FirstName} {LastName}", bodyFont, XBrushes.Black, new XRect(50, -300, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Id: {Id}", bodyFont, XBrushes.Black, new XRect(50, -250, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Title: {Title}", bodyFont, XBrushes.Black, new XRect(50, -225, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"First name: {FirstName}", bodyFont, XBrushes.Black, new XRect(50, -200, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Last name: {LastName}", bodyFont, XBrushes.Black, new XRect(50, -175, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Role: {Role}", bodyFont, XBrushes.Black, new XRect(50, -150, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Date of birth: {DateOfBirth.Date:dd/MM/yyyy}", bodyFont, XBrushes.Black, new XRect(50, -125, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Salary: £{Salary:N2}", bodyFont, XBrushes.Black, new XRect(50, -100, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Number of purchase requests: {NumberOfPurchaseRequests}", bodyFont, XBrushes.Black, new XRect(50, -75, page.Width, page.Height), XStringFormats.CenterLeft);

            // footer
            gfx.DrawString($"Report id: {base.Id}", footerFont, XBrushes.Black, new XRect(50, 200, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Creation date: {base.CreationTimestamp:f}", footerFont, XBrushes.Black, new XRect(50, 175, page.Width, page.Height), XStringFormats.CenterLeft);


            string fileName = $"staff_report_{CreationTimestamp.Date.Year}{CreationTimestamp.Date.Month}{CreationTimestamp.Date.Day}{Id}.pdf";
            pdfReport.Save(fileName);

            return fileName;
        }
    }
}
