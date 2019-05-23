<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="BookWebAPIClient.SearchBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function searchBook()
        {
            $.getJSON("http://localhost:58752/api/Books/" 
                + $("#<%=txtBookId.ClientID%>").val(),
                function (data) {
                    
                    $("#<%=txtBookName.ClientID%>").val(data.Name);
                    $("#<%=txtPrice.ClientID%>").val(data.Price);
                    $("#<%=txtDescription.ClientID%>").val(data.Description)
                });

            //return false;
        }
        $(document).ready(function () {
            $("#btnSearch").click(searchBook);
        })
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblBookId" runat="server" Text="BookID"></asp:Label>
        <div>
            <asp:TextBox ID="txtBookId" runat="server"></asp:TextBox>
            <input id="btnSearch" type="button" value="Search" /><br />
            <br />
            <asp:Label ID="lblBookName" runat="server" Text="Book Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <br />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
