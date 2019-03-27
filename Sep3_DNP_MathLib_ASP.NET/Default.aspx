<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sep3_DNP_MathLib_ASP.NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DEFAULT PAGE 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxAdd1" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="+" />
            <asp:TextBox ID="TextBoxAdd2" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;=
            <asp:TextBox ID="TextBoxAddResult" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxSub1" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="ButtonSub" runat="server" OnClick="ButtonSub_Click" Text="-" />
            <asp:TextBox ID="TextBoxSub2" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;=
            <asp:TextBox ID="TextBoxSubResult" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxMul1" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="ButtonMul" runat="server" OnClick="ButtonMul_Click" Text="*" />
            <asp:TextBox ID="TextBoxMul2" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;=
            <asp:TextBox ID="TextBoxMulResult" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxDiv1" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="ButtonDiv" runat="server" OnClick="ButtonDiv_Click" Text="/" />
            <asp:TextBox ID="TextBoxDiv2" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;=
            <asp:TextBox ID="TextBoxDivResult" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx">HyperLink</asp:HyperLink>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelApplicationClicks" runat="server" Text="LabelApplicationClicks"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLinkPage2" runat="server" NavigateUrl="~/Default2.aspx">HyperLinkPage2</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="LabelSessionClicks" runat="server" Text="LabelSessionClicks"></asp:Label>
    </form>
</body>
</html>
