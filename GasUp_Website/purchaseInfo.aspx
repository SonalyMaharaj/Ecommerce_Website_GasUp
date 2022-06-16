<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="purchaseInfo.aspx.cs" Inherits="GasUp_Website.purchaseInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <div class="row"> 
        <div class="col-lg-6">
            <h1><strong>GasUp</h1>

            
        </div>
        <div class="col-lg-6">
            <h1>INVOICE</h1>
        </div>
    </div>
    <br>
    <br>
    <br>
    <h2>Customer Details</h2>
    <div id="purchaseinfo" runat="server"></div>
    <div id="table" runat="server"></div>

</asp:Content>
