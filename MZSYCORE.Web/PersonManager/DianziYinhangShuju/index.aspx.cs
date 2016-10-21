using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.PersonManager.DianziYinhangShuju
{

    public partial class index : System.Web.UI.Page
    {


        class TempModel
        {
            public string JGM { get; set; }//机构码
            public int JYBS { get; set; }//交易笔数
            public decimal JYJE { get; set; }//交易金额
            public int JYZHS { get; set; }//交易账户数
        }

        protected Dictionary<string, string> dic = new Dictionary<string, string>();
        BLL.BLL_CaiwubuSuoxuShuju bll_CaiwubuSuoxuShuju = new BLL.BLL_CaiwubuSuoxuShuju();
        BLL.BLL_DianziYinhangShuju bll_DianziYinhangShuju = new BLL.BLL_DianziYinhangShuju();
        protected void Page_Load(object sender, EventArgs e)
        {
            //各单位手机银行户数
            dic.Add("sjyhhs_yyb", "没有相关数据");
            dic.Add("sjyhhs_xgzh", "没有相关数据");
            dic.Add("sjyhhs_hgzh", "没有相关数据");
            dic.Add("sjyhhs_nzzh", "没有相关数据");
            dic.Add("sjyhhs_mzsyczyh", "没有相关数据");
            //各单位个人网银户数
            dic.Add("grwyhs_yyb", "没有相关数据");
            dic.Add("grwyhs_xgzh", "没有相关数据");
            dic.Add("grwyhs_hgzh", "没有相关数据");
            dic.Add("grwyhs_nzzh", "没有相关数据");
            dic.Add("grwyhs_mzsyczyh", "没有相关数据");
            //各单位企业网银户数
            dic.Add("qywyhs_yyb", "没有相关数据");
            dic.Add("qywyhs_xgzh", "没有相关数据");
            dic.Add("qywyhs_hgzh", "没有相关数据");
            dic.Add("qywyhs_nzzh", "没有相关数据");
            dic.Add("qywyhs_mzsyczyh", "没有相关数据");

            //各单位银行卡户数
            dic.Add("yhkhs_yyb", "没有相关数据");
            dic.Add("yhkhs_xgzh", "没有相关数据");
            dic.Add("yhkhs_hgzh", "没有相关数据");
            dic.Add("yhkhs_nzzh", "没有相关数据");
            dic.Add("yhkhs_mzsyczyh", "没有相关数据");
            //各单位银行卡有效户户数
            dic.Add("yhkyxhhs_yyb", "没有相关数据");
            dic.Add("yhkyxhhs_xgzh", "没有相关数据");
            dic.Add("yhkyxhhs_hgzh", "没有相关数据");
            dic.Add("yhkyxhhs_nzzh", "没有相关数据");
            dic.Add("yhkyxhhs_mzsyczyh", "没有相关数据");

            //个人网银交易情况
            dic.Add("grwyjybs_yyb", "没有相关数据");
            dic.Add("grwyjyje_yyb", "没有相关数据");
            dic.Add("grwyjyzhs_yyb", "没有相关数据");
            dic.Add("grwyjyzhzb_yyb", "没有相关数据");

            dic.Add("grwyjybs_xgzh", "没有相关数据");
            dic.Add("grwyjyje_xgzh", "没有相关数据");
            dic.Add("grwyjyzhs_xgzh", "没有相关数据");
            dic.Add("grwyjyzhzb_xgzh", "没有相关数据");

            dic.Add("grwyjybs_hgzh", "没有相关数据");
            dic.Add("grwyjyje_hgzh", "没有相关数据");
            dic.Add("grwyjyzhs_hgzh", "没有相关数据");
            dic.Add("grwyjyzhzb_hgzh", "没有相关数据");

            dic.Add("grwyjybs_nzzh", "没有相关数据");
            dic.Add("grwyjyje_nzzh", "没有相关数据");
            dic.Add("grwyjyzhs_nzzh", "没有相关数据");
            dic.Add("grwyjyzhzb_nzzh", "没有相关数据");


            dic.Add("grwyjybs_mzsyczyh", "没有相关数据");
            dic.Add("grwyjyje_mzsyczyh", "没有相关数据");
            dic.Add("grwyjyzhs_mzsyczyh", "没有相关数据");
            dic.Add("grwyjyzhzb_mzsyczyh", "没有相关数据");


            //企业网银交易情况
            dic.Add("qywyjybs_yyb", "没有相关数据");
            dic.Add("qywyjyje_yyb", "没有相关数据");
            dic.Add("qywyjyzhs_yyb", "没有相关数据");
            dic.Add("qywyjyzhzb_yyb", "没有相关数据");

            dic.Add("qywyjybs_xgzh", "没有相关数据");
            dic.Add("qywyjyje_xgzh", "没有相关数据");
            dic.Add("qywyjyzhs_xgzh", "没有相关数据");
            dic.Add("qywyjyzhzb_xgzh", "没有相关数据");

            dic.Add("qywyjybs_hgzh", "没有相关数据");
            dic.Add("qywyjyje_hgzh", "没有相关数据");
            dic.Add("qywyjyzhs_hgzh", "没有相关数据");
            dic.Add("qywyjyzhzb_hgzh", "没有相关数据");

            dic.Add("qywyjybs_nzzh", "没有相关数据");
            dic.Add("qywyjyje_nzzh", "没有相关数据");
            dic.Add("qywyjyzhs_nzzh", "没有相关数据");
            dic.Add("qywyjyzhzb_nzzh", "没有相关数据");

            dic.Add("qywyjybs_mzsyczyh", "没有相关数据");
            dic.Add("qywyjyje_mzsyczyh", "没有相关数据");
            dic.Add("qywyjyzhs_mzsyczyh", "没有相关数据");
            dic.Add("qywyjyzhzb_mzsyczyh", "没有相关数据");


            //手机银行交易情况
            dic.Add("sjyhjybs_yyb", "没有相关数据");
            dic.Add("sjyhjyje_yyb", "没有相关数据");
            dic.Add("sjyhjyzhs_yyb", "没有相关数据");
            dic.Add("sjyhjyzhzb_yyb", "没有相关数据");

            dic.Add("sjyhjybs_xgzh", "没有相关数据");
            dic.Add("sjyhjyje_xgzh", "没有相关数据");
            dic.Add("sjyhjyzhs_xgzh", "没有相关数据");
            dic.Add("sjyhjyzhzb_xgzh", "没有相关数据");

            dic.Add("sjyhjybs_hgzh", "没有相关数据");
            dic.Add("sjyhjyje_hgzh", "没有相关数据");
            dic.Add("sjyhjyzhs_hgzh", "没有相关数据");
            dic.Add("sjyhjyzhzb_hgzh", "没有相关数据");

            dic.Add("sjyhjybs_nzzh", "没有相关数据");
            dic.Add("sjyhjyje_nzzh", "没有相关数据");
            dic.Add("sjyhjyzhs_nzzh", "没有相关数据");
            dic.Add("sjyhjyzhzb_nzzh", "没有相关数据");

            dic.Add("sjyhjybs_mzsyczyh", "没有相关数据");
            dic.Add("sjyhjyje_mzsyczyh", "没有相关数据");
            dic.Add("sjyhjyzhs_mzsyczyh", "没有相关数据");
            dic.Add("sjyhjyzhzb_mzsyczyh", "没有相关数据");

        }

        protected void btn_Jisuan_Click(object sender, EventArgs e)
        {
            string tongjiRiqiQian = this.tbox_DateQian.Text;
            string tongjiRiqiHou = this.tbox_DateHou.Text;
            BindDianziyinhangShuju(Common.Common.ConventStringToDateTime(tongjiRiqiHou).AddDays(1).ToString("yyyy-MM-dd"));//绑定电子银行户数情况
            BindYinghangkaHushu(tongjiRiqiHou.Replace("-", ""));//绑定银行卡户数
            BindYinhangkaYouxiaohuHushu();//绑定银行卡有效户户数
            BindGerenwangyinJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);//绑定个人网银交易情况数据
            BindQiyewangyinJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);//绑定企业网银交易情况数据
            BindShoujiyinhangJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);//绑定手机银行交易情况数据
            Context.Response.Write("<script language=javascript>alert('数据获取成功，如有未显示部分表示数据未到达，请稍后再查询！');</script>");

        }

        private void BindShoujiyinhangJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            DataSet ds = bll_DianziYinhangShuju.GetShoujiYinhangJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);
            if (ds != null)
            {
                List<TempModel> lst = BindToModelLst(ds.Tables[0]);
                int jybsSum = 0, jyzhsSum = 0;
                decimal jyjeSum = 0;
                foreach (TempModel model in lst)
                {
                    jybsSum += model.JYBS;
                    jyzhsSum += model.JYZHS;
                    jyjeSum += model.JYJE;
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {       
                        dic["sjyhjybs_yyb"] = model.JYBS.ToString();
                        dic["sjyhjyje_yyb"] = model.JYJE.ToString();
                        dic["sjyhjyzhs_yyb"] = model.JYZHS.ToString();
                        dic["sjyhjyzhzb_yyb"] = ((decimal)model.JYZHS / decimal.Parse(dic["sjyhhs_yyb"]) * 100).ToString("f2") + "%";
                    }

                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["sjyhjybs_xgzh"] = model.JYBS.ToString();
                        dic["sjyhjyje_xgzh"] = model.JYJE.ToString();
                        dic["sjyhjyzhs_xgzh"] = model.JYZHS.ToString();
                        dic["sjyhjyzhzb_xgzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["sjyhhs_xgzh"]) * 100).ToString("f2") + "%";
                    }


                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["sjyhjybs_hgzh"] = model.JYBS.ToString();
                        dic["sjyhjyje_hgzh"] = model.JYJE.ToString();
                        dic["sjyhjyzhs_hgzh"] = model.JYZHS.ToString();
                        dic["sjyhjyzhzb_hgzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["sjyhhs_hgzh"]) * 100).ToString("f2") + "%";
                    }

                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["sjyhjybs_nzzh"] = model.JYBS.ToString();
                        dic["sjyhjyje_nzzh"] = model.JYJE.ToString();
                        dic["sjyhjyzhs_nzzh"] = model.JYZHS.ToString();
                        dic["sjyhjyzhzb_nzzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["sjyhhs_nzzh"]) * 100).ToString("f2") + "%";
                    }
                }

                dic["sjyhjybs_mzsyczyh"] = jybsSum.ToString();
                dic["sjyhjyje_mzsyczyh"] = jyjeSum.ToString();
                dic["sjyhjyzhs_mzsyczyh"] = jyzhsSum.ToString();
                dic["sjyhjyzhzb_mzsyczyh"] = ((decimal)jyzhsSum / decimal.Parse(dic["sjyhhs_mzsyczyh"]) * 100).ToString("f2") + "%";
            }
        }

        private void BindQiyewangyinJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            DataSet ds = bll_DianziYinhangShuju.GetQiyewangyinJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);
            if (ds != null)
            {
                List<TempModel> lst = BindToModelLst(ds.Tables[0]);
                int jybsSum = 0, jyzhsSum = 0;
                decimal jyjeSum = 0;
                foreach (TempModel model in lst)
                {
                    jybsSum += model.JYBS;
                    jyzhsSum += model.JYZHS;
                    jyjeSum += model.JYJE;
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["qywyjybs_yyb"] = model.JYBS.ToString();
                        dic["qywyjyje_yyb"] = model.JYJE.ToString();
                        dic["qywyjyzhs_yyb"] = model.JYZHS.ToString();
                        dic["qywyjyzhzb_yyb"] = ((decimal)model.JYZHS / decimal.Parse(dic["qywyhs_yyb"]) * 100).ToString("f2") + "%";
                    }

                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["qywyjybs_xgzh"] = model.JYBS.ToString();
                        dic["qywyjyje_xgzh"] = model.JYJE.ToString();
                        dic["qywyjyzhs_xgzh"] = model.JYZHS.ToString();
                        dic["qywyjyzhzb_xgzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["qywyhs_xgzh"]) * 100).ToString("f2") + "%";
                    }


                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["qywyjybs_hgzh"] = model.JYBS.ToString();
                        dic["qywyjyje_hgzh"] = model.JYJE.ToString();
                        dic["qywyjyzhs_hgzh"] = model.JYZHS.ToString();
                        dic["qywyjyzhzb_hgzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["qywyhs_hgzh"]) * 100).ToString("f2") + "%";
                    }

                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["qywyjybs_nzzh"] = model.JYBS.ToString();
                        dic["qywyjyje_nzzh"] = model.JYJE.ToString();
                        dic["qywyjyzhs_nzzh"] = model.JYZHS.ToString();
                        dic["qywyjyzhzb_nzzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["qywyhs_nzzh"]) * 100).ToString("f2") + "%";
                    }
                }

                dic["qywyjybs_mzsyczyh"] = jybsSum.ToString();
                dic["qywyjyje_mzsyczyh"] = jyjeSum.ToString();
                dic["qywyjyzhs_mzsyczyh"] = jyzhsSum.ToString();
                dic["qywyjyzhzb_mzsyczyh"] = ((decimal)jyzhsSum / decimal.Parse(dic["qywyhs_mzsyczyh"]) * 100).ToString("f2") + "%";
            }
        }

        private void BindGerenwangyinJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            DataSet ds = bll_DianziYinhangShuju.GetGerenwangyinJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);
            if (ds != null)
            {
                List<TempModel> lst = BindToModelLst(ds.Tables[0]);
                int jybsSum = 0, jyzhsSum = 0;
                decimal jyjeSum = 0;
                foreach (TempModel model in lst)
                {
                    jybsSum += model.JYBS;
                    jyzhsSum += model.JYZHS;
                    jyjeSum += model.JYJE;
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["grwyjybs_yyb"] = model.JYBS.ToString();
                        dic["grwyjyje_yyb"] = model.JYJE.ToString();
                        dic["grwyjyzhs_yyb"] = model.JYZHS.ToString();
                        dic["grwyjyzhzb_yyb"] = ((decimal)model.JYZHS / decimal.Parse(dic["grwyhs_yyb"]) * 100).ToString("f2") + "%";
                    }

                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["grwyjybs_xgzh"] = model.JYBS.ToString();
                        dic["grwyjyje_xgzh"] = model.JYJE.ToString();
                        dic["grwyjyzhs_xgzh"] = model.JYZHS.ToString();
                        dic["grwyjyzhzb_xgzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["grwyhs_xgzh"]) * 100).ToString("f2") + "%";
                    }


                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["grwyjybs_hgzh"] = model.JYBS.ToString();
                        dic["grwyjyje_hgzh"] = model.JYJE.ToString();
                        dic["grwyjyzhs_hgzh"] = model.JYZHS.ToString();
                        dic["grwyjyzhzb_hgzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["grwyhs_hgzh"]) * 100).ToString("f2") + "%";
                    }

                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["grwyjybs_nzzh"] = model.JYBS.ToString();
                        dic["grwyjyje_nzzh"] = model.JYJE.ToString();
                        dic["grwyjyzhs_nzzh"] = model.JYZHS.ToString();
                        dic["grwyjyzhzb_nzzh"] = ((decimal)model.JYZHS / decimal.Parse(dic["grwyhs_nzzh"]) * 100).ToString("f2") + "%";
                    }
                }

                dic["grwyjybs_mzsyczyh"] = jybsSum.ToString();
                dic["grwyjyje_mzsyczyh"] = jyjeSum.ToString();
                dic["grwyjyzhs_mzsyczyh"] = jyzhsSum.ToString();
                dic["grwyjyzhzb_mzsyczyh"] = ((decimal)jyzhsSum / decimal.Parse(dic["grwyhs_mzsyczyh"]) * 100).ToString("f2") + "%";
            }


        }


        private List<TempModel> BindToModelLst(DataTable dt)
        {
            List<TempModel> lst = new List<TempModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TempModel tm = new TempModel();
                if (dt.Rows[i] != null)
                {
                    if (dt.Rows[i]["JGM"] != null)
                    {
                        tm.JGM = dt.Rows[i]["JGM"].ToString();
                    }
                    if (dt.Rows[i]["JYBS"] != null)
                    {
                        tm.JYBS = int.Parse(dt.Rows[i]["JYBS"].ToString());
                    }
                    if (dt.Rows[i]["JYJE"] != null)
                    {
                        tm.JYJE = decimal.Parse(dt.Rows[i]["JYJE"].ToString());
                    }
                    if (dt.Rows[i]["JYZHS"] != null)
                    {
                        tm.JYZHS = int.Parse(dt.Rows[i]["JYZHS"].ToString());
                    }
                }
                lst.Add(tm);
            }

            return lst;
        }





        //绑定银行卡户数
        private void BindYinghangkaHushu(string tongjiRiqi)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_CaiwubuSuoxuShuju.GetYinhangkaCountModelList(tongjiRiqi);
            decimal count = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["yhkhs_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["yhkhs_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["yhkhs_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["yhkhs_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["yhkhs_mzsyczyh"] = count.ToString();
                    }
                }
            }
        }


        /// <summary>
        /// 绑定电子银行数据
        /// </summary>
        /// <param name="tongjiRiqi"></param>
        private void BindDianziyinhangShuju(string tongjiRiqi)
        {
            ///绑定手机银行，个人网银，企业网银开户数据
            BindSJYH(tongjiRiqi);
            BindGRWY(tongjiRiqi);
            BindQYWY(tongjiRiqi);
        }


        private void BindQYWY(string tongjiRiqi)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_CaiwubuSuoxuShuju.GetCountQYWY(tongjiRiqi);
            decimal count = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["qywyhs_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["qywyhs_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["qywyhs_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["qywyhs_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["qywyhs_mzsyczyh"] = count.ToString();
                    }
                }

            }
        }

        private void BindGRWY(string tongjiRiqi)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_CaiwubuSuoxuShuju.GetCount_GRWY(tongjiRiqi);
            decimal count = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["grwyhs_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["grwyhs_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["grwyhs_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["grwyhs_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["grwyhs_mzsyczyh"] = count.ToString();
                    }
                }

            }

        }

        private void BindSJYH(string tongjiRiqi)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_CaiwubuSuoxuShuju.GetCount_SJYH(tongjiRiqi);
            decimal count = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["sjyhhs_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["sjyhhs_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["sjyhhs_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["sjyhhs_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["sjyhhs_mzsyczyh"] = count.ToString();
                    }
                }

            }
        }

        /// <summary>
        /// 绑定银行卡有效户数
        /// </summary>
        private void BindYinhangkaYouxiaohuHushu()
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_DianziYinhangShuju.GetYinhangkaYouxiaohuHushuLst();
            decimal count = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["yhkyxhhs_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["yhkyxhhs_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["yhkyxhhs_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["yhkyxhhs_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["yhkyxhhs_mzsyczyh"] = count.ToString();
                    }
                }

            }
        }

    }
}