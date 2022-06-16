<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="GasUp_Website.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">

  <title>Forgot Password GasUp</title>

    <link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">

	<link rel="stylesheet" href="layout/styles/bootstrap_plain.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="layout/styles/bootstrap_theme.css" media="screen" type="text/css" />

  <link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'>
	
    <link rel="stylesheet" href="layout/styles/sign_in_syles.css" media="screen" type="text/css" />
</head>
<body class="overlay" style="background-image:url('images/demo/backgrounds/tankBackground.jpg" >
<font color="black">
  <div class="login-card">
    <h1>Forgot Password</h1><br>
	
      <form id="form1" runat="server">
  
	
   
	<input type="email" runat="server" style="height:40px" size="41px" placeholder="Username (registered email address)" id="email" name="email" required="required"><br>
          <asp:Button ID="Button1" runat="server" Text="Next" type="submit" name="forgotpswrd" class="login login-submit" OnClick="Button1_Click"/>
          <br>
  
      </form>
	
  <div class="login-help">
    <a href="Register.aspx">Register</a> • <a href="LogIn.aspx">Already have an account?</a>
	  <font color="black" ><p><br/>If you no longer use the email address associated with your gasUp account, you may contact <a href="ContactUsMaster.aspx">Customer Service</a> for help restoring access to your account.</p>
	</font>
  </div>
</div>


<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
</font>
</body>
</html>
