using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class AboutInstallation : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"]!=null) {
                InstallInfoBook.Visible = true;
                lbl_IsAdded.Visible = false;
            }
            int InstallId = Convert.ToInt32(Request.QueryString["IID"].ToString());
            dynamic i = client.getInstallation(InstallId);

            String display = "";

            display += "<img src='images/demo/" + i.Install_Image + "' alt='Install' style='width:100%'>";
            display += "<h1>" + i.Install_Name + " Installation</h1>";
            display += "<p class='price'>R" + i.Install_Price + "</p>";
            display += "<p><br><b>Installation Description:</b>";
            display += "<br>" + i.Install_Description;
            display += "<br><br><b>Duration of Installation procedure:</b><br>" + i.Install_Duration + " hours<br>";
            

            aboutInstall.InnerHtml = display;
        }

        protected void InstallInfoBook_Click(object sender, EventArgs e)
        {
            ShoppingCart newItem = new ShoppingCart(Convert.ToInt32(Request.QueryString["IID"]),1);
            GasUp.CartItems.Add(newItem);
            int items = Convert.ToInt32(Session["CartItems"].ToString());
            items += 1;
            Session["CartItems"] = items;
            Response.Redirect("Cart.aspx");
        }
    }
}