using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    /// <summary>
    /// 自造的明日到期定存（三个月以上定期）实体模型
    /// </summary>
    public class Model_ZiZao_MRDQDC_CBOD_TDACNACN
    {
        private string _etldt;
        /// <summary>
        /// 发生日期
        /// </summary>
        public string Etldt
        {
            get { return _etldt; }
            set { _etldt = value; }
        }
        private string _td_td_acct_no;
        /// <summary>
        /// 定存账号
        /// </summary>
        public string Td_td_acct_no
        {
            get { return _td_td_acct_no; }
            set { _td_td_acct_no = value; }
        }
        private decimal? _td_dep_prd_n;
        /// <summary>
        /// 存期
        /// </summary>
        public decimal? Td_dep_prd_n
        {
            get { return _td_dep_prd_n; }
            set { _td_dep_prd_n = value; }
        }
        private string _td_due_dt;
        /// <summary>
        /// 到期日期
        /// </summary>
        public string Td_due_dt
        {
            get { return _td_due_dt; }
            set { _td_due_dt = value; }
        }
        private string _td_opac_dt;
        /// <summary>
        /// 开户日期
        /// </summary>
        public string Td_opac_dt
        {
            get { return _td_opac_dt; }
            set { _td_opac_dt = value; }
        }
        private decimal? _td_actu_amt;
        /// <summary>
        /// 实际余额
        /// </summary>
        public decimal? Td_actu_amt
        {
            get { return _td_actu_amt; }
            set { _td_actu_amt = value; }
        }
        private string _td_cust_name;
        /// <summary>
        /// 客户名称
        /// </summary>
        public string Td_cust_name
        {
            get { return _td_cust_name; }
            set { _td_cust_name = value; }
        }
        private string _td_conntr_no;
        /// <summary>
        /// 客户经理编号
        /// </summary>
        public string Td_conntr_no
        {
            get { return _td_conntr_no; }
            set { _td_conntr_no = value; }
        }
    }
}
