<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="lab8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            margin-left: 28px;
        }
        .auto-style3 {
            margin-left: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Inregeistrare<br />
            <br />
            Utilizator<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
            <br />
            Parola<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Inregistrare" />
        </p>
    </form>
</body>
</html>
