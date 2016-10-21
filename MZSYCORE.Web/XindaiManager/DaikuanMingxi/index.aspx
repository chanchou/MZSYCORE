<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.XindaiManager.DaikuanMingxi.index" %>

<%@ Register Src="~/MyControls/Repeater_Page.ascx" TagPrefix="uc1" TagName="Repeater_Page" %>


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



    <style type="text/css">
        body {
            padding-bottom: 40px;
        }

        #main_div {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-inline definewidth m20">
        <div id="main_div">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;所属单位：<asp:DropDownList ID="ddl_suoshudanwei" runat="server" Height="26px" Width="90px">
                <asp:ListItem Value="-1">全行</asp:ListItem>
                <asp:ListItem Value="410826001">营业部</asp:ListItem>
                <asp:ListItem Value="410826002">西虢支行</asp:ListItem>
                <asp:ListItem Value="410826003">化工支行</asp:ListItem>
                <asp:ListItem Value="410826004">南庄支行</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;  &nbsp;&nbsp;
            账户状态:
            <asp:DropDownList ID="ddl_zhanghuzhuangtai" runat="server" Height="26px" Width="90px">
                <asp:ListItem Value="-1">全部</asp:ListItem>
                <asp:ListItem Value="1">正常</asp:ListItem>
                <asp:ListItem Value="2">逾期</asp:ListItem>
                <asp:ListItem Value="3">非应计</asp:ListItem>
                <asp:ListItem Value="5">结清</asp:ListItem>
                <asp:ListItem Value="6">部分逾期</asp:ListItem>

            </asp:DropDownList>
            &nbsp;&nbsp;      &nbsp;&nbsp;
            客户类别:
            <asp:DropDownList ID="ddl_kehuleibie" runat="server" Height="26px" Width="90px">
                <asp:ListItem Value="-1">全部</asp:ListItem>
                <asp:ListItem Value="1">对私</asp:ListItem>
                <asp:ListItem Value="2">对公</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_chaxun" runat="server" Text="批量导出" class="btn btn-primary" OnClick="btn_chaxun_Click" />
        </div>
        <br />
    </form>
    <br />
    <br />
    <div>
        说明：1.非客户经理无查询权限。<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;         
            2.普通客户经理只能查询导出本人管户的贷款户。<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    </div>
</body>
</html>
