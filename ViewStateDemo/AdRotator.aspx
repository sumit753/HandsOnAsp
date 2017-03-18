<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdRotator.aspx.cs" Inherits="ViewStateDemo.AdRotator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <%--keywordfilter is used to show context based ads .--%>
    <asp:AdRotator ID="AdRotator1" runat="server" KeywordFilter="google" AdvertisementFile="~/AdData.xml" 
         />
    </form>
</body>
</html>
