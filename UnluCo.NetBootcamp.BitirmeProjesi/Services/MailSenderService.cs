using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Services
{
    public class MailSenderService : IMailSenderService
    {
        public void SendEmail(string message,string email)
        {
            MailMessage msg = new MailMessage();
            msg.Subject = "UnluCo .Net Bootcamp";
            msg.From = new MailAddress("projedenemermk@gmail.com", "Deneme");
            msg.To.Add(new MailAddress(email, "UnluCo"));
            msg.Body = message;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            NetworkCredential AccountInfo = new NetworkCredential("projedenemermk@gmail.com", "ProjeDenemeRmk55");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = AccountInfo;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(msg);
        }
    }
}
