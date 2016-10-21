using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    /// <summary>
    /// Model_CBOD_SAACNTXN:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Model_CBOD_SAACNTXN
    {
        public Model_CBOD_SAACNTXN()
        { }
        #region Model
        private string _etldt;
        private decimal? _satxn_ll;
        private string _fk_saacn_key;
        private decimal _sa_ddp_acct_no_det_n;
        private decimal? _satxn_db_timestamp;
        private string _sa_curr_cod;
        private string _sa_opr_no;
        private string _sa_curr_iden;
        private string _sa_ec_flg;
        private decimal? _sa_ec_det_no_n;
        private decimal? _sa_cr_amt;
        private decimal? _sa_ddp_acct_bal;
        private decimal? _sa_tx_amt;
        private string _sa_tx_crd_no;
        private string _sa_tx_typ;
        private string _sa_tx_log_no;
        private decimal? _sa_dr_amt;
        private string _sa_doc_no;
        private string _sa_doc_typ;
        private string _sa_val_dt;
        private decimal? _sa_svc;
        private string _sa_auth_no;
        private string _sa_cust_docag_stno;
        private string _sa_opun_cod;
        private string _sa_dscrp_cod;
        private string _sa_rmrk;
        private string _sa_tx_tm;
        private string _sa_tx_dt;
        private string _sa_sys_dt;
        private decimal? _sa_ddp_pdt;
        private string _sa_app_tx_code;
        private string _sa_etx_flg;
        private string _sa_otx_flg;
        private string _sa_flx_flg;
        private string _sa_guiji_flag;
        private string _sa_prt_flg;
        private string _sa_filler;
        private string _sa_rmrk_1;
        private string _sa_op_cust_name;
        private string _sa_agt_cert_typ;
        private string _sa_agt_cert_id;
        private string _sa_agt_cust_name;
        private string _sa_belong_instn_cod;
        private string _sa_channel_flag;
        private string _sa_pdp_code;
        private string _sa_op_acct_no_32;
        private string _sa_op_bank_no;
        private string _sa_sup_tlr;
        private string _sa_db_part_id;
        /// <summary>
        /// 
        /// </summary>
        public string ETLDT
        {
            set { _etldt = value; }
            get { return _etldt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SATXN_LL
        {
            set { _satxn_ll = value; }
            get { return _satxn_ll; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FK_SAACN_KEY
        {
            set { _fk_saacn_key = value; }
            get { return _fk_saacn_key; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SA_DDP_ACCT_NO_DET_N
        {
            set { _sa_ddp_acct_no_det_n = value; }
            get { return _sa_ddp_acct_no_det_n; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SATXN_DB_TIMESTAMP
        {
            set { _satxn_db_timestamp = value; }
            get { return _satxn_db_timestamp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_CURR_COD
        {
            set { _sa_curr_cod = value; }
            get { return _sa_curr_cod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_OPR_NO
        {
            set { _sa_opr_no = value; }
            get { return _sa_opr_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_CURR_IDEN
        {
            set { _sa_curr_iden = value; }
            get { return _sa_curr_iden; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_EC_FLG
        {
            set { _sa_ec_flg = value; }
            get { return _sa_ec_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_EC_DET_NO_N
        {
            set { _sa_ec_det_no_n = value; }
            get { return _sa_ec_det_no_n; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_CR_AMT
        {
            set { _sa_cr_amt = value; }
            get { return _sa_cr_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_DDP_ACCT_BAL
        {
            set { _sa_ddp_acct_bal = value; }
            get { return _sa_ddp_acct_bal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_TX_AMT
        {
            set { _sa_tx_amt = value; }
            get { return _sa_tx_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_TX_CRD_NO
        {
            set { _sa_tx_crd_no = value; }
            get { return _sa_tx_crd_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_TX_TYP
        {
            set { _sa_tx_typ = value; }
            get { return _sa_tx_typ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_TX_LOG_NO
        {
            set { _sa_tx_log_no = value; }
            get { return _sa_tx_log_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_DR_AMT
        {
            set { _sa_dr_amt = value; }
            get { return _sa_dr_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_DOC_NO
        {
            set { _sa_doc_no = value; }
            get { return _sa_doc_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_DOC_TYP
        {
            set { _sa_doc_typ = value; }
            get { return _sa_doc_typ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_VAL_DT
        {
            set { _sa_val_dt = value; }
            get { return _sa_val_dt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_SVC
        {
            set { _sa_svc = value; }
            get { return _sa_svc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_AUTH_NO
        {
            set { _sa_auth_no = value; }
            get { return _sa_auth_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_CUST_DOCAG_STNO
        {
            set { _sa_cust_docag_stno = value; }
            get { return _sa_cust_docag_stno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_OPUN_COD
        {
            set { _sa_opun_cod = value; }
            get { return _sa_opun_cod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_DSCRP_COD
        {
            set { _sa_dscrp_cod = value; }
            get { return _sa_dscrp_cod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_RMRK
        {
            set { _sa_rmrk = value; }
            get { return _sa_rmrk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_TX_TM
        {
            set { _sa_tx_tm = value; }
            get { return _sa_tx_tm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_TX_DT
        {
            set { _sa_tx_dt = value; }
            get { return _sa_tx_dt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_SYS_DT
        {
            set { _sa_sys_dt = value; }
            get { return _sa_sys_dt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SA_DDP_PDT
        {
            set { _sa_ddp_pdt = value; }
            get { return _sa_ddp_pdt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_APP_TX_CODE
        {
            set { _sa_app_tx_code = value; }
            get { return _sa_app_tx_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_ETX_FLG
        {
            set { _sa_etx_flg = value; }
            get { return _sa_etx_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_OTX_FLG
        {
            set { _sa_otx_flg = value; }
            get { return _sa_otx_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_FLX_FLG
        {
            set { _sa_flx_flg = value; }
            get { return _sa_flx_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_GUIJI_FLAG
        {
            set { _sa_guiji_flag = value; }
            get { return _sa_guiji_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_PRT_FLG
        {
            set { _sa_prt_flg = value; }
            get { return _sa_prt_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_FILLER
        {
            set { _sa_filler = value; }
            get { return _sa_filler; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_RMRK_1
        {
            set { _sa_rmrk_1 = value; }
            get { return _sa_rmrk_1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_OP_CUST_NAME
        {
            set { _sa_op_cust_name = value; }
            get { return _sa_op_cust_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_AGT_CERT_TYP
        {
            set { _sa_agt_cert_typ = value; }
            get { return _sa_agt_cert_typ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_AGT_CERT_ID
        {
            set { _sa_agt_cert_id = value; }
            get { return _sa_agt_cert_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_AGT_CUST_NAME
        {
            set { _sa_agt_cust_name = value; }
            get { return _sa_agt_cust_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_BELONG_INSTN_COD
        {
            set { _sa_belong_instn_cod = value; }
            get { return _sa_belong_instn_cod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_CHANNEL_FLAG
        {
            set { _sa_channel_flag = value; }
            get { return _sa_channel_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_PDP_CODE
        {
            set { _sa_pdp_code = value; }
            get { return _sa_pdp_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_OP_ACCT_NO_32
        {
            set { _sa_op_acct_no_32 = value; }
            get { return _sa_op_acct_no_32; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_OP_BANK_NO
        {
            set { _sa_op_bank_no = value; }
            get { return _sa_op_bank_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_SUP_TLR
        {
            set { _sa_sup_tlr = value; }
            get { return _sa_sup_tlr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SA_DB_PART_ID
        {
            set { _sa_db_part_id = value; }
            get { return _sa_db_part_id; }
        }
        #endregion Model
    }
}