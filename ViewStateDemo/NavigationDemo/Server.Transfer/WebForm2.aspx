<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ViewStateDemo.NavigationDemo.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
            <td>
                <b>Name</b>
            </td>
            <td>
                :<asp:Label ID="lblName" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email</b>
            </td>
            <td>
                :<asp:Label ID="lblEmail" runat="server">
                </asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
