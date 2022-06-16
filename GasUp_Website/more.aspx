<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="more.aspx.cs" Inherits="GasUp_Website.more" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div id="info" runat="server"> <center><h2 style="color: pink;">Dicount Monthly rates: (Loyalty Points)</h2>
             <h3 style="color: purple;">Get Discounts up to 50%</h3>
             <h4>Loyalty points range(10,20) = 10% discount</h4>
             <h4>Loyalty points range(21,40) = 20% discount</h4>
             <h4>Loyalty points range(41,60) = 30% discount</h4>
             <h4>Loyalty points range(61,100) = 40% discount</h4>
             <h4>Loyalty points range(>100) = 50% discount</h4>
                 <p>Get +2 loyalty points everytime you make a purchase and be part of the discount team.<br>We offer more than just cheaper prices, we offer quality at low prices.
                     Your loyalty points can get you a maximum of 50% in discounts. <br>Wow, what beats that? And better yet, we give you the opportunity to do it all over again every 3 months.
                     <pre>Loyalty points expire within three months of not redeeming them.
                         <br>Gas Up with Gas On The Go (Here to make you<i class="fa fa-smile-o" aria-hidden="true"> smile</i>)
                     </pre>
                 </p>
             </center></div>

        <div id="invoices" runat="server" visible="false">
            <br>
    <div class="row"> 
        <div class="col-lg-6">
            <h1><strong>GasUp</h1>

            
        </div>
        <div class="col-lg-6">
            <h1 style="color: magenta;">INVOICE</h1>
        </div>
    </div>
    <br>
    <br>
    <br>
    <h2 style="color: purple;" id="custd" runat="server">Customer Details</h2>
    <div id="purchaseinfo" runat="server"></div>
    <div id="table" runat="server"></div>
        </div>

</asp:Content>
