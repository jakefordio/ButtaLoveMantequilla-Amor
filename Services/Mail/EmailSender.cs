using ButtaLove.Data;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace ButtaLove.Services.Mail
{
    public static class EmailSender
    {
        public static async Task SendEmailAsync(string recipient, string htmlSubject, string htmlBody)
        {
            MimeMessage message = new();
            message.From.Add(MailboxAddress.Parse(Statics.SMTP.Account));
            message.Headers.Add("Reply-To", Statics.SMTP.Account);
            message.To.Add(MailboxAddress.Parse(recipient));
            message.Subject = htmlSubject;
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlBody };

            try
            {
                using (SmtpClient smtp = new())
                {
                    smtp.Timeout = 20000;
                    await smtp.ConnectAsync(Statics.SMTP.Account, (int)Statics.SMTP.ServerPort,
                        MailKit.Security.SecureSocketOptions.StartTls);
                    await smtp.AuthenticateAsync(Statics.SMTP.Account, Statics.SMTP.Password);
                    await smtp.SendAsync(message);
                    await smtp.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }
    }
}