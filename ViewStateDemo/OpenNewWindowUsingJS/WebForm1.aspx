<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewStateDemo.OpenNewWindowUsingJS.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function openNewWindow() {
            var name = document.getElementById('txtName').value;
            var email = document.getElementById('txtEmail').value;

            window.open('WebForm2.aspx?Name=' + name + '&Email=' + email, "Login", 'location=no,resizable=no,scrollbars=no,toolbar=no');
        } 
    </script>
    <title></title>
    <style type="text/css">
        #Button1
        {
            margin-top: 0px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div>
       <table>
        <tr>
            <td colspan="2">
                <h1>
                    This is WebForm1</h1>
            </td>
        </tr>
        <tr>
            <td>
                <b>Name</b>
            </td>
            <td>
                :<asp:TextBox ID="txtName" runat="server">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email</b>
            </td>
            <td>
                :<asp:TextBox ID="txtEmail" runat="server" 
                    >
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                
                <input id="Button1" type="button" value="Open New Window" onclick="openNewWindow()" /></td>
        </tr>
    </div>
    </form>
    </div>
    <p>
        &nbsp;</p>
</body>
</html>
