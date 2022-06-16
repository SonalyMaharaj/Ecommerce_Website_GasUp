<%@ Page Title="" Language="C#" MasterPageFile="~/GasUp.Master" AutoEventWireup="true" CodeBehind="InstallationsMaster.aspx.cs" Inherits="GasUp_Website.InstallationsMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="bgded overlay" style="background-image:url('images/demo/backgrounds/tank2Background.jpg');">
  <figure class="hoc container clear imgroup"> 
    <!-- ################################################################################################ -->
    <figcaption class="sectiontitle">
      <p style="color:black" class="nospace font-xs"><b>The gas yard of Eden. COC approved.</b></p>
      <p style="color:black" class="heading underline font-x2"><b>The installation services we provide. </b></p>

        <p style="font-size:20px" >
            <center>
					<b>Gas installations that don't suck - Or your money back</b>
					<br>That's our promise to you. You give us the job of making your gas installation worries disappear - and we'll give you a compliant gas installation without hickups.
					<br>
					<br><b>Here's a list of a few of the things that make us special.</b>
					<br>Same day installations - anywhere in Gauteng.
					<br>We know your house is your castle. We keep it clean, we mess we cleanup. Period.
					<br>We've been at it since 1947. We know the rules and tricks, we know the gotchas.
					<br>We're the only guys in the country with 3g telemetry watching your consumption.
					<br>We're open 7 days a week, we install and we deliver every day.
					<br>Over 5000 home installations under the belt.
					<br>When we install we are only starting our relationship, we do servicing, repairs, maintenance and we supply the gas.
					<br>We hold your hand through this journey, we'll be friends by the time we're done.
					<br>We communicate and follow up throughout the process.
					<br>We don't live in our bakkies, we have brick and morter shops that you can toss maltov cocktails at if we let you down.
					<br>We can schedule or reschedule or cancel super quickly and painlessly, and we won't charge you for canceling last minute.
					<br>We send a different installer to inspect and issue the CoC so that we get independent checks on quality.
				</center>
        </p>

    </figcaption>
    <ul runat="server" id="PopulateInstall" class="nospace group">
      
    </ul>
    <!-- ################################################################################################ -->
  </figure>
</div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <section class="group">
      <div class="one_half first"><img class="inspace-15 borderedbox" src="images/demo/COC.jpg" alt=""></div>
      <div class="one_half">
        <ul class="nospace group inspace-15">
          <li class="one_half first btmspace-50">
            <article>
              <h6 class="heading"><a href="#">COC</a></h6>
              <p class="nospace">Let's jst get this out the way right up front. Any gas installation that's permanent in nature's gotta have a CoC, and the CoC's gotta be issued by a registered installer. Thems the law. Registered installers have a Certificate of Conformity available for clients upon installation. Only a registered installer can provide such a document. This document states that the installation took place under correct execution by a licensed installer. Without this document, insurance will not cover the cost of gas related damages / hazards.</p>
            <form runat="server">
                 <asp:Button ID="btnApplyCOC" runat="server" Text="Apply for COC" Width="202px" BackColor="#990099" OnClick="btnApplyCOC_Click" />
            </form>
               
            </article>
          </li>
          <li class="one_half btmspace-50">
            <article>
              <h6 class="heading"><a href="#">Consider</a></h6>
              <p class="nospace">The installer signing off takes complete responsibility for the whole installation. Nobody's gonna sign up for that without a carrot dangling somewhere therefore payment for this document is required. Not all COC issuing is done in person, you can send in photos and we can usually tell with a fairly high confidence level if your installation is certifiable, but the only way to know for sure is to be there and inspect. The physical inspection has to take place, there's no getting around that. Clean cut situation and done.</p>
            </article>
          </li>
        </ul>
      </div>
    </section>

</asp:Content>
