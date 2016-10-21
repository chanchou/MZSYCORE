using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_PISA
    {
        BLL.BLL_CBOD_SAACNTXN bll_cbod_saacntxn = new BLL_CBOD_SAACNTXN();
        BLL.BLL_CBOD_CRATMDET bll_cbod_cratmdet = new BLL_CBOD_CRATMDET();
        DAL.DAL_PISA dal_pisa = new DAL.DAL_PISA();

        /// <summary>
        /// 根据日期和机构码，获取数据列表。获取的列表为未冲正的；起始日期为当月第一天，结束日期为下月第一天，机构码为410826
        /// </summary>
        /// <param name="qishiRiqi"></param>
        /// <param name="jieshuRiqi"></param>
        /// <param name="jigouma"></param>
        /// <returns></returns>
        public DataSet GetSaacntxtList(string qishiRiqi, string jieshuRiqi, string jigouma)
        {
            string strSql = string.Format("FK_SAACN_KEY like '{0}%'  and SA_EC_FLG ='0' and  ETLDT >={1} and  ETLDT <{2}", jigouma, qishiRiqi, jieshuRiqi);
            DataSet ds = new DataSet();
            ds = bll_cbod_saacntxn.GetList(strSql);
            return ds;
        }

        /// <summary>
        /// 根据日期和机构码，获取数据列表。获取的列表为未冲正的；起始日期为当月第一天，结束日期为下月第一天，机构码为410826h
        /// </summary>
        /// <param name="qishiRiqi"></param>
        /// <param name="jieshuRiqi"></param>
        /// <param name="jigouma"></param>
        /// <returns></returns>
        public DataSet GetCratmdetList(string qishiRiqi, string jieshuRiqi, string jigouma)
        {
            DataSet ds = new DataSet();
            string strSql = string.Format("CR_BELONGTO_BRH like '{0}%' and CR_EC_FLG='0' and ETLDT >={1} and etldt<{2}", jigouma, qishiRiqi, jieshuRiqi);
            ds = bll_cbod_cratmdet.GetList(strSql);
            return ds;
        }



        /// <summary>
        /// 根据机构码，其实和截止日期，获取企业网银交易笔数和金额。机构码为410826，日期格式为yyyyMMdd。返回笔数，out为金额
        /// </summary>
        /// <param name="jigouma"></param>
        /// <param name="qishiriqi"></param>
        /// <param name="jiezhiriqi"></param>
        /// <param name="jine"></param>
        /// <returns></returns>
        public string GetQiyewangyinJiaoyi(string jigouma, string qishiriqi, string jiezhiriqi, out string jine)
        {
            //qishiriqi = Common.Common.yyyyMMddToYegang(qishiriqi);
            //jiezhiriqi = Common.Common.yyyyMMddToYegang(jiezhiriqi);
            return dal_pisa.GetQiyewangyinJiaoyi(jigouma, qishiriqi, jiezhiriqi, out jine);
        }
        /// <summary>
        /// 根据机构码，起始和截止日期，获取个人网银交易笔数和金额。机构码为410826，日期格式为yyyyMMdd。返回笔数，out为金额
        /// </summary>
        /// <param name="jigouma"></param>
        /// <param name="qishiriqi"></param>
        /// <param name="jiezhiriqi"></param>
        /// <param name="jine"></param>
        /// <returns></returns>
        public string GetGerenwangyinJiaoyi(string jigouma, string qishiriqi, string jiezhiriqi, out string jine)
        {
            //qishiriqi = Common.Common.yyyyMMddToYegang(qishiriqi);
            //jiezhiriqi = Common.Common.yyyyMMddToYegang(jiezhiriqi);
            return dal_pisa.GetGerenwangyinJiaoyi(jigouma, qishiriqi, jiezhiriqi, out jine);
        }
        // <summary>
        /// 根据机构码，起始和截止日期，获取手机银行交易笔数和金额。机构码为410826，日期格式为yyyyMMdd。返回笔数，out为金额
        /// </summary>
        /// <param name="jigouma"></param>
        /// <param name="qishiriqi"></param>
        /// <param name="jiezhiriqi"></param>
        /// <param name="jine"></param>
        /// <returns></returns>
        public string GetShoujiyinhangJiaoyi(string jigouma, string qishiriqi, string jiezhiriqi, out string jine)
        {
            //qishiriqi = Common.Common.yyyyMMddToYegang(qishiriqi);
            //jiezhiriqi = Common.Common.yyyyMMddToYegang(jiezhiriqi);
            return dal_pisa.GetShoujiyinhangJiaoyi(jigouma, qishiriqi, jiezhiriqi, out jine);
        }
    }
}
