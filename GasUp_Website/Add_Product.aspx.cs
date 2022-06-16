using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class Add_Product : System.Web.UI.Page
    {

        Service1Client client = new Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string prepath = "images\\demo\\";
            if (Session["UserType"].Equals("MA") && Session["UserId"] != null)
            {
                var id=0;
               
                id=Convert.ToInt32(Request.QueryString["id"]);
                if (id==0)
                {
                }
                if (id != 999)
                { //clicked from the navbar
                    pagetitle.InnerHtml = "<h2>Edit product</h2>";
                    btnadd_product.Text = "Submit Changes";


                    var product = client.getProduct(id);

                    pagetitle.InnerHtml = "<h2>Edit product</h2>";
                    btnadd_product.Text = "Submit Changes";
                    if (product != null)
                    {

                        string innerhtml = "<img src=" + prepath + product.Product_image + " alt='A Short description of image' class='img_resize'/>";
                        pro_img.InnerHtml = innerhtml;
                    }

                    if (!IsPostBack)
                    {


                        product_price.Value = Convert.ToString(product.Product_Price);
                        product_size.Value = Convert.ToString(product.Product_Size);
                        product_category.Value = product.Product_Category;
                        product_aval.Value = Convert.ToString(product.Product_Availability);
                        product_image.Value = product.Product_image;
                        description.Value = product.Product_Description;

                        //product image here

                    }

                }
                else {
                    string innerhtml = "<img src=" + prepath+"logo.png alt='A Short description of image' class='img_resize'/>";
                    pro_img.InnerHtml = innerhtml;
                }

            }
            else {
                Response.Redirect("Home.aspx");
            }
        }

        protected void addproduct_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToInt32(Request.QueryString["id"]).Equals(999))
            {
                //add product
                bool isadded = client.addProduct(description.Value,product_category.Value,Convert.ToDecimal(product_price.Value),Convert.ToDecimal(product_size.Value) ,Convert.ToInt32(product_aval.Value),product_image.Value);
                if (isadded==true) {
                    lbl_IsAdded.Text = "Product Successfully added";
                }
                else
                {
                    lbl_IsAdded.Text = "Product Edit  failed";
                }
            }
            else {
                //edit product
                var id = Convert.ToInt32(Request.QueryString["id"]);
                var product = client.getProduct(id);
                
                bool isedited = client.editProduct(id, description.Value,product_category.Value, Convert.ToDecimal(product_price.Value), Convert.ToDecimal(product_size.Value), Convert.ToInt32(product_aval.Value), product_image.Value);

                if (isedited == true)
                {
                    lbl_IsAdded.Text = "Product Successfully Edited";
                }
                else {
                    //"<img style='background-image: url(" + a.CauseImg + ");'><img>";

                    lbl_IsAdded.Text = "Product Edit  failed";
                }
            }
        }
    }
}