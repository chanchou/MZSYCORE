<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="MZSYCORE.Web.Xiaogongju.daikuanlilvjisuan.index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" align="center">
        <div>
            <h3>贷款户当期应还利息查询</h3>
            贷款人姓名：<asp:TextBox ID="tbox_daiKuanRenName" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btn_chaxun" CssClass="btn btn-success" runat="server" Text="查询" OnClick="btn_chaxun_Click" />
        </div>
    </form>
    <div>
        <table class="table table-bordered table-hover definewidth m10">
            <thead>
                <th>客户名称</th>                
                <th>还款卡号</th>             
                <th>贷款余额</th>
                <th>当期应还利息</th>
                <th>表内欠息</th>
                <th>表外欠息</th>
                <th>本金罚息</th>
                <th>利息罚息</th>
                <th>合计</th>
            </thead>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>                        
                        <td><%#Eval("CUSTOMERNAME") %></td>
                        <td><%#Eval("")%></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>                      
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

    </div>
</body>
</html>
