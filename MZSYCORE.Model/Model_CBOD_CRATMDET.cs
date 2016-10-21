using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    /// <summary>
    /// Model_CBOD_CRATMDET:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Model_CBOD_CRATMDET
    {
        public Model_CBOD_CRATMDET()
        { }
        #region Model
        private string _etldt;
        private decimal? _crdet_ll;
        private string _fk_cratm_key;
        private string _cr_tx_dt;
        private string _cr_atm_tx_sq_no;
        private decimal? _crdet_db_timestamp;
        private string _cr_belongto_brh;
        private string _cr_rsv_flg;
        private string _cr_curr_cod;
        private string _cr_ec_flg;
        private string _cr_opr_ec;
        private string _cr_entr_dt;
        private string _cr_tx_no;
        private decimal? _cr_tx_amt;
        private string _cr_tx_log_no;
        private string _cr_tx_tm;
        private string _cr_tx_netp_no;
        private string _cr_crd_no;
        private string _cr_cpu_dt;
        private string _cr_gcrd_tx_sq_no;
        private string _cr_drgn_crd_tx_sq_no;
        private string _cr_conf_flg;
        private string _cr_dscrp_cod;
        private string _cr_trni_sav_no;
        private string _cr_trno_sav_no;
        private decimal? _cr_psbk_sq_no_n;
        private string _cr_db_part_id;
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
        public decimal? CRDET_LL
        {
            set { _crdet_ll = value; }
            get { return _crdet_ll; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FK_CRATM_KEY
        {
            set { _fk_cratm_key = value; }
            get { return _fk_cratm_key; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TX_DT
        {
            set { _cr_tx_dt = value; }
            get { return _cr_tx_dt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_ATM_TX_SQ_NO
        {
            set { _cr_atm_tx_sq_no = value; }
            get { return _cr_atm_tx_sq_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CRDET_DB_TIMESTAMP
        {
            set { _crdet_db_timestamp = value; }
            get { return _crdet_db_timestamp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_BELONGTO_BRH
        {
            set { _cr_belongto_brh = value; }
            get { return _cr_belongto_brh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_RSV_FLG
        {
            set { _cr_rsv_flg = value; }
            get { return _cr_rsv_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_CURR_COD
        {
            set { _cr_curr_cod = value; }
            get { return _cr_curr_cod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_EC_FLG
        {
            set { _cr_ec_flg = value; }
            get { return _cr_ec_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_OPR_EC
        {
            set { _cr_opr_ec = value; }
            get { return _cr_opr_ec; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_ENTR_DT
        {
            set { _cr_entr_dt = value; }
            get { return _cr_entr_dt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TX_NO
        {
            set { _cr_tx_no = value; }
            get { return _cr_tx_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CR_TX_AMT
        {
            set { _cr_tx_amt = value; }
            get { return _cr_tx_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TX_LOG_NO
        {
            set { _cr_tx_log_no = value; }
            get { return _cr_tx_log_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TX_TM
        {
            set { _cr_tx_tm = value; }
            get { return _cr_tx_tm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TX_NETP_NO
        {
            set { _cr_tx_netp_no = value; }
            get { return _cr_tx_netp_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_CRD_NO
        {
            set { _cr_crd_no = value; }
            get { return _cr_crd_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_CPU_DT
        {
            set { _cr_cpu_dt = value; }
            get { return _cr_cpu_dt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_GCRD_TX_SQ_NO
        {
            set { _cr_gcrd_tx_sq_no = value; }
            get { return _cr_gcrd_tx_sq_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_DRGN_CRD_TX_SQ_NO
        {
            set { _cr_drgn_crd_tx_sq_no = value; }
            get { return _cr_drgn_crd_tx_sq_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_CONF_FLG
        {
            set { _cr_conf_flg = value; }
            get { return _cr_conf_flg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_DSCRP_COD
        {
            set { _cr_dscrp_cod = value; }
            get { return _cr_dscrp_cod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TRNI_SAV_NO
        {
            set { _cr_trni_sav_no = value; }
            get { return _cr_trni_sav_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_TRNO_SAV_NO
        {
            set { _cr_trno_sav_no = value; }
            get { return _cr_trno_sav_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CR_PSBK_SQ_NO_N
        {
            set { _cr_psbk_sq_no_n = value; }
            get { return _cr_psbk_sq_no_n; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CR_DB_PART_ID
        {
            set { _cr_db_part_id = value; }
            get { return _cr_db_part_id; }
        }
        #endregion Model

    }
}
