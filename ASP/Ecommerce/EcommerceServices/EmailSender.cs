using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceServices
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "elvin.azim01@gmail.com",
                    Password = "wuzwxevashmbdfhx"
                }
            };

            MailAddress FromeMail = new MailAddress("elvin.azim01@gmail.com", "From");
            MailAddress ToeMail = new MailAddress(email, "To");


            MailMessage Message = new MailMessage()
            {
                From = FromeMail,
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            Message.To.Add(ToeMail);

            try
            {
                await Client.SendMailAsync(Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
