<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GasUp_Website.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">

  <title>Register GasUp</title>
  <link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">

	<link rel="stylesheet" href="layout/styles/bootstrap_plain.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="layout/styles/bootstrap_theme.css" media="screen" type="text/css" />

  <link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'>
	
    <link rel="stylesheet" href="layout/styles/sign_in_syles.css" media="screen" type="text/css" />
</head>

<body class="overlay" style="background-image:url('images/demo/backgrounds/tankBackground.jpg">
<font color="black">
  <div class="login-card">
    <h1 id="pagetitle" runat="server">Sign-up</h1><br>
      <form id="form1" runat="server">

	
    <input type="text" runat="server" style="height:40px" id="fname" placeholder="First Name" name="fname" required="required" class="container"  ><br><br>
    
	<input type="text" runat="server" style="height:40px" id="lname" placeholder="Last Name" name="lname" required="required" class="container"  ><br><br>
    
	
	<input type="email" runat="server" style="height:40px" size="41px" placeholder="Email Address" id="email" name="email" required="required"><br><br>
    
	<input type="phone" runat="server" style="height:40px" size="41px" placeholder="Phone Number" id="phone" name="phone" required="required"><br><br>
    
	
	<input type="password" runat="server" style="height:40px" id="password1" placeholder="Enter Password" name="password1" required="required"><br><br>
    
	<input type="password" runat="server" style="height:40px" id="password2" placeholder="Confirm Password" name="password2" required="required"><br><br>
    <div id="utype" runat="server" visible="false">
		<label for="selectUType">Choose User Type:</label>
	<select runat="server" class="form-group" type="text" id="selectUType" name="UserType">
		<option value="CU"> Customer</option>
		<option value="EM"> Employee</option>
		<option value="MA"> Manager</option>
		</select>
        
	</div>
	
	<!--<label for="birthday" background="black">date of birth: <i class="fas fa-heart-circle"></i></label>
    <input type="date" id="birthday" placeholder="your birthday" name="birthday"><br><br>-->
          
          <asp:Button ID="signup" runat="server" Text="Register" class="login login-submit" OnClick="signup_Click"/>
        <a id="idgoback" runat="server" href="MasterHome.aspx" visible="false"> <h4> ----------------- <-go back --------------------</h4> </a>
	
  
      </form>

  <div class="login-help" id="regDiv" runat="server">
    •<a href="LogIn.aspx">Already have an account?</a>
  </div>
</div>

<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
</font>
  
</body>
</html>
