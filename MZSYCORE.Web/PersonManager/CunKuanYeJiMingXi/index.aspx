<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.CunKuanYeJiMingXi.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-hover definewidth m10" >
                <thead>
                    <tr>
                        <th>账号</th>
                        <th>账户名称</th>
                        <th>账户余额</th>
                        <th>开户日期</th>
                        <th>到期日期</th>
                        <th>年利率</th>
                        <th>产品类别</th>                       
                        <th>分配比例</th>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("zhdh") %></td>
                            <td><%#Eval("zhhm") %></td>
                            <td><%#Eval("zhye","{0:f2}") %></td>
                            <td><%#Eval("khrq") %></td>
                            <td><%#Eval("dqrq") %></td>
                            <td><%#Eval("nll","{0:f2}") %></td>
                            <td><%#ChangeChanPinHao(Eval("cph")) %></td>                           
                            <td><%#Eval("zlbl","{0:f2}") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
