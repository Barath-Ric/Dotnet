<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBook.aspx.cs" Inherits="BookWebAPIClient.ShowBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function getBooks()
        {
            $.getJSON("http://localhost:58752/api/Books",
                function (data) {
                    $('#books').empty();
                    $.each(data, function (key, val) {
                        var row = '<tr><td>' + val.ID + '</td><td>' + val.Name + '</td><td>' + val.Price + '</td><td>' + val.Description + '</td></tr>';
                        // $('<tr/>', { text: row }).appendTo($('#books'));
                        $('#books').append(row);
                    });
                });                
        }
        $(document).ready(getBooks);
    </script>
    <title></title>
</head>
<body>
    
        <div>
            <table class="table">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Description</th>
                        </tr>
                    </thead>
                <tbody id="books">
                    </tbody>
                </table>
        </div>
  
</body>
</html>
