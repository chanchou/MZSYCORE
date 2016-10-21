using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.PersonManager.CaiwubuSuoxuShuju
{
    public partial class index : System.Web.UI.Page
    {
        protected Dictionary<string, string> dic = new Dictionary<string, string>();
        BLL.BLL_CaiwubuSuoxuShuju bll_CaiwubuSuoxuShuju = new BLL.BLL_CaiwubuSuoxuShuju();
        //参数设置
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //各单位存款总余额-时点
            dic.Add("cunkuanZongyue_Shidian_yyb", "没有相关数据");
            dic.Add("cunkuanZongyue_Shidian_xgzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Shidian_hgzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Shidian_nzzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Shidian_mzsyczyh", "没有相关数据");

            //各单位存款总余额-月日均
            dic.Add("cunkuanZongyue_Yuerijun_yyb", "没有相关数据");
            dic.Add("cunkuanZongyue_Yuerijun_xgzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Yuerijun_hgzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Yuerijun_nzzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Yuerijun_mzsyczyh", "没有相关数据");

            //各单位储蓄存款-月日均
            dic.Add("chuxuncunkuan_Yuerijun_yyb", "没有相关数据");
            dic.Add("chuxuncunkuan_Yuerijun_xgzh", "没有相关数据");
            dic.Add("chuxuncunkuan_Yuerijun_hgzh", "没有相关数据");
            dic.Add("chuxuncunkuan_Yuerijun_nzzh", "没有相关数据");
            dic.Add("chuxuncunkuan_Yuerijun_mzsyczyh", "没有相关数据");
            //各单位单位存款-月日均
            dic.Add("danweicunkuan_Yuerijun_yyb", "没有相关数据");
            dic.Add("danweicunkuan_Yuerijun_xgzh", "没有相关数据");
            dic.Add("danweicunkuan_Yuerijun_hgzh", "没有相关数据");
            dic.Add("danweicunkuan_Yuerijun_nzzh", "没有相关数据");
            dic.Add("danweicunkuan_Yuerijun_mzsyczyh", "没有相关数据");

            //各单位存款总余额-年日均
            dic.Add("cunkuanZongyue_Nianrijun_yyb", "没有相关数据");
            dic.Add("cunkuanZongyue_Nianrijun_xgzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Nianrijun_hgzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Nianrijun_nzzh", "没有相关数据");
            dic.Add("cunkuanZongyue_Nianrijun_mzsyczyh", "没有相关数据");

            //各单位贷款总余额-时点
            dic.Add("daikuanZongyue_Shidian_yyb", "没有相关数据");
            dic.Add("daikuanZongyue_Shidian_xgzh", "没有相关数据");
            dic.Add("daikuanZongyue_Shidian_hgzh", "没有相关数据");
            dic.Add("daikuanZongyue_Shidian_nzzh", "没有相关数据");
            dic.Add("daikuanZongyue_Shidian_mzsyczyh", "没有相关数据");

            //各单位贷款总余额-月日均
            dic.Add("daikuanZongyue_Yuerijun_yyb", "没有相关数据");
            dic.Add("daikuanZongyue_Yuerijun_xgzh", "没有相关数据");
            dic.Add("daikuanZongyue_Yuerijun_hgzh", "没有相关数据");
            dic.Add("daikuanZongyue_Yuerijun_nzzh", "没有相关数据");
            dic.Add("daikuanZongyue_Yuerijun_mzsyczyh", "没有相关数据");

            //各单位贷款总余额-年日均
            dic.Add("daikuanZongyue_Nianrijun_yyb", "没有相关数据");
            dic.Add("daikuanZongyue_Nianrijun_xgzh", "没有相关数据");
            dic.Add("daikuanZongyue_Nianrijun_hgzh", "没有相关数据");
            dic.Add("daikuanZongyue_Nianrijun_nzzh", "没有相关数据");
            dic.Add("daikuanZongyue_Nianrijun_mzsyczyh", "没有相关数据");


            //各单位手机银行
            dic.Add("sjyh_yyb", "没有相关数据");
            dic.Add("sjyh_xgzh", "没有相关数据");
            dic.Add("sjyh_hgzh", "没有相关数据");
            dic.Add("sjyh_nzzh", "没有相关数据");
            dic.Add("sjyh_mzsyczyh", "没有相关数据");
            //各单位个人网银
            dic.Add("grwy_yyb", "没有相关数据");
            dic.Add("grwy_xgzh", "没有相关数据");
            dic.Add("grwy_hgzh", "没有相关数据");
            dic.Add("grwy_nzzh", "没有相关数据");
            dic.Add("grwy_mzsyczyh", "没有相关数据");
            //各单位企业网银
            dic.Add("qywy_yyb", "没有相关数据");
            dic.Add("qywy_xgzh", "没有相关数据");
            dic.Add("qywy_hgzh", "没有相关数据");
            dic.Add("qywy_nzzh", "没有相关数据");
            dic.Add("qywy_mzsyczyh", "没有相关数据");


            //各单位银行卡户数
            dic.Add("yhkhs_yyb", "没有相关数据");
            dic.Add("yhkhs_xgzh", "没有相关数据");
            dic.Add("yhkhs_hgzh", "没有相关数据");
            dic.Add("yhkhs_nzzh", "没有相关数据");
            dic.Add("yhkhs_mzsyczyh", "没有相关数据");
            //各单位贷款户数
            dic.Add("dkhs_yyb", "没有相关数据");
            dic.Add("dkhs_xgzh", "没有相关数据");
            dic.Add("dkhs_hgzh", "没有相关数据");
            dic.Add("dkhs_nzzh", "没有相关数据");
            dic.Add("dkhs_mzsyczyh", "没有相关数据");
            //各单位本季度累放余额
            dic.Add("bjdlfdk_yyb", "没有相关数据");
            dic.Add("bjdlfdk_xgzh", "没有相关数据");
            dic.Add("bjdlfdk_hgzh", "没有相关数据");
            dic.Add("bjdlfdk_nzzh", "没有相关数据");
            dic.Add("bjdlfdk_mzsyczyh", "没有相关数据");

            //一个月内到期定存和信息员存款
            dic.Add("ygyndqdc_mzsyczyh", "没有相关数据");
            dic.Add("xxyck_mzsyczyh", "没有相关数据");

        }

        protected void btn_Jisuan_Click(object sender, EventArgs e)
        {
            string tongjiRiqi = this.tbox_Date.Text;

            BindCundaikuanShuju(tongjiRiqi.Replace("-", ""));//绑定存贷款数据           
            BindDianziyinhangShuju(Common.Common.ConventStringToDateTime(tongjiRiqi).AddDays(1).ToString("yyyy-MM-dd"));//绑定电子银行数据
            BindYinghangkaHushu(tongjiRiqi.Replace("-", ""));//绑定银行卡户数
            BindWeijieqingHushu(tongjiRiqi.Replace("-", ""));//绑定未结清贷款户数
            BindLeifangDaikuanHushu(Common.Common.ConventStringToDateTime(tongjiRiqi));//绑定累放贷款户数
            BindYigeyueDaoqiDingCun(Common.Common.ConventStringToDateTime(tongjiRiqi).AddMonths(1));//下月月到期的定存
            BindXinxiyuanCunkuan(tongjiRiqi.Replace("-", ""));//信息员存款

            Context.Response.Write("<script language=javascript>alert('数据获取成功，如有未显示部分表示数据未到达，请稍后再查询！');</script>");

        }
        //信息员存款
        private void BindXinxiyuanCunkuan(string date)
        {
            decimal result = bll_CaiwubuSuoxuShuju.SumXinxiyuanCunkuan(date);
            if (result > 0)
            {
                dic["xxyck_mzsyczyh"] = result.ToString();
            }
        }
        //下月到期的定存
        private void BindYigeyueDaoqiDingCun(DateTime dateTime)
        {
            decimal result = bll_CaiwubuSuoxuShuju.SumYigeyueDaoqiDingcun(dateTime);
            if (result >= 0)
            {
                dic["ygyndqdc_mzsyczyh"] = result.ToString();
            }
        }
        //绑定累放贷款户数
        private void BindLeifangDaikuanHushu(DateTime tongjiRiqi)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_CaiwubuSuoxuShuju.GetBenjiduLeifangDaikuanCountModelList(tongjiRiqi);
            decimal number = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["bjdlfdk_yyb"] = model.Number.ToString();
                        number += model.Number;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["bjdlfdk_xgzh"] = model.Number.ToString();
                        number += model.Number;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["bjdlfdk_hgzh"] = model.Number.ToString();
                        number += model.Number;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["bjdlfdk_nzzh"] = model.Number.ToString();
                        number += model.Number;
                    }
                    if (number != 0)
                    {
                        dic["bjdlfdk_mzsyczyh"] = number.ToString();
                    }
                }
            }
        }
        //绑定未结清贷款户数
        private void BindWeijieqingHushu(string tongjiRiqi)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            lst = bll_CaiwubuSuoxuShuju.GetWeijieqingDaikuanhushuCountModelList(tongjiRiqi);
            decimal count = 0;
            if (lst != null)
            {
                foreach (Model.Model_Zizao_Count model in lst)
                {
                    if (model.JGM == Web_Constant.YingyebuJigouma)
                    {
                        dic["dkhs_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["dkhs_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["dkhs_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["dkhs_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["dkhs_mzsyczyh"] = count.ToString();
                    }
                }
            }
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
                        dic["qywy_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["qywy_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["qywy_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["qywy_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["qywy_mzsyczyh"] = count.ToString();
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
                        dic["grwy_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["grwy_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["grwy_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["grwy_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["grwy_mzsyczyh"] = count.ToString();
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
                        dic["sjyh_yyb"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.XiguoJigouma)
                    {
                        dic["sjyh_xgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.HuagongJigouma)
                    {
                        dic["sjyh_hgzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (model.JGM == Web_Constant.NanzhuangJigouma)
                    {
                        dic["sjyh_nzzh"] = model.Count.ToString();
                        count += model.Count;
                    }
                    if (count != 0)
                    {
                        dic["sjyh_mzsyczyh"] = count.ToString();
                    }
                }

            }
        }

        /// <summary>
        /// 绑定存贷款数据
        /// </summary>
        /// <param name="tongjiRiqi"></param>
        private void BindCundaikuanShuju(string tongjiRiqi)
        {
            List<Model.Model_YJZB_JG_01> lst = bll_CaiwubuSuoxuShuju.GetCundaikuanShuju(tongjiRiqi);
            foreach (Model.Model_YJZB_JG_01 model in lst)
            {
                #region 营业部
                if (model.KHDXDH == Web_Constant.JixiaoxitongYingyebuKHDXDH)//营业部
                {
                    if (model.ZBDH == 1007)//存款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["cunkuanZongyue_Shidian_yyb"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["cunkuanZongyue_Yuerijun_yyb"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["cunkuanZongyue_Nianrijun_yyb"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1000)//贷款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["daikuanZongyue_Shidian_yyb"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["daikuanZongyue_Yuerijun_yyb"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["daikuanZongyue_Nianrijun_yyb"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1023)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["chuxuncunkuan_Yuerijun_yyb"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1008)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["danweicunkuan_Yuerijun_yyb"] = model.ZBZ.ToString();
                        }
                    }
                }
                #endregion

                #region 西虢支行
                if (model.KHDXDH == Web_Constant.JixiaoxitongXiguoKHDXDH)//西虢支行
                {
                    if (model.ZBDH == 1007)//存款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["cunkuanZongyue_Shidian_xgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["cunkuanZongyue_Yuerijun_xgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["cunkuanZongyue_Nianrijun_xgzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1000)//贷款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["daikuanZongyue_Shidian_xgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["daikuanZongyue_Yuerijun_xgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["daikuanZongyue_Nianrijun_xgzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1023)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["chuxuncunkuan_Yuerijun_xgzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1008)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["danweicunkuan_Yuerijun_xgzh"] = model.ZBZ.ToString();
                        }
                    }
                }
                #endregion
                #region 化工支行
                if (model.KHDXDH == Web_Constant.JixiaoxitongHuagongKHDXDH)//化工支行
                {
                    if (model.ZBDH == 1007)//存款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["cunkuanZongyue_Shidian_hgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["cunkuanZongyue_Yuerijun_hgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["cunkuanZongyue_Nianrijun_hgzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1000)//贷款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["daikuanZongyue_Shidian_hgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["daikuanZongyue_Yuerijun_hgzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["daikuanZongyue_Nianrijun_hgzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1023)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["chuxuncunkuan_Yuerijun_hgzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1008)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["danweicunkuan_Yuerijun_hgzh"] = model.ZBZ.ToString();
                        }
                    }
                }
                #endregion
                #region 南庄支行
                if (model.KHDXDH == Web_Constant.JixiaoxitongNanzhuangKHDXDH)//南庄支行
                {
                    if (model.ZBDH == 1007)//存款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["cunkuanZongyue_Shidian_nzzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["cunkuanZongyue_Yuerijun_nzzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["cunkuanZongyue_Nianrijun_nzzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1000)//贷款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["daikuanZongyue_Shidian_nzzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["daikuanZongyue_Yuerijun_nzzh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["daikuanZongyue_Nianrijun_nzzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1023)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["chuxuncunkuan_Yuerijun_nzzh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1008)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["danweicunkuan_Yuerijun_nzzh"] = model.ZBZ.ToString();
                        }
                    }
                }
                #endregion
                #region 孟州射阳村镇银行
                if (model.KHDXDH == Web_Constant.JixiaoxitongMZSYCZYHKHDXDH)//孟州射阳村镇银行
                {
                    if (model.ZBDH == 1007)//存款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["cunkuanZongyue_Shidian_mzsyczyh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["cunkuanZongyue_Yuerijun_mzsyczyh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["cunkuanZongyue_Nianrijun_mzsyczyh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1000)//贷款余额
                    {
                        if (model.SDBS == "1")//时点
                        {
                            dic["daikuanZongyue_Shidian_mzsyczyh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "2")//月日均
                        {
                            dic["daikuanZongyue_Yuerijun_mzsyczyh"] = model.ZBZ.ToString();
                        }
                        if (model.SDBS == "4")//年日均
                        {
                            dic["daikuanZongyue_Nianrijun_mzsyczyh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1023)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["chuxuncunkuan_Yuerijun_mzsyczyh"] = model.ZBZ.ToString();
                        }
                    }
                    if (model.ZBDH == 1008)//储蓄存款余额
                    {
                        if (model.SDBS == "2")//月日均
                        {
                            dic["danweicunkuan_Yuerijun_mzsyczyh"] = model.ZBZ.ToString();
                        }
                    }
                }
                #endregion
            }
        }
    }
}