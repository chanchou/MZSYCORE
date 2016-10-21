<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.XindaiManager.DaikuanQianXi.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table class="table table-bordered table-hover definewidth m10">
            <thead>
                <tr>
                    <th>所属机构</th>
                    <th>客户经理</th>
                    <th>客户姓名</th>
                    <th>贷款金额</th>
                    <th>贷款余额</th>
                    <th>表内欠息</th>
                    <th>表外欠息</th>
                    <th>本金罚息</th>
                    <th>利息罚息</th>
                    <th>到期日期</th>
                </tr>
            </thead>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                         <td><%#BindJiGou(Eval("MANAGEORGID")) %></td>
                        <td><%#FindName(Eval("MANAGEUSERID")) %></td>
                        <td><%#Eval("CUSTOMERNAME") %></td>
                        <td><%#Eval("BUSINESSSUM","{0:f2}") %></td>
                        <td><%#Eval("BALANCE","{0:f2}") %></td>
                        <td><%#Eval("INTERESTBALANCE1","{0:f2}") %></td>
                        <td><%#Eval("INTERESTBALANCE2","{0:f2}") %></td>
                        <td><%#Eval("FINEBALANCE1","{0:f2}") %></td>
                        <td><%#Eval("FINEBALANCE2","{0:f2}") %></td>
                        <td><%#Eval("MATURITY") %></td>
                        
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    <tr>
                        <td>合计</td>
                        <td></td>
                        <td><%#GetCount("CUSTOMERNAME") %>户</td>
                        <td><%#GetSum("BUSINESSSUM").ToString("f2") %></td>
                        <td><%#GetSum("BALANCE").ToString("f2") %></td>
                        <td><%#GetSum("INTERESTBALANCE1").ToString("f2") %></td>
                        <td><%#GetSum("INTERESTBALANCE2").ToString("f2") %></td>
                        <td><%#GetSum("FINEBALANCE1").ToString("f2") %></td>
                        <td><%#GetSum("FINEBALANCE2").ToString("f2") %></td>
                        <td></td>
                    </tr>
                </FooterTemplate>

            </asp:Repeater>



        </table>
    </form>
</body>
</html>
