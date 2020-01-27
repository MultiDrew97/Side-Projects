using Mailjet.Client;
using Mailjet.Client.Resources;
using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Mailjet.ConsoleApplication
{
    class Program
    {
        private static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        private static async Task RunAsync()
        {
            MailjetClient client = new MailjetClient("99dbe9992162bf54d2b3f69f814d1b7f", "0f84619c6bc01c6fc151028f3e5a35c7")
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
                .Property(Send.Messages, new JArray {
                    new JObject {
                        {
                            "From",
                            new JObject {
                                {"Email", "arandlemiller97@yahoo.com"},
                                {"Name", "Andrew"}
                            }
                        }, {
                            "To",
                            new JArray {
                                new JObject {
                                    {
                                        "Email",
                                        "randlewaam@jacks.sfasu.edu"
                                    }, {
                                        "Name",
                                        "Andrew"
                                    }
                                }
                            }
                        }, {
                            "Subject",
                            "Greetings from Mailjet."
                        }, {
                            "TextPart",
                            "My first Mailjet email"
                        }, {
                            "HTMLPart",
                            "<h3>Dear passenger 1, welcome to <a href='https://www.mailjet.com/'>Mailjet</a>!</h3><br />May the delivery force be with you!"
                        }, {
                            "CustomID",
                            "AppGettingStartedTest"
                        }
                    }
                });
            MailjetResponse response = await client.PostAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
                Console.WriteLine(response.GetData());
            }
            else
            {
                Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
                Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
                Console.WriteLine(response.GetData());
                Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
            }
        }
    }
}
