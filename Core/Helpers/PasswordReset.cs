using System.Net;
using System.Net.Mail;

namespace Core.Helpers
{
    public static class PasswordReset
    {
        public static void PasswordResetSendMail(string link, string email)
        {
            MailMessage mailMessage = new MailMessage();
            SmtpClient client = new SmtpClient();
            mailMessage.From = new MailAddress("onlinepsikolog999@gmail.com");
            mailMessage.To.Add(email);
            mailMessage.Subject = "Şifre sıfırlama";
            mailMessage.Body = "<h2> Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız. </h2> <hr/>";
            mailMessage.Body += $"<a href='{link}'>Şifre Yenilemek İçin Tıklayın</a>";
            mailMessage.IsBodyHtml = true;
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("onlinepsikolog999@gmail.com", "Deneme123.");
            client.Send(mailMessage);
        }
    }
}
