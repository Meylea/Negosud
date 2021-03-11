using Microsoft.AspNetCore.Mvc;
using Negosud_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Negosud_MVC.Controllers
{
    public class ContactForm : Controller
    {
        public static void SendMail(string from, string body)
        {
            string mailj = "jean-beauno@outlook.fr";
            string mdpj = "JeanBeauno";
            MailMessage objMessage = new MailMessage();
            System.Net.Mail.MailAddress address = new MailAddress(mailj, from);
            objMessage = new MailMessage();
            objMessage.IsBodyHtml = true;
            objMessage.Subject = "Message de Negosud.com";
            objMessage.From = address;
            objMessage.To.Add("cfouquet.web@gmail.com");
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

        //Méthode Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(ContactViewModel model)
        {

            SendMail(model.from, model.body);
            return View("../Home/Contact");

        }

        
    }
}
