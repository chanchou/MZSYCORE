<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MZSYCORE.Web.Default" %>

<%@ Register Src="~/MyControls/Repeater_Page.ascx" TagPrefix="uc1" TagName="Repeater_Page" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>孟州射阳村镇银行数据系统首页</title>
    <link rel="stylesheet" type="text/css" href="../Css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="../Css/bootstrap-responsive.css" />
    <link rel="stylesheet" type="text/css" href="../Css/style.css" />
    <script type="text/javascript" src="../Js/jquery.js"></script>
    <%--    <script type="text/javascript" src="../Js/jquery.sorted.js"></script>
    <script type="text/javascript" src="../Js/bootstrap.js"></script>
    <script type="text/javascript" src="../Js/ckform.js"></script>
    <script type="text/javascript" src="../Js/common.js"></script>--%>

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
    <style type="text/css">
        * {
            margin: 0;
            padding: 0;
            list-style: none;
        }

        img {
            border: 0 none;
        }

        /*主导航菜单*/
        #nav-menu {
            height: 40px;
            background: #1a529c;
            margin: 0 0;
        }

            #nav-menu .container {
                position: relative;
                overflow: visible;
                z-index: 99;
            }

            #nav-menu .menu {
                padding: 0 0 0 14px;
            }

                #nav-menu .menu li {
                    position: relative;
                    float: left;
                    padding: 0 8px 0 5px;
                    display: inline;
                    font-size: 14px;
                }

                    #nav-menu .menu li h3 {
                        font-weight: normal;
                        display: inline-block;
                        float: left;
                    }

                    #nav-menu .menu li a.xialaguang {
                        margin-top: 0px;
                        display: inline-block;
                        color: #FFF;
                        height: 30px;
                        text-decoration: none;
                        font-size: 14px;
                        width: 100px;
                        text-align: center;
                    }

                        #nav-menu .menu li a.selected, #nav-menu .menu li a.navhover, #nav-menu .menu li a.xialaguang:hover {
                            color: #1a529c;
                        }

                        #nav-menu .menu li a.navhover, #nav-menu .menu li a.xialaguang:hover {
                            background-color: #FFF;
                        }

                        #nav-menu .menu li a.xialaguang span {
                            height: 30px;
                            line-height: 25px;
                            display: inline-block;
                            font-weight: bold;
                        }

                        #nav-menu .menu li a.selected span, #nav-menu .menu li a.navhover span, #nav-menu .menu li a.xialaguang:hover span {
                            cursor: pointer;
                        }

                        #nav-menu .menu li a.navhover span, #nav-menu .menu li a.xialaguang:hover span {
                            width: 100px;
                        }

                #nav-menu .menu ul.children {
                    display: none;
                    position: absolute;
                    top: 40px;
                    left: 3px;
                    width: 100px;
                    background: #FFF;
                    border: 2px solid #1a529c;
                    border-top: 0;
                    line-height: normal;
                }

                    #nav-menu .menu ul.children li {
                        width: 100px;
                        padding: 0px;
                        display: inline-block;
                        font-size: 12px;
                        border-top: 1px solid #ccc;
                    }

                        #nav-menu .menu ul.children li h3 {
                            display: block;
                            width: 100%;
                        }

                        #nav-menu .menu ul.children li a {
                            width: 100%;
                            height: 16px;
                            line-height: 16px;
                            overflow: hidden;
                            padding: 3px 0;
                            display: block;
                            color: #1a529c;
                            text-align: center;
                            text-decoration: none;
                            font-size: 12px;
                        }

                            #nav-menu .menu ul.children li a:hover {
                                background-color: #eee;
                                text-decoration: none;
                            }
    </style>

</head>
<body>
    <div id="nav-menu">
        <ul class="menu">
            <li class="stmenu">
                <h6><a href="#" class="xialaguang"><span>行务信息</span></a></h6>
                <ul class="children">
                    <li><a href="http://19.88.250.10/" target="_blank"><span>银监企业专网邮箱</span></a></li>
                    <li><a href="http://19.88.250.5:9080/gwyq/" target="_blank"><span>银监公文要情网</span></a></li>
                    <li><a href="http://32.188.32.4" target="_blank"><span>射阳农商行</span></a></li>
                    <li><a href="http://32.188.32.77/t9/login.jsp" target="_blank"><span>T9内网邮箱</span></a></li>
                    <li><a href=" http://32.188.32.4:8081/synshczy/" target="_blank"><span>中间业务批量转换</span></a></li>
                    <li><a href="http://32.188.108.33/" target="_blank"><span>武陟射阳村镇银行</span></a></li>
                </ul>
            </li>
            <li class="stmenu">
                <h6><a href="#" class="xialaguang"><span>柜面业务</span></a></h6>
                <ul class="children">
                    <li><a href="xiaogongju/cunkuanlilvjisuan/index.aspx" target="_blank"><span>存款利息计算</span></a></li>
                    <li><a href="xiaogongju/daikuanlilvjisuan/index.aspx" target="_blank"><span>贷款利息计算</span></a></li>
                    <li><a href="http://32.188.32.130:9999/erptaml/" target="_blank"><span>村镇银行反洗钱</span></a></li>
                    <li><a href="http://32.4.17.34/aml/login.do" target="_blank"><span>江苏农信反洗钱</span></a></li>
                    <li><a href="http://32.188.108.34/ams/" target="_blank"><span>人行结算账户管理</span></a></li>
                    <li><a href="http://32.0.249.1/picp/" target="_blank"><span>人行联网核查</span></a></li>
                    <li><a href="https://32.4.17.35/mweb/" target="_blank"><span>网银后台管理</span></a></li>
                    <li><a href="http://32.0.249.1/index/" target="_blank"><span>人行信息系统</span></a></li>
                    <li><a href="http://32.0.249.11/qzxt/" target="_blank"><span>人行网间互联</span></a></li>

                </ul>
            </li>

            <li class="stmenu">
                <h6><a href="#" class="xialaguang"><span>信贷业务</span></a></h6>
                <ul class="children">
                     <li><a href="PersonManager/CunKuanRiJun/index.aspx" target="_blank"><span>存款户日均计算</span></a></li>
                    <li><a href="http://32.4.16.1:9084/credit/" target="_blank"><span>信贷管理系统</span></a></li>
                    <li><a href="http://32.0.249.1/irsas/login.do" target="_blank"><span>人行利率报备</span></a></li>
                    <li><a href="http://32.188.108.34/shcreditunion/" target="_blank"><span>个人征信查询</span></a></li>
                    <li><a href="http://32.188.108.34/shwebroot/" target="_blank"><span>企业征信查询</span></a></li>
                    <li><a href="http://32.188.32.130:9999/venus/pages/index/login.jsp" target="_blank"><span>村镇银行征信系统</span></a></li>
                   
                </ul>
            </li>
            <li class="stmenu">
                <h6><a href="#" class="xialaguang"><span>财务业务</span></a></h6>
                <ul class="children">
                    <li><a href="http://32.1.127.206/" target="_blank"><span>财管系统</span></a></li>
                    <li><a href="http://32.1.127.207/" target="_blank"><span>财报系统</span></a></li>
                    <li><a href=" http://32.188.32.213:8080/CBRS/" target="_blank"><span>射阳报表管理系统</span></a></li>
                    <li><a href="http://32.4.17.25/eReport/" target="_blank"><span>江苏农信1104</span></a></li>
                    <li><a href="http://32.188.32.81/WebReport/ReportServer?op=fs_load&cmd=fs_signin&_=1352375894015&" target="_blank"><span>射阳数据决策系统</span></a></li>
                    <li><a href="http://32.0.249.11/qzxt/" target="_blank"><span>人行网间互联</span></a></li>
                    <li><a href="http://32.188.108.34/isbp/index.jsf" target="_blank"><span>金融服务平台</span></a></li>
                   
                </ul>
            </li>
            <li class="stmenu">
                <h6><a href="#" class="xialaguang"><span>后台业务</span></a></h6>
                <ul class="children">
                    <li><a href="http://32.1.127.201:9080/itonline/pages/index/login.jsp" target="_blank"><span>Itonline系统</span></a></li>
                    <li><a href="http://32.4.17.4:9080/smart/viewLogin.action" target="_blank"><span>指纹管理系统</span></a></li>
                    <li><a href="http://32.188.32.133/sypas/login.jsp" target="_blank"><span>新绩效系统</span></a></li>
                    <li><a href="http://32.4.18.11:9080/login.html" target="_blank"><span>ATM监控系统</span></a></li>
                    <li><a href="http://32.188.108.34/webmail/" target="_blank"><span>金融城域网邮箱</span></a></li>
                    <li><a href="http://32.4.17.42:9084/crmweb/login.jsp" target="_blank"><span>CRM系统</span></a></li>

                </ul>
            </li>

        </ul>
    </div>
    <form id="form1" runat="server">
        <h3>孟州射阳村镇银行核心数据系统首页---欢迎您</h3>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;现在时间：<%=DateTime.Now.ToLongDateString() %>&nbsp;&nbsp;<%=DateTime.Now.DayOfWeek.ToString() %>
        <table class="table table-bordered table-hover definewidth m10">
            <thead>
                <tr>
                    <th class="auto-style6">发布日期</th>
                    <th class="auto-style5">发布人</th>
                    <th class="auto-style7">新闻标题</th>
                    <th class="auto-style8">操作</th>
                </tr>
            </thead>

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("publish_date","{0:D}") %></td>
                        <td><%#Eval("publish_person")%></td>
                        <td><a href="shownews.aspx?news_id=<%#Eval("news_id") %>"><%#Eval("news_title")%></a></td>
                        <td>
                            <a href="shownews.aspx?news_id=<%#Eval("news_id") %>">详情</a>
                            &nbsp;&nbsp;   
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div class="inline pull-right page">
            <asp:Label ID="lbl_dataCount" runat="server" Text="0"></asp:Label>条记录&nbsp;&nbsp;
        <asp:Label ID="lbl_pageIndex" runat="server" Text="0"></asp:Label>/
            <asp:Label ID="lbl_pageCount" runat="server" Text="0"></asp:Label>页&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_firstPage" runat="server" OnClick="lbtn_firstPage_Click">首页</asp:LinkButton>
            &nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_prePage" runat="server" OnClick="lbtn_prePage_Click">上一页</asp:LinkButton>&nbsp;&nbsp;
         <asp:LinkButton ID="lbtn_nextPage" runat="server" OnClick="lbtn_nextPage_Click">下一页</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_lastPage" runat="server" OnClick="lbtn_lastPage_Click">末页</asp:LinkButton>
        </div>
        <br />
        <br />
        <div>
            伙计，伙计，<a href="Login.aspx">登录</a>点这里
        </div>
    </form>
    <script type="text/javascript">
        $('#nav-menu .menu > li').hover(function () {
            $(this).find('.children').animate({ opacity: 'show', height: 'show' }, 200);
            $(this).find('.xialaguang').addClass('navhover');
        }, function () {
            $('.children').stop(true, true).hide();
            $('.xialaguang').removeClass('navhover');
        });
    </script>

</body>
</html>
