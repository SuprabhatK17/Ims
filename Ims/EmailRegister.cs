using System.Net;
using System.Net.Mail;

namespace Ims
{
    internal class EmailRegister
    {
        SmtpClient smtpClient;
        static string fromMail = "suprabhatk086577@gmail.com";
        static string password = "suprabhat0117";

        public EmailRegister()
        {
            smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, password)
            };
        }
        public void Send(string body, string toAddr)
        {
            using (var m = new MailMessage(fromMail, toAddr)
            {
                Subject = "Register",
                Body = body,
            })
            {
                m.IsBodyHtml = true;
                smtpClient.Send(m);
            }


        }
    }
}
