<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.XindaiManager.DaikuanFangHuankuan.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link rel="stylesheet" type="text/css" href="../../Css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="../../Css/bootstrap-responsive.css" />
    <link rel="stylesheet" type="text/css" href="../../Css/style.css" />
    <script type="text/javascript" src="../../Js/jquery.js"></script>
    <script type="text/javascript" src="../../Js/jquery.sorted.js"></script>
    <script type="text/javascript" src="../../Js/bootstrap.js"></script>
    <script type="text/javascript" src="../../Js/ckform.js"></script>
    <script type="text/javascript" src="../../Js/common.js"></script>
    <script type="text/javascript" src="../../Js/My97DatePicker/WdatePicker.js"></script>



    <style type="text/css">
        body {
            padding-bottom: 40px;
        }

        .sidebar-nav {
            padding: 9px 0;
        }

        @media (max-width: 980px) {
            /* Enable use of floated navbar text */
            .navbar-text.pull-right {
                float: none;
                padding-left: 5px;
                padding-right: 5px;
            }
        }
        .auto-style1 {
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-inline definewidth m20">
        <div>
             &nbsp;&nbsp; &nbsp;&nbsp;
            查询记账日期：<asp:TextBox ID="tbox_date" runat="server" Width="85px" Height="26px"></asp:TextBox><img onclick="WdatePicker({el:'tbox_date'})" src="../../Js/My97DatePicker/skin/datePicker.gif" width="16" height="22" align="absmiddle" />
        &nbsp;&nbsp;
            借还款标志：<asp:DropDownList ID="ddl_jiehuanflag" runat="server" Height="26px" Width="97px" >
                 <asp:ListItem Value="-1">全部</asp:ListItem>
                 <asp:ListItem Value="C">还款</asp:ListItem>
                 <asp:ListItem Value="D">放款</asp:ListItem>
             </asp:DropDownList>
              &nbsp;&nbsp;  &nbsp;&nbsp;  &nbsp;&nbsp;  &nbsp;&nbsp;  &nbsp;&nbsp;
            <asp:Button ID="btn_search" runat="server" Text="查询" CssClass="btn btn-success" OnClick="btn_search_Click" />
        </div>
        <div>
            <table class="table table-bordered table-hover definewidth m10">
                <thead>
                    <tr>
                        <th class="auto-style1">记账日期</th>
                        <th class="auto-style1">借贷别</th>
                        <th class="auto-style1">贷款账号</th>
                        <th class="auto-style1">客户名称</th>
                        <th class="auto-style1">帐卡种类</th>
                        <th class="auto-style1">帐卡子分类</th>                       
                        <th class="auto-style1">交易金额</th>
                        <th class="auto-style1">贷款余额</th>
                        <th class="auto-style1">操作柜员号</th>            
                        <th class="auto-style1">机构号</th>
                       <%-- <th>操作</th>--%>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("LN_ENTR_DT_N") %></td>
                             <td><%#Bind_LN_DR_CR_COD(Eval("LN_DR_CR_COD")) %></td>
                             <td><%#Eval("LN_LN_ACCT_NO") %></td>
                             <td><%#Eval("ln_cust_name") %></td>
                             <td><%#Bind_LN_ACCD_TYP(Eval("LN_ACCD_TYP")) %></td>
                             <td><%#Bind_LN_ACCD_SUB_CLSFN(Eval("LN_ACCD_SUB_CLSFN")) %></td>                            
                             <td><%#Eval("LN_TX_AMT") %></td>
                             <td><%#Eval("LN_ATX_BAL") %></td>
                             <td><%#Eval("LN_TX_OPR_NO") %></td>                    
                            <td><%#Bind_LN_TX_OPUN_NO(Eval("LN_TX_OPUN_NO")) %></td>
                            <%--<td><a href="showdetailed.aspx?date=<%#Eval("LN_ENTR_DT_N")%>&&LN_LN_ACCT_NO=<%#Eval("LN_LN_ACCT_NO") %>">详情</a></td>--%>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
