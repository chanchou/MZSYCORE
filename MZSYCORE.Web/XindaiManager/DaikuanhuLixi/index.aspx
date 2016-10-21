<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.XindaiManager.DaikuanhuLixi.index" %>

<%@ Register Src="~/MyControls/Repeater_Page.ascx" TagPrefix="uc1" TagName="Repeater_Page" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    
    <link href="../../Css/bootstrap.css" rel="stylesheet" /> 
    <link href="../../Css/style.css" rel="stylesheet" />   
    <script src="../../Js/jquery.js"></script>    
     <script src="../../Js/My97DatePicker/WdatePicker.js"></script>   
    <script type="text/ecmascript">       
        $(function () {
            $("#tbox_startDay").attr("onfocus", "");
            $("#tbox_startDay").focus(function () {
                var tbox_day_hou = $dp.$("tbox_endDay");
                WdatePicker({ onpicked: function () { tbox_endDay.focus(); }, maxDate: "#F{$dp.$D('tbox_endDay')}" })

            });
            $("#tbox_endDay").focus(function () {
                WdatePicker({ minDate: "#F{$dp.$D('tbox_startDay')}" });
            });
        });
    </script>
    <style type="text/css">
        body {
            padding-bottom: 40px;           
        }
        #main {
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-inline definewidth m20">
        <div id="main">
            单位选择：<asp:DropDownList ID="ddl_danwei" runat="server">
                <asp:ListItem Value="410826%">全部</asp:ListItem>
                <asp:ListItem Value="410826001">营业部</asp:ListItem>
                <asp:ListItem Value="410826002">西虢支行</asp:ListItem>
                <asp:ListItem Value="410826003">化工支行</asp:ListItem>
                <asp:ListItem Value="410826004">南庄支行</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;
            大小额度： <asp:DropDownList ID="ddl_daxiaoe" runat="server" Width="80px">
                <asp:ListItem>大额</asp:ListItem>
                <asp:ListItem>小额</asp:ListItem>
            </asp:DropDownList>      
             &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;   
             <asp:Button ID="btn_export" runat="server" Text="批量导出数据" CssClass="btn btn-success" OnClick="btn_export_Click" />
            <br />
            <br />
        </div>
        <div>
            说明：1.非客户经理无查询权限。<br /> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;         
            2.普通客户经理只能查询导出本人管户的贷款户。<br /> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
            3.计息日期为系统自动根据放款日期判断。<br /> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            4.计息金额默认以查询日的客户余额为计息金额。<br /> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            5.系统自动根据当前日期判断，3、6、9、12月份可导出按季结息的小额贷款户，其余月份仅可导出大额贷款户。
        </div>
    </form>
</body>
</html>
