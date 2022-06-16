<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="Add_Product.aspx.cs" Inherits="GasUp_Website.Add_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Add_Product</title>
  <link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
	<link rel="stylesheet" href="layout/styles/bootstrap_theme.css" media="screen" type="text/css" />

  <link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'>
	
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
		 <h1 id="pagetitle" runat="server">Add Product</h1><br>
      <form id="form1" runat="server">

	

	

	<input type="text" runat="server" style="height:40px" width="48" placeholder="Product price" id="product_price" name="product_price" required="required"><br><br>
	<input type="text" runat="server" style="height:40px" width="48" placeholder="Product Category" id="product_category" name="product_category" required="required"><br><br>
	
	<input type="text" runat="server" style="height:40px" id="product_size" placeholder="product size" name="product size" required="required"><br><br>
	<input type="text" runat="server" style="height:40px" id="product_image" placeholder="image(e.g tank1.jpg)" name="product image" required="required"><br><br>
	<!--<input type="text" runat="server" style="height:40px" id="product_Quantity" placeholder="Quantity(availability)" name="product Quantity" required="required"><br><br>
    -->
	
	<input type="text" runat="server" style="height:40px" id="product_aval" placeholder="Quantity" name="product Quantity" required="required"><br><br>
	
	
	<input type="text" runat="server" style="height:70px" id="description" placeholder="Enter product description" name="description" required="required"><br>
	
    <font color="white">
		<asp:Label ID="lbl_IsAdded" runat="server" Text=""></asp:Label>
</font>



        <br>
	
	
	<!--<label for="birthday" background="black">date of birth: <i class="fas fa-heart-circle"></i></label>
    <input type="date" id="birthday" placeholder="your birthday" name="birthday"><br><br>-->
          
          <asp:Button ID="btnadd_product" runat="server" Text="add Product" OnClick="addproduct_Click" class="button"/>
        <a id="idgoback" runat="server" href="MasterHome.aspx" visible="false"> <h4> ----------------- <-go back --------------------</h4> </a>
	
  
      </form>
	  </div>
			
	  </div>
</div>

<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
			
</font>



</asp:Content>
