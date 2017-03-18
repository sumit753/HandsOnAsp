<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HandlingMulipleEvents.aspx.cs" Inherits="ViewStateDemo.HandlingMulipleEvents" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div>
    
    </div>
    <asp:Button ID="BtPrint" runat="server" Text="Print" CommandName="Print" OnCommand = "CommandButton_click"/>
    <asp:Button ID="BtDelete" runat="server" Text="Delete"  CommandName="Delete" OnCommand = "CommandButton_click"/>
    <asp:Button ID="BtShowTop10" runat="server" Text="Show Top 10 Employees"  CommandName="Show" OnCommand = "CommandButton_click" CommandArgument="Top10" />
    <asp:Button ID="BtShowBottom10" runat="server" Text="Show Bottom 10 Employees"  CommandName="Show" OnCommand = "CommandButton_click" CommandArgument="Bottom10"/>
    </form>
</body>
</html>
