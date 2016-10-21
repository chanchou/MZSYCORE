<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.ToubaoJigouCunkuanZhanghuTongjibiao.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
            font-size: large;
        }
        .auto-style2 {
            font-size: large;
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            <span class="auto-style1">当前计算的数据日期为：<asp:Label ID="lblShujuRiqi" runat="server" Text="数据未到达"></asp:Label>，当日存款总余额为：<asp:Label ID="lblCunkuanZonge" runat="server" Text="数据未到达"></asp:Label>
            <br />
            <strong>确认无误后请</strong></span><span class="auto-style2"><strong>点击“计算”按钮</strong></span>
           <asp:Button ID="btnJisuan" runat="server" Text="确认计算" OnClick="btnJisuan_Click" CssClass="btn btn-success" OnClientClick="this.disabled=true" UseSubmitBehavior="False" />
        </div>
        <br />
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <tr>
                    <td></td>
                    <td colspan="2">合计</td>
                    <td colspan="2">金额≤50万元</td>
                    <td colspan="2">金额>50万元</td>
                </tr>
                <tr>
                    <td>项目</td>
                    <td>户数</td>
                    <td>金额</td>
                    <td>户数</td>
                    <td>金额</td>
                    <td>户数</td>
                    <td>金额</td>
                </tr>
                <tr>
                    <td>一、境内存款</td>
                    <td><%=JingneiCunkuanHushu %></td>
                    <td><%=JingneiCunkuanJine %></td>
                    <td><%=JingneiCunkuanHushu50wanyixia %></td>
                    <td><%=JingneiCunkuanJine50wanyixia %></td>
                    <td><%=JingneiCunkuanHushu50wanyishang %></td>
                    <td><%=JingneiCunkuanJine50wanyishang %></td>
                </tr>
                <tr>
                    <td>（一）个人存款</td>
                    <td><%=JingneiGerenCunkuanHushu %></td>
                    <td><%=JingneiGerenCunkuanJine %></td>
                    <td><%=JingneiGerenCunkuanHushu50wanyixia %></td>
                    <td><%=JingneiGerenCunkuanJine50wanyixia %></td>
                    <td><%=JingneiGerenCunkuanHushu50wanyishang %></td>
                    <td><%=JingneiGerenCunkuanJine50wanyishang %></td>
                </tr>
                <tr>
                    <td>（二）单位存款</td>
                    <td><%=JingneiDanweiCunkuanHushu %></td>
                    <td><%=JingneiDanweiCunkuanJine %></td>
                    <td><%=JingneiDanweiCunkuanHushu50wanyixia %></td>
                    <td><%=JingneiDanweiCunkuanJine50wanyixia %></td>
                    <td><%=JingneiDanweiCunkuanHushu50wanyishang %></td>
                    <td><%=JingneiDanweiCunkuanJine50wanyishang %></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;其中：住房公积金存款（默认无）</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;社保基金存款（默认无）</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>（三）财政性存款（默认全部为代理财政性存款）</td>
                    <td><%=JingneiCaizhengxingCunkuanHushu %></td>
                    <td><%=JingneiCaizhengxingCunkuanJine %></td>
                    <td><%=JingneiCaizhengxingCunkuanHushu50wanyixia %></td>
                    <td><%=JingneiCaizhengxingCunkuanJine50wanyixia %></td>
                    <td><%=JingneiCaizhengxingCunkuanHushu50wanyishang %></td>
                    <td><%=JingneiCaizhengxingCunkuanJine50wanyishang %></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1、国库定期存款（默认无）</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2、代理财政性存款</td>
                    <td><%=JingneiCaizhengxingCunkuanHushu %></td>
                    <td><%=JingneiCaizhengxingCunkuanJine %></td>
                    <td><%=JingneiCaizhengxingCunkuanHushu50wanyixia %></td>
                    <td><%=JingneiCaizhengxingCunkuanJine50wanyixia %></td>
                    <td><%=JingneiCaizhengxingCunkuanHushu50wanyishang %></td>
                    <td><%=JingneiCaizhengxingCunkuanJine50wanyishang %></td>
                </tr>
                <tr>
                    <td>（四）非存款类金融机构存款（默认无）</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>二、境外存款（默认无）</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>（一）个人存款</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>（二）单位存款</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>（三）境外同业存放</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>三、高级管理人员在本机构存款</td>
                    <td><%=GaoguanCunkuanHushu %></td>
                    <td><%=GaoguanCunkuanJine %></td>
                    <td><%=GaoguanCunkuanHushu50wanyixia %></td>
                    <td><%=GaoguanCunkuanJine50wanyixia %></td>
                    <td><%=GaoguanCunkuanHushu50wanyishang %></td>
                    <td><%=GaoguanCunkuanJine50wanyishang %></td>
                </tr>
                <tr>
                    <td>附报</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>一、被保险存款</td>
                    <td colspan="6"><%=BeibaoxianCunkuan %></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 其中：受保存款</td>
                    <td colspan="6"><%=ShoubaoCunkuan %></td>
                </tr>
                <tr>
                    <td>二、应交纳保费数额</td>
                    <td colspan="6"></td>
                </tr>

            </table>
        </div>
    <p>
        备注：
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1、在开始计算之前，请确保存款余额核对一致；如不一致，请核验是否存在挂账。如果是因为挂账造成的数据不一致，不影响计算；如果是其他原因，请查明后在计算。&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblJiaoyan" runat="server" Text="校验通过"></asp:Label>
    </p>
    </form>
    </body>
</html>
