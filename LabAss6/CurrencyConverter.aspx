<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="LabAss6.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Convert："></asp:Label>
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Chinese Yuan to Dollars"></asp:Label>
            <br />
        </div>
        <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="OK" Width="88px" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
