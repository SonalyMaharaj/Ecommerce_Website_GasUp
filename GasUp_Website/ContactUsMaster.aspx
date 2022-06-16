<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="ContactUsMaster.aspx.cs" Inherits="GasUp_Website.ContactUsMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="layout/styles/ContactUs.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    		<h3>Get in Touch</h3>

	<div class="container">
	    <form id="form1" runat="server">
		<label for="fname">First Name</label>
		<input type="text" runat="server" id="fname" name="firstname" placeholder="Your name..">

		<label for="lname">Last Name</label>
		<input type="text" runat="server" id="lname" name="lastname" placeholder="Your last name..">
		
		<label for="email">Email</label>
		<input type="text" runat="server" id="email" name="email" placeholder="Your email address..">
		
		<label for="phone">Phone Number</label>
		<input type="text" runat="server" id="phone" name="phone" placeholder="Your phone number..">

		<label for="query">Query</label>
		<textarea id="query" runat="server" name="query" placeholder="Write something.." style="height:200px"></textarea>

		<center><asp:Button id="btnSubmit" runat="server" Text="Submit" BackColor="#990099" OnClick="btnSubmit_Click" Width="250px" /></center>

            <div runat="server" id="msg"></div>
	    </form>
	</div>


    <div class="wrapper row3">
  <section class="hoc container clear"> 
    <!-- ################################################################################################ -->
    <div class="sectiontitle">
      <p class="nospace font-xs">Help Us Help You by growing our presence</p>
      <p class="heading underline font-x2">Follow us on social media</p>
    </div>
    <ul id="latest" class="nospace group">
      <li class="one_third first">
        <article><a class="imgover" href="#"><img src="images/demo/admin.png" alt=""></a>
          <ul class="nospace meta clear">
            <li><i class="fas fa-user"></i> <a href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">GasUp</a></li>
            <li><i class="fas fa-comments"></i> <a href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">Comments (1)</a></li>
          </ul>
          <div class="excerpt clear">
            <h6 class="heading">How good looking are we. New tanks = New perspective</h6>
            <time datetime="UTC +2 SAST Tue, 9:40:54 pm"><strong>05</strong> <em>Aug</em></time>
            <p>Check out our new range of tanks, the color and aesthetic of it really brings our stock together...&hellip;</p>
          </div>
          <footer><a class="btn" href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">Read More</a></footer>
        </article>
      </li>
      <li class="one_third">
        <article><a class="imgover" href="#"><img src="images/demo/admin.png" alt=""></a>
          <ul class="nospace meta clear">
            <li><i class="fas fa-user"></i> <a href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">GasUp</a></li>
            <li><i class="fas fa-comments"></i> <a href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">Comments (10)</a></li>
          </ul>
          <div class="excerpt clear">
            <h6 class="heading">We say no to cold water, Gas for the win(ter)</h6>
            <time datetime="UTC +2 SAST Wed, 11:28:53 am"><strong>10</strong> <em>Sep</em></time>
            <p>We have officially been licenced to install gas geysers, be sure to check out our promotions...&hellip;</p>
          </div>
          <footer><a class="btn" href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">Read More</a></footer>
        </article>
      </li>
      <li class="one_third">
        <article><a class="imgover" href="#"><img src="images/demo/admin.png" alt=""></a>
          <ul class="nospace meta clear">
            <li><i class="fas fa-user"></i> <a href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">GasUp</a></li>
            <li><i class="fas fa-comments"></i> <a href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">Comments (3)</a></li>
          </ul>
          <div class="excerpt clear">
            <h6 class="heading">Loyalty from me equates to Loyalty from you</h6>
            <time datetime="UTC +2 SAST Sat, 13:18:21 pm"><strong>01</strong> <em>Oct</em></time>
            <p>With Loyalty points like these being given away as an added gain , who could resist...&hellip;</p>
          </div>
          <footer><a class="btn" href="https://www.facebook.com/pages/category/Local-Business/Gas-Up-JHB-1085212921506177/">Read More</a></footer>
        </article>
      </li>
    </ul>
    <!-- ################################################################################################ -->
  </section>
</div>
</asp:Content>
