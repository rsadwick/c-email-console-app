using System.Threading.Tasks;

namespace EmailConsoleApp {
    internal class Program {
        private static async Task Main() {
            var emailer = new Email();
            var emailMessage = new EmailSend {
                Body = "<h1>Hi I am cool async email<h1>",
                From = "ryan.sadwick@3ee.com",
                Subject = "Test Email from async",
                To = "some.email.accountk@3ee.com"
            };
            
            await emailer.SendAsync(emailMessage);
        }
    }
}
