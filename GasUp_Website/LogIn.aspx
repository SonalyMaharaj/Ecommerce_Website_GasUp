<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="GasUp_Website.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8">

  <title>LogIn GasUp</title>

	<link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'>
	<link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
	
    <link rel="stylesheet" href="layout/styles/sign_in_syles.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="layout/styles/bootstrap_blue.css" media="screen" type="text/css" />
</head>
<body class="overlay" style="background-image:url('images/demo/backgrounds/tankBackground.jpg" >
<font color="black">
  <div class="login-card">
    <h1>Welcome back!</h1><br>
	
      <form id="form1" runat="server">
  
	
   
	<input type="email" runat="server" style="height:40px" size="42px" placeholder="Username (email)" id="email" name="email" required="required"><br><br>
	
	<input type="password" runat="server" style="height:40px" id="password" placeholder="Enter Password" name="password" required="required">
          <asp:Label id="error" runat="server" Text=""></asp:Label>
          <br>
   <asp:Button ID="Button1" runat="server" text="Login" class="login login-submit" OnClick="Button1_Click" />
          <br>
      </form>
	
  <div class="login-help">
    <a href="Register.aspx">Register</a> • <a href="ForgotPassword.aspx">Forgot Password</a>
  </div>
</div>


<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
</font>
</body>
</html>
