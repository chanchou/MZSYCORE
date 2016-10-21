using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public class DAL_PISA
    {
        /// <summary>
        /// 根据机构码，其实和截止日期，获取企业网银交易笔数和金额。机构码为410826，日期格式为yyyy-MM-dd。返回笔数，out为金额
        /// </summary>
        /// <param name="jigouma"></param>
        /// <param name="qishiriqi"></param>
        /// <param name="jiezhiriqi"></param>
        /// <param name="jine"></param>
        /// <returns></returns>
        public string GetQiyewangyinJiaoyi(string jigouma, string qishiriqi, string jiezhiriqi, out string jine)
        {

            string strSql = string.Format("select  count(AMOUNT), sum(AMOUNT) from jsrun.wsyh_EJnlTransfer t1 join (select JNLNO,TRANSTIME from jsrun.wsyh_ejnl where jgm like '{0}%' and transdate>='{1}' and transdate<'{2}') t2 on t1.JNLNO=t2.JNLNO where jgm like '{0}%'", jigouma, qishiriqi, jiezhiriqi);
            DataSet ds = DBUtility.DbHelperOleDb.Query(strSql);
            string bishu = ds.Tables[0].Rows[0][0].ToString();
            jine = ds.Tables[0].Rows[0][1].ToString();
            return bishu;

        }


        /// <summary>
        /// 根据机构码，起始和截止日期，获取个人网银交易笔数和金额。机构码为410826，日期格式为yyyy-MM-dd。返回笔数，out为金额
        /// </summary>
        /// <param name="jigouma"></param>
        /// <param name="qishiriqi"></param>
        /// <param name="jiezhiriqi"></param>
        /// <param name="jine"></param>
        /// <returns></returns>
        public string GetGerenwangyinJiaoyi(string jigouma, string qishiriqi, string jiezhiriqi, out string jine)
        {

            string strSql = string.Format("select  count(AMOUNT), sum(AMOUNT) from jsrun.wsyh_pjnltransfer t1 join ( select JNLNO,TRANSTIME from jsrun.wsyh_pjnl where jgm like '{0}%' and transdate>='{1}' and transdate<'{2}' ) t2 on t1.JNLNO=t2.JNLNO where jgm like '{0}%'", jigouma, qishiriqi, jiezhiriqi);
            DataSet ds = DBUtility.DbHelperOleDb.Query(strSql);
            string bishu = ds.Tables[0].Rows[0][0].ToString();
            jine = ds.Tables[0].Rows[0][1].ToString();
            return bishu;

        }


        // <summary>
        /// 根据机构码，起始和截止日期，获取手机银行交易笔数和金额。机构码为410826，日期格式为yyyy-MM-dd。返回笔数，out为金额
        /// </summary>
        /// <param name="jigouma"></param>
        /// <param name="qishiriqi"></param>
        /// <param name="jiezhiriqi"></param>
        /// <param name="jine"></param>
        /// <returns></returns>
        public string GetShoujiyinhangJiaoyi(string jigouma, string qishiriqi, string jiezhiriqi, out string jine)
        {
            string strSql = string.Format("select  count(AMOUNT), sum(AMOUNT) from jsrun.wsyh_cjnltransfer where jgm like  '{0}%'    and    CTRANSFERDATE >= '{1}'  and CTRANSFERDATE<'{2}' ", jigouma, qishiriqi, jiezhiriqi);
            DataSet ds = DBUtility.DbHelperOleDb.Query(strSql);
            string bishu =ds.Tables[0].Rows[0][0].ToString();
            jine =ds.Tables[0].Rows[0][1].ToString();
            return bishu;
        }
    }
}
