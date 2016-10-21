<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changePWD.aspx.cs" Inherits="MZSYCORE.Web.employee.changePWD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <link rel="stylesheet" type="text/css" href="../Css/bootstrap.css" />   
     <link rel="stylesheet" type="text/css" href="../Css/style.css" />
     <style type="text/css">
        body {
            padding-bottom: 40px;
        }

        .sidebar-nav {
            padding: 9px 0;
        }

        @media (max-width: 980px) {
            /* Enable use of floated navbar text */
            .navbar-text.pull-right {
                float: none;
                padding-left: 5px;
                padding-right: 5px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <tr>
                    <td>行员号:</td>
                    <td>
                        <label><%=model_employee_info.employee_id %></label></td>
                </tr>
                <tr>
                    <td>姓名:</td>
                    <td>
                        <label><%=model_employee_info.name %></label></td>
                </tr>
                <tr>
                    <td>新密码：</td>
                    <td>
                        <asp:TextBox ID="tbox_NewPwd" runat="server" TextMode="Password" Wrap="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>再输入一次：</td>
                    <td>
                        <asp:TextBox ID="tbox_NewPwd_repeat" runat="server" TextMode="Password" Wrap="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btn_changepwd" CssClass="btn btn-success" runat="server" Text="修改密码" OnClick="btn_changepwd_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
