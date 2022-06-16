using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class InstallationsMaster : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var install = client.getInstallations();

            String display = "";

            foreach (Installation i in install)
            {
                display += "<li class='one_third'><a class='imgover' href='AboutInstallation.aspx?IID=" + i.Install_Id + "'><img style = 'height:400px' src='images/demo/" + i.Install_Image + "' alt=''></a></li>";
            }
            PopulateInstall.InnerHtml = display;
        }

        protected void btnApplyCOC_Click(object sender, EventArgs e)
        {
            Response.Redirect("CocApplication.aspx");
        }
    }
}