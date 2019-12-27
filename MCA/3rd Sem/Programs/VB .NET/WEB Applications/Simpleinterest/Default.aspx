<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Application to Find Simple Interest<br />
        <br />
        Enter Princial&nbsp;&nbsp;
        <asp:TextBox ID="txtP" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToValidate="txtP" ErrorMessage="Principal must be greater than 0" 
            Operator="GreaterThan" Type="Integer" ValueToCompare="0"></asp:CompareValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtP" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
        <br />
        <br />
        Enter Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;         <asp:TextBox ID="txtR" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txtR" ErrorMessage="Range 1-20" MaximumValue="20" 
            MinimumValue="1"></asp:RangeValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtR" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
        <br />
        <br />
        Enter Time&nbsp;
        <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ControlToValidate="txtA" ErrorMessage="Time must be greater than 1" 
            Operator="GreaterThan" Type="Integer" ValueToCompare="1"></asp:CompareValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtA" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
        <br />
    
    </div>
    <asp:Button ID="Button1" runat="server" Text="Find" />
    <p>
        The Simple Interest:    <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
