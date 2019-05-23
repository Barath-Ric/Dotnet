<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="UpdateBook.aspx.cs" Inherits="BMSWebApp.UpdateBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="6" cellspacing="6" class="auto-style1">
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Update Book Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Book ID:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBookID" runat="server" Height="24px" Width="93px"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Name :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Price :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesciption" runat="server" Height="56px" Width="144px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblerror" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnUpdateBook" runat="server" Text="Update Book" OnClick="btnUpdateBook_Click" />
            &nbsp;</td>
        </tr>
    </table>
</asp:Content>
