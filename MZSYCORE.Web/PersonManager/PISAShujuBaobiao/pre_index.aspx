<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pre_index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.PISAShujuBaobiao.pre_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <%--<link href="../../Css/style.css" rel="stylesheet" />--%>
    <%--<link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>注意事项：</h1>
            <br />
            <div>
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                1.本功能为测试版，使用之前请至少核对一次数据。
            <br />
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                2.为节省系统开销，本功能仅在每月10日前开放查询。<br />
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                3.系统默认为本月报表查询提供服务，计算数据为上月数据。
            </div>
            <br />
            <br />
            <br />
            <br />
            <div align="center">
                <asp:Button ID="Button1" runat="server" Text="开始查询" CssClass="btn btn-success" OnClick="Button1_Click"  OnClientClick="this.disabled=true" UseSubmitBehavior="False"/>

            </div>
        </div>
    </form>

</body>
</html>
