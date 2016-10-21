<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.CunKuanRiJun.index" %>

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
    <h2 style="text-align: center">孟州射阳村镇银行活期存款账户日均计算器</h2>
    <form id="form1" runat="server">
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <tr>
                    <td>账号/卡号：</td>
                    <td>
                        <asp:TextBox ID="tbox_zhanghao" runat="server" Width="451px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>计算期限：</td>
                    <td>
                        <asp:TextBox ID="tbox_day_qian" runat="server"></asp:TextBox>
                        &nbsp;至
                        <asp:TextBox ID="tbox_day_hou" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>客户名称：</td>
                    <td>
                        <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>开户日期：</td>
                    <td>
                        <asp:Label ID="lbl_kaihuriqi" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td>查询期间发生笔数：</td>
                    <td>
                        <asp:Label ID="lbl_yewubishu" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td>期间日均：</td>
                    <td>
                        <asp:Label ID="lbl_rijun" runat="server" Text=""></asp:Label></td>
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
