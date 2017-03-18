<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CascadingDrpDwnList.aspx.cs" Inherits="ViewStateDemo.CascadingDropDownlist.CascadingDrpDwnList" %>

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
              <asp:DropDownList ID="DdlContinents" runat="server" Width="200px" 
                    DataTextField="ContinentName" DataValueField="ContinentId" AutoPostBack="true" 
                    onselectedindexchanged="DdlContinents_SelectedIndexChanged">
              </asp:DropDownList>
             </td>
     </tr>
     <tr>
            <td>
              <asp:DropDownList ID="DdlCountry" runat="server" Width="200px" 
                    DataTextField="countryName" DataValueField="countryId" AutoPostBack="true" 
                    onselectedindexchanged="DdlCountry_SelectedIndexChanged1">
              </asp:DropDownList>
             </td>
     </tr>
     <tr>
            <td>
              <asp:DropDownList ID="DdlCity" runat="server" Width="200px" 
                    DataTextField="cityName" DataValueField="cityID" 
                   >
              </asp:DropDownList>
             </td>
     </tr>
     </table>
    </div>
    </form>
   
           
</body>
</html>
