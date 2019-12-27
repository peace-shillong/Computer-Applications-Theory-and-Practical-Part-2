<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Page2.aspx.vb" Inherits="Page2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Regular Exp</title>
</head>
<body>
    <p>
        Application to use Compare Validator with another control</p>
    <form id="form1" runat="server">
    <p>
        Enter Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtPwd" ErrorMessage="Password length should be max 8" 
            ValidationExpression="[a-zA-Z0-9 ]{8}"></asp:RegularExpressionValidator>
    </p>
    <p>
        Re-enter Password         <asp:TextBox ID="txtPwd2" runat="server"></asp:TextBox>
&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtPwd" ControlToValidate="txtPwd2" 
            ErrorMessage="you re-entered a wrong password"></asp:CompareValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Check" />
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
