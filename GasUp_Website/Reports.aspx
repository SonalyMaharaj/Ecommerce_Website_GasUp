<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="GasUp_Website.Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reports</title>
	<link rel="stylesheet" href="layout/styles/Reports.css">
	<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.min.js"></script>
</head>
<body>
    		<div class="bg-image" style="background-image: url('images/demo/backgrounds/reportBackground.jpg');"></div>
		
		<div class="bg-text">
		  <h2>Gas Up</h2>
		  <h1 style="font-size:50px">Analysis Reports</h1>
		</div>
		
		<div style="background-color:black;color:white;padding:20px;">
		
			<canvas id="chart1" style="width:100%;max-width:600px"></canvas>
			<div id="productcylinders" runat="server"></div>
		
		</div>
		
		<div style="background-color:black;color:white;padding:20px;">
		
			<canvas id="chart2" style="width:100%;max-width:600px"></canvas>
			<div id="instcattegories" runat="server"></div>
		
		</div>
		
	<!--code goes here-->
	
		
		<div  style="background-color:black;color:white;padding:20px;">
		
			<canvas id="chart3" style="width:100%;max-width:600px"></canvas>
			<p> Number of tanks sold according to size in each product category. </p>
			<p> Blue - Refills </p>
			<p> Red - Exchanges </p>
			<p> Green - New </p>
			<div id="analy" runat="server">
			
		</div>
		</div>
		
		<h2>Monthly analysis of Activity</h2>
	<div id="idcustomers" runat="server"></div>
		
		
		<div style="background-color:black;color:white;padding:20px;">
		
		<canvas id="myChart" style="width:100%;max-width:600px"></canvas>
			<div id="myCharthere" runat="server">
				<!--code goes here-->
			</div>
		
		
		</div>
</body>
</html>
