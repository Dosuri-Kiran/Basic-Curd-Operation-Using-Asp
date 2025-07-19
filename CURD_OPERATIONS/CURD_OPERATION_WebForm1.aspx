<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CURD_OPERATION_WebForm1.aspx.cs" Inherits="CURD_OPERATIONS.CURD_OPERATION_WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      /*  .auto-style1 {
            width: 40%;
        }
        .auto-style2 {
            height: 26px;
        }*/
      body {
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        background-color: #f4f7f8;
        padding: 50px;
    }

    form {
        background-color: #ffffff;
        padding: 30px 40px;
        border-radius: 10px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        max-width: 500px;
        margin: auto;
    }

    .auto-style1 {
        width: 100%;
        border-collapse: collapse;
    }

    .auto-style1 td {
        padding: 10px 5px;
        vertical-align: middle;
    }

    .auto-style1 td:first-child {
        width: 30%;
        font-weight: 600;
        color: #333;
    }

    .auto-style1 td:last-child {
        width: 70%;
    }

    input[type="text"], input[type="email"], input[type="number"], 
    .aspNetTextBox {
        width: 100%;
        padding: 8px;
        border: 1px solid #ccc;
        border-radius: 6px;
        box-sizing: border-box;
    }

    input:focus {
        outline: none;
        border-color: #5b9bd5;
        box-shadow: 0 0 5px #cce0f5;
    }

    .auto-style1 button, 
    .aspNetButton, 
    input[type="submit"] {
        padding: 8px 16px;
        border: none;
        background-color: #5b9bd5;
        color: white;
        font-weight: 600;
        border-radius: 6px;
        cursor: pointer;
        margin-right: 10px;
    }

    .auto-style1 button:hover,
    .aspNetButton:hover {
        background-color: #407ec9;
    }

    #Label5 {
        display: block;
        margin-top: 20px;
        font-weight: 600;
        color: green;
        text-align: center;
    }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h3> <marquee> FILL THIS FORM </marquee></h3>
             <table class="auto-style1">
     <tr>
         <td><asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
         <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
     </tr>
     <tr>
         <td><asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label></td>
         <td><asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="aspNetTextBox"></asp:TextBox></td>
     </tr>
     <tr>
         <td><asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
         <td><asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox></td>
     </tr>
     <tr>
         <td><asp:Label ID="Label4" runat="server" Text="Phone" ></asp:Label></td>
         <td><asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox></td>
     </tr>
     <tr>
         <td colspan="2">
                             <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" CssClass="aspNetButton" /> &nbsp; &nbsp;
                             <asp:Button ID="Button2" runat="server" Text="View" OnClick="Button2_Click" CssClass="aspNetButton" /> &nbsp;&nbsp;
                             <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" CssClass="aspNetButton"/> &nbsp;&nbsp;
                             <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" CssClass="aspNetButton" /> &nbsp;&nbsp;
                             <asp:Button ID="Button5" runat="server" Text="Clear" OnClick="Button5_Click" CssClass="aspNetButton"  /> &nbsp;&nbsp;

         </td>
         
     </tr>
 </table>
        </div>
        <asp:Label ID="Label5" runat="server"></asp:Label>
    </form>
    
</body>
</html>
