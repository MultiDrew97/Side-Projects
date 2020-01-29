using Mailjet.Client;
using Mailjet.Client.Resources;
using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace SendEmailsApplication
{
    public class SendEmails
    {
        private string publicKey;
        private string privateKey;
        private string htmlPart { get; set; }
        private string textPart { get; set; }
        private string subject { get; set; }

        public SendEmails(string publicKey, string privateKey)
        {
            this.publicKey = publicKey;
            this.privateKey = privateKey;
            htmlPart = "<!DOCTYPE html>< html >< head >< title ></ title ></ head >< body >< h3 >Dear Andrew,< br >    Welcome to < a href = \'http://x58w0.mjt.lu/lnk/CAAAAKAgcIYAAAAAAAAAAKkFVA0AAYCrWbsAAAAAABGsngBeMMj79Hn-FwrnTYyijeGLuYTpQwARurM/1/ANRGS8gzw3_jy_NqJvYuaA/aHR0cHM6Ly93d3cubWFpbGpldC5jb20v' > Mailjet </ a > !</ h3 >< br >    May the delivery force be with you!< br >< img src = \"http://x58w0.mjt.lu/oo/CAAAAKAgcIYAAAAAAAAAAKkFVA0AAYCrWbsAAAAAABGsngBeMMj79Hn-FwrnTYyijeGLuYTpQwARurM/f550d847/e.gif\" style = \"height:1px;width:1px;border:0;\" ></ body ></ html > ";
            textPart = "Good afternoon from St. Paul PBC. Today we have the next installment in the email ministry";
            subject = "Good Afternoon from St. Paul PBC.";
        }

        public async Task<bool> Sender(string[] recipient, string[] attachment)
        {
            //recipient[ email, name ]
            //attachment[ fileName, encodedContents ]
            MailjetClient client = new MailjetClient(publicKey, privateKey)
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
                                {"Email", "pastormiller@damascuscfc.com"},
                                {"Name", "Pastor B. K. Miller"}
                            }
                        }, {
                            "To",
                            new JArray {
                                new JObject {
                                    {
                                        "Email",
                                        recipient[0]
                                    }, {
                                        "Name",
                                        recipient[1]
                                    }
                                }
                            }
                        }, {
                            "Subject",
                            subject
                        }, {
                            "TextPart",
                            textPart
                        }, {
                            "HTMLPart",
                            htmlPart
                        }, {
                            "CustomID",
                            "EmailMinistry"
                        },
                        {
                            "Attachments", new JArray
                            {
                                new JObject
                                {
                                    {"Filename", attachment[0]},
                                    {"ContentType", "audio/mpeg4-generic"},
                                    {"Base64Content", attachment[1]}
                                }//end JObject
                            }//end JArray
                        }//end attachments
                    }//end messages
                });

            MailjetResponse response = await client.PostAsync(request);

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
                //Console.WriteLine(response.GetData());
                return true;
            }
            else
            {
                //Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
                //Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
                //Console.WriteLine(response.GetData());
                //Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
                return false;
            }
        }//end send

        public async Task<bool> Sender(string[] recipient, string[] attachment, string subject, string textPart, string htmlPart)
        {
            this.subject = subject;
            this.textPart = textPart;
            this.htmlPart = htmlPart;

            return await Sender(recipient, attachment);
        }

        public async Task<bool> Sender(string[] recipient, string[] attachment, string textPart, string htmlPart)
        {
            this.textPart = textPart;
            this.htmlPart = htmlPart;

            return await Sender(recipient, attachment);
        }
    }
}
