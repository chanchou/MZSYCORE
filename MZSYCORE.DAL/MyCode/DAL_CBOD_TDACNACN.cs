using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DBUtility;

namespace MZSYCORE.DAL
{
    public partial class DAL_CBOD_TDACNACN
    {
        /// <summary>
        /// 根据员工号和当前时间获取到期一个月内的存款列表。employee_id如果为“admin”,那么就表示查询全行的
        /// </summary>
        /// <param name="employee_id"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataSet GetDaoQiDingCunList(string employee_id, DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select td_td_acct_no, td_dep_prd_n, td_opac_dt, td_due_dt, td_actu_amt,td_cust_name, td_conntr_no");
            strSql.Append(" from jsrun.cbod_TDACNACN ");
            strSql.AppendFormat(" where td_cacct_tlr_no is null and td_td_acct_no like '{0}'",string.Format("{0}%",DAL_Constant.Jigouma));
            
            if (!string.Equals(employee_id, "admin"))
            {
                strSql.AppendFormat(" and td_conntr_no='{0}'", employee_id);
            }
            string dt_qian = dt.ToString("yyyyMMdd");
            string dt_hou = dt.AddMonths(1).ToString("yyyyMMdd");
            strSql.AppendFormat(" and td_due_dt between '{0}' and '{1}' ", dt_qian, dt_hou);
            strSql.Append(" order by td_due_dt");
            return DbHelperOleDb.Query(strSql.ToString());
        }

        
    }
}
