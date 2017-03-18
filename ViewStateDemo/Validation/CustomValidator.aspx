<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidator.aspx.cs" Inherits="ViewStateDemo.Validation.CustomValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language=javascript>
        function isEven(source, args) { 
        if(args.Value == " ")
        {
            args.IsValid = false;
        }
        else{
            if(args.Value % 2 == 0 )
            {
               args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        } 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table>
    <tr>
        <td>
            <b>Please Enter a Postive Even number </b>
        </td>
        <td>
            :<asp:TextBox ID="txtNum" runat="server" Width="150px">
            </asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtNum" ClientValidationFunction="isEven" ErrorMessage="Enter Positive Integer" 
                onservervalidate="CustomValidator1_ServerValidate" 
                ValidateEmptyText="True"></asp:CustomValidator>
           
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSave" runat="server" Text="Save" Width="100px" 
                onclick="btnSave_Click"/>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblStatus" runat="server" Font-Bold="true">
            </asp:Label>
        </td>
    </tr>
</table>
    </div>
    </form>
</body>
</html>
