using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public class DAL_DaikuanFangHuankuan
    {
        /// <summary>
        /// 根据日期和借还标志，获取数据列表。日期不可为空，借还标志可为空
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="huanfangkuanflag">借还标志，即位借贷标志</param>
        /// <returns></returns>
        public DataSet GetList(string date, string huanfangkuanflag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t1.LN_ENTR_DT_N , t1.LN_DR_CR_COD , t1.LN_LN_ACCT_NO , t2.ln_cust_name ,t1.LN_ACCD_TYP , t1.LN_ACCD_SUB_CLSFN , t1.LN_TX_TYP ,  t1.LN_TX_AMT , t1.LN_ATX_BAL ,t1.LN_TX_OPR_NO ,t1.LN_TX_NO, t1.LN_DSCRP , t1.LN_TX_OPUN_NO ");
            strSql.Append("from jsrun.cbod_LNLNSJRN0 t1 left join jsrun.cbod_LnLnsLns t2 ");
            strSql.Append(" on t1.LN_LN_ACCT_NO = t2.ln_ln_acct_no ");
            strSql.AppendFormat(" where t1.LN_ASS_OPUN_NO = '{0}000' ",DAL_Constant.Jigouma);
            strSql.AppendFormat(" and t1.LN_ENTR_DT_N='{0}' ", date);
            if (huanfangkuanflag != "")
            {
                strSql.AppendFormat(" and t1.LN_DR_CR_COD= '{0}' ", huanfangkuanflag);
            }
          
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}
