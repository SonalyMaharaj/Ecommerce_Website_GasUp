using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class purchaseInfo : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["Userid"]);
            var lists = client.get_purchases();
            string innerhtml = "";
            string tablehtml = "<table  height='100%'><col style='width:50%'>";
                    
            tablehtml += "<tr>";
            tablehtml += "<th>Description</th>";
            tablehtml += "<th>Qty</th>";
            tablehtml += "<th>Unit Price</th>";
            tablehtml += "<th>Amount</th>";
            tablehtml += "</tr>";
            double subtotal = 0;
            string address = "";
            Purchase purchase=new Purchase();
            foreach (var a in GasUp.CartItems) {

                //str.Replace("@", "@" + System.Environment.NewLine)
                var product = client.getProduct(a.id);
                address = "</br>"+GasUp.province;
                address += "</br>" + GasUp.town;
                address += "</br>" + GasUp.city;
                address += "</br>" + GasUp.home;
                address += "</br>" + GasUp.postcode;
                tablehtml += "<tr>";
                if (product != null)
                {

                    tablehtml += "<td>" + product.Product_Description + " size: " + product.Product_Size + " Type(Category): " + product.Product_Category + "</td>";
                    tablehtml += "<td>" + a.quantity + "</td>";
                    tablehtml += "<td>" + product.Product_Price + "</td>";
                    tablehtml += "<td>" + Math.Round((a.quantity * product.Product_Price), 2) + "</td>";
                    subtotal += Convert.ToDouble(Math.Round((a.quantity * product.Product_Price), 2));
                    tablehtml += "</tr>";
                }
                else {
                    //booked installation
                    var installation = client.getInstallation(a.id);
                    if (installation!=null) {
                        tablehtml += "<td>INSTALLATION:" + installation.Install_Description + " Duration: " + installation.Install_Duration + "hrs</td>";
                        tablehtml += "<td>" + a.quantity + "</td>";
                        tablehtml += "<td>" + installation.Install_Price + "</td>";
                        tablehtml += "<td>" + Math.Round((a.quantity * installation.Install_Price), 2) + "</td>";
                        subtotal += Convert.ToDouble(Math.Round((a.quantity * installation.Install_Price), 2));
                        tablehtml += "</tr>";
                    }
                }
            }


            var customer = client.getUser(id);
            innerhtml += "<h4>" + customer.Name + " " + customer.surname + "</h4>";
            innerhtml += "<h4>" + address + "</h4>";
            innerhtml += "<h4>" + customer.email + "</h4>";
            innerhtml += "<h4>" + customer.phone + "</h4>";
            /*points between 10 and 20, that is 15% discount
             21 and 40 that is 20% discount
            41 and 60 that is 30% discount
            61 and 100 that is 40%
            100 and infinity that is 50% discount*/
            double discount = 2;
            var points = client.get_purchase_cust(id);
            if (points.loyalty_points <= 20 && points.loyalty_points >= 10) {
                discount = 0.1*subtotal;
            }
            else if (points.loyalty_points > 20 && points.loyalty_points < 41)
            {
                discount = 0.2 * subtotal;
            }
            else if (points.loyalty_points > 40 && points.loyalty_points < 61)
            {
                discount = 0.3 * subtotal;
            }
            else if (points.loyalty_points > 60 && points.loyalty_points >101)
            {
                discount = 0.4 * subtotal;

            }
            else if (points.loyalty_points > 100)
            {
                discount = 0.5 * subtotal;
            }
            else {
                discount = 0;
            }
            double shipping=GasUp.shippingfee; //fixed
            
            tablehtml += "</table>";
            tablehtml +="<h3>Sub Total: R"+ subtotal + "<h3>";
            tablehtml +="<h3>Discounts R"+ discount + "<h3>";
            tablehtml +="<h3>Shipping cost: R"+ shipping + "<h3>";
            tablehtml +="<h3>Total: R"+ (subtotal+shipping-discount) + "<h3>";
            tablehtml +="<center><h2>The Manager Will email specific delivery details<h2></center>";
            purchaseinfo.InnerHtml = innerhtml;
            table.InnerHtml = tablehtml;
            GasUp.CartItems = new List<ShoppingCart>();
        }
    }
}