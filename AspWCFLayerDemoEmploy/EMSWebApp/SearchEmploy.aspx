<%@ Page Title="" Language="C#" MasterPageFile="~/EmployManagementSystem.Master" AutoEventWireup="true" CodeBehind="SearchEmploy.aspx.cs" Inherits="EMSWebApp.SearchEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="6" cellspacing="6" style="width: 100%; border: 3px solid #3399FF">
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Larger" Text="Search Employ Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Emp No:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Name: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Department :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Designation :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Basic :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtbasic" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="blberror" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAdd" runat="server" Text="Search Employ" OnClick="btnAdd_Click" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
