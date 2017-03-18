<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadDemo.aspx.cs" Inherits="ViewStateDemo.FileUploadDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" BorderStyle="Solid" />
        <asp:Button ID="BtUpload" runat="server" onclick="BtUpload_Click" 
            Text="Upload" />
    
    </div>
    <asp:Label ID="LabelOutput" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
