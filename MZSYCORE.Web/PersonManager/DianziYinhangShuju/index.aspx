<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.DianziYinhangShuju.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div align="center">
                <h1>电子银行相关数据查询</h1>
            </div>
            <br />
            <br />
            <div>
                查询日期（如不能选择，手工输入格式为‘2016-08-01’）：<asp:TextBox ID="tbox_DateQian" runat="server"></asp:TextBox>&nbsp;&nbsp;至&nbsp;&nbsp;<asp:TextBox ID="tbox_DateHou" runat="server"></asp:TextBox><asp:Button ID="btn_Jisuan" runat="server" Text="计算查询" CssClass="btn btn-success" OnClientClick="this.disabled=true" UseSubmitBehavior="False" OnClick="btn_Jisuan_Click" />
            </div>
            <br />
            <br />
            <div>
                <b>各单位电子银行户数情况统计表：</b>
                <table class="table table-bordered table-hover definewidth m10">
                    <thead>
                        <th>单位</th>
                        <th>个人网银开户</th>
                        <th>企业网银开户</th>
                        <th>手机银行开户</th>
                        <th>银行卡户数</th>
                        <th>银行卡有效户数（仅显示最新结果）</th>
                    </thead>
                    <tbody>
                        <tr>
                            <td>孟州营业部</td>
                            <td><%=dic["grwyhs_yyb"] %></td>
                            <td><%=dic["qywyhs_yyb"] %></td>
                            <td><%=dic["sjyhhs_yyb"] %></td>
                            <td><%=dic["yhkhs_yyb"] %></td>
                            <td><%=dic["yhkyxhhs_yyb"] %></td>

                        </tr>
                        <tr>
                            <td>孟州西虢支行</td>
                            <td><%=dic["grwyhs_xgzh"] %></td>
                            <td><%=dic["qywyhs_xgzh"] %></td>
                            <td><%=dic["sjyhhs_xgzh"] %></td>
                            <td><%=dic["yhkhs_xgzh"] %></td>
                            <td><%=dic["yhkyxhhs_xgzh"] %></td>

                        </tr>
                        <tr>
                            <td>孟州化工支行</td>
                            <td><%=dic["grwyhs_hgzh"] %></td>
                            <td><%=dic["qywyhs_hgzh"] %></td>
                            <td><%=dic["sjyhhs_hgzh"] %></td>
                            <td><%=dic["yhkhs_hgzh"] %></td>
                            <td><%=dic["yhkyxhhs_hgzh"] %></td>

                        </tr>
                        <tr>
                            <td>孟州南庄支行</td>
                            <td><%=dic["grwyhs_nzzh"] %></td>
                            <td><%=dic["qywyhs_nzzh"] %></td>
                            <td><%=dic["sjyhhs_nzzh"] %></td>
                            <td><%=dic["yhkhs_nzzh"] %></td>
                            <td><%=dic["yhkyxhhs_nzzh"] %></td>

                        </tr>
                        <tr>
                            <td>合计：</td>
                            <td><%=dic["grwyhs_mzsyczyh"] %></td>
                            <td><%=dic["qywyhs_mzsyczyh"] %></td>
                            <td><%=dic["sjyhhs_mzsyczyh"] %></td>
                            <td><%=dic["yhkhs_mzsyczyh"] %></td>
                            <td><%=dic["yhkyxhhs_mzsyczyh"] %></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <br />
            <br />
            <div>
                <b>各单位个人网银交易情况统计表：</b>
                <table class="table table-bordered table-hover definewidth m10">
                    <thead>
                        <tr>
                            <th>单位</th>
                            <th>交易笔数</th>
                            <th>交易金额数</th>
                            <th>交易账户数</th>
                            <th>交易账号占比</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>孟州营业部</td>
                            <td><%=dic["grwyjybs_yyb"] %></td>
                            <td><%=dic["grwyjyje_yyb"] %></td>
                            <td><%=dic["grwyjyzhs_yyb"] %></td>
                            <td><%=dic["grwyjyzhzb_yyb"] %></td>
                        </tr>
                        <tr>
                            <td>孟州西虢支行</td>
                            <td><%=dic["grwyjybs_xgzh"] %></td>
                            <td><%=dic["grwyjyje_xgzh"] %></td>
                            <td><%=dic["grwyjyzhs_xgzh"] %></td>
                            <td><%=dic["grwyjyzhzb_xgzh"] %></td>
                        </tr>
                        <tr>
                            <td>孟州化工支行</td>
                            <td><%=dic["grwyjybs_hgzh"] %></td>
                            <td><%=dic["grwyjyje_hgzh"] %></td>
                            <td><%=dic["grwyjyzhs_hgzh"] %></td>
                            <td><%=dic["grwyjyzhzb_hgzh"] %></td>
                        </tr>
                        <tr>
                            <td>孟州南庄支行</td>
                            <td><%=dic["grwyjybs_nzzh"] %></td>
                            <td><%=dic["grwyjyje_nzzh"] %></td>
                            <td><%=dic["grwyjyzhs_nzzh"] %></td>
                            <td><%=dic["grwyjyzhzb_nzzh"] %></td>
                        </tr>
                        <tr>
                            <td>合计</td>
                            <td><%=dic["grwyjybs_mzsyczyh"] %></td>
                            <td><%=dic["grwyjyje_mzsyczyh"] %></td>
                            <td><%=dic["grwyjyzhs_mzsyczyh"] %></td>
                            <td><%=dic["grwyjyzhzb_mzsyczyh"] %></td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <br />
            <br />
            <div>
                <b>各单位企业网银交易情况统计表：</b>
                <table class="table table-bordered table-hover definewidth m10">
                    <thead>
                        <tr>
                            <th>单位</th>
                            <th>交易笔数</th>
                            <th>交易金额数</th>
                            <th>交易账户数</th>
                            <th>交易账号占比</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>孟州营业部</td>
                            <td><%=dic["qywyjybs_yyb"] %></td>
                            <td><%=dic["qywyjyje_yyb"] %></td>
                            <td><%=dic["qywyjyzhs_yyb"] %></td>
                            <td><%=dic["qywyjyzhzb_yyb"] %></td>
                        </tr>
                        <tr>
                            <td>孟州西虢支行</td>
                            <td><%=dic["qywyjybs_xgzh"] %></td>
                            <td><%=dic["qywyjyje_xgzh"] %></td>
                            <td><%=dic["qywyjyzhs_xgzh"] %></td>
                            <td><%=dic["qywyjyzhzb_xgzh"] %></td>
                        </tr>
                        <tr>
                            <td>孟州化工支行</td>
                            <td><%=dic["qywyjybs_hgzh"] %></td>
                            <td><%=dic["qywyjyje_hgzh"] %></td>
                            <td><%=dic["qywyjyzhs_hgzh"] %></td>
                            <td><%=dic["qywyjyzhzb_hgzh"] %></td>
                        </tr>
                        <tr>
                            <td>孟州南庄支行</td>
                            <td><%=dic["qywyjybs_nzzh"] %></td>
                            <td><%=dic["qywyjyje_nzzh"] %></td>
                            <td><%=dic["qywyjyzhs_nzzh"] %></td>
                            <td><%=dic["qywyjyzhzb_nzzh"] %></td>
                        </tr>
                        <tr>
                            <td>合计</td>
                            <td><%=dic["qywyjybs_mzsyczyh"] %></td>
                            <td><%=dic["qywyjyje_mzsyczyh"] %></td>
                            <td><%=dic["qywyjyzhs_mzsyczyh"] %></td>
                            <td><%=dic["qywyjyzhzb_mzsyczyh"] %></td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <br />
            <br />
            <div>
                <b>各单位手机银行交易情况统计表：</b>
                <table class="table table-bordered table-hover definewidth m10">
                    <thead>
                        <tr>
                            <th>单位</th>
                            <th>交易笔数</th>
                            <th>交易金额数</th>
                            <th>交易账户数</th>
                            <th>交易账号占比</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>孟州营业部</td>
                            <td><%=dic["sjyhjybs_yyb"] %></td>
                            <td><%=dic["sjyhjyje_yyb"] %></td>
                            <td><%=dic["sjyhjyzhs_yyb"] %></td>
                            <td><%=dic["sjyhjyzhzb_yyb"] %></td>
                        </tr>
                        <tr>
                            <td>孟州西虢支行</td>
                            <td><%=dic["sjyhjybs_xgzh"] %></td>
                            <td><%=dic["sjyhjyje_xgzh"] %></td>
                            <td><%=dic["sjyhjyzhs_xgzh"] %></td>
                            <td><%=dic["sjyhjyzhzb_xgzh"] %></td>
                        </tr>
                        <tr>
                            <td>孟州化工支行</td>
                            <td><%=dic["sjyhjybs_hgzh"] %></td>
                            <td><%=dic["sjyhjyje_hgzh"] %></td>
                            <td><%=dic["sjyhjyzhs_hgzh"] %></td>
                            <td><%=dic["sjyhjyzhzb_hgzh"] %></td>
                        </tr>
                        <tr>
                            <td>孟州南庄支行</td>
                            <td><%=dic["sjyhjybs_nzzh"] %></td>
                            <td><%=dic["sjyhjyje_nzzh"] %></td>
                            <td><%=dic["sjyhjyzhs_nzzh"] %></td>
                            <td><%=dic["sjyhjyzhzb_nzzh"] %></td>
                        </tr>
                        <tr>
                            <td>合计</td>
                            <td><%=dic["sjyhjybs_mzsyczyh"] %></td>
                            <td><%=dic["sjyhjyje_mzsyczyh"] %></td>
                            <td><%=dic["sjyhjyzhs_mzsyczyh"] %></td>
                            <td><%=dic["sjyhjyzhzb_mzsyczyh"] %></td>
                        </tr>
                    </tbody>
                </table>
            </div>

        </div>
    </form>
    <br />
    <p>
        &nbsp;</p>
</body>
</html>
