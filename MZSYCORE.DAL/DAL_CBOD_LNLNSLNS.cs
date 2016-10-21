using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//Please add references
namespace MZSYCORE.DAL
{
	/// <summary>
	/// 数据访问类:DAL_CBOD_LNLNSLNS
	/// </summary>
	public partial class DAL_CBOD_LNLNSLNS
	{
		public DAL_CBOD_LNLNSLNS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MZSYCORE.Model.Model_CBOD_LNLNSLNS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CBOD_LNLNSLNS(");
			strSql.Append("ETLDT,LN_LN_ACCT_NO,LNLNS_DB_TIMESTAMP,LN_FINL_VRSN_N,LN_DB_MNTN_NO_N,LN_CUST_NO,LN_CRLMT_NO,LN_PDP_CODE,LN_BUSN_TYP,LN_ACCT_STS,LN_VIP_ACCT_FLG,LN_CUST_TYP,LN_CURR_COD,LN_CURR_IDEN,LN_FINBUSN,LN_CURR_COD_AUTHOR,LN_LN_TYP,LN_HYPO_TYP,LN_NWLN_AMT_HYPO_AMT,LN_TOTL_LN_AMT_HYPO_AMT,LN_LN_BAL,LN_FRST_ALFD_DT_N,LN_DUE_DT_N,LN_CLSD_DT_N,LN_RFN_STY,LN_ROP_CYCL_MN_TOTL_N,LN_ROP_CYCL_UNIT,LN_COLI_CYCL_TOTL_MN_N,LN_COLI_CYCL_UNIT,LN_PPRD_INTP_DAY_N,LN_ROP_DAY_N,LN_TOTL_PRD_N,LN_ARFN_SCHD_PR_N,LN_ARFN_SCHD_INT_N,LN_TNRNO_N,LN_LN_MTHS_N,LN_PR_CAC_DT_N,LN_INTC_UP_DT_N,LN_INTC_UP_DT_ODD_DAYS_N,LN_LAST_INTC_UP_DT_N,LN_INT_INTC_UP_DT_N,LN_PMN_INTC_COD,LN_CLSD_INTC_TYP,LN_FRST_INTC_INTR,LN_FRST_DELAY_INTR,LN_INTR_ADJ_STY,LN_INTR_ADJ_CYCL,LN_INTR_ADJ_STRT_DT_N,LN_INTR_EFF_DT_N,LN_INTR_ACOR_STY,LN_INTR_TYP,LN_INTR_NEGO_SYMB,LN_INTR_NEGO_RATE,LN_DLAY_INTR_ACOR_STY,LN_DLAY_INTR_TYP,LN_DLAY_INTR_PLMN_SYMB,LN_DLAY_INTR_PLMN_COD,LN_LN_FUND_RSUR,LN_LN_PURP,LN_LN_STY,LN_USE_BOOK_FLG,LN_MULTI_RFN_FLG,LN_RCT_EXTN_DT_N,LN_EXTN_CTRT_NO,LN_EXTN_TM_N,LN_EXT_SEQ_NO_N,LN_BUSN_TYP_CHG_DT_N,LN_BUSN_TYP_NEW,LN_BUSN_TYP_ORG,LN_CHG_RFN_STY_DT_N,LN_CHG_RFN_STY,LN_INT_STRV_DT_N,LN_PR_INTS_FLAG,LN_INT_INTS_FLAG,LN_INTS_EFF_DT_N,LN_HALT_INTC_SYMB,LN_HALT_STRT_DT_N,LN_HALT_CUT_DT_N,LN_COLL_SVC_STY,LN_SVC_RTO,LN_TRTO,LN_ROP_DURAN_N,LN_DURAN_INTC_FLG,LN_PR_TOLE_DAYS_N,LN_INT_DURAN_DAYS_N,LN_PAY_SEQ_FLG,LN_AUTO_DDUT_PR_FLG,LN_AUTO_DEDU_INT_FLG,LN_DLY_AUTO_PAY_FLG,LN_AUTO_DEDU_DEP_ACCT_NO_1,LN_AUTO_DEDU_DEP_ACCT_NO_2,LN_AUTO_DEDU_DEP_ACCT_NO_3,LN_AUTO_DEDU_ACCT_TYP_1,LN_AUTO_DEDU_ACCT_TYP_2,LN_AUTO_DEDU_ACCT_TYP_3,LN_LN_TO_DEP_FLG,LN_DEP_ACCT_NO,LN_PAY_INT_ACCT_NO,LN_ZHIBIAO_NO,LN_FAC_COD,LN_DLF_COD,LN_LNB_COD,LN_FILLER1_COD,LN_FILLER2_COD,LN_INT_DIS_END_DT_N,LN_INT_DIS_RATE_N,LN_FUND_TO_AUOR_FLG,LN_FUND_ACCT_NO,LN_AUOR_DEP_ACCT_NO,LN_GUAR_MARGIN_ACCT_NO,LN_TD_PSBK_NO_N,LN_TD_PSBK_SEQ_NO_N,LN_FRZ_DT_N,LN_RWHLD_NO,LN_HYPO_SQ_NO,LN_MAN_TOVD_FLG,LN_BAD_LN_FLG,LN_SIGNL_LN_INTURN_TABLE,LN_INSTAL_RFN_PLAN,LN_INSTAL_MULTI_RFN_STY,LN_PPRD_RFN_AMT,LN_CRNT_PRD_RTN_AMT,LN_CRNT_PRD_PAYRBL_PR,LN_CRNT_PRD_PAYRBL_INT,LN_NEXT_PRD_ARFN_AMT,LN_NEXT_PRD_PAYRBL_INT,LN_WHHD_PR_ACCRUD,LN_WHHD_INT_ACCRUD,LN_INTRBL_INT,LN_DLAY_INT_INT,LN_OVDLN_INTRBL,LN_CRNT_OVDLN_INT_INT,LN_CRNT_OVDLN_INTRBL,LN_CRNT_OVDLN_LN_INTR,LN_DEVLU_INT,LN_APCL_FLG,LN_INT_APCL_TOTL_INPLAN,LN_INTRBL_APCL_AMT_TOTL,LN_OVDLN_INTRBL_APCL_TOTL,LN_OVDLN_INT_APCL_TOTL,LN_LSAC_INT_APCL_TOTL,LN_PR_APCL_TOTL,LN_CRNT_YR_INTRBL,LN_YHEAD_RBL_UCOLL_LN_INT,LN_ARR_PR,LN_DLAY_PR_TOTL,LN_TOVDLN_PR_BAL,LN_DLAY_LN_DT_N,LN_TRNLST_OVD_DT_N,LN_DLAY_LN_RSN,LN_DLAY_RSK_RTNG,LN_FOVDLN_SQ_DT_N,LN_DLAY_LN_FRN_DT_N,LN_DLAY_LN_RFN_RSN,LN_DLAY_LN_RFN_AMT,LN_DERATE_PENALTY_TOTL,LN_DERATE_ARRAMT_TOTL,LN_ROP_ROI_EXCS_FLAG,LN_INCR_DECR_AMT,LN_EQPROP_INCR_DECR,LN_INCR_DECR_INIT_PRD_N,LN_INCR_DECR_INTER_PRD_N,LN_CLOSE_FLG,LN_SYNLN_FLG,LN_RCPT_NO,LN_RMRK,LN_FS_ACCT,LN_CUST_NAME,LN_CERT_TYP,LN_CERT_ID,LN_CUSTD_RCPT_REF_NO,LN_DTL_PRT_FLAG,LN_DTL_PRT_PG_N,LN_DTL_PRT_KEYS,LN_LTST_RISK_TYP_DT_N,LN_LTST_PR_MV_DT_N,LN_LTST_PR_MV_TM_N,LN_ARR_AMT,LN_PENALTY,LN_PENL_STRT_DT_N,LN_SVC_BAL,LN_RCV_INT_TOTL,LN_ACCUM_COLI,LN_ACCUM_RECV_PNL,LN_ACCUM_RECV_SVC,LN_ADVPMT_TOTL,LN_YHEAD_LN_BAL,LN_CRNT_YR_LN_ACCUM,LN_CRNT_YR_REV_ACCUM,LN_CRNT_YR_COLLED_INT,LN_EXCE_FLG,LN_FS_FLG,LN_HYP_FLG,LN_NACCT_STS,LN_ACCP_TYP,LN_GUAR_ACCP_EXPT_NO,LN_NOR_BACK_FLG,LN_HUNT_DUE_DT_N,LN_LOC_CITY_FLG,LN_INT_RCPT_MAIL,LN_DLAY_ADV,LN_RFN_RCPT_MAIL,LN_MBSTMT_CYCL,LN_MBSTMT_DT_N,LN_CACL_INTR_CYCL,LN_CACL_INTR_DT,LN_CACL_INTR_FLG,LN_FSTM_RFN_DT_N,LN_FSTM_INTP_DT_N,LN_NEXT_PR_RFN_DT_N,LN_NEXT_INT_RFN_DT_N,LN_OLD_LN_ACCT_TRNI,LN_NWLN_ACCT_NO_TRNO,LN_AALFD_SUCS,LN_FLST_TLR_NO,LN_FLST_APRV_PIC_NO,LN_FLST_DT_N,LN_LTST_MNTN_OPR_NO,LN_LTST_APRV_PIC_NO,LN_SPV,LN_LTST_MNTN_DT_N,LN_CRNT_DAY_FST_TX_SQ_NO,LN_CRNT_DAY_LST_TX_SQ_NO,LN_ROP_INTC_STY_FLG,LN_INT_INTC_STY_FLG,LN_ADV_RFN_TOT_NUM_N,LN_CURR_CYCL_FAC_YR_N,LN_CURR_CYCL_ADV_NUM_N,LN_PSBK_PRT_NO,LN_INTR_ADJ_DAY,LN_AAUTO_ROP,LN_ROP_DURAN_CUTDT_N,LN_APPL_DUE_DT_N,LN_CNL_NO,LN_BELONG_INSTN_COD,LN_ASS_OPUN_NO,LN_LTST_MNTN_OPUN_NO,LN_TRS_OLD_SYS_FLG,LN_FLST_OPUN_NO,LN_DB_PART_ID)");
			strSql.Append(" values (");
			strSql.Append("@ETLDT,@LN_LN_ACCT_NO,@LNLNS_DB_TIMESTAMP,@LN_FINL_VRSN_N,@LN_DB_MNTN_NO_N,@LN_CUST_NO,@LN_CRLMT_NO,@LN_PDP_CODE,@LN_BUSN_TYP,@LN_ACCT_STS,@LN_VIP_ACCT_FLG,@LN_CUST_TYP,@LN_CURR_COD,@LN_CURR_IDEN,@LN_FINBUSN,@LN_CURR_COD_AUTHOR,@LN_LN_TYP,@LN_HYPO_TYP,@LN_NWLN_AMT_HYPO_AMT,@LN_TOTL_LN_AMT_HYPO_AMT,@LN_LN_BAL,@LN_FRST_ALFD_DT_N,@LN_DUE_DT_N,@LN_CLSD_DT_N,@LN_RFN_STY,@LN_ROP_CYCL_MN_TOTL_N,@LN_ROP_CYCL_UNIT,@LN_COLI_CYCL_TOTL_MN_N,@LN_COLI_CYCL_UNIT,@LN_PPRD_INTP_DAY_N,@LN_ROP_DAY_N,@LN_TOTL_PRD_N,@LN_ARFN_SCHD_PR_N,@LN_ARFN_SCHD_INT_N,@LN_TNRNO_N,@LN_LN_MTHS_N,@LN_PR_CAC_DT_N,@LN_INTC_UP_DT_N,@LN_INTC_UP_DT_ODD_DAYS_N,@LN_LAST_INTC_UP_DT_N,@LN_INT_INTC_UP_DT_N,@LN_PMN_INTC_COD,@LN_CLSD_INTC_TYP,@LN_FRST_INTC_INTR,@LN_FRST_DELAY_INTR,@LN_INTR_ADJ_STY,@LN_INTR_ADJ_CYCL,@LN_INTR_ADJ_STRT_DT_N,@LN_INTR_EFF_DT_N,@LN_INTR_ACOR_STY,@LN_INTR_TYP,@LN_INTR_NEGO_SYMB,@LN_INTR_NEGO_RATE,@LN_DLAY_INTR_ACOR_STY,@LN_DLAY_INTR_TYP,@LN_DLAY_INTR_PLMN_SYMB,@LN_DLAY_INTR_PLMN_COD,@LN_LN_FUND_RSUR,@LN_LN_PURP,@LN_LN_STY,@LN_USE_BOOK_FLG,@LN_MULTI_RFN_FLG,@LN_RCT_EXTN_DT_N,@LN_EXTN_CTRT_NO,@LN_EXTN_TM_N,@LN_EXT_SEQ_NO_N,@LN_BUSN_TYP_CHG_DT_N,@LN_BUSN_TYP_NEW,@LN_BUSN_TYP_ORG,@LN_CHG_RFN_STY_DT_N,@LN_CHG_RFN_STY,@LN_INT_STRV_DT_N,@LN_PR_INTS_FLAG,@LN_INT_INTS_FLAG,@LN_INTS_EFF_DT_N,@LN_HALT_INTC_SYMB,@LN_HALT_STRT_DT_N,@LN_HALT_CUT_DT_N,@LN_COLL_SVC_STY,@LN_SVC_RTO,@LN_TRTO,@LN_ROP_DURAN_N,@LN_DURAN_INTC_FLG,@LN_PR_TOLE_DAYS_N,@LN_INT_DURAN_DAYS_N,@LN_PAY_SEQ_FLG,@LN_AUTO_DDUT_PR_FLG,@LN_AUTO_DEDU_INT_FLG,@LN_DLY_AUTO_PAY_FLG,@LN_AUTO_DEDU_DEP_ACCT_NO_1,@LN_AUTO_DEDU_DEP_ACCT_NO_2,@LN_AUTO_DEDU_DEP_ACCT_NO_3,@LN_AUTO_DEDU_ACCT_TYP_1,@LN_AUTO_DEDU_ACCT_TYP_2,@LN_AUTO_DEDU_ACCT_TYP_3,@LN_LN_TO_DEP_FLG,@LN_DEP_ACCT_NO,@LN_PAY_INT_ACCT_NO,@LN_ZHIBIAO_NO,@LN_FAC_COD,@LN_DLF_COD,@LN_LNB_COD,@LN_FILLER1_COD,@LN_FILLER2_COD,@LN_INT_DIS_END_DT_N,@LN_INT_DIS_RATE_N,@LN_FUND_TO_AUOR_FLG,@LN_FUND_ACCT_NO,@LN_AUOR_DEP_ACCT_NO,@LN_GUAR_MARGIN_ACCT_NO,@LN_TD_PSBK_NO_N,@LN_TD_PSBK_SEQ_NO_N,@LN_FRZ_DT_N,@LN_RWHLD_NO,@LN_HYPO_SQ_NO,@LN_MAN_TOVD_FLG,@LN_BAD_LN_FLG,@LN_SIGNL_LN_INTURN_TABLE,@LN_INSTAL_RFN_PLAN,@LN_INSTAL_MULTI_RFN_STY,@LN_PPRD_RFN_AMT,@LN_CRNT_PRD_RTN_AMT,@LN_CRNT_PRD_PAYRBL_PR,@LN_CRNT_PRD_PAYRBL_INT,@LN_NEXT_PRD_ARFN_AMT,@LN_NEXT_PRD_PAYRBL_INT,@LN_WHHD_PR_ACCRUD,@LN_WHHD_INT_ACCRUD,@LN_INTRBL_INT,@LN_DLAY_INT_INT,@LN_OVDLN_INTRBL,@LN_CRNT_OVDLN_INT_INT,@LN_CRNT_OVDLN_INTRBL,@LN_CRNT_OVDLN_LN_INTR,@LN_DEVLU_INT,@LN_APCL_FLG,@LN_INT_APCL_TOTL_INPLAN,@LN_INTRBL_APCL_AMT_TOTL,@LN_OVDLN_INTRBL_APCL_TOTL,@LN_OVDLN_INT_APCL_TOTL,@LN_LSAC_INT_APCL_TOTL,@LN_PR_APCL_TOTL,@LN_CRNT_YR_INTRBL,@LN_YHEAD_RBL_UCOLL_LN_INT,@LN_ARR_PR,@LN_DLAY_PR_TOTL,@LN_TOVDLN_PR_BAL,@LN_DLAY_LN_DT_N,@LN_TRNLST_OVD_DT_N,@LN_DLAY_LN_RSN,@LN_DLAY_RSK_RTNG,@LN_FOVDLN_SQ_DT_N,@LN_DLAY_LN_FRN_DT_N,@LN_DLAY_LN_RFN_RSN,@LN_DLAY_LN_RFN_AMT,@LN_DERATE_PENALTY_TOTL,@LN_DERATE_ARRAMT_TOTL,@LN_ROP_ROI_EXCS_FLAG,@LN_INCR_DECR_AMT,@LN_EQPROP_INCR_DECR,@LN_INCR_DECR_INIT_PRD_N,@LN_INCR_DECR_INTER_PRD_N,@LN_CLOSE_FLG,@LN_SYNLN_FLG,@LN_RCPT_NO,@LN_RMRK,@LN_FS_ACCT,@LN_CUST_NAME,@LN_CERT_TYP,@LN_CERT_ID,@LN_CUSTD_RCPT_REF_NO,@LN_DTL_PRT_FLAG,@LN_DTL_PRT_PG_N,@LN_DTL_PRT_KEYS,@LN_LTST_RISK_TYP_DT_N,@LN_LTST_PR_MV_DT_N,@LN_LTST_PR_MV_TM_N,@LN_ARR_AMT,@LN_PENALTY,@LN_PENL_STRT_DT_N,@LN_SVC_BAL,@LN_RCV_INT_TOTL,@LN_ACCUM_COLI,@LN_ACCUM_RECV_PNL,@LN_ACCUM_RECV_SVC,@LN_ADVPMT_TOTL,@LN_YHEAD_LN_BAL,@LN_CRNT_YR_LN_ACCUM,@LN_CRNT_YR_REV_ACCUM,@LN_CRNT_YR_COLLED_INT,@LN_EXCE_FLG,@LN_FS_FLG,@LN_HYP_FLG,@LN_NACCT_STS,@LN_ACCP_TYP,@LN_GUAR_ACCP_EXPT_NO,@LN_NOR_BACK_FLG,@LN_HUNT_DUE_DT_N,@LN_LOC_CITY_FLG,@LN_INT_RCPT_MAIL,@LN_DLAY_ADV,@LN_RFN_RCPT_MAIL,@LN_MBSTMT_CYCL,@LN_MBSTMT_DT_N,@LN_CACL_INTR_CYCL,@LN_CACL_INTR_DT,@LN_CACL_INTR_FLG,@LN_FSTM_RFN_DT_N,@LN_FSTM_INTP_DT_N,@LN_NEXT_PR_RFN_DT_N,@LN_NEXT_INT_RFN_DT_N,@LN_OLD_LN_ACCT_TRNI,@LN_NWLN_ACCT_NO_TRNO,@LN_AALFD_SUCS,@LN_FLST_TLR_NO,@LN_FLST_APRV_PIC_NO,@LN_FLST_DT_N,@LN_LTST_MNTN_OPR_NO,@LN_LTST_APRV_PIC_NO,@LN_SPV,@LN_LTST_MNTN_DT_N,@LN_CRNT_DAY_FST_TX_SQ_NO,@LN_CRNT_DAY_LST_TX_SQ_NO,@LN_ROP_INTC_STY_FLG,@LN_INT_INTC_STY_FLG,@LN_ADV_RFN_TOT_NUM_N,@LN_CURR_CYCL_FAC_YR_N,@LN_CURR_CYCL_ADV_NUM_N,@LN_PSBK_PRT_NO,@LN_INTR_ADJ_DAY,@LN_AAUTO_ROP,@LN_ROP_DURAN_CUTDT_N,@LN_APPL_DUE_DT_N,@LN_CNL_NO,@LN_BELONG_INSTN_COD,@LN_ASS_OPUN_NO,@LN_LTST_MNTN_OPUN_NO,@LN_TRS_OLD_SYS_FLG,@LN_FLST_OPUN_NO,@LN_DB_PART_ID)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@LN_LN_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LNLNS_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@LN_FINL_VRSN_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DB_MNTN_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CUST_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_CRLMT_NO", OleDbType.VarChar,4),
					new OleDbParameter("@LN_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@LN_BUSN_TYP", OleDbType.VarChar,3),
					new OleDbParameter("@LN_ACCT_STS", OleDbType.VarChar,1),
					new OleDbParameter("@LN_VIP_ACCT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CUST_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@LN_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FINBUSN", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CURR_COD_AUTHOR", OleDbType.VarChar,2),
					new OleDbParameter("@LN_LN_TYP", OleDbType.VarChar,3),
					new OleDbParameter("@LN_HYPO_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_NWLN_AMT_HYPO_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_TOTL_LN_AMT_HYPO_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_LN_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_FRST_ALFD_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DUE_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CLSD_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_RFN_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_ROP_CYCL_MN_TOTL_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_CYCL_UNIT", OleDbType.VarChar,1),
					new OleDbParameter("@LN_COLI_CYCL_TOTL_MN_N", OleDbType.Decimal),
					new OleDbParameter("@LN_COLI_CYCL_UNIT", OleDbType.VarChar,1),
					new OleDbParameter("@LN_PPRD_INTP_DAY_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_DAY_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TOTL_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ARFN_SCHD_PR_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ARFN_SCHD_INT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TNRNO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LN_MTHS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PR_CAC_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTC_UP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTC_UP_DT_ODD_DAYS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LAST_INTC_UP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INT_INTC_UP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PMN_INTC_COD", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CLSD_INTC_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FRST_INTC_INTR", OleDbType.Decimal),
					new OleDbParameter("@LN_FRST_DELAY_INTR", OleDbType.Decimal),
					new OleDbParameter("@LN_INTR_ADJ_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INTR_ADJ_CYCL", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INTR_ADJ_STRT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTR_EFF_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTR_ACOR_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INTR_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INTR_NEGO_SYMB", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INTR_NEGO_RATE", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_INTR_ACOR_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_INTR_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_INTR_PLMN_SYMB", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DLAY_INTR_PLMN_COD", OleDbType.Decimal),
					new OleDbParameter("@LN_LN_FUND_RSUR", OleDbType.VarChar,2),
					new OleDbParameter("@LN_LN_PURP", OleDbType.VarChar,2),
					new OleDbParameter("@LN_LN_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_USE_BOOK_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_MULTI_RFN_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_RCT_EXTN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_EXTN_CTRT_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_EXTN_TM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_EXT_SEQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_BUSN_TYP_CHG_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_BUSN_TYP_NEW", OleDbType.VarChar,3),
					new OleDbParameter("@LN_BUSN_TYP_ORG", OleDbType.VarChar,3),
					new OleDbParameter("@LN_CHG_RFN_STY_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CHG_RFN_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INT_STRV_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PR_INTS_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_INTS_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INTS_EFF_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_HALT_INTC_SYMB", OleDbType.VarChar,1),
					new OleDbParameter("@LN_HALT_STRT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_HALT_CUT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_COLL_SVC_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_SVC_RTO", OleDbType.Decimal),
					new OleDbParameter("@LN_TRTO", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_DURAN_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DURAN_INTC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_PR_TOLE_DAYS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INT_DURAN_DAYS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PAY_SEQ_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DDUT_PR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_INT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DLY_AUTO_PAY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_DEP_ACCT_NO_1", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUTO_DEDU_DEP_ACCT_NO_2", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUTO_DEDU_DEP_ACCT_NO_3", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUTO_DEDU_ACCT_TYP_1", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_ACCT_TYP_2", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_ACCT_TYP_3", OleDbType.VarChar,1),
					new OleDbParameter("@LN_LN_TO_DEP_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DEP_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_PAY_INT_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_ZHIBIAO_NO", OleDbType.VarChar,19),
					new OleDbParameter("@LN_FAC_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_DLF_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_LNB_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_FILLER1_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_FILLER2_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_INT_DIS_END_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INT_DIS_RATE_N", OleDbType.Decimal),
					new OleDbParameter("@LN_FUND_TO_AUOR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FUND_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUOR_DEP_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_GUAR_MARGIN_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_TD_PSBK_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TD_PSBK_SEQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_FRZ_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_RWHLD_NO", OleDbType.VarChar,10),
					new OleDbParameter("@LN_HYPO_SQ_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_MAN_TOVD_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_BAD_LN_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_SIGNL_LN_INTURN_TABLE", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INSTAL_RFN_PLAN", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INSTAL_MULTI_RFN_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_PPRD_RFN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_PRD_RTN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_PRD_PAYRBL_PR", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_PRD_PAYRBL_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_PRD_ARFN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_PRD_PAYRBL_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_WHHD_PR_ACCRUD", OleDbType.Decimal),
					new OleDbParameter("@LN_WHHD_INT_ACCRUD", OleDbType.Decimal),
					new OleDbParameter("@LN_INTRBL_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_INT_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_OVDLN_INTRBL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_OVDLN_INT_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_OVDLN_INTRBL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_OVDLN_LN_INTR", OleDbType.Decimal),
					new OleDbParameter("@LN_DEVLU_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_APCL_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_APCL_TOTL_INPLAN", OleDbType.Decimal),
					new OleDbParameter("@LN_INTRBL_APCL_AMT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_OVDLN_INTRBL_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_OVDLN_INT_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_LSAC_INT_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_PR_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_INTRBL", OleDbType.Decimal),
					new OleDbParameter("@LN_YHEAD_RBL_UCOLL_LN_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_ARR_PR", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_PR_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_TOVDLN_PR_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TRNLST_OVD_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_RSN", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_RSK_RTNG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FOVDLN_SQ_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_FRN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_RFN_RSN", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_LN_RFN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_DERATE_PENALTY_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_DERATE_ARRAMT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_ROI_EXCS_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INCR_DECR_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_EQPROP_INCR_DECR", OleDbType.Decimal),
					new OleDbParameter("@LN_INCR_DECR_INIT_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INCR_DECR_INTER_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CLOSE_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_SYNLN_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_RCPT_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_RMRK", OleDbType.VarChar,62),
					new OleDbParameter("@LN_FS_ACCT", OleDbType.VarChar,28),
					new OleDbParameter("@LN_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@LN_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CERT_ID", OleDbType.VarChar,20),
					new OleDbParameter("@LN_CUSTD_RCPT_REF_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_DTL_PRT_FLAG", OleDbType.VarChar,3),
					new OleDbParameter("@LN_DTL_PRT_PG_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DTL_PRT_KEYS", OleDbType.VarChar,19),
					new OleDbParameter("@LN_LTST_RISK_TYP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LTST_PR_MV_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LTST_PR_MV_TM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ARR_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_PENALTY", OleDbType.Decimal),
					new OleDbParameter("@LN_PENL_STRT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_SVC_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_RCV_INT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_ACCUM_COLI", OleDbType.Decimal),
					new OleDbParameter("@LN_ACCUM_RECV_PNL", OleDbType.Decimal),
					new OleDbParameter("@LN_ACCUM_RECV_SVC", OleDbType.Decimal),
					new OleDbParameter("@LN_ADVPMT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_YHEAD_LN_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_LN_ACCUM", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_REV_ACCUM", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_COLLED_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_EXCE_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FS_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_HYP_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_NACCT_STS", OleDbType.VarChar,1),
					new OleDbParameter("@LN_ACCP_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_GUAR_ACCP_EXPT_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_NOR_BACK_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_HUNT_DUE_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LOC_CITY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_RCPT_MAIL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DLAY_ADV", OleDbType.VarChar,1),
					new OleDbParameter("@LN_RFN_RCPT_MAIL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_MBSTMT_CYCL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_MBSTMT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CACL_INTR_CYCL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CACL_INTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@LN_CACL_INTR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FSTM_RFN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_FSTM_INTP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_PR_RFN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_INT_RFN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_OLD_LN_ACCT_TRNI", OleDbType.VarChar,28),
					new OleDbParameter("@LN_NWLN_ACCT_NO_TRNO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AALFD_SUCS", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FLST_TLR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_FLST_APRV_PIC_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_FLST_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LTST_MNTN_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_LTST_APRV_PIC_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_SPV", OleDbType.VarChar,12),
					new OleDbParameter("@LN_LTST_MNTN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_DAY_FST_TX_SQ_NO", OleDbType.VarChar,19),
					new OleDbParameter("@LN_CRNT_DAY_LST_TX_SQ_NO", OleDbType.VarChar,19),
					new OleDbParameter("@LN_ROP_INTC_STY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_INTC_STY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_ADV_RFN_TOT_NUM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CURR_CYCL_FAC_YR_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CURR_CYCL_ADV_NUM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PSBK_PRT_NO", OleDbType.VarChar,13),
					new OleDbParameter("@LN_INTR_ADJ_DAY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_AAUTO_ROP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_ROP_DURAN_CUTDT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_APPL_DUE_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CNL_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@LN_ASS_OPUN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@LN_LTST_MNTN_OPUN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@LN_TRS_OLD_SYS_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FLST_OPUN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@LN_DB_PART_ID", OleDbType.VarChar,9)};
			parameters[0].Value = model.ETLDT;
			parameters[1].Value = model.LN_LN_ACCT_NO;
			parameters[2].Value = model.LNLNS_DB_TIMESTAMP;
			parameters[3].Value = model.LN_FINL_VRSN_N;
			parameters[4].Value = model.LN_DB_MNTN_NO_N;
			parameters[5].Value = model.LN_CUST_NO;
			parameters[6].Value = model.LN_CRLMT_NO;
			parameters[7].Value = model.LN_PDP_CODE;
			parameters[8].Value = model.LN_BUSN_TYP;
			parameters[9].Value = model.LN_ACCT_STS;
			parameters[10].Value = model.LN_VIP_ACCT_FLG;
			parameters[11].Value = model.LN_CUST_TYP;
			parameters[12].Value = model.LN_CURR_COD;
			parameters[13].Value = model.LN_CURR_IDEN;
			parameters[14].Value = model.LN_FINBUSN;
			parameters[15].Value = model.LN_CURR_COD_AUTHOR;
			parameters[16].Value = model.LN_LN_TYP;
			parameters[17].Value = model.LN_HYPO_TYP;
			parameters[18].Value = model.LN_NWLN_AMT_HYPO_AMT;
			parameters[19].Value = model.LN_TOTL_LN_AMT_HYPO_AMT;
			parameters[20].Value = model.LN_LN_BAL;
			parameters[21].Value = model.LN_FRST_ALFD_DT_N;
			parameters[22].Value = model.LN_DUE_DT_N;
			parameters[23].Value = model.LN_CLSD_DT_N;
			parameters[24].Value = model.LN_RFN_STY;
			parameters[25].Value = model.LN_ROP_CYCL_MN_TOTL_N;
			parameters[26].Value = model.LN_ROP_CYCL_UNIT;
			parameters[27].Value = model.LN_COLI_CYCL_TOTL_MN_N;
			parameters[28].Value = model.LN_COLI_CYCL_UNIT;
			parameters[29].Value = model.LN_PPRD_INTP_DAY_N;
			parameters[30].Value = model.LN_ROP_DAY_N;
			parameters[31].Value = model.LN_TOTL_PRD_N;
			parameters[32].Value = model.LN_ARFN_SCHD_PR_N;
			parameters[33].Value = model.LN_ARFN_SCHD_INT_N;
			parameters[34].Value = model.LN_TNRNO_N;
			parameters[35].Value = model.LN_LN_MTHS_N;
			parameters[36].Value = model.LN_PR_CAC_DT_N;
			parameters[37].Value = model.LN_INTC_UP_DT_N;
			parameters[38].Value = model.LN_INTC_UP_DT_ODD_DAYS_N;
			parameters[39].Value = model.LN_LAST_INTC_UP_DT_N;
			parameters[40].Value = model.LN_INT_INTC_UP_DT_N;
			parameters[41].Value = model.LN_PMN_INTC_COD;
			parameters[42].Value = model.LN_CLSD_INTC_TYP;
			parameters[43].Value = model.LN_FRST_INTC_INTR;
			parameters[44].Value = model.LN_FRST_DELAY_INTR;
			parameters[45].Value = model.LN_INTR_ADJ_STY;
			parameters[46].Value = model.LN_INTR_ADJ_CYCL;
			parameters[47].Value = model.LN_INTR_ADJ_STRT_DT_N;
			parameters[48].Value = model.LN_INTR_EFF_DT_N;
			parameters[49].Value = model.LN_INTR_ACOR_STY;
			parameters[50].Value = model.LN_INTR_TYP;
			parameters[51].Value = model.LN_INTR_NEGO_SYMB;
			parameters[52].Value = model.LN_INTR_NEGO_RATE;
			parameters[53].Value = model.LN_DLAY_INTR_ACOR_STY;
			parameters[54].Value = model.LN_DLAY_INTR_TYP;
			parameters[55].Value = model.LN_DLAY_INTR_PLMN_SYMB;
			parameters[56].Value = model.LN_DLAY_INTR_PLMN_COD;
			parameters[57].Value = model.LN_LN_FUND_RSUR;
			parameters[58].Value = model.LN_LN_PURP;
			parameters[59].Value = model.LN_LN_STY;
			parameters[60].Value = model.LN_USE_BOOK_FLG;
			parameters[61].Value = model.LN_MULTI_RFN_FLG;
			parameters[62].Value = model.LN_RCT_EXTN_DT_N;
			parameters[63].Value = model.LN_EXTN_CTRT_NO;
			parameters[64].Value = model.LN_EXTN_TM_N;
			parameters[65].Value = model.LN_EXT_SEQ_NO_N;
			parameters[66].Value = model.LN_BUSN_TYP_CHG_DT_N;
			parameters[67].Value = model.LN_BUSN_TYP_NEW;
			parameters[68].Value = model.LN_BUSN_TYP_ORG;
			parameters[69].Value = model.LN_CHG_RFN_STY_DT_N;
			parameters[70].Value = model.LN_CHG_RFN_STY;
			parameters[71].Value = model.LN_INT_STRV_DT_N;
			parameters[72].Value = model.LN_PR_INTS_FLAG;
			parameters[73].Value = model.LN_INT_INTS_FLAG;
			parameters[74].Value = model.LN_INTS_EFF_DT_N;
			parameters[75].Value = model.LN_HALT_INTC_SYMB;
			parameters[76].Value = model.LN_HALT_STRT_DT_N;
			parameters[77].Value = model.LN_HALT_CUT_DT_N;
			parameters[78].Value = model.LN_COLL_SVC_STY;
			parameters[79].Value = model.LN_SVC_RTO;
			parameters[80].Value = model.LN_TRTO;
			parameters[81].Value = model.LN_ROP_DURAN_N;
			parameters[82].Value = model.LN_DURAN_INTC_FLG;
			parameters[83].Value = model.LN_PR_TOLE_DAYS_N;
			parameters[84].Value = model.LN_INT_DURAN_DAYS_N;
			parameters[85].Value = model.LN_PAY_SEQ_FLG;
			parameters[86].Value = model.LN_AUTO_DDUT_PR_FLG;
			parameters[87].Value = model.LN_AUTO_DEDU_INT_FLG;
			parameters[88].Value = model.LN_DLY_AUTO_PAY_FLG;
			parameters[89].Value = model.LN_AUTO_DEDU_DEP_ACCT_NO_1;
			parameters[90].Value = model.LN_AUTO_DEDU_DEP_ACCT_NO_2;
			parameters[91].Value = model.LN_AUTO_DEDU_DEP_ACCT_NO_3;
			parameters[92].Value = model.LN_AUTO_DEDU_ACCT_TYP_1;
			parameters[93].Value = model.LN_AUTO_DEDU_ACCT_TYP_2;
			parameters[94].Value = model.LN_AUTO_DEDU_ACCT_TYP_3;
			parameters[95].Value = model.LN_LN_TO_DEP_FLG;
			parameters[96].Value = model.LN_DEP_ACCT_NO;
			parameters[97].Value = model.LN_PAY_INT_ACCT_NO;
			parameters[98].Value = model.LN_ZHIBIAO_NO;
			parameters[99].Value = model.LN_FAC_COD;
			parameters[100].Value = model.LN_DLF_COD;
			parameters[101].Value = model.LN_LNB_COD;
			parameters[102].Value = model.LN_FILLER1_COD;
			parameters[103].Value = model.LN_FILLER2_COD;
			parameters[104].Value = model.LN_INT_DIS_END_DT_N;
			parameters[105].Value = model.LN_INT_DIS_RATE_N;
			parameters[106].Value = model.LN_FUND_TO_AUOR_FLG;
			parameters[107].Value = model.LN_FUND_ACCT_NO;
			parameters[108].Value = model.LN_AUOR_DEP_ACCT_NO;
			parameters[109].Value = model.LN_GUAR_MARGIN_ACCT_NO;
			parameters[110].Value = model.LN_TD_PSBK_NO_N;
			parameters[111].Value = model.LN_TD_PSBK_SEQ_NO_N;
			parameters[112].Value = model.LN_FRZ_DT_N;
			parameters[113].Value = model.LN_RWHLD_NO;
			parameters[114].Value = model.LN_HYPO_SQ_NO;
			parameters[115].Value = model.LN_MAN_TOVD_FLG;
			parameters[116].Value = model.LN_BAD_LN_FLG;
			parameters[117].Value = model.LN_SIGNL_LN_INTURN_TABLE;
			parameters[118].Value = model.LN_INSTAL_RFN_PLAN;
			parameters[119].Value = model.LN_INSTAL_MULTI_RFN_STY;
			parameters[120].Value = model.LN_PPRD_RFN_AMT;
			parameters[121].Value = model.LN_CRNT_PRD_RTN_AMT;
			parameters[122].Value = model.LN_CRNT_PRD_PAYRBL_PR;
			parameters[123].Value = model.LN_CRNT_PRD_PAYRBL_INT;
			parameters[124].Value = model.LN_NEXT_PRD_ARFN_AMT;
			parameters[125].Value = model.LN_NEXT_PRD_PAYRBL_INT;
			parameters[126].Value = model.LN_WHHD_PR_ACCRUD;
			parameters[127].Value = model.LN_WHHD_INT_ACCRUD;
			parameters[128].Value = model.LN_INTRBL_INT;
			parameters[129].Value = model.LN_DLAY_INT_INT;
			parameters[130].Value = model.LN_OVDLN_INTRBL;
			parameters[131].Value = model.LN_CRNT_OVDLN_INT_INT;
			parameters[132].Value = model.LN_CRNT_OVDLN_INTRBL;
			parameters[133].Value = model.LN_CRNT_OVDLN_LN_INTR;
			parameters[134].Value = model.LN_DEVLU_INT;
			parameters[135].Value = model.LN_APCL_FLG;
			parameters[136].Value = model.LN_INT_APCL_TOTL_INPLAN;
			parameters[137].Value = model.LN_INTRBL_APCL_AMT_TOTL;
			parameters[138].Value = model.LN_OVDLN_INTRBL_APCL_TOTL;
			parameters[139].Value = model.LN_OVDLN_INT_APCL_TOTL;
			parameters[140].Value = model.LN_LSAC_INT_APCL_TOTL;
			parameters[141].Value = model.LN_PR_APCL_TOTL;
			parameters[142].Value = model.LN_CRNT_YR_INTRBL;
			parameters[143].Value = model.LN_YHEAD_RBL_UCOLL_LN_INT;
			parameters[144].Value = model.LN_ARR_PR;
			parameters[145].Value = model.LN_DLAY_PR_TOTL;
			parameters[146].Value = model.LN_TOVDLN_PR_BAL;
			parameters[147].Value = model.LN_DLAY_LN_DT_N;
			parameters[148].Value = model.LN_TRNLST_OVD_DT_N;
			parameters[149].Value = model.LN_DLAY_LN_RSN;
			parameters[150].Value = model.LN_DLAY_RSK_RTNG;
			parameters[151].Value = model.LN_FOVDLN_SQ_DT_N;
			parameters[152].Value = model.LN_DLAY_LN_FRN_DT_N;
			parameters[153].Value = model.LN_DLAY_LN_RFN_RSN;
			parameters[154].Value = model.LN_DLAY_LN_RFN_AMT;
			parameters[155].Value = model.LN_DERATE_PENALTY_TOTL;
			parameters[156].Value = model.LN_DERATE_ARRAMT_TOTL;
			parameters[157].Value = model.LN_ROP_ROI_EXCS_FLAG;
			parameters[158].Value = model.LN_INCR_DECR_AMT;
			parameters[159].Value = model.LN_EQPROP_INCR_DECR;
			parameters[160].Value = model.LN_INCR_DECR_INIT_PRD_N;
			parameters[161].Value = model.LN_INCR_DECR_INTER_PRD_N;
			parameters[162].Value = model.LN_CLOSE_FLG;
			parameters[163].Value = model.LN_SYNLN_FLG;
			parameters[164].Value = model.LN_RCPT_NO;
			parameters[165].Value = model.LN_RMRK;
			parameters[166].Value = model.LN_FS_ACCT;
			parameters[167].Value = model.LN_CUST_NAME;
			parameters[168].Value = model.LN_CERT_TYP;
			parameters[169].Value = model.LN_CERT_ID;
			parameters[170].Value = model.LN_CUSTD_RCPT_REF_NO;
			parameters[171].Value = model.LN_DTL_PRT_FLAG;
			parameters[172].Value = model.LN_DTL_PRT_PG_N;
			parameters[173].Value = model.LN_DTL_PRT_KEYS;
			parameters[174].Value = model.LN_LTST_RISK_TYP_DT_N;
			parameters[175].Value = model.LN_LTST_PR_MV_DT_N;
			parameters[176].Value = model.LN_LTST_PR_MV_TM_N;
			parameters[177].Value = model.LN_ARR_AMT;
			parameters[178].Value = model.LN_PENALTY;
			parameters[179].Value = model.LN_PENL_STRT_DT_N;
			parameters[180].Value = model.LN_SVC_BAL;
			parameters[181].Value = model.LN_RCV_INT_TOTL;
			parameters[182].Value = model.LN_ACCUM_COLI;
			parameters[183].Value = model.LN_ACCUM_RECV_PNL;
			parameters[184].Value = model.LN_ACCUM_RECV_SVC;
			parameters[185].Value = model.LN_ADVPMT_TOTL;
			parameters[186].Value = model.LN_YHEAD_LN_BAL;
			parameters[187].Value = model.LN_CRNT_YR_LN_ACCUM;
			parameters[188].Value = model.LN_CRNT_YR_REV_ACCUM;
			parameters[189].Value = model.LN_CRNT_YR_COLLED_INT;
			parameters[190].Value = model.LN_EXCE_FLG;
			parameters[191].Value = model.LN_FS_FLG;
			parameters[192].Value = model.LN_HYP_FLG;
			parameters[193].Value = model.LN_NACCT_STS;
			parameters[194].Value = model.LN_ACCP_TYP;
			parameters[195].Value = model.LN_GUAR_ACCP_EXPT_NO;
			parameters[196].Value = model.LN_NOR_BACK_FLG;
			parameters[197].Value = model.LN_HUNT_DUE_DT_N;
			parameters[198].Value = model.LN_LOC_CITY_FLG;
			parameters[199].Value = model.LN_INT_RCPT_MAIL;
			parameters[200].Value = model.LN_DLAY_ADV;
			parameters[201].Value = model.LN_RFN_RCPT_MAIL;
			parameters[202].Value = model.LN_MBSTMT_CYCL;
			parameters[203].Value = model.LN_MBSTMT_DT_N;
			parameters[204].Value = model.LN_CACL_INTR_CYCL;
			parameters[205].Value = model.LN_CACL_INTR_DT;
			parameters[206].Value = model.LN_CACL_INTR_FLG;
			parameters[207].Value = model.LN_FSTM_RFN_DT_N;
			parameters[208].Value = model.LN_FSTM_INTP_DT_N;
			parameters[209].Value = model.LN_NEXT_PR_RFN_DT_N;
			parameters[210].Value = model.LN_NEXT_INT_RFN_DT_N;
			parameters[211].Value = model.LN_OLD_LN_ACCT_TRNI;
			parameters[212].Value = model.LN_NWLN_ACCT_NO_TRNO;
			parameters[213].Value = model.LN_AALFD_SUCS;
			parameters[214].Value = model.LN_FLST_TLR_NO;
			parameters[215].Value = model.LN_FLST_APRV_PIC_NO;
			parameters[216].Value = model.LN_FLST_DT_N;
			parameters[217].Value = model.LN_LTST_MNTN_OPR_NO;
			parameters[218].Value = model.LN_LTST_APRV_PIC_NO;
			parameters[219].Value = model.LN_SPV;
			parameters[220].Value = model.LN_LTST_MNTN_DT_N;
			parameters[221].Value = model.LN_CRNT_DAY_FST_TX_SQ_NO;
			parameters[222].Value = model.LN_CRNT_DAY_LST_TX_SQ_NO;
			parameters[223].Value = model.LN_ROP_INTC_STY_FLG;
			parameters[224].Value = model.LN_INT_INTC_STY_FLG;
			parameters[225].Value = model.LN_ADV_RFN_TOT_NUM_N;
			parameters[226].Value = model.LN_CURR_CYCL_FAC_YR_N;
			parameters[227].Value = model.LN_CURR_CYCL_ADV_NUM_N;
			parameters[228].Value = model.LN_PSBK_PRT_NO;
			parameters[229].Value = model.LN_INTR_ADJ_DAY;
			parameters[230].Value = model.LN_AAUTO_ROP;
			parameters[231].Value = model.LN_ROP_DURAN_CUTDT_N;
			parameters[232].Value = model.LN_APPL_DUE_DT_N;
			parameters[233].Value = model.LN_CNL_NO;
			parameters[234].Value = model.LN_BELONG_INSTN_COD;
			parameters[235].Value = model.LN_ASS_OPUN_NO;
			parameters[236].Value = model.LN_LTST_MNTN_OPUN_NO;
			parameters[237].Value = model.LN_TRS_OLD_SYS_FLG;
			parameters[238].Value = model.LN_FLST_OPUN_NO;
			parameters[239].Value = model.LN_DB_PART_ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MZSYCORE.Model.Model_CBOD_LNLNSLNS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CBOD_LNLNSLNS set ");
			strSql.Append("ETLDT=@ETLDT,");
			strSql.Append("LN_LN_ACCT_NO=@LN_LN_ACCT_NO,");
			strSql.Append("LNLNS_DB_TIMESTAMP=@LNLNS_DB_TIMESTAMP,");
			strSql.Append("LN_FINL_VRSN_N=@LN_FINL_VRSN_N,");
			strSql.Append("LN_DB_MNTN_NO_N=@LN_DB_MNTN_NO_N,");
			strSql.Append("LN_CUST_NO=@LN_CUST_NO,");
			strSql.Append("LN_CRLMT_NO=@LN_CRLMT_NO,");
			strSql.Append("LN_PDP_CODE=@LN_PDP_CODE,");
			strSql.Append("LN_BUSN_TYP=@LN_BUSN_TYP,");
			strSql.Append("LN_ACCT_STS=@LN_ACCT_STS,");
			strSql.Append("LN_VIP_ACCT_FLG=@LN_VIP_ACCT_FLG,");
			strSql.Append("LN_CUST_TYP=@LN_CUST_TYP,");
			strSql.Append("LN_CURR_COD=@LN_CURR_COD,");
			strSql.Append("LN_CURR_IDEN=@LN_CURR_IDEN,");
			strSql.Append("LN_FINBUSN=@LN_FINBUSN,");
			strSql.Append("LN_CURR_COD_AUTHOR=@LN_CURR_COD_AUTHOR,");
			strSql.Append("LN_LN_TYP=@LN_LN_TYP,");
			strSql.Append("LN_HYPO_TYP=@LN_HYPO_TYP,");
			strSql.Append("LN_NWLN_AMT_HYPO_AMT=@LN_NWLN_AMT_HYPO_AMT,");
			strSql.Append("LN_TOTL_LN_AMT_HYPO_AMT=@LN_TOTL_LN_AMT_HYPO_AMT,");
			strSql.Append("LN_LN_BAL=@LN_LN_BAL,");
			strSql.Append("LN_FRST_ALFD_DT_N=@LN_FRST_ALFD_DT_N,");
			strSql.Append("LN_DUE_DT_N=@LN_DUE_DT_N,");
			strSql.Append("LN_CLSD_DT_N=@LN_CLSD_DT_N,");
			strSql.Append("LN_RFN_STY=@LN_RFN_STY,");
			strSql.Append("LN_ROP_CYCL_MN_TOTL_N=@LN_ROP_CYCL_MN_TOTL_N,");
			strSql.Append("LN_ROP_CYCL_UNIT=@LN_ROP_CYCL_UNIT,");
			strSql.Append("LN_COLI_CYCL_TOTL_MN_N=@LN_COLI_CYCL_TOTL_MN_N,");
			strSql.Append("LN_COLI_CYCL_UNIT=@LN_COLI_CYCL_UNIT,");
			strSql.Append("LN_PPRD_INTP_DAY_N=@LN_PPRD_INTP_DAY_N,");
			strSql.Append("LN_ROP_DAY_N=@LN_ROP_DAY_N,");
			strSql.Append("LN_TOTL_PRD_N=@LN_TOTL_PRD_N,");
			strSql.Append("LN_ARFN_SCHD_PR_N=@LN_ARFN_SCHD_PR_N,");
			strSql.Append("LN_ARFN_SCHD_INT_N=@LN_ARFN_SCHD_INT_N,");
			strSql.Append("LN_TNRNO_N=@LN_TNRNO_N,");
			strSql.Append("LN_LN_MTHS_N=@LN_LN_MTHS_N,");
			strSql.Append("LN_PR_CAC_DT_N=@LN_PR_CAC_DT_N,");
			strSql.Append("LN_INTC_UP_DT_N=@LN_INTC_UP_DT_N,");
			strSql.Append("LN_INTC_UP_DT_ODD_DAYS_N=@LN_INTC_UP_DT_ODD_DAYS_N,");
			strSql.Append("LN_LAST_INTC_UP_DT_N=@LN_LAST_INTC_UP_DT_N,");
			strSql.Append("LN_INT_INTC_UP_DT_N=@LN_INT_INTC_UP_DT_N,");
			strSql.Append("LN_PMN_INTC_COD=@LN_PMN_INTC_COD,");
			strSql.Append("LN_CLSD_INTC_TYP=@LN_CLSD_INTC_TYP,");
			strSql.Append("LN_FRST_INTC_INTR=@LN_FRST_INTC_INTR,");
			strSql.Append("LN_FRST_DELAY_INTR=@LN_FRST_DELAY_INTR,");
			strSql.Append("LN_INTR_ADJ_STY=@LN_INTR_ADJ_STY,");
			strSql.Append("LN_INTR_ADJ_CYCL=@LN_INTR_ADJ_CYCL,");
			strSql.Append("LN_INTR_ADJ_STRT_DT_N=@LN_INTR_ADJ_STRT_DT_N,");
			strSql.Append("LN_INTR_EFF_DT_N=@LN_INTR_EFF_DT_N,");
			strSql.Append("LN_INTR_ACOR_STY=@LN_INTR_ACOR_STY,");
			strSql.Append("LN_INTR_TYP=@LN_INTR_TYP,");
			strSql.Append("LN_INTR_NEGO_SYMB=@LN_INTR_NEGO_SYMB,");
			strSql.Append("LN_INTR_NEGO_RATE=@LN_INTR_NEGO_RATE,");
			strSql.Append("LN_DLAY_INTR_ACOR_STY=@LN_DLAY_INTR_ACOR_STY,");
			strSql.Append("LN_DLAY_INTR_TYP=@LN_DLAY_INTR_TYP,");
			strSql.Append("LN_DLAY_INTR_PLMN_SYMB=@LN_DLAY_INTR_PLMN_SYMB,");
			strSql.Append("LN_DLAY_INTR_PLMN_COD=@LN_DLAY_INTR_PLMN_COD,");
			strSql.Append("LN_LN_FUND_RSUR=@LN_LN_FUND_RSUR,");
			strSql.Append("LN_LN_PURP=@LN_LN_PURP,");
			strSql.Append("LN_LN_STY=@LN_LN_STY,");
			strSql.Append("LN_USE_BOOK_FLG=@LN_USE_BOOK_FLG,");
			strSql.Append("LN_MULTI_RFN_FLG=@LN_MULTI_RFN_FLG,");
			strSql.Append("LN_RCT_EXTN_DT_N=@LN_RCT_EXTN_DT_N,");
			strSql.Append("LN_EXTN_CTRT_NO=@LN_EXTN_CTRT_NO,");
			strSql.Append("LN_EXTN_TM_N=@LN_EXTN_TM_N,");
			strSql.Append("LN_EXT_SEQ_NO_N=@LN_EXT_SEQ_NO_N,");
			strSql.Append("LN_BUSN_TYP_CHG_DT_N=@LN_BUSN_TYP_CHG_DT_N,");
			strSql.Append("LN_BUSN_TYP_NEW=@LN_BUSN_TYP_NEW,");
			strSql.Append("LN_BUSN_TYP_ORG=@LN_BUSN_TYP_ORG,");
			strSql.Append("LN_CHG_RFN_STY_DT_N=@LN_CHG_RFN_STY_DT_N,");
			strSql.Append("LN_CHG_RFN_STY=@LN_CHG_RFN_STY,");
			strSql.Append("LN_INT_STRV_DT_N=@LN_INT_STRV_DT_N,");
			strSql.Append("LN_PR_INTS_FLAG=@LN_PR_INTS_FLAG,");
			strSql.Append("LN_INT_INTS_FLAG=@LN_INT_INTS_FLAG,");
			strSql.Append("LN_INTS_EFF_DT_N=@LN_INTS_EFF_DT_N,");
			strSql.Append("LN_HALT_INTC_SYMB=@LN_HALT_INTC_SYMB,");
			strSql.Append("LN_HALT_STRT_DT_N=@LN_HALT_STRT_DT_N,");
			strSql.Append("LN_HALT_CUT_DT_N=@LN_HALT_CUT_DT_N,");
			strSql.Append("LN_COLL_SVC_STY=@LN_COLL_SVC_STY,");
			strSql.Append("LN_SVC_RTO=@LN_SVC_RTO,");
			strSql.Append("LN_TRTO=@LN_TRTO,");
			strSql.Append("LN_ROP_DURAN_N=@LN_ROP_DURAN_N,");
			strSql.Append("LN_DURAN_INTC_FLG=@LN_DURAN_INTC_FLG,");
			strSql.Append("LN_PR_TOLE_DAYS_N=@LN_PR_TOLE_DAYS_N,");
			strSql.Append("LN_INT_DURAN_DAYS_N=@LN_INT_DURAN_DAYS_N,");
			strSql.Append("LN_PAY_SEQ_FLG=@LN_PAY_SEQ_FLG,");
			strSql.Append("LN_AUTO_DDUT_PR_FLG=@LN_AUTO_DDUT_PR_FLG,");
			strSql.Append("LN_AUTO_DEDU_INT_FLG=@LN_AUTO_DEDU_INT_FLG,");
			strSql.Append("LN_DLY_AUTO_PAY_FLG=@LN_DLY_AUTO_PAY_FLG,");
			strSql.Append("LN_AUTO_DEDU_DEP_ACCT_NO_1=@LN_AUTO_DEDU_DEP_ACCT_NO_1,");
			strSql.Append("LN_AUTO_DEDU_DEP_ACCT_NO_2=@LN_AUTO_DEDU_DEP_ACCT_NO_2,");
			strSql.Append("LN_AUTO_DEDU_DEP_ACCT_NO_3=@LN_AUTO_DEDU_DEP_ACCT_NO_3,");
			strSql.Append("LN_AUTO_DEDU_ACCT_TYP_1=@LN_AUTO_DEDU_ACCT_TYP_1,");
			strSql.Append("LN_AUTO_DEDU_ACCT_TYP_2=@LN_AUTO_DEDU_ACCT_TYP_2,");
			strSql.Append("LN_AUTO_DEDU_ACCT_TYP_3=@LN_AUTO_DEDU_ACCT_TYP_3,");
			strSql.Append("LN_LN_TO_DEP_FLG=@LN_LN_TO_DEP_FLG,");
			strSql.Append("LN_DEP_ACCT_NO=@LN_DEP_ACCT_NO,");
			strSql.Append("LN_PAY_INT_ACCT_NO=@LN_PAY_INT_ACCT_NO,");
			strSql.Append("LN_ZHIBIAO_NO=@LN_ZHIBIAO_NO,");
			strSql.Append("LN_FAC_COD=@LN_FAC_COD,");
			strSql.Append("LN_DLF_COD=@LN_DLF_COD,");
			strSql.Append("LN_LNB_COD=@LN_LNB_COD,");
			strSql.Append("LN_FILLER1_COD=@LN_FILLER1_COD,");
			strSql.Append("LN_FILLER2_COD=@LN_FILLER2_COD,");
			strSql.Append("LN_INT_DIS_END_DT_N=@LN_INT_DIS_END_DT_N,");
			strSql.Append("LN_INT_DIS_RATE_N=@LN_INT_DIS_RATE_N,");
			strSql.Append("LN_FUND_TO_AUOR_FLG=@LN_FUND_TO_AUOR_FLG,");
			strSql.Append("LN_FUND_ACCT_NO=@LN_FUND_ACCT_NO,");
			strSql.Append("LN_AUOR_DEP_ACCT_NO=@LN_AUOR_DEP_ACCT_NO,");
			strSql.Append("LN_GUAR_MARGIN_ACCT_NO=@LN_GUAR_MARGIN_ACCT_NO,");
			strSql.Append("LN_TD_PSBK_NO_N=@LN_TD_PSBK_NO_N,");
			strSql.Append("LN_TD_PSBK_SEQ_NO_N=@LN_TD_PSBK_SEQ_NO_N,");
			strSql.Append("LN_FRZ_DT_N=@LN_FRZ_DT_N,");
			strSql.Append("LN_RWHLD_NO=@LN_RWHLD_NO,");
			strSql.Append("LN_HYPO_SQ_NO=@LN_HYPO_SQ_NO,");
			strSql.Append("LN_MAN_TOVD_FLG=@LN_MAN_TOVD_FLG,");
			strSql.Append("LN_BAD_LN_FLG=@LN_BAD_LN_FLG,");
			strSql.Append("LN_SIGNL_LN_INTURN_TABLE=@LN_SIGNL_LN_INTURN_TABLE,");
			strSql.Append("LN_INSTAL_RFN_PLAN=@LN_INSTAL_RFN_PLAN,");
			strSql.Append("LN_INSTAL_MULTI_RFN_STY=@LN_INSTAL_MULTI_RFN_STY,");
			strSql.Append("LN_PPRD_RFN_AMT=@LN_PPRD_RFN_AMT,");
			strSql.Append("LN_CRNT_PRD_RTN_AMT=@LN_CRNT_PRD_RTN_AMT,");
			strSql.Append("LN_CRNT_PRD_PAYRBL_PR=@LN_CRNT_PRD_PAYRBL_PR,");
			strSql.Append("LN_CRNT_PRD_PAYRBL_INT=@LN_CRNT_PRD_PAYRBL_INT,");
			strSql.Append("LN_NEXT_PRD_ARFN_AMT=@LN_NEXT_PRD_ARFN_AMT,");
			strSql.Append("LN_NEXT_PRD_PAYRBL_INT=@LN_NEXT_PRD_PAYRBL_INT,");
			strSql.Append("LN_WHHD_PR_ACCRUD=@LN_WHHD_PR_ACCRUD,");
			strSql.Append("LN_WHHD_INT_ACCRUD=@LN_WHHD_INT_ACCRUD,");
			strSql.Append("LN_INTRBL_INT=@LN_INTRBL_INT,");
			strSql.Append("LN_DLAY_INT_INT=@LN_DLAY_INT_INT,");
			strSql.Append("LN_OVDLN_INTRBL=@LN_OVDLN_INTRBL,");
			strSql.Append("LN_CRNT_OVDLN_INT_INT=@LN_CRNT_OVDLN_INT_INT,");
			strSql.Append("LN_CRNT_OVDLN_INTRBL=@LN_CRNT_OVDLN_INTRBL,");
			strSql.Append("LN_CRNT_OVDLN_LN_INTR=@LN_CRNT_OVDLN_LN_INTR,");
			strSql.Append("LN_DEVLU_INT=@LN_DEVLU_INT,");
			strSql.Append("LN_APCL_FLG=@LN_APCL_FLG,");
			strSql.Append("LN_INT_APCL_TOTL_INPLAN=@LN_INT_APCL_TOTL_INPLAN,");
			strSql.Append("LN_INTRBL_APCL_AMT_TOTL=@LN_INTRBL_APCL_AMT_TOTL,");
			strSql.Append("LN_OVDLN_INTRBL_APCL_TOTL=@LN_OVDLN_INTRBL_APCL_TOTL,");
			strSql.Append("LN_OVDLN_INT_APCL_TOTL=@LN_OVDLN_INT_APCL_TOTL,");
			strSql.Append("LN_LSAC_INT_APCL_TOTL=@LN_LSAC_INT_APCL_TOTL,");
			strSql.Append("LN_PR_APCL_TOTL=@LN_PR_APCL_TOTL,");
			strSql.Append("LN_CRNT_YR_INTRBL=@LN_CRNT_YR_INTRBL,");
			strSql.Append("LN_YHEAD_RBL_UCOLL_LN_INT=@LN_YHEAD_RBL_UCOLL_LN_INT,");
			strSql.Append("LN_ARR_PR=@LN_ARR_PR,");
			strSql.Append("LN_DLAY_PR_TOTL=@LN_DLAY_PR_TOTL,");
			strSql.Append("LN_TOVDLN_PR_BAL=@LN_TOVDLN_PR_BAL,");
			strSql.Append("LN_DLAY_LN_DT_N=@LN_DLAY_LN_DT_N,");
			strSql.Append("LN_TRNLST_OVD_DT_N=@LN_TRNLST_OVD_DT_N,");
			strSql.Append("LN_DLAY_LN_RSN=@LN_DLAY_LN_RSN,");
			strSql.Append("LN_DLAY_RSK_RTNG=@LN_DLAY_RSK_RTNG,");
			strSql.Append("LN_FOVDLN_SQ_DT_N=@LN_FOVDLN_SQ_DT_N,");
			strSql.Append("LN_DLAY_LN_FRN_DT_N=@LN_DLAY_LN_FRN_DT_N,");
			strSql.Append("LN_DLAY_LN_RFN_RSN=@LN_DLAY_LN_RFN_RSN,");
			strSql.Append("LN_DLAY_LN_RFN_AMT=@LN_DLAY_LN_RFN_AMT,");
			strSql.Append("LN_DERATE_PENALTY_TOTL=@LN_DERATE_PENALTY_TOTL,");
			strSql.Append("LN_DERATE_ARRAMT_TOTL=@LN_DERATE_ARRAMT_TOTL,");
			strSql.Append("LN_ROP_ROI_EXCS_FLAG=@LN_ROP_ROI_EXCS_FLAG,");
			strSql.Append("LN_INCR_DECR_AMT=@LN_INCR_DECR_AMT,");
			strSql.Append("LN_EQPROP_INCR_DECR=@LN_EQPROP_INCR_DECR,");
			strSql.Append("LN_INCR_DECR_INIT_PRD_N=@LN_INCR_DECR_INIT_PRD_N,");
			strSql.Append("LN_INCR_DECR_INTER_PRD_N=@LN_INCR_DECR_INTER_PRD_N,");
			strSql.Append("LN_CLOSE_FLG=@LN_CLOSE_FLG,");
			strSql.Append("LN_SYNLN_FLG=@LN_SYNLN_FLG,");
			strSql.Append("LN_RCPT_NO=@LN_RCPT_NO,");
			strSql.Append("LN_RMRK=@LN_RMRK,");
			strSql.Append("LN_FS_ACCT=@LN_FS_ACCT,");
			strSql.Append("LN_CUST_NAME=@LN_CUST_NAME,");
			strSql.Append("LN_CERT_TYP=@LN_CERT_TYP,");
			strSql.Append("LN_CERT_ID=@LN_CERT_ID,");
			strSql.Append("LN_CUSTD_RCPT_REF_NO=@LN_CUSTD_RCPT_REF_NO,");
			strSql.Append("LN_DTL_PRT_FLAG=@LN_DTL_PRT_FLAG,");
			strSql.Append("LN_DTL_PRT_PG_N=@LN_DTL_PRT_PG_N,");
			strSql.Append("LN_DTL_PRT_KEYS=@LN_DTL_PRT_KEYS,");
			strSql.Append("LN_LTST_RISK_TYP_DT_N=@LN_LTST_RISK_TYP_DT_N,");
			strSql.Append("LN_LTST_PR_MV_DT_N=@LN_LTST_PR_MV_DT_N,");
			strSql.Append("LN_LTST_PR_MV_TM_N=@LN_LTST_PR_MV_TM_N,");
			strSql.Append("LN_ARR_AMT=@LN_ARR_AMT,");
			strSql.Append("LN_PENALTY=@LN_PENALTY,");
			strSql.Append("LN_PENL_STRT_DT_N=@LN_PENL_STRT_DT_N,");
			strSql.Append("LN_SVC_BAL=@LN_SVC_BAL,");
			strSql.Append("LN_RCV_INT_TOTL=@LN_RCV_INT_TOTL,");
			strSql.Append("LN_ACCUM_COLI=@LN_ACCUM_COLI,");
			strSql.Append("LN_ACCUM_RECV_PNL=@LN_ACCUM_RECV_PNL,");
			strSql.Append("LN_ACCUM_RECV_SVC=@LN_ACCUM_RECV_SVC,");
			strSql.Append("LN_ADVPMT_TOTL=@LN_ADVPMT_TOTL,");
			strSql.Append("LN_YHEAD_LN_BAL=@LN_YHEAD_LN_BAL,");
			strSql.Append("LN_CRNT_YR_LN_ACCUM=@LN_CRNT_YR_LN_ACCUM,");
			strSql.Append("LN_CRNT_YR_REV_ACCUM=@LN_CRNT_YR_REV_ACCUM,");
			strSql.Append("LN_CRNT_YR_COLLED_INT=@LN_CRNT_YR_COLLED_INT,");
			strSql.Append("LN_EXCE_FLG=@LN_EXCE_FLG,");
			strSql.Append("LN_FS_FLG=@LN_FS_FLG,");
			strSql.Append("LN_HYP_FLG=@LN_HYP_FLG,");
			strSql.Append("LN_NACCT_STS=@LN_NACCT_STS,");
			strSql.Append("LN_ACCP_TYP=@LN_ACCP_TYP,");
			strSql.Append("LN_GUAR_ACCP_EXPT_NO=@LN_GUAR_ACCP_EXPT_NO,");
			strSql.Append("LN_NOR_BACK_FLG=@LN_NOR_BACK_FLG,");
			strSql.Append("LN_HUNT_DUE_DT_N=@LN_HUNT_DUE_DT_N,");
			strSql.Append("LN_LOC_CITY_FLG=@LN_LOC_CITY_FLG,");
			strSql.Append("LN_INT_RCPT_MAIL=@LN_INT_RCPT_MAIL,");
			strSql.Append("LN_DLAY_ADV=@LN_DLAY_ADV,");
			strSql.Append("LN_RFN_RCPT_MAIL=@LN_RFN_RCPT_MAIL,");
			strSql.Append("LN_MBSTMT_CYCL=@LN_MBSTMT_CYCL,");
			strSql.Append("LN_MBSTMT_DT_N=@LN_MBSTMT_DT_N,");
			strSql.Append("LN_CACL_INTR_CYCL=@LN_CACL_INTR_CYCL,");
			strSql.Append("LN_CACL_INTR_DT=@LN_CACL_INTR_DT,");
			strSql.Append("LN_CACL_INTR_FLG=@LN_CACL_INTR_FLG,");
			strSql.Append("LN_FSTM_RFN_DT_N=@LN_FSTM_RFN_DT_N,");
			strSql.Append("LN_FSTM_INTP_DT_N=@LN_FSTM_INTP_DT_N,");
			strSql.Append("LN_NEXT_PR_RFN_DT_N=@LN_NEXT_PR_RFN_DT_N,");
			strSql.Append("LN_NEXT_INT_RFN_DT_N=@LN_NEXT_INT_RFN_DT_N,");
			strSql.Append("LN_OLD_LN_ACCT_TRNI=@LN_OLD_LN_ACCT_TRNI,");
			strSql.Append("LN_NWLN_ACCT_NO_TRNO=@LN_NWLN_ACCT_NO_TRNO,");
			strSql.Append("LN_AALFD_SUCS=@LN_AALFD_SUCS,");
			strSql.Append("LN_FLST_TLR_NO=@LN_FLST_TLR_NO,");
			strSql.Append("LN_FLST_APRV_PIC_NO=@LN_FLST_APRV_PIC_NO,");
			strSql.Append("LN_FLST_DT_N=@LN_FLST_DT_N,");
			strSql.Append("LN_LTST_MNTN_OPR_NO=@LN_LTST_MNTN_OPR_NO,");
			strSql.Append("LN_LTST_APRV_PIC_NO=@LN_LTST_APRV_PIC_NO,");
			strSql.Append("LN_SPV=@LN_SPV,");
			strSql.Append("LN_LTST_MNTN_DT_N=@LN_LTST_MNTN_DT_N,");
			strSql.Append("LN_CRNT_DAY_FST_TX_SQ_NO=@LN_CRNT_DAY_FST_TX_SQ_NO,");
			strSql.Append("LN_CRNT_DAY_LST_TX_SQ_NO=@LN_CRNT_DAY_LST_TX_SQ_NO,");
			strSql.Append("LN_ROP_INTC_STY_FLG=@LN_ROP_INTC_STY_FLG,");
			strSql.Append("LN_INT_INTC_STY_FLG=@LN_INT_INTC_STY_FLG,");
			strSql.Append("LN_ADV_RFN_TOT_NUM_N=@LN_ADV_RFN_TOT_NUM_N,");
			strSql.Append("LN_CURR_CYCL_FAC_YR_N=@LN_CURR_CYCL_FAC_YR_N,");
			strSql.Append("LN_CURR_CYCL_ADV_NUM_N=@LN_CURR_CYCL_ADV_NUM_N,");
			strSql.Append("LN_PSBK_PRT_NO=@LN_PSBK_PRT_NO,");
			strSql.Append("LN_INTR_ADJ_DAY=@LN_INTR_ADJ_DAY,");
			strSql.Append("LN_AAUTO_ROP=@LN_AAUTO_ROP,");
			strSql.Append("LN_ROP_DURAN_CUTDT_N=@LN_ROP_DURAN_CUTDT_N,");
			strSql.Append("LN_APPL_DUE_DT_N=@LN_APPL_DUE_DT_N,");
			strSql.Append("LN_CNL_NO=@LN_CNL_NO,");
			strSql.Append("LN_BELONG_INSTN_COD=@LN_BELONG_INSTN_COD,");
			strSql.Append("LN_ASS_OPUN_NO=@LN_ASS_OPUN_NO,");
			strSql.Append("LN_LTST_MNTN_OPUN_NO=@LN_LTST_MNTN_OPUN_NO,");
			strSql.Append("LN_TRS_OLD_SYS_FLG=@LN_TRS_OLD_SYS_FLG,");
			strSql.Append("LN_FLST_OPUN_NO=@LN_FLST_OPUN_NO,");
			strSql.Append("LN_DB_PART_ID=@LN_DB_PART_ID");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@LN_LN_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LNLNS_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@LN_FINL_VRSN_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DB_MNTN_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CUST_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_CRLMT_NO", OleDbType.VarChar,4),
					new OleDbParameter("@LN_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@LN_BUSN_TYP", OleDbType.VarChar,3),
					new OleDbParameter("@LN_ACCT_STS", OleDbType.VarChar,1),
					new OleDbParameter("@LN_VIP_ACCT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CUST_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@LN_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FINBUSN", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CURR_COD_AUTHOR", OleDbType.VarChar,2),
					new OleDbParameter("@LN_LN_TYP", OleDbType.VarChar,3),
					new OleDbParameter("@LN_HYPO_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_NWLN_AMT_HYPO_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_TOTL_LN_AMT_HYPO_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_LN_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_FRST_ALFD_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DUE_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CLSD_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_RFN_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_ROP_CYCL_MN_TOTL_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_CYCL_UNIT", OleDbType.VarChar,1),
					new OleDbParameter("@LN_COLI_CYCL_TOTL_MN_N", OleDbType.Decimal),
					new OleDbParameter("@LN_COLI_CYCL_UNIT", OleDbType.VarChar,1),
					new OleDbParameter("@LN_PPRD_INTP_DAY_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_DAY_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TOTL_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ARFN_SCHD_PR_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ARFN_SCHD_INT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TNRNO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LN_MTHS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PR_CAC_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTC_UP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTC_UP_DT_ODD_DAYS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LAST_INTC_UP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INT_INTC_UP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PMN_INTC_COD", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CLSD_INTC_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FRST_INTC_INTR", OleDbType.Decimal),
					new OleDbParameter("@LN_FRST_DELAY_INTR", OleDbType.Decimal),
					new OleDbParameter("@LN_INTR_ADJ_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INTR_ADJ_CYCL", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INTR_ADJ_STRT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTR_EFF_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INTR_ACOR_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INTR_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INTR_NEGO_SYMB", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INTR_NEGO_RATE", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_INTR_ACOR_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_INTR_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_INTR_PLMN_SYMB", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DLAY_INTR_PLMN_COD", OleDbType.Decimal),
					new OleDbParameter("@LN_LN_FUND_RSUR", OleDbType.VarChar,2),
					new OleDbParameter("@LN_LN_PURP", OleDbType.VarChar,2),
					new OleDbParameter("@LN_LN_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_USE_BOOK_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_MULTI_RFN_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_RCT_EXTN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_EXTN_CTRT_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_EXTN_TM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_EXT_SEQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_BUSN_TYP_CHG_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_BUSN_TYP_NEW", OleDbType.VarChar,3),
					new OleDbParameter("@LN_BUSN_TYP_ORG", OleDbType.VarChar,3),
					new OleDbParameter("@LN_CHG_RFN_STY_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CHG_RFN_STY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_INT_STRV_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PR_INTS_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_INTS_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INTS_EFF_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_HALT_INTC_SYMB", OleDbType.VarChar,1),
					new OleDbParameter("@LN_HALT_STRT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_HALT_CUT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_COLL_SVC_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_SVC_RTO", OleDbType.Decimal),
					new OleDbParameter("@LN_TRTO", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_DURAN_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DURAN_INTC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_PR_TOLE_DAYS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INT_DURAN_DAYS_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PAY_SEQ_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DDUT_PR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_INT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DLY_AUTO_PAY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_DEP_ACCT_NO_1", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUTO_DEDU_DEP_ACCT_NO_2", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUTO_DEDU_DEP_ACCT_NO_3", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUTO_DEDU_ACCT_TYP_1", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_ACCT_TYP_2", OleDbType.VarChar,1),
					new OleDbParameter("@LN_AUTO_DEDU_ACCT_TYP_3", OleDbType.VarChar,1),
					new OleDbParameter("@LN_LN_TO_DEP_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DEP_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_PAY_INT_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_ZHIBIAO_NO", OleDbType.VarChar,19),
					new OleDbParameter("@LN_FAC_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_DLF_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_LNB_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_FILLER1_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_FILLER2_COD", OleDbType.VarChar,4),
					new OleDbParameter("@LN_INT_DIS_END_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INT_DIS_RATE_N", OleDbType.Decimal),
					new OleDbParameter("@LN_FUND_TO_AUOR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FUND_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AUOR_DEP_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_GUAR_MARGIN_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_TD_PSBK_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TD_PSBK_SEQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@LN_FRZ_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_RWHLD_NO", OleDbType.VarChar,10),
					new OleDbParameter("@LN_HYPO_SQ_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_MAN_TOVD_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_BAD_LN_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_SIGNL_LN_INTURN_TABLE", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INSTAL_RFN_PLAN", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INSTAL_MULTI_RFN_STY", OleDbType.VarChar,1),
					new OleDbParameter("@LN_PPRD_RFN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_PRD_RTN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_PRD_PAYRBL_PR", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_PRD_PAYRBL_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_PRD_ARFN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_PRD_PAYRBL_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_WHHD_PR_ACCRUD", OleDbType.Decimal),
					new OleDbParameter("@LN_WHHD_INT_ACCRUD", OleDbType.Decimal),
					new OleDbParameter("@LN_INTRBL_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_INT_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_OVDLN_INTRBL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_OVDLN_INT_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_OVDLN_INTRBL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_OVDLN_LN_INTR", OleDbType.Decimal),
					new OleDbParameter("@LN_DEVLU_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_APCL_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_APCL_TOTL_INPLAN", OleDbType.Decimal),
					new OleDbParameter("@LN_INTRBL_APCL_AMT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_OVDLN_INTRBL_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_OVDLN_INT_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_LSAC_INT_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_PR_APCL_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_INTRBL", OleDbType.Decimal),
					new OleDbParameter("@LN_YHEAD_RBL_UCOLL_LN_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_ARR_PR", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_PR_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_TOVDLN_PR_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_TRNLST_OVD_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_RSN", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_RSK_RTNG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FOVDLN_SQ_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_FRN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DLAY_LN_RFN_RSN", OleDbType.VarChar,2),
					new OleDbParameter("@LN_DLAY_LN_RFN_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_DERATE_PENALTY_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_DERATE_ARRAMT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_ROP_ROI_EXCS_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INCR_DECR_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_EQPROP_INCR_DECR", OleDbType.Decimal),
					new OleDbParameter("@LN_INCR_DECR_INIT_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@LN_INCR_DECR_INTER_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CLOSE_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_SYNLN_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_RCPT_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_RMRK", OleDbType.VarChar,62),
					new OleDbParameter("@LN_FS_ACCT", OleDbType.VarChar,28),
					new OleDbParameter("@LN_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@LN_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CERT_ID", OleDbType.VarChar,20),
					new OleDbParameter("@LN_CUSTD_RCPT_REF_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_DTL_PRT_FLAG", OleDbType.VarChar,3),
					new OleDbParameter("@LN_DTL_PRT_PG_N", OleDbType.Decimal),
					new OleDbParameter("@LN_DTL_PRT_KEYS", OleDbType.VarChar,19),
					new OleDbParameter("@LN_LTST_RISK_TYP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LTST_PR_MV_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LTST_PR_MV_TM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_ARR_AMT", OleDbType.Decimal),
					new OleDbParameter("@LN_PENALTY", OleDbType.Decimal),
					new OleDbParameter("@LN_PENL_STRT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_SVC_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_RCV_INT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_ACCUM_COLI", OleDbType.Decimal),
					new OleDbParameter("@LN_ACCUM_RECV_PNL", OleDbType.Decimal),
					new OleDbParameter("@LN_ACCUM_RECV_SVC", OleDbType.Decimal),
					new OleDbParameter("@LN_ADVPMT_TOTL", OleDbType.Decimal),
					new OleDbParameter("@LN_YHEAD_LN_BAL", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_LN_ACCUM", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_REV_ACCUM", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_YR_COLLED_INT", OleDbType.Decimal),
					new OleDbParameter("@LN_EXCE_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FS_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_HYP_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_NACCT_STS", OleDbType.VarChar,1),
					new OleDbParameter("@LN_ACCP_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_GUAR_ACCP_EXPT_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_NOR_BACK_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_HUNT_DUE_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LOC_CITY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_RCPT_MAIL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_DLAY_ADV", OleDbType.VarChar,1),
					new OleDbParameter("@LN_RFN_RCPT_MAIL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_MBSTMT_CYCL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_MBSTMT_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CACL_INTR_CYCL", OleDbType.VarChar,1),
					new OleDbParameter("@LN_CACL_INTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@LN_CACL_INTR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FSTM_RFN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_FSTM_INTP_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_PR_RFN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_NEXT_INT_RFN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_OLD_LN_ACCT_TRNI", OleDbType.VarChar,28),
					new OleDbParameter("@LN_NWLN_ACCT_NO_TRNO", OleDbType.VarChar,28),
					new OleDbParameter("@LN_AALFD_SUCS", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FLST_TLR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_FLST_APRV_PIC_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_FLST_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_LTST_MNTN_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_LTST_APRV_PIC_NO", OleDbType.VarChar,12),
					new OleDbParameter("@LN_SPV", OleDbType.VarChar,12),
					new OleDbParameter("@LN_LTST_MNTN_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CRNT_DAY_FST_TX_SQ_NO", OleDbType.VarChar,19),
					new OleDbParameter("@LN_CRNT_DAY_LST_TX_SQ_NO", OleDbType.VarChar,19),
					new OleDbParameter("@LN_ROP_INTC_STY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_INT_INTC_STY_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_ADV_RFN_TOT_NUM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CURR_CYCL_FAC_YR_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CURR_CYCL_ADV_NUM_N", OleDbType.Decimal),
					new OleDbParameter("@LN_PSBK_PRT_NO", OleDbType.VarChar,13),
					new OleDbParameter("@LN_INTR_ADJ_DAY", OleDbType.VarChar,2),
					new OleDbParameter("@LN_AAUTO_ROP", OleDbType.VarChar,1),
					new OleDbParameter("@LN_ROP_DURAN_CUTDT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_APPL_DUE_DT_N", OleDbType.Decimal),
					new OleDbParameter("@LN_CNL_NO", OleDbType.VarChar,20),
					new OleDbParameter("@LN_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@LN_ASS_OPUN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@LN_LTST_MNTN_OPUN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@LN_TRS_OLD_SYS_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@LN_FLST_OPUN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@LN_DB_PART_ID", OleDbType.VarChar,9)};
			parameters[0].Value = model.ETLDT;
			parameters[1].Value = model.LN_LN_ACCT_NO;
			parameters[2].Value = model.LNLNS_DB_TIMESTAMP;
			parameters[3].Value = model.LN_FINL_VRSN_N;
			parameters[4].Value = model.LN_DB_MNTN_NO_N;
			parameters[5].Value = model.LN_CUST_NO;
			parameters[6].Value = model.LN_CRLMT_NO;
			parameters[7].Value = model.LN_PDP_CODE;
			parameters[8].Value = model.LN_BUSN_TYP;
			parameters[9].Value = model.LN_ACCT_STS;
			parameters[10].Value = model.LN_VIP_ACCT_FLG;
			parameters[11].Value = model.LN_CUST_TYP;
			parameters[12].Value = model.LN_CURR_COD;
			parameters[13].Value = model.LN_CURR_IDEN;
			parameters[14].Value = model.LN_FINBUSN;
			parameters[15].Value = model.LN_CURR_COD_AUTHOR;
			parameters[16].Value = model.LN_LN_TYP;
			parameters[17].Value = model.LN_HYPO_TYP;
			parameters[18].Value = model.LN_NWLN_AMT_HYPO_AMT;
			parameters[19].Value = model.LN_TOTL_LN_AMT_HYPO_AMT;
			parameters[20].Value = model.LN_LN_BAL;
			parameters[21].Value = model.LN_FRST_ALFD_DT_N;
			parameters[22].Value = model.LN_DUE_DT_N;
			parameters[23].Value = model.LN_CLSD_DT_N;
			parameters[24].Value = model.LN_RFN_STY;
			parameters[25].Value = model.LN_ROP_CYCL_MN_TOTL_N;
			parameters[26].Value = model.LN_ROP_CYCL_UNIT;
			parameters[27].Value = model.LN_COLI_CYCL_TOTL_MN_N;
			parameters[28].Value = model.LN_COLI_CYCL_UNIT;
			parameters[29].Value = model.LN_PPRD_INTP_DAY_N;
			parameters[30].Value = model.LN_ROP_DAY_N;
			parameters[31].Value = model.LN_TOTL_PRD_N;
			parameters[32].Value = model.LN_ARFN_SCHD_PR_N;
			parameters[33].Value = model.LN_ARFN_SCHD_INT_N;
			parameters[34].Value = model.LN_TNRNO_N;
			parameters[35].Value = model.LN_LN_MTHS_N;
			parameters[36].Value = model.LN_PR_CAC_DT_N;
			parameters[37].Value = model.LN_INTC_UP_DT_N;
			parameters[38].Value = model.LN_INTC_UP_DT_ODD_DAYS_N;
			parameters[39].Value = model.LN_LAST_INTC_UP_DT_N;
			parameters[40].Value = model.LN_INT_INTC_UP_DT_N;
			parameters[41].Value = model.LN_PMN_INTC_COD;
			parameters[42].Value = model.LN_CLSD_INTC_TYP;
			parameters[43].Value = model.LN_FRST_INTC_INTR;
			parameters[44].Value = model.LN_FRST_DELAY_INTR;
			parameters[45].Value = model.LN_INTR_ADJ_STY;
			parameters[46].Value = model.LN_INTR_ADJ_CYCL;
			parameters[47].Value = model.LN_INTR_ADJ_STRT_DT_N;
			parameters[48].Value = model.LN_INTR_EFF_DT_N;
			parameters[49].Value = model.LN_INTR_ACOR_STY;
			parameters[50].Value = model.LN_INTR_TYP;
			parameters[51].Value = model.LN_INTR_NEGO_SYMB;
			parameters[52].Value = model.LN_INTR_NEGO_RATE;
			parameters[53].Value = model.LN_DLAY_INTR_ACOR_STY;
			parameters[54].Value = model.LN_DLAY_INTR_TYP;
			parameters[55].Value = model.LN_DLAY_INTR_PLMN_SYMB;
			parameters[56].Value = model.LN_DLAY_INTR_PLMN_COD;
			parameters[57].Value = model.LN_LN_FUND_RSUR;
			parameters[58].Value = model.LN_LN_PURP;
			parameters[59].Value = model.LN_LN_STY;
			parameters[60].Value = model.LN_USE_BOOK_FLG;
			parameters[61].Value = model.LN_MULTI_RFN_FLG;
			parameters[62].Value = model.LN_RCT_EXTN_DT_N;
			parameters[63].Value = model.LN_EXTN_CTRT_NO;
			parameters[64].Value = model.LN_EXTN_TM_N;
			parameters[65].Value = model.LN_EXT_SEQ_NO_N;
			parameters[66].Value = model.LN_BUSN_TYP_CHG_DT_N;
			parameters[67].Value = model.LN_BUSN_TYP_NEW;
			parameters[68].Value = model.LN_BUSN_TYP_ORG;
			parameters[69].Value = model.LN_CHG_RFN_STY_DT_N;
			parameters[70].Value = model.LN_CHG_RFN_STY;
			parameters[71].Value = model.LN_INT_STRV_DT_N;
			parameters[72].Value = model.LN_PR_INTS_FLAG;
			parameters[73].Value = model.LN_INT_INTS_FLAG;
			parameters[74].Value = model.LN_INTS_EFF_DT_N;
			parameters[75].Value = model.LN_HALT_INTC_SYMB;
			parameters[76].Value = model.LN_HALT_STRT_DT_N;
			parameters[77].Value = model.LN_HALT_CUT_DT_N;
			parameters[78].Value = model.LN_COLL_SVC_STY;
			parameters[79].Value = model.LN_SVC_RTO;
			parameters[80].Value = model.LN_TRTO;
			parameters[81].Value = model.LN_ROP_DURAN_N;
			parameters[82].Value = model.LN_DURAN_INTC_FLG;
			parameters[83].Value = model.LN_PR_TOLE_DAYS_N;
			parameters[84].Value = model.LN_INT_DURAN_DAYS_N;
			parameters[85].Value = model.LN_PAY_SEQ_FLG;
			parameters[86].Value = model.LN_AUTO_DDUT_PR_FLG;
			parameters[87].Value = model.LN_AUTO_DEDU_INT_FLG;
			parameters[88].Value = model.LN_DLY_AUTO_PAY_FLG;
			parameters[89].Value = model.LN_AUTO_DEDU_DEP_ACCT_NO_1;
			parameters[90].Value = model.LN_AUTO_DEDU_DEP_ACCT_NO_2;
			parameters[91].Value = model.LN_AUTO_DEDU_DEP_ACCT_NO_3;
			parameters[92].Value = model.LN_AUTO_DEDU_ACCT_TYP_1;
			parameters[93].Value = model.LN_AUTO_DEDU_ACCT_TYP_2;
			parameters[94].Value = model.LN_AUTO_DEDU_ACCT_TYP_3;
			parameters[95].Value = model.LN_LN_TO_DEP_FLG;
			parameters[96].Value = model.LN_DEP_ACCT_NO;
			parameters[97].Value = model.LN_PAY_INT_ACCT_NO;
			parameters[98].Value = model.LN_ZHIBIAO_NO;
			parameters[99].Value = model.LN_FAC_COD;
			parameters[100].Value = model.LN_DLF_COD;
			parameters[101].Value = model.LN_LNB_COD;
			parameters[102].Value = model.LN_FILLER1_COD;
			parameters[103].Value = model.LN_FILLER2_COD;
			parameters[104].Value = model.LN_INT_DIS_END_DT_N;
			parameters[105].Value = model.LN_INT_DIS_RATE_N;
			parameters[106].Value = model.LN_FUND_TO_AUOR_FLG;
			parameters[107].Value = model.LN_FUND_ACCT_NO;
			parameters[108].Value = model.LN_AUOR_DEP_ACCT_NO;
			parameters[109].Value = model.LN_GUAR_MARGIN_ACCT_NO;
			parameters[110].Value = model.LN_TD_PSBK_NO_N;
			parameters[111].Value = model.LN_TD_PSBK_SEQ_NO_N;
			parameters[112].Value = model.LN_FRZ_DT_N;
			parameters[113].Value = model.LN_RWHLD_NO;
			parameters[114].Value = model.LN_HYPO_SQ_NO;
			parameters[115].Value = model.LN_MAN_TOVD_FLG;
			parameters[116].Value = model.LN_BAD_LN_FLG;
			parameters[117].Value = model.LN_SIGNL_LN_INTURN_TABLE;
			parameters[118].Value = model.LN_INSTAL_RFN_PLAN;
			parameters[119].Value = model.LN_INSTAL_MULTI_RFN_STY;
			parameters[120].Value = model.LN_PPRD_RFN_AMT;
			parameters[121].Value = model.LN_CRNT_PRD_RTN_AMT;
			parameters[122].Value = model.LN_CRNT_PRD_PAYRBL_PR;
			parameters[123].Value = model.LN_CRNT_PRD_PAYRBL_INT;
			parameters[124].Value = model.LN_NEXT_PRD_ARFN_AMT;
			parameters[125].Value = model.LN_NEXT_PRD_PAYRBL_INT;
			parameters[126].Value = model.LN_WHHD_PR_ACCRUD;
			parameters[127].Value = model.LN_WHHD_INT_ACCRUD;
			parameters[128].Value = model.LN_INTRBL_INT;
			parameters[129].Value = model.LN_DLAY_INT_INT;
			parameters[130].Value = model.LN_OVDLN_INTRBL;
			parameters[131].Value = model.LN_CRNT_OVDLN_INT_INT;
			parameters[132].Value = model.LN_CRNT_OVDLN_INTRBL;
			parameters[133].Value = model.LN_CRNT_OVDLN_LN_INTR;
			parameters[134].Value = model.LN_DEVLU_INT;
			parameters[135].Value = model.LN_APCL_FLG;
			parameters[136].Value = model.LN_INT_APCL_TOTL_INPLAN;
			parameters[137].Value = model.LN_INTRBL_APCL_AMT_TOTL;
			parameters[138].Value = model.LN_OVDLN_INTRBL_APCL_TOTL;
			parameters[139].Value = model.LN_OVDLN_INT_APCL_TOTL;
			parameters[140].Value = model.LN_LSAC_INT_APCL_TOTL;
			parameters[141].Value = model.LN_PR_APCL_TOTL;
			parameters[142].Value = model.LN_CRNT_YR_INTRBL;
			parameters[143].Value = model.LN_YHEAD_RBL_UCOLL_LN_INT;
			parameters[144].Value = model.LN_ARR_PR;
			parameters[145].Value = model.LN_DLAY_PR_TOTL;
			parameters[146].Value = model.LN_TOVDLN_PR_BAL;
			parameters[147].Value = model.LN_DLAY_LN_DT_N;
			parameters[148].Value = model.LN_TRNLST_OVD_DT_N;
			parameters[149].Value = model.LN_DLAY_LN_RSN;
			parameters[150].Value = model.LN_DLAY_RSK_RTNG;
			parameters[151].Value = model.LN_FOVDLN_SQ_DT_N;
			parameters[152].Value = model.LN_DLAY_LN_FRN_DT_N;
			parameters[153].Value = model.LN_DLAY_LN_RFN_RSN;
			parameters[154].Value = model.LN_DLAY_LN_RFN_AMT;
			parameters[155].Value = model.LN_DERATE_PENALTY_TOTL;
			parameters[156].Value = model.LN_DERATE_ARRAMT_TOTL;
			parameters[157].Value = model.LN_ROP_ROI_EXCS_FLAG;
			parameters[158].Value = model.LN_INCR_DECR_AMT;
			parameters[159].Value = model.LN_EQPROP_INCR_DECR;
			parameters[160].Value = model.LN_INCR_DECR_INIT_PRD_N;
			parameters[161].Value = model.LN_INCR_DECR_INTER_PRD_N;
			parameters[162].Value = model.LN_CLOSE_FLG;
			parameters[163].Value = model.LN_SYNLN_FLG;
			parameters[164].Value = model.LN_RCPT_NO;
			parameters[165].Value = model.LN_RMRK;
			parameters[166].Value = model.LN_FS_ACCT;
			parameters[167].Value = model.LN_CUST_NAME;
			parameters[168].Value = model.LN_CERT_TYP;
			parameters[169].Value = model.LN_CERT_ID;
			parameters[170].Value = model.LN_CUSTD_RCPT_REF_NO;
			parameters[171].Value = model.LN_DTL_PRT_FLAG;
			parameters[172].Value = model.LN_DTL_PRT_PG_N;
			parameters[173].Value = model.LN_DTL_PRT_KEYS;
			parameters[174].Value = model.LN_LTST_RISK_TYP_DT_N;
			parameters[175].Value = model.LN_LTST_PR_MV_DT_N;
			parameters[176].Value = model.LN_LTST_PR_MV_TM_N;
			parameters[177].Value = model.LN_ARR_AMT;
			parameters[178].Value = model.LN_PENALTY;
			parameters[179].Value = model.LN_PENL_STRT_DT_N;
			parameters[180].Value = model.LN_SVC_BAL;
			parameters[181].Value = model.LN_RCV_INT_TOTL;
			parameters[182].Value = model.LN_ACCUM_COLI;
			parameters[183].Value = model.LN_ACCUM_RECV_PNL;
			parameters[184].Value = model.LN_ACCUM_RECV_SVC;
			parameters[185].Value = model.LN_ADVPMT_TOTL;
			parameters[186].Value = model.LN_YHEAD_LN_BAL;
			parameters[187].Value = model.LN_CRNT_YR_LN_ACCUM;
			parameters[188].Value = model.LN_CRNT_YR_REV_ACCUM;
			parameters[189].Value = model.LN_CRNT_YR_COLLED_INT;
			parameters[190].Value = model.LN_EXCE_FLG;
			parameters[191].Value = model.LN_FS_FLG;
			parameters[192].Value = model.LN_HYP_FLG;
			parameters[193].Value = model.LN_NACCT_STS;
			parameters[194].Value = model.LN_ACCP_TYP;
			parameters[195].Value = model.LN_GUAR_ACCP_EXPT_NO;
			parameters[196].Value = model.LN_NOR_BACK_FLG;
			parameters[197].Value = model.LN_HUNT_DUE_DT_N;
			parameters[198].Value = model.LN_LOC_CITY_FLG;
			parameters[199].Value = model.LN_INT_RCPT_MAIL;
			parameters[200].Value = model.LN_DLAY_ADV;
			parameters[201].Value = model.LN_RFN_RCPT_MAIL;
			parameters[202].Value = model.LN_MBSTMT_CYCL;
			parameters[203].Value = model.LN_MBSTMT_DT_N;
			parameters[204].Value = model.LN_CACL_INTR_CYCL;
			parameters[205].Value = model.LN_CACL_INTR_DT;
			parameters[206].Value = model.LN_CACL_INTR_FLG;
			parameters[207].Value = model.LN_FSTM_RFN_DT_N;
			parameters[208].Value = model.LN_FSTM_INTP_DT_N;
			parameters[209].Value = model.LN_NEXT_PR_RFN_DT_N;
			parameters[210].Value = model.LN_NEXT_INT_RFN_DT_N;
			parameters[211].Value = model.LN_OLD_LN_ACCT_TRNI;
			parameters[212].Value = model.LN_NWLN_ACCT_NO_TRNO;
			parameters[213].Value = model.LN_AALFD_SUCS;
			parameters[214].Value = model.LN_FLST_TLR_NO;
			parameters[215].Value = model.LN_FLST_APRV_PIC_NO;
			parameters[216].Value = model.LN_FLST_DT_N;
			parameters[217].Value = model.LN_LTST_MNTN_OPR_NO;
			parameters[218].Value = model.LN_LTST_APRV_PIC_NO;
			parameters[219].Value = model.LN_SPV;
			parameters[220].Value = model.LN_LTST_MNTN_DT_N;
			parameters[221].Value = model.LN_CRNT_DAY_FST_TX_SQ_NO;
			parameters[222].Value = model.LN_CRNT_DAY_LST_TX_SQ_NO;
			parameters[223].Value = model.LN_ROP_INTC_STY_FLG;
			parameters[224].Value = model.LN_INT_INTC_STY_FLG;
			parameters[225].Value = model.LN_ADV_RFN_TOT_NUM_N;
			parameters[226].Value = model.LN_CURR_CYCL_FAC_YR_N;
			parameters[227].Value = model.LN_CURR_CYCL_ADV_NUM_N;
			parameters[228].Value = model.LN_PSBK_PRT_NO;
			parameters[229].Value = model.LN_INTR_ADJ_DAY;
			parameters[230].Value = model.LN_AAUTO_ROP;
			parameters[231].Value = model.LN_ROP_DURAN_CUTDT_N;
			parameters[232].Value = model.LN_APPL_DUE_DT_N;
			parameters[233].Value = model.LN_CNL_NO;
			parameters[234].Value = model.LN_BELONG_INSTN_COD;
			parameters[235].Value = model.LN_ASS_OPUN_NO;
			parameters[236].Value = model.LN_LTST_MNTN_OPUN_NO;
			parameters[237].Value = model.LN_TRS_OLD_SYS_FLG;
			parameters[238].Value = model.LN_FLST_OPUN_NO;
			parameters[239].Value = model.LN_DB_PART_ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CBOD_LNLNSLNS ");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
			};

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MZSYCORE.Model.Model_CBOD_LNLNSLNS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ETLDT,LN_LN_ACCT_NO,LNLNS_DB_TIMESTAMP,LN_FINL_VRSN_N,LN_DB_MNTN_NO_N,LN_CUST_NO,LN_CRLMT_NO,LN_PDP_CODE,LN_BUSN_TYP,LN_ACCT_STS,LN_VIP_ACCT_FLG,LN_CUST_TYP,LN_CURR_COD,LN_CURR_IDEN,LN_FINBUSN,LN_CURR_COD_AUTHOR,LN_LN_TYP,LN_HYPO_TYP,LN_NWLN_AMT_HYPO_AMT,LN_TOTL_LN_AMT_HYPO_AMT,LN_LN_BAL,LN_FRST_ALFD_DT_N,LN_DUE_DT_N,LN_CLSD_DT_N,LN_RFN_STY,LN_ROP_CYCL_MN_TOTL_N,LN_ROP_CYCL_UNIT,LN_COLI_CYCL_TOTL_MN_N,LN_COLI_CYCL_UNIT,LN_PPRD_INTP_DAY_N,LN_ROP_DAY_N,LN_TOTL_PRD_N,LN_ARFN_SCHD_PR_N,LN_ARFN_SCHD_INT_N,LN_TNRNO_N,LN_LN_MTHS_N,LN_PR_CAC_DT_N,LN_INTC_UP_DT_N,LN_INTC_UP_DT_ODD_DAYS_N,LN_LAST_INTC_UP_DT_N,LN_INT_INTC_UP_DT_N,LN_PMN_INTC_COD,LN_CLSD_INTC_TYP,LN_FRST_INTC_INTR,LN_FRST_DELAY_INTR,LN_INTR_ADJ_STY,LN_INTR_ADJ_CYCL,LN_INTR_ADJ_STRT_DT_N,LN_INTR_EFF_DT_N,LN_INTR_ACOR_STY,LN_INTR_TYP,LN_INTR_NEGO_SYMB,LN_INTR_NEGO_RATE,LN_DLAY_INTR_ACOR_STY,LN_DLAY_INTR_TYP,LN_DLAY_INTR_PLMN_SYMB,LN_DLAY_INTR_PLMN_COD,LN_LN_FUND_RSUR,LN_LN_PURP,LN_LN_STY,LN_USE_BOOK_FLG,LN_MULTI_RFN_FLG,LN_RCT_EXTN_DT_N,LN_EXTN_CTRT_NO,LN_EXTN_TM_N,LN_EXT_SEQ_NO_N,LN_BUSN_TYP_CHG_DT_N,LN_BUSN_TYP_NEW,LN_BUSN_TYP_ORG,LN_CHG_RFN_STY_DT_N,LN_CHG_RFN_STY,LN_INT_STRV_DT_N,LN_PR_INTS_FLAG,LN_INT_INTS_FLAG,LN_INTS_EFF_DT_N,LN_HALT_INTC_SYMB,LN_HALT_STRT_DT_N,LN_HALT_CUT_DT_N,LN_COLL_SVC_STY,LN_SVC_RTO,LN_TRTO,LN_ROP_DURAN_N,LN_DURAN_INTC_FLG,LN_PR_TOLE_DAYS_N,LN_INT_DURAN_DAYS_N,LN_PAY_SEQ_FLG,LN_AUTO_DDUT_PR_FLG,LN_AUTO_DEDU_INT_FLG,LN_DLY_AUTO_PAY_FLG,LN_AUTO_DEDU_DEP_ACCT_NO_1,LN_AUTO_DEDU_DEP_ACCT_NO_2,LN_AUTO_DEDU_DEP_ACCT_NO_3,LN_AUTO_DEDU_ACCT_TYP_1,LN_AUTO_DEDU_ACCT_TYP_2,LN_AUTO_DEDU_ACCT_TYP_3,LN_LN_TO_DEP_FLG,LN_DEP_ACCT_NO,LN_PAY_INT_ACCT_NO,LN_ZHIBIAO_NO,LN_FAC_COD,LN_DLF_COD,LN_LNB_COD,LN_FILLER1_COD,LN_FILLER2_COD,LN_INT_DIS_END_DT_N,LN_INT_DIS_RATE_N,LN_FUND_TO_AUOR_FLG,LN_FUND_ACCT_NO,LN_AUOR_DEP_ACCT_NO,LN_GUAR_MARGIN_ACCT_NO,LN_TD_PSBK_NO_N,LN_TD_PSBK_SEQ_NO_N,LN_FRZ_DT_N,LN_RWHLD_NO,LN_HYPO_SQ_NO,LN_MAN_TOVD_FLG,LN_BAD_LN_FLG,LN_SIGNL_LN_INTURN_TABLE,LN_INSTAL_RFN_PLAN,LN_INSTAL_MULTI_RFN_STY,LN_PPRD_RFN_AMT,LN_CRNT_PRD_RTN_AMT,LN_CRNT_PRD_PAYRBL_PR,LN_CRNT_PRD_PAYRBL_INT,LN_NEXT_PRD_ARFN_AMT,LN_NEXT_PRD_PAYRBL_INT,LN_WHHD_PR_ACCRUD,LN_WHHD_INT_ACCRUD,LN_INTRBL_INT,LN_DLAY_INT_INT,LN_OVDLN_INTRBL,LN_CRNT_OVDLN_INT_INT,LN_CRNT_OVDLN_INTRBL,LN_CRNT_OVDLN_LN_INTR,LN_DEVLU_INT,LN_APCL_FLG,LN_INT_APCL_TOTL_INPLAN,LN_INTRBL_APCL_AMT_TOTL,LN_OVDLN_INTRBL_APCL_TOTL,LN_OVDLN_INT_APCL_TOTL,LN_LSAC_INT_APCL_TOTL,LN_PR_APCL_TOTL,LN_CRNT_YR_INTRBL,LN_YHEAD_RBL_UCOLL_LN_INT,LN_ARR_PR,LN_DLAY_PR_TOTL,LN_TOVDLN_PR_BAL,LN_DLAY_LN_DT_N,LN_TRNLST_OVD_DT_N,LN_DLAY_LN_RSN,LN_DLAY_RSK_RTNG,LN_FOVDLN_SQ_DT_N,LN_DLAY_LN_FRN_DT_N,LN_DLAY_LN_RFN_RSN,LN_DLAY_LN_RFN_AMT,LN_DERATE_PENALTY_TOTL,LN_DERATE_ARRAMT_TOTL,LN_ROP_ROI_EXCS_FLAG,LN_INCR_DECR_AMT,LN_EQPROP_INCR_DECR,LN_INCR_DECR_INIT_PRD_N,LN_INCR_DECR_INTER_PRD_N,LN_CLOSE_FLG,LN_SYNLN_FLG,LN_RCPT_NO,LN_RMRK,LN_FS_ACCT,LN_CUST_NAME,LN_CERT_TYP,LN_CERT_ID,LN_CUSTD_RCPT_REF_NO,LN_DTL_PRT_FLAG,LN_DTL_PRT_PG_N,LN_DTL_PRT_KEYS,LN_LTST_RISK_TYP_DT_N,LN_LTST_PR_MV_DT_N,LN_LTST_PR_MV_TM_N,LN_ARR_AMT,LN_PENALTY,LN_PENL_STRT_DT_N,LN_SVC_BAL,LN_RCV_INT_TOTL,LN_ACCUM_COLI,LN_ACCUM_RECV_PNL,LN_ACCUM_RECV_SVC,LN_ADVPMT_TOTL,LN_YHEAD_LN_BAL,LN_CRNT_YR_LN_ACCUM,LN_CRNT_YR_REV_ACCUM,LN_CRNT_YR_COLLED_INT,LN_EXCE_FLG,LN_FS_FLG,LN_HYP_FLG,LN_NACCT_STS,LN_ACCP_TYP,LN_GUAR_ACCP_EXPT_NO,LN_NOR_BACK_FLG,LN_HUNT_DUE_DT_N,LN_LOC_CITY_FLG,LN_INT_RCPT_MAIL,LN_DLAY_ADV,LN_RFN_RCPT_MAIL,LN_MBSTMT_CYCL,LN_MBSTMT_DT_N,LN_CACL_INTR_CYCL,LN_CACL_INTR_DT,LN_CACL_INTR_FLG,LN_FSTM_RFN_DT_N,LN_FSTM_INTP_DT_N,LN_NEXT_PR_RFN_DT_N,LN_NEXT_INT_RFN_DT_N,LN_OLD_LN_ACCT_TRNI,LN_NWLN_ACCT_NO_TRNO,LN_AALFD_SUCS,LN_FLST_TLR_NO,LN_FLST_APRV_PIC_NO,LN_FLST_DT_N,LN_LTST_MNTN_OPR_NO,LN_LTST_APRV_PIC_NO,LN_SPV,LN_LTST_MNTN_DT_N,LN_CRNT_DAY_FST_TX_SQ_NO,LN_CRNT_DAY_LST_TX_SQ_NO,LN_ROP_INTC_STY_FLG,LN_INT_INTC_STY_FLG,LN_ADV_RFN_TOT_NUM_N,LN_CURR_CYCL_FAC_YR_N,LN_CURR_CYCL_ADV_NUM_N,LN_PSBK_PRT_NO,LN_INTR_ADJ_DAY,LN_AAUTO_ROP,LN_ROP_DURAN_CUTDT_N,LN_APPL_DUE_DT_N,LN_CNL_NO,LN_BELONG_INSTN_COD,LN_ASS_OPUN_NO,LN_LTST_MNTN_OPUN_NO,LN_TRS_OLD_SYS_FLG,LN_FLST_OPUN_NO,LN_DB_PART_ID from CBOD_LNLNSLNS ");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
			};

			MZSYCORE.Model.Model_CBOD_LNLNSLNS model=new MZSYCORE.Model.Model_CBOD_LNLNSLNS();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MZSYCORE.Model.Model_CBOD_LNLNSLNS DataRowToModel(DataRow row)
		{
			MZSYCORE.Model.Model_CBOD_LNLNSLNS model=new MZSYCORE.Model.Model_CBOD_LNLNSLNS();
			if (row != null)
			{
				if(row["ETLDT"]!=null)
				{
					model.ETLDT=row["ETLDT"].ToString();
				}
				if(row["LN_LN_ACCT_NO"]!=null)
				{
					model.LN_LN_ACCT_NO=row["LN_LN_ACCT_NO"].ToString();
				}
				if(row["LNLNS_DB_TIMESTAMP"]!=null && row["LNLNS_DB_TIMESTAMP"].ToString()!="")
				{
					model.LNLNS_DB_TIMESTAMP=decimal.Parse(row["LNLNS_DB_TIMESTAMP"].ToString());
				}
				if(row["LN_FINL_VRSN_N"]!=null && row["LN_FINL_VRSN_N"].ToString()!="")
				{
					model.LN_FINL_VRSN_N=decimal.Parse(row["LN_FINL_VRSN_N"].ToString());
				}
				if(row["LN_DB_MNTN_NO_N"]!=null && row["LN_DB_MNTN_NO_N"].ToString()!="")
				{
					model.LN_DB_MNTN_NO_N=decimal.Parse(row["LN_DB_MNTN_NO_N"].ToString());
				}
				if(row["LN_CUST_NO"]!=null)
				{
					model.LN_CUST_NO=row["LN_CUST_NO"].ToString();
				}
				if(row["LN_CRLMT_NO"]!=null)
				{
					model.LN_CRLMT_NO=row["LN_CRLMT_NO"].ToString();
				}
				if(row["LN_PDP_CODE"]!=null)
				{
					model.LN_PDP_CODE=row["LN_PDP_CODE"].ToString();
				}
				if(row["LN_BUSN_TYP"]!=null)
				{
					model.LN_BUSN_TYP=row["LN_BUSN_TYP"].ToString();
				}
				if(row["LN_ACCT_STS"]!=null)
				{
					model.LN_ACCT_STS=row["LN_ACCT_STS"].ToString();
				}
				if(row["LN_VIP_ACCT_FLG"]!=null)
				{
					model.LN_VIP_ACCT_FLG=row["LN_VIP_ACCT_FLG"].ToString();
				}
				if(row["LN_CUST_TYP"]!=null)
				{
					model.LN_CUST_TYP=row["LN_CUST_TYP"].ToString();
				}
				if(row["LN_CURR_COD"]!=null)
				{
					model.LN_CURR_COD=row["LN_CURR_COD"].ToString();
				}
				if(row["LN_CURR_IDEN"]!=null)
				{
					model.LN_CURR_IDEN=row["LN_CURR_IDEN"].ToString();
				}
				if(row["LN_FINBUSN"]!=null)
				{
					model.LN_FINBUSN=row["LN_FINBUSN"].ToString();
				}
				if(row["LN_CURR_COD_AUTHOR"]!=null)
				{
					model.LN_CURR_COD_AUTHOR=row["LN_CURR_COD_AUTHOR"].ToString();
				}
				if(row["LN_LN_TYP"]!=null)
				{
					model.LN_LN_TYP=row["LN_LN_TYP"].ToString();
				}
				if(row["LN_HYPO_TYP"]!=null)
				{
					model.LN_HYPO_TYP=row["LN_HYPO_TYP"].ToString();
				}
				if(row["LN_NWLN_AMT_HYPO_AMT"]!=null && row["LN_NWLN_AMT_HYPO_AMT"].ToString()!="")
				{
					model.LN_NWLN_AMT_HYPO_AMT=decimal.Parse(row["LN_NWLN_AMT_HYPO_AMT"].ToString());
				}
				if(row["LN_TOTL_LN_AMT_HYPO_AMT"]!=null && row["LN_TOTL_LN_AMT_HYPO_AMT"].ToString()!="")
				{
					model.LN_TOTL_LN_AMT_HYPO_AMT=decimal.Parse(row["LN_TOTL_LN_AMT_HYPO_AMT"].ToString());
				}
				if(row["LN_LN_BAL"]!=null && row["LN_LN_BAL"].ToString()!="")
				{
					model.LN_LN_BAL=decimal.Parse(row["LN_LN_BAL"].ToString());
				}
				if(row["LN_FRST_ALFD_DT_N"]!=null && row["LN_FRST_ALFD_DT_N"].ToString()!="")
				{
					model.LN_FRST_ALFD_DT_N=decimal.Parse(row["LN_FRST_ALFD_DT_N"].ToString());
				}
				if(row["LN_DUE_DT_N"]!=null && row["LN_DUE_DT_N"].ToString()!="")
				{
					model.LN_DUE_DT_N=decimal.Parse(row["LN_DUE_DT_N"].ToString());
				}
				if(row["LN_CLSD_DT_N"]!=null && row["LN_CLSD_DT_N"].ToString()!="")
				{
					model.LN_CLSD_DT_N=decimal.Parse(row["LN_CLSD_DT_N"].ToString());
				}
				if(row["LN_RFN_STY"]!=null)
				{
					model.LN_RFN_STY=row["LN_RFN_STY"].ToString();
				}
				if(row["LN_ROP_CYCL_MN_TOTL_N"]!=null && row["LN_ROP_CYCL_MN_TOTL_N"].ToString()!="")
				{
					model.LN_ROP_CYCL_MN_TOTL_N=decimal.Parse(row["LN_ROP_CYCL_MN_TOTL_N"].ToString());
				}
				if(row["LN_ROP_CYCL_UNIT"]!=null)
				{
					model.LN_ROP_CYCL_UNIT=row["LN_ROP_CYCL_UNIT"].ToString();
				}
				if(row["LN_COLI_CYCL_TOTL_MN_N"]!=null && row["LN_COLI_CYCL_TOTL_MN_N"].ToString()!="")
				{
					model.LN_COLI_CYCL_TOTL_MN_N=decimal.Parse(row["LN_COLI_CYCL_TOTL_MN_N"].ToString());
				}
				if(row["LN_COLI_CYCL_UNIT"]!=null)
				{
					model.LN_COLI_CYCL_UNIT=row["LN_COLI_CYCL_UNIT"].ToString();
				}
				if(row["LN_PPRD_INTP_DAY_N"]!=null && row["LN_PPRD_INTP_DAY_N"].ToString()!="")
				{
					model.LN_PPRD_INTP_DAY_N=decimal.Parse(row["LN_PPRD_INTP_DAY_N"].ToString());
				}
				if(row["LN_ROP_DAY_N"]!=null && row["LN_ROP_DAY_N"].ToString()!="")
				{
					model.LN_ROP_DAY_N=decimal.Parse(row["LN_ROP_DAY_N"].ToString());
				}
				if(row["LN_TOTL_PRD_N"]!=null && row["LN_TOTL_PRD_N"].ToString()!="")
				{
					model.LN_TOTL_PRD_N=decimal.Parse(row["LN_TOTL_PRD_N"].ToString());
				}
				if(row["LN_ARFN_SCHD_PR_N"]!=null && row["LN_ARFN_SCHD_PR_N"].ToString()!="")
				{
					model.LN_ARFN_SCHD_PR_N=decimal.Parse(row["LN_ARFN_SCHD_PR_N"].ToString());
				}
				if(row["LN_ARFN_SCHD_INT_N"]!=null && row["LN_ARFN_SCHD_INT_N"].ToString()!="")
				{
					model.LN_ARFN_SCHD_INT_N=decimal.Parse(row["LN_ARFN_SCHD_INT_N"].ToString());
				}
				if(row["LN_TNRNO_N"]!=null && row["LN_TNRNO_N"].ToString()!="")
				{
					model.LN_TNRNO_N=decimal.Parse(row["LN_TNRNO_N"].ToString());
				}
				if(row["LN_LN_MTHS_N"]!=null && row["LN_LN_MTHS_N"].ToString()!="")
				{
					model.LN_LN_MTHS_N=decimal.Parse(row["LN_LN_MTHS_N"].ToString());
				}
				if(row["LN_PR_CAC_DT_N"]!=null && row["LN_PR_CAC_DT_N"].ToString()!="")
				{
					model.LN_PR_CAC_DT_N=decimal.Parse(row["LN_PR_CAC_DT_N"].ToString());
				}
				if(row["LN_INTC_UP_DT_N"]!=null && row["LN_INTC_UP_DT_N"].ToString()!="")
				{
					model.LN_INTC_UP_DT_N=decimal.Parse(row["LN_INTC_UP_DT_N"].ToString());
				}
				if(row["LN_INTC_UP_DT_ODD_DAYS_N"]!=null && row["LN_INTC_UP_DT_ODD_DAYS_N"].ToString()!="")
				{
					model.LN_INTC_UP_DT_ODD_DAYS_N=decimal.Parse(row["LN_INTC_UP_DT_ODD_DAYS_N"].ToString());
				}
				if(row["LN_LAST_INTC_UP_DT_N"]!=null && row["LN_LAST_INTC_UP_DT_N"].ToString()!="")
				{
					model.LN_LAST_INTC_UP_DT_N=decimal.Parse(row["LN_LAST_INTC_UP_DT_N"].ToString());
				}
				if(row["LN_INT_INTC_UP_DT_N"]!=null && row["LN_INT_INTC_UP_DT_N"].ToString()!="")
				{
					model.LN_INT_INTC_UP_DT_N=decimal.Parse(row["LN_INT_INTC_UP_DT_N"].ToString());
				}
				if(row["LN_PMN_INTC_COD"]!=null)
				{
					model.LN_PMN_INTC_COD=row["LN_PMN_INTC_COD"].ToString();
				}
				if(row["LN_CLSD_INTC_TYP"]!=null)
				{
					model.LN_CLSD_INTC_TYP=row["LN_CLSD_INTC_TYP"].ToString();
				}
				if(row["LN_FRST_INTC_INTR"]!=null && row["LN_FRST_INTC_INTR"].ToString()!="")
				{
					model.LN_FRST_INTC_INTR=decimal.Parse(row["LN_FRST_INTC_INTR"].ToString());
				}
				if(row["LN_FRST_DELAY_INTR"]!=null && row["LN_FRST_DELAY_INTR"].ToString()!="")
				{
					model.LN_FRST_DELAY_INTR=decimal.Parse(row["LN_FRST_DELAY_INTR"].ToString());
				}
				if(row["LN_INTR_ADJ_STY"]!=null)
				{
					model.LN_INTR_ADJ_STY=row["LN_INTR_ADJ_STY"].ToString();
				}
				if(row["LN_INTR_ADJ_CYCL"]!=null)
				{
					model.LN_INTR_ADJ_CYCL=row["LN_INTR_ADJ_CYCL"].ToString();
				}
				if(row["LN_INTR_ADJ_STRT_DT_N"]!=null && row["LN_INTR_ADJ_STRT_DT_N"].ToString()!="")
				{
					model.LN_INTR_ADJ_STRT_DT_N=decimal.Parse(row["LN_INTR_ADJ_STRT_DT_N"].ToString());
				}
				if(row["LN_INTR_EFF_DT_N"]!=null && row["LN_INTR_EFF_DT_N"].ToString()!="")
				{
					model.LN_INTR_EFF_DT_N=decimal.Parse(row["LN_INTR_EFF_DT_N"].ToString());
				}
				if(row["LN_INTR_ACOR_STY"]!=null)
				{
					model.LN_INTR_ACOR_STY=row["LN_INTR_ACOR_STY"].ToString();
				}
				if(row["LN_INTR_TYP"]!=null)
				{
					model.LN_INTR_TYP=row["LN_INTR_TYP"].ToString();
				}
				if(row["LN_INTR_NEGO_SYMB"]!=null)
				{
					model.LN_INTR_NEGO_SYMB=row["LN_INTR_NEGO_SYMB"].ToString();
				}
				if(row["LN_INTR_NEGO_RATE"]!=null && row["LN_INTR_NEGO_RATE"].ToString()!="")
				{
					model.LN_INTR_NEGO_RATE=decimal.Parse(row["LN_INTR_NEGO_RATE"].ToString());
				}
				if(row["LN_DLAY_INTR_ACOR_STY"]!=null)
				{
					model.LN_DLAY_INTR_ACOR_STY=row["LN_DLAY_INTR_ACOR_STY"].ToString();
				}
				if(row["LN_DLAY_INTR_TYP"]!=null)
				{
					model.LN_DLAY_INTR_TYP=row["LN_DLAY_INTR_TYP"].ToString();
				}
				if(row["LN_DLAY_INTR_PLMN_SYMB"]!=null)
				{
					model.LN_DLAY_INTR_PLMN_SYMB=row["LN_DLAY_INTR_PLMN_SYMB"].ToString();
				}
				if(row["LN_DLAY_INTR_PLMN_COD"]!=null && row["LN_DLAY_INTR_PLMN_COD"].ToString()!="")
				{
					model.LN_DLAY_INTR_PLMN_COD=decimal.Parse(row["LN_DLAY_INTR_PLMN_COD"].ToString());
				}
				if(row["LN_LN_FUND_RSUR"]!=null)
				{
					model.LN_LN_FUND_RSUR=row["LN_LN_FUND_RSUR"].ToString();
				}
				if(row["LN_LN_PURP"]!=null)
				{
					model.LN_LN_PURP=row["LN_LN_PURP"].ToString();
				}
				if(row["LN_LN_STY"]!=null)
				{
					model.LN_LN_STY=row["LN_LN_STY"].ToString();
				}
				if(row["LN_USE_BOOK_FLG"]!=null)
				{
					model.LN_USE_BOOK_FLG=row["LN_USE_BOOK_FLG"].ToString();
				}
				if(row["LN_MULTI_RFN_FLG"]!=null)
				{
					model.LN_MULTI_RFN_FLG=row["LN_MULTI_RFN_FLG"].ToString();
				}
				if(row["LN_RCT_EXTN_DT_N"]!=null && row["LN_RCT_EXTN_DT_N"].ToString()!="")
				{
					model.LN_RCT_EXTN_DT_N=decimal.Parse(row["LN_RCT_EXTN_DT_N"].ToString());
				}
				if(row["LN_EXTN_CTRT_NO"]!=null)
				{
					model.LN_EXTN_CTRT_NO=row["LN_EXTN_CTRT_NO"].ToString();
				}
				if(row["LN_EXTN_TM_N"]!=null && row["LN_EXTN_TM_N"].ToString()!="")
				{
					model.LN_EXTN_TM_N=decimal.Parse(row["LN_EXTN_TM_N"].ToString());
				}
				if(row["LN_EXT_SEQ_NO_N"]!=null && row["LN_EXT_SEQ_NO_N"].ToString()!="")
				{
					model.LN_EXT_SEQ_NO_N=decimal.Parse(row["LN_EXT_SEQ_NO_N"].ToString());
				}
				if(row["LN_BUSN_TYP_CHG_DT_N"]!=null && row["LN_BUSN_TYP_CHG_DT_N"].ToString()!="")
				{
					model.LN_BUSN_TYP_CHG_DT_N=decimal.Parse(row["LN_BUSN_TYP_CHG_DT_N"].ToString());
				}
				if(row["LN_BUSN_TYP_NEW"]!=null)
				{
					model.LN_BUSN_TYP_NEW=row["LN_BUSN_TYP_NEW"].ToString();
				}
				if(row["LN_BUSN_TYP_ORG"]!=null)
				{
					model.LN_BUSN_TYP_ORG=row["LN_BUSN_TYP_ORG"].ToString();
				}
				if(row["LN_CHG_RFN_STY_DT_N"]!=null && row["LN_CHG_RFN_STY_DT_N"].ToString()!="")
				{
					model.LN_CHG_RFN_STY_DT_N=decimal.Parse(row["LN_CHG_RFN_STY_DT_N"].ToString());
				}
				if(row["LN_CHG_RFN_STY"]!=null)
				{
					model.LN_CHG_RFN_STY=row["LN_CHG_RFN_STY"].ToString();
				}
				if(row["LN_INT_STRV_DT_N"]!=null && row["LN_INT_STRV_DT_N"].ToString()!="")
				{
					model.LN_INT_STRV_DT_N=decimal.Parse(row["LN_INT_STRV_DT_N"].ToString());
				}
				if(row["LN_PR_INTS_FLAG"]!=null)
				{
					model.LN_PR_INTS_FLAG=row["LN_PR_INTS_FLAG"].ToString();
				}
				if(row["LN_INT_INTS_FLAG"]!=null)
				{
					model.LN_INT_INTS_FLAG=row["LN_INT_INTS_FLAG"].ToString();
				}
				if(row["LN_INTS_EFF_DT_N"]!=null && row["LN_INTS_EFF_DT_N"].ToString()!="")
				{
					model.LN_INTS_EFF_DT_N=decimal.Parse(row["LN_INTS_EFF_DT_N"].ToString());
				}
				if(row["LN_HALT_INTC_SYMB"]!=null)
				{
					model.LN_HALT_INTC_SYMB=row["LN_HALT_INTC_SYMB"].ToString();
				}
				if(row["LN_HALT_STRT_DT_N"]!=null && row["LN_HALT_STRT_DT_N"].ToString()!="")
				{
					model.LN_HALT_STRT_DT_N=decimal.Parse(row["LN_HALT_STRT_DT_N"].ToString());
				}
				if(row["LN_HALT_CUT_DT_N"]!=null && row["LN_HALT_CUT_DT_N"].ToString()!="")
				{
					model.LN_HALT_CUT_DT_N=decimal.Parse(row["LN_HALT_CUT_DT_N"].ToString());
				}
				if(row["LN_COLL_SVC_STY"]!=null)
				{
					model.LN_COLL_SVC_STY=row["LN_COLL_SVC_STY"].ToString();
				}
				if(row["LN_SVC_RTO"]!=null && row["LN_SVC_RTO"].ToString()!="")
				{
					model.LN_SVC_RTO=decimal.Parse(row["LN_SVC_RTO"].ToString());
				}
				if(row["LN_TRTO"]!=null && row["LN_TRTO"].ToString()!="")
				{
					model.LN_TRTO=decimal.Parse(row["LN_TRTO"].ToString());
				}
				if(row["LN_ROP_DURAN_N"]!=null && row["LN_ROP_DURAN_N"].ToString()!="")
				{
					model.LN_ROP_DURAN_N=decimal.Parse(row["LN_ROP_DURAN_N"].ToString());
				}
				if(row["LN_DURAN_INTC_FLG"]!=null)
				{
					model.LN_DURAN_INTC_FLG=row["LN_DURAN_INTC_FLG"].ToString();
				}
				if(row["LN_PR_TOLE_DAYS_N"]!=null && row["LN_PR_TOLE_DAYS_N"].ToString()!="")
				{
					model.LN_PR_TOLE_DAYS_N=decimal.Parse(row["LN_PR_TOLE_DAYS_N"].ToString());
				}
				if(row["LN_INT_DURAN_DAYS_N"]!=null && row["LN_INT_DURAN_DAYS_N"].ToString()!="")
				{
					model.LN_INT_DURAN_DAYS_N=decimal.Parse(row["LN_INT_DURAN_DAYS_N"].ToString());
				}
				if(row["LN_PAY_SEQ_FLG"]!=null)
				{
					model.LN_PAY_SEQ_FLG=row["LN_PAY_SEQ_FLG"].ToString();
				}
				if(row["LN_AUTO_DDUT_PR_FLG"]!=null)
				{
					model.LN_AUTO_DDUT_PR_FLG=row["LN_AUTO_DDUT_PR_FLG"].ToString();
				}
				if(row["LN_AUTO_DEDU_INT_FLG"]!=null)
				{
					model.LN_AUTO_DEDU_INT_FLG=row["LN_AUTO_DEDU_INT_FLG"].ToString();
				}
				if(row["LN_DLY_AUTO_PAY_FLG"]!=null)
				{
					model.LN_DLY_AUTO_PAY_FLG=row["LN_DLY_AUTO_PAY_FLG"].ToString();
				}
				if(row["LN_AUTO_DEDU_DEP_ACCT_NO_1"]!=null)
				{
					model.LN_AUTO_DEDU_DEP_ACCT_NO_1=row["LN_AUTO_DEDU_DEP_ACCT_NO_1"].ToString();
				}
				if(row["LN_AUTO_DEDU_DEP_ACCT_NO_2"]!=null)
				{
					model.LN_AUTO_DEDU_DEP_ACCT_NO_2=row["LN_AUTO_DEDU_DEP_ACCT_NO_2"].ToString();
				}
				if(row["LN_AUTO_DEDU_DEP_ACCT_NO_3"]!=null)
				{
					model.LN_AUTO_DEDU_DEP_ACCT_NO_3=row["LN_AUTO_DEDU_DEP_ACCT_NO_3"].ToString();
				}
				if(row["LN_AUTO_DEDU_ACCT_TYP_1"]!=null)
				{
					model.LN_AUTO_DEDU_ACCT_TYP_1=row["LN_AUTO_DEDU_ACCT_TYP_1"].ToString();
				}
				if(row["LN_AUTO_DEDU_ACCT_TYP_2"]!=null)
				{
					model.LN_AUTO_DEDU_ACCT_TYP_2=row["LN_AUTO_DEDU_ACCT_TYP_2"].ToString();
				}
				if(row["LN_AUTO_DEDU_ACCT_TYP_3"]!=null)
				{
					model.LN_AUTO_DEDU_ACCT_TYP_3=row["LN_AUTO_DEDU_ACCT_TYP_3"].ToString();
				}
				if(row["LN_LN_TO_DEP_FLG"]!=null)
				{
					model.LN_LN_TO_DEP_FLG=row["LN_LN_TO_DEP_FLG"].ToString();
				}
				if(row["LN_DEP_ACCT_NO"]!=null)
				{
					model.LN_DEP_ACCT_NO=row["LN_DEP_ACCT_NO"].ToString();
				}
				if(row["LN_PAY_INT_ACCT_NO"]!=null)
				{
					model.LN_PAY_INT_ACCT_NO=row["LN_PAY_INT_ACCT_NO"].ToString();
				}
				if(row["LN_ZHIBIAO_NO"]!=null)
				{
					model.LN_ZHIBIAO_NO=row["LN_ZHIBIAO_NO"].ToString();
				}
				if(row["LN_FAC_COD"]!=null)
				{
					model.LN_FAC_COD=row["LN_FAC_COD"].ToString();
				}
				if(row["LN_DLF_COD"]!=null)
				{
					model.LN_DLF_COD=row["LN_DLF_COD"].ToString();
				}
				if(row["LN_LNB_COD"]!=null)
				{
					model.LN_LNB_COD=row["LN_LNB_COD"].ToString();
				}
				if(row["LN_FILLER1_COD"]!=null)
				{
					model.LN_FILLER1_COD=row["LN_FILLER1_COD"].ToString();
				}
				if(row["LN_FILLER2_COD"]!=null)
				{
					model.LN_FILLER2_COD=row["LN_FILLER2_COD"].ToString();
				}
				if(row["LN_INT_DIS_END_DT_N"]!=null && row["LN_INT_DIS_END_DT_N"].ToString()!="")
				{
					model.LN_INT_DIS_END_DT_N=decimal.Parse(row["LN_INT_DIS_END_DT_N"].ToString());
				}
				if(row["LN_INT_DIS_RATE_N"]!=null && row["LN_INT_DIS_RATE_N"].ToString()!="")
				{
					model.LN_INT_DIS_RATE_N=decimal.Parse(row["LN_INT_DIS_RATE_N"].ToString());
				}
				if(row["LN_FUND_TO_AUOR_FLG"]!=null)
				{
					model.LN_FUND_TO_AUOR_FLG=row["LN_FUND_TO_AUOR_FLG"].ToString();
				}
				if(row["LN_FUND_ACCT_NO"]!=null)
				{
					model.LN_FUND_ACCT_NO=row["LN_FUND_ACCT_NO"].ToString();
				}
				if(row["LN_AUOR_DEP_ACCT_NO"]!=null)
				{
					model.LN_AUOR_DEP_ACCT_NO=row["LN_AUOR_DEP_ACCT_NO"].ToString();
				}
				if(row["LN_GUAR_MARGIN_ACCT_NO"]!=null)
				{
					model.LN_GUAR_MARGIN_ACCT_NO=row["LN_GUAR_MARGIN_ACCT_NO"].ToString();
				}
				if(row["LN_TD_PSBK_NO_N"]!=null && row["LN_TD_PSBK_NO_N"].ToString()!="")
				{
					model.LN_TD_PSBK_NO_N=decimal.Parse(row["LN_TD_PSBK_NO_N"].ToString());
				}
				if(row["LN_TD_PSBK_SEQ_NO_N"]!=null && row["LN_TD_PSBK_SEQ_NO_N"].ToString()!="")
				{
					model.LN_TD_PSBK_SEQ_NO_N=decimal.Parse(row["LN_TD_PSBK_SEQ_NO_N"].ToString());
				}
				if(row["LN_FRZ_DT_N"]!=null && row["LN_FRZ_DT_N"].ToString()!="")
				{
					model.LN_FRZ_DT_N=decimal.Parse(row["LN_FRZ_DT_N"].ToString());
				}
				if(row["LN_RWHLD_NO"]!=null)
				{
					model.LN_RWHLD_NO=row["LN_RWHLD_NO"].ToString();
				}
				if(row["LN_HYPO_SQ_NO"]!=null)
				{
					model.LN_HYPO_SQ_NO=row["LN_HYPO_SQ_NO"].ToString();
				}
				if(row["LN_MAN_TOVD_FLG"]!=null)
				{
					model.LN_MAN_TOVD_FLG=row["LN_MAN_TOVD_FLG"].ToString();
				}
				if(row["LN_BAD_LN_FLG"]!=null)
				{
					model.LN_BAD_LN_FLG=row["LN_BAD_LN_FLG"].ToString();
				}
				if(row["LN_SIGNL_LN_INTURN_TABLE"]!=null)
				{
					model.LN_SIGNL_LN_INTURN_TABLE=row["LN_SIGNL_LN_INTURN_TABLE"].ToString();
				}
				if(row["LN_INSTAL_RFN_PLAN"]!=null)
				{
					model.LN_INSTAL_RFN_PLAN=row["LN_INSTAL_RFN_PLAN"].ToString();
				}
				if(row["LN_INSTAL_MULTI_RFN_STY"]!=null)
				{
					model.LN_INSTAL_MULTI_RFN_STY=row["LN_INSTAL_MULTI_RFN_STY"].ToString();
				}
				if(row["LN_PPRD_RFN_AMT"]!=null && row["LN_PPRD_RFN_AMT"].ToString()!="")
				{
					model.LN_PPRD_RFN_AMT=decimal.Parse(row["LN_PPRD_RFN_AMT"].ToString());
				}
				if(row["LN_CRNT_PRD_RTN_AMT"]!=null && row["LN_CRNT_PRD_RTN_AMT"].ToString()!="")
				{
					model.LN_CRNT_PRD_RTN_AMT=decimal.Parse(row["LN_CRNT_PRD_RTN_AMT"].ToString());
				}
				if(row["LN_CRNT_PRD_PAYRBL_PR"]!=null && row["LN_CRNT_PRD_PAYRBL_PR"].ToString()!="")
				{
					model.LN_CRNT_PRD_PAYRBL_PR=decimal.Parse(row["LN_CRNT_PRD_PAYRBL_PR"].ToString());
				}
				if(row["LN_CRNT_PRD_PAYRBL_INT"]!=null && row["LN_CRNT_PRD_PAYRBL_INT"].ToString()!="")
				{
					model.LN_CRNT_PRD_PAYRBL_INT=decimal.Parse(row["LN_CRNT_PRD_PAYRBL_INT"].ToString());
				}
				if(row["LN_NEXT_PRD_ARFN_AMT"]!=null && row["LN_NEXT_PRD_ARFN_AMT"].ToString()!="")
				{
					model.LN_NEXT_PRD_ARFN_AMT=decimal.Parse(row["LN_NEXT_PRD_ARFN_AMT"].ToString());
				}
				if(row["LN_NEXT_PRD_PAYRBL_INT"]!=null && row["LN_NEXT_PRD_PAYRBL_INT"].ToString()!="")
				{
					model.LN_NEXT_PRD_PAYRBL_INT=decimal.Parse(row["LN_NEXT_PRD_PAYRBL_INT"].ToString());
				}
				if(row["LN_WHHD_PR_ACCRUD"]!=null && row["LN_WHHD_PR_ACCRUD"].ToString()!="")
				{
					model.LN_WHHD_PR_ACCRUD=decimal.Parse(row["LN_WHHD_PR_ACCRUD"].ToString());
				}
				if(row["LN_WHHD_INT_ACCRUD"]!=null && row["LN_WHHD_INT_ACCRUD"].ToString()!="")
				{
					model.LN_WHHD_INT_ACCRUD=decimal.Parse(row["LN_WHHD_INT_ACCRUD"].ToString());
				}
				if(row["LN_INTRBL_INT"]!=null && row["LN_INTRBL_INT"].ToString()!="")
				{
					model.LN_INTRBL_INT=decimal.Parse(row["LN_INTRBL_INT"].ToString());
				}
				if(row["LN_DLAY_INT_INT"]!=null && row["LN_DLAY_INT_INT"].ToString()!="")
				{
					model.LN_DLAY_INT_INT=decimal.Parse(row["LN_DLAY_INT_INT"].ToString());
				}
				if(row["LN_OVDLN_INTRBL"]!=null && row["LN_OVDLN_INTRBL"].ToString()!="")
				{
					model.LN_OVDLN_INTRBL=decimal.Parse(row["LN_OVDLN_INTRBL"].ToString());
				}
				if(row["LN_CRNT_OVDLN_INT_INT"]!=null && row["LN_CRNT_OVDLN_INT_INT"].ToString()!="")
				{
					model.LN_CRNT_OVDLN_INT_INT=decimal.Parse(row["LN_CRNT_OVDLN_INT_INT"].ToString());
				}
				if(row["LN_CRNT_OVDLN_INTRBL"]!=null && row["LN_CRNT_OVDLN_INTRBL"].ToString()!="")
				{
					model.LN_CRNT_OVDLN_INTRBL=decimal.Parse(row["LN_CRNT_OVDLN_INTRBL"].ToString());
				}
				if(row["LN_CRNT_OVDLN_LN_INTR"]!=null && row["LN_CRNT_OVDLN_LN_INTR"].ToString()!="")
				{
					model.LN_CRNT_OVDLN_LN_INTR=decimal.Parse(row["LN_CRNT_OVDLN_LN_INTR"].ToString());
				}
				if(row["LN_DEVLU_INT"]!=null && row["LN_DEVLU_INT"].ToString()!="")
				{
					model.LN_DEVLU_INT=decimal.Parse(row["LN_DEVLU_INT"].ToString());
				}
				if(row["LN_APCL_FLG"]!=null)
				{
					model.LN_APCL_FLG=row["LN_APCL_FLG"].ToString();
				}
				if(row["LN_INT_APCL_TOTL_INPLAN"]!=null && row["LN_INT_APCL_TOTL_INPLAN"].ToString()!="")
				{
					model.LN_INT_APCL_TOTL_INPLAN=decimal.Parse(row["LN_INT_APCL_TOTL_INPLAN"].ToString());
				}
				if(row["LN_INTRBL_APCL_AMT_TOTL"]!=null && row["LN_INTRBL_APCL_AMT_TOTL"].ToString()!="")
				{
					model.LN_INTRBL_APCL_AMT_TOTL=decimal.Parse(row["LN_INTRBL_APCL_AMT_TOTL"].ToString());
				}
				if(row["LN_OVDLN_INTRBL_APCL_TOTL"]!=null && row["LN_OVDLN_INTRBL_APCL_TOTL"].ToString()!="")
				{
					model.LN_OVDLN_INTRBL_APCL_TOTL=decimal.Parse(row["LN_OVDLN_INTRBL_APCL_TOTL"].ToString());
				}
				if(row["LN_OVDLN_INT_APCL_TOTL"]!=null && row["LN_OVDLN_INT_APCL_TOTL"].ToString()!="")
				{
					model.LN_OVDLN_INT_APCL_TOTL=decimal.Parse(row["LN_OVDLN_INT_APCL_TOTL"].ToString());
				}
				if(row["LN_LSAC_INT_APCL_TOTL"]!=null && row["LN_LSAC_INT_APCL_TOTL"].ToString()!="")
				{
					model.LN_LSAC_INT_APCL_TOTL=decimal.Parse(row["LN_LSAC_INT_APCL_TOTL"].ToString());
				}
				if(row["LN_PR_APCL_TOTL"]!=null && row["LN_PR_APCL_TOTL"].ToString()!="")
				{
					model.LN_PR_APCL_TOTL=decimal.Parse(row["LN_PR_APCL_TOTL"].ToString());
				}
				if(row["LN_CRNT_YR_INTRBL"]!=null && row["LN_CRNT_YR_INTRBL"].ToString()!="")
				{
					model.LN_CRNT_YR_INTRBL=decimal.Parse(row["LN_CRNT_YR_INTRBL"].ToString());
				}
				if(row["LN_YHEAD_RBL_UCOLL_LN_INT"]!=null && row["LN_YHEAD_RBL_UCOLL_LN_INT"].ToString()!="")
				{
					model.LN_YHEAD_RBL_UCOLL_LN_INT=decimal.Parse(row["LN_YHEAD_RBL_UCOLL_LN_INT"].ToString());
				}
				if(row["LN_ARR_PR"]!=null && row["LN_ARR_PR"].ToString()!="")
				{
					model.LN_ARR_PR=decimal.Parse(row["LN_ARR_PR"].ToString());
				}
				if(row["LN_DLAY_PR_TOTL"]!=null && row["LN_DLAY_PR_TOTL"].ToString()!="")
				{
					model.LN_DLAY_PR_TOTL=decimal.Parse(row["LN_DLAY_PR_TOTL"].ToString());
				}
				if(row["LN_TOVDLN_PR_BAL"]!=null && row["LN_TOVDLN_PR_BAL"].ToString()!="")
				{
					model.LN_TOVDLN_PR_BAL=decimal.Parse(row["LN_TOVDLN_PR_BAL"].ToString());
				}
				if(row["LN_DLAY_LN_DT_N"]!=null && row["LN_DLAY_LN_DT_N"].ToString()!="")
				{
					model.LN_DLAY_LN_DT_N=decimal.Parse(row["LN_DLAY_LN_DT_N"].ToString());
				}
				if(row["LN_TRNLST_OVD_DT_N"]!=null && row["LN_TRNLST_OVD_DT_N"].ToString()!="")
				{
					model.LN_TRNLST_OVD_DT_N=decimal.Parse(row["LN_TRNLST_OVD_DT_N"].ToString());
				}
				if(row["LN_DLAY_LN_RSN"]!=null)
				{
					model.LN_DLAY_LN_RSN=row["LN_DLAY_LN_RSN"].ToString();
				}
				if(row["LN_DLAY_RSK_RTNG"]!=null)
				{
					model.LN_DLAY_RSK_RTNG=row["LN_DLAY_RSK_RTNG"].ToString();
				}
				if(row["LN_FOVDLN_SQ_DT_N"]!=null && row["LN_FOVDLN_SQ_DT_N"].ToString()!="")
				{
					model.LN_FOVDLN_SQ_DT_N=decimal.Parse(row["LN_FOVDLN_SQ_DT_N"].ToString());
				}
				if(row["LN_DLAY_LN_FRN_DT_N"]!=null && row["LN_DLAY_LN_FRN_DT_N"].ToString()!="")
				{
					model.LN_DLAY_LN_FRN_DT_N=decimal.Parse(row["LN_DLAY_LN_FRN_DT_N"].ToString());
				}
				if(row["LN_DLAY_LN_RFN_RSN"]!=null)
				{
					model.LN_DLAY_LN_RFN_RSN=row["LN_DLAY_LN_RFN_RSN"].ToString();
				}
				if(row["LN_DLAY_LN_RFN_AMT"]!=null && row["LN_DLAY_LN_RFN_AMT"].ToString()!="")
				{
					model.LN_DLAY_LN_RFN_AMT=decimal.Parse(row["LN_DLAY_LN_RFN_AMT"].ToString());
				}
				if(row["LN_DERATE_PENALTY_TOTL"]!=null && row["LN_DERATE_PENALTY_TOTL"].ToString()!="")
				{
					model.LN_DERATE_PENALTY_TOTL=decimal.Parse(row["LN_DERATE_PENALTY_TOTL"].ToString());
				}
				if(row["LN_DERATE_ARRAMT_TOTL"]!=null && row["LN_DERATE_ARRAMT_TOTL"].ToString()!="")
				{
					model.LN_DERATE_ARRAMT_TOTL=decimal.Parse(row["LN_DERATE_ARRAMT_TOTL"].ToString());
				}
				if(row["LN_ROP_ROI_EXCS_FLAG"]!=null)
				{
					model.LN_ROP_ROI_EXCS_FLAG=row["LN_ROP_ROI_EXCS_FLAG"].ToString();
				}
				if(row["LN_INCR_DECR_AMT"]!=null && row["LN_INCR_DECR_AMT"].ToString()!="")
				{
					model.LN_INCR_DECR_AMT=decimal.Parse(row["LN_INCR_DECR_AMT"].ToString());
				}
				if(row["LN_EQPROP_INCR_DECR"]!=null && row["LN_EQPROP_INCR_DECR"].ToString()!="")
				{
					model.LN_EQPROP_INCR_DECR=decimal.Parse(row["LN_EQPROP_INCR_DECR"].ToString());
				}
				if(row["LN_INCR_DECR_INIT_PRD_N"]!=null && row["LN_INCR_DECR_INIT_PRD_N"].ToString()!="")
				{
					model.LN_INCR_DECR_INIT_PRD_N=decimal.Parse(row["LN_INCR_DECR_INIT_PRD_N"].ToString());
				}
				if(row["LN_INCR_DECR_INTER_PRD_N"]!=null && row["LN_INCR_DECR_INTER_PRD_N"].ToString()!="")
				{
					model.LN_INCR_DECR_INTER_PRD_N=decimal.Parse(row["LN_INCR_DECR_INTER_PRD_N"].ToString());
				}
				if(row["LN_CLOSE_FLG"]!=null)
				{
					model.LN_CLOSE_FLG=row["LN_CLOSE_FLG"].ToString();
				}
				if(row["LN_SYNLN_FLG"]!=null)
				{
					model.LN_SYNLN_FLG=row["LN_SYNLN_FLG"].ToString();
				}
				if(row["LN_RCPT_NO"]!=null)
				{
					model.LN_RCPT_NO=row["LN_RCPT_NO"].ToString();
				}
				if(row["LN_RMRK"]!=null)
				{
					model.LN_RMRK=row["LN_RMRK"].ToString();
				}
				if(row["LN_FS_ACCT"]!=null)
				{
					model.LN_FS_ACCT=row["LN_FS_ACCT"].ToString();
				}
				if(row["LN_CUST_NAME"]!=null)
				{
					model.LN_CUST_NAME=row["LN_CUST_NAME"].ToString();
				}
				if(row["LN_CERT_TYP"]!=null)
				{
					model.LN_CERT_TYP=row["LN_CERT_TYP"].ToString();
				}
				if(row["LN_CERT_ID"]!=null)
				{
					model.LN_CERT_ID=row["LN_CERT_ID"].ToString();
				}
				if(row["LN_CUSTD_RCPT_REF_NO"]!=null)
				{
					model.LN_CUSTD_RCPT_REF_NO=row["LN_CUSTD_RCPT_REF_NO"].ToString();
				}
				if(row["LN_DTL_PRT_FLAG"]!=null)
				{
					model.LN_DTL_PRT_FLAG=row["LN_DTL_PRT_FLAG"].ToString();
				}
				if(row["LN_DTL_PRT_PG_N"]!=null && row["LN_DTL_PRT_PG_N"].ToString()!="")
				{
					model.LN_DTL_PRT_PG_N=decimal.Parse(row["LN_DTL_PRT_PG_N"].ToString());
				}
				if(row["LN_DTL_PRT_KEYS"]!=null)
				{
					model.LN_DTL_PRT_KEYS=row["LN_DTL_PRT_KEYS"].ToString();
				}
				if(row["LN_LTST_RISK_TYP_DT_N"]!=null && row["LN_LTST_RISK_TYP_DT_N"].ToString()!="")
				{
					model.LN_LTST_RISK_TYP_DT_N=decimal.Parse(row["LN_LTST_RISK_TYP_DT_N"].ToString());
				}
				if(row["LN_LTST_PR_MV_DT_N"]!=null && row["LN_LTST_PR_MV_DT_N"].ToString()!="")
				{
					model.LN_LTST_PR_MV_DT_N=decimal.Parse(row["LN_LTST_PR_MV_DT_N"].ToString());
				}
				if(row["LN_LTST_PR_MV_TM_N"]!=null && row["LN_LTST_PR_MV_TM_N"].ToString()!="")
				{
					model.LN_LTST_PR_MV_TM_N=decimal.Parse(row["LN_LTST_PR_MV_TM_N"].ToString());
				}
				if(row["LN_ARR_AMT"]!=null && row["LN_ARR_AMT"].ToString()!="")
				{
					model.LN_ARR_AMT=decimal.Parse(row["LN_ARR_AMT"].ToString());
				}
				if(row["LN_PENALTY"]!=null && row["LN_PENALTY"].ToString()!="")
				{
					model.LN_PENALTY=decimal.Parse(row["LN_PENALTY"].ToString());
				}
				if(row["LN_PENL_STRT_DT_N"]!=null && row["LN_PENL_STRT_DT_N"].ToString()!="")
				{
					model.LN_PENL_STRT_DT_N=decimal.Parse(row["LN_PENL_STRT_DT_N"].ToString());
				}
				if(row["LN_SVC_BAL"]!=null && row["LN_SVC_BAL"].ToString()!="")
				{
					model.LN_SVC_BAL=decimal.Parse(row["LN_SVC_BAL"].ToString());
				}
				if(row["LN_RCV_INT_TOTL"]!=null && row["LN_RCV_INT_TOTL"].ToString()!="")
				{
					model.LN_RCV_INT_TOTL=decimal.Parse(row["LN_RCV_INT_TOTL"].ToString());
				}
				if(row["LN_ACCUM_COLI"]!=null && row["LN_ACCUM_COLI"].ToString()!="")
				{
					model.LN_ACCUM_COLI=decimal.Parse(row["LN_ACCUM_COLI"].ToString());
				}
				if(row["LN_ACCUM_RECV_PNL"]!=null && row["LN_ACCUM_RECV_PNL"].ToString()!="")
				{
					model.LN_ACCUM_RECV_PNL=decimal.Parse(row["LN_ACCUM_RECV_PNL"].ToString());
				}
				if(row["LN_ACCUM_RECV_SVC"]!=null && row["LN_ACCUM_RECV_SVC"].ToString()!="")
				{
					model.LN_ACCUM_RECV_SVC=decimal.Parse(row["LN_ACCUM_RECV_SVC"].ToString());
				}
				if(row["LN_ADVPMT_TOTL"]!=null && row["LN_ADVPMT_TOTL"].ToString()!="")
				{
					model.LN_ADVPMT_TOTL=decimal.Parse(row["LN_ADVPMT_TOTL"].ToString());
				}
				if(row["LN_YHEAD_LN_BAL"]!=null && row["LN_YHEAD_LN_BAL"].ToString()!="")
				{
					model.LN_YHEAD_LN_BAL=decimal.Parse(row["LN_YHEAD_LN_BAL"].ToString());
				}
				if(row["LN_CRNT_YR_LN_ACCUM"]!=null && row["LN_CRNT_YR_LN_ACCUM"].ToString()!="")
				{
					model.LN_CRNT_YR_LN_ACCUM=decimal.Parse(row["LN_CRNT_YR_LN_ACCUM"].ToString());
				}
				if(row["LN_CRNT_YR_REV_ACCUM"]!=null && row["LN_CRNT_YR_REV_ACCUM"].ToString()!="")
				{
					model.LN_CRNT_YR_REV_ACCUM=decimal.Parse(row["LN_CRNT_YR_REV_ACCUM"].ToString());
				}
				if(row["LN_CRNT_YR_COLLED_INT"]!=null && row["LN_CRNT_YR_COLLED_INT"].ToString()!="")
				{
					model.LN_CRNT_YR_COLLED_INT=decimal.Parse(row["LN_CRNT_YR_COLLED_INT"].ToString());
				}
				if(row["LN_EXCE_FLG"]!=null)
				{
					model.LN_EXCE_FLG=row["LN_EXCE_FLG"].ToString();
				}
				if(row["LN_FS_FLG"]!=null)
				{
					model.LN_FS_FLG=row["LN_FS_FLG"].ToString();
				}
				if(row["LN_HYP_FLG"]!=null)
				{
					model.LN_HYP_FLG=row["LN_HYP_FLG"].ToString();
				}
				if(row["LN_NACCT_STS"]!=null)
				{
					model.LN_NACCT_STS=row["LN_NACCT_STS"].ToString();
				}
				if(row["LN_ACCP_TYP"]!=null)
				{
					model.LN_ACCP_TYP=row["LN_ACCP_TYP"].ToString();
				}
				if(row["LN_GUAR_ACCP_EXPT_NO"]!=null)
				{
					model.LN_GUAR_ACCP_EXPT_NO=row["LN_GUAR_ACCP_EXPT_NO"].ToString();
				}
				if(row["LN_NOR_BACK_FLG"]!=null)
				{
					model.LN_NOR_BACK_FLG=row["LN_NOR_BACK_FLG"].ToString();
				}
				if(row["LN_HUNT_DUE_DT_N"]!=null && row["LN_HUNT_DUE_DT_N"].ToString()!="")
				{
					model.LN_HUNT_DUE_DT_N=decimal.Parse(row["LN_HUNT_DUE_DT_N"].ToString());
				}
				if(row["LN_LOC_CITY_FLG"]!=null)
				{
					model.LN_LOC_CITY_FLG=row["LN_LOC_CITY_FLG"].ToString();
				}
				if(row["LN_INT_RCPT_MAIL"]!=null)
				{
					model.LN_INT_RCPT_MAIL=row["LN_INT_RCPT_MAIL"].ToString();
				}
				if(row["LN_DLAY_ADV"]!=null)
				{
					model.LN_DLAY_ADV=row["LN_DLAY_ADV"].ToString();
				}
				if(row["LN_RFN_RCPT_MAIL"]!=null)
				{
					model.LN_RFN_RCPT_MAIL=row["LN_RFN_RCPT_MAIL"].ToString();
				}
				if(row["LN_MBSTMT_CYCL"]!=null)
				{
					model.LN_MBSTMT_CYCL=row["LN_MBSTMT_CYCL"].ToString();
				}
				if(row["LN_MBSTMT_DT_N"]!=null && row["LN_MBSTMT_DT_N"].ToString()!="")
				{
					model.LN_MBSTMT_DT_N=decimal.Parse(row["LN_MBSTMT_DT_N"].ToString());
				}
				if(row["LN_CACL_INTR_CYCL"]!=null)
				{
					model.LN_CACL_INTR_CYCL=row["LN_CACL_INTR_CYCL"].ToString();
				}
				if(row["LN_CACL_INTR_DT"]!=null)
				{
					model.LN_CACL_INTR_DT=row["LN_CACL_INTR_DT"].ToString();
				}
				if(row["LN_CACL_INTR_FLG"]!=null)
				{
					model.LN_CACL_INTR_FLG=row["LN_CACL_INTR_FLG"].ToString();
				}
				if(row["LN_FSTM_RFN_DT_N"]!=null && row["LN_FSTM_RFN_DT_N"].ToString()!="")
				{
					model.LN_FSTM_RFN_DT_N=decimal.Parse(row["LN_FSTM_RFN_DT_N"].ToString());
				}
				if(row["LN_FSTM_INTP_DT_N"]!=null && row["LN_FSTM_INTP_DT_N"].ToString()!="")
				{
					model.LN_FSTM_INTP_DT_N=decimal.Parse(row["LN_FSTM_INTP_DT_N"].ToString());
				}
				if(row["LN_NEXT_PR_RFN_DT_N"]!=null && row["LN_NEXT_PR_RFN_DT_N"].ToString()!="")
				{
					model.LN_NEXT_PR_RFN_DT_N=decimal.Parse(row["LN_NEXT_PR_RFN_DT_N"].ToString());
				}
				if(row["LN_NEXT_INT_RFN_DT_N"]!=null && row["LN_NEXT_INT_RFN_DT_N"].ToString()!="")
				{
					model.LN_NEXT_INT_RFN_DT_N=decimal.Parse(row["LN_NEXT_INT_RFN_DT_N"].ToString());
				}
				if(row["LN_OLD_LN_ACCT_TRNI"]!=null)
				{
					model.LN_OLD_LN_ACCT_TRNI=row["LN_OLD_LN_ACCT_TRNI"].ToString();
				}
				if(row["LN_NWLN_ACCT_NO_TRNO"]!=null)
				{
					model.LN_NWLN_ACCT_NO_TRNO=row["LN_NWLN_ACCT_NO_TRNO"].ToString();
				}
				if(row["LN_AALFD_SUCS"]!=null)
				{
					model.LN_AALFD_SUCS=row["LN_AALFD_SUCS"].ToString();
				}
				if(row["LN_FLST_TLR_NO"]!=null)
				{
					model.LN_FLST_TLR_NO=row["LN_FLST_TLR_NO"].ToString();
				}
				if(row["LN_FLST_APRV_PIC_NO"]!=null)
				{
					model.LN_FLST_APRV_PIC_NO=row["LN_FLST_APRV_PIC_NO"].ToString();
				}
				if(row["LN_FLST_DT_N"]!=null && row["LN_FLST_DT_N"].ToString()!="")
				{
					model.LN_FLST_DT_N=decimal.Parse(row["LN_FLST_DT_N"].ToString());
				}
				if(row["LN_LTST_MNTN_OPR_NO"]!=null)
				{
					model.LN_LTST_MNTN_OPR_NO=row["LN_LTST_MNTN_OPR_NO"].ToString();
				}
				if(row["LN_LTST_APRV_PIC_NO"]!=null)
				{
					model.LN_LTST_APRV_PIC_NO=row["LN_LTST_APRV_PIC_NO"].ToString();
				}
				if(row["LN_SPV"]!=null)
				{
					model.LN_SPV=row["LN_SPV"].ToString();
				}
				if(row["LN_LTST_MNTN_DT_N"]!=null && row["LN_LTST_MNTN_DT_N"].ToString()!="")
				{
					model.LN_LTST_MNTN_DT_N=decimal.Parse(row["LN_LTST_MNTN_DT_N"].ToString());
				}
				if(row["LN_CRNT_DAY_FST_TX_SQ_NO"]!=null)
				{
					model.LN_CRNT_DAY_FST_TX_SQ_NO=row["LN_CRNT_DAY_FST_TX_SQ_NO"].ToString();
				}
				if(row["LN_CRNT_DAY_LST_TX_SQ_NO"]!=null)
				{
					model.LN_CRNT_DAY_LST_TX_SQ_NO=row["LN_CRNT_DAY_LST_TX_SQ_NO"].ToString();
				}
				if(row["LN_ROP_INTC_STY_FLG"]!=null)
				{
					model.LN_ROP_INTC_STY_FLG=row["LN_ROP_INTC_STY_FLG"].ToString();
				}
				if(row["LN_INT_INTC_STY_FLG"]!=null)
				{
					model.LN_INT_INTC_STY_FLG=row["LN_INT_INTC_STY_FLG"].ToString();
				}
				if(row["LN_ADV_RFN_TOT_NUM_N"]!=null && row["LN_ADV_RFN_TOT_NUM_N"].ToString()!="")
				{
					model.LN_ADV_RFN_TOT_NUM_N=decimal.Parse(row["LN_ADV_RFN_TOT_NUM_N"].ToString());
				}
				if(row["LN_CURR_CYCL_FAC_YR_N"]!=null && row["LN_CURR_CYCL_FAC_YR_N"].ToString()!="")
				{
					model.LN_CURR_CYCL_FAC_YR_N=decimal.Parse(row["LN_CURR_CYCL_FAC_YR_N"].ToString());
				}
				if(row["LN_CURR_CYCL_ADV_NUM_N"]!=null && row["LN_CURR_CYCL_ADV_NUM_N"].ToString()!="")
				{
					model.LN_CURR_CYCL_ADV_NUM_N=decimal.Parse(row["LN_CURR_CYCL_ADV_NUM_N"].ToString());
				}
				if(row["LN_PSBK_PRT_NO"]!=null)
				{
					model.LN_PSBK_PRT_NO=row["LN_PSBK_PRT_NO"].ToString();
				}
				if(row["LN_INTR_ADJ_DAY"]!=null)
				{
					model.LN_INTR_ADJ_DAY=row["LN_INTR_ADJ_DAY"].ToString();
				}
				if(row["LN_AAUTO_ROP"]!=null)
				{
					model.LN_AAUTO_ROP=row["LN_AAUTO_ROP"].ToString();
				}
				if(row["LN_ROP_DURAN_CUTDT_N"]!=null && row["LN_ROP_DURAN_CUTDT_N"].ToString()!="")
				{
					model.LN_ROP_DURAN_CUTDT_N=decimal.Parse(row["LN_ROP_DURAN_CUTDT_N"].ToString());
				}
				if(row["LN_APPL_DUE_DT_N"]!=null && row["LN_APPL_DUE_DT_N"].ToString()!="")
				{
					model.LN_APPL_DUE_DT_N=decimal.Parse(row["LN_APPL_DUE_DT_N"].ToString());
				}
				if(row["LN_CNL_NO"]!=null)
				{
					model.LN_CNL_NO=row["LN_CNL_NO"].ToString();
				}
				if(row["LN_BELONG_INSTN_COD"]!=null)
				{
					model.LN_BELONG_INSTN_COD=row["LN_BELONG_INSTN_COD"].ToString();
				}
				if(row["LN_ASS_OPUN_NO"]!=null)
				{
					model.LN_ASS_OPUN_NO=row["LN_ASS_OPUN_NO"].ToString();
				}
				if(row["LN_LTST_MNTN_OPUN_NO"]!=null)
				{
					model.LN_LTST_MNTN_OPUN_NO=row["LN_LTST_MNTN_OPUN_NO"].ToString();
				}
				if(row["LN_TRS_OLD_SYS_FLG"]!=null)
				{
					model.LN_TRS_OLD_SYS_FLG=row["LN_TRS_OLD_SYS_FLG"].ToString();
				}
				if(row["LN_FLST_OPUN_NO"]!=null)
				{
					model.LN_FLST_OPUN_NO=row["LN_FLST_OPUN_NO"].ToString();
				}
				if(row["LN_DB_PART_ID"]!=null)
				{
					model.LN_DB_PART_ID=row["LN_DB_PART_ID"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ETLDT,LN_LN_ACCT_NO,LNLNS_DB_TIMESTAMP,LN_FINL_VRSN_N,LN_DB_MNTN_NO_N,LN_CUST_NO,LN_CRLMT_NO,LN_PDP_CODE,LN_BUSN_TYP,LN_ACCT_STS,LN_VIP_ACCT_FLG,LN_CUST_TYP,LN_CURR_COD,LN_CURR_IDEN,LN_FINBUSN,LN_CURR_COD_AUTHOR,LN_LN_TYP,LN_HYPO_TYP,LN_NWLN_AMT_HYPO_AMT,LN_TOTL_LN_AMT_HYPO_AMT,LN_LN_BAL,LN_FRST_ALFD_DT_N,LN_DUE_DT_N,LN_CLSD_DT_N,LN_RFN_STY,LN_ROP_CYCL_MN_TOTL_N,LN_ROP_CYCL_UNIT,LN_COLI_CYCL_TOTL_MN_N,LN_COLI_CYCL_UNIT,LN_PPRD_INTP_DAY_N,LN_ROP_DAY_N,LN_TOTL_PRD_N,LN_ARFN_SCHD_PR_N,LN_ARFN_SCHD_INT_N,LN_TNRNO_N,LN_LN_MTHS_N,LN_PR_CAC_DT_N,LN_INTC_UP_DT_N,LN_INTC_UP_DT_ODD_DAYS_N,LN_LAST_INTC_UP_DT_N,LN_INT_INTC_UP_DT_N,LN_PMN_INTC_COD,LN_CLSD_INTC_TYP,LN_FRST_INTC_INTR,LN_FRST_DELAY_INTR,LN_INTR_ADJ_STY,LN_INTR_ADJ_CYCL,LN_INTR_ADJ_STRT_DT_N,LN_INTR_EFF_DT_N,LN_INTR_ACOR_STY,LN_INTR_TYP,LN_INTR_NEGO_SYMB,LN_INTR_NEGO_RATE,LN_DLAY_INTR_ACOR_STY,LN_DLAY_INTR_TYP,LN_DLAY_INTR_PLMN_SYMB,LN_DLAY_INTR_PLMN_COD,LN_LN_FUND_RSUR,LN_LN_PURP,LN_LN_STY,LN_USE_BOOK_FLG,LN_MULTI_RFN_FLG,LN_RCT_EXTN_DT_N,LN_EXTN_CTRT_NO,LN_EXTN_TM_N,LN_EXT_SEQ_NO_N,LN_BUSN_TYP_CHG_DT_N,LN_BUSN_TYP_NEW,LN_BUSN_TYP_ORG,LN_CHG_RFN_STY_DT_N,LN_CHG_RFN_STY,LN_INT_STRV_DT_N,LN_PR_INTS_FLAG,LN_INT_INTS_FLAG,LN_INTS_EFF_DT_N,LN_HALT_INTC_SYMB,LN_HALT_STRT_DT_N,LN_HALT_CUT_DT_N,LN_COLL_SVC_STY,LN_SVC_RTO,LN_TRTO,LN_ROP_DURAN_N,LN_DURAN_INTC_FLG,LN_PR_TOLE_DAYS_N,LN_INT_DURAN_DAYS_N,LN_PAY_SEQ_FLG,LN_AUTO_DDUT_PR_FLG,LN_AUTO_DEDU_INT_FLG,LN_DLY_AUTO_PAY_FLG,LN_AUTO_DEDU_DEP_ACCT_NO_1,LN_AUTO_DEDU_DEP_ACCT_NO_2,LN_AUTO_DEDU_DEP_ACCT_NO_3,LN_AUTO_DEDU_ACCT_TYP_1,LN_AUTO_DEDU_ACCT_TYP_2,LN_AUTO_DEDU_ACCT_TYP_3,LN_LN_TO_DEP_FLG,LN_DEP_ACCT_NO,LN_PAY_INT_ACCT_NO,LN_ZHIBIAO_NO,LN_FAC_COD,LN_DLF_COD,LN_LNB_COD,LN_FILLER1_COD,LN_FILLER2_COD,LN_INT_DIS_END_DT_N,LN_INT_DIS_RATE_N,LN_FUND_TO_AUOR_FLG,LN_FUND_ACCT_NO,LN_AUOR_DEP_ACCT_NO,LN_GUAR_MARGIN_ACCT_NO,LN_TD_PSBK_NO_N,LN_TD_PSBK_SEQ_NO_N,LN_FRZ_DT_N,LN_RWHLD_NO,LN_HYPO_SQ_NO,LN_MAN_TOVD_FLG,LN_BAD_LN_FLG,LN_SIGNL_LN_INTURN_TABLE,LN_INSTAL_RFN_PLAN,LN_INSTAL_MULTI_RFN_STY,LN_PPRD_RFN_AMT,LN_CRNT_PRD_RTN_AMT,LN_CRNT_PRD_PAYRBL_PR,LN_CRNT_PRD_PAYRBL_INT,LN_NEXT_PRD_ARFN_AMT,LN_NEXT_PRD_PAYRBL_INT,LN_WHHD_PR_ACCRUD,LN_WHHD_INT_ACCRUD,LN_INTRBL_INT,LN_DLAY_INT_INT,LN_OVDLN_INTRBL,LN_CRNT_OVDLN_INT_INT,LN_CRNT_OVDLN_INTRBL,LN_CRNT_OVDLN_LN_INTR,LN_DEVLU_INT,LN_APCL_FLG,LN_INT_APCL_TOTL_INPLAN,LN_INTRBL_APCL_AMT_TOTL,LN_OVDLN_INTRBL_APCL_TOTL,LN_OVDLN_INT_APCL_TOTL,LN_LSAC_INT_APCL_TOTL,LN_PR_APCL_TOTL,LN_CRNT_YR_INTRBL,LN_YHEAD_RBL_UCOLL_LN_INT,LN_ARR_PR,LN_DLAY_PR_TOTL,LN_TOVDLN_PR_BAL,LN_DLAY_LN_DT_N,LN_TRNLST_OVD_DT_N,LN_DLAY_LN_RSN,LN_DLAY_RSK_RTNG,LN_FOVDLN_SQ_DT_N,LN_DLAY_LN_FRN_DT_N,LN_DLAY_LN_RFN_RSN,LN_DLAY_LN_RFN_AMT,LN_DERATE_PENALTY_TOTL,LN_DERATE_ARRAMT_TOTL,LN_ROP_ROI_EXCS_FLAG,LN_INCR_DECR_AMT,LN_EQPROP_INCR_DECR,LN_INCR_DECR_INIT_PRD_N,LN_INCR_DECR_INTER_PRD_N,LN_CLOSE_FLG,LN_SYNLN_FLG,LN_RCPT_NO,LN_RMRK,LN_FS_ACCT,LN_CUST_NAME,LN_CERT_TYP,LN_CERT_ID,LN_CUSTD_RCPT_REF_NO,LN_DTL_PRT_FLAG,LN_DTL_PRT_PG_N,LN_DTL_PRT_KEYS,LN_LTST_RISK_TYP_DT_N,LN_LTST_PR_MV_DT_N,LN_LTST_PR_MV_TM_N,LN_ARR_AMT,LN_PENALTY,LN_PENL_STRT_DT_N,LN_SVC_BAL,LN_RCV_INT_TOTL,LN_ACCUM_COLI,LN_ACCUM_RECV_PNL,LN_ACCUM_RECV_SVC,LN_ADVPMT_TOTL,LN_YHEAD_LN_BAL,LN_CRNT_YR_LN_ACCUM,LN_CRNT_YR_REV_ACCUM,LN_CRNT_YR_COLLED_INT,LN_EXCE_FLG,LN_FS_FLG,LN_HYP_FLG,LN_NACCT_STS,LN_ACCP_TYP,LN_GUAR_ACCP_EXPT_NO,LN_NOR_BACK_FLG,LN_HUNT_DUE_DT_N,LN_LOC_CITY_FLG,LN_INT_RCPT_MAIL,LN_DLAY_ADV,LN_RFN_RCPT_MAIL,LN_MBSTMT_CYCL,LN_MBSTMT_DT_N,LN_CACL_INTR_CYCL,LN_CACL_INTR_DT,LN_CACL_INTR_FLG,LN_FSTM_RFN_DT_N,LN_FSTM_INTP_DT_N,LN_NEXT_PR_RFN_DT_N,LN_NEXT_INT_RFN_DT_N,LN_OLD_LN_ACCT_TRNI,LN_NWLN_ACCT_NO_TRNO,LN_AALFD_SUCS,LN_FLST_TLR_NO,LN_FLST_APRV_PIC_NO,LN_FLST_DT_N,LN_LTST_MNTN_OPR_NO,LN_LTST_APRV_PIC_NO,LN_SPV,LN_LTST_MNTN_DT_N,LN_CRNT_DAY_FST_TX_SQ_NO,LN_CRNT_DAY_LST_TX_SQ_NO,LN_ROP_INTC_STY_FLG,LN_INT_INTC_STY_FLG,LN_ADV_RFN_TOT_NUM_N,LN_CURR_CYCL_FAC_YR_N,LN_CURR_CYCL_ADV_NUM_N,LN_PSBK_PRT_NO,LN_INTR_ADJ_DAY,LN_AAUTO_ROP,LN_ROP_DURAN_CUTDT_N,LN_APPL_DUE_DT_N,LN_CNL_NO,LN_BELONG_INSTN_COD,LN_ASS_OPUN_NO,LN_LTST_MNTN_OPUN_NO,LN_TRS_OLD_SYS_FLG,LN_FLST_OPUN_NO,LN_DB_PART_ID ");
			strSql.Append(" FROM CBOD_LNLNSLNS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM jsrun.CBOD_LNLNSLNS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperOleDb.GetSingle(strSql.ToString());// DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby +" desc ");
			}
			else
			{
				//strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from jsrun.CBOD_LNLNSLNS T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "CBOD_LNLNSLNS";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

