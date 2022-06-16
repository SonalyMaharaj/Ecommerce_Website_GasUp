using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class AboutProduct : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null) {
                addtocart.Visible = true;
                select_Quantity.Visible = true;
            }
            int ProdId = Convert.ToInt32(Request.QueryString["PID"].ToString());
            dynamic p = client.getProduct(ProdId);

            String display = "";
            if (p != null)
            {

                display += "<img src='images/demo/" + p.Product_image + "' alt='Gas Tank' style='width:100%'>";
                display += "<h1>" + p.Product_Size + "kg " + p.Product_Category + "  Gas Cylinder</h1>";
                display += "<p class='price'>R" + p.Product_Price + "</p>";
                display += "<p><br><b>Bottle Sizes and their uses</b>";
                display += "<br>" + p.Product_Description;
                display += "<br><br><b>Features</b><br>Size:" + p.Product_Size + "kg<br>";
                /*  display += "<br><b>Product/Packaging Information</b>";
                  display += "<br>Product Weight:" + p.Product_Weight + "kg";
                  display += "<br>Product Dimensions:" + p.Product_Dimensions;
                  display += "<br>Shipping Weight:" + p.Product_ShippingWeight + "kg";
                  display += "<br>Shipping Dimensions:" + p.Product_ShippingDimensions;*/
            }
            else {
                var installation = client.getInstallation(ProdId);
                if (installation != null)
                {


                    display += "<img src='images/demo/" + installation.Install_Image + "' alt='Gas Tank' style='width:100%'>";
                    display += "<h1>"+installation.Install_Name + "</h1>";
                    display += "<p class='price'>R" + installation.Install_Price + "</p>";
                    display += "<br>INSTALLATION:" + installation.Install_Description + " Duration: " + installation.Install_Duration + "hrs";
                   
                }
            }
            if (Request.QueryString["pre"] == null)
            {
                
            }
            else {
                var purchase = client.get_purchase(Convert.ToInt32(Request.QueryString["pre"]));
                select_Quantity.Visible = false;
                addtocart.Visible = false;
                if (purchase!=null) {
                    var customer = client.getUser(purchase.Customer_id);
                    display += "<br> Product Quantity: " + purchase.quantity + "<br>";
                    display += "<br><br><b> Customer Details </b><br> Name: " + customer.Name + "<br> ";
                    display += "<br> Surname: " + customer.surname + "<br>";
                    display += "<br> phone number: " + customer.phone + "<br> ";
                    display += "<br> <b>Delivery Address: " + "<br>" + purchase.delivery_Address;
                }
            }
               

            aboutProd.InnerHtml = display;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ShoppingCart newItem = new ShoppingCart(Convert.ToInt32(Request.QueryString["PID"]),Convert.ToInt32(select_Quantity.Value));
            GasUp.CartItems.Add(newItem);
            int items = Convert.ToInt32(Session["CartItems"].ToString());
            items += 1;
            Session["CartItems"]=items;
            Response.Redirect("GasTanks.aspx");
        }
    }
}