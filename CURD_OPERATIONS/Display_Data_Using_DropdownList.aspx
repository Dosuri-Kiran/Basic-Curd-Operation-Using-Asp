<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display_Data_Using_DropdownList.aspx.cs" Inherits="CURD_OPERATIONS.Display_Data_Using_DropdownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
    <tr>
        <td><asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
        <td><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></td>
    </tr>
    <tr>
        <td><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label></td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
