<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Assignment1Asp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="313px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Price" />
            <br />
            <br />
        </div>
        <asp:Image ID="Image1" runat="server" Height="334px" Width="866px" />
        <br />
        <br />
        Price is :&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="--"></asp:Label>
    </form>
</body>
</html>
