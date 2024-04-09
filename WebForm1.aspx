<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            margin-left: 85px;
        }
        .auto-style3 {
            margin-left: 78px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div>
                <div>
        <div class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Autentificare"></asp:Label>
            <br />
        </div>
                    <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" Height="16px" Width="129px">
                    </asp:DropDownList>
&nbsp;<p>
                        <asp:Label ID="Label2" runat="server" Text="Parola"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </p>
                </div>
                <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Autentificare" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Inregistrare" />
        </div>
    </form>
</body>
</html>
