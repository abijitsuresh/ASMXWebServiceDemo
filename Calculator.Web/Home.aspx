<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Calculator.Web.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="First Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="FirstNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Second Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="SecondNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click" />
                &nbsp;<asp:Button ID="SubtractButton" runat="server" Text="Subtract" OnClick="SubtractButton_Click" />
&nbsp;<asp:Button ID="MultiplyButton" runat="server" Text="Multiply" OnClick="MultiplyButton_Click" />
&nbsp;<asp:Button ID="DivideButton" runat="server" Text="Divide" OnClick="DivideButton_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Result: "></asp:Label>
                </td>
                <td>
                    <asp:Label ID="ResultLabel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
