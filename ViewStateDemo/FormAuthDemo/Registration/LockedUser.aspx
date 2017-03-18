<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LockedUser.aspx.cs" Inherits="ViewStateDemo.FormAuthDemo.Registration.LockedUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            onrowcommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="User Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="LockedDateTime" 
                    HeaderText="Locked Date &amp; Time" />
                <asp:BoundField DataField="HoursElapsed" HeaderText="Hours Elapsed" />
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="Button1" Enabled='<%#Convert.ToInt32(Eval("HoursElapsed")) > 20 %>'
                           CommandArgument = '<%#Eval("UserName") %>'
                         runat="server" Text="Enable" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
