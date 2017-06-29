using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailConsoleApp {
    internal class Email {
        private const string Host = "mail.domain.com";
        private const int Port = 25;
        private const int TimeOut = 20000;

        public int Send(EmailSend email) {
            using(var message = BuildMessage(email))
            using(var client = new SmtpClient {
                Host = Host,
                Port = Port,
                Timeout = TimeOut
            }) {
                client.Send(message);
            }
            return 0;
        }

        public async Task<int> SendAsync(EmailSend email) {
            using(var message = BuildMessage(email))
            using(var client = new SmtpClient {
                Host = Host,
                Port = Port,
                Timeout = TimeOut
            }) {
                await client.SendMailAsync(message).ConfigureAwait(false);
            }
            return 0;
        }

        private static MailMessage BuildMessage(EmailSend email) {
            var mailMessage = new MailMessage {
                From = new MailAddress(email.From),
                Subject = email.Subject,
                Body = email.Body,
                IsBodyHtml = true
            };
            mailMessage.To.Add(new MailAddress(email.To));
            return mailMessage;
        }
    }
}
