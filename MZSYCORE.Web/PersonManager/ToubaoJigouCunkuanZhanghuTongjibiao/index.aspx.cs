using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tools;

namespace MZSYCORE.Web.PersonManager.ToubaoJigouCunkuanZhanghuTongjibiao
{
    public partial class index : Tools.BasePage
    {
        BLL.BLL_ToubaoJigouCunkuanZhanghuTongjibiao bll_ToubaoJigouCunkuanZhanghuTongjibiao = new BLL.BLL_ToubaoJigouCunkuanZhanghuTongjibiao();

        //定义相关的dic
        public Dictionary<string, decimal> dicGerenCunkuan = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> dicDanweiCunkuan = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> dicCaizhengxingCunkuan = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> dicGaoguanCunkuan = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> dicOtherCunkuan = new Dictionary<string, decimal>();

        //定义筛选的函数
        public Func<decimal, decimal> func50yishangsum = x =>
        {
            if (x > 500000)
            {
                return x;
            }
            else
            {
                return 0;
            }
        };
        public Func<decimal, bool> fun50yishangcount = x => { return x > 500000; };
        public Func<decimal, bool> fun50yixiacount = x => { return x <= 500000; };
        public Func<decimal, decimal> func50yixiasum = x =>
        {
            if (x > 500000)
            {
                return 0;
            }
            else
            {
                return x;
            }
        };

        //定义相关字段供查询
        public int JingneiCunkuanHushu = 0;
        public int JingneiCunkuanJine = 0;
        public int JingneiGerenCunkuanHushu = 0;
        public int JingneiGerenCunkuanJine = 0;
        public int JingneiDanweiCunkuanHushu = 0;
        public int JingneiDanweiCunkuanJine = 0;
        public int JingneiCaizhengxingCunkuanHushu = 0;
        public int JingneiCaizhengxingCunkuanJine = 0;
        public int GaoguanCunkuanHushu = 0;
        public int GaoguanCunkuanJine = 0;

        public int JingneiCunkuanHushu50wanyishang = 0;
        public int JingneiCunkuanJine50wanyishang = 0;
        public int JingneiGerenCunkuanHushu50wanyishang = 0;
        public int JingneiGerenCunkuanJine50wanyishang = 0;
        public int JingneiDanweiCunkuanHushu50wanyishang = 0;
        public int JingneiDanweiCunkuanJine50wanyishang = 0;
        public int JingneiCaizhengxingCunkuanHushu50wanyishang = 0;
        public int JingneiCaizhengxingCunkuanJine50wanyishang = 0;
        public int GaoguanCunkuanHushu50wanyishang = 0;
        public int GaoguanCunkuanJine50wanyishang = 0;

        public int JingneiCunkuanHushu50wanyixia = 0;
        public int JingneiCunkuanJine50wanyixia = 0;
        public int JingneiGerenCunkuanHushu50wanyixia = 0;
        public int JingneiGerenCunkuanJine50wanyixia = 0;
        public int JingneiDanweiCunkuanHushu50wanyixia = 0;
        public int JingneiDanweiCunkuanJine50wanyixia = 0;
        public int JingneiCaizhengxingCunkuanHushu50wanyixia = 0;
        public int JingneiCaizhengxingCunkuanJine50wanyixia = 0;
        public int GaoguanCunkuanHushu50wanyixia = 0;
        public int GaoguanCunkuanJine50wanyixia = 0;

        public int BeibaoxianCunkuan = 0;
        public int ShoubaoCunkuan = 0;
        public int YingjiaonaBaofeiShue = 0;


        //106622004855	卞训勇
        //133346360970	温国光
        //133346368753	王伟
        //133356674864	陈以光
        //133369250091	丹程
        //106622017012  刘丰
        public List<string> lstGaoguanKehuhao = new List<string>() { "106622004855", "133346360970", "133346368753", "133356674864", "133369250091", "106622017012" };
        protected void Page_Load(object sender, EventArgs e)
        {

            //如果是首次载入，那么计算查询出数据日期
            if (!IsPostBack)
            {
                if (model_employee_info.name == "宋高磊" || model_employee_info.name == "周东杰")
                {

                    Response.Write("<script lanague='javascript'>alert('磊行长，添的痒不痒？')</script>");

                }
                lblShujuRiqi.Text = bll_ToubaoJigouCunkuanZhanghuTongjibiao.GetShujuRiqi(Web_Constant.Jigouma);
                lblCunkuanZonge.Text = bll_ToubaoJigouCunkuanZhanghuTongjibiao.GetCunkuanZonge(Web_Constant.Jigouma);
            }

        }

        //点击计算按钮，计算出报表数据
        protected void btnJisuan_Click(object sender, EventArgs e)
        {
            ///整体思路：
            ///0.获取当前所有的数据集
            ///1.根据科目号，判断出存款种类，按照个人存款、单位存款、财政性存款划分
            ///     为每个存款种类创建一个数据字典，用来保存客户号和存款本息合
            ///2.划分之后，分别对各个存款种类，进行利息计算；存款种类分为活期，定期，定活两便，通知存款，零存整取。
            ///3.利息计算主要为天数计算。
            ///


            List<Model.Model_LSB_CKZH> lstModel = new List<Model.Model_LSB_CKZH>();
            lstModel = bll_ToubaoJigouCunkuanZhanghuTongjibiao.GetModelList(Web_Constant.Jigouma);

            //循环处理数据集：先计算本息和，在归类到专门的分类

            //foreach (Model.Model_LSB_CKZH model in lstModel)
            for (int i = 0; i < lstModel.Count; i++)
            {
                //计算本息
                JisuanBenxihe(lstModel[i]);
                //按照科目添加到不同的dic字典中
                Adddic(lstModel[i]);
                Debug.WriteLine(i);
            }

            //将公共字段赋值，提供给前端页面显示
            BindData();


        }

        private void BindData()
        {
            //个人存款
            JingneiGerenCunkuanHushu = dicGerenCunkuan.Count;
            JingneiGerenCunkuanJine = (int)dicGerenCunkuan.Values.Sum();
            JingneiGerenCunkuanHushu50wanyixia = dicGerenCunkuan.Values.Count(fun50yixiacount);
            JingneiGerenCunkuanHushu50wanyishang = JingneiGerenCunkuanHushu - JingneiGerenCunkuanHushu50wanyixia;
            JingneiGerenCunkuanJine50wanyixia = (int)dicGerenCunkuan.Values.Sum(func50yixiasum);
            JingneiGerenCunkuanJine50wanyishang = JingneiGerenCunkuanJine - JingneiGerenCunkuanJine50wanyixia;

            //单位存款
            JingneiDanweiCunkuanHushu = dicDanweiCunkuan.Count;
            JingneiDanweiCunkuanJine = (int)dicDanweiCunkuan.Values.Sum();
            JingneiDanweiCunkuanHushu50wanyixia = dicDanweiCunkuan.Values.Count(fun50yixiacount);
            JingneiDanweiCunkuanHushu50wanyishang = JingneiDanweiCunkuanHushu - JingneiDanweiCunkuanHushu50wanyixia;
            JingneiDanweiCunkuanJine50wanyixia = (int)dicDanweiCunkuan.Values.Sum(func50yixiasum);
            JingneiDanweiCunkuanJine50wanyishang = JingneiDanweiCunkuanJine - JingneiDanweiCunkuanJine50wanyixia;


            //代理财政性存款
            JingneiCaizhengxingCunkuanHushu = dicCaizhengxingCunkuan.Count;
            JingneiCaizhengxingCunkuanJine = (int)dicCaizhengxingCunkuan.Values.Sum();
            JingneiCaizhengxingCunkuanHushu50wanyixia = dicCaizhengxingCunkuan.Values.Count(fun50yixiacount);
            JingneiCaizhengxingCunkuanHushu50wanyishang = JingneiCaizhengxingCunkuanHushu - JingneiCaizhengxingCunkuanHushu50wanyixia;
            JingneiCaizhengxingCunkuanJine50wanyixia = (int)dicCaizhengxingCunkuan.Values.Sum(func50yixiasum);
            JingneiCaizhengxingCunkuanJine50wanyishang = JingneiCaizhengxingCunkuanJine - JingneiCaizhengxingCunkuanJine50wanyixia;

            //境内存款汇总
            JingneiCunkuanHushu = JingneiGerenCunkuanHushu + JingneiDanweiCunkuanHushu + JingneiCaizhengxingCunkuanHushu;
            JingneiCunkuanJine = JingneiGerenCunkuanJine + JingneiDanweiCunkuanJine + JingneiCaizhengxingCunkuanJine;
            JingneiCunkuanHushu50wanyixia = JingneiGerenCunkuanHushu50wanyixia + JingneiDanweiCunkuanHushu50wanyixia + JingneiCaizhengxingCunkuanHushu50wanyixia;
            JingneiCunkuanJine50wanyixia = JingneiGerenCunkuanJine50wanyixia + JingneiDanweiCunkuanJine50wanyixia + JingneiCaizhengxingCunkuanJine50wanyixia;
            JingneiCunkuanHushu50wanyishang = JingneiGerenCunkuanHushu50wanyishang + JingneiDanweiCunkuanHushu50wanyishang + JingneiCaizhengxingCunkuanHushu50wanyishang;
            JingneiCunkuanJine50wanyishang = JingneiGerenCunkuanJine50wanyishang + JingneiDanweiCunkuanJine50wanyishang + JingneiCaizhengxingCunkuanJine50wanyishang;


            //高管存款
            dicGaoguanCunkuan = bll_ToubaoJigouCunkuanZhanghuTongjibiao.GetGaoguancunkuan(dicGerenCunkuan, lstGaoguanKehuhao);

            GaoguanCunkuanHushu = dicGaoguanCunkuan.Count;
            GaoguanCunkuanJine = (int)dicGaoguanCunkuan.Values.Sum();
            GaoguanCunkuanHushu50wanyixia = dicGaoguanCunkuan.Values.Count(fun50yixiacount);
            GaoguanCunkuanHushu50wanyishang = GaoguanCunkuanHushu - GaoguanCunkuanHushu50wanyixia;
            GaoguanCunkuanJine50wanyixia = (int)dicGaoguanCunkuan.Values.Sum(func50yixiasum);
            GaoguanCunkuanJine50wanyishang = GaoguanCunkuanJine - GaoguanCunkuanJine50wanyixia;




            //附报
            //被保险存款=境内存款-非存款类金融机构存款+（境外存款-境外同业存放）-高管存款
            BeibaoxianCunkuan = JingneiCunkuanJine - GaoguanCunkuanJine;
            //受保存款=（50万以下的金额）（个人存款+单位存款+财政性存款+境外个人存款+境外单位存款-高管存款）+（50万以上的户数）（个人存款+单位存款+财政性存款+境外个人存款+境外单位存款-高管存款）*500000
            ShoubaoCunkuan = (JingneiGerenCunkuanJine50wanyixia + JingneiDanweiCunkuanJine50wanyixia + JingneiCaizhengxingCunkuanJine50wanyixia - GaoguanCunkuanJine50wanyixia) + (JingneiGerenCunkuanHushu50wanyishang + JingneiDanweiCunkuanHushu50wanyishang + JingneiCaizhengxingCunkuanHushu50wanyishang - GaoguanCunkuanHushu50wanyishang) * 500000;

            if (dicOtherCunkuan.Count != 0)
            {
                string error = "";
                foreach  (var item in dicOtherCunkuan)
                {
                   
                   error += string.Format("科目号：{0},余额：{1}；  ",item.Key,item.Value);
                }
           
               
                lblJiaoyan.Text = "可能有错误，代码：" + error;

            }

        }

        /// <summary>
        /// 存款种类分类
        /// </summary>
        /// <param name="model"></param>
        private void Adddic(Model.Model_LSB_CKZH model)
        {
            switch (model.KMH.Substring(0, 4))
            {
                case "2001":
                    AdddicCunkuan(dicDanweiCunkuan, model);
                    break;
                case "2002":
                    AdddicCunkuan(dicDanweiCunkuan, model);
                    break;
                case "2003":
                    AdddicCunkuan(dicGerenCunkuan, model);
                    break;
                case "2004":
                    AdddicCunkuan(dicGerenCunkuan, model);
                    break;
                case "2005":
                    AdddicCunkuan(dicGerenCunkuan, model);
                    break;
                case "2006":
                    AdddicCunkuan(dicCaizhengxingCunkuan, model);
                    break;
                case "2014":
                    AdddicCunkuan(dicGerenCunkuan, model);
                    break;
                case "2241":
                    AdddicCunkuan(dicDanweiCunkuan, model);
                    break;
                default:
                    dicOtherCunkuan.Add(model.KMH, (decimal)model.ZHYE);
                    //AdddicCunkuan(dicOtherCunkuan, model);
                    break;
            }

          

        }






        /// <summary>
        /// 向数据字典中添加相关数据。如果存在该客户号，那么合并存款。如果不存在，那么直接添加
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="model"></param>
        public void AdddicCunkuan(Dictionary<string, decimal> dic, Model.Model_LSB_CKZH model)
        {
            if (dic.ContainsKey(model.KHH))
            {
                dic[model.KHH] = dic[model.KHH] + (decimal)model.ZHYE;
            }
            else
            {
                dic.Add(model.KHH, (decimal)model.ZHYE);
            }
        }

        /// <summary>
        /// 计算数据模型的本息和
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void JisuanBenxihe(Model.Model_LSB_CKZH model)
        {
            ///整体思路：
            ///1.根据期限字段，判断是活期，还是定期，还是通知七天存款
            ///    如果期限为D000，那么根据产品号来判断是活期或者是定活两便、贷款保证金
            ///         活期暂且不提吧，因为没有搞懂
            ///         保证金存款和定活两便，也暂不提
            ///         总之，期限为D0000的，均不考虑利息
            ///     如果期限为D007或D0001，那么为通知存款，计算公式为：账户余额*利率/360*（当前日期-起息日期）
            ///     如果期限为Mxxx，是定期存款。默认全部为自动转存
            ///
            ///经过此方法处理之后，模型的账户余额变更为账户本金+计提利息之和


            DateTime qishiRiqi = ConventToDateTime.ConventStringToDateTime(model.QXRQ.ToString());
            DateTime jieshuRiqi = ConventToDateTime.ConventStringToDateTime(lblShujuRiqi.Text);
            if (jieshuRiqi.Day <= 10)
            {
                jieshuRiqi = new DateTime(jieshuRiqi.Year, jieshuRiqi.Month, 10);
            }
            else if (jieshuRiqi.Day <= 20)
            {
                jieshuRiqi = new DateTime(jieshuRiqi.Year, jieshuRiqi.Month, 20);
            }
            else
            {
                jieshuRiqi = new DateTime(jieshuRiqi.Year, jieshuRiqi.Month + 1, 1).AddDays(-1);
            }

            if (model.QX == "D000")
            {
                // 如果为活期、定活两便、保证金存款，暂不计算利息。不做任何操作
                return;
            }
            else if (model.QX == "D001" || model.QX == "D007")
            {
                //如果为通知存款                           

            }
            else
            {
                //定义定存月数
                int dingcunYueshu = Convert.ToInt32(model.QX.Substring(2, 2));
                while (qishiRiqi.AddMonths(dingcunYueshu) < DateTime.Now)
                {
                    if (model.KHJE == model.ZHYE)
                    {
                        jieshuRiqi = qishiRiqi.AddMonths(dingcunYueshu);
                    }

                    qishiRiqi = qishiRiqi.AddMonths(dingcunYueshu);

                }

            }
            model.ZHYE = CalInterest.CalJitiLixi((decimal)model.ZHYE, (decimal)model.NLL, qishiRiqi, DateTime.Now);

        }


    }
}