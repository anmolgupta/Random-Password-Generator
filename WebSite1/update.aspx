<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        width: 100%;
    }
    .style7
    {
        width: 236px;
    }
    .style8
    {
    }
    .style9
    {
        height: 28px;
    }
    .style10
    {
        width: 284px;
        height: 28px;
    }
    .style11
    {
        width: 243px;
        height: 28px;
    }
    .style12
    {
            width: 137px;
        }
    .style13
    {
        height: 28px;
        width: 137px;
    }
    .style14
    {
        width: 137px;
        height: 26px;
    }
    .style15
    {
        width: 284px;
        height: 26px;
    }
    .style16
    {
        width: 243px;
        height: 26px;
    }
    .style17
    {
        height: 26px;
    }
        .style18
        {
            width: 284px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="center">
    <br />
</p>
<p align="left">
    <table class="style6">
        <tr>
            <td class="style14">
            </td>
            <td class="style15">
                Enter name :</td>
            <td class="style16">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="style17">
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                &nbsp;</td>
            <td class="style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="This feild can't be left blank"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style13">
            </td>
            <td class="style10">
                Previous password :
            </td>
            <td class="style11">
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style9">
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                New Password&nbsp; Length :
            </td>
            <td class="style8">
                <asp:TextBox ID="TextBox3" runat="server" MaxLength="2"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                &nbsp;</td>
            <td class="style8" colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="This field can't be left blank"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="Enter an integer value between 8-14" 
                    MaximumValue="14" MinimumValue="8" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                Category :
            </td>
            <td class="style8">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>APLHABETIC</asp:ListItem>
                    <asp:ListItem>NUMERIC</asp:ListItem>
                    <asp:ListItem>ALPHANUMERIC</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                New Password :</td>
            <td class="style8">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="Label2" runat="server" ForeColor="Blue"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td class="style18">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Generate password" Width="133px" />
            </td>
            <td class="style8">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Save &amp; Update" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
</p>
<p align="left">
    &nbsp;</p>
<p align="center">
    &nbsp;</p>
</asp:Content>

