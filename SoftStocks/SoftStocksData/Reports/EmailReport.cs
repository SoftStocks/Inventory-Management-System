using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
    public class EmailReport
    {

        // Last Updated: 13-03-23 - Jack Wallace
        public static void SendEmail(string fromAddress, string recipients, string subject, string body, List<string> attachments, bool isHtml)
        {
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
                NetworkCredential credentials = new NetworkCredential("PUT YOUR OUTLOOK EMAIL HERE", "PUT YOUR PASSWORD HERE");
                client.EnableSsl = true;
                client.Credentials = credentials;
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while sending the email: " + ex.Message);
            }
        }

    }
}
