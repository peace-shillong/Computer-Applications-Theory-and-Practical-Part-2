<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Using Sessions</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Application to Share Information using&nbsp; Session Object<br />
        <br />
        Enter Your Name&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtName" ErrorMessage="Please Enter Your Name"></asp:RequiredFieldValidator>
        <br />
        <br />
        Enter Your Roll No         <asp:TextBox ID="txtNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:LinkButton ID="next" runat="server">Next Page</asp:LinkButton>
        <br />
    
    </div>
    <p>
&nbsp;</p>
    </form>
</body>
</html>
