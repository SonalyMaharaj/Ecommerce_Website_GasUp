<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="edit_purchase.aspx.cs" Inherits="GasUp_Website.edit_purchase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	
	<link rel="stylesheet" href="layout/styles/bootstrap_blue.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="layout/styles/backg_syles.css" media="screen" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <font color="white">
		
  <div style="background-color:#000000" >

	 <div class="row">
		 
		  <div class="col-md-6" id="pro_img" runat="server">
				<!--IMAGE GOES HERE-->
			</div>
		  <div class="col-md-6">
		 <font color="white" id="pagetitle" runat="server"></font><br>
      <form id="form1" runat="server">


	

	

	<!--<input type="text" runat="server" style="height:40px" width="48" placeholder="customer_name" id="customer_name" name="customer_name" required="required" readonly><br><br>
	<input type="text" runat="server" style="height:40px" width="48" placeholder="Surname" id="customer_surname" name="customer_surname" required="required" readonly><br><br>
	<input type="text" runat="server" style="height:40px" width="48" placeholder="Email Address" id="email" name="Email" required="required" readonly><br><br>
	<input type="text" runat="server" style="height:40px" width="48" placeholder="Product" id="product_info" name="product_info" required="required" readonly><br><br>
	<input type="text" runat="server" style="height:60px" id="address" placeholder="address" name="address" required="required" readonly><br><br>
	<input type="text" runat="server" style="height:40px" id="loyaltypoints" placeholder="Loyalty points" name="loyaltypoints" required="required" readonly><br><br>
	<div id="display" runat="server"></div>-->
		  <Label for="Authorized"> Authorized Purchase: </Label>
	<font color="black">
	
	<select runat="server" style="width:160px" class="form-group" type="text" id="authorized_purchase" name="authorized" placeholder="authorized">
		<option value="true"> TRUE</option>
		<option value="false"> FALSE</option>
	</select>
	 </font>
	<Label for="Authorized"> Delivery Date: </Label>
	<!--<font color="black">
	<select runat="server" style="width:160px" class="form-group" type="text" id="del_date" name="delivery date" placeholder="delivery date">
		<option value="09/24/2021"> 09/24/2021</option>
		<option value="09/30/2021"> 09/30/2021</option>
		<option value="10/04/2021"> 10/04/2021</option>
		<option value="10/09/2021"> 10/09/2021</option>
	</select>
		  </font>-->
	<!--<input type="text" runat="server" style="height:40px" id="assistant" placeholder="Assign Assistant" name="assistant" required="required"><br><br>
	
		  <input type="text" runat="server" style="height:40px" id="product_Quantity" placeholder="Quantity(availability)" name="product Quantity" required="required"><br><br>
    -->
	
		<br>
	
    <font color="white">
		<!--<asp:Label ID="lbl_IsAdded" runat="server" Text=""></asp:Label>-->
		<asp:Label ID="lblIsAdded" runat="server" Text=""></asp:Label>
	</font>
		   <br>
		<asp:Button ID="editpurchase" runat="server" Text="Assign Task" OnClick="editpurchase_Click" class="button"/>
        <a id="idgoback" runat="server" href="MasterHome.aspx" visible="false"> <h4> ----------------- <-go back --------------------</h4> </a>
	
  
      </form>
	  </div>
			
	  </div>
</div>

<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
			
</font>

</asp:Content>
