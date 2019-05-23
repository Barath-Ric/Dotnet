<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchEmploy.aspx.cs" Inherits="EmployWebAPIClient.SearchEmploy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function searchEmploy()
        {
            $.getJSON("http://localhost:59853/api/emps/" 
                + $("#<%=txtEmpno.ClientID%>").val(),
                function (data) {
                    
                    $("#<%=txtName.ClientID%>").val(data.nam);
                    $("#<%=txtDept.ClientID%>").val(data.dept);
                    $("#<%=txtDesig.ClientID%>").val(data.desig);
                     $("#<%=txtBasic.ClientID%>").val(data.basic);
                });

            //return false;
        }
        $(document).ready(function () {
            $("#btnSearch").click(searchEmploy);
        })
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Empno"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
            <input id="btnSearch" type="button" value="Search" /><br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Dept"></asp:Label>
            <br />
            <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Desig"></asp:Label>
            <br />
            <asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Basic"></asp:Label>
            <br />
            <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
