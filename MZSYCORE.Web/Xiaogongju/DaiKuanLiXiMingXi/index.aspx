<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.Xiaogongju.DaiKuanLiXiMingXi.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Js/jquery.js"></script>
    <script src="../../Js/My97DatePicker/WdatePicker.js"></script>   
</head>
<body>
    <form id="form1" runat="server" align="center">
        <h3>贷款应还利息明细查询</h3>
        <div>
            &nbsp;&nbsp;&nbsp;
            贷款金额：<asp:TextBox ID="tbox_daiKuanJinE" runat="server" Width="106px"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            年利率：<asp:TextBox ID="tbox_daiKuanLiLv" runat="server" Width="78px"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            计息周期：<asp:TextBox ID="tbox_day_qian" runat="server" Width="108px"></asp:TextBox>
            &nbsp;至
                        <asp:TextBox ID="tbox_day_hou" runat="server" Width="124px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_jisuan" CssClass="btn btn-success" runat="server" Text="计算" OnClick="btn_jisuan_Click" />
        </div>
        <script type="text/ecmascript">
            $(function () {
                $("#tbox_day_qian").attr("onfocus", "");
                $("#tbox_day_qian").focus(function () {
                    var tbox_day_hou = $dp.$("tbox_day_hou");
                    WdatePicker({ onpicked: function () { tbox_day_hou.focus(); }, maxDate: "#F{$dp.$D('tbox_day_hou')}" })

                });
                $("#tbox_day_hou").focus(function () {
                    WdatePicker({ minDate: "#F{$dp.$D('tbox_day_qian')}" });
                });
            });
        </script>
    </form>
    <div>
        <table class="table table-bordered table-hover definewidth m10">
            <thead>
                <th>期数</th>
                <th>还款日</th>
                <th>计息天数</th>
                <th>还款金额</th>
            </thead>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("key").ToString().Split(':')[0] %></td>
                        <td><%#Eval("key").ToString().Split(':')[1] %></td>
                        <td><%#Eval("key").ToString().Split(':')[2] %></td>
                        <td><%#Eval("value","{0:f2}") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>

</body>
</html>

