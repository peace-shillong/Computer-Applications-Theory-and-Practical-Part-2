<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using Sessions</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        The Name entered is :
        <asp:Label ID="lblName" runat="server"></asp:Label>
    
        <br />
        Roll Number is :
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    <asp:LinkButton ID="home" runat="server">Homepage</asp:LinkButton>
    </form>
</body>
</html>
