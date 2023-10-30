<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert Your Details:<br />
            <br />
            Name&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            *&nbsp;
            <br />
            <br />
            Family Name&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
            *
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Differ from name"></asp:Label>
            <br />
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            *&nbsp;
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="At least two characters"></asp:Label>
            <br />
            <br />
            City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            *&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Atleast 2 character"></asp:Label>
            <br />
            <br />
            Zipcode&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            *&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="(XXXXXX)"></asp:Label>
            <br />
            <br />
            Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            *&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="(xx-xxxx / xxxx)"></asp:Label>
            <br />
            <br />
            E-mali&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            *&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="test@gmail.com"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Check" />
        </div>
    </form>
</body>
</html>
