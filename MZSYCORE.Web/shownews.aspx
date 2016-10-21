<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shownews.aspx.cs" Inherits="MZSYCORE.Web.news.shownews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta charset="UTF-8"/>
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

        .auto-style1 {
            text-align: right;
            padding-left: 5px;
            background-color: #f5f5f5;
            height: 33px;
        }

        .auto-style2 {
            height: 33px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" class="definewidth m20">
        <table class="table table-bordered table-hover definewidth m10">
            <tr>
                <td width="10%" class="tableleft">发布人</td>
                <td>
                    <asp:Label ID="lbl_person" runat="server" Height="24px" Width="583px"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">发布时间</td>
                <td>
                    <asp:Label ID="lbl_date" runat="server" Height="24px" Width="583px"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">新闻标题</td>
                <td>
                    <asp:Label ID="lbl_title" runat="server" Height="24px" Width="583px"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%" class="tableleft">新闻内容</td>
                <td>
                    <asp:TextBox ID="tbox_content" runat="server" Height="166px" TextMode="MultiLine" Width="582px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="10%" class="auto-style1">附件下载</td>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbtn_attachment" runat="server" OnClick="lbtn_attachment_Click">附件下载</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="tableleft"></td>
                <td>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:LinkButton ID="lbtn_back" runat="server" CssClass="btn btn-primary" PostBackUrl="Default.aspx">返回列表</asp:LinkButton></td>
            </tr>
        </table>
    </form>
</body>
</html>
