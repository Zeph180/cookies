<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="cookies.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Welcome:   <span id="usrName" runat="server"></span></p>
            <p>You last visited: <span id="lstVst" runat="server"></span></p>

            <p>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </p>
            <hr />

            <asp:Label Text="Enter your name:" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="nameInput" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </div>
    </form>
</body>
</html>
