using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Twilio;
using System.Web.UI.WebControls;

namespace beyonicweb.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = codegenerator.GetUniqueKey(6);
             
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            string AccountSid = "AC3dc3196f4210e1be0202bd0d4e5f115c";
            string AuthToken = "4ab736f63cbaac64f4572af5421a9e10";
            string origin = "+15162462309";
            string reciver = "+254723396461";
            string body =text;
            // Create a Twilio client using your credentials
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var message = twilio.SendMessage(origin, reciver, body);
            if (message != null)
            {
                var error = message.RestException.Message;
                // handle the error ...
            }
        }
    }
}
