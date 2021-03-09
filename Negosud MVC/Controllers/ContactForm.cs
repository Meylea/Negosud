using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Controllers
{
    public class ContactForm
    {
        public static void SendMail(string from, string to, String body)
        {
            string mailj = "jean-beauno@outlook.fr";
            string mdpj = "JeanBeauno";
            MailMessage objMessage = new MailMessage();
            System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(mailj, from);
            objMessage = new MailMessage();
            objMessage.IsBodyHtml = true;
            objMessage.Subject = "Test";
            objMessage.From = address;
            objMessage.To.Add(to);
            objMessage.Body = body;
            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential(mailj, mdpj);
            smtp.EnableSsl = true;
            smtp.Credentials = credential;
            smtp.Send(objMessage);
        }
    }
}
