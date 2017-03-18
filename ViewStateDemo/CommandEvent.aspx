<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommandEvent.aspx.cs" Inherits="ViewStateDemo.WebForm4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    
           <%--  in this we are associating event handler to Event of control using HTML declarative
            <asp:Button ID="Button1" runat="server" Text="Button" 
        onclick="Button1_Click" oncommand="Button1_Command" />--%>

         <asp:Button ID="Button1" runat="server" Text="Button"/>
            
    </form>
</body>
</html>
