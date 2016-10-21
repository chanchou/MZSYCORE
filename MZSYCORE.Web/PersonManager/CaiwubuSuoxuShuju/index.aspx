<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.CaiwubuSuoxuShuju.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />
   
    <script src="../../Js/My97DatePicker/WdatePicker.js"></script>
     <script src="../../Js/jquery.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#tbox_Date").focus(function () {
                WdatePicker({ skin: 'whyGreen', maxDate: '%y-%M-%d' });
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div align="center">
                <h2>财务部所需数据查询</h2>
                <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4>
            </div>
            <div>查询日期：<asp:TextBox ID="tbox_Date" runat="server"></asp:TextBox><asp:Button ID="btn_Jisuan" CssClass="btn btn-success" runat="server" Text="查询" OnClick="btn_Jisuan_Click" OnClientClick="this.disabled=true" UseSubmitBehavior="False" /></div>
            <br />
            <b>各单位存贷款情况表：</b>
            <table class="table table-bordered table-hover definewidth m10">
                <thead>
                    <th>单位</th>
                    <th>存款余额</th>
                    <th>存款月日均</th>
                    <th>存款年日均</th>
                    <th>储蓄存款月日均</th>
                    <th>对公存款月日均</th>
                    <th>贷款余额</th>
                    <th>贷款月日均</th>
                    <th>贷款年日均</th>
                </thead>
                <tbody>
                    <tr>
                        <td>孟州营业部</td>
                        <td><%=dic["cunkuanZongyue_Shidian_yyb"] %></td>
                        <td><%=dic["cunkuanZongyue_Yuerijun_yyb"] %></td>
                        <td><%=dic["cunkuanZongyue_Nianrijun_yyb"] %></td>
                        <td><%=dic["chuxuncunkuan_Yuerijun_yyb"] %></td>
                        <td><%=dic["danweicunkuan_Yuerijun_yyb"] %></td>
                        <td><%=dic["daikuanZongyue_Shidian_yyb"] %></td>
                        <td><%=dic["daikuanZongyue_Yuerijun_yyb"] %></td>
                        <td><%=dic["daikuanZongyue_Nianrijun_yyb"] %></td>
                    </tr>
                    <tr>
                        <td>孟州西虢支行</td>
                        <td><%=dic["cunkuanZongyue_Shidian_xgzh"] %></td>
                        <td><%=dic["cunkuanZongyue_Yuerijun_xgzh"] %></td>
                        <td><%=dic["cunkuanZongyue_Nianrijun_xgzh"] %></td>
                        <td><%=dic["chuxuncunkuan_Yuerijun_xgzh"] %></td>
                        <td><%=dic["danweicunkuan_Yuerijun_xgzh"] %></td>
                        <td><%=dic["daikuanZongyue_Shidian_xgzh"] %></td>
                        <td><%=dic["daikuanZongyue_Yuerijun_xgzh"] %></td>
                        <td><%=dic["daikuanZongyue_Nianrijun_xgzh"] %></td>
                    </tr>
                    <tr>
                        <td>孟州化工支行</td>
                        <td><%=dic["cunkuanZongyue_Shidian_hgzh"] %></td>
                        <td><%=dic["cunkuanZongyue_Yuerijun_hgzh"] %></td>
                        <td><%=dic["cunkuanZongyue_Nianrijun_hgzh"] %></td>
                        <td><%=dic["chuxuncunkuan_Yuerijun_hgzh"] %></td>
                        <td><%=dic["danweicunkuan_Yuerijun_hgzh"] %></td>
                        <td><%=dic["daikuanZongyue_Shidian_hgzh"] %></td>
                        <td><%=dic["daikuanZongyue_Yuerijun_hgzh"] %></td>
                        <td><%=dic["daikuanZongyue_Nianrijun_hgzh"] %></td>
                    </tr>
                    <tr>
                        <td>孟州南庄支行</td>
                        <td><%=dic["cunkuanZongyue_Shidian_nzzh"] %></td>
                        <td><%=dic["cunkuanZongyue_Yuerijun_nzzh"] %></td>
                        <td><%=dic["cunkuanZongyue_Nianrijun_nzzh"] %></td>
                        <td><%=dic["chuxuncunkuan_Yuerijun_nzzh"] %></td>
                        <td><%=dic["danweicunkuan_Yuerijun_nzzh"] %></td>
                        <td><%=dic["daikuanZongyue_Shidian_nzzh"] %></td>
                        <td><%=dic["daikuanZongyue_Yuerijun_nzzh"] %></td>
                        <td><%=dic["daikuanZongyue_Nianrijun_nzzh"] %></td>
                    </tr>
                    <tr>
                        <td>合计：</td>
                        <td><%=dic["cunkuanZongyue_Shidian_mzsyczyh"] %></td>
                        <td><%=dic["cunkuanZongyue_Yuerijun_mzsyczyh"] %></td>
                        <td><%=dic["cunkuanZongyue_Nianrijun_mzsyczyh"] %></td>
                        <td><%=dic["chuxuncunkuan_Yuerijun_mzsyczyh"] %></td>
                         <td><%=dic["danweicunkuan_Yuerijun_mzsyczyh"] %></td>
                        <td><%=dic["daikuanZongyue_Shidian_mzsyczyh"] %></td>
                        <td><%=dic["daikuanZongyue_Yuerijun_mzsyczyh"] %></td>
                        <td><%=dic["daikuanZongyue_Nianrijun_mzsyczyh"] %></td>
                    </tr>
                </tbody>
            </table>
            <br />
            <br />
            <b>各单位户数统计情况表：</b>
            <table class="table table-bordered table-hover definewidth m10">
                <thead>
                    <th>单位</th>
                    <th>个人网银开户</th>
                    <th>企业网银开户</th>
                    <th>手机银行开户</th>
                    <th>银行卡户数</th>
                    <th>未结清的贷款户数（仅显示最新）</th>
                    <th>本季度累放贷款（仅显示最新）</th>

                </thead>
                <tbody>
                    <tr>
                        <td>孟州营业部</td>
                        <td><%=dic["grwy_yyb"] %></td>
                        <td><%=dic["qywy_yyb"] %></td>
                        <td><%=dic["sjyh_yyb"] %></td>
                        <td><%=dic["yhkhs_yyb"] %></td>
                        <td><%=dic["dkhs_yyb"] %></td>
                         <td><%=dic["bjdlfdk_yyb"] %></td>
                    </tr>
                    <tr>
                        <td>孟州西虢支行</td>
                        <td><%=dic["grwy_xgzh"] %></td>
                        <td><%=dic["qywy_xgzh"] %></td>
                        <td><%=dic["sjyh_xgzh"] %></td>
                        <td><%=dic["yhkhs_xgzh"] %></td>
                        <td><%=dic["dkhs_xgzh"] %></td>
                         <td><%=dic["bjdlfdk_xgzh"] %></td>
                    </tr>
                    <tr>
                        <td>孟州化工支行</td>
                        <td><%=dic["grwy_hgzh"] %></td>
                        <td><%=dic["qywy_hgzh"] %></td>
                        <td><%=dic["sjyh_hgzh"] %></td>
                        <td><%=dic["yhkhs_hgzh"] %></td>
                        <td><%=dic["dkhs_hgzh"] %></td>
                         <td><%=dic["bjdlfdk_hgzh"] %></td>
                    </tr>
                    <tr>
                        <td>孟州南庄支行</td>
                        <td><%=dic["grwy_nzzh"] %></td>
                        <td><%=dic["qywy_nzzh"] %></td>
                        <td><%=dic["sjyh_nzzh"] %></td>
                        <td><%=dic["yhkhs_nzzh"] %></td>
                        <td><%=dic["dkhs_nzzh"] %></td>
                         <td><%=dic["bjdlfdk_nzzh"] %></td>
                    </tr>
                    <tr>
                        <td>合计：</td>
                        <td><%=dic["grwy_mzsyczyh"] %></td>
                        <td><%=dic["qywy_mzsyczyh"] %></td>
                        <td><%=dic["sjyh_mzsyczyh"] %></td>
                        <td><%=dic["yhkhs_mzsyczyh"] %></td>
                        <td><%=dic["dkhs_mzsyczyh"] %></td>
                         <td><%=dic["bjdlfdk_mzsyczyh"] %></td>

                    </tr>
                </tbody>
            </table>
            <br />
            <br />
            <b>总行其他指标：</b>
            <table class="table table-bordered table-hover definewidth m10">
                <thead>
                    <th>单位</th>
                    <th>下月到期的定期存款</th>
                    <th>信息员存款</th>
                </thead>
                <tbody>
                    <tr>
                        <td>孟州射阳村镇银行</td>
                        <td><%=dic["ygyndqdc_mzsyczyh"] %></td>
                        <td><%=dic["xxyck_mzsyczyh"] %></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <br />
        <br />
    </form>
</body>
</html>
