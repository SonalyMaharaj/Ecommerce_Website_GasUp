<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="AboutProduct.aspx.cs" Inherits="GasUp_Website.AboutProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="layout/styles/About_Product.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

		
		<form id="form1" runat="server">

		<h2 style="text-align:center">Product Information</h2>
			<div runat="server" id="aboutProd" class="card">

			</div>
			
		<center><select runat="server" class="form-group" type="text" id="select_Quantity" name="select_Quantity" Width="700px" visible="false">
			<option value="1"> Quantity</option>
		<option value="1"> 1</option>
		<option value="2"> 2</option>
		<option value="3"> 3</option>
		<option value="4"> 4</option>
		<option value="5"> 5</option>
		<option value="6"> 6</option>
		<option value="7"> 7</option>
		<option value="8"> 8</option>
		<option value="9"> 9</option>
		<option value="10"> 10</option>
		<option value="11"> 11</option>
		<option value="12"> 12</option>
		<option value="13"> 13</option>
		<option value="14"> 14</option>
		<option value="15"> 15</option>
		<option value="16"> 16</option>
		<option value="17"> 17</option>
		<option value="18"> 18</option>
		<option value="19"> 19</option>
		<option value="20"> 20</option>

		</select><center>
			
		    <asp:Button ID="addtocart" runat="server" Text="Add to Cart" class="card" Width="700px" Height="40px" BackColor="Red" OnClick="Button1_Click" Visible="false"/>

		
		

        </form>

</asp:Content>
