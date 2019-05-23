<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="BMSWebApp.DeleteBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="3" cellspacing="3" class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Delete Book Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="BookID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBookId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete Book" />
            </td>
        </tr>
    </table>
</asp:Content>
