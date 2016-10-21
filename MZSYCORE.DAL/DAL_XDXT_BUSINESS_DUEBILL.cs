using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DBUtility;

namespace MZSYCORE.DAL
{
    public class DAL_XDXT_BUSINESS_DUEBILL
    {
        /// <summary>
        /// 获取欠息贷款户的数据列表。
        /// </summary>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            return GetList(strWhere, "");
        }
        /// <summary>
        /// 获取欠息贷款户的数据列表。
        /// </summary>
        /// <returns></returns>
        public DataSet GetList(string strWhere, string orderBy)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select MANAGEUSERID , SERIALNO , PAYINTERESTACCOUNT,CUSTOMERNAME ,  PUTOUTDATE,  MATURITY , BUSINESSSUM ,  ACTUALBUSINESSRATE ,  BALANCE ,  NORMALBALANCE,  OVERDUEBALANCE,  DULLBALANCE ,  BADBALANCE ,  INTERESTBALANCE1 ,  INTERESTBALANCE2 ,  FINEBALANCE1 ,  FINEBALANCE2 , UPDATEDATE ,  MANAGEORGID from jsrun.xdxt_business_duebill where CORPORATEORGID ='{0}' and FINISHDATE is null ",DAL_Constant.Farenhao);

            if (strWhere != "")
            {
                strSql.Append(strWhere);
            }
            if (orderBy != "")
            {
                strSql.Append(orderBy);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据所选择的字段，求和.科目可选为欠息qianxi，或者本金逾期benjinyuqi
        /// </summary>
        /// <param name="ziduan"></param>
        /// <returns></returns>
        public decimal GetSum(string ziduan, string kemu)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select sum({0}) from jsrun.xdxt_business_duebill where CORPORATEORGID ='{1}' and FINISHDATE is null ", ziduan,DAL_Constant.Farenhao);
            if (kemu == "qianxi")
            {
                //strSql.Append("  and (INTERESTBALANCE1 !=0 or INTERESTBALANCE2 !=0 or FINEBALANCE1 !=0 or FINEBALANCE2 !=0) ");
                strSql.Append("  and (INTERESTBALANCE1 !=0 or INTERESTBALANCE2 !=0 or FINEBALANCE1 !=0) ");
            }
            else if (kemu == "benjinyuqi")
            {
                strSql.Append("  and (OVERDUEBALANCE !=0 or DULLBALANCE !=0 or BADBALANCE !=0) ");
            }
            return Convert.ToDecimal(DbHelperOleDb.GetSingle(strSql.ToString()));
        }

        /// <summary>
        /// 根据所选择的字段，计数.科目可选为欠息qianxi，或者本金逾期benjinyuqi
        /// </summary>
        /// <param name="ziduan"></param>
        /// <returns></returns>
        public int GetCount(string ziduan, string kemu)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select count({0}) from jsrun.xdxt_business_duebill where CORPORATEORGID ='{1}' and FINISHDATE is null", ziduan,DAL_Constant.Farenhao);
            if (kemu == "qianxi")
            {
                //strSql.Append("  and (INTERESTBALANCE1 !=0 or INTERESTBALANCE2 !=0 or FINEBALANCE1 !=0 or FINEBALANCE2 !=0) ");
                strSql.Append("  and (INTERESTBALANCE1 !=0 or INTERESTBALANCE2 !=0 or FINEBALANCE1 !=0 ) ");
            }
            else if (kemu == "benjinyuqi")
            {
                strSql.Append("  and (OVERDUEBALANCE !=0 or DULLBALANCE !=0 or BADBALANCE !=0) ");
            }
            return Convert.ToInt32(DbHelperOleDb.GetSingle(strSql.ToString()));
        }

       
    }
}
