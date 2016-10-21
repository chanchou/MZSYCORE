using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZSYCORE.DAL
{
    public partial class DAL_CBOD_LNLNSLNS
    {
        /// <summary>
        /// 根据客户经理，所属单位和账户状态来获得数据列表
        /// </summary>
        /// <param name="suoshudanwei">所属单位</param>
        /// <param name="kehujingli">客户经理编号</param>
        /// <param name="zhanghuzhuangtai">账户状态</param>
        /// <returns></returns>
        public DataSet GetList(string suoshudanwei, string kehujingli, string zhanghuzhuangtai)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select etldt, ln_acct_sts, ln_zhibiao_no,ln_cust_no, ln_cust_name , ln_cert_typ , ln_cert_id , LN_CUST_TYP ,LN_COLI_CYCL_UNIT ,ln_belong_instn_cod , ln_totl_ln_amt_hypo_amt , ln_ln_bal,  ln_frst_intc_intr , ln_frst_alfd_dt_n ,ln_due_dt_n , ln_clsd_dt_n ,ln_ln_acct_no,ln_auto_dedu_dep_acct_no_1 ");
            strSql.Append(" from jsrun.cbod_lnlnslns ");
            strSql.AppendFormat(" where ln_belong_instn_cod like '{0}'", suoshudanwei);
            if (kehujingli != "")
            {
                strSql.AppendFormat(" and ln_zhibiao_no='{0}' ", kehujingli);
            }
            if (zhanghuzhuangtai != "")
            {
                strSql.AppendFormat(" and ln_acct_sts='{0}' ", zhanghuzhuangtai);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }


        public DataSet GetListKehujingliTaizhang(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select etldt , ln_belong_instn_cod ,ln_zhibiao_no ,ln_acct_sts , ln_cust_name , LN_CUST_TYP , ln_totl_ln_amt_hypo_amt , ln_ln_bal,  ln_frst_intc_intr, ln_frst_alfd_dt_n ,ln_due_dt_n, ln_clsd_dt_n ");
            sb.Append(" from jsrun.cbod_lnlnslns");
            if (!string.IsNullOrEmpty(strWhere))
            {
                sb.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(sb.ToString());
        }

    }
}
