<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Web_Project.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Scripts/bootstrap.min.css"/>
     <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
     <script src="Scripts/jquery.min.js"></script>
  <script src="Scripts/popper.min.js"></script>
  <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="text-align:center;"><asp:Label ID="lblgridmsg" runat="server" CssClass="text-center" Text="Welcome To Admin Page"></asp:Label></h1>
        <asp:GridView ID="txtGridView" CssClass="table table-dark table-sm" runat="server"></asp:GridView>
    </form>
</body>
</html>
