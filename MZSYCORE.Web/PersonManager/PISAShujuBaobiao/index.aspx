<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MZSYCORE.Web.PersonManager.PISA数据报表.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Css/style.css" rel="stylesheet" />
    <link href="../../Css/bootstrap-responsive.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 10%;
        }

        .auto-style2 {
            width: 30%;
        }

        .auto-style3 {
            width: 10%;
        }

        .auto-style4 {
            width: 10%;
        }

        .auto-style5 {
            width: 40%;
        }

        </style>
</head>
<body>
    <form id="form1" runat="server" >

        <div >
            <h3><span>银行卡业务量采集表单</span></h3>
            <table class="table table-bordered table-hover definewidth m10" >
                <thead>
                    <tr>
                        <td class="auto-style1">序号</td>
                        <td class="auto-style2">名称</td>
                        <td class="auto-style3">笔数</td>
                        <td class="auto-style4">业务量</td>
                        <td class="auto-style5">备注</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class="auto-style1">0</td>
                        <td class="auto-style2">银行卡业务量总量</td>
                        <td class="auto-style3"><%=Yinhangka_Zongliang_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zongliang_Jine %></td>
                        <td class="auto-style5">银行卡业务量总量=存现+取现+消费+转账</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">1</td>
                        <td class="auto-style2">存现</td>
                        <td class="auto-style3"><%=Yinhangka_Cunxian_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Cunxian_Jine %></td>
                        <td class="auto-style5">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">柜面存现</td>
                        <td class="auto-style3"><%=Yinhangka_Cunxian_Guimian_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Cunxian_Guimian_Jine %></td>
                        <td class="auto-style5" rowspan="2">存现=柜面存现+ATM存现<br />
                            备注：将非柜面存现全部视为ATM存现</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">ATM存现</td>
                        <td class="auto-style3"><%=Yinhangka_Cunxian_ATM_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Cunxian_ATM_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">2</td>
                        <td class="auto-style2">取现</td>
                        <td class="auto-style3"><%=Yinhangka_Quxian_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Quxian_Jine %></td>
                        <td class="auto-style5">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">柜面取现</td>
                        <td class="auto-style3"><%=Yinhangka_Quxian_Guimian_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Quxian_Guimian_Jine %></td>
                        <td class="auto-style5" rowspan="2">取现=柜面取现+ATM取现<br />
                            备注：将非柜面取现全部视为ATM取现</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">ATM取现</td>
                        <td class="auto-style3"><%=Yinhangka_Quxian_ATM_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Quxian_ATM_Jine %></td>
                    </tr>
                      <tr>
                        <td class="auto-style1">a&nbsp;</td>
                        <td class="auto-style2">本行取现</td>
                        <td class="auto-style3"><%=Yinhangka_Quxian_Benhang_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Quxian_Benhang_Jine %></td>
                           <td class="auto-style5" rowspan="2">取现=本行取现+他行取现</td>
                    </tr>
                      <tr>
                        <td class="auto-style1">b</td>
                        <td class="auto-style2">他行取现</td>
                        <td class="auto-style3"><%=Yinhangka_Quxian_Tahang_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Quxian_Tahang_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">3</td>
                        <td class="auto-style2">消费</td>
                        <td class="auto-style3"><%=Yinhangka_Xiaofei_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Xiaofei_Jine %></td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">4</td>
                        <td class="auto-style2">转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_Jine %></td>
                        <td class="auto-style5"><br />
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">行内转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_Hangnei_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_Hangnei_Jine %></td>
                        <td class="auto-style5" rowspan="2">转账=行内转账+跨行转账</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">跨行转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_Kuahang_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_Kuahang_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">a</td>
                        <td class="auto-style2">柜面转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_Guimian_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_Guimian_Jine %></td>
                        <td class="auto-style5" rowspan="4">转账=柜面转账+ATM转账+网银转账+手机银行转账</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">b</td>
                        <td class="auto-style2">ATM转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_ATM_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_ATM_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">c</td>
                        <td class="auto-style2">网银转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_Wangyin_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_Wangyin_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">d</td>
                        <td class="auto-style2">手机银行转账</td>
                        <td class="auto-style3"><%=Yinhangka_Zhuanzhang_Shouji_Bishu %></td>
                        <td class="auto-style4"><%=Yinhangka_Zhuanzhang_Shouji_Jine %></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>
            <br />
            <h3>支票业务量</h3>
            <table class="table table-bordered table-hover definewidth ">
                <thead>
                    <tr>
                        <td class="auto-style1">序号</td>
                        <td class="auto-style2">名称</td>
                        <td class="auto-style3">笔数</td>
                        <td class="auto-style4">业务量</td>
                        <td class="auto-style5">备注</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class="auto-style1">0</td>
                        <td class="auto-style2">支票业务量总量</td>
                        <td class="auto-style3"><%=Zhipiao_Zongliang_Bishu %></td>
                        <td class="auto-style4"><%=Zhipiao_Zongliang_Jine %></td>
                        <td class="auto-style5">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">1</td>
                        <td class="auto-style2">转账支票业务量</td>
                        <td class="auto-style3"><%=Zhipiao_Zhuanzhang_Bishu %></td>
                        <td class="auto-style4"><%=Zhipiao_Zhuanzhang_Jine %></td>
                        <td class="auto-style5" rowspan="2">支票业务量总量=现金支票+转账支票</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">2</td>
                        <td class="auto-style2">现金支票业务量</td>
                        <td class="auto-style3"><%=Zhipiao_Xianjin_Bishu %></td>
                        <td class="auto-style4"><%=Zhipiao_Xianjin_Jine %></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>
            <br />
            <h3>电子支付业务量</h3>
            <table class="table table-bordered table-hover definewidth m10">
                <thead>
                    <tr>
                        <td class="auto-style1">序号</td>
                        <td class="auto-style2">名称</td>
                        <td class="auto-style3">笔数</td>
                        <td class="auto-style4">业务量</td>
                        <td class="auto-style5">备注</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class="auto-style1">0</td>
                        <td class="auto-style2">ATM业务量</td>
                        <td class="auto-style3"><%=ATM_Zongliang_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Zongliang_Jine %></td>
                        <td class="auto-style5">ATM业务量=ATM存现业务+ATM取现业务+ATM转账业务量</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">行内ATM业务量</td>
                        <td class="auto-style3"><%=ATM_Hangnei_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Hangnei_Jine %></td>
                        <td class="auto-style5" rowspan="2">ATM业务量=行内+行外</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">跨行ATM业务量</td>
                        <td class="auto-style3"><%=ATM_Kuahang_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Kuahang_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">a</td>
                        <td class="auto-style2">单位ATM业务量</td>
                        <td class="auto-style3"><%=ATM_Danwei_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Danwei_Jine %></td>
                        <td class="auto-style5" rowspan="2">ATM业务量=单位+个人（默认无单位）</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">b</td>
                        <td class="auto-style2">个人ATM业务量</td>
                        <td class="auto-style3"><%=ATM_Geren_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Geren_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">1</td>
                        <td class="auto-style2">ATM存现业务量</td>
                        <td class="auto-style3"><%=ATM_Cunxian_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Cunxian_Jine %></td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">行内ATM存现业务量</td>
                        <td class="auto-style3"><%=ATM_Cunxian_Hangnei_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Cunxian_Hangnei_Jine %></td>
                        <td class="auto-style5" rowspan="2">ATM存现业务=行内+行外</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">跨行ATM存现业务量</td>
                        <td class="auto-style3"><%=ATM_Cunxian_Kuahang_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Cunxian_Kuahang_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">2</td>
                        <td class="auto-style2">ATM取现业务量</td>
                        <td class="auto-style3"><%=ATM_Quxian_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Quxian_Jine %></td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">行内ATM取现业务量</td>
                        <td class="auto-style3"><%=ATM_Quxian_Hangnei_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Quxian_Hangnei_Jine %></td>
                        <td class="auto-style5" rowspan="2">ATM取现业务=行内+行外</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">跨行ATM取现业务量</td>
                        <td class="auto-style3"><%=ATM_Quxian_Kuahang_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Quxian_Kuahang_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">3</td>
                        <td class="auto-style2">ATM转账业务量</td>
                        <td class="auto-style3"><%=ATM_Zhuanzhang_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Zhuanzhang_Jine %></td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">行内ATM转账业务量</td>
                        <td class="auto-style3"><%=ATM_Zhuanzhang_Hangnei_Bishu %></td>
                        <td class="auto-style4"><%=ATM_Zhuanzhang_Hangnei_Jine %></td>
                        <td class="auto-style5" rowspan="2">ATM转账业务=行内+行外</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">跨行ATM转账业务量</td>
                        <td class="auto-style3"><%=ATM_Zhuanzhang_Kuahang_Bishu %></td>
                        <td class="auto-style3"><%=ATM_Zhuanzhang_Kuahang_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">4</td>
                        <td class="auto-style2">网上支付业务量</td>
                        <td class="auto-style3"><%=Wangyin_Bishu %></td>
                        <td class="auto-style4"><%=Wangyin_Jine %></td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">单位网上银行支付业务量</td>
                        <td class="auto-style3"><%=Wangyin_Danwei_Bishu %></td>
                        <td class="auto-style4"><%=Wangyin_Danwei_Jine %></td>
                        <td class="auto-style5" rowspan="2">网上支付=单位+个人</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">个人网上银行支付业务量</td>
                        <td class="auto-style3"><%=Wangyin_Geren_Bishu %></td>
                        <td class="auto-style4"><%=Wangyin_Geren_Jine %></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">5</td>
                        <td class="auto-style2">移动支付业务量</td>
                        <td class="auto-style3"><%=Shouji_Bishu %></td>
                        <td class="auto-style4"><%=Shouji_Jine %></td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">A</td>
                        <td class="auto-style2">单位移动支付业务量</td>
                        <td class="auto-style3"><%=Shouji_Danwei_Bishu %></td>
                        <td class="auto-style4"><%=Shouji_Danwei_Jine %></td>
                        <td class="auto-style5" rowspan="2">移动支付=单位+个人（默认单位无手机银行）</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">B</td>
                        <td class="auto-style2">个人移动支付业务量</td>
                        <td class="auto-style3"><%=Shouji_Geren_Bishu %></td>
                        <td class="auto-style4"><%=Shouji_Geren_Jine %></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div>
            <br />
            <h3>银行业存款类金融机构行内支付系统指标</h3>
              <table class="table table-bordered table-hover definewidth m10">
                  <thead>
                      <tr>
                          <td class="auto-style1">序号</td>
                          <td class="auto-style2">名称</td>
                          <td class="auto-style3">笔数</td>
                          <td class="auto-style4">业务量</td>
                          <td class="auto-style5">备注</td>
                      </tr>
                  </thead>
                  <tbody>
                      <tr>
                          <td class="auto-style1">0</td>
                          <td class="auto-style2">资金流动总量</td>
                          <td class="auto-style3"><%=Hangneizhifu_Zijinliudong_zongliang_Bishu %></td>
                          <td class="auto-style4"><%=Hangneizhifu_Zijinliudong_zongliang_Jine %></td>
                          <td class="auto-style5">&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style1">A</td>
                          <td class="auto-style2">资金流入量</td>
                          <td class="auto-style3"><%=Hangneizhifu_Zijinliudong_Liuru_Bishu %></td>
                          <td class="auto-style4"><%=Hangneizhifu_Zijinliudong_Liuru_Jine %></td>
                          <td class="auto-style5" rowspan="2">资金流动总量=资金流入量+资金流出量</td>
                      </tr>
                      <tr>
                          <td class="auto-style1">B</td>
                          <td class="auto-style2">资金流出量</td>
                          <td class="auto-style3"><%=Hangneizhifu_Zijinliudong_Liuchu_Bishu %></td>
                          <td class="auto-style4"><%=Hangneizhifu_Zijinliudong_Liuchu_Jine %></td>
                      </tr>
                  </tbody>
              </table>
        </div>
    </form>
</body>
</html>
