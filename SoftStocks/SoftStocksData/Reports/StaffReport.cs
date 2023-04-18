using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
    public class StaffReport : Report
    {
		// basic information
		string staffId;
        public string Title;
        public string FirstName;
        public string LastName;
        public string Role;
        public DateTime DateOfBirth;
        public float Salary;

		DateTime creationDate = DateTime.Now;

        //derived information
        public int NumberOfPurchaseRequests;
        //public List<string> MostFrequentModelsPurchased;

        public StaffReport(int id)
        {
			staffId = id.ToString();
            using (var db = new SoftStocksDBContext()) 
            {
                var staff = db.Staff.FirstOrDefault(s => s.Id == id);

                if (staff != null)
                {
                    Title = staff.Title;
                    FirstName = staff.FirstName;
                    LastName = staff.LastName;
                    Role = staff.Role;
                    DateOfBirth = staff.DateOfBirth;
                    Salary = staff.Salary;

                    NumberOfPurchaseRequests = (from pr in db.PurchaseRequests where pr.StaffId == id select pr).Count();

                }
                else
                {
                    Title = "";
                    FirstName = "";
                    LastName = "";
                    Role = "";
                    DateOfBirth = DateTime.Now;
                    Salary = 0.0f;
                }

            }

        }

        public override void Delete()
        {
			Session.RemoveReportById(Id);
        }

        public override string Create(ReportFormat format)
        {
			Session.AddReport(this);

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
                    gfx.DrawString($"Directory - {LastName}, {FirstName} ({Id})", titleFont, XBrushes.Black, new XRect(50, -350, page.Width, page.Height), XStringFormats.CenterLeft);
                    
                    // header
                    gfx.DrawString($"Staff member listing for SoftStocks employee {FirstName} {LastName}", bodyFont, XBrushes.Black, new XRect(50, -300, page.Width, page.Height), XStringFormats.CenterLeft);
                    gfx.DrawString($"Id: {staffId}", bodyFont, XBrushes.Black, new XRect(50, -250, page.Width, page.Height), XStringFormats.CenterLeft);
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

					Directory.CreateDirectory("Reports");
					string path = Path.Combine(Directory.GetCurrentDirectory(), @$"Reports\");
					string fileName = path + $"staff-report_{creationDate.Year}-{creationDate.Month}-{creationDate.Day}-{creationDate.Hour}-{creationDate.Minute}-{creationDate.Second}_{staffId}.pdf";

                    pdfReport.Save(fileName);

                    return fileName;

				case ReportFormat.Email:

					string recipients = "softstocks@outlook.com";
					string fromAddress = "softstocks@outlook.com";

					string subject = "Staff Report";
					string body = "<span style=\"font-size: 24px; font-family: Arial, sans-serif; color: #222222;\" >" +
						$"Soft Stocks Employee: {FirstName} {LastName}<br>" +
						$"<br>" +
						$"Id: {Id}<br>" +
						$"Title: {Title}<br>" +
						$"Role: {Role}<br>" +
						$"Date Of Birth: {DateOfBirth.Date:dd/MM/yyyy}<br>" +
						$"Salary: £{Salary:N2}<br>" +
						$"Number Of Purchases: {NumberOfPurchaseRequests}<br>" +
						$"<br>" +
						$"Report Id: {base.Id}<br>" +
						$"Send Date: {base.CreationTimestamp:f}<br>" +
						"</span>";

					List<string> attachments = new List<string>();

					bool isHtml = true;

					try
					{
						string[] recipientArray = recipients.Split(',');

						MailMessage mail = new MailMessage();
						mail.From = new MailAddress(fromAddress);

						foreach (string recipient in recipientArray)
						{
							mail.To.Add(new MailAddress(recipient.Trim()));
						}

						mail.Subject = subject;
						mail.Body = body;
						mail.IsBodyHtml = isHtml;

						if (attachments != null && attachments.Count > 0)
						{
							foreach (string attachmentPath in attachments)
							{
								Attachment attachment = new Attachment(attachmentPath);
								mail.Attachments.Add(attachment);
							}
						}

						SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);   //smtp.gmail.com for gmail email account
						client.UseDefaultCredentials = false;
						NetworkCredential credentials = new NetworkCredential("softstocks@outlook.com", "zblniphjespgnprh");
						client.EnableSsl = true;
						client.Credentials = credentials;
						client.Send(mail);
						return $"Email Sent";
					}
					catch (Exception ex)
					{
						return $"{ex}";
					}

				default:
                    return "";
            }
        }

        public override void Download()
        {
            throw new NotImplementedException();
        }
    }
}
