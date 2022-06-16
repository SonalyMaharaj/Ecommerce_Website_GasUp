using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class ContactUsMaster : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (client.addQuery(fname.Value, lname.Value, email.Value, phone.Value, query.Value))
            {
                msg.InnerHtml = "<div style='color: green;'> Query submitted successfully. </div>";
            }
            else
            {
                msg.InnerHtml = "<div style='color: red;'> Could not submit Query. Please try again later. </div>";
            }
        }
    }
}