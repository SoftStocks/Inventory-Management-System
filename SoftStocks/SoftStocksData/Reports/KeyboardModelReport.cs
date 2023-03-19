using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
    public class KeyboardModelReport : Report
    {
        // basic information
        public int ModelNumber;
        public Supplier Supplier;
        public int Quantity;
        public string? Description;
        public SqlMoney Price;

        // advanced (derived) information
        public int TotalNumberOfTransactions;
        //public List<Admin> PurchasedBy;
        public List<KeyboardModelReport> SimilarModels;
        public List<float> PriceHistory;


        public KeyboardModelReport(int modelNumber) { 
            using(var dbContext = new SoftStocksDBContext())
            {
                ModelNumber = modelNumber;
                var keyboard = dbContext.Keyboards.FirstOrDefault(k => k.ModelNumber == modelNumber);
                this.Supplier = dbContext.Suppliers.FirstOrDefault(s => s.Id == keyboard.SupplierId);
                this.Quantity = keyboard.Quantity;
                this.Description = keyboard.Description;
                this.Price = keyboard.Price;

                // TODO: write other methods
                //this.TotalNumberOfTransactions = dbContext.PurchaseRequests.Join(dbContext.KeyboardRequests, pr => pr.KeyboardRequestId, kr => kr.Id, (pr, kr) => kr.ModelNumber == modelNumber).ToList().Count();
            }

        }
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override string Create(ReportFormat format)
        {
            switch (format)
            {
                case ReportFormat.Pdf:
                    PdfDocument pdfReport = new();
                    PdfPage page = pdfReport.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    XFont titleFont = new("Segoe UI", 24, XFontStyle.Bold);
                    XFont bodyFont = new("Segoe UI", 12, XFontStyle.Regular);
                    XFont footerFont = new("Segoe UI", 11, XFontStyle.Italic);

                    // title
                    gfx.DrawString($"SoftStocks keyboard (Model: {ModelNumber})", titleFont, XBrushes.Black, new XRect(50, -350, page.Width, page.Height), XStringFormats.CenterLeft);

                    // header
                    gfx.DrawString($"Supplier: {Supplier.Name}", bodyFont, XBrushes.Black, new XRect(50, -300, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Quantity in stock: {Quantity}", bodyFont, XBrushes.Black, new XRect(50, -250, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Product description: {Description}", bodyFont, XBrushes.Black, new XRect(50, -225, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Price: £{Price:N2}", bodyFont, XBrushes.Black, new XRect(50, -200, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Total models sold: {TotalNumberOfTransactions}", bodyFont, XBrushes.Black, new XRect(50, -150, page.Width, page.Height), XStringFormats.CenterLeft);
                    //gfx.DrawString($"Purchasers: {PurchasedBy}", bodyFont, XBrushes.Black, new XRect(50, -125, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Similar models: {SimilarModels}", bodyFont, XBrushes.Black, new XRect(50, -100, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Price history: {PriceHistory}", bodyFont, XBrushes.Black, new XRect(50, -75, page.Width, page.Height), XStringFormats.CenterLeft);

                    // footer
                    gfx.DrawString($"Report id: {base.Id}", footerFont, XBrushes.Black, new XRect(50, 200, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Creation date: {base.CreationTimestamp:f}", footerFont, XBrushes.Black, new XRect(50, 175, page.Width, page.Height), XStringFormats.CenterLeft);


                    string fileName = $"staff_report_{CreationTimestamp.Date.Year}{CreationTimestamp.Date.Month}{CreationTimestamp.Date.Day}{Id}.pdf";
                    pdfReport.Save(fileName);

                    return fileName;
                case ReportFormat.Email:
                    return "";
                case ReportFormat.Notification:
                    return "";
                default:
                    return "";
            }
        }

        public override void Download()
        {
            string filename = this.Create(ReportFormat.Pdf);
            System.Diagnostics.Process.Start(filename);

        }
    }
}
