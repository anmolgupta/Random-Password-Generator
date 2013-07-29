<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo.aspx.cs" Inherits="Demo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" 
        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#666666" StaticSubMenuIndent="10px">
        <StaticSelectedStyle BackColor="#1C5E55" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
        <DynamicMenuStyle BackColor="#E3EAEB" />
        <DynamicSelectedStyle BackColor="#1C5E55" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticHoverStyle BackColor="#666666" ForeColor="White" />
        <Items>
            <asp:MenuItem Text="New Item" Value="New Item">
                <asp:MenuItem Text="New Item" Value="New Item">
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
        </Items>
        <StaticItemTemplate>
            <%# Eval("Text") %>
        </StaticItemTemplate>
    </asp:Menu>
    <asp:TreeView ID="TreeView1" runat="server">
    </asp:TreeView>
    </form>
</body>
</html>
