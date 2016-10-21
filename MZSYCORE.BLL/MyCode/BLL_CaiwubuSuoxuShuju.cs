using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_CaiwubuSuoxuShuju
    {
        DAL.DAL_YJZB_JG_01 dal_YJZB_JG_01 = new DAL.DAL_YJZB_JG_01();
        DAL.DAL_CaiwubuSuoxuShuju dal_CaiwubuSuoxuShuju = new DAL.DAL_CaiwubuSuoxuShuju();
        /// <summary>
        /// 根据统计日期，获取各单位存贷款数据
        /// </summary>
        /// <param name="tjrq"></param>
        /// <returns></returns>
        public List<Model.Model_YJZB_JG_01> GetCundaikuanShuju(string tjrq)
        {
            string tjkj = "0";
            string zbdh = "1000,1007,1008,1023";
            string sdbs = "1,2,4";
            //string khdxdh = "40,47,77,86,87";
            //return dal_YJZB_JG_01.GetModelList(tjkj, zbdh, sdbs, khdxdh, tjrq);
            return dal_YJZB_JG_01.GetModelList(tjkj, zbdh, sdbs,  tjrq);
        }

        /// <summary>
        /// 根据统计日期，获取各单位手机银行开户数
        /// </summary>
        /// <param name="date">yyyy-MM-dd，此日期为小于，不是小于等于，要注意</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetCount_SJYH(string date)
        {
            return dal_CaiwubuSuoxuShuju.GetDianziyinhangModelList("wsyh_cuser", date);
        }
        /// <summary>
        /// 根据统计日期，获取各单位个人网银开户数
        /// </summary>
        /// <param name="date">yyyy-MM-dd，此日期为小于，不是小于等于，要注意</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetCount_GRWY(string date)
        {
            return dal_CaiwubuSuoxuShuju.GetDianziyinhangModelList("wsyh_puser", date);
        }
        /// <summary>
        /// 根据统计日期，获取各单位企业网银开户数
        /// </summary>
        /// <param name="date">yyyy-MM-dd，此日期为小于，不是小于等于，要注意</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetCountQYWY(string date)
        {
            return dal_CaiwubuSuoxuShuju.GetDianziyinhangModelList("wsyh_eaccount", date);
        }
        /// <summary>
        /// 根据日期，计算各机构银行开户数
        /// </summary>
        /// <param name="date">时间格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetYinhangkaCountModelList(string date)
        {
            return dal_CaiwubuSuoxuShuju.GetYinhangkaCountModelList(date);
        }
        /// <summary>
        /// 根据日期，计算各机构本季度累放贷款
        /// </summary>
        /// <param name="date">时间格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetBenjiduLeifangDaikuanCountModelList(DateTime date)
        {
            string qishiRiqi = string.Empty, jieshuRiq = string.Empty;
            int flag = date.Month / 3;
            if (flag <= 1)
            {
                qishiRiqi = date.Year + "0101";
                jieshuRiq = date.Year + "0331";
            }
            else if (flag <= 2)
            {
                qishiRiqi = date.Year + "0401";
                jieshuRiq = date.Year + "0630";
            }
            else if (flag <= 3)
            {
                qishiRiqi = date.Year + "0701";
                jieshuRiq = date.Year + "0930";
            }
            else if (flag <= 4)
            {
                qishiRiqi = date.Year + "1001";
                jieshuRiq = date.Year + "1231";
            }
            return dal_CaiwubuSuoxuShuju.GetBenjiduLeifangDaikuanCountModelList(qishiRiqi, jieshuRiq);

        }
        /// <summary>
        /// 根据日期，计算各机构未结清贷款的数据
        /// </summary>
        /// <param name="date">时间格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetWeijieqingDaikuanhushuCountModelList(string date)
        {
            return dal_CaiwubuSuoxuShuju.GetWeijieqingDaikuanhushuCountModelList(date);
        }

        /// <summary>
        /// 获得当前月一个月内的到期定存，不包括定活两便和通知七天，不包括自动转存
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public decimal SumYigeyueDaoqiDingcun(DateTime date) { return dal_CaiwubuSuoxuShuju.SumYigeyueDaoqiDingcun(date); }
         /// <summary>
        /// 计算当前日期的信息员存款总余额
        /// </summary>
        /// <param name="date">yyyyMMdd</param>
        /// <returns></returns>
        public decimal SumXinxiyuanCunkuan(string date) { return dal_CaiwubuSuoxuShuju.SumXinxiyuanCunkuan(date); }
    }
}
