<%@ Page Language="C#" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="report" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <p align="center" 
        style="font-family: 'Bodoni MT Condensed'; font-size: 400%; font-weight: 900; font-style: italic; font-variant: normal; color: #0000FF;">
        RANDOM PASSWORD GENERATION</p>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    <p align="center">
        Select Category :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Name</asp:ListItem>
            <asp:ListItem>Date</asp:ListItem>
            <asp:ListItem>Show All Data</asp:ListItem>
        </asp:DropDownList>
    </p>
    </form>
</body>
</html>
