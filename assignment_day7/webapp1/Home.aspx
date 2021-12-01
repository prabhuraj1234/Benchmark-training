<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="violet">
    <form id="form1" runat="server">
        <div>
<asp:Label runat="server" Text="Login Form"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblLogin" runat="server" Text="Login Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblerr" runat="server" Text=""></asp:Label></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblerrPass" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /> </td>
                    <td colspan="2">
                        <asp:Label ID="Lblerr2" runat="server" Text=""></asp:Label>
                        </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>

