using System.Threading.Tasks;

namespace EmailConsoleApp {
    internal class Program {
        private static void Main(string[] args) {
            MainAsync().GetAwaiter().GetResult();
            /* var emailMessage = new EmailSend {
                 Body = "<h1>Hi I am cool async<h1>",
                 From = "noreply@domain.net",
                 Subject = "Test Email from async",
                 To = "ryan.sadwick@3ee.com"

             };
             emailer.Send(emailMessage);*/
        }

        private static async Task MainAsync() {
            var emailer = new Email();
            var emailMessage = new EmailSend {
                Body = "<h1>Hi I am cool async<h1>",
                From = "noreply@domain.net",
                Subject = "Test Email from async",
                To = "ryan.sadwick@3ee.com"
            };
            await emailer.SendAsync(emailMessage);
        }
    }
}
