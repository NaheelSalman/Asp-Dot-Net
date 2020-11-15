<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpForm.aspx.cs" Inherits="Web_Project.SignUpForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Scripts/bootstrap.min.css"/>
     <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="Icons/all.css" rel="stylesheet" />
    <link href="App_Themes/Theme1/dc.css" rel="stylesheet" />
    <script src="Scripts/jquery.min.js"></script>
  <script src="Scripts/popper.min.js"></script>
  <script src="Scripts/bootstrap.min.js"></script>
 
    <style type="text/css">
        .auto-style2 {
            width: 171px;
        }
        .auto-style3 {
            width: 296px;
        }
        .auto-style4 {
            width: 173px;
        }
        .auto-style5 {
            left: 0px;
            top: 0px;
            height: 78px;
        }
        .auto-style6 {
            left: 0px;
            top: 4px;
            height: 329px;
        }
    </style>
 
</head>
<body>
    <header>
<nav class="navbar navbar-expand-md bg-dark navbar-dark ">
  <a class="navbar-brand" id="logo" href="#">
  <img id="logo-img" src="Images/dc Logo.png" alt="Website Logo" style="height:auto; width:100%;" />
  </a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="collapsibleNavbar">
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link " href="WebForm1.aspx"><i class="fas fa-home">Home</i></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#features"><i class="fas fa-award">Features</i></a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="#about-us"><i class="fas fa-atlas">About-US</i></a>
      </li>    
      
        <li class="nav-item">
        <a class="nav-link" href="#contact-us"><i class="fas fa-address-card">Contact-US</i></a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="SignUpForm.aspx"><i class="fas fa-user-plus">SignUp</i></a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="#"><i class="fas fa-sign-in-alt">Login</i></a>
      </li>
    </ul>
  </div>  
</nav>
</header>
    <div class="jumbotron">
            <h1 style="text-align:center;">Sign Up Form</h1>
            <p>Become a member by filling this below form</p>
     </div>
    <div  id="signup" class="row">
        <div id="article" class="fa-pull-left col-lg-4">
            <h2>Join the Developer's Community</h2>
            <ul>
                <li>Get unstuck — ask a question</li>
                <li>Unlock new privileges like voting and commenting</li>
                <li>Save your favorite tags, filters, and jobs</li>
                <li>Earn reputation and badges</li>
            </ul>
        </div>
    
        <div class="fa-pull-left col-lg-8">
           <aside class="col-10" >
            <form id="form1" runat="server" >
        
            <table class="table table-dark table-hover" style="margin-top: 14px">
                <tr>
                    <td class="auto-style3" colspan="1">
                        <asp:Label ID="Label1" runat="server" Text="First Name" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" placeholder="e.g. 'Muhammad'" CssClass="form-control"></asp:TextBox>

                    </td>
                    <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please Enter Your Name" EnableClientScript="True"></asp:RequiredFieldValidator>
                    
                    </td>
           </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Last Name" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" placeholder="'Salman'" CssClass="form-control"></asp:TextBox></td>
   
                    <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name / Surname .. please" EnableClientScript="True"></asp:RequiredFieldValidator>
  
                    </td>
                    
                </tr>
                
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Email" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="@yahoo.com"  CssClass="form-control"></asp:TextBox></td>
                    <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please Enter your Valid Email Address"></asp:RequiredFieldValidator>
                  
                    </td>
           </tr>
           <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Password" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="password" TextMode="Password" CssClass="form-control"></asp:TextBox>

                    </td>
                    <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter your password"></asp:RequiredFieldValidator>
                    
                    </td>
            </tr>
        
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label8" runat="server" Text="Confirm Password" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtConfrmPass" runat="server" placeholder="password" TextMode="Password" CssClass="form-control"></asp:TextBox></td>
                   <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtConfrmPass" ErrorMessage="Please enter your password"></asp:RequiredFieldValidator>
                   </td>
                    <td class="auto-style2">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtConfrmPass" ControlToCompare="txtPassword" ErrorMessage="Password Doesn't Match"></asp:CompareValidator>
                    </td>
           </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Contact No" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtContactNo" runat="server" TextMode="Phone" CssClass="form-control" ></asp:TextBox>

                    </td>
      
                    <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtContactNo" ErrorMessage="Please Enter your phone number"></asp:RequiredFieldValidator>
 
                    </td>
                    
                </tr>
                
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Date Of Birth" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtDOB" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>

                    </td>
      
                    <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDOB" ErrorMessage="Select Your Date Of Birth"></asp:RequiredFieldValidator>
  
                    </td>              
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblMessage" runat="server" Text="Msg" BackColor="Gray"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnAddNewMember" runat="server" Text="Submit" CssClass="btn btn-primary btn-lg" OnClick="btnAddNewMember_Click" />

                    </td>
                </tr>
            </table>
            </form>
            </aside>
        </div>
   
        </div>
</body>
</html>
