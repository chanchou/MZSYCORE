<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MZSYCORE.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Js/jquery.js"></script>
   

</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <h1>系统登录</h1>
            <table>
                <tr>
                    <td>行员号：</td>
                    <td>
                        <asp:TextBox ID="tbox_employee_id" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>密&nbsp;码：</td>
                    <td>
                        <asp:TextBox ID="tbox_loginpwd" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                     <%--   <input type="checkbox" name="remberme" />记住我--%></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn_login" runat="server" Text="登录" OnClick="btn_login_Click" /></td>
                </tr>
            </table>
        </div>
        <div>登录界面太丑了，谁能给我们做个图啊？</div>
    </form>
</body>
</html>
