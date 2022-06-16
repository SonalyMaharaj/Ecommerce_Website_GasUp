<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="AboutInstallation.aspx.cs" Inherits="GasUp_Website.AboutInstallation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="layout/styles/About_Product.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<form runat="server">
    <h2 style="text-align:center">Installation Information</h2>

		<div runat="server" id="aboutInstall" class="card">
		  
		</div>
		<center><asp:Label ID="lbl_IsAdded" runat="server" Text="Login to Book Installation"></asp:Label></center>
	<center><asp:Button ID="InstallInfoBook" runat="server" Text="Book Installation" back-color="red" OnClick="InstallInfoBook_Click" Visible="false"/></center>
	</form>
</asp:Content>
