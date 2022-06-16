using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class more : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        Double discount_percentage = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"]!=null && Session["UserType"].ToString().Equals("CU") && Request.QueryString["invoice"]!=null) {
                info.Visible = false;
                invoices.Visible = true;
                int id = Convert.ToInt32(Session["Userid"]);
                var purchase = client.get_purchases();


                //   var lists = client.get_purchases();
                string innerhtml = "";
                string tablehtml = "";
                int index = 0;
                foreach (var a in purchase) {
                    if (a.Customer_id.Equals(id)) {
                        index++;
                        double subtotal = 0;
                        string address = a.delivery_Address;
                        var customer = client.getUser(id);
                        tablehtml += "<br><hr><br>";
                        tablehtml += "<h1 style='color:magenta;'>INVOICE " + index+"</h1>";
                        tablehtml += "<h4>" + customer.Name + " " + customer.surname + "</h4>";
                        tablehtml += "<h4>" + address + "</h4>";
                        tablehtml += "<h4>" + customer.email + "</h4>";
                        tablehtml += "<h4>" + customer.phone + "</h4>";
                        tablehtml += "<table  height='100%'><col style='width:50%'>";
                        tablehtml += "<tr>";
                        tablehtml += "<th>Description</th>";
                        tablehtml += "<th>Qty</th>";
                        tablehtml += "<th>Unit Price</th>";
                        tablehtml += "<th>Amount</th>";
                        tablehtml += "</tr>";


                        //str.Replace("@", "@" + System.Environment.NewLine)
                        var product = client.getProduct(a.Product_id);
                        if (product != null)
                        {
                            tablehtml += "<tr>";
                            tablehtml += "<td>" + product.Product_Description + " size: " + product.Product_Size + " Type(Category): " + product.Product_Category + "</td>";
                            tablehtml += "<td>" + a.quantity + "</td>";
                            tablehtml += "<td>" + product.Product_Price + "</td>";
                            tablehtml += "<td>" + Math.Round((a.quantity * product.Product_Price), 2) + "</td>";
                            subtotal += Convert.ToDouble(Math.Round((a.quantity * product.Product_Price), 2));
                            tablehtml += "</tr>";

                        }
                        else {
                            //for displaying booked info
                            var installation = client.getInstallation(a.Product_id);
                            if (installation!=null) {
                                tablehtml += "<tr>";
                                tablehtml += "<td>INSTALLATION "+ installation.Install_Name+ ":" + installation.Install_Description + " Duration: " + installation.Install_Duration + "hrs</td>";
                                tablehtml += "<td>" + a.quantity + "</td>";
                                tablehtml += "<td>" + installation.Install_Price + "</td>";
                                tablehtml += "<td>" + Math.Round((a.quantity * installation.Install_Price), 2) + "</td>";
                                subtotal += Convert.ToDouble(Math.Round((a.quantity * installation.Install_Price), 2));
                                tablehtml += "</tr>";
                            }
                        }

                        /*points between 10 and 20, that is 15% discount
                         21 and 40 that is 20% discount
                        41 and 60 that is 30% discount
                        61 and 100 that is 40%
                        100 and infinity that is 50% discount*/
                        discount_percentage =Convert.ToDouble(a.Discount_percentage/100);
                        double discount = discount_percentage* subtotal;
                        double shipping = 50; //fixed

                        tablehtml += "</table>";
                        tablehtml += "<h3>Sub Total: R" + subtotal + "<h3>";
                        tablehtml += "<h3 style='color:red;'>Discounts R" + discount + "<h3>";
                        tablehtml += "<h3>Shipping cost: R" + a.shipping + "<h3>";
                        tablehtml += "<h3 style='color:red;'>Total: R" + (subtotal + shipping - discount) + "<h3>";
                      
                       
                        

                    }
                }
                purchaseinfo.InnerHtml = innerhtml;
                table.InnerHtml = tablehtml;
            }
        }
    }
}