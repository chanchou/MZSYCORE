using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    public class Model_RiJun_SAACNACN_SAACNTXN
    {
        private string _etldt;
        /// <summary>
        /// 日期
        /// </summary>
        public string ETLDT
        {
            set { _etldt = value; }
            get { return _etldt; }
        }

        private string _sa_card_no;
        /// <summary>
        /// 卡号
        /// </summary>
        public string SA_CARD_NO
        {
            set { _sa_card_no = value; }
            get { return _sa_card_no; }
        }
        private string _sa_acct_no;
        /// <summary>
        /// 活存账号
        /// </summary>
        public string SA_ACCT_NO
        {
            set { _sa_acct_no = value; }
            get { return _sa_acct_no; }
        }
        private string _sa_opac_dt;
        /// <summary>
        /// 开户日期
        /// </summary>
        public string SA_OPAC_DT
        {
            set { _sa_opac_dt = value; }
            get { return _sa_opac_dt; }
        }
        private string _sa_cust_name;
        private string _sa_conntr_no;
        /// <summary>
        /// 客户名称
        /// </summary>
        public string SA_CUST_NAME
        {
            set { _sa_cust_name = value; }
            get { return _sa_cust_name; }
        }
        /// <summary>
        /// 客户经理编号
        /// </summary>
        public string SA_CONNTR_NO
        {
            set { _sa_conntr_no = value; }
            get { return _sa_conntr_no; }
        }
        private decimal? _sa_cr_amt;
        private decimal? _sa_ddp_acct_bal;
        /// <summary>
        /// 贷方发生额
        /// </summary>
        public decimal? SA_CR_AMT
        {
            set { _sa_cr_amt = value; }
            get { return _sa_cr_amt; }
        }
        /// <summary>
        /// 活存账户余额
        /// </summary>
        public decimal? SA_DDP_ACCT_BAL
        {
            set { _sa_ddp_acct_bal = value; }
            get { return _sa_ddp_acct_bal; }
        }
        private decimal? _sa_tx_amt;
        /// <summary>
        /// 交易金额
        /// </summary>
        public decimal? SA_TX_AMT
        {
            set { _sa_tx_amt = value; }
            get { return _sa_tx_amt; }
        }
        private decimal? _sa_dr_amt;
        /// <summary>
        /// 借方发生额
        /// </summary>
        public decimal? SA_DR_AMT
        {
            set { _sa_dr_amt = value; }
            get { return _sa_dr_amt; }
        }
        private string _sa_rmrk;
        /// <summary>
        /// 备注
        /// </summary>
        public string SA_RMRK
        {
            set { _sa_rmrk = value; }
            get { return _sa_rmrk; }
        }

    }
}
