<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEmploy.aspx.cs" Inherits="EmployWebAPIClient.ShowEmploy" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function getEmploys()
        {
            $.getJSON("http://localhost:59853/api/emps",
                function (data) {
                    $('#employs').empty();
                    $.each(data, function (key, val) {
                        var row = '<tr><td>' + val.Empno + '</td><td>' + val.nam + '</td><td>' + val.dept + '</td><td>' + val.desig + '</td><td>' + val.basic + '</td></tr>';
                        // $('<tr/>', { text: row }).appendTo($('#books'));
                        $('#employs').append(row);
                    });
                });                
        }
        $(document).ready(getEmploys);
    </script>
    <title></title>
</head>
<body>

        <div>
            <table class="table">
                <thead>
                    <tr>
                        <th>Empno</th>
                        <th>Name</th>
                        <th>Dept</th>
                        <th>Desig</th>
                        <th>Basic</th>
                        </tr>
                    </thead>
                <tbody id="employs">
                    </tbody>
                </table>
        </div>

</body>
</html>
