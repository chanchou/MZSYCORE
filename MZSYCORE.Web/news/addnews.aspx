<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addnews.aspx.cs" Inherits="MZSYCORE.Web.news.addnews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta charset="UTF-8">
    <link rel="stylesheet" type="text/css" href="../Css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="../Css/bootstrap-responsive.css" />
    <link rel="stylesheet" type="text/css" href="../Css/style.css" />
    <script type="text/javascript" src="../Js/jquery.js"></script>
    <script type="text/javascript" src="../Js/jquery.sorted.js"></script>
    <script type="text/javascript" src="../Js/bootstrap.js"></script>
    <script type="text/javascript" src="../Js/ckform.js"></script>
    <script type="text/javascript" src="../Js/common.js"></script>



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
    </style>
</head>
<body>
    <form id="form1" runat="server" class="definewidth m20">
        <table class="table table-bordered table-hover definewidth m10">
            <tr>
                <td width="10%" class="tableleft">新闻标题</td>
                <td>
                    <asp:TextBox ID="tbox_title" runat="server" Height="24px" Width="583px"></asp:TextBox></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">新闻内容</td>
                <td>
                    <asp:TextBox ID="tbox_content" runat="server" Height="166px" TextMode="MultiLine" Width="582px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">上传附件</td>
                <td>
                    <asp:FileUpload ID="fileupload" runat="server" Width="308px" /></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft"></td>
                <td><asp:CheckBox ID="ckbSendMessage" runat="server" Checked="True"  Text="是否发送短信通知"  /></td>
            </tr>
            <tr>
                <td class="tableleft">
                    </td>
                <td>&nbsp; &nbsp;
                    <asp:LinkButton ID="lbtn_save" runat="server" CssClass="btn btn-primary" OnClick="lbtn_save_Click">保存</asp:LinkButton>&nbsp;&nbsp;
                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:LinkButton ID="lbtn_back" runat="server" CssClass="btn btn-primary" PostBackUrl="~/news/index.aspx">返回列表</asp:LinkButton></td>
            </tr>
        </table>
    </form>
</body>
</html>
