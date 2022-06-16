<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="CocApplication.aspx.cs" Inherits="GasUp_Website.CocApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="layout/styles/COC_Apply.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    		<h2>COC Application Form</h2>

	<form id="form1" runat="server">

	  <div class="container">
		<label for="email"><b>Email</b></label>
		<input type="text" runat="server" id="email" placeholder="Enter Email" name="email" required>

		<label for="phone"><b>Phone Number</b></label>
		<input type="text" runat="server" id="phone" placeholder="Enter Phone Number" name="phone" required>
		
		<label for="install"><b>Installation type</b></label>
		<input type="text" runat="server" id="install" placeholder="Enter Installation type to be approved" name="install" required>
			
		<br>
		  <br>
		
	      <center><asp:Button ID="btnApply" type="submit" runat="server" Height="39px" Text="Apply" Width="536px" BackColor="#990099" ForeColor="White" OnClick="btnApply_Click" /></center>

	  </div>

		<div runat="server" id="msg"></div>

	</form>

</asp:Content>
