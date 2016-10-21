<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="MZSYCORE.Web.Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>孟州射阳村镇银行核心数据管理系统</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="assets/css/dpl-min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/bui-min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/main-min.css" rel="stylesheet" type="text/css" />

</head>
<body>

    <div class="header">

        <div class="dl-title">
            <!--<img src="/chinapost/Public/assets/img/top.png">-->
        </div>

        <div class="dl-log">
            欢迎您，<span class="dl-log-user"><%=name %></span><a href="Handler/Logout.ashx" title="退出系统" class="dl-log-quit">[退出]</a>
        </div>
    </div>
    <div class="content">
        <div class="dl-main-nav">
            <div class="dl-inform">
                <div class="dl-inform-title"><s class="dl-inform-icon dl-up"></s></div>
            </div>
            <ul id="J_Nav" class="nav-list ks-clear">
                <li class="nav-item dl-selected">
                    <div class="nav-item-inner nav-home">行务信息</div>
                </li>
                <li class="nav-item dl-selected">
                    <div class="nav-item-inner nav-home">存款会计</div>
                </li>
                <li class="nav-item dl-selected">
                    <div class="nav-item-inner nav-home">信贷管理</div>
                </li>
                <li class="nav-item dl-selected">
                    <div class="nav-item-inner nav-home">小工具</div>
                </li>
            </ul>
        </div>
        <ul id="J_NavContent" class="dl-tab-conten">
        </ul>
    </div>
    <script type="text/javascript" src="assets/js/jquery-1.8.1.min.js"></script>
    <script type="text/javascript" src="assets/js/bui-min.js"></script>
    <script type="text/javascript" src="assets/js/common/main-min.js"></script>
    <script type="text/javascript" src="assets/js/config-min.js"></script>
    <script>
        BUI.use('common/main', function () {
            var config = [
                {
                    id: '101', menu: [{
                        text: '行务信息', items: [{ id: '102', text: '行员信息', href: 'employee/index.aspx' },
                                                  { id: '103', text: '新闻管理', href: 'news/index.aspx' },
                                                  { id: '104', text: '修改密码', href: 'employee/changePWD.aspx' }
                        ]
                    }]

                },
                {
                    id: '201', menu: [{
                        text: '存款会计', items: [
                            { id: '202', text: '一月内到期存款', href: 'PersonManager/DaoqiCunkuan/index.aspx' },
                            { id: '203', text: '存款业绩明细查询', href: 'PersonManager/CunKuanYeJiMingXi/index.aspx' },
                            { id: '204', text: '财务部所需数据查询', href: 'PersonManager/CaiwubuSuoxuShuju/index.aspx' },
                            { id: '205', text: 'PISA报表（试用）', href: 'PersonManager/PISAShujuBaobiao/pre_index.aspx' },
                            { id: '206', text: '电子银行业务数据查询', href: 'PersonManager/DianziYinhangShuju/index.aspx' }

                        ]
                    }]

                },
                {
                    id: '301', menu: [{
                        text: '信贷管理', items: [{ id: '302', text: '贷款信息明细', href: 'XindaiManager/DaikuanMingxi/index.aspx' },
                                                  { id: '303', text: '贷款每日放还款', href: 'XindaiManager/DaikuanFangHuankuan/index.aspx' },
                                                  { id: '304', text: '贷款利息导出', href: 'XindaiManager/DaikuanhuLixi/index.aspx' },
                                                  { id: '305', text: '利息逾期查询', href: 'XindaiManager/DaikuanQianxi/index.aspx' },
                                                  { id: '306', text: '本金逾期查询', href: 'XindaiManager/DaikuanQianxi/feizhengchang.aspx' }]
                    }]

                },
                {
                    id: '401', menu: [{
                        text: '小工具', items: [{ id: '402', text: '存款利率计算', href: 'Xiaogongju/CunkuanLilvJisuan/index.aspx' },
                                                { id: '403', text: '贷款利率计算', href: 'Xiaogongju/daikuanlilvjisuan/index.aspx' },
                                                { id: '404', text: '存款户日均计算', href: 'PersonManager/CunKuanRiJun/index.aspx' }

                        ]
                    }]
                }];
            new PageUtil.MainPage({
                modulesConfig: config
            });
        });
    </script>
</body>
</html>
