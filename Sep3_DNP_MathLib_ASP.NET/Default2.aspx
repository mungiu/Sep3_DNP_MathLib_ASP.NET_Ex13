<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="Sep3_DNP_MathLib_ASP.NET.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default Page 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">HyperLink</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelApplicationClicks" runat="server" Text="LabelApplicationClicks"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLinkPage1" runat="server" NavigateUrl="~/Default.aspx">HyperLinkPage1</asp:HyperLink>
        <br />
        <asp:Label ID="LabelSessionClicks" runat="server" Text="LabelSessionClicks"></asp:Label>
    </form>
</body>
</html>
