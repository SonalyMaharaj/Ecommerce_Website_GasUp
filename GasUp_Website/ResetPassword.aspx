<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="GasUp_Website.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8">

  <title>gasUp-log-in</title>

  <link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'>
<link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">

	
    <link rel="stylesheet" href="layout/styles/sign_in_syles.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="layout/styles/bootstrap_blue.css" media="screen" type="text/css" />
</head>
<body class="overlay" style="background-image:url('images/demo/backgrounds/tankBackground.jpg" >
<font color="black">
  <div class="login-card">
    <h1>Reset Password GasUp</h1><br>
	
      <form id="form1" runat="server">
  
	
   
	<input type="password" runat="server" style="height:40px"  placeholder="New Password" id="password" name="password" required="required"><br><br>
	
	<input type="password" style="height:40px" id="passwordC" placeholder="Confirm password" name="passwordC" required="required"><br>
          <asp:Button ID="Button1" runat="server" Text="Submit" type="submit" name="resetpsqrd" class="login login-submit" OnClick="Button1_Click"/>
          <br>
  
      </form>
	<!--
  <div class="login-help">
    <p>Reset your password</p>
  </div>-->
</div>


<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
</font>
    
</body>
</html>
