<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="GasUp_Website.Location" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>My First Google Map</h1>

<div id="googleMap" style="width:100%;height:400px;"></div>

<script>
    function myMap() {
        var mapProp = {
            center: new google.maps.LatLng(51.508742, -0.120850),
            zoom: 5,
        };
        var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
    }
</script>

<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCblcR-ONDB7XU8d7ae9hMJDjqjinudatk&callback=myMap"></script>
</asp:Content>
