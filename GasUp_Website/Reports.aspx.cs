using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class Reports : System.Web.UI.Page
	{
		Service1Client client = new Service1Client();
		protected void Page_Load(object sender, EventArgs e)
		{
			var purchaseslists = client.get_purchases();
			//PRODUCT CYLINDERS
			int newT = 0;
			int refillT = 0;
			int exchT = 0;
			foreach (var a in purchaseslists)
			{
				var prodds = client.getProduct(a.Product_id);
				if (prodds != null)
				{

					if (prodds.Product_Category.Equals("New"))
					{
						newT++;
					}
					else if (prodds.Product_Category.Equals("Exchange"))
					{
						exchT++;
					}
					else if (prodds.Product_Category.Equals("Refill"))
					{
						refillT++;
					}

				}
			}

			string strcyliners = "";
			strcyliners += "<script>";
			strcyliners += "	var xValues = ['New Tank', 'Refill Tank', 'Exchange Tank'];";
			strcyliners += "var yValues = [" +newT+","+refillT+","+exchT+"];";
			strcyliners += "var barColors = [";
			strcyliners += "  '#b91d47',";
			strcyliners += "  '#00aba9',";
			strcyliners += "  '#e8c3b9'";
			strcyliners += "];";

			strcyliners += "new Chart('chart1', {";
			strcyliners += "	  type: 'pie',";
			strcyliners += "	  data: {";
			strcyliners += "labels: xValues,";
			strcyliners += "		datasets:";
			strcyliners += "	[{";
			strcyliners += "	backgroundColor: barColors,";
			strcyliners += "			  data: yValues";
			strcyliners += "			}]";
			strcyliners += "		  },";
			strcyliners += "	  options:";
			strcyliners += "{";
			strcyliners += "title:";
			strcyliners += "		{";
			strcyliners += "		display: true,";
			strcyliners += "			  text: 'Product Category Sales Analysis'";
			strcyliners += "			}";
			strcyliners += "}";
			strcyliners += "	});";
			strcyliners += "	</script>";
			productcylinders.InnerHtml = strcyliners;

			//INSTALLATIONS
			int stove = 0;
			int geyser = 0;
			int fireplace = 0;
			foreach (var a in purchaseslists)
			{
				var installations = client.getInstallation(a.Product_id);
				if (installations!=null) {

					if (installations.Install_Name.Equals("Gas Stove")) {
						stove++;
					}
					else if (installations.Install_Name.Equals("Gas Fireplace")) {
						geyser++;
					}
					else if (installations.Install_Name.Equals("Gas Geyser")) {
						fireplace++;
					}
				
				}
			}
			string instcatt = "";
			instcatt += "<div style = 'background -color:black;color:white;padding:20px;' >";
			instcatt += " <canvas id = 'chart2'style = 'width:100%;max-width:600px'></canvas>";
			instcatt += "<script>";
			instcatt += "	var xValues = ['Gas Stove', 'Gas Geyser', 'Gas Fireplace'];";
			instcatt += "var yValues = ['" + stove + "', '" + geyser + "', '" + fireplace + "'];";
			instcatt += "var barColors = [";
			instcatt += "  '#b91d47',";
			instcatt += "  '#2b5797',";
			instcatt += "	  '#1e7145'";
			instcatt += "	];";
			instcatt += "	new Chart('chart2', {";
			instcatt += "		  type: 'pie',";
			instcatt += "	  data: {";
			instcatt += "labels: xValues,";
			instcatt += "		datasets:";
			instcatt += "	[{";
			instcatt += "	backgroundColor: barColors,";
			instcatt += "		  data: yValues";
			instcatt += "		}]";
			instcatt += "	  },";
			instcatt += "	  options:";
			instcatt += "{";
			instcatt += "	title:";
			instcatt += "		{";
			instcatt += "	display: true,";
			instcatt += "		  text: 'Installation Category Performance'";
			instcatt += "		}";
			instcatt += "	}";
			instcatt += "	});";
			instcatt += "	</script>";

			instcatt += "</div>";
			instcattegories.InnerHtml = instcatt;

			//Categry by size

			List<int> size3_9=new List<int>();
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

			foreach (var a in purchaseslists)
			{
				var installations = client.getProduct(a.Product_id);
				if (installations != null)
				{

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

					string innerhtml = "";
			innerhtml += "<script>";
			innerhtml += "var xValues = [3.9, 6, 9, 11, 18, 19, 47, 48];";

			innerhtml += "new Chart('chart3', {";
			innerhtml += "type: 'line',";
			innerhtml += "data: {";
			innerhtml += "labels: xValues,";
			innerhtml += "datasets:";
			innerhtml += "[{";
			innerhtml += "	data:[0,0,"+size9[1]+",0,0,"+ size19[1] + ",0,"+ size48[1] + "],";
			innerhtml += "		  borderColor: 'red',";
			innerhtml += "		  fill: false";
			innerhtml += "		}, {";
			innerhtml += "	data:[0,0,"+ size9[2] + ",0,0,"+ size19[2] + ",0,"+ size48[2] + "],";
			innerhtml += "		  borderColor: 'green',";
			innerhtml += "		  fill: false";
			innerhtml += "		}, {";
			innerhtml += "	data:["+size3_9[3]+ ","+size6[3]+","+ size9[1] + ","+ size11[3] + ","+ size9[3] + ","+ size9[3] + ","+size47[3] + ","+size48[3] + "],";
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
			analy.InnerHtml = innerhtml;
			//Customerrs

			int customers = 0;
			int registered = 0;
			var users = client.GetUsers();
			foreach (var b in users)
			{
				registered++;
		

					if (b.UserType.Equals("CU"))
					{
						customers++;
					}

				
			}
			string custmers = "";
			custmers += "<table style = 'width:100%' >";


			custmers += "<tr>";

			custmers += "	 <th> Month </th>";

			custmers += " <th> Number of Registrations</th>";

			custmers += "<th> Number of Customers</th>";

			custmers += "  <th> Advertisment Costs </th>";

			custmers += "</tr>";

			custmers += "<tr>";

			custmers += "  <td> January </td>";

			custmers += "<td> "+ registered + "</td>";

			custmers += "  <td> "+ customers + " </td>";

			custmers += "	  <td> R150.00 </td>";

			custmers += "</tr>";

			/*custmers += " <tr>";

			custmers += "	 <td> February </td>";

			custmers += " <td> 26 </td>";

			custmers += " <td> 10 </td>";

			custmers += " <td> R300.00 </td>";

			custmers += " </tr>";

			custmers += " <tr>";

			custmers += "<td> March </td>";

			custmers += "<td> 64 </td>";

			custmers += "<td> 35 </td>";

			custmers += "<td> R400.00 </td>";

							 custmers += "</tr>";

			custmers += "<tr>";

			custmers += " <td> April </td";

			custmers += " <td> 125 </td>";

			custmers += "  <td> 73 </td>";

			custmers += "  <td> R400.00 </td>";

			custmers += "</tr>";*/

			custmers += " </table>";
			idcustomers.InnerHtml = custmers;
			//end of customer analysis
			int installs = 0;
			int cylinders = 0;
			foreach (var a in purchaseslists)
			{
				var someproduct = client.getProduct(a.Product_id);
				if (someproduct != null)
				{
					cylinders++;
				}
				else {
					installs++;
				}

			}
			string charthtml = "<div>";
			charthtml += "<script>";
			charthtml += "var xValues = ['Installations', 'Cylinders'];";
			charthtml += "var yValues = ["+ installs + ","+ cylinders + "];";
			charthtml += "var barColors = ['red', 'blue'];";

			charthtml += "new Chart('myChart', {";
			charthtml += "  type: 'bar',";
			charthtml += "  data: {";
			charthtml += "labels: xValues,";
			charthtml += "	datasets:";
			charthtml += "	[{";
			charthtml += "	backgroundColor: barColors,";
			charthtml += "	  data: yValues";
			charthtml += "	}]";
			charthtml += " },";
			charthtml += "  options:";
			charthtml += "	{";
			charthtml += "legend: { display: false},";
			charthtml += "	title:";
			charthtml += "	{";
			charthtml += "	display: true,";
			charthtml += "	  text: 'Services Statistics'";
			charthtml += "	}";
			charthtml += "	}";
			charthtml += "	});";
			charthtml += "</script></div>";
			myCharthere.InnerHtml = charthtml;
		}
    }
}