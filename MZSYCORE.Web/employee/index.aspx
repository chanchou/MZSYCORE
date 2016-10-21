<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.employee.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
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

    <script>
        $(function () {


            $('#addnew').click(function () {

                window.location.href = "add.html";
            });


        });

        function del(id) {


            if (confirm("确定要删除吗？")) {

                var url = "index.html";

                window.location.href = url;

            }




        }
    </script>

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
    <form runat="server">
        <div class="form-inline definewidth m20">
            用户名称：
    <input type="text" name="username" id="username" class="abc input-default" placeholder="" value="" />&nbsp;&nbsp;  
    <asp:Button ID="btn_Search" CssClass="btn btn-primary" runat="server" Text="查询" OnClick="btn_Search_Click" />&nbsp;&nbsp;
       
        </div>

        <table class="table table-bordered table-hover definewidth m10">
            <thead>
                <tr>
                    <th>行员号</th>
                    <th>姓名</th>
                    <th>部门</th>
                    <th>柜员号</th>
                    <th>客户经理号</th>
                    <th>手机号码</th>
                    <th>手机短号</th>
                    <th>详情</th>
                </tr>
            </thead>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("employee_id") %></td>
                        <td><%#Eval("name") %></td>
                        <td><%#Eval("department") %></td>
                        <td><%#Eval("guiyuan_id") %></td>
                        <td><%#Eval("kehujingli_id") %></td>
                        <td><%#Eval("phone_number_1") %></td>
                        <td><%#Eval("short_phone_number_2") %></td>
                        <td><a href="show_detailed.aspx?employee_id=<%#Eval("employee_id") %>">详情</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div class="inline pull-right page">

            <asp:Label ID="lbl_count" runat="server" Text="lable"></asp:Label>条记录&nbsp;&nbsp;
        <asp:Label ID="lbl_currentIndex" runat="server" Text="Label"></asp:Label>/<asp:Label ID="lbl_pageCount" runat="server" Text="Label"></asp:Label>页&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_firstPage" runat="server" OnClick="lbtn_firstPage_Click">首页</asp:LinkButton>
            &nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_prePage" runat="server" OnClick="lbtn_prePage_Click">上一页</asp:LinkButton>&nbsp;&nbsp;
         <asp:LinkButton ID="lbtn_nextPage" runat="server" OnClick="lbtn_nextPage_Click">下一页</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_lastPage" runat="server" OnClick="lbtn_lastPage_Click">末页</asp:LinkButton>

        </div>
    </form>
</body>
</html>
