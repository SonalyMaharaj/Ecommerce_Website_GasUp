using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class Cart : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        decimal discount_percentage = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"].ToString().Equals("CU"))
            {
                String tablehtml = "";
                //product name, product price, quantity, (price*quantity),image
                tablehtml += "<table>";
                tablehtml += "<tr>";
                tablehtml += "<th>Product</th>";
                tablehtml += "<th>price</th>";
                tablehtml += "<th>Quantity</th>";
                tablehtml += "<th>Total</th>";
                tablehtml += "<th>Image</th>";
                tablehtml += "</tr>";

                double est_total = 00;
                double sub_total = 00;
                double shippingfee = 50;
                double discount = 0;
                int index = 0;
                foreach (ShoppingCart sc in GasUp.CartItems) //iterate through the session ids (there is no way a user is going to add more than oneK sessions)
                {
                    //style="background-color:black;color:white;width:150px;
                    // height: 40px; "
                    var product = client.getProduct(sc.id);
                    var installation = client.getInstallation(sc.id);
                   
                    if (product != null)
                    {
                        sub_total += Convert.ToDouble(sc.quantity * product.Product_Price);
                        tablehtml += "<tr>";
                        tablehtml += "<th>" + product.Product_Size + "-tank:" + product.Product_Category + "-" + product.Product_Description + "</th>";
                        tablehtml += "<th>" + product.Product_Price + "</th>";
                        tablehtml += "<th>" + sc.quantity + "</th>";
                        tablehtml += "<th>" + Convert.ToDouble(sc.quantity * product.Product_Price) + "</th>";
                        tablehtml += "<th><img src = 'images\\demo\\" + product.Product_image + "' alt = '' widht = '300' style = 'height: 200px' ></ img></th>";
                        tablehtml += "<th><Button><a href='Removefromcart.aspx?id=" + index + "' style='background-color:red;width:50px'>X</a></Button></th>";
                        tablehtml += "</tr>";
                       
                    }
                    else if (installation!=null){

                        sub_total += Convert.ToDouble(installation.Install_Price);
                        tablehtml += "<tr>";
                        tablehtml += "<th>INSTALLATION:" + installation.Install_Description +" Duration: "+ installation .Install_Duration+ "hrs</th>";
                        tablehtml += "<th>" + installation.Install_Price + "</th>";
                        tablehtml += "<th>" + 1 + "</th>";
                        tablehtml += "<th>" + Convert.ToDouble(sc.quantity * installation.Install_Price) + "</th>";
                        tablehtml += "<th><img src = 'images\\demo\\" + installation.Install_Image + "' alt = '' widht = '300' style = 'height: 200px' ></ img></th>";
                        tablehtml += "<th><Button><a href='Removefromcart.aspx?id=" + index + "' style='background-color:red;width:50px'>X</a></Button></th>";
                        tablehtml += "</tr>";
                        
                    }
                    index++;
                    // quantity = 1;
                }

                int loyaltypoints = 0;
                var points = client.get_purchase_cust(Convert.ToInt32(Session["Userid"]));
                if (points != null)
                {
                    loyaltypoints= points.loyalty_points;
                    if (points.loyalty_points <= 20 && points.loyalty_points >= 10)
                    {
                        discount = 0.1 * sub_total;
                        discount_percentage = 10;
                    }
                    else if (points.loyalty_points > 20 && points.loyalty_points < 41)
                    {
                        discount = 0.2 * sub_total;
                        discount_percentage = 20;
                    }
                    else if (points.loyalty_points > 40 && points.loyalty_points < 61)
                    {
                        discount = 0.3 * sub_total;
                        discount_percentage = 30;
                    }
                    else if (points.loyalty_points > 60 && points.loyalty_points > 101)
                    {
                        discount = 0.4 * sub_total;
                        discount_percentage = 40;

                    }
                    else if (points.loyalty_points > 100)
                    {
                        discount = 0.5 * sub_total;
                        discount_percentage = 40;
                    }
                    else
                    {
                        discount = 0;
                    }
                }
                tablehtml += "</table>";
                if (GasUp.CartItems.Count > 0)
                {
                    carttable.InnerHtml = tablehtml;
                }
                else
                {
                    carttable.InnerHtml = "<br><br><center><h2>NO ITEMS ADDED NO CART<h2></center><br><br>";
                }
            
                est_total = sub_total + shippingfee- discount;

                loypoints.InnerText = "Loyalty points: R" + loyaltypoints;
                subTotal.InnerText = "Sub Total: R" + sub_total;
                Shippingfee.InnerText = "Shipping fee: R"+ shippingfee;
                discountid.InnerText = "Discount: R"+ discount;
                estimated_totalid.InnerText = "Estimated Total: R"+est_total;
            }
        }

        protected void checkout_Click(object sender, EventArgs e)
        {
            bool isadded = false;
            foreach (ShoppingCart sc in GasUp.CartItems) {
                GasUp.province = province.Value;
                GasUp.town = town.Value;
                GasUp.city = city.Value;
                GasUp.home = Address.Value;
                GasUp.postcode = PAddress.Value;
                string address = GasUp.province;
                address += GasUp.town;
                address += GasUp.city;
                address += GasUp.home;
                address += GasUp.postcode;
                
                int shipping = 50;
                DateTime del_dat = Convert.ToDateTime(del_date.Value);
                if (del_dat.Equals(Convert.ToDateTime("01/01/2000"))) {
                    del_dat = Convert.ToDateTime(DateTime.Now.ToShortDateString()); ;
                    shipping = 250;

                }
                GasUp.shippingfee = shipping;
                var product = client.getProduct(sc.id);
              
                if (product != null){
                    int qunatity = product.Product_Availability - sc.quantity;
                    if (qunatity < 0)
                    {
                        qunatity = 0;
                    }
                    bool isedited = client.editProduct(product.Product_Id, product.Product_Description, product.Product_Category, product.Product_Price, product.Product_Size, qunatity, product.Product_image);

                    isadded = client.Add_purchase(Convert.ToInt32(Session["Userid"]), sc.id, del_dat, false, sc.quantity, Convert.ToDecimal(discount_percentage), address, shipping, 3);
                   
                }
                else{
                    var installation = client.getInstallation(sc.id);
                    if (installation!=null) {
                       
                        isadded = client.Add_purchase(Convert.ToInt32(Session["Userid"]), sc.id, del_dat, false, sc.quantity, Convert.ToDecimal(discount_percentage), address, shipping, 3);
                        
                    }
                }
        
            }
            if (isadded == true)
            {
                client.Edit_loyaltypoints(Convert.ToInt32(Session["Userid"]), 2); //everytime there is a purchase, increase points by 2

                Session["CartItems"] = 0;
                Response.Redirect("purchaseInfo.aspx");
            }
        }
    }
}