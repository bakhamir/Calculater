﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="display" runat="server" ReadOnly="True"></asp:TextBox><asp:Button ID="Button14" runat="server" Text="=" OnClick="Button14_Click" /></div>
        <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" /><asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" />
        <div><asp:Button ID="Button4" runat="server" Text="4" OnClick="Button4_Click"/><asp:Button ID="Button5" runat="server" Text="5" OnClick="Button5_Click"/><asp:Button ID="Button6" runat="server" Text="6" OnClick="Button6_Click" /></div>
        <div><asp:Button ID="Button7" runat="server" Text="7" OnClick="Button7_Click" /><asp:Button ID="Button8" runat="server" Text="8" OnClick="Button8_Click"/><asp:Button ID="Button9" runat="server" Text="9" OnClick="Button9_Click"/></div>
        <div>
            <asp:Button ID="Button10" runat="server" Text="+" OnClick="Button10_Click" /><asp:Button ID="Button11" runat="server" Text="-" OnClick="Button11_Click" /><asp:Button ID="Button12" runat="server" Text="*" OnClick="Button12_Click" /><asp:Button ID="Button13" runat="server" Text="/" OnClick="Button13_Click" /></div>
</form>
</body>
</html>
