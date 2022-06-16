using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            var purchaseslists = client.get_purchases();
            int numberpurchases = 0;
            string innerhtml = "";
        
            innerhtml += " <script>";


            //INSTALLATIONS
            int stove = 0;
            int geyser = 0;
            int fireplace = 0;
            foreach (var a in purchaseslists)
            {
                numberpurchases++;
                var installations = client.getInstallation(a.Product_id);
                if (installations != null)
                {

                    if (installations.Install_Name.Equals("Gas Stove"))
                    {
                        stove++;
                    }
                    else if (installations.Install_Name.Equals("Gas Fireplace"))
                    {
                        geyser++;
                    }
                    else if (installations.Install_Name.Equals("Gas Geyser"))
                    {
                        fireplace++;
                    }

                }
            }


            innerhtml += "var ctx = document.getElementById('chart-bars').getContext('2d');";

            innerhtml += "  new Chart(ctx, {";
            innerhtml += "type: 'bar',";
            innerhtml += " data: {";
            innerhtml += "  labels: ['Stove', 'Geyser', 'Fireplace'],";
            innerhtml += " datasets: [{";
            innerhtml += "     label: 'Bookings',";
            innerhtml += "     tension: 0.4,";
            innerhtml += "    borderWidth: 0,";
            innerhtml += "    borderRadius: 4,";
            innerhtml += "    borderSkipped: false,";
            innerhtml += "     backgroundColor: '#fff',";
             innerhtml += "      data: ["+ stove + ", "+ geyser + ", "+ fireplace + "],";
            innerhtml += "    maxBarThickness: 6";
            innerhtml += "     }, ],";
            innerhtml += "     },";
            innerhtml += "   options: {";
            innerhtml += "  responsive: true,";
            innerhtml += "    maintainAspectRatio: false,";
            innerhtml += "     plugins: {";
            innerhtml += "    legend: {";
            innerhtml += "        display: false,";
            innerhtml += "      }";
            innerhtml += "     },";
            innerhtml += "   interaction: {";
            innerhtml += "    intersect: false,";
            innerhtml += "     mode: 'index',";
            innerhtml += "   },";
            innerhtml += "    scales: {";
            innerhtml += "    y: {";
            innerhtml += "    grid: {";
            innerhtml += "     drawBorder: false,";
            innerhtml += "     display: false,";
            innerhtml += "     drawOnChartArea: false,";
            innerhtml += "    drawTicks: false,";
            innerhtml += "     },";
            innerhtml += "   ticks: {";
            innerhtml += "      suggestedMin: 0,";
            innerhtml += "    suggestedMax: 500,";
            innerhtml += "       beginAtZero: true,";
            innerhtml += "        padding: 15,";
            innerhtml += "         font: {";
            innerhtml += "          size: 14,";
            innerhtml += "          family: 'Open Sans',";
            innerhtml += "           style: 'normal',";
            innerhtml += "          lineHeight: 2";
            innerhtml += "          },";
            innerhtml += "          color: '#fff'";
            innerhtml += "         },";
            innerhtml += "       },";
            innerhtml += "      x: {";
            innerhtml += "       grid: {";
            innerhtml += "         drawBorder: false,";
            innerhtml += "        display: false,";
            innerhtml += "        drawOnChartArea: false,";
            innerhtml += "      drawTicks: false";
            innerhtml += "     },";
            innerhtml += "    ticks: {";
            innerhtml += "       display: false";
            innerhtml += "     },";
            innerhtml += "     },";
            innerhtml += "    },";
            innerhtml += "     },";
            innerhtml += "   });";
           




            //Categry by size

            List<int> size3_9 = new List<int>();
            List<int> size6 = new List<int>();
            List<int> size9 = new List<int>();
            List<int> size11 = new List<int>();
            List<int> size18 = new List<int>();
            List<int> size19 = new List<int>();
            List<int> size47 = new List<int>();
            List<int> size48 = new List<int>();
            size3_9.Add(0);
            size3_9.Add(0);
            size3_9.Add(0);
            size3_9.Add(0);

            size6.Add(0);
            size6.Add(0);
            size6.Add(0);
            size6.Add(0);

            size9.Add(0);
            size9.Add(0);
            size9.Add(0);
            size9.Add(0);

            size11.Add(0);
            size11.Add(0);
            size11.Add(0);
            size11.Add(0);

            size18.Add(0);
            size18.Add(0);
            size18.Add(0);
            size18.Add(0);

            size19.Add(0);
            size19.Add(0);
            size19.Add(0);
            size19.Add(0);

            size47.Add(0);
            size47.Add(0);
            size47.Add(0);
            size47.Add(0);

            size48.Add(0);
            size48.Add(0);
            size48.Add(0);
            size48.Add(0);
            Decimal totalsales =0;
            foreach (var a in purchaseslists)
            {
                var installations = client.getProduct(a.Product_id);
                if (installations != null)
                {
                    totalsales += installations.Product_Price * a.quantity;

                    if (installations.Product_Size.Equals(3.9))
                    {


                        if (installations.Product_Category.Equals("New"))
                        {
                            size3_9.Insert(1, size3_9[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size3_9.Insert(2, size3_9[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size3_9.Insert(3, size3_9[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(6))
                    {

                        if (installations.Product_Category.Equals("New"))
                        {
                            size6.Insert(1, size6[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size6.Insert(2, size6[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size6.Insert(3, size6[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(9))
                    {

                        if (installations.Product_Category.Equals("New"))
                        {
                            size9.Insert(1, size9[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size9.Insert(2, size9[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size9.Insert(3, size9[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(11))
                    {

                        if (installations.Product_Category.Equals("New"))
                        {
                            size11.Insert(1, size11[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size11.Insert(2, size11[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size11.Insert(3, size11[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(18))
                    {

                        if (installations.Product_Category.Equals("New"))
                        {
                            size18.Insert(1, size18[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size18.Insert(2, size18[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size18.Insert(3, size18[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(19))
                    {

                        if (installations.Product_Category.Equals("New"))
                        {
                            size19.Insert(1, size19[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size19.Insert(2, size19[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size19.Insert(3, size19[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(47))
                    {

                        if (installations.Product_Category.Equals("New"))
                        {
                            size47.Insert(1, size47[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size47.Insert(2, size47[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size47.Insert(3, size47[3]++);
                        }
                    }
                    else if (installations.Product_Size.Equals(48))
                    {
                        if (installations.Product_Category.Equals("New"))
                        {


                            size48.Insert(1, size48[1]++);
                        }
                        else if (installations.Product_Category.Equals("Exchange"))
                        {
                            size48.Insert(2, size48[2]++);
                        }
                        else if (installations.Product_Category.Equals("Refill"))
                        {
                            size48.Insert(3, size48[3]++);
                        }
                    }

                }
            }
            innerhtml += " var ctx2=document.getElementById('chart-line').getContext('2d');";
            innerhtml += "var xValues = [3.9, 6, 9, 11, 18, 19, 47, 48];";

            innerhtml += "new Chart(ctx2, {";
            innerhtml += "type: 'line',";
            innerhtml += "data: {";
            innerhtml += "labels: xValues,";
            innerhtml += "datasets:";
            innerhtml += "[{";
            innerhtml += "	data:[0,0," + size9[1] + ",0,0," + size19[1] + ",0," + size48[1] + "],";
            innerhtml += "		  borderColor: 'red',";
            innerhtml += "		  fill: false,";
            innerhtml += "		}, {";
            innerhtml += "	data:[0,0," + size9[2] + ",0,0," + size19[2] + ",0," + size48[2] + "],";
            innerhtml += "		  borderColor: 'green',";
            innerhtml += "		  fill: false";
            innerhtml += "		}, {";
            innerhtml += "	data:[" + size3_9[3] + "," + size6[3] + "," + size9[1] + "," + size11[3] + "," + size9[3] + "," + size9[3] + "," + size47[3] + "," + size48[3] + "],";
            innerhtml += "		  borderColor: 'blue',";
            innerhtml += "		  fill: false";
            innerhtml += "		}]";
            innerhtml += "	  },";
            innerhtml += "	  options:";
            innerhtml += "{";
            innerhtml += "legend: { display: false}";
            innerhtml += "	}";
            innerhtml += "});";
            innerhtml += "	</script>";


            innerhtml += "</div>";
            dynam.InnerHtml = innerhtml;
            totsales.InnerText ="R"+totalsales;

            int customers = 0;
            int registered = 0;
            int loyalcustomers = 0;
            var users = client.GetUsers();
            foreach (var b in users)
            {
                registered++;


                if (b.UserType.Equals("CU"))
                {
                    customers++;
                    var loyal = client.get_purchase_cust(b.Id);
                    if (loyal!=null) {
                        loyalcustomers++;
                    }
                }


            }
            totcusts.InnerText = "" + customers;
            loyalcusts.InnerText = ""+loyalcustomers;
            numpurchases.InnerText =""+ numberpurchases;

            /*
            string innerhtml2 = "";

            innerhtml2 += "<script>";
            innerhtml2 += "var xValues = [3.9, 6, 9, 11, 18, 19, 47, 48];";

            innerhtml2 += "new Chart('chart3', {";
            innerhtml2 += "type: 'line',";
            innerhtml2 += "data: {";
            innerhtml2 += "labels: xValues,";
            innerhtml2 += "datasets:";
            innerhtml2 += "[{";
            innerhtml2 += "	data:[0,0," + size9[1] + ",0,0," + size19[1] + ",0," + size48[1] + "],";
            innerhtml2 += "		  borderColor: 'red',";
            innerhtml2 += "		  fill: false";
            innerhtml2 += "		}, {";
            innerhtml2 += "	data:[0,0," + size9[2] + ",0,0," + size19[2] + ",0," + size48[2] + "],";
            innerhtml2 += "		  borderColor: 'green',";
            innerhtml2 += "		  fill: false";
            innerhtml2 += "		}, {";
            innerhtml2 += "	data:[" + size3_9[3] + "," + size6[3] + "," + size9[1] + "," + size11[3] + "," + size9[3] + "," + size9[3] + "," + size47[3] + "," + size48[3] + "],";
            innerhtml2 += "		  borderColor: 'blue',";
            innerhtml2 += "		  fill: false";
            innerhtml2 += "		}]";
            innerhtml2 += "	  },";
            innerhtml2 += "	  options:";
            innerhtml2 += "{";
            innerhtml2 += "legend: { display: false}";
            innerhtml2 += "	}";
            innerhtml2 += "});";
            innerhtml2 += "	</script>";
            innerhtml2 += "	</div>";

            
            analy.InnerHtml = innerhtml2;*/
            /*
            innerhtml += " var ctx2=document.getElementById('chart-line').getContext('2d');";

             innerhtml += " var gradientStroke1 = ctx2.createLinearGradient(0, 230, 0, 50);";

            innerhtml += "gradientStroke1.addColorStop(1,'rgba(203,12,159,0.2)');";
            innerhtml += "gradientStroke1.addColorStop(0.2,'rgba(72,72,176,0.0)');";
            innerhtml += "gradientStroke1.addColorStop(0,'rgba(203,12,159,0)');";

            innerhtml += " var gradientStroke2 = ctx2.createLinearGradient(0, 230, 0, 50);";

            innerhtml += "   gradientStroke2.addColorStop(1, 'rgba(20,23,39,0.2)');";
            innerhtml += " gradientStroke2.addColorStop(0.2, 'rgba(72,72,176,0.0)');";
            innerhtml += "  gradientStroke2.addColorStop(0, 'rgba(20,23,39,0)');";

            innerhtml += "   var gradientStroke3 = ctx2.createLinearGradient(0, 230, 0, 50);";

            innerhtml += "  gradientStroke3.addColorStop(1, 'rgba(20,23,39,0.2)');";
            innerhtml += "      gradientStroke3.addColorStop(0.2, 'rgba(72,72,176,0.0)');";
            innerhtml += "   gradientStroke3.addColorStop(0, 'rgba(20,23,39,0)'); //purple colors";

            innerhtml += "     new Chart(ctx2, {";
            innerhtml += "  type: 'line',";
            innerhtml += "  data: {";
            innerhtml += "   labels:['3.9kg', '6kg', '9kg', '11kg', '18kg', '19kg', '47kg', '48kg'],";
            innerhtml += "  datasets:";
            innerhtml += "         [{";
            innerhtml += "         label: 'New Tank',";
            innerhtml += "      tension: 0.4,";
            innerhtml += "     borderWidth: 0,";
            innerhtml += "    pointRadius: 0,";
            innerhtml += "     borderColor: '#cb0c9f'";
          innerhtml += "    borderWidth: 3,";
            innerhtml += "    backgroundColor: gradientStroke1,";
            innerhtml += "  fill: true,";
            innerhtml += "      data:[50, 40, 300, 220, 500, 250, 400, 230],";
            innerhtml += "    maxBarThickness: 6";

            innerhtml += " },";
            innerhtml += "  {";
            innerhtml += "        label: 'Refill Tank',";
            innerhtml += "     tension: 0.4,";
            innerhtml += "      borderWidth: 0,";
            innerhtml += "      pointRadius: 0,";
            innerhtml += "    borderColor: '#3A416F',";
        innerhtml += "      borderWidth: 3,";
            innerhtml += "      backgroundColor: gradientStroke2,";
            innerhtml += "     fill: true,";
            innerhtml += "    data:[30, 90, 40, 140, 290, 290, 340, 230],";
            innerhtml += "     maxBarThickness: 6";
            innerhtml += "   },";
            innerhtml += "    {";
            innerhtml += "        label: 'Exchange Tank',";
            innerhtml += "    tension: 0.4,";
            innerhtml += "  borderWidth: 0,";
            innerhtml += "   pointRadius: 0,";
            innerhtml += "  borderColor: '#34495E',";
            innerhtml += "  borderWidth: 3,";
            innerhtml += "   backgroundColor: gradientStroke3,";
            innerhtml += "    fill: true,";
            innerhtml += "   data:[30, 90, 40, 140, 290, 290, 340, 230],";
            innerhtml += "    maxBarThickness: 6";
            innerhtml += "     },";
            innerhtml += "    ],";
            innerhtml += "    },";
            innerhtml += "    options:";
            innerhtml += "       {";
            innerhtml += "          responsive: true,";
            innerhtml += "maintainAspectRatio: false,";
            innerhtml += "    plugins:";
            innerhtml += "           {";
            innerhtml += "          legend:";
            innerhtml += "           {";
            innerhtml += "           display: false,";
            innerhtml += " }";
            innerhtml += "        },";
            innerhtml += "  interaction:";
            innerhtml += "         {";
            innerhtml += "        intersect: false,";
            innerhtml += "   mode: 'index',";
            innerhtml += "  },";
            innerhtml += "  scales:";
            innerhtml += "         {";
            innerhtml += "        y:";
            innerhtml += "      {";
            innerhtml += "    grid:";
            innerhtml += "       {";
            innerhtml += "      drawBorder: false,";
            innerhtml += "   display: true,";
            innerhtml += "   drawOnChartArea: true,";
            innerhtml += " drawTicks: false,";
            innerhtml += "    borderDash:[5, 5]";
            innerhtml += "    },";
            innerhtml += "   ticks:";
            innerhtml += "        {";
            innerhtml += "             display: true,";
            innerhtml += "   padding: 10,";
            innerhtml += "     color: '#b2b9bf',";
            innerhtml += "       font:";
            innerhtml += "                  {";
            innerhtml += "                  size: 11,";
            innerhtml += "     family: 'Open Sans',";
            innerhtml += "    style: 'normal',";
            innerhtml += "       lineHeight: 2";
            innerhtml += "   },";
            innerhtml += "     }";
            innerhtml += "          },";
            innerhtml += "      x:";
            innerhtml += "              {";
            innerhtml += "          grid:";
            innerhtml += "            {";
            innerhtml += "        drawBorder: false,";
            innerhtml += "     display: false,";
            innerhtml += "       drawOnChartArea: false,";
            innerhtml += "      drawTicks: false,";
            innerhtml += "  borderDash:[5, 5]";
            innerhtml += "    },";
            innerhtml += "    ticks:";
            innerhtml += "             {";
            innerhtml += "         display: true,";
            innerhtml += "   color: '#b2b9bf',";
            innerhtml += "   padding: 20,";
            innerhtml += "  font:";
            innerhtml += "{";
                
                
                innerhtml += "               size: 11,";
                innerhtml += "     family: Open Sans',";
                innerhtml += "   style: 'normal',";
                innerhtml += "   lineHeight: 2";
                innerhtml += "    },";
                innerhtml += "   }";
                innerhtml += "          },";
                innerhtml += "    },";
                innerhtml += "},";
                innerhtml += " });";
            innerhtml += "</script>iv>";
            dynam.InnerHtml = innerhtml;*/

            /*
            innerhtml += " var ctx2 = document.getElementById('chart -line').getContext('2d');";

            innerhtml += " var gradientStroke1 = ctx2.createLinearGradient(0, 230, 0, 50);";

            innerhtml += " gradientStroke1.addColorStop(1, 'rgba(203,12,159,0.2)');";
            innerhtml += "gradientStroke1.addColorStop(0.2, 'rgba(72,72,176,0.0)');";
            innerhtml += "  gradientStroke1.addColorStop(0, 'rgba(203,12,159,0)'); //purple colors";

            innerhtml += " var gradientStroke2 = ctx2.createLinearGradient(0, 230, 0, 50);";

            innerhtml += " gradientStroke2.addColorStop(1, 'rgba(20,23,39,0.2)');";
            innerhtml += " gradientStroke2.addColorStop(0.2, 'rgba(72,72,176,0.0)');";
            innerhtml += " gradientStroke2.addColorStop(0, 'rgba(20,23,39,0)'); //purple colors";

            innerhtml += " var gradientStroke3 = ctx2.createLinearGradient(0, 230, 0, 50);";

            innerhtml += " gradientStroke3.addColorStop(1, 'rgba(20,23,39,0.2)');";
            innerhtml += " gradientStroke3.addColorStop(0.2, 'rgba(72,72,176,0.0)');";
            innerhtml += " gradientStroke3.addColorStop(0, 'rgba(20,23,39,0)'); //purple colors";
            innerhtml +="new Chart(ctx2, {";
            innerhtml += "type: 'line',";
            innerhtml += "data: {";
            innerhtml += " labels: ['3.9kg', '6kg', '9kg', '11kg', '18kg', '19kg', '47kg', '48kg'],";
            innerhtml += "datasets: [{";
            innerhtml += "  label: 'New Tank',";
            innerhtml += " tension: 0.4,";
            innerhtml += " borderWidth: 0,";
            innerhtml += "  pointRadius: 0,";
            innerhtml += " borderColor: '#cb0c9f',";
           innerhtml += " borderWidth: 3,";
            innerhtml += " backgroundColor: gradientStroke1,";
            innerhtml += "  fill: true,";
            innerhtml += " data::[0, 0, " + size9[2] + ", 0, 0, "+ size19[2] + ", 0, "+ size48[2] + "],";
            innerhtml += " maxBarThickness: 6";

            innerhtml += " },";
            innerhtml += "{";
            innerhtml += "   label: 'Refill Tank',";
            innerhtml += "  tension: 0.4,";
            innerhtml += "  borderWidth: 0,";
            innerhtml += "   pointRadius: 0,";
            innerhtml += "  borderColor: '#3A416F',";
          innerhtml += "  borderWidth: 3,";
            innerhtml += " backgroundColor: gradientStroke2,";
            innerhtml += "  fill: true,";
            innerhtml +="data:[" +size3_9[3]+ ","+size6[3]+","+ size9[1] + ","+ size11[3] + ","+ size9[3] + ","+ size9[3] + ","+size47[3] + ","+size48[3] + "],";
            innerhtml +="maxBarThickness: 6";
         innerhtml += " },";
            innerhtml += " {";
            innerhtml += "   label: 'Exchange Tank',";
            innerhtml += "     tension: 0.4,";
            innerhtml += "  borderWidth: 0,";
            innerhtml += "  pointRadius: 0,";
            innerhtml += "    borderColor: '#34495E',";
        innerhtml += "    borderWidth: 3,";
            innerhtml += "     backgroundColor: gradientStroke3,";
            innerhtml += "    fill: true,";
            innerhtml += "    data:[0,0," + size9[1]+",0,0,"+ size19[1] + ",0,"+ size48[1] + "],";
            innerhtml += "     maxBarThickness: 6";
            innerhtml += "    },";
            innerhtml += "   ],";
            innerhtml += "   },";
            innerhtml += "   options: {";
            innerhtml += "    responsive: true,";
            innerhtml += "   maintainAspectRatio: false,";
            innerhtml += "   plugins: {";
            innerhtml += "      legend: {";
            innerhtml += "     display: false,";
            innerhtml += "      }";
            innerhtml += "   },";
            innerhtml += "  interaction: {";
            innerhtml += "  intersect: false,";
            innerhtml += "   mode: 'index',";
            innerhtml += "  },";
            innerhtml += "  scales: {";
            innerhtml += "    y: {";
            innerhtml += "    grid: {";
            innerhtml += "       drawBorder: false,";
            innerhtml += "     display: true,";
            innerhtml += "       drawOnChartArea: true,";
            innerhtml += "        drawTicks: false,";
            innerhtml += "       borderDash: [5, 5]";
            innerhtml += "    },";
            innerhtml += "    ticks: {";
            innerhtml += "     display: true,";
            innerhtml += "     padding: 10,";
            innerhtml += "      color: '#b2b9bf',";
            innerhtml += "     font: {";
            innerhtml += "       size: 11,";
            innerhtml += "       family: 'Open Sans',";
            innerhtml += "       style: 'normal',";
            innerhtml += "       lineHeight: 2";
            innerhtml += "     },";
            innerhtml += "    }";
            innerhtml += "  },";
            innerhtml += "  x: {";
            innerhtml += "  grid: {";
            innerhtml += "   drawBorder: false,";
            innerhtml += "    display: false,";
            innerhtml += "    drawOnChartArea: false,";
            innerhtml += "    drawTicks: false,";
            innerhtml += "     borderDash: [5, 5";
            innerhtml += "     },";
            innerhtml += "   ticks: {";
            innerhtml += "    display: true,";
            innerhtml += "      color: '#b2b9bf',";
            innerhtml += "     padding: 20,";
            innerhtml += "    font: {";
            innerhtml += "       size: 11,";
            innerhtml += "     family: 'Open Sans',";
            innerhtml += "      style: 'normal',";
            innerhtml += "      lineHeight: 2";
            innerhtml += "      },";
            innerhtml += "       }";
            innerhtml += "     },";
            innerhtml += "     },";
            innerhtml += "   },";
            innerhtml += "   });";
            innerhtml += "</script>";*/
            //dynam.InnerHtml = innerhtml;


        }
    }
}