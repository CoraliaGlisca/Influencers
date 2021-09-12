using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace Influencers.BusinessLogic.Services
{
    public class EmailService
    {
        
       
       public void SendEmail(string email, int? id)
        {
            var fromAddress = new MailAddress("test.summer.camp.2020@gmail.com", "From Name");
            var toAddress = new MailAddress(email, "To Name");

            string url = HttpUtility.HtmlEncode("https://localhost:44323/Article/EditArticle/" + id);
            const string fromPassword = "jstoamnumuxkecjl";
            const string subject = "Edit your article";
            const string body = "You requested to edit your article. If it was you, access the following link. If it was not you, ignore this." + "<br/>";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };

            message.Body = body + url;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }

        
    }
}

