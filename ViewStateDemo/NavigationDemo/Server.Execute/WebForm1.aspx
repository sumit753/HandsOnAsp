<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewStateDemo.NavigationDemo.Server.Execute.WebForm1" %>

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
                <asp:Button ID="btnTransfer" runat="server" 
                    Text="Transfer to WebForm2" Width="250px" 
                    OnClick="btnTransfer_Click"/>
            </td>
        </tr>
        </table>
    </div>
    <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
