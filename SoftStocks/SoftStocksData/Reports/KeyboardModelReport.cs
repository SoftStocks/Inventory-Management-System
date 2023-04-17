﻿using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SoftStocksData.Entities.Keyboards;
using SoftStocksData.Entities.Purchases;
using SoftStocksData.Entities.StaffMember;
using SoftStocksData.Entities.Suppliers;
using SoftStocksData.Keyboards;
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
        public float Price;

        // advanced (derived) information
        public int TotalNumberOfTransactions;
        public List<Admin> PurchasedBy;
        public List<Keyboard> SimilarModels;

        public KeyboardModelReport(int modelNumber) { 
            using(var dbContext = new SoftStocksDBContext())
            {
                ModelNumber = modelNumber;
                
				Keyboard keyboard = dbContext.Keyboards.FirstOrDefault(k => k.ModelNumber == modelNumber);

                this.Supplier = dbContext.Suppliers.FirstOrDefault(s => s.Id == keyboard.SupplierId);
                this.Quantity = keyboard.Quantity;
                this.Description = keyboard.Description;
                this.Price = keyboard.Price;

				var transactions = dbContext.PurchaseRequests.Join(dbContext.KeyboardRequests, pr => pr.KeyboardRequestId, kr => kr.Id, (pr, kr) => kr.ModelNumber == modelNumber);


				this.TotalNumberOfTransactions = transactions.ToList().Count();

				// Get the list of all staff members who have purchased a particular keyboard model
				var staffMemberIds = dbContext.PurchaseRequests.Join(
					dbContext.KeyboardRequests,
					pr => pr.Id,
					kr => kr.PurchaseRequestId,
					(pr, kr) => new {pr.Id, kr.ModelNumber, pr.StaffId}
					)
					.Where(
					prkr => prkr.ModelNumber == modelNumber
					)
					.Select(
					prkr => prkr.StaffId
					).ToList();

				this.PurchasedBy = new List<Admin>();

				foreach(var smid in staffMemberIds)
				{
					this.PurchasedBy.AddRange((IEnumerable<Admin>)dbContext.Staff.Where(s => s.Id == smid));
				}

				// recommendation logic
				
				var similarModelTrainingSet = new KeyboardRecommendationModel.ModelInput()
				{
					Supplier_id = keyboard.SupplierId,
					Description = keyboard.Description
				};

				//Load model and predict output
				var result = Math.Round(float.Parse(KeyboardRecommendationModel.Predict(similarModelTrainingSet).ToString()));

				this.SimilarModels = dbContext.Keyboards.Where(k => k.ModelNumber == result).ToList();
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
					
					
					gfx.DrawString("Purchasers", titleFont, XBrushes.Black, new XRect(50, -125, page.Width, page.Height), XStringFormats.CenterLeft);

					var height = -100;

					foreach(var purchaser in this.PurchasedBy)
					{
						gfx.DrawString($"ID: {purchaser} | Name: {purchaser.FirstName} {purchaser.LastName}", bodyFont, XBrushes.Black, new XRect(50, height, page.Width, page.Height), XStringFormats.CenterLeft);
						height += 25;
					}
					
					gfx.DrawString($"Similar models: {SimilarModels}", bodyFont, XBrushes.Black, new XRect(50, height + 25, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Price history: {PriceHistory}", bodyFont, XBrushes.Black, new XRect(50, height + 50, page.Width, page.Height), XStringFormats.CenterLeft);

                    // footer
                    gfx.DrawString($"Report id: {base.Id}", footerFont, XBrushes.Black, new XRect(50, height + 75, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Creation date: {base.CreationTimestamp:f}", footerFont, XBrushes.Black, new XRect(50, height + 100, page.Width, page.Height), XStringFormats.CenterLeft);


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