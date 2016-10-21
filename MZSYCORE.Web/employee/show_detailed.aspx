<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show_detailed.aspx.cs" Inherits="MZSYCORE.Web.employee.show_detailed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta charset="UTF-8" />
    <link rel="stylesheet" type="text/css" href="../Css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="../Css/bootstrap-responsive.css" />
    <link rel="stylesheet" type="text/css" href="../Css/style.css" />
    <script type="text/javascript" src="../Js/jquery.js"></script>
    <script type="text/javascript" src="../Js/jquery.sorted.js"></script>
    <script type="text/javascript" src="../Js/bootstrap.js"></script>
    <script type="text/javascript" src="../Js/ckform.js"></script>
    <script type="text/javascript" src="../Js/common.js"></script>



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


        .auto-style1 {
            text-align: right;
            padding-left: 5px;
            background-color: #f5f5f5;
            height: 47px;
        }

        .auto-style2 {
            height: 47px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <table class="table table-bordered table-hover definewidth m10">
            <tr>
                <td width="10%" class="tableleft">行员号</td>
                <td>
                    <input type="text" value="<%=model.employee_id %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">姓名</td>
                <td>
                    <input type="text" value="<%=model.name %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">所属部门</td>
                <td>
                    <input type="text" value="<%=model.department %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">柜员号</td>
                <td>
                    <input type="text" value="<%=model.guiyuan_id %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">客户经理号</td>
                <td>
                    <input type="text" value="<%=model.kehujingli_id %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">主要手机号码</td>
                <td>
                    <input type="text" value="<%=model.phone_number_1 %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">主要手机短号</td>
                <td>
                    <input type="text" value="<%=model.short_phone_number_1 %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">次要手机号码</td>
                <td>
                    <input type="text" value="<%=model.phone_number_2 %>" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">次要手机短号</td>
                <td>
                    <input type="text" value="<%=model.short_phone_number_2 %>" /></td>
            </tr>


            <tr>
                <td class="tableleft"></td>
                <td>                    
                    <asp:LinkButton ID="lbtn_back" runat="server" CssClass="btn btn-success" OnClick="lbtn_back_Click" >返回列表</asp:LinkButton>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
