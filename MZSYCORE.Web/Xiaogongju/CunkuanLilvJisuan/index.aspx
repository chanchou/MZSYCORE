<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.Xiaogongju.CunkuanLilvJisuan.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.css" rel="stylesheet" />
    <script src="../../Js/My97DatePicker/WdatePicker.js"></script>
    <script src="../../Js/jquery.js"></script>
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
</head>
<body>
    <h2 style="text-align:center">孟州射阳村镇银行存款利率计算器</h2>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <tr>
                    <td>币种：</td>
                    <td>人民币</td>
                </tr>
                <tr>
                    <td>
                        <label for="amount">存款金额：</label></td>
                    <td>
                        <asp:TextBox ID="tbox_jine" runat="server" Text="10000.00"></asp:TextBox>
                        <span id="unit">元</span></td>
                </tr>
                <tr>
                    <td>
                        <label>储蓄类型：</label></td>
                    <td>
                        <asp:DropDownList ID="ddl_leixing" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_leixing_SelectedIndexChanged">
                            <asp:ListItem Value="0.35">活期</asp:ListItem>
                            <asp:ListItem Value="2.73">整存整取三个月</asp:ListItem>
                            <asp:ListItem Value="2.99">整存整取六个月</asp:ListItem>
                            <asp:ListItem Value="3.25">整存整取一年</asp:ListItem>
                            <asp:ListItem Value="4.03">整存整取两年</asp:ListItem>
                            <asp:ListItem Value="4.875">整存整取三年</asp:ListItem>
                            <asp:ListItem Value="5.225">整存整取五年</asp:ListItem>
                            <asp:ListItem Value="1.04">通知一天</asp:ListItem>
                            <asp:ListItem Value="1.755">通知七天</asp:ListItem>
                            <asp:ListItem Value="0">贷款</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>存款年利率：</td>
                    <td>
                        <asp:TextBox ID="tbox_lilv" runat="server" Text="0.42"></asp:TextBox>%</td>
                </tr>
                <tr>
                    <td>储蓄期限：</td>
                    <td>
                        <asp:TextBox ID="tbox_day_qian" runat="server"></asp:TextBox>
                        &nbsp;至
                        <asp:TextBox ID="tbox_day_hou" runat="server"></asp:TextBox>
                        </td>
                </tr>
                
                <tr>
                    <td>到期本息总额：</td>
                    <td>
                        <asp:TextBox ID="tbox_benxizonge" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                       </td>
                    <td>
                        <asp:Button ID="btn_jisuan"  CssClass="btn btn-success"  runat="server" Text="计算" OnClick="btn_jisuan_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
