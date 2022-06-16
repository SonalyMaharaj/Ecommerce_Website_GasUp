<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="GasTanks.aspx.cs" Inherits="GasUp_Website.GasTanks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bgded overlay" style="background-image:url('images/demo/backgrounds/bluetankBackground.jpg');">
  <figure class="hoc container clear imgroup"> 
    <!-- ################################################################################################ -->
    <figcaption class="sectiontitle">
      <p style="color:white" class="nospace font-xs">Welcome to cylinder parenthood</p>
      <p style="color:white" class="heading underline font-x2">This is our range for non-tank owners</p>
    </figcaption>
    <ul runat="server" id="PopulateNew" class="nospace group">

    </ul>
    <!-- ################################################################################################ -->
  </figure>
  <!-- ################################################################################################ -->
</div>

     <div class="bgded overlay" style="background-image:url('images/demo/backgrounds/tank2Background.jpg');">
  <figure class="hoc container clear imgroup"> 
    <!-- ################################################################################################ -->
    <figcaption class="sectiontitle">
      <p style="color:white" class="nospace font-xs">Welcome to the top up station</p>
      <p style="color:white" class="heading underline font-x2">This is our range for filling up empty tanks</p>
    </figcaption>
    <ul runat="server" id="PopulateRefill" class="nospace group">

    </ul>
    <!-- ################################################################################################ -->
  </figure>
  <!-- ################################################################################################ -->
</div>

     <div class="bgded overlay" style="background-image:url('images/demo/backgrounds/orangetankBackground.jpg');">
  <figure class="hoc container clear imgroup"> 
    <!-- ################################################################################################ -->
    <figcaption class="sectiontitle">
      <p style="color:white" class="nospace font-xs">Welcome to the exchange relationship</p>
      <p style="color:white" class="heading underline font-x2">This is our range eligible for swap out</p>
    </figcaption>
    <ul runat="server" id="PopulateExchange" class="nospace group">

    </ul>
    <!-- ################################################################################################ -->
  </figure>
  <!-- ################################################################################################ -->
</div>
</asp:Content>
