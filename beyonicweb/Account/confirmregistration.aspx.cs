using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace beyonicweb.Account
{
    public partial class confirmregistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncodesub_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?");
        }
    }
}