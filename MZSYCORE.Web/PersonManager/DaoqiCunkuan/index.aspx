<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.DaoqiCunkuan.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <thead>
                    <tr>
                        <th>存单账号</th>
                        <th>存期</th>
                        <th>开户日期</th>
                        <th>到期日期</th>
                        <th>实际余额</th>
                        <th>客户名称</th>
                        <th>客户经理编号</th>
                    </tr>
                </thead>

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("td_td_acct_no") %></td>
                            <td><%#Eval("td_dep_prd_n") %></td>
                            <td><%#Eval("td_opac_dt") %></td>
                            <td><%#Eval("td_due_dt") %></td>
                            <td><%#Eval("td_actu_amt") %></td>
                            <td><%#Eval("td_cust_name") %></td>
                            <td><%#Eval("td_conntr_no") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
