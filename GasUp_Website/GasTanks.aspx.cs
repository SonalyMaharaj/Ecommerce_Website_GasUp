using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class GasTanks : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var prod = client.getProducts();

            String displayNew = "";
            String displayRefill = "";
            String displayExchange = "";

            foreach (Product p in prod)
            {
                if (p.Product_Availability >= 1)
                {
                    if (p.Product_Category == "New")
                    {
                        displayNew += "<li class='one_third'><a class='imgover' href='AboutProduct.aspx?PID=" + p.Product_Id + "'><img src='images/demo/" + p.Product_image + "' alt=''></a></li>";
                        PopulateNew.InnerHtml = displayNew;
                    }

                    if (p.Product_Category == "Refill")
                    {
                        displayRefill += "<li class='one_third'><a class='imgover' href='AboutProduct.aspx?PID=" + p.Product_Id + "'><img src='images/demo/" + p.Product_image + "' alt=''></a></li>";
                        PopulateRefill.InnerHtml = displayRefill;
                    }

                    if (p.Product_Category == "Exchange")
                    {
                        displayExchange += "<li class='one_third'><a class='imgover' href='AboutProduct.aspx?PID=" + p.Product_Id + "'><img src='images/demo/" + p.Product_image + "' alt=''></a></li>";
                        PopulateExchange.InnerHtml = displayExchange;
                    }
                }
                else {

                    if (p.Product_Category == "New")
                    {
                        displayNew += "<li class='one_third'><a class='imgover' href='#'><pre>Out of Stock</pre><img src='images/demo/" + p.Product_image + "' alt=''></a></li>";
                        PopulateNew.InnerHtml = displayNew;
                    }

                    if (p.Product_Category == "Refill")
                    {
                        displayRefill += "<li class='one_third'><a class='imgover' href='#'><pre>Out of Stock</pre><img src='images/demo/" + p.Product_image + "' alt=''></a></li>";
                        PopulateRefill.InnerHtml = displayRefill;
                    }

                    if (p.Product_Category == "Exchange")
                    {
                        displayExchange += "<li class='one_third'><a class='imgover' href='#'><pre>Out of Stock</pre><img src='images/demo/" + p.Product_image + "' alt=''></a></li>";
                        PopulateExchange.InnerHtml = displayExchange;
                    }

                }
               
            }
            
        }
    }
}