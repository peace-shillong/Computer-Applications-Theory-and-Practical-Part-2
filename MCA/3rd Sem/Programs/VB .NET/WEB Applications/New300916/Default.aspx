<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
    <div>
    
        DropDown Combox App<br />
        <br />
        <br />
    
    </div>
    <p>
        Application to work with combo boxes</p>
    <p>
        Select Colour From the Combo box (Also Know as Dropdown list)</p>
    <p>
        <asp:DropDownList ID="ColourList1" runat="server">
        </asp:DropDownList>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Select" />
    <br />
    Selected Colour :
    <br />
    <asp:Label ID="color" runat="server"></asp:Label>
    </form>
</body>
</html>
