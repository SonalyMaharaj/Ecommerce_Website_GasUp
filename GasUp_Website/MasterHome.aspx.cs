using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class MasterHome : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null && Session["Userid"] != null && Session["UserType"].ToString().Equals("CU"))
            {
                var user = client.getUser(Convert.ToInt32(Session["UserId"]));
                var purchase = client.get_purchase_cust(user.Id);
                int discount = 0;
                string tease = "<u>why not 50%?_<a href='more.aspx'>find out</a></u>";
                if (purchase != null)
                {
                    if (purchase.loyalty_points <= 20 && purchase.loyalty_points >= 10)
                    {
                        discount = 10;
                    }
                    else if (purchase.loyalty_points > 20 && purchase.loyalty_points < 41)
                    {
                        discount = 20;
                    }
                    else if (purchase.loyalty_points > 40 && purchase.loyalty_points < 61)
                    {
                        discount = 30;
                    }
                    else if (purchase.loyalty_points > 60 && purchase.loyalty_points > 101)
                    {
                        discount = 40;

                    }
                    else if (purchase.loyalty_points > 100)
                    {
                        tease = " Yes 50%?<a href='more.aspx'>why?</a>";
                        discount = 50;
                    }
                    else
                    {
                        discount = 0;
                    }
                }
                

                discounttag.InnerHtml = "Get DISCOUNT UP TO " + discount + "% OFF NOW!,LOYALTY POINTS!"+tease;
                tagdiscount.Visible = true;
            }
        }
    }
}