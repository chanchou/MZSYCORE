using System;
namespace MZSYCORE.Model
{
	/// <summary>
	/// Model_CBOD_LNLNSLNS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Model_CBOD_LNLNSLNS
	{
		public Model_CBOD_LNLNSLNS()
		{}
		#region Model
		private string _etldt;
		private string _ln_ln_acct_no;
		private decimal? _lnlns_db_timestamp;
		private decimal? _ln_finl_vrsn_n;
		private decimal? _ln_db_mntn_no_n;
		private string _ln_cust_no;
		private string _ln_crlmt_no;
		private string _ln_pdp_code;
		private string _ln_busn_typ;
		private string _ln_acct_sts;
		private string _ln_vip_acct_flg;
		private string _ln_cust_typ;
		private string _ln_curr_cod;
		private string _ln_curr_iden;
		private string _ln_finbusn;
		private string _ln_curr_cod_author;
		private string _ln_ln_typ;
		private string _ln_hypo_typ;
		private decimal? _ln_nwln_amt_hypo_amt;
		private decimal? _ln_totl_ln_amt_hypo_amt;
		private decimal? _ln_ln_bal;
		private decimal? _ln_frst_alfd_dt_n;
		private decimal? _ln_due_dt_n;
		private decimal? _ln_clsd_dt_n;
		private string _ln_rfn_sty;
		private decimal? _ln_rop_cycl_mn_totl_n;
		private string _ln_rop_cycl_unit;
		private decimal? _ln_coli_cycl_totl_mn_n;
		private string _ln_coli_cycl_unit;
		private decimal? _ln_pprd_intp_day_n;
		private decimal? _ln_rop_day_n;
		private decimal? _ln_totl_prd_n;
		private decimal? _ln_arfn_schd_pr_n;
		private decimal? _ln_arfn_schd_int_n;
		private decimal? _ln_tnrno_n;
		private decimal? _ln_ln_mths_n;
		private decimal? _ln_pr_cac_dt_n;
		private decimal? _ln_intc_up_dt_n;
		private decimal? _ln_intc_up_dt_odd_days_n;
		private decimal? _ln_last_intc_up_dt_n;
		private decimal? _ln_int_intc_up_dt_n;
		private string _ln_pmn_intc_cod;
		private string _ln_clsd_intc_typ;
		private decimal? _ln_frst_intc_intr;
		private decimal? _ln_frst_delay_intr;
		private string _ln_intr_adj_sty;
		private string _ln_intr_adj_cycl;
		private decimal? _ln_intr_adj_strt_dt_n;
		private decimal? _ln_intr_eff_dt_n;
		private string _ln_intr_acor_sty;
		private string _ln_intr_typ;
		private string _ln_intr_nego_symb;
		private decimal? _ln_intr_nego_rate;
		private string _ln_dlay_intr_acor_sty;
		private string _ln_dlay_intr_typ;
		private string _ln_dlay_intr_plmn_symb;
		private decimal? _ln_dlay_intr_plmn_cod;
		private string _ln_ln_fund_rsur;
		private string _ln_ln_purp;
		private string _ln_ln_sty;
		private string _ln_use_book_flg;
		private string _ln_multi_rfn_flg;
		private decimal? _ln_rct_extn_dt_n;
		private string _ln_extn_ctrt_no;
		private decimal? _ln_extn_tm_n;
		private decimal? _ln_ext_seq_no_n;
		private decimal? _ln_busn_typ_chg_dt_n;
		private string _ln_busn_typ_new;
		private string _ln_busn_typ_org;
		private decimal? _ln_chg_rfn_sty_dt_n;
		private string _ln_chg_rfn_sty;
		private decimal? _ln_int_strv_dt_n;
		private string _ln_pr_ints_flag;
		private string _ln_int_ints_flag;
		private decimal? _ln_ints_eff_dt_n;
		private string _ln_halt_intc_symb;
		private decimal? _ln_halt_strt_dt_n;
		private decimal? _ln_halt_cut_dt_n;
		private string _ln_coll_svc_sty;
		private decimal? _ln_svc_rto;
		private decimal? _ln_trto;
		private decimal? _ln_rop_duran_n;
		private string _ln_duran_intc_flg;
		private decimal? _ln_pr_tole_days_n;
		private decimal? _ln_int_duran_days_n;
		private string _ln_pay_seq_flg;
		private string _ln_auto_ddut_pr_flg;
		private string _ln_auto_dedu_int_flg;
		private string _ln_dly_auto_pay_flg;
		private string _ln_auto_dedu_dep_acct_no_1;
		private string _ln_auto_dedu_dep_acct_no_2;
		private string _ln_auto_dedu_dep_acct_no_3;
		private string _ln_auto_dedu_acct_typ_1;
		private string _ln_auto_dedu_acct_typ_2;
		private string _ln_auto_dedu_acct_typ_3;
		private string _ln_ln_to_dep_flg;
		private string _ln_dep_acct_no;
		private string _ln_pay_int_acct_no;
		private string _ln_zhibiao_no;
		private string _ln_fac_cod;
		private string _ln_dlf_cod;
		private string _ln_lnb_cod;
		private string _ln_filler1_cod;
		private string _ln_filler2_cod;
		private decimal? _ln_int_dis_end_dt_n;
		private decimal? _ln_int_dis_rate_n;
		private string _ln_fund_to_auor_flg;
		private string _ln_fund_acct_no;
		private string _ln_auor_dep_acct_no;
		private string _ln_guar_margin_acct_no;
		private decimal? _ln_td_psbk_no_n;
		private decimal? _ln_td_psbk_seq_no_n;
		private decimal? _ln_frz_dt_n;
		private string _ln_rwhld_no;
		private string _ln_hypo_sq_no;
		private string _ln_man_tovd_flg;
		private string _ln_bad_ln_flg;
		private string _ln_signl_ln_inturn_table;
		private string _ln_instal_rfn_plan;
		private string _ln_instal_multi_rfn_sty;
		private decimal? _ln_pprd_rfn_amt;
		private decimal? _ln_crnt_prd_rtn_amt;
		private decimal? _ln_crnt_prd_payrbl_pr;
		private decimal? _ln_crnt_prd_payrbl_int;
		private decimal? _ln_next_prd_arfn_amt;
		private decimal? _ln_next_prd_payrbl_int;
		private decimal? _ln_whhd_pr_accrud;
		private decimal? _ln_whhd_int_accrud;
		private decimal? _ln_intrbl_int;
		private decimal? _ln_dlay_int_int;
		private decimal? _ln_ovdln_intrbl;
		private decimal? _ln_crnt_ovdln_int_int;
		private decimal? _ln_crnt_ovdln_intrbl;
		private decimal? _ln_crnt_ovdln_ln_intr;
		private decimal? _ln_devlu_int;
		private string _ln_apcl_flg;
		private decimal? _ln_int_apcl_totl_inplan;
		private decimal? _ln_intrbl_apcl_amt_totl;
		private decimal? _ln_ovdln_intrbl_apcl_totl;
		private decimal? _ln_ovdln_int_apcl_totl;
		private decimal? _ln_lsac_int_apcl_totl;
		private decimal? _ln_pr_apcl_totl;
		private decimal? _ln_crnt_yr_intrbl;
		private decimal? _ln_yhead_rbl_ucoll_ln_int;
		private decimal? _ln_arr_pr;
		private decimal? _ln_dlay_pr_totl;
		private decimal? _ln_tovdln_pr_bal;
		private decimal? _ln_dlay_ln_dt_n;
		private decimal? _ln_trnlst_ovd_dt_n;
		private string _ln_dlay_ln_rsn;
		private string _ln_dlay_rsk_rtng;
		private decimal? _ln_fovdln_sq_dt_n;
		private decimal? _ln_dlay_ln_frn_dt_n;
		private string _ln_dlay_ln_rfn_rsn;
		private decimal? _ln_dlay_ln_rfn_amt;
		private decimal? _ln_derate_penalty_totl;
		private decimal? _ln_derate_arramt_totl;
		private string _ln_rop_roi_excs_flag;
		private decimal? _ln_incr_decr_amt;
		private decimal? _ln_eqprop_incr_decr;
		private decimal? _ln_incr_decr_init_prd_n;
		private decimal? _ln_incr_decr_inter_prd_n;
		private string _ln_close_flg;
		private string _ln_synln_flg;
		private string _ln_rcpt_no;
		private string _ln_rmrk;
		private string _ln_fs_acct;
		private string _ln_cust_name;
		private string _ln_cert_typ;
		private string _ln_cert_id;
		private string _ln_custd_rcpt_ref_no;
		private string _ln_dtl_prt_flag;
		private decimal? _ln_dtl_prt_pg_n;
		private string _ln_dtl_prt_keys;
		private decimal? _ln_ltst_risk_typ_dt_n;
		private decimal? _ln_ltst_pr_mv_dt_n;
		private decimal? _ln_ltst_pr_mv_tm_n;
		private decimal? _ln_arr_amt;
		private decimal? _ln_penalty;
		private decimal? _ln_penl_strt_dt_n;
		private decimal? _ln_svc_bal;
		private decimal? _ln_rcv_int_totl;
		private decimal? _ln_accum_coli;
		private decimal? _ln_accum_recv_pnl;
		private decimal? _ln_accum_recv_svc;
		private decimal? _ln_advpmt_totl;
		private decimal? _ln_yhead_ln_bal;
		private decimal? _ln_crnt_yr_ln_accum;
		private decimal? _ln_crnt_yr_rev_accum;
		private decimal? _ln_crnt_yr_colled_int;
		private string _ln_exce_flg;
		private string _ln_fs_flg;
		private string _ln_hyp_flg;
		private string _ln_nacct_sts;
		private string _ln_accp_typ;
		private string _ln_guar_accp_expt_no;
		private string _ln_nor_back_flg;
		private decimal? _ln_hunt_due_dt_n;
		private string _ln_loc_city_flg;
		private string _ln_int_rcpt_mail;
		private string _ln_dlay_adv;
		private string _ln_rfn_rcpt_mail;
		private string _ln_mbstmt_cycl;
		private decimal? _ln_mbstmt_dt_n;
		private string _ln_cacl_intr_cycl;
		private string _ln_cacl_intr_dt;
		private string _ln_cacl_intr_flg;
		private decimal? _ln_fstm_rfn_dt_n;
		private decimal? _ln_fstm_intp_dt_n;
		private decimal? _ln_next_pr_rfn_dt_n;
		private decimal? _ln_next_int_rfn_dt_n;
		private string _ln_old_ln_acct_trni;
		private string _ln_nwln_acct_no_trno;
		private string _ln_aalfd_sucs;
		private string _ln_flst_tlr_no;
		private string _ln_flst_aprv_pic_no;
		private decimal? _ln_flst_dt_n;
		private string _ln_ltst_mntn_opr_no;
		private string _ln_ltst_aprv_pic_no;
		private string _ln_spv;
		private decimal? _ln_ltst_mntn_dt_n;
		private string _ln_crnt_day_fst_tx_sq_no;
		private string _ln_crnt_day_lst_tx_sq_no;
		private string _ln_rop_intc_sty_flg;
		private string _ln_int_intc_sty_flg;
		private decimal? _ln_adv_rfn_tot_num_n;
		private decimal? _ln_curr_cycl_fac_yr_n;
		private decimal? _ln_curr_cycl_adv_num_n;
		private string _ln_psbk_prt_no;
		private string _ln_intr_adj_day;
		private string _ln_aauto_rop;
		private decimal? _ln_rop_duran_cutdt_n;
		private decimal? _ln_appl_due_dt_n;
		private string _ln_cnl_no;
		private string _ln_belong_instn_cod;
		private string _ln_ass_opun_no;
		private string _ln_ltst_mntn_opun_no;
		private string _ln_trs_old_sys_flg;
		private string _ln_flst_opun_no;
		private string _ln_db_part_id;
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
		public string LN_LN_ACCT_NO
		{
			set{ _ln_ln_acct_no=value;}
			get{return _ln_ln_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LNLNS_DB_TIMESTAMP
		{
			set{ _lnlns_db_timestamp=value;}
			get{return _lnlns_db_timestamp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FINL_VRSN_N
		{
			set{ _ln_finl_vrsn_n=value;}
			get{return _ln_finl_vrsn_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DB_MNTN_NO_N
		{
			set{ _ln_db_mntn_no_n=value;}
			get{return _ln_db_mntn_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CUST_NO
		{
			set{ _ln_cust_no=value;}
			get{return _ln_cust_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CRLMT_NO
		{
			set{ _ln_crlmt_no=value;}
			get{return _ln_crlmt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_PDP_CODE
		{
			set{ _ln_pdp_code=value;}
			get{return _ln_pdp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_BUSN_TYP
		{
			set{ _ln_busn_typ=value;}
			get{return _ln_busn_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ACCT_STS
		{
			set{ _ln_acct_sts=value;}
			get{return _ln_acct_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_VIP_ACCT_FLG
		{
			set{ _ln_vip_acct_flg=value;}
			get{return _ln_vip_acct_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CUST_TYP
		{
			set{ _ln_cust_typ=value;}
			get{return _ln_cust_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CURR_COD
		{
			set{ _ln_curr_cod=value;}
			get{return _ln_curr_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CURR_IDEN
		{
			set{ _ln_curr_iden=value;}
			get{return _ln_curr_iden;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FINBUSN
		{
			set{ _ln_finbusn=value;}
			get{return _ln_finbusn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CURR_COD_AUTHOR
		{
			set{ _ln_curr_cod_author=value;}
			get{return _ln_curr_cod_author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LN_TYP
		{
			set{ _ln_ln_typ=value;}
			get{return _ln_ln_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_HYPO_TYP
		{
			set{ _ln_hypo_typ=value;}
			get{return _ln_hypo_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_NWLN_AMT_HYPO_AMT
		{
			set{ _ln_nwln_amt_hypo_amt=value;}
			get{return _ln_nwln_amt_hypo_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TOTL_LN_AMT_HYPO_AMT
		{
			set{ _ln_totl_ln_amt_hypo_amt=value;}
			get{return _ln_totl_ln_amt_hypo_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LN_BAL
		{
			set{ _ln_ln_bal=value;}
			get{return _ln_ln_bal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FRST_ALFD_DT_N
		{
			set{ _ln_frst_alfd_dt_n=value;}
			get{return _ln_frst_alfd_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DUE_DT_N
		{
			set{ _ln_due_dt_n=value;}
			get{return _ln_due_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CLSD_DT_N
		{
			set{ _ln_clsd_dt_n=value;}
			get{return _ln_clsd_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_RFN_STY
		{
			set{ _ln_rfn_sty=value;}
			get{return _ln_rfn_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ROP_CYCL_MN_TOTL_N
		{
			set{ _ln_rop_cycl_mn_totl_n=value;}
			get{return _ln_rop_cycl_mn_totl_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ROP_CYCL_UNIT
		{
			set{ _ln_rop_cycl_unit=value;}
			get{return _ln_rop_cycl_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_COLI_CYCL_TOTL_MN_N
		{
			set{ _ln_coli_cycl_totl_mn_n=value;}
			get{return _ln_coli_cycl_totl_mn_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_COLI_CYCL_UNIT
		{
			set{ _ln_coli_cycl_unit=value;}
			get{return _ln_coli_cycl_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PPRD_INTP_DAY_N
		{
			set{ _ln_pprd_intp_day_n=value;}
			get{return _ln_pprd_intp_day_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ROP_DAY_N
		{
			set{ _ln_rop_day_n=value;}
			get{return _ln_rop_day_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TOTL_PRD_N
		{
			set{ _ln_totl_prd_n=value;}
			get{return _ln_totl_prd_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ARFN_SCHD_PR_N
		{
			set{ _ln_arfn_schd_pr_n=value;}
			get{return _ln_arfn_schd_pr_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ARFN_SCHD_INT_N
		{
			set{ _ln_arfn_schd_int_n=value;}
			get{return _ln_arfn_schd_int_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TNRNO_N
		{
			set{ _ln_tnrno_n=value;}
			get{return _ln_tnrno_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LN_MTHS_N
		{
			set{ _ln_ln_mths_n=value;}
			get{return _ln_ln_mths_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PR_CAC_DT_N
		{
			set{ _ln_pr_cac_dt_n=value;}
			get{return _ln_pr_cac_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTC_UP_DT_N
		{
			set{ _ln_intc_up_dt_n=value;}
			get{return _ln_intc_up_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTC_UP_DT_ODD_DAYS_N
		{
			set{ _ln_intc_up_dt_odd_days_n=value;}
			get{return _ln_intc_up_dt_odd_days_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LAST_INTC_UP_DT_N
		{
			set{ _ln_last_intc_up_dt_n=value;}
			get{return _ln_last_intc_up_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INT_INTC_UP_DT_N
		{
			set{ _ln_int_intc_up_dt_n=value;}
			get{return _ln_int_intc_up_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_PMN_INTC_COD
		{
			set{ _ln_pmn_intc_cod=value;}
			get{return _ln_pmn_intc_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CLSD_INTC_TYP
		{
			set{ _ln_clsd_intc_typ=value;}
			get{return _ln_clsd_intc_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FRST_INTC_INTR
		{
			set{ _ln_frst_intc_intr=value;}
			get{return _ln_frst_intc_intr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FRST_DELAY_INTR
		{
			set{ _ln_frst_delay_intr=value;}
			get{return _ln_frst_delay_intr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INTR_ADJ_STY
		{
			set{ _ln_intr_adj_sty=value;}
			get{return _ln_intr_adj_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INTR_ADJ_CYCL
		{
			set{ _ln_intr_adj_cycl=value;}
			get{return _ln_intr_adj_cycl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTR_ADJ_STRT_DT_N
		{
			set{ _ln_intr_adj_strt_dt_n=value;}
			get{return _ln_intr_adj_strt_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTR_EFF_DT_N
		{
			set{ _ln_intr_eff_dt_n=value;}
			get{return _ln_intr_eff_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INTR_ACOR_STY
		{
			set{ _ln_intr_acor_sty=value;}
			get{return _ln_intr_acor_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INTR_TYP
		{
			set{ _ln_intr_typ=value;}
			get{return _ln_intr_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INTR_NEGO_SYMB
		{
			set{ _ln_intr_nego_symb=value;}
			get{return _ln_intr_nego_symb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTR_NEGO_RATE
		{
			set{ _ln_intr_nego_rate=value;}
			get{return _ln_intr_nego_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_INTR_ACOR_STY
		{
			set{ _ln_dlay_intr_acor_sty=value;}
			get{return _ln_dlay_intr_acor_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_INTR_TYP
		{
			set{ _ln_dlay_intr_typ=value;}
			get{return _ln_dlay_intr_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_INTR_PLMN_SYMB
		{
			set{ _ln_dlay_intr_plmn_symb=value;}
			get{return _ln_dlay_intr_plmn_symb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DLAY_INTR_PLMN_COD
		{
			set{ _ln_dlay_intr_plmn_cod=value;}
			get{return _ln_dlay_intr_plmn_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LN_FUND_RSUR
		{
			set{ _ln_ln_fund_rsur=value;}
			get{return _ln_ln_fund_rsur;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LN_PURP
		{
			set{ _ln_ln_purp=value;}
			get{return _ln_ln_purp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LN_STY
		{
			set{ _ln_ln_sty=value;}
			get{return _ln_ln_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_USE_BOOK_FLG
		{
			set{ _ln_use_book_flg=value;}
			get{return _ln_use_book_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_MULTI_RFN_FLG
		{
			set{ _ln_multi_rfn_flg=value;}
			get{return _ln_multi_rfn_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_RCT_EXTN_DT_N
		{
			set{ _ln_rct_extn_dt_n=value;}
			get{return _ln_rct_extn_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_EXTN_CTRT_NO
		{
			set{ _ln_extn_ctrt_no=value;}
			get{return _ln_extn_ctrt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_EXTN_TM_N
		{
			set{ _ln_extn_tm_n=value;}
			get{return _ln_extn_tm_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_EXT_SEQ_NO_N
		{
			set{ _ln_ext_seq_no_n=value;}
			get{return _ln_ext_seq_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_BUSN_TYP_CHG_DT_N
		{
			set{ _ln_busn_typ_chg_dt_n=value;}
			get{return _ln_busn_typ_chg_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_BUSN_TYP_NEW
		{
			set{ _ln_busn_typ_new=value;}
			get{return _ln_busn_typ_new;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_BUSN_TYP_ORG
		{
			set{ _ln_busn_typ_org=value;}
			get{return _ln_busn_typ_org;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CHG_RFN_STY_DT_N
		{
			set{ _ln_chg_rfn_sty_dt_n=value;}
			get{return _ln_chg_rfn_sty_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CHG_RFN_STY
		{
			set{ _ln_chg_rfn_sty=value;}
			get{return _ln_chg_rfn_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INT_STRV_DT_N
		{
			set{ _ln_int_strv_dt_n=value;}
			get{return _ln_int_strv_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_PR_INTS_FLAG
		{
			set{ _ln_pr_ints_flag=value;}
			get{return _ln_pr_ints_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INT_INTS_FLAG
		{
			set{ _ln_int_ints_flag=value;}
			get{return _ln_int_ints_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTS_EFF_DT_N
		{
			set{ _ln_ints_eff_dt_n=value;}
			get{return _ln_ints_eff_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_HALT_INTC_SYMB
		{
			set{ _ln_halt_intc_symb=value;}
			get{return _ln_halt_intc_symb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_HALT_STRT_DT_N
		{
			set{ _ln_halt_strt_dt_n=value;}
			get{return _ln_halt_strt_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_HALT_CUT_DT_N
		{
			set{ _ln_halt_cut_dt_n=value;}
			get{return _ln_halt_cut_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_COLL_SVC_STY
		{
			set{ _ln_coll_svc_sty=value;}
			get{return _ln_coll_svc_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_SVC_RTO
		{
			set{ _ln_svc_rto=value;}
			get{return _ln_svc_rto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TRTO
		{
			set{ _ln_trto=value;}
			get{return _ln_trto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ROP_DURAN_N
		{
			set{ _ln_rop_duran_n=value;}
			get{return _ln_rop_duran_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DURAN_INTC_FLG
		{
			set{ _ln_duran_intc_flg=value;}
			get{return _ln_duran_intc_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PR_TOLE_DAYS_N
		{
			set{ _ln_pr_tole_days_n=value;}
			get{return _ln_pr_tole_days_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INT_DURAN_DAYS_N
		{
			set{ _ln_int_duran_days_n=value;}
			get{return _ln_int_duran_days_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_PAY_SEQ_FLG
		{
			set{ _ln_pay_seq_flg=value;}
			get{return _ln_pay_seq_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DDUT_PR_FLG
		{
			set{ _ln_auto_ddut_pr_flg=value;}
			get{return _ln_auto_ddut_pr_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_INT_FLG
		{
			set{ _ln_auto_dedu_int_flg=value;}
			get{return _ln_auto_dedu_int_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLY_AUTO_PAY_FLG
		{
			set{ _ln_dly_auto_pay_flg=value;}
			get{return _ln_dly_auto_pay_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_DEP_ACCT_NO_1
		{
			set{ _ln_auto_dedu_dep_acct_no_1=value;}
			get{return _ln_auto_dedu_dep_acct_no_1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_DEP_ACCT_NO_2
		{
			set{ _ln_auto_dedu_dep_acct_no_2=value;}
			get{return _ln_auto_dedu_dep_acct_no_2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_DEP_ACCT_NO_3
		{
			set{ _ln_auto_dedu_dep_acct_no_3=value;}
			get{return _ln_auto_dedu_dep_acct_no_3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_ACCT_TYP_1
		{
			set{ _ln_auto_dedu_acct_typ_1=value;}
			get{return _ln_auto_dedu_acct_typ_1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_ACCT_TYP_2
		{
			set{ _ln_auto_dedu_acct_typ_2=value;}
			get{return _ln_auto_dedu_acct_typ_2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUTO_DEDU_ACCT_TYP_3
		{
			set{ _ln_auto_dedu_acct_typ_3=value;}
			get{return _ln_auto_dedu_acct_typ_3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LN_TO_DEP_FLG
		{
			set{ _ln_ln_to_dep_flg=value;}
			get{return _ln_ln_to_dep_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DEP_ACCT_NO
		{
			set{ _ln_dep_acct_no=value;}
			get{return _ln_dep_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_PAY_INT_ACCT_NO
		{
			set{ _ln_pay_int_acct_no=value;}
			get{return _ln_pay_int_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ZHIBIAO_NO
		{
			set{ _ln_zhibiao_no=value;}
			get{return _ln_zhibiao_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FAC_COD
		{
			set{ _ln_fac_cod=value;}
			get{return _ln_fac_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLF_COD
		{
			set{ _ln_dlf_cod=value;}
			get{return _ln_dlf_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LNB_COD
		{
			set{ _ln_lnb_cod=value;}
			get{return _ln_lnb_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FILLER1_COD
		{
			set{ _ln_filler1_cod=value;}
			get{return _ln_filler1_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FILLER2_COD
		{
			set{ _ln_filler2_cod=value;}
			get{return _ln_filler2_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INT_DIS_END_DT_N
		{
			set{ _ln_int_dis_end_dt_n=value;}
			get{return _ln_int_dis_end_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INT_DIS_RATE_N
		{
			set{ _ln_int_dis_rate_n=value;}
			get{return _ln_int_dis_rate_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FUND_TO_AUOR_FLG
		{
			set{ _ln_fund_to_auor_flg=value;}
			get{return _ln_fund_to_auor_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FUND_ACCT_NO
		{
			set{ _ln_fund_acct_no=value;}
			get{return _ln_fund_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AUOR_DEP_ACCT_NO
		{
			set{ _ln_auor_dep_acct_no=value;}
			get{return _ln_auor_dep_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_GUAR_MARGIN_ACCT_NO
		{
			set{ _ln_guar_margin_acct_no=value;}
			get{return _ln_guar_margin_acct_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TD_PSBK_NO_N
		{
			set{ _ln_td_psbk_no_n=value;}
			get{return _ln_td_psbk_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TD_PSBK_SEQ_NO_N
		{
			set{ _ln_td_psbk_seq_no_n=value;}
			get{return _ln_td_psbk_seq_no_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FRZ_DT_N
		{
			set{ _ln_frz_dt_n=value;}
			get{return _ln_frz_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_RWHLD_NO
		{
			set{ _ln_rwhld_no=value;}
			get{return _ln_rwhld_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_HYPO_SQ_NO
		{
			set{ _ln_hypo_sq_no=value;}
			get{return _ln_hypo_sq_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_MAN_TOVD_FLG
		{
			set{ _ln_man_tovd_flg=value;}
			get{return _ln_man_tovd_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_BAD_LN_FLG
		{
			set{ _ln_bad_ln_flg=value;}
			get{return _ln_bad_ln_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_SIGNL_LN_INTURN_TABLE
		{
			set{ _ln_signl_ln_inturn_table=value;}
			get{return _ln_signl_ln_inturn_table;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INSTAL_RFN_PLAN
		{
			set{ _ln_instal_rfn_plan=value;}
			get{return _ln_instal_rfn_plan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INSTAL_MULTI_RFN_STY
		{
			set{ _ln_instal_multi_rfn_sty=value;}
			get{return _ln_instal_multi_rfn_sty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PPRD_RFN_AMT
		{
			set{ _ln_pprd_rfn_amt=value;}
			get{return _ln_pprd_rfn_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_PRD_RTN_AMT
		{
			set{ _ln_crnt_prd_rtn_amt=value;}
			get{return _ln_crnt_prd_rtn_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_PRD_PAYRBL_PR
		{
			set{ _ln_crnt_prd_payrbl_pr=value;}
			get{return _ln_crnt_prd_payrbl_pr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_PRD_PAYRBL_INT
		{
			set{ _ln_crnt_prd_payrbl_int=value;}
			get{return _ln_crnt_prd_payrbl_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_NEXT_PRD_ARFN_AMT
		{
			set{ _ln_next_prd_arfn_amt=value;}
			get{return _ln_next_prd_arfn_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_NEXT_PRD_PAYRBL_INT
		{
			set{ _ln_next_prd_payrbl_int=value;}
			get{return _ln_next_prd_payrbl_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_WHHD_PR_ACCRUD
		{
			set{ _ln_whhd_pr_accrud=value;}
			get{return _ln_whhd_pr_accrud;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_WHHD_INT_ACCRUD
		{
			set{ _ln_whhd_int_accrud=value;}
			get{return _ln_whhd_int_accrud;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTRBL_INT
		{
			set{ _ln_intrbl_int=value;}
			get{return _ln_intrbl_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DLAY_INT_INT
		{
			set{ _ln_dlay_int_int=value;}
			get{return _ln_dlay_int_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_OVDLN_INTRBL
		{
			set{ _ln_ovdln_intrbl=value;}
			get{return _ln_ovdln_intrbl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_OVDLN_INT_INT
		{
			set{ _ln_crnt_ovdln_int_int=value;}
			get{return _ln_crnt_ovdln_int_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_OVDLN_INTRBL
		{
			set{ _ln_crnt_ovdln_intrbl=value;}
			get{return _ln_crnt_ovdln_intrbl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_OVDLN_LN_INTR
		{
			set{ _ln_crnt_ovdln_ln_intr=value;}
			get{return _ln_crnt_ovdln_ln_intr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DEVLU_INT
		{
			set{ _ln_devlu_int=value;}
			get{return _ln_devlu_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_APCL_FLG
		{
			set{ _ln_apcl_flg=value;}
			get{return _ln_apcl_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INT_APCL_TOTL_INPLAN
		{
			set{ _ln_int_apcl_totl_inplan=value;}
			get{return _ln_int_apcl_totl_inplan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INTRBL_APCL_AMT_TOTL
		{
			set{ _ln_intrbl_apcl_amt_totl=value;}
			get{return _ln_intrbl_apcl_amt_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_OVDLN_INTRBL_APCL_TOTL
		{
			set{ _ln_ovdln_intrbl_apcl_totl=value;}
			get{return _ln_ovdln_intrbl_apcl_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_OVDLN_INT_APCL_TOTL
		{
			set{ _ln_ovdln_int_apcl_totl=value;}
			get{return _ln_ovdln_int_apcl_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LSAC_INT_APCL_TOTL
		{
			set{ _ln_lsac_int_apcl_totl=value;}
			get{return _ln_lsac_int_apcl_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PR_APCL_TOTL
		{
			set{ _ln_pr_apcl_totl=value;}
			get{return _ln_pr_apcl_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_YR_INTRBL
		{
			set{ _ln_crnt_yr_intrbl=value;}
			get{return _ln_crnt_yr_intrbl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_YHEAD_RBL_UCOLL_LN_INT
		{
			set{ _ln_yhead_rbl_ucoll_ln_int=value;}
			get{return _ln_yhead_rbl_ucoll_ln_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ARR_PR
		{
			set{ _ln_arr_pr=value;}
			get{return _ln_arr_pr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DLAY_PR_TOTL
		{
			set{ _ln_dlay_pr_totl=value;}
			get{return _ln_dlay_pr_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TOVDLN_PR_BAL
		{
			set{ _ln_tovdln_pr_bal=value;}
			get{return _ln_tovdln_pr_bal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DLAY_LN_DT_N
		{
			set{ _ln_dlay_ln_dt_n=value;}
			get{return _ln_dlay_ln_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_TRNLST_OVD_DT_N
		{
			set{ _ln_trnlst_ovd_dt_n=value;}
			get{return _ln_trnlst_ovd_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_LN_RSN
		{
			set{ _ln_dlay_ln_rsn=value;}
			get{return _ln_dlay_ln_rsn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_RSK_RTNG
		{
			set{ _ln_dlay_rsk_rtng=value;}
			get{return _ln_dlay_rsk_rtng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FOVDLN_SQ_DT_N
		{
			set{ _ln_fovdln_sq_dt_n=value;}
			get{return _ln_fovdln_sq_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DLAY_LN_FRN_DT_N
		{
			set{ _ln_dlay_ln_frn_dt_n=value;}
			get{return _ln_dlay_ln_frn_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_LN_RFN_RSN
		{
			set{ _ln_dlay_ln_rfn_rsn=value;}
			get{return _ln_dlay_ln_rfn_rsn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DLAY_LN_RFN_AMT
		{
			set{ _ln_dlay_ln_rfn_amt=value;}
			get{return _ln_dlay_ln_rfn_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DERATE_PENALTY_TOTL
		{
			set{ _ln_derate_penalty_totl=value;}
			get{return _ln_derate_penalty_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DERATE_ARRAMT_TOTL
		{
			set{ _ln_derate_arramt_totl=value;}
			get{return _ln_derate_arramt_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ROP_ROI_EXCS_FLAG
		{
			set{ _ln_rop_roi_excs_flag=value;}
			get{return _ln_rop_roi_excs_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INCR_DECR_AMT
		{
			set{ _ln_incr_decr_amt=value;}
			get{return _ln_incr_decr_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_EQPROP_INCR_DECR
		{
			set{ _ln_eqprop_incr_decr=value;}
			get{return _ln_eqprop_incr_decr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INCR_DECR_INIT_PRD_N
		{
			set{ _ln_incr_decr_init_prd_n=value;}
			get{return _ln_incr_decr_init_prd_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_INCR_DECR_INTER_PRD_N
		{
			set{ _ln_incr_decr_inter_prd_n=value;}
			get{return _ln_incr_decr_inter_prd_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CLOSE_FLG
		{
			set{ _ln_close_flg=value;}
			get{return _ln_close_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_SYNLN_FLG
		{
			set{ _ln_synln_flg=value;}
			get{return _ln_synln_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_RCPT_NO
		{
			set{ _ln_rcpt_no=value;}
			get{return _ln_rcpt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_RMRK
		{
			set{ _ln_rmrk=value;}
			get{return _ln_rmrk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FS_ACCT
		{
			set{ _ln_fs_acct=value;}
			get{return _ln_fs_acct;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CUST_NAME
		{
			set{ _ln_cust_name=value;}
			get{return _ln_cust_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CERT_TYP
		{
			set{ _ln_cert_typ=value;}
			get{return _ln_cert_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CERT_ID
		{
			set{ _ln_cert_id=value;}
			get{return _ln_cert_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CUSTD_RCPT_REF_NO
		{
			set{ _ln_custd_rcpt_ref_no=value;}
			get{return _ln_custd_rcpt_ref_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DTL_PRT_FLAG
		{
			set{ _ln_dtl_prt_flag=value;}
			get{return _ln_dtl_prt_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_DTL_PRT_PG_N
		{
			set{ _ln_dtl_prt_pg_n=value;}
			get{return _ln_dtl_prt_pg_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DTL_PRT_KEYS
		{
			set{ _ln_dtl_prt_keys=value;}
			get{return _ln_dtl_prt_keys;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LTST_RISK_TYP_DT_N
		{
			set{ _ln_ltst_risk_typ_dt_n=value;}
			get{return _ln_ltst_risk_typ_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LTST_PR_MV_DT_N
		{
			set{ _ln_ltst_pr_mv_dt_n=value;}
			get{return _ln_ltst_pr_mv_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LTST_PR_MV_TM_N
		{
			set{ _ln_ltst_pr_mv_tm_n=value;}
			get{return _ln_ltst_pr_mv_tm_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ARR_AMT
		{
			set{ _ln_arr_amt=value;}
			get{return _ln_arr_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PENALTY
		{
			set{ _ln_penalty=value;}
			get{return _ln_penalty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_PENL_STRT_DT_N
		{
			set{ _ln_penl_strt_dt_n=value;}
			get{return _ln_penl_strt_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_SVC_BAL
		{
			set{ _ln_svc_bal=value;}
			get{return _ln_svc_bal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_RCV_INT_TOTL
		{
			set{ _ln_rcv_int_totl=value;}
			get{return _ln_rcv_int_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ACCUM_COLI
		{
			set{ _ln_accum_coli=value;}
			get{return _ln_accum_coli;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ACCUM_RECV_PNL
		{
			set{ _ln_accum_recv_pnl=value;}
			get{return _ln_accum_recv_pnl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ACCUM_RECV_SVC
		{
			set{ _ln_accum_recv_svc=value;}
			get{return _ln_accum_recv_svc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ADVPMT_TOTL
		{
			set{ _ln_advpmt_totl=value;}
			get{return _ln_advpmt_totl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_YHEAD_LN_BAL
		{
			set{ _ln_yhead_ln_bal=value;}
			get{return _ln_yhead_ln_bal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_YR_LN_ACCUM
		{
			set{ _ln_crnt_yr_ln_accum=value;}
			get{return _ln_crnt_yr_ln_accum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_YR_REV_ACCUM
		{
			set{ _ln_crnt_yr_rev_accum=value;}
			get{return _ln_crnt_yr_rev_accum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CRNT_YR_COLLED_INT
		{
			set{ _ln_crnt_yr_colled_int=value;}
			get{return _ln_crnt_yr_colled_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_EXCE_FLG
		{
			set{ _ln_exce_flg=value;}
			get{return _ln_exce_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FS_FLG
		{
			set{ _ln_fs_flg=value;}
			get{return _ln_fs_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_HYP_FLG
		{
			set{ _ln_hyp_flg=value;}
			get{return _ln_hyp_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_NACCT_STS
		{
			set{ _ln_nacct_sts=value;}
			get{return _ln_nacct_sts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ACCP_TYP
		{
			set{ _ln_accp_typ=value;}
			get{return _ln_accp_typ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_GUAR_ACCP_EXPT_NO
		{
			set{ _ln_guar_accp_expt_no=value;}
			get{return _ln_guar_accp_expt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_NOR_BACK_FLG
		{
			set{ _ln_nor_back_flg=value;}
			get{return _ln_nor_back_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_HUNT_DUE_DT_N
		{
			set{ _ln_hunt_due_dt_n=value;}
			get{return _ln_hunt_due_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LOC_CITY_FLG
		{
			set{ _ln_loc_city_flg=value;}
			get{return _ln_loc_city_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INT_RCPT_MAIL
		{
			set{ _ln_int_rcpt_mail=value;}
			get{return _ln_int_rcpt_mail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DLAY_ADV
		{
			set{ _ln_dlay_adv=value;}
			get{return _ln_dlay_adv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_RFN_RCPT_MAIL
		{
			set{ _ln_rfn_rcpt_mail=value;}
			get{return _ln_rfn_rcpt_mail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_MBSTMT_CYCL
		{
			set{ _ln_mbstmt_cycl=value;}
			get{return _ln_mbstmt_cycl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_MBSTMT_DT_N
		{
			set{ _ln_mbstmt_dt_n=value;}
			get{return _ln_mbstmt_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CACL_INTR_CYCL
		{
			set{ _ln_cacl_intr_cycl=value;}
			get{return _ln_cacl_intr_cycl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CACL_INTR_DT
		{
			set{ _ln_cacl_intr_dt=value;}
			get{return _ln_cacl_intr_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CACL_INTR_FLG
		{
			set{ _ln_cacl_intr_flg=value;}
			get{return _ln_cacl_intr_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FSTM_RFN_DT_N
		{
			set{ _ln_fstm_rfn_dt_n=value;}
			get{return _ln_fstm_rfn_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FSTM_INTP_DT_N
		{
			set{ _ln_fstm_intp_dt_n=value;}
			get{return _ln_fstm_intp_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_NEXT_PR_RFN_DT_N
		{
			set{ _ln_next_pr_rfn_dt_n=value;}
			get{return _ln_next_pr_rfn_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_NEXT_INT_RFN_DT_N
		{
			set{ _ln_next_int_rfn_dt_n=value;}
			get{return _ln_next_int_rfn_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_OLD_LN_ACCT_TRNI
		{
			set{ _ln_old_ln_acct_trni=value;}
			get{return _ln_old_ln_acct_trni;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_NWLN_ACCT_NO_TRNO
		{
			set{ _ln_nwln_acct_no_trno=value;}
			get{return _ln_nwln_acct_no_trno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AALFD_SUCS
		{
			set{ _ln_aalfd_sucs=value;}
			get{return _ln_aalfd_sucs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FLST_TLR_NO
		{
			set{ _ln_flst_tlr_no=value;}
			get{return _ln_flst_tlr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FLST_APRV_PIC_NO
		{
			set{ _ln_flst_aprv_pic_no=value;}
			get{return _ln_flst_aprv_pic_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_FLST_DT_N
		{
			set{ _ln_flst_dt_n=value;}
			get{return _ln_flst_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LTST_MNTN_OPR_NO
		{
			set{ _ln_ltst_mntn_opr_no=value;}
			get{return _ln_ltst_mntn_opr_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LTST_APRV_PIC_NO
		{
			set{ _ln_ltst_aprv_pic_no=value;}
			get{return _ln_ltst_aprv_pic_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_SPV
		{
			set{ _ln_spv=value;}
			get{return _ln_spv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_LTST_MNTN_DT_N
		{
			set{ _ln_ltst_mntn_dt_n=value;}
			get{return _ln_ltst_mntn_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CRNT_DAY_FST_TX_SQ_NO
		{
			set{ _ln_crnt_day_fst_tx_sq_no=value;}
			get{return _ln_crnt_day_fst_tx_sq_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CRNT_DAY_LST_TX_SQ_NO
		{
			set{ _ln_crnt_day_lst_tx_sq_no=value;}
			get{return _ln_crnt_day_lst_tx_sq_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ROP_INTC_STY_FLG
		{
			set{ _ln_rop_intc_sty_flg=value;}
			get{return _ln_rop_intc_sty_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INT_INTC_STY_FLG
		{
			set{ _ln_int_intc_sty_flg=value;}
			get{return _ln_int_intc_sty_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ADV_RFN_TOT_NUM_N
		{
			set{ _ln_adv_rfn_tot_num_n=value;}
			get{return _ln_adv_rfn_tot_num_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CURR_CYCL_FAC_YR_N
		{
			set{ _ln_curr_cycl_fac_yr_n=value;}
			get{return _ln_curr_cycl_fac_yr_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_CURR_CYCL_ADV_NUM_N
		{
			set{ _ln_curr_cycl_adv_num_n=value;}
			get{return _ln_curr_cycl_adv_num_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_PSBK_PRT_NO
		{
			set{ _ln_psbk_prt_no=value;}
			get{return _ln_psbk_prt_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_INTR_ADJ_DAY
		{
			set{ _ln_intr_adj_day=value;}
			get{return _ln_intr_adj_day;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_AAUTO_ROP
		{
			set{ _ln_aauto_rop=value;}
			get{return _ln_aauto_rop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_ROP_DURAN_CUTDT_N
		{
			set{ _ln_rop_duran_cutdt_n=value;}
			get{return _ln_rop_duran_cutdt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LN_APPL_DUE_DT_N
		{
			set{ _ln_appl_due_dt_n=value;}
			get{return _ln_appl_due_dt_n;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_CNL_NO
		{
			set{ _ln_cnl_no=value;}
			get{return _ln_cnl_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_BELONG_INSTN_COD
		{
			set{ _ln_belong_instn_cod=value;}
			get{return _ln_belong_instn_cod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_ASS_OPUN_NO
		{
			set{ _ln_ass_opun_no=value;}
			get{return _ln_ass_opun_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_LTST_MNTN_OPUN_NO
		{
			set{ _ln_ltst_mntn_opun_no=value;}
			get{return _ln_ltst_mntn_opun_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_TRS_OLD_SYS_FLG
		{
			set{ _ln_trs_old_sys_flg=value;}
			get{return _ln_trs_old_sys_flg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_FLST_OPUN_NO
		{
			set{ _ln_flst_opun_no=value;}
			get{return _ln_flst_opun_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LN_DB_PART_ID
		{
			set{ _ln_db_part_id=value;}
			get{return _ln_db_part_id;}
		}
		#endregion Model

	}
}

