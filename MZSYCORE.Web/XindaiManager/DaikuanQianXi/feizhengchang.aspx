<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feizhengchang.aspx.cs" Inherits="MZSYCORE.Web.XindaiManager.DaikuanQianXi.feizhengchang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
                    <th>客户经理</th>
                   
                    <th>客户姓名</th>
                    <th>发放日</th>
                    <th>到期日</th>
                    <th>贷款总额</th>
                    <th>贷款余额</th>
                    <th>逾期余额</th>
                    <th>呆滞余额</th>
                    <th>呆账余额</th>
                    <th>所属机构</th>
                </tr>
            </thead>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#FindName(Eval("MANAGEUSERID")) %></td>
                       
                        <td><%#Eval("CUSTOMERNAME") %></td>
                        <td><%#Eval("PUTOUTDATE") %></td>
                        <td><%#Eval("MATURITY") %></td>
                        <td><%#Eval("BUSINESSSUM","{0:f2}") %></td>
                        <td><%#Eval("BALANCE","{0:f2}") %></td>
                        <td><%#Eval("OVERDUEBALANCE","{0:f2}") %></td>
                        <td><%#Eval("DULLBALANCE","{0:f2}") %></td>
                        <td><%#Eval("BADBALANCE","{0:f2}") %></td>
                        <td><%#Bind_Depart(Eval("MANAGEORGID")) %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    <tr>
                        <td>合计：</td>
                        <td><%#GetCount("CUSTOMERNAME") %>户</td>
                        
                        <td></td>
                        <td></td>
                        <td><%#GetSum("BUSINESSSUM").ToString("f2") %></td>
                        <td><%#GetSum("BALANCE").ToString("f2") %></td>
                        <td><%#GetSum("OVERDUEBALANCE").ToString("f2") %></td>
                        <td><%#GetSum("DULLBALANCE").ToString("f2") %></td>
                        <td><%#GetSum("BADBALANCE").ToString("f2") %></td>
                        <td></td>
                    </tr>
                </FooterTemplate>

            </asp:Repeater>



        </table>
    </form>
</body>
</html>
