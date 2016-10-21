<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.news.index" %>

<%@ Register Src="~/MyControls/Repeater_Page.ascx" TagPrefix="uc1" TagName="Repeater_Page" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
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

        .auto-style5 {
            width: 133px;
            height: 36px;
        }
        .auto-style6 {
            width: 140px;
            height: 36px;
        }
        .auto-style7 {
            width: 454px;
            height: 36px;
        }
        .auto-style8 {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Button ID="btn_addnews" CssClass="btn btn-success"  runat="server" Text="发布新消息" PostBackUrl="~/news/addnews.aspx" />
        <table class="table table-bordered table-hover definewidth m10">
            <thead>
                <tr>
                    <th class="auto-style6">发布日期</th>
                    <th class="auto-style5">发布人</th>
                    <th class="auto-style7">新闻标题</th>
                    <th class="auto-style8">修改</th>
                </tr>
            </thead>

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("publish_date","{0:D}") %></td>
                        <td><%#Eval("publish_person")%></td>
                        <td><%#Eval("news_title")%></td>
                        <td>
                            <a href="shownews.aspx?news_id=<%#Eval("news_id") %>" >详情</a>&nbsp;&nbsp;
                           <%-- <a href="delete.ashx?news_id=<%#Eval("news_id") %>" >删除</a></td>--%>
                      <%--  删除功能暂且屏蔽--%>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
        <div class="inline pull-right page">
            <asp:Label ID="lbl_dataCount" runat="server" Text="0"></asp:Label>条记录&nbsp;&nbsp;
        <asp:Label ID="lbl_pageIndex" runat="server" Text="0"></asp:Label>/
            <asp:Label ID="lbl_pageCount" runat="server" Text="0"></asp:Label>页&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_firstPage" runat="server" OnClick="lbtn_firstPage_Click" >首页</asp:LinkButton>
            &nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_prePage" runat="server" OnClick="lbtn_prePage_Click" >上一页</asp:LinkButton>&nbsp;&nbsp;
         <asp:LinkButton ID="lbtn_nextPage" runat="server" OnClick="lbtn_nextPage_Click" >下一页</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_lastPage" runat="server" OnClick="lbtn_lastPage_Click" >末页</asp:LinkButton>
        </div>
    </form>
</body>
</html>
