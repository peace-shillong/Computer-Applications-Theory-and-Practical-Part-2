<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-weight: 700" text="#3366ff">
    <p>
        Using Regular Expressions</p>
    <form id="form1" runat="server">
    <p>
        Enter Name:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" Height="22px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtName" ErrorMessage="enter small letters only" 
            ValidationExpression="[a-z]*"></asp:RegularExpressionValidator>
    </p>
    <p>
        Enter Mobile No&nbsp;
        <asp:TextBox ID="txtPhno" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="txtPhno" ErrorMessage="enter Numbers only" 
            ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
    </p>
    <p>
        Enter Full Name&nbsp;
        <asp:TextBox ID="txtFName" runat="server" Height="24px" Width="315px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
            ControlToValidate="txtFName" ErrorMessage="input error" 
            ValidationExpression="[a-zA-Z ]*"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="OK" />
    </p>
    <p>
        &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
