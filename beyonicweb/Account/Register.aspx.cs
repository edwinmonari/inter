using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio;
using System.Net.Mail;

namespace beyonicweb.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            string AccountSid = "AC3dc3196f4210e1be0202bd0d4e5f115c";
            string AuthToken = "4ab736f63cbaac64f4572af5421a9e10";

            // Create a Twilio client using your credentials
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage("+12018577749", "+254722262940", "This is a test message ", "");
            if (message.RestException != null)
            {
                var error = message.RestException.Message;
            }
            //generate code and send it to phone and also send an email
            // a table in db will contain the link and code the link is a diffrent page u cant navigate 
            //normally from the app which will contain provision for the code sent
            // handle the error ...


                string receiver = ((TextBox)RegisterUser.FindControl("Email")).ToString();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("eduwin87@gmail.com");
                mail.To.Add(receiver);
                mail.Subject = "login app link";
                mail.Body = "hello click this link to complete your registration please  confirmregistration.aspx";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("eduwin87@gmail.com", "mimisiwako123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
              //  MessageBox.Show("mail Send");
           // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);
        }

    }
}
