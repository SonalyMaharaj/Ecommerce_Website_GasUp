<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="GasUp_Website.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <form id="form1" runat="server" >
        <h3 id="loypoints" style="color: purple;" runat="server">Loyalty points: </h3>
    <div id="carttable" runat="server" style="margin-right:25%"></div>
        <div class="row">
   <div class="col-lg-4">
    <h4 id="subTotal" runat="server"> </h4>
    <h4 id="Shippingfee" runat="server"> </h4>
     <h4 style="color: red;" id="discountid" runat="server">Discount: </h4>
    <h3 style="color: red;" id="estimated_totalid" runat="server">Estimated Total: </h3>
   
        <br><br>
            <h2 id="install_info" style="color: Purple;" runat="server"><b><b>Delivery Information </h2>
            <label style="color: magenta;" for="Province">Province*:</label>
            <input type="text" runat="server" style="height:40px" id="province" placeholder="Gauteng(only)" name="Province" required="required" class="card" readonly><br><br>
    
            <label style="color: magenta;" for="city">City*:</label>
            <input type="text" runat="server" style="height:40px" id="city" placeholder="e.g Johannesburg" name="city" required="required" ><br><br>
            
            <label style="color: magenta;" for="city">Town:</label>
            <input type="text" runat="server" style="height:40px" id="town" placeholder="e.g Thembisa" name="town"  ><br><br>
    

            <label style="color: magenta;" for="Home">Home Address*:</label>
            <input type="text" runat="server" style="height:40px" id="Address" placeholder="e.g 73 rissik street, stinson road" name="Address" required="required"  ><br><br>
    
            <label style="color: magenta;" for="postal address">Postal code:</label>
            <input type="text" runat="server" style="height:40px" id="PAddress" placeholder="e.g 1634 " name="PAddress"  ><br><br>
        
            <!--<h2>Delivery will be done withing the next 5 days</h2>-->
            </div>
           <center> <div class="col-lg-4" margin-botton="100">
               
            <h2 style="color: purple;">Dicount rates: (Loyalty Points)</h2>
             <h3 style="color: magenta;">Get Discount up to 50%</h3>
             <h4>Loyalty points range(10,20)=10% discount</h4>
             <h4>Loyalty points range(21,40)=20% discount</h4>
             <h4>Loyalty points range(41,60)=30% discount</h4>
             <h4>Loyalty points range(61,100)=40% discount</h4>
             <h4>Loyalty points range(>100)=50% discount</h4>
             <img src="images/demo/mastercard-logo-2018-png-3.png" alt="We accept MasterCard" style ="height:70px">
             <img src="images/demo/Visa-Logo.png" alt="We accept Visa" style ="height:70px"><br>
               <div class="row">
                   <div class="col-lg-6">
                       <label style="color: magenta;" for="Home">Card Holder*:</label>
                     <input type="text" runat="server" style="height:40px" id="cardholder" placeholder="e.g S MOYO" name="Card Holder" required="required"  ><br><br>
    
                   </div>
                   
                   <div class="col-lg-6">
                       <label style="color: magenta;" for="Home">Card No*:</label>
                    <input type="text" runat="server" style="height:40px" id="accountno" placeholder="e.g 1234 4334 443 434" name="Card No" required="required"  ><br><br>
    
                   </div>
                   <label style="color: magenta;" for="Home">CVV*:</label>
                    <input type="text" runat="server" style="height:40px" id="CVV" placeholder="e.g 123" name="CVV" required="required"  ><br><br>
    

               </div>
               <div clasa="row">
            <div class="col-lg-6">
	   <Label style="color: magenta;" for="Authorized"> Select Delivery Date: </Label>
                   
       <select runat="server" style="width:160px" class="form-group" type="text" id="del_date" name="delivery date" placeholder="delivery date">
       
		<option value="01/01/2000"> Today</option>
		<option value="09/24/2021"> 09/24/2021</option>
		<option value="09/30/2021"> 09/30/2021</option>
		<option value="10/04/2021"> 10/04/2021</option>
		<option value="10/09/2021"> 10/09/2021</option>
	    </select>
                </div>
            <div class="col-lg-6">
                <pre><p>Same day delivery <br> fee is R250</p></pre>
            </div>
       </div>
             <asp:Button ID="checkout" runat="server" Text="Checkout" BackColor="Red" height="40px" width="120px" OnClick="checkout_Click" />
           </div></center>
    </div>

           
        
      
    </form>

    </b></b>

</asp:Content>
