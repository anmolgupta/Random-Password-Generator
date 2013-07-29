<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 100%;
        }
        .style8
        {
            width: 488px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <table class="style7">
        <tr>
            <td class="style8">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Timer ID="Timer1" runat="server" Interval="10000" ontick="Timer1_Tick">
                </asp:Timer>
                <asp:Image ID="Image1" runat="server" Height="278px" Width="483px" 
                    ImageUrl="~/images/rand.jpg" />
            </td>
            <td>
    <p style="font-size: x-large; color: #3333CC; font-style: italic; font-family: 'Bookman Old Style'">
        Random Password Generator is used to generate random password for a user which 
        is more secure and can&#39;t be guessed easily.This application, here, is used to 
        generate a password which can be alphabetic, numeric, or alphanumeric having a 
        length between 8-14. The password can be updated later to increase the security 
        of the password and user&#39;s account detail. This way a password is generated 
        which is a more secure one and no one can make guesses of it.</p>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

