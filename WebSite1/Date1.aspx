<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Date1.aspx.cs" Inherits="Date1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p align="center">
&nbsp;Enter date :
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList3_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp; to&nbsp;
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList4_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList5_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList6" runat="server">
            </asp:DropDownList>
            </p>
    <p align="center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    </p>
    <p align="center">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            Height="271px" Visible="False" Width="581px" CellPadding="4" 
            ForeColor="#333333" GridLines="None" >
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                                <%#Eval("name") %>
                            </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date">
                    <ItemTemplate>
                                <%#Eval("date") %>
                            </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                                <%#Eval("password") %>
                            </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
            </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
    </p>
    <p>
    </p>
</asp:Content>

