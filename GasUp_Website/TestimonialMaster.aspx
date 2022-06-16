<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="TestimonialMaster.aspx.cs" Inherits="GasUp_Website.TestimonialMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="wrapper bgded overlay" style="background-image:url('images/demo/logo.png'); top: -12px; left: 4px;">
  <section id="testimonials" class="hoc container clear"> 
    <!-- ################################################################################################ -->
    <div class="sectiontitle">
      <p style="color:white" class="nospace font-xs">Gas Up Customer Testimonials</p>
      <p style="color:white" class="heading underline font-x2">We're all about transparency</p>
    </div>
    <article class="btmspace-80" >
      <blockquote>The  on time delivery and friendly service is top notch. I don't usually do this, but Gas Up is the one. Thank you guys for ensuring I have one less in home battle.</blockquote>
      <figure class="clear"><img src="images/demo/anon.png" alt="">
        <figcaption>
          <h6 class="heading">John Doe</h6>
          <em>Aspen Hills Resident</em></figcaption>
      </figure>

        <div id="idtestimonials" runat="server">
            <!--code goes here-->

        </div>
    </article>
    <footer class="center"><a class="btn" href="TestimonialMaster.aspx?id=1">More Testimonials</a></footer>
    <!-- ################################################################################################ -->

      <!--write testimonial-->
      
      

  </section>
       
</div>
         <center><label for="testimonial" id="testimonial_label" style="font-size:20px" runat="server"><a href="LogIn.aspx">Login to Write Your Testimonial:</a></label>
      <div id="testimonial_div" runat="server" visible="false">
      <textarea type="text" runat="server" rows="4" cols="40" id="txttestimonial" placeholder="My Testimonial" name="testimonial" required="required" ></textarea>
      <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="Submit" width="200px" class="button contact_submit_button"/>
          <br><br>
        </div></center>
    </form>
</asp:Content>
