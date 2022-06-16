using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class CocApplication : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            if (client.addCocApplication(email.Value, phone.Value, install.Value))
            {
                msg.InnerHtml = "<div style='color: green;'> Application submitted successfully. </div>";
            }
            else
            {
                msg.InnerHtml = "<div style='color: red;'> Could not submit application. Please try again later. </div>";
            }
        }
    }
}