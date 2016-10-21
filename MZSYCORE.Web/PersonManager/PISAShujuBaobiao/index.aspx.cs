using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.PersonManager.PISA数据报表
{
    public partial class index : System.Web.UI.Page
    {
        BLL.BLL_PISA bll_pisa = new BLL.BLL_PISA();
        public string YinhangkaYewu_Zongliang = "没有数据";

      //测试  int i0

       //参数设置
        public string Jigouma = Web_Constant.Jigouma;
        public string Kabin = Web_Constant.Kabin;

        //银行卡业务量总量
        public string Yinhangka_Zongliang_Bishu = "没有数据";
        public string Yinhangka_Zongliang_Jine = "没有数据";

        //银行卡存现
        public string Yinhangka_Cunxian_Bishu = "没有数据";
        public string Yinhangka_Cunxian_Jine = "没有数据";

        //银行卡柜面存现和ATM存现
        public string Yinhangka_Cunxian_Guimian_Bishu = "没有数据";
        public string Yinhangka_Cunxian_Guimian_Jine = "没有数据";
        public string Yinhangka_Cunxian_ATM_Bishu = "没有数据";
        public string Yinhangka_Cunxian_ATM_Jine = "没有数据";

        //银行卡取现
        public string Yinhangka_Quxian_Bishu = "没有数据";
        public string Yinhangka_Quxian_Jine = "没有数据";

        //银行卡柜面取现和ATM取现
        public string Yinhangka_Quxian_Guimian_Bishu = "没有数据";
        public string Yinhangka_Quxian_Guimian_Jine = "没有数据";
        public string Yinhangka_Quxian_ATM_Bishu = "没有数据";
        public string Yinhangka_Quxian_ATM_Jine = "没有数据";

        //银行卡本行取现和他行取现
        public string Yinhangka_Quxian_Benhang_Bishu = "没有数据";
        public string Yinhangka_Quxian_Benhang_Jine = "没有数据";
        public string Yinhangka_Quxian_Tahang_Bishu = "没有数据";
        public string Yinhangka_Quxian_Tahang_Jine = "没有数据";

        //银行卡消费
        public string Yinhangka_Xiaofei_Bishu = "没有数据";
        public string Yinhangka_Xiaofei_Jine = "没有数据";

        //银行卡转账
        public string Yinhangka_Zhuanzhang_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_Jine = "没有数据";

        //银行卡行内转账和跨行转账
        public string Yinhangka_Zhuanzhang_Hangnei_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_Hangnei_Jine = "没有数据";
        public string Yinhangka_Zhuanzhang_Kuahang_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_Kuahang_Jine = "没有数据";

        //银行卡柜面转账、ATM转账、网银转账、手机转账
        public string Yinhangka_Zhuanzhang_Guimian_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_Guimian_Jine = "没有数据";
        public string Yinhangka_Zhuanzhang_ATM_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_ATM_Jine = "没有数据";
        public string Yinhangka_Zhuanzhang_Wangyin_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_Wangyin_Jine = "没有数据";
        public string Yinhangka_Zhuanzhang_Shouji_Bishu = "没有数据";
        public string Yinhangka_Zhuanzhang_Shouji_Jine = "没有数据";

        //支票业务总量
        //转账支票业务量
        //现金支票业务量
        public string Zhipiao_Zongliang_Bishu = "没有数据";
        public string Zhipiao_Zongliang_Jine = "没有数据";
        public string Zhipiao_Zhuanzhang_Bishu = "没有数据";
        public string Zhipiao_Zhuanzhang_Jine = "没有数据";
        public string Zhipiao_Xianjin_Bishu = "没有数据";
        public string Zhipiao_Xianjin_Jine = "没有数据";

        //ATM总量
        public string ATM_Zongliang_Bishu = "没有数据";
        public string ATM_Zongliang_Jine = "没有数据";
        //行内ATM
        public string ATM_Hangnei_Bishu = "没有数据";
        public string ATM_Hangnei_Jine = "没有数据";
        //跨行ATM
        public string ATM_Kuahang_Bishu = "没有数据";
        public string ATM_Kuahang_Jine = "没有数据";

        //单位ATM
        public string ATM_Danwei_Bishu = "没有数据";
        public string ATM_Danwei_Jine = "没有数据";
        //个人ATM
        public string ATM_Geren_Bishu = "没有数据";
        public string ATM_Geren_Jine = "没有数据";

        //ATM存现
        public string ATM_Cunxian_Bishu = "没有数据";
        public string ATM_Cunxian_Jine = "没有数据";
        //行内ATM存现
        public string ATM_Cunxian_Hangnei_Bishu = "没有数据";
        public string ATM_Cunxian_Hangnei_Jine = "没有数据";
        //跨行ATM存现
        public string ATM_Cunxian_Kuahang_Bishu = "没有数据";
        public string ATM_Cunxian_Kuahang_Jine = "没有数据";

        //ATM取现
        public string ATM_Quxian_Bishu = "没有数据";
        public string ATM_Quxian_Jine = "没有数据";
        //行内ATM取现
        public string ATM_Quxian_Hangnei_Bishu = "没有数据";
        public string ATM_Quxian_Hangnei_Jine = "没有数据";
        //跨行ATM取现
        public string ATM_Quxian_Kuahang_Bishu = "没有数据";
        public string ATM_Quxian_Kuahang_Jine = "没有数据";

        //ATM转账
        public string ATM_Zhuanzhang_Bishu = "没有数据";
        public string ATM_Zhuanzhang_Jine = "没有数据";
        //行内ATM转账
        public string ATM_Zhuanzhang_Hangnei_Bishu = "没有数据";
        public string ATM_Zhuanzhang_Hangnei_Jine = "没有数据";
        //跨行ATM转账
        public string ATM_Zhuanzhang_Kuahang_Bishu = "没有数据";
        public string ATM_Zhuanzhang_Kuahang_Jine = "没有数据";


        //网上支付
        public string Wangyin_Bishu = "没有数据";
        public string Wangyin_Jine = "没有数据";
        //单位网上支付
        public string Wangyin_Danwei_Bishu = "没有数据";
        public string Wangyin_Danwei_Jine = "没有数据";
        //个人网上支付
        public string Wangyin_Geren_Bishu = "没有数据";
        public string Wangyin_Geren_Jine = "没有数据";

        //移动支付
        public string Shouji_Bishu = "没有数据";
        public string Shouji_Jine = "没有数据";
        //单位移动支付
        public string Shouji_Danwei_Bishu = "没有数据";
        public string Shouji_Danwei_Jine = "没有数据";
        //个人移动支付
        public string Shouji_Geren_Bishu = "没有数据";
        public string Shouji_Geren_Jine = "没有数据";


        //行内支付系统资金流动总量
        public string Hangneizhifu_Zijinliudong_zongliang_Bishu = "没有数据";
        public string Hangneizhifu_Zijinliudong_zongliang_Jine = "没有数据";
        //行内支付系统资金流入总量
        public string Hangneizhifu_Zijinliudong_Liuru_Bishu = "没有数据";
        public string Hangneizhifu_Zijinliudong_Liuru_Jine = "没有数据";
        //行内支付系统资金流出总量
        public string Hangneizhifu_Zijinliudong_Liuchu_Bishu = "没有数据";
        public string Hangneizhifu_Zijinliudong_Liuchu_Jine = "没有数据";

        DateTime dt, dt2, jiezhiRiqi, qishiRiqi;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Day < 2)
            {
                Context.Response.Write("<script language=javascript>alert('上月数据未生成。系统开放日期为本月2日后可以查询上月数据');</script>");
            }
            else
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                dt = DateTime.Now;
                dt2 = dt.AddMonths(-1);
                //截止日期是下月1号，开始日期是当月1号。比如20151001到20151101
                jiezhiRiqi = new DateTime(dt.Year, dt.Month, 1);
                qishiRiqi = new DateTime(dt2.Year, dt2.Month, 1);

                Creat_SAACNTXT_DATA();
                Creat_CRATMDET();
                Creat_WangyinZhifu();
                sw.Stop();
                Context.Response.Write(string.Format("<script language=javascript>alert('数据查询返回，本次查询用时：{0}秒钟');</script>", sw.Elapsed.TotalSeconds));
            }
        }

        private void Creat_WangyinZhifu()
        {

            //单位网上支付
            Wangyin_Danwei_Bishu = bll_pisa.GetQiyewangyinJiaoyi(Jigouma, qishiRiqi.ToString("yyyy-MM-dd"), jiezhiRiqi.ToString("yyyy-MM-dd"), out Wangyin_Danwei_Jine);


            //个人网上支付
            Wangyin_Geren_Bishu = bll_pisa.GetGerenwangyinJiaoyi(Jigouma, qishiRiqi.ToString("yyyy-MM-dd"), jiezhiRiqi.ToString("yyyy-MM-dd"), out Wangyin_Geren_Jine);



            //默认单位移动支付为0
            Shouji_Danwei_Bishu = "0";
            Shouji_Danwei_Jine = "0";
            //个人移动支付
            Shouji_Geren_Bishu = bll_pisa.GetShoujiyinhangJiaoyi(Jigouma, qishiRiqi.ToString("yyyy-MM-dd"), jiezhiRiqi.ToString("yyyy-MM-dd"), out Shouji_Geren_Jine);
            //移动支付
            Shouji_Bishu = Shouji_Geren_Bishu;
            Shouji_Jine = Shouji_Geren_Jine;

            //网上支付
            Wangyin_Bishu = Common.Common.StringYunsuan(Wangyin_Danwei_Bishu, Wangyin_Geren_Bishu, "+").ToString();
            Wangyin_Jine = Common.Common.StringYunsuan(Wangyin_Danwei_Jine, Wangyin_Geren_Jine, "+").ToString();

        }

        private void Creat_CRATMDET()
        {

            DataSet ds_Cratmdet = new DataSet();
            string CratmdetCacheNameToUse = string.Format("ds_Cratmdet_{0}", jiezhiRiqi);
            string CratmdetCacheNameToDelete = string.Format("ds_Cratmdet_{0}", qishiRiqi);

            //根据当前时间，判断是否存在使用的缓存。如果存在，那么直接调用，否则重新生成。
            //同时，判断上一个缓存是否存在，如果存在，那么删除
            if (Cache[CratmdetCacheNameToDelete] != null)
            {
                Cache[CratmdetCacheNameToDelete] = null;
            }
            if (Cache[CratmdetCacheNameToUse] == null)
            {
                ds_Cratmdet = bll_pisa.GetCratmdetList(qishiRiqi.ToString("yyyyMMdd"), jiezhiRiqi.ToString("yyyyMMdd"), Jigouma);
                Cache[CratmdetCacheNameToUse] = ds_Cratmdet;
            }
            else
            {
                ds_Cratmdet = Cache[CratmdetCacheNameToUse] as DataSet;
            }


            //行内ATM
            //我的理解是本行银行卡业务 
            //[隶属机构：410826%；卡号：621386004%或者卡号为空；冲正标志：0未冲正；]
            ATM_Hangnei_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", string.Format("CR_CRD_NO like '{0}%' or CR_CRD_NO is null", Kabin)).ToString();
            ATM_Hangnei_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", string.Format("CR_CRD_NO like '{0}%' or CR_CRD_NO is null",Kabin)).ToString();

            //跨行ATM
            //我的理解是他行银行卡业务
            //[隶属机构：410826%；卡号：不是621386004%；冲正标志：0未冲正；]
            ATM_Kuahang_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", string.Format("CR_CRD_NO not like '{0}%'",Kabin)).ToString();
            ATM_Kuahang_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", string.Format("CR_CRD_NO not like '{0}%'",Kabin)).ToString();




            //ATM存现
            //---ATM存现业务量
            //----[隶属机构：410826%；交易代号：CR0514800存款和SA0106103无卡无折存款；冲正标志：0未冲正；]
            ATM_Cunxian_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", "CR_TX_NO in('CR0514800','SA0106103')").ToString();
            ATM_Cunxian_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", "CR_TX_NO in('CR0514800','SA0106103')").ToString();
            //行内ATM存现
            //-----我理解为：行内的存现交易，全部是本行卡的存现交易
            //-----[隶属机构：410826%；交易代号：CR0514800存款和SA0106103无卡无折存款；卡号：621386004%或者为空；冲正标志：0未冲正；]
            ATM_Cunxian_Hangnei_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", string.Format("CR_TX_NO in('CR0514800','SA0106103') and (CR_CRD_NO like '{0}%' or CR_CRD_NO is null)",Kabin)).ToString();
            ATM_Cunxian_Hangnei_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", string.Format("CR_TX_NO in('CR0514800','SA0106103') and (CR_CRD_NO like '{0}%' or CR_CRD_NO is null)",Kabin)).ToString();

            //跨行ATM存现
            // -----我理解为：他行卡的存现交易
            //-----[隶属机构：410826%；交易代号：CR0514800存款；卡号：不为621386004%；冲正标志：0未冲正；]
            ATM_Cunxian_Kuahang_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", string.Format("CR_TX_NO ='CR0514800' and CR_CRD_NO not like '{0}%'",Kabin)).ToString();
            ATM_Cunxian_Kuahang_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", string.Format("CR_TX_NO ='CR0514800' and CR_CRD_NO not like '{0}%'",Kabin)).ToString();

            //ATM取现
            //-----我理解为：行内的取现交易，全部是本行卡的取现交易
            //-----[隶属机构：410826%；交易代号：CR0506900取款；冲正标志：0未冲正；]
            ATM_Quxian_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", "CR_TX_NO ='CR0506900'").ToString();
            ATM_Quxian_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", "CR_TX_NO ='CR0506900'").ToString();
            //行内ATM取现
            //-----我理解为：行内的取现交易，全部是本行卡的取现交易
            //-----[隶属机构：410826%；交易代号：CR0506900取款；卡号：621386004%；冲正标志：0未冲正；]
            ATM_Quxian_Hangnei_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", string.Format("CR_TX_NO ='CR0506900' and CR_CRD_NO like '{0}%'",Kabin)).ToString();
            ATM_Quxian_Hangnei_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", string.Format("CR_TX_NO ='CR0506900' and CR_CRD_NO like '{0}%'",Kabin)).ToString();
            //跨行ATM取现
            //-----我理解为：行内的取现交易，全部是他行卡的取现交易
            //-----[隶属机构：410826%；交易代号：CR0506900取款；卡号：不是621386004%；冲正标志：0未冲正；]
            ATM_Quxian_Kuahang_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", string.Format("CR_TX_NO ='CR0506900' and CR_CRD_NO not like '{0}%' ",Kabin)).ToString();
            ATM_Quxian_Kuahang_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", string.Format("CR_TX_NO ='CR0506900' and CR_CRD_NO not like '{0}%' ",Kabin)).ToString();


            //行内ATM转账
            //-----我的理解：根据数据库的表结构，本系统转本系统，均为行内。本系统转他系统，他系统转本系统，均算作跨行
            //----[隶属机构：410826%；交易代号：CR0507600本系统转本系统；冲正标志：0未冲正；]
            ATM_Zhuanzhang_Hangnei_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", "CR_TX_NO ='CR0507600'").ToString();
            ATM_Zhuanzhang_Hangnei_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", "CR_TX_NO ='CR0507600'").ToString();
            //跨行ATM转账
            //-----我的理解：根据数据库的表结构，本系统转本系统，均为行内。本系统转他系统，他系统转本系统，均算作跨行
            //----[隶属机构：410826%；交易代号：CR0512700	本系统转他行，他行转本系统；冲正标志：0未冲正；]
            ATM_Zhuanzhang_Kuahang_Bishu = ds_Cratmdet.Tables[0].Compute("count(CR_TX_AMT)", "CR_TX_NO ='CR0512700'").ToString();
            ATM_Zhuanzhang_Kuahang_Jine = ds_Cratmdet.Tables[0].Compute("sum(CR_TX_AMT)", "CR_TX_NO ='CR0512700'").ToString();


            //汇总数据

            //ATM总量
            ATM_Zongliang_Bishu = Common.Common.StringYunsuan(ATM_Hangnei_Bishu, ATM_Kuahang_Bishu, "+").ToString();
            ATM_Zongliang_Jine = Common.Common.StringYunsuan(ATM_Hangnei_Jine, ATM_Kuahang_Jine, "+").ToString();
            //单位ATM
            ATM_Danwei_Bishu = "0";
            ATM_Danwei_Jine = "0";
            //个人ATM
            //不用计算，全部都计算为个人ATM业务量
            ATM_Geren_Bishu = ATM_Zongliang_Bishu;
            ATM_Geren_Jine = ATM_Zongliang_Jine;


            //ATM转账
            ATM_Zhuanzhang_Bishu = Common.Common.StringYunsuan(ATM_Zhuanzhang_Hangnei_Bishu, ATM_Zhuanzhang_Kuahang_Bishu, "+").ToString();
            ATM_Zhuanzhang_Jine = Common.Common.StringYunsuan(ATM_Zhuanzhang_Hangnei_Jine, ATM_Zhuanzhang_Kuahang_Jine, "+").ToString();
        }

        private void Creat_SAACNTXT_DATA()
        {

            DataSet ds_Saacntxt = new DataSet();
            string SaacntxtCacheNameToUse = string.Format("ds_Saacntxt_{0}", jiezhiRiqi);
            string SaacntxtCacheNameToDelete = string.Format("ds_Saacntxt_{0}", qishiRiqi);

            //根据当前时间，判断是否存在使用的缓存。如果存在，那么直接调用，否则重新生成。
            //同时，判断上一个缓存是否存在，如果存在，那么删除
            //
            if (Cache[SaacntxtCacheNameToDelete] != null)
            {
                Cache[SaacntxtCacheNameToDelete] = null;
            }
            if (Cache[SaacntxtCacheNameToUse] == null)
            {
                ds_Saacntxt = bll_pisa.GetSaacntxtList(qishiRiqi.ToString("yyyyMMdd"), jiezhiRiqi.ToString("yyyyMMdd"), Jigouma);
                Cache[SaacntxtCacheNameToUse] = ds_Saacntxt;
            }
            else
            {
                ds_Saacntxt = Cache[SaacntxtCacheNameToUse] as DataSet;
            }







            //银行卡柜面存现和ATM存现
            //-----[账号410826，卡号不为空，冲正标志：0未冲正，交易类别：1现金，交易渠道：01柜面；贷方发生额：大于0]
            Yinhangka_Cunxian_Guimian_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_CR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG ='01' and SA_CR_AMT>0 ",Kabin)).ToString();
            Yinhangka_Cunxian_Guimian_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_CR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG ='01' and SA_CR_AMT>0 ",Kabin)).ToString();

            //银行卡ATM存现           
            //-----[简单的成为atm存现是不合适的，应该是将所有非柜面的存现都看做atm存现]
            //-----[账号410826，卡号不为空，冲正标志：0未冲正，交易类别：1现金，交易渠道：不是01柜面；贷方发生额：大于0]
            Yinhangka_Cunxian_ATM_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_CR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG <>'01' and SA_CR_AMT>0 ",Kabin)).ToString();
            Yinhangka_Cunxian_ATM_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_CR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG <>'01' and SA_CR_AMT>0 ",Kabin)).ToString();


            //银行卡柜面取现
            //----[账号410826，卡号不为空，冲正标志：0未冲正，交易类别：1现金，交易渠道：01柜面；借方发生额：大于0；]
            Yinhangka_Quxian_Guimian_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG ='01' and SA_DR_AMT>0 ",Kabin)).ToString();
            Yinhangka_Quxian_Guimian_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG ='01' and SA_DR_AMT>0 ", Kabin)).ToString();

            //银行卡ATM取现
            // -----[简单的成为atm取现是不合适的，应该是将所有非柜面的存现都看做atm取现]
            //-----[账号410826，卡号不为空，冲正标志：0未冲正，交易类别：1现金，交易渠道：不为01柜面；借方发生额：大于0；]
            Yinhangka_Quxian_ATM_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG <>'01' and SA_DR_AMT>0 ", Kabin)).ToString();
            Yinhangka_Quxian_ATM_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_CHANNEL_FLAG <>'01' and SA_DR_AMT>0 ", Kabin)).ToString();



            //银行卡本行取现
            //----[账号410826，卡号不为空，冲正标志：0未冲正，交易类别：1现金，操作员：410826%；借方发生额：大于0；]
            Yinhangka_Quxian_Benhang_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_OPR_NO like '{1}%' and SA_DR_AMT>0", Kabin,Jigouma)).ToString();
            Yinhangka_Quxian_Benhang_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_OPR_NO like '{1}%' and SA_DR_AMT>0", Kabin,Jigouma)).ToString();

            //银行卡他行取现
            //----[账号410826，卡号不为空，冲正标志：0未冲正，交易类别：1现金，操作员：不是410826%；借方发生额：大于0；]
            Yinhangka_Quxian_Tahang_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_OPR_NO not like '{1}%' and SA_DR_AMT>0", Kabin,Jigouma)).ToString();
            Yinhangka_Quxian_Tahang_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='1' and SA_OPR_NO not like '{1}%' and SA_DR_AMT>0", Kabin,Jigouma)).ToString();

            //银行卡消费
            //----[账号410826，冲正标志：0为冲正，交易渠道：07POS，交易金额：大于0（消费退回不计入）]
            Yinhangka_Xiaofei_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_TX_AMT)", string.Format(" SA_CHANNEL_FLAG ='07' and SA_TX_AMT>0 ")).ToString();
            Yinhangka_Xiaofei_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_TX_AMT)",string.Format( " SA_CHANNEL_FLAG ='07' and SA_TX_AMT>0 ")).ToString();




            //银行卡行内转账（转出到转行内）
            //[账号410826；卡号：不为空；冲正标志：0未冲正；交易类别：2转账；对方行号：410826%；借方发生额：大于0；]
            Yinhangka_Zhuanzhang_Hangnei_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_OP_BANK_NO like '{1}%' and SA_DR_AMT>0 ", Kabin,Jigouma)).ToString();
            Yinhangka_Zhuanzhang_Hangnei_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_OP_BANK_NO like '{1}%' and SA_DR_AMT>0 ", Kabin,Jigouma)).ToString();



            //银行卡柜面转账
            //-----[账号410826；卡号：不为空；冲正标志：0未冲正；交易类别：2转账；借方发生额：大于0；交易渠道：01柜面]
            Yinhangka_Zhuanzhang_Guimian_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='01'",Kabin)).ToString();
            Yinhangka_Zhuanzhang_Guimian_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='01'", Kabin)).ToString();

            //银行卡ATM转账
            //-----[账号410826；卡号：不为空；冲正标志：0未冲正；交易类别：2转账；借方发生额：大于0；渠道：06ATM]
            Yinhangka_Zhuanzhang_ATM_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='06'", Kabin)).ToString();
            Yinhangka_Zhuanzhang_ATM_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='06'", Kabin)).ToString();

            //银行卡网银转账
            //-----[账号410826；卡号：不为空；冲正标志：0未冲正；交易类别：2转账；借方发生额：大于0；渠道：02网银]
            Yinhangka_Zhuanzhang_Wangyin_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='02'", Kabin)).ToString();
            Yinhangka_Zhuanzhang_Wangyin_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='02'", Kabin)).ToString();

            //手机转账
            //-----[账号410826；卡号：不为空；冲正标志：0未冲正；交易类别：2转账；借方发生额：大于0；渠道：03手机银行]
            Yinhangka_Zhuanzhang_Shouji_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='03'", Kabin)).ToString();
            Yinhangka_Zhuanzhang_Shouji_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_DR_AMT)", string.Format("SA_TX_CRD_NO like '{0}%' and SA_TX_TYP='2' and SA_DR_AMT>0 and  SA_CHANNEL_FLAG ='03'", Kabin)).ToString();



            //转账支票业务量
            Zhipiao_Zhuanzhang_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_TX_AMT)", "SA_DOC_TYP ='0302'").ToString();
            Zhipiao_Zhuanzhang_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_TX_AMT)", "SA_DOC_TYP ='0302'").ToString();
            //现金支票业务量
            Zhipiao_Xianjin_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_TX_AMT)", "SA_DOC_TYP ='0303'").ToString();
            Zhipiao_Xianjin_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_TX_AMT)", "SA_DOC_TYP ='0303'").ToString();

            //银行业存款类金融机构行内支付系统资金流动总量（是否包括行内资金的流动？）
            //银行业存款类金融机构行内支付系统资金流入量
            //----[账号：410826%；冲正标志：0未冲正；贷方发生额：大于0；]
            Hangneizhifu_Zijinliudong_Liuru_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_TX_AMT)", "SA_CR_AMT>0").ToString();
            Hangneizhifu_Zijinliudong_Liuru_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_TX_AMT)", "SA_CR_AMT>0").ToString();
            //银行业存款类金融机构行内支付系统资金流出量
            //----[账号：410826%；冲正标志：0未冲正；借方发生额：大于0；]
            Hangneizhifu_Zijinliudong_Liuchu_Bishu = ds_Saacntxt.Tables[0].Compute("count(SA_TX_AMT)", "SA_DR_AMT>0").ToString();
            Hangneizhifu_Zijinliudong_Liuchu_Jine = ds_Saacntxt.Tables[0].Compute("sum(SA_TX_AMT)", "SA_DR_AMT>0").ToString();

            //汇总数据全部放在最后
            //银行卡存现
            Yinhangka_Cunxian_Bishu = Common.Common.StringYunsuan(Yinhangka_Cunxian_Guimian_Bishu, Yinhangka_Cunxian_ATM_Bishu, "+").ToString();
            Yinhangka_Cunxian_Jine = Common.Common.StringYunsuan(Yinhangka_Cunxian_Guimian_Jine, Yinhangka_Cunxian_ATM_Jine, "+").ToString();


            //银行卡取现
            Yinhangka_Quxian_Bishu = Common.Common.StringYunsuan(Yinhangka_Quxian_Guimian_Bishu, Yinhangka_Quxian_ATM_Bishu, "+").ToString();
            Yinhangka_Quxian_Jine = Common.Common.StringYunsuan(Yinhangka_Quxian_Guimian_Jine, Yinhangka_Quxian_ATM_Jine, "+").ToString();

            //银行卡转账
            //----此项内容应该进行反向求解。
            //----[转账=柜面转账+ATM转账+网银转账+手机银行转账，然后再通过计算得来的银行卡转账，减去行内转账，得出跨行转账]
            Yinhangka_Zhuanzhang_Bishu = (Common.Common.StringYunsuan(Yinhangka_Zhuanzhang_Guimian_Bishu, Yinhangka_Zhuanzhang_ATM_Bishu, "+") + Common.Common.StringYunsuan(Yinhangka_Zhuanzhang_Wangyin_Bishu, Yinhangka_Zhuanzhang_Shouji_Bishu, "+")).ToString();
            Yinhangka_Zhuanzhang_Jine = (Common.Common.StringYunsuan(Yinhangka_Zhuanzhang_Guimian_Jine, Yinhangka_Zhuanzhang_ATM_Jine, "+") + Common.Common.StringYunsuan(Yinhangka_Zhuanzhang_Wangyin_Jine, Yinhangka_Zhuanzhang_Shouji_Jine, "+")).ToString();


            //银行卡跨行转账    
            //-----[银行卡转账减去银行卡行内转账]
            Yinhangka_Zhuanzhang_Kuahang_Bishu = Common.Common.StringYunsuan(Yinhangka_Zhuanzhang_Bishu, Yinhangka_Zhuanzhang_Hangnei_Bishu, "-").ToString();
            Yinhangka_Zhuanzhang_Kuahang_Jine = Common.Common.StringYunsuan(Yinhangka_Zhuanzhang_Jine, Yinhangka_Zhuanzhang_Hangnei_Jine, "-").ToString();

            //银行卡业务量总量
            Yinhangka_Zongliang_Bishu = (Common.Common.StringYunsuan(Yinhangka_Cunxian_Bishu, Yinhangka_Quxian_Bishu, "+") + Common.Common.StringYunsuan(Yinhangka_Xiaofei_Bishu, Yinhangka_Zhuanzhang_Bishu, "+")).ToString();
            Yinhangka_Zongliang_Jine = (Common.Common.StringYunsuan(Yinhangka_Cunxian_Jine, Yinhangka_Quxian_Jine, "+") + Common.Common.StringYunsuan(Yinhangka_Xiaofei_Jine, Yinhangka_Zhuanzhang_Jine, "+")).ToString();


            //支票业务总量
            Zhipiao_Zongliang_Bishu = Common.Common.StringYunsuan(Zhipiao_Xianjin_Bishu, Zhipiao_Zhuanzhang_Bishu, "+").ToString();
            Zhipiao_Zongliang_Jine = Common.Common.StringYunsuan(Zhipiao_Xianjin_Jine, Zhipiao_Zhuanzhang_Jine, "+").ToString();

            //行内支付系统资金流动总量
            Hangneizhifu_Zijinliudong_zongliang_Bishu = Common.Common.StringYunsuan(Hangneizhifu_Zijinliudong_Liuchu_Bishu, Hangneizhifu_Zijinliudong_Liuru_Bishu, "+").ToString();
            Hangneizhifu_Zijinliudong_zongliang_Jine = Common.Common.StringYunsuan(Hangneizhifu_Zijinliudong_Liuru_Jine, Hangneizhifu_Zijinliudong_Liuchu_Jine, "+").ToString();
        }
    }
}