using System;
namespace MZSYCORE.Model
{
	/// <summary>
	/// Model_CBOD_TDACNACN:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Model_CBOD_TDACNACN
	{
		public Model_CBOD_TDACNACN()
		{}
		#region Model
		private string _etldt;
		private decimal? _tdacn_ll;
		private string _td_td_acct_no;
		private decimal? _tdacn_db_timestamp;
		private decimal? _td_vrsn_no_n;
		private string _td_curr_cod;
		private string _td_vip_acct_flg;
		private string _td_back;
		private decimal? _td_tdp_intr;
		private decimal? _td_dep_prd_n;
		private decimal? _td_dep_drw_cycl_n;
		private string _td_due_dt;
		private string _td_td_rmrk;
		private string _td_frz_sts;
		private string _td_frz_dt;
		private string _td_frz_tm;
		private decimal? _td_fltr_fvr;
		private string _td_dl_flg;
		private string _td_dl_dt;
		private string _td_dl_tm;
		private string _td_mbstmt_addr;
		private string _td_clsd_dt;
		private string _td_opac_tlr_no;
		private decimal? _td_opac_amt;
		private string _td_opac_ints_dt;
		private string _td_opac_dt;
		private string _td_cust_no;
		private decimal? _td_accum_dep_amt;
		private decimal? _td_accum_pdt;
		private decimal? _td_accum_drw_amt;
		private decimal? _td_pprd_drw_amt;
		private string _td_qpswd;
		private decimal? _td_actu_amt;
		private string _td_as_exc_flag;
		private string _td_dw_rang;
		private string _td_adv_drw_dt;
		private string _td_adv_drw_dsgn;
		private string _td_cacct_tlr_no;
		private string _td_nacct_no;
		private string _td_oacct_no;
		private decimal? _td_prds_dep_prd1_n;
		private decimal? _td_prds_dep_prd2_n;
		private string _td_acct_typ;
		private decimal? _td_cvrt_fxr;
		private string _td_drw_typ;
		private string _td_lhypo_flg;
		private decimal? _td_cycl_dep_amt;
		private string _td_trno_acc_no;
		private decimal? _td_trnd_tdp_int;
		private string _td_trnd_duedt;
		private decimal? _td_trnd_amt;
		private string _td_trnd_intc_dt;
		private decimal? _td_trnt_tm_n;
		private string _td_mng_dep_knd;
		private string _td_acct_sts;
		private decimal? _td_psbk_no_n;
		private string _td_lst_tx_dt;
		private string _td_dep_typ;
		private string _td_opac_instn_no;
		private string _td_cacct_instn_no;
		private string _td_acct_char;
		private string _td_tdp_psbk_flg;
		private string _td_pswd_sts;
		private string _td_pswd_dl_dt;
		private string _td_seal_sts;
		private string _td_seal_dl_dt;
		private string _td_mng_flg;
		private string _td_mng_acc_no;
		private decimal? _td_clsd_int;
		private string _td_part_drw_flg;
		private decimal? _td_int_amt;
		private string _td_prt_flg;
		private string _td_cust_name;
		private string _td_acc1_no;
		private string _td_doc_typ;
		private string _td_curr_char;
		private decimal? _td_psbk_sq_no_n;
		private decimal? _td_adv_drw_amt;
		private string _td_curr_iden;
		private string _td_pswd_dl_tm;
		private string _td_seal_dl_tm;
		private string _td_wk_date;
		private string _td_tx_dt;
		private string _td_tx_tm;
		private decimal? _td_cert_num;
		private decimal? _td_prt_num;
		private decimal? _td_trt_val;
		private string _td_int_tax_rpt_flg;
		private string _td_tax_flg;
		private string _td_conntr_no;
		private string _td_large_dep_flg;
		private string _td_fltr_typ;
		private string _td_fltr_fvr_sign;
		private string _td_input_intr_flg;
		private string _td_belong_to_flg;
		private string _td_trno_acc_brch_no;
		private decimal? _td_org_opac_amt;
		private decimal? _td_adv_no_n;
		private decimal? _td_accum_sa_pdt;
		private string _td_tdp_psbk_prt_no;
		private string _td_pdp_code;
		private string _td_pdp_code_c1;
		private string _td_pdp_code_c2;
		private string _td_intr_cod;
		private string _td_dp_rang;
		private string _td_slcrd_no;
		private string _td_cert_prt_no;
		private string _td_pswd_rule;
		private string _td_pswd_vrsn_no1;
		private decimal? _td_pswd_err_times_n;
		private decimal? _td_part_frz_amt;
		private string _td_cert_typ;
		private string _td_cert_id;
		private string _td_belong_instn_cod;
		private decimal? _td_pend_int;
		private decimal? _td_pend_inttax;
		private string _td_jur_frz_sts;
		private decimal? _td_jur_part_frz_amt;
		private string _td_jur_frz_dt;
		private string _td_jur_frz_tm;
		private decimal? _td_clsd_taxint;
		private decimal? _td_clsd_inttax;
		private string _td_ases_instn_cod;
		private string _td_db_part_id;
		/// <summary>
		/// 
		/// </summary>
		public string ETLDT
		{
			set{ _etldt=value;}
			get{return _etldt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TDACN_LL
		{
			set{ _tdacn_ll=value;}
			get{return _tdacn_ll;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TD_ACCT_NO
		{
			set{ _td_td_acct_no=value;}
			get{return _td_td_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TDACN_DB_TIMESTAMP
		{
			set{ _tdacn_db_timestamp=value;}
			get{return _tdacn_db_timestamp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_VRSN_NO_N
		{
			set{ _td_vrsn_no_n=value;}
			get{return _td_vrsn_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CURR_COD
		{
			set{ _td_curr_cod=value;}
			get{return _td_curr_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_VIP_ACCT_FLG
		{
			set{ _td_vip_acct_flg=value;}
			get{return _td_vip_acct_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_BACK
		{
			set{ _td_back=value;}
			get{return _td_back;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_TDP_INTR
		{
			set{ _td_tdp_intr=value;}
			get{return _td_tdp_intr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_DEP_PRD_N
		{
			set{ _td_dep_prd_n=value;}
			get{return _td_dep_prd_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_DEP_DRW_CYCL_N
		{
			set{ _td_dep_drw_cycl_n=value;}
			get{return _td_dep_drw_cycl_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DUE_DT
		{
			set{ _td_due_dt=value;}
			get{return _td_due_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TD_RMRK
		{
			set{ _td_td_rmrk=value;}
			get{return _td_td_rmrk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_FRZ_STS
		{
			set{ _td_frz_sts=value;}
			get{return _td_frz_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_FRZ_DT
		{
			set{ _td_frz_dt=value;}
			get{return _td_frz_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_FRZ_TM
		{
			set{ _td_frz_tm=value;}
			get{return _td_frz_tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_FLTR_FVR
		{
			set{ _td_fltr_fvr=value;}
			get{return _td_fltr_fvr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DL_FLG
		{
			set{ _td_dl_flg=value;}
			get{return _td_dl_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DL_DT
		{
			set{ _td_dl_dt=value;}
			get{return _td_dl_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DL_TM
		{
			set{ _td_dl_tm=value;}
			get{return _td_dl_tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_MBSTMT_ADDR
		{
			set{ _td_mbstmt_addr=value;}
			get{return _td_mbstmt_addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CLSD_DT
		{
			set{ _td_clsd_dt=value;}
			get{return _td_clsd_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_OPAC_TLR_NO
		{
			set{ _td_opac_tlr_no=value;}
			get{return _td_opac_tlr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_OPAC_AMT
		{
			set{ _td_opac_amt=value;}
			get{return _td_opac_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_OPAC_INTS_DT
		{
			set{ _td_opac_ints_dt=value;}
			get{return _td_opac_ints_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_OPAC_DT
		{
			set{ _td_opac_dt=value;}
			get{return _td_opac_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CUST_NO
		{
			set{ _td_cust_no=value;}
			get{return _td_cust_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ACCUM_DEP_AMT
		{
			set{ _td_accum_dep_amt=value;}
			get{return _td_accum_dep_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ACCUM_PDT
		{
			set{ _td_accum_pdt=value;}
			get{return _td_accum_pdt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ACCUM_DRW_AMT
		{
			set{ _td_accum_drw_amt=value;}
			get{return _td_accum_drw_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PPRD_DRW_AMT
		{
			set{ _td_pprd_drw_amt=value;}
			get{return _td_pprd_drw_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_QPSWD
		{
			set{ _td_qpswd=value;}
			get{return _td_qpswd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ACTU_AMT
		{
			set{ _td_actu_amt=value;}
			get{return _td_actu_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_AS_EXC_FLAG
		{
			set{ _td_as_exc_flag=value;}
			get{return _td_as_exc_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DW_RANG
		{
			set{ _td_dw_rang=value;}
			get{return _td_dw_rang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ADV_DRW_DT
		{
			set{ _td_adv_drw_dt=value;}
			get{return _td_adv_drw_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ADV_DRW_DSGN
		{
			set{ _td_adv_drw_dsgn=value;}
			get{return _td_adv_drw_dsgn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CACCT_TLR_NO
		{
			set{ _td_cacct_tlr_no=value;}
			get{return _td_cacct_tlr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_NACCT_NO
		{
			set{ _td_nacct_no=value;}
			get{return _td_nacct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_OACCT_NO
		{
			set{ _td_oacct_no=value;}
			get{return _td_oacct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PRDS_DEP_PRD1_N
		{
			set{ _td_prds_dep_prd1_n=value;}
			get{return _td_prds_dep_prd1_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PRDS_DEP_PRD2_N
		{
			set{ _td_prds_dep_prd2_n=value;}
			get{return _td_prds_dep_prd2_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ACCT_TYP
		{
			set{ _td_acct_typ=value;}
			get{return _td_acct_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_CVRT_FXR
		{
			set{ _td_cvrt_fxr=value;}
			get{return _td_cvrt_fxr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DRW_TYP
		{
			set{ _td_drw_typ=value;}
			get{return _td_drw_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_LHYPO_FLG
		{
			set{ _td_lhypo_flg=value;}
			get{return _td_lhypo_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_CYCL_DEP_AMT
		{
			set{ _td_cycl_dep_amt=value;}
			get{return _td_cycl_dep_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TRNO_ACC_NO
		{
			set{ _td_trno_acc_no=value;}
			get{return _td_trno_acc_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_TRND_TDP_INT
		{
			set{ _td_trnd_tdp_int=value;}
			get{return _td_trnd_tdp_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TRND_DUEDT
		{
			set{ _td_trnd_duedt=value;}
			get{return _td_trnd_duedt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_TRND_AMT
		{
			set{ _td_trnd_amt=value;}
			get{return _td_trnd_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TRND_INTC_DT
		{
			set{ _td_trnd_intc_dt=value;}
			get{return _td_trnd_intc_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_TRNT_TM_N
		{
			set{ _td_trnt_tm_n=value;}
			get{return _td_trnt_tm_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_MNG_DEP_KND
		{
			set{ _td_mng_dep_knd=value;}
			get{return _td_mng_dep_knd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ACCT_STS
		{
			set{ _td_acct_sts=value;}
			get{return _td_acct_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PSBK_NO_N
		{
			set{ _td_psbk_no_n=value;}
			get{return _td_psbk_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_LST_TX_DT
		{
			set{ _td_lst_tx_dt=value;}
			get{return _td_lst_tx_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DEP_TYP
		{
			set{ _td_dep_typ=value;}
			get{return _td_dep_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_OPAC_INSTN_NO
		{
			set{ _td_opac_instn_no=value;}
			get{return _td_opac_instn_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CACCT_INSTN_NO
		{
			set{ _td_cacct_instn_no=value;}
			get{return _td_cacct_instn_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ACCT_CHAR
		{
			set{ _td_acct_char=value;}
			get{return _td_acct_char;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TDP_PSBK_FLG
		{
			set{ _td_tdp_psbk_flg=value;}
			get{return _td_tdp_psbk_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PSWD_STS
		{
			set{ _td_pswd_sts=value;}
			get{return _td_pswd_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PSWD_DL_DT
		{
			set{ _td_pswd_dl_dt=value;}
			get{return _td_pswd_dl_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_SEAL_STS
		{
			set{ _td_seal_sts=value;}
			get{return _td_seal_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_SEAL_DL_DT
		{
			set{ _td_seal_dl_dt=value;}
			get{return _td_seal_dl_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_MNG_FLG
		{
			set{ _td_mng_flg=value;}
			get{return _td_mng_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_MNG_ACC_NO
		{
			set{ _td_mng_acc_no=value;}
			get{return _td_mng_acc_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_CLSD_INT
		{
			set{ _td_clsd_int=value;}
			get{return _td_clsd_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PART_DRW_FLG
		{
			set{ _td_part_drw_flg=value;}
			get{return _td_part_drw_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_INT_AMT
		{
			set{ _td_int_amt=value;}
			get{return _td_int_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PRT_FLG
		{
			set{ _td_prt_flg=value;}
			get{return _td_prt_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CUST_NAME
		{
			set{ _td_cust_name=value;}
			get{return _td_cust_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ACC1_NO
		{
			set{ _td_acc1_no=value;}
			get{return _td_acc1_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DOC_TYP
		{
			set{ _td_doc_typ=value;}
			get{return _td_doc_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CURR_CHAR
		{
			set{ _td_curr_char=value;}
			get{return _td_curr_char;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PSBK_SQ_NO_N
		{
			set{ _td_psbk_sq_no_n=value;}
			get{return _td_psbk_sq_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ADV_DRW_AMT
		{
			set{ _td_adv_drw_amt=value;}
			get{return _td_adv_drw_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CURR_IDEN
		{
			set{ _td_curr_iden=value;}
			get{return _td_curr_iden;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PSWD_DL_TM
		{
			set{ _td_pswd_dl_tm=value;}
			get{return _td_pswd_dl_tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_SEAL_DL_TM
		{
			set{ _td_seal_dl_tm=value;}
			get{return _td_seal_dl_tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_WK_DATE
		{
			set{ _td_wk_date=value;}
			get{return _td_wk_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TX_DT
		{
			set{ _td_tx_dt=value;}
			get{return _td_tx_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TX_TM
		{
			set{ _td_tx_tm=value;}
			get{return _td_tx_tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_CERT_NUM
		{
			set{ _td_cert_num=value;}
			get{return _td_cert_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PRT_NUM
		{
			set{ _td_prt_num=value;}
			get{return _td_prt_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_TRT_VAL
		{
			set{ _td_trt_val=value;}
			get{return _td_trt_val;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_INT_TAX_RPT_FLG
		{
			set{ _td_int_tax_rpt_flg=value;}
			get{return _td_int_tax_rpt_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TAX_FLG
		{
			set{ _td_tax_flg=value;}
			get{return _td_tax_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CONNTR_NO
		{
			set{ _td_conntr_no=value;}
			get{return _td_conntr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_LARGE_DEP_FLG
		{
			set{ _td_large_dep_flg=value;}
			get{return _td_large_dep_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_FLTR_TYP
		{
			set{ _td_fltr_typ=value;}
			get{return _td_fltr_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_FLTR_FVR_SIGN
		{
			set{ _td_fltr_fvr_sign=value;}
			get{return _td_fltr_fvr_sign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_INPUT_INTR_FLG
		{
			set{ _td_input_intr_flg=value;}
			get{return _td_input_intr_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_BELONG_TO_FLG
		{
			set{ _td_belong_to_flg=value;}
			get{return _td_belong_to_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TRNO_ACC_BRCH_NO
		{
			set{ _td_trno_acc_brch_no=value;}
			get{return _td_trno_acc_brch_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ORG_OPAC_AMT
		{
			set{ _td_org_opac_amt=value;}
			get{return _td_org_opac_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ADV_NO_N
		{
			set{ _td_adv_no_n=value;}
			get{return _td_adv_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_ACCUM_SA_PDT
		{
			set{ _td_accum_sa_pdt=value;}
			get{return _td_accum_sa_pdt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_TDP_PSBK_PRT_NO
		{
			set{ _td_tdp_psbk_prt_no=value;}
			get{return _td_tdp_psbk_prt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PDP_CODE
		{
			set{ _td_pdp_code=value;}
			get{return _td_pdp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PDP_CODE_C1
		{
			set{ _td_pdp_code_c1=value;}
			get{return _td_pdp_code_c1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PDP_CODE_C2
		{
			set{ _td_pdp_code_c2=value;}
			get{return _td_pdp_code_c2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_INTR_COD
		{
			set{ _td_intr_cod=value;}
			get{return _td_intr_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DP_RANG
		{
			set{ _td_dp_rang=value;}
			get{return _td_dp_rang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_SLCRD_NO
		{
			set{ _td_slcrd_no=value;}
			get{return _td_slcrd_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CERT_PRT_NO
		{
			set{ _td_cert_prt_no=value;}
			get{return _td_cert_prt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PSWD_RULE
		{
			set{ _td_pswd_rule=value;}
			get{return _td_pswd_rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_PSWD_VRSN_NO1
		{
			set{ _td_pswd_vrsn_no1=value;}
			get{return _td_pswd_vrsn_no1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PSWD_ERR_TIMES_N
		{
			set{ _td_pswd_err_times_n=value;}
			get{return _td_pswd_err_times_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PART_FRZ_AMT
		{
			set{ _td_part_frz_amt=value;}
			get{return _td_part_frz_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CERT_TYP
		{
			set{ _td_cert_typ=value;}
			get{return _td_cert_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_CERT_ID
		{
			set{ _td_cert_id=value;}
			get{return _td_cert_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_BELONG_INSTN_COD
		{
			set{ _td_belong_instn_cod=value;}
			get{return _td_belong_instn_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PEND_INT
		{
			set{ _td_pend_int=value;}
			get{return _td_pend_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_PEND_INTTAX
		{
			set{ _td_pend_inttax=value;}
			get{return _td_pend_inttax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_JUR_FRZ_STS
		{
			set{ _td_jur_frz_sts=value;}
			get{return _td_jur_frz_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_JUR_PART_FRZ_AMT
		{
			set{ _td_jur_part_frz_amt=value;}
			get{return _td_jur_part_frz_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_JUR_FRZ_DT
		{
			set{ _td_jur_frz_dt=value;}
			get{return _td_jur_frz_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_JUR_FRZ_TM
		{
			set{ _td_jur_frz_tm=value;}
			get{return _td_jur_frz_tm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_CLSD_TAXINT
		{
			set{ _td_clsd_taxint=value;}
			get{return _td_clsd_taxint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TD_CLSD_INTTAX
		{
			set{ _td_clsd_inttax=value;}
			get{return _td_clsd_inttax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_ASES_INSTN_COD
		{
			set{ _td_ases_instn_cod=value;}
			get{return _td_ases_instn_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TD_DB_PART_ID
		{
			set{ _td_db_part_id=value;}
			get{return _td_db_part_id;}
		}
		#endregion Model

	}
}

