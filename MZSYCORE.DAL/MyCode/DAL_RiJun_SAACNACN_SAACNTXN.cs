using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public class DAL_RiJun_SAACNACN_SAACNTXN
    {
        /// <summary>
        /// 根据条件获得实体列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select b.ETLDT, a.SA_ACCT_NO, a.SA_CARD_NO, a.SA_OPAC_DT, a.SA_CUST_NAME, a.SA_CONNTR_NO, b.SA_CR_AMT, b.SA_DDP_ACCT_BAL, b.SA_DR_AMT,b.SA_TX_AMT ,b.SA_RMRK ");
            sb.Append(" from jsrun.cbod_saacnacn a left join jsrun.cbod_saacntxn b on a.SA_ACCT_NO = b.FK_SAACN_KEY ");
            if (string.IsNullOrEmpty(strWhere))
            {
                return null;
            }
            else
            {
                sb.AppendFormat(" where {0}", strWhere);
                sb.AppendFormat(" order by b.ETLDT asc");
                return DBUtility.DbHelperOleDb.Query(sb.ToString());
            }
        }
        /// <summary>
        /// 根据账号，起始日期，结束时期，获得数据列表。时间格式为yyyyMMdd
        /// </summary>
        /// <param name="zhangHao"></param>
        /// <param name="qiShiRiQi"></param>
        /// <param name="jieShuRiQi"></param>
        /// <returns></returns>
        public DataSet GetList(string zhangHao, string qiShiRiQi, string jieShuRiQi)
        {
            StringBuilder sb = new StringBuilder();
            if (zhangHao.Length == 19)
            {
                sb.AppendFormat(" a.SA_CARD_NO='{0}' ", zhangHao);
            }
            else if (zhangHao.Length == 22)
            {
                sb.AppendFormat(" a.SA_ACCT_NO='{0}' ", zhangHao);
            }
            if (!string.IsNullOrEmpty(qiShiRiQi) && !string.IsNullOrEmpty(jieShuRiQi))
            {
                sb.AppendFormat(" and  b.etldt >= {0} and b.etldt <= {1}", qiShiRiQi, jieShuRiQi); 
            }
            return GetList(sb.ToString());

        }
    }
}
