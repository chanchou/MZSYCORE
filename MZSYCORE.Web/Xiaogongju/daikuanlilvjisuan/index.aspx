<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.Xiaogongju.daikuanlilvjisuan.index" %>

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
    <h2 style="text-align: center">孟州射阳村镇银行贷款利率计算器</h2>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <tr>
                    <td>币种：</td>
                    <td>人民币</td>
                </tr>
                <tr>
                    <td>
                        <label for="amount">贷款金额：</label></td>
                    <td>
                        <asp:TextBox ID="tbox_jine" runat="server" Text="10000.00"></asp:TextBox>
                        <span id="unit">元</span></td>
                </tr>
                <tr>
                    <td>
                        <label>贷款类型：</label></td>
                    <td>
                        <asp:DropDownList ID="ddl_leixing" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_leixing_SelectedIndexChanged">
                            <asp:ListItem Value="5.6004">半年期存单质押</asp:ListItem>
                            <asp:ListItem Value="6">一年期存单质押</asp:ListItem>
                            <asp:ListItem Value="9">财政贴息贷款</asp:ListItem>
                            <asp:ListItem Value="9.804">半年期小额农贷</asp:ListItem>
                            <asp:ListItem Value="10.5">一年期小额农贷</asp:ListItem>
                            <asp:ListItem Value="10.608">仓单质押</asp:ListItem>
                            <asp:ListItem Value="10.944">大额四户联保</asp:ListItem>
                            <asp:ListItem Value="11.196">担保公司担保</asp:ListItem>
                            <asp:ListItem Value="11.484">一年期房产抵押</asp:ListItem>
                            <asp:ListItem Value="11.628">二年期房产抵押</asp:ListItem>
                            <asp:ListItem Value="11.808">应收账款质押</asp:ListItem>
                            <asp:ListItem Value="12.204">半年期担保</asp:ListItem>
                            <asp:ListItem Value="13.176">一年期担保</asp:ListItem>
                            <asp:ListItem Value="0">其他利率</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>贷款年利率：</td>
                    <td>
                        <asp:TextBox ID="tbox_lilv" runat="server" Text="0.42"></asp:TextBox>%</td>
                </tr>
                <tr>
                    <td>贷款期限：</td>
                    <td>
                        <asp:TextBox ID="tbox_day_qian" runat="server"></asp:TextBox>
                        &nbsp;至
                        <asp:TextBox ID="tbox_day_hou" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>应还利息：</td>
                    <td>
                        <asp:TextBox ID="tbox_lixi" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btn_jisuan" CssClass="btn btn-success" runat="server" Text="计算" OnClick="btn_jisuan_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
