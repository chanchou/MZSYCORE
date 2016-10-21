using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//Please add references
namespace MZSYCORE.DAL
{
	/// <summary>
	/// 数据访问类:DAL_CBOD_TDACNACN
	/// </summary>
	public partial class DAL_CBOD_TDACNACN
	{
		public DAL_CBOD_TDACNACN()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MZSYCORE.Model.Model_CBOD_TDACNACN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CBOD_TDACNACN(");
			strSql.Append("ETLDT,TDACN_LL,TD_TD_ACCT_NO,TDACN_DB_TIMESTAMP,TD_VRSN_NO_N,TD_CURR_COD,TD_VIP_ACCT_FLG,TD_BACK,TD_TDP_INTR,TD_DEP_PRD_N,TD_DEP_DRW_CYCL_N,TD_DUE_DT,TD_TD_RMRK,TD_FRZ_STS,TD_FRZ_DT,TD_FRZ_TM,TD_FLTR_FVR,TD_DL_FLG,TD_DL_DT,TD_DL_TM,TD_MBSTMT_ADDR,TD_CLSD_DT,TD_OPAC_TLR_NO,TD_OPAC_AMT,TD_OPAC_INTS_DT,TD_OPAC_DT,TD_CUST_NO,TD_ACCUM_DEP_AMT,TD_ACCUM_PDT,TD_ACCUM_DRW_AMT,TD_PPRD_DRW_AMT,TD_QPSWD,TD_ACTU_AMT,TD_AS_EXC_FLAG,TD_DW_RANG,TD_ADV_DRW_DT,TD_ADV_DRW_DSGN,TD_CACCT_TLR_NO,TD_NACCT_NO,TD_OACCT_NO,TD_PRDS_DEP_PRD1_N,TD_PRDS_DEP_PRD2_N,TD_ACCT_TYP,TD_CVRT_FXR,TD_DRW_TYP,TD_LHYPO_FLG,TD_CYCL_DEP_AMT,TD_TRNO_ACC_NO,TD_TRND_TDP_INT,TD_TRND_DUEDT,TD_TRND_AMT,TD_TRND_INTC_DT,TD_TRNT_TM_N,TD_MNG_DEP_KND,TD_ACCT_STS,TD_PSBK_NO_N,TD_LST_TX_DT,TD_DEP_TYP,TD_OPAC_INSTN_NO,TD_CACCT_INSTN_NO,TD_ACCT_CHAR,TD_TDP_PSBK_FLG,TD_PSWD_STS,TD_PSWD_DL_DT,TD_SEAL_STS,TD_SEAL_DL_DT,TD_MNG_FLG,TD_MNG_ACC_NO,TD_CLSD_INT,TD_PART_DRW_FLG,TD_INT_AMT,TD_PRT_FLG,TD_CUST_NAME,TD_ACC1_NO,TD_DOC_TYP,TD_CURR_CHAR,TD_PSBK_SQ_NO_N,TD_ADV_DRW_AMT,TD_CURR_IDEN,TD_PSWD_DL_TM,TD_SEAL_DL_TM,TD_WK_DATE,TD_TX_DT,TD_TX_TM,TD_CERT_NUM,TD_PRT_NUM,TD_TRT_VAL,TD_INT_TAX_RPT_FLG,TD_TAX_FLG,TD_CONNTR_NO,TD_LARGE_DEP_FLG,TD_FLTR_TYP,TD_FLTR_FVR_SIGN,TD_INPUT_INTR_FLG,TD_BELONG_TO_FLG,TD_TRNO_ACC_BRCH_NO,TD_ORG_OPAC_AMT,TD_ADV_NO_N,TD_ACCUM_SA_PDT,TD_TDP_PSBK_PRT_NO,TD_PDP_CODE,TD_PDP_CODE_C1,TD_PDP_CODE_C2,TD_INTR_COD,TD_DP_RANG,TD_SLCRD_NO,TD_CERT_PRT_NO,TD_PSWD_RULE,TD_PSWD_VRSN_NO1,TD_PSWD_ERR_TIMES_N,TD_PART_FRZ_AMT,TD_CERT_TYP,TD_CERT_ID,TD_BELONG_INSTN_COD,TD_PEND_INT,TD_PEND_INTTAX,TD_JUR_FRZ_STS,TD_JUR_PART_FRZ_AMT,TD_JUR_FRZ_DT,TD_JUR_FRZ_TM,TD_CLSD_TAXINT,TD_CLSD_INTTAX,TD_ASES_INSTN_COD,TD_DB_PART_ID)");
			strSql.Append(" values (");
			strSql.Append("@ETLDT,@TDACN_LL,@TD_TD_ACCT_NO,@TDACN_DB_TIMESTAMP,@TD_VRSN_NO_N,@TD_CURR_COD,@TD_VIP_ACCT_FLG,@TD_BACK,@TD_TDP_INTR,@TD_DEP_PRD_N,@TD_DEP_DRW_CYCL_N,@TD_DUE_DT,@TD_TD_RMRK,@TD_FRZ_STS,@TD_FRZ_DT,@TD_FRZ_TM,@TD_FLTR_FVR,@TD_DL_FLG,@TD_DL_DT,@TD_DL_TM,@TD_MBSTMT_ADDR,@TD_CLSD_DT,@TD_OPAC_TLR_NO,@TD_OPAC_AMT,@TD_OPAC_INTS_DT,@TD_OPAC_DT,@TD_CUST_NO,@TD_ACCUM_DEP_AMT,@TD_ACCUM_PDT,@TD_ACCUM_DRW_AMT,@TD_PPRD_DRW_AMT,@TD_QPSWD,@TD_ACTU_AMT,@TD_AS_EXC_FLAG,@TD_DW_RANG,@TD_ADV_DRW_DT,@TD_ADV_DRW_DSGN,@TD_CACCT_TLR_NO,@TD_NACCT_NO,@TD_OACCT_NO,@TD_PRDS_DEP_PRD1_N,@TD_PRDS_DEP_PRD2_N,@TD_ACCT_TYP,@TD_CVRT_FXR,@TD_DRW_TYP,@TD_LHYPO_FLG,@TD_CYCL_DEP_AMT,@TD_TRNO_ACC_NO,@TD_TRND_TDP_INT,@TD_TRND_DUEDT,@TD_TRND_AMT,@TD_TRND_INTC_DT,@TD_TRNT_TM_N,@TD_MNG_DEP_KND,@TD_ACCT_STS,@TD_PSBK_NO_N,@TD_LST_TX_DT,@TD_DEP_TYP,@TD_OPAC_INSTN_NO,@TD_CACCT_INSTN_NO,@TD_ACCT_CHAR,@TD_TDP_PSBK_FLG,@TD_PSWD_STS,@TD_PSWD_DL_DT,@TD_SEAL_STS,@TD_SEAL_DL_DT,@TD_MNG_FLG,@TD_MNG_ACC_NO,@TD_CLSD_INT,@TD_PART_DRW_FLG,@TD_INT_AMT,@TD_PRT_FLG,@TD_CUST_NAME,@TD_ACC1_NO,@TD_DOC_TYP,@TD_CURR_CHAR,@TD_PSBK_SQ_NO_N,@TD_ADV_DRW_AMT,@TD_CURR_IDEN,@TD_PSWD_DL_TM,@TD_SEAL_DL_TM,@TD_WK_DATE,@TD_TX_DT,@TD_TX_TM,@TD_CERT_NUM,@TD_PRT_NUM,@TD_TRT_VAL,@TD_INT_TAX_RPT_FLG,@TD_TAX_FLG,@TD_CONNTR_NO,@TD_LARGE_DEP_FLG,@TD_FLTR_TYP,@TD_FLTR_FVR_SIGN,@TD_INPUT_INTR_FLG,@TD_BELONG_TO_FLG,@TD_TRNO_ACC_BRCH_NO,@TD_ORG_OPAC_AMT,@TD_ADV_NO_N,@TD_ACCUM_SA_PDT,@TD_TDP_PSBK_PRT_NO,@TD_PDP_CODE,@TD_PDP_CODE_C1,@TD_PDP_CODE_C2,@TD_INTR_COD,@TD_DP_RANG,@TD_SLCRD_NO,@TD_CERT_PRT_NO,@TD_PSWD_RULE,@TD_PSWD_VRSN_NO1,@TD_PSWD_ERR_TIMES_N,@TD_PART_FRZ_AMT,@TD_CERT_TYP,@TD_CERT_ID,@TD_BELONG_INSTN_COD,@TD_PEND_INT,@TD_PEND_INTTAX,@TD_JUR_FRZ_STS,@TD_JUR_PART_FRZ_AMT,@TD_JUR_FRZ_DT,@TD_JUR_FRZ_TM,@TD_CLSD_TAXINT,@TD_CLSD_INTTAX,@TD_ASES_INSTN_COD,@TD_DB_PART_ID)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@TDACN_LL", OleDbType.Decimal),
					new OleDbParameter("@TD_TD_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TDACN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@TD_VRSN_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@TD_VIP_ACCT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_BACK", OleDbType.VarChar,9),
					new OleDbParameter("@TD_TDP_INTR", OleDbType.Decimal),
					new OleDbParameter("@TD_DEP_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@TD_DEP_DRW_CYCL_N", OleDbType.Decimal),
					new OleDbParameter("@TD_DUE_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TD_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@TD_FRZ_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_FRZ_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_FRZ_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_FLTR_FVR", OleDbType.Decimal),
					new OleDbParameter("@TD_DL_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_DL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_DL_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_MBSTMT_ADDR", OleDbType.VarChar,3),
					new OleDbParameter("@TD_CLSD_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_OPAC_TLR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@TD_OPAC_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_OPAC_INTS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_OPAC_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_CUST_NO", OleDbType.VarChar,20),
					new OleDbParameter("@TD_ACCUM_DEP_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCUM_PDT", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCUM_DRW_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_PPRD_DRW_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_QPSWD", OleDbType.VarChar,6),
					new OleDbParameter("@TD_ACTU_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_AS_EXC_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_DW_RANG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_ADV_DRW_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_ADV_DRW_DSGN", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CACCT_TLR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@TD_NACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_OACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_PRDS_DEP_PRD1_N", OleDbType.Decimal),
					new OleDbParameter("@TD_PRDS_DEP_PRD2_N", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCT_TYP", OleDbType.VarChar,3),
					new OleDbParameter("@TD_CVRT_FXR", OleDbType.Decimal),
					new OleDbParameter("@TD_DRW_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@TD_LHYPO_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CYCL_DEP_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_TRNO_ACC_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_TRND_TDP_INT", OleDbType.Decimal),
					new OleDbParameter("@TD_TRND_DUEDT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TRND_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_TRND_INTC_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TRNT_TM_N", OleDbType.Decimal),
					new OleDbParameter("@TD_MNG_DEP_KND", OleDbType.VarChar,2),
					new OleDbParameter("@TD_ACCT_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSBK_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_LST_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_DEP_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@TD_OPAC_INSTN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@TD_CACCT_INSTN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@TD_ACCT_CHAR", OleDbType.VarChar,4),
					new OleDbParameter("@TD_TDP_PSBK_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_DL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_SEAL_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_SEAL_DL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_MNG_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_MNG_ACC_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_CLSD_INT", OleDbType.Decimal),
					new OleDbParameter("@TD_PART_DRW_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_INT_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@TD_ACC1_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@TD_CURR_CHAR", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_ADV_DRW_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_DL_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_SEAL_DL_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_WK_DATE", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@TD_CERT_NUM", OleDbType.Decimal),
					new OleDbParameter("@TD_PRT_NUM", OleDbType.Decimal),
					new OleDbParameter("@TD_TRT_VAL", OleDbType.Decimal),
					new OleDbParameter("@TD_INT_TAX_RPT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_TAX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CONNTR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@TD_LARGE_DEP_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_FLTR_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@TD_FLTR_FVR_SIGN", OleDbType.VarChar,1),
					new OleDbParameter("@TD_INPUT_INTR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_BELONG_TO_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_TRNO_ACC_BRCH_NO", OleDbType.VarChar,40),
					new OleDbParameter("@TD_ORG_OPAC_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_ADV_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCUM_SA_PDT", OleDbType.Decimal),
					new OleDbParameter("@TD_TDP_PSBK_PRT_NO", OleDbType.VarChar,13),
					new OleDbParameter("@TD_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@TD_PDP_CODE_C1", OleDbType.VarChar,3),
					new OleDbParameter("@TD_PDP_CODE_C2", OleDbType.VarChar,8),
					new OleDbParameter("@TD_INTR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@TD_DP_RANG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_SLCRD_NO", OleDbType.VarChar,16),
					new OleDbParameter("@TD_CERT_PRT_NO", OleDbType.VarChar,16),
					new OleDbParameter("@TD_PSWD_RULE", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_VRSN_NO1", OleDbType.VarChar,3),
					new OleDbParameter("@TD_PSWD_ERR_TIMES_N", OleDbType.Decimal),
					new OleDbParameter("@TD_PART_FRZ_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@TD_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@TD_PEND_INT", OleDbType.Decimal),
					new OleDbParameter("@TD_PEND_INTTAX", OleDbType.Decimal),
					new OleDbParameter("@TD_JUR_FRZ_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_JUR_PART_FRZ_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_JUR_FRZ_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_JUR_FRZ_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_CLSD_TAXINT", OleDbType.Decimal),
					new OleDbParameter("@TD_CLSD_INTTAX", OleDbType.Decimal),
					new OleDbParameter("@TD_ASES_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@TD_DB_PART_ID", OleDbType.VarChar,9)};
			parameters[0].Value = model.ETLDT;
			parameters[1].Value = model.TDACN_LL;
			parameters[2].Value = model.TD_TD_ACCT_NO;
			parameters[3].Value = model.TDACN_DB_TIMESTAMP;
			parameters[4].Value = model.TD_VRSN_NO_N;
			parameters[5].Value = model.TD_CURR_COD;
			parameters[6].Value = model.TD_VIP_ACCT_FLG;
			parameters[7].Value = model.TD_BACK;
			parameters[8].Value = model.TD_TDP_INTR;
			parameters[9].Value = model.TD_DEP_PRD_N;
			parameters[10].Value = model.TD_DEP_DRW_CYCL_N;
			parameters[11].Value = model.TD_DUE_DT;
			parameters[12].Value = model.TD_TD_RMRK;
			parameters[13].Value = model.TD_FRZ_STS;
			parameters[14].Value = model.TD_FRZ_DT;
			parameters[15].Value = model.TD_FRZ_TM;
			parameters[16].Value = model.TD_FLTR_FVR;
			parameters[17].Value = model.TD_DL_FLG;
			parameters[18].Value = model.TD_DL_DT;
			parameters[19].Value = model.TD_DL_TM;
			parameters[20].Value = model.TD_MBSTMT_ADDR;
			parameters[21].Value = model.TD_CLSD_DT;
			parameters[22].Value = model.TD_OPAC_TLR_NO;
			parameters[23].Value = model.TD_OPAC_AMT;
			parameters[24].Value = model.TD_OPAC_INTS_DT;
			parameters[25].Value = model.TD_OPAC_DT;
			parameters[26].Value = model.TD_CUST_NO;
			parameters[27].Value = model.TD_ACCUM_DEP_AMT;
			parameters[28].Value = model.TD_ACCUM_PDT;
			parameters[29].Value = model.TD_ACCUM_DRW_AMT;
			parameters[30].Value = model.TD_PPRD_DRW_AMT;
			parameters[31].Value = model.TD_QPSWD;
			parameters[32].Value = model.TD_ACTU_AMT;
			parameters[33].Value = model.TD_AS_EXC_FLAG;
			parameters[34].Value = model.TD_DW_RANG;
			parameters[35].Value = model.TD_ADV_DRW_DT;
			parameters[36].Value = model.TD_ADV_DRW_DSGN;
			parameters[37].Value = model.TD_CACCT_TLR_NO;
			parameters[38].Value = model.TD_NACCT_NO;
			parameters[39].Value = model.TD_OACCT_NO;
			parameters[40].Value = model.TD_PRDS_DEP_PRD1_N;
			parameters[41].Value = model.TD_PRDS_DEP_PRD2_N;
			parameters[42].Value = model.TD_ACCT_TYP;
			parameters[43].Value = model.TD_CVRT_FXR;
			parameters[44].Value = model.TD_DRW_TYP;
			parameters[45].Value = model.TD_LHYPO_FLG;
			parameters[46].Value = model.TD_CYCL_DEP_AMT;
			parameters[47].Value = model.TD_TRNO_ACC_NO;
			parameters[48].Value = model.TD_TRND_TDP_INT;
			parameters[49].Value = model.TD_TRND_DUEDT;
			parameters[50].Value = model.TD_TRND_AMT;
			parameters[51].Value = model.TD_TRND_INTC_DT;
			parameters[52].Value = model.TD_TRNT_TM_N;
			parameters[53].Value = model.TD_MNG_DEP_KND;
			parameters[54].Value = model.TD_ACCT_STS;
			parameters[55].Value = model.TD_PSBK_NO_N;
			parameters[56].Value = model.TD_LST_TX_DT;
			parameters[57].Value = model.TD_DEP_TYP;
			parameters[58].Value = model.TD_OPAC_INSTN_NO;
			parameters[59].Value = model.TD_CACCT_INSTN_NO;
			parameters[60].Value = model.TD_ACCT_CHAR;
			parameters[61].Value = model.TD_TDP_PSBK_FLG;
			parameters[62].Value = model.TD_PSWD_STS;
			parameters[63].Value = model.TD_PSWD_DL_DT;
			parameters[64].Value = model.TD_SEAL_STS;
			parameters[65].Value = model.TD_SEAL_DL_DT;
			parameters[66].Value = model.TD_MNG_FLG;
			parameters[67].Value = model.TD_MNG_ACC_NO;
			parameters[68].Value = model.TD_CLSD_INT;
			parameters[69].Value = model.TD_PART_DRW_FLG;
			parameters[70].Value = model.TD_INT_AMT;
			parameters[71].Value = model.TD_PRT_FLG;
			parameters[72].Value = model.TD_CUST_NAME;
			parameters[73].Value = model.TD_ACC1_NO;
			parameters[74].Value = model.TD_DOC_TYP;
			parameters[75].Value = model.TD_CURR_CHAR;
			parameters[76].Value = model.TD_PSBK_SQ_NO_N;
			parameters[77].Value = model.TD_ADV_DRW_AMT;
			parameters[78].Value = model.TD_CURR_IDEN;
			parameters[79].Value = model.TD_PSWD_DL_TM;
			parameters[80].Value = model.TD_SEAL_DL_TM;
			parameters[81].Value = model.TD_WK_DATE;
			parameters[82].Value = model.TD_TX_DT;
			parameters[83].Value = model.TD_TX_TM;
			parameters[84].Value = model.TD_CERT_NUM;
			parameters[85].Value = model.TD_PRT_NUM;
			parameters[86].Value = model.TD_TRT_VAL;
			parameters[87].Value = model.TD_INT_TAX_RPT_FLG;
			parameters[88].Value = model.TD_TAX_FLG;
			parameters[89].Value = model.TD_CONNTR_NO;
			parameters[90].Value = model.TD_LARGE_DEP_FLG;
			parameters[91].Value = model.TD_FLTR_TYP;
			parameters[92].Value = model.TD_FLTR_FVR_SIGN;
			parameters[93].Value = model.TD_INPUT_INTR_FLG;
			parameters[94].Value = model.TD_BELONG_TO_FLG;
			parameters[95].Value = model.TD_TRNO_ACC_BRCH_NO;
			parameters[96].Value = model.TD_ORG_OPAC_AMT;
			parameters[97].Value = model.TD_ADV_NO_N;
			parameters[98].Value = model.TD_ACCUM_SA_PDT;
			parameters[99].Value = model.TD_TDP_PSBK_PRT_NO;
			parameters[100].Value = model.TD_PDP_CODE;
			parameters[101].Value = model.TD_PDP_CODE_C1;
			parameters[102].Value = model.TD_PDP_CODE_C2;
			parameters[103].Value = model.TD_INTR_COD;
			parameters[104].Value = model.TD_DP_RANG;
			parameters[105].Value = model.TD_SLCRD_NO;
			parameters[106].Value = model.TD_CERT_PRT_NO;
			parameters[107].Value = model.TD_PSWD_RULE;
			parameters[108].Value = model.TD_PSWD_VRSN_NO1;
			parameters[109].Value = model.TD_PSWD_ERR_TIMES_N;
			parameters[110].Value = model.TD_PART_FRZ_AMT;
			parameters[111].Value = model.TD_CERT_TYP;
			parameters[112].Value = model.TD_CERT_ID;
			parameters[113].Value = model.TD_BELONG_INSTN_COD;
			parameters[114].Value = model.TD_PEND_INT;
			parameters[115].Value = model.TD_PEND_INTTAX;
			parameters[116].Value = model.TD_JUR_FRZ_STS;
			parameters[117].Value = model.TD_JUR_PART_FRZ_AMT;
			parameters[118].Value = model.TD_JUR_FRZ_DT;
			parameters[119].Value = model.TD_JUR_FRZ_TM;
			parameters[120].Value = model.TD_CLSD_TAXINT;
			parameters[121].Value = model.TD_CLSD_INTTAX;
			parameters[122].Value = model.TD_ASES_INSTN_COD;
			parameters[123].Value = model.TD_DB_PART_ID;

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
		public bool Update(MZSYCORE.Model.Model_CBOD_TDACNACN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CBOD_TDACNACN set ");
			strSql.Append("ETLDT=@ETLDT,");
			strSql.Append("TDACN_LL=@TDACN_LL,");
			strSql.Append("TD_TD_ACCT_NO=@TD_TD_ACCT_NO,");
			strSql.Append("TDACN_DB_TIMESTAMP=@TDACN_DB_TIMESTAMP,");
			strSql.Append("TD_VRSN_NO_N=@TD_VRSN_NO_N,");
			strSql.Append("TD_CURR_COD=@TD_CURR_COD,");
			strSql.Append("TD_VIP_ACCT_FLG=@TD_VIP_ACCT_FLG,");
			strSql.Append("TD_BACK=@TD_BACK,");
			strSql.Append("TD_TDP_INTR=@TD_TDP_INTR,");
			strSql.Append("TD_DEP_PRD_N=@TD_DEP_PRD_N,");
			strSql.Append("TD_DEP_DRW_CYCL_N=@TD_DEP_DRW_CYCL_N,");
			strSql.Append("TD_DUE_DT=@TD_DUE_DT,");
			strSql.Append("TD_TD_RMRK=@TD_TD_RMRK,");
			strSql.Append("TD_FRZ_STS=@TD_FRZ_STS,");
			strSql.Append("TD_FRZ_DT=@TD_FRZ_DT,");
			strSql.Append("TD_FRZ_TM=@TD_FRZ_TM,");
			strSql.Append("TD_FLTR_FVR=@TD_FLTR_FVR,");
			strSql.Append("TD_DL_FLG=@TD_DL_FLG,");
			strSql.Append("TD_DL_DT=@TD_DL_DT,");
			strSql.Append("TD_DL_TM=@TD_DL_TM,");
			strSql.Append("TD_MBSTMT_ADDR=@TD_MBSTMT_ADDR,");
			strSql.Append("TD_CLSD_DT=@TD_CLSD_DT,");
			strSql.Append("TD_OPAC_TLR_NO=@TD_OPAC_TLR_NO,");
			strSql.Append("TD_OPAC_AMT=@TD_OPAC_AMT,");
			strSql.Append("TD_OPAC_INTS_DT=@TD_OPAC_INTS_DT,");
			strSql.Append("TD_OPAC_DT=@TD_OPAC_DT,");
			strSql.Append("TD_CUST_NO=@TD_CUST_NO,");
			strSql.Append("TD_ACCUM_DEP_AMT=@TD_ACCUM_DEP_AMT,");
			strSql.Append("TD_ACCUM_PDT=@TD_ACCUM_PDT,");
			strSql.Append("TD_ACCUM_DRW_AMT=@TD_ACCUM_DRW_AMT,");
			strSql.Append("TD_PPRD_DRW_AMT=@TD_PPRD_DRW_AMT,");
			strSql.Append("TD_QPSWD=@TD_QPSWD,");
			strSql.Append("TD_ACTU_AMT=@TD_ACTU_AMT,");
			strSql.Append("TD_AS_EXC_FLAG=@TD_AS_EXC_FLAG,");
			strSql.Append("TD_DW_RANG=@TD_DW_RANG,");
			strSql.Append("TD_ADV_DRW_DT=@TD_ADV_DRW_DT,");
			strSql.Append("TD_ADV_DRW_DSGN=@TD_ADV_DRW_DSGN,");
			strSql.Append("TD_CACCT_TLR_NO=@TD_CACCT_TLR_NO,");
			strSql.Append("TD_NACCT_NO=@TD_NACCT_NO,");
			strSql.Append("TD_OACCT_NO=@TD_OACCT_NO,");
			strSql.Append("TD_PRDS_DEP_PRD1_N=@TD_PRDS_DEP_PRD1_N,");
			strSql.Append("TD_PRDS_DEP_PRD2_N=@TD_PRDS_DEP_PRD2_N,");
			strSql.Append("TD_ACCT_TYP=@TD_ACCT_TYP,");
			strSql.Append("TD_CVRT_FXR=@TD_CVRT_FXR,");
			strSql.Append("TD_DRW_TYP=@TD_DRW_TYP,");
			strSql.Append("TD_LHYPO_FLG=@TD_LHYPO_FLG,");
			strSql.Append("TD_CYCL_DEP_AMT=@TD_CYCL_DEP_AMT,");
			strSql.Append("TD_TRNO_ACC_NO=@TD_TRNO_ACC_NO,");
			strSql.Append("TD_TRND_TDP_INT=@TD_TRND_TDP_INT,");
			strSql.Append("TD_TRND_DUEDT=@TD_TRND_DUEDT,");
			strSql.Append("TD_TRND_AMT=@TD_TRND_AMT,");
			strSql.Append("TD_TRND_INTC_DT=@TD_TRND_INTC_DT,");
			strSql.Append("TD_TRNT_TM_N=@TD_TRNT_TM_N,");
			strSql.Append("TD_MNG_DEP_KND=@TD_MNG_DEP_KND,");
			strSql.Append("TD_ACCT_STS=@TD_ACCT_STS,");
			strSql.Append("TD_PSBK_NO_N=@TD_PSBK_NO_N,");
			strSql.Append("TD_LST_TX_DT=@TD_LST_TX_DT,");
			strSql.Append("TD_DEP_TYP=@TD_DEP_TYP,");
			strSql.Append("TD_OPAC_INSTN_NO=@TD_OPAC_INSTN_NO,");
			strSql.Append("TD_CACCT_INSTN_NO=@TD_CACCT_INSTN_NO,");
			strSql.Append("TD_ACCT_CHAR=@TD_ACCT_CHAR,");
			strSql.Append("TD_TDP_PSBK_FLG=@TD_TDP_PSBK_FLG,");
			strSql.Append("TD_PSWD_STS=@TD_PSWD_STS,");
			strSql.Append("TD_PSWD_DL_DT=@TD_PSWD_DL_DT,");
			strSql.Append("TD_SEAL_STS=@TD_SEAL_STS,");
			strSql.Append("TD_SEAL_DL_DT=@TD_SEAL_DL_DT,");
			strSql.Append("TD_MNG_FLG=@TD_MNG_FLG,");
			strSql.Append("TD_MNG_ACC_NO=@TD_MNG_ACC_NO,");
			strSql.Append("TD_CLSD_INT=@TD_CLSD_INT,");
			strSql.Append("TD_PART_DRW_FLG=@TD_PART_DRW_FLG,");
			strSql.Append("TD_INT_AMT=@TD_INT_AMT,");
			strSql.Append("TD_PRT_FLG=@TD_PRT_FLG,");
			strSql.Append("TD_CUST_NAME=@TD_CUST_NAME,");
			strSql.Append("TD_ACC1_NO=@TD_ACC1_NO,");
			strSql.Append("TD_DOC_TYP=@TD_DOC_TYP,");
			strSql.Append("TD_CURR_CHAR=@TD_CURR_CHAR,");
			strSql.Append("TD_PSBK_SQ_NO_N=@TD_PSBK_SQ_NO_N,");
			strSql.Append("TD_ADV_DRW_AMT=@TD_ADV_DRW_AMT,");
			strSql.Append("TD_CURR_IDEN=@TD_CURR_IDEN,");
			strSql.Append("TD_PSWD_DL_TM=@TD_PSWD_DL_TM,");
			strSql.Append("TD_SEAL_DL_TM=@TD_SEAL_DL_TM,");
			strSql.Append("TD_WK_DATE=@TD_WK_DATE,");
			strSql.Append("TD_TX_DT=@TD_TX_DT,");
			strSql.Append("TD_TX_TM=@TD_TX_TM,");
			strSql.Append("TD_CERT_NUM=@TD_CERT_NUM,");
			strSql.Append("TD_PRT_NUM=@TD_PRT_NUM,");
			strSql.Append("TD_TRT_VAL=@TD_TRT_VAL,");
			strSql.Append("TD_INT_TAX_RPT_FLG=@TD_INT_TAX_RPT_FLG,");
			strSql.Append("TD_TAX_FLG=@TD_TAX_FLG,");
			strSql.Append("TD_CONNTR_NO=@TD_CONNTR_NO,");
			strSql.Append("TD_LARGE_DEP_FLG=@TD_LARGE_DEP_FLG,");
			strSql.Append("TD_FLTR_TYP=@TD_FLTR_TYP,");
			strSql.Append("TD_FLTR_FVR_SIGN=@TD_FLTR_FVR_SIGN,");
			strSql.Append("TD_INPUT_INTR_FLG=@TD_INPUT_INTR_FLG,");
			strSql.Append("TD_BELONG_TO_FLG=@TD_BELONG_TO_FLG,");
			strSql.Append("TD_TRNO_ACC_BRCH_NO=@TD_TRNO_ACC_BRCH_NO,");
			strSql.Append("TD_ORG_OPAC_AMT=@TD_ORG_OPAC_AMT,");
			strSql.Append("TD_ADV_NO_N=@TD_ADV_NO_N,");
			strSql.Append("TD_ACCUM_SA_PDT=@TD_ACCUM_SA_PDT,");
			strSql.Append("TD_TDP_PSBK_PRT_NO=@TD_TDP_PSBK_PRT_NO,");
			strSql.Append("TD_PDP_CODE=@TD_PDP_CODE,");
			strSql.Append("TD_PDP_CODE_C1=@TD_PDP_CODE_C1,");
			strSql.Append("TD_PDP_CODE_C2=@TD_PDP_CODE_C2,");
			strSql.Append("TD_INTR_COD=@TD_INTR_COD,");
			strSql.Append("TD_DP_RANG=@TD_DP_RANG,");
			strSql.Append("TD_SLCRD_NO=@TD_SLCRD_NO,");
			strSql.Append("TD_CERT_PRT_NO=@TD_CERT_PRT_NO,");
			strSql.Append("TD_PSWD_RULE=@TD_PSWD_RULE,");
			strSql.Append("TD_PSWD_VRSN_NO1=@TD_PSWD_VRSN_NO1,");
			strSql.Append("TD_PSWD_ERR_TIMES_N=@TD_PSWD_ERR_TIMES_N,");
			strSql.Append("TD_PART_FRZ_AMT=@TD_PART_FRZ_AMT,");
			strSql.Append("TD_CERT_TYP=@TD_CERT_TYP,");
			strSql.Append("TD_CERT_ID=@TD_CERT_ID,");
			strSql.Append("TD_BELONG_INSTN_COD=@TD_BELONG_INSTN_COD,");
			strSql.Append("TD_PEND_INT=@TD_PEND_INT,");
			strSql.Append("TD_PEND_INTTAX=@TD_PEND_INTTAX,");
			strSql.Append("TD_JUR_FRZ_STS=@TD_JUR_FRZ_STS,");
			strSql.Append("TD_JUR_PART_FRZ_AMT=@TD_JUR_PART_FRZ_AMT,");
			strSql.Append("TD_JUR_FRZ_DT=@TD_JUR_FRZ_DT,");
			strSql.Append("TD_JUR_FRZ_TM=@TD_JUR_FRZ_TM,");
			strSql.Append("TD_CLSD_TAXINT=@TD_CLSD_TAXINT,");
			strSql.Append("TD_CLSD_INTTAX=@TD_CLSD_INTTAX,");
			strSql.Append("TD_ASES_INSTN_COD=@TD_ASES_INSTN_COD,");
			strSql.Append("TD_DB_PART_ID=@TD_DB_PART_ID");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@TDACN_LL", OleDbType.Decimal),
					new OleDbParameter("@TD_TD_ACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TDACN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@TD_VRSN_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@TD_VIP_ACCT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_BACK", OleDbType.VarChar,9),
					new OleDbParameter("@TD_TDP_INTR", OleDbType.Decimal),
					new OleDbParameter("@TD_DEP_PRD_N", OleDbType.Decimal),
					new OleDbParameter("@TD_DEP_DRW_CYCL_N", OleDbType.Decimal),
					new OleDbParameter("@TD_DUE_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TD_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@TD_FRZ_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_FRZ_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_FRZ_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_FLTR_FVR", OleDbType.Decimal),
					new OleDbParameter("@TD_DL_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_DL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_DL_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_MBSTMT_ADDR", OleDbType.VarChar,3),
					new OleDbParameter("@TD_CLSD_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_OPAC_TLR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@TD_OPAC_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_OPAC_INTS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_OPAC_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_CUST_NO", OleDbType.VarChar,20),
					new OleDbParameter("@TD_ACCUM_DEP_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCUM_PDT", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCUM_DRW_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_PPRD_DRW_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_QPSWD", OleDbType.VarChar,6),
					new OleDbParameter("@TD_ACTU_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_AS_EXC_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_DW_RANG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_ADV_DRW_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_ADV_DRW_DSGN", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CACCT_TLR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@TD_NACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_OACCT_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_PRDS_DEP_PRD1_N", OleDbType.Decimal),
					new OleDbParameter("@TD_PRDS_DEP_PRD2_N", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCT_TYP", OleDbType.VarChar,3),
					new OleDbParameter("@TD_CVRT_FXR", OleDbType.Decimal),
					new OleDbParameter("@TD_DRW_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@TD_LHYPO_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CYCL_DEP_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_TRNO_ACC_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_TRND_TDP_INT", OleDbType.Decimal),
					new OleDbParameter("@TD_TRND_DUEDT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TRND_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_TRND_INTC_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TRNT_TM_N", OleDbType.Decimal),
					new OleDbParameter("@TD_MNG_DEP_KND", OleDbType.VarChar,2),
					new OleDbParameter("@TD_ACCT_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSBK_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_LST_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_DEP_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@TD_OPAC_INSTN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@TD_CACCT_INSTN_NO", OleDbType.VarChar,9),
					new OleDbParameter("@TD_ACCT_CHAR", OleDbType.VarChar,4),
					new OleDbParameter("@TD_TDP_PSBK_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_DL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_SEAL_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_SEAL_DL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_MNG_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_MNG_ACC_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_CLSD_INT", OleDbType.Decimal),
					new OleDbParameter("@TD_PART_DRW_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_INT_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@TD_ACC1_NO", OleDbType.VarChar,28),
					new OleDbParameter("@TD_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@TD_CURR_CHAR", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_ADV_DRW_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_DL_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_SEAL_DL_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_WK_DATE", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@TD_CERT_NUM", OleDbType.Decimal),
					new OleDbParameter("@TD_PRT_NUM", OleDbType.Decimal),
					new OleDbParameter("@TD_TRT_VAL", OleDbType.Decimal),
					new OleDbParameter("@TD_INT_TAX_RPT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_TAX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CONNTR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@TD_LARGE_DEP_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_FLTR_TYP", OleDbType.VarChar,2),
					new OleDbParameter("@TD_FLTR_FVR_SIGN", OleDbType.VarChar,1),
					new OleDbParameter("@TD_INPUT_INTR_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_BELONG_TO_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_TRNO_ACC_BRCH_NO", OleDbType.VarChar,40),
					new OleDbParameter("@TD_ORG_OPAC_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_ADV_NO_N", OleDbType.Decimal),
					new OleDbParameter("@TD_ACCUM_SA_PDT", OleDbType.Decimal),
					new OleDbParameter("@TD_TDP_PSBK_PRT_NO", OleDbType.VarChar,13),
					new OleDbParameter("@TD_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@TD_PDP_CODE_C1", OleDbType.VarChar,3),
					new OleDbParameter("@TD_PDP_CODE_C2", OleDbType.VarChar,8),
					new OleDbParameter("@TD_INTR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@TD_DP_RANG", OleDbType.VarChar,1),
					new OleDbParameter("@TD_SLCRD_NO", OleDbType.VarChar,16),
					new OleDbParameter("@TD_CERT_PRT_NO", OleDbType.VarChar,16),
					new OleDbParameter("@TD_PSWD_RULE", OleDbType.VarChar,1),
					new OleDbParameter("@TD_PSWD_VRSN_NO1", OleDbType.VarChar,3),
					new OleDbParameter("@TD_PSWD_ERR_TIMES_N", OleDbType.Decimal),
					new OleDbParameter("@TD_PART_FRZ_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@TD_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@TD_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@TD_PEND_INT", OleDbType.Decimal),
					new OleDbParameter("@TD_PEND_INTTAX", OleDbType.Decimal),
					new OleDbParameter("@TD_JUR_FRZ_STS", OleDbType.VarChar,1),
					new OleDbParameter("@TD_JUR_PART_FRZ_AMT", OleDbType.Decimal),
					new OleDbParameter("@TD_JUR_FRZ_DT", OleDbType.VarChar,8),
					new OleDbParameter("@TD_JUR_FRZ_TM", OleDbType.VarChar,6),
					new OleDbParameter("@TD_CLSD_TAXINT", OleDbType.Decimal),
					new OleDbParameter("@TD_CLSD_INTTAX", OleDbType.Decimal),
					new OleDbParameter("@TD_ASES_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@TD_DB_PART_ID", OleDbType.VarChar,9)};
			parameters[0].Value = model.ETLDT;
			parameters[1].Value = model.TDACN_LL;
			parameters[2].Value = model.TD_TD_ACCT_NO;
			parameters[3].Value = model.TDACN_DB_TIMESTAMP;
			parameters[4].Value = model.TD_VRSN_NO_N;
			parameters[5].Value = model.TD_CURR_COD;
			parameters[6].Value = model.TD_VIP_ACCT_FLG;
			parameters[7].Value = model.TD_BACK;
			parameters[8].Value = model.TD_TDP_INTR;
			parameters[9].Value = model.TD_DEP_PRD_N;
			parameters[10].Value = model.TD_DEP_DRW_CYCL_N;
			parameters[11].Value = model.TD_DUE_DT;
			parameters[12].Value = model.TD_TD_RMRK;
			parameters[13].Value = model.TD_FRZ_STS;
			parameters[14].Value = model.TD_FRZ_DT;
			parameters[15].Value = model.TD_FRZ_TM;
			parameters[16].Value = model.TD_FLTR_FVR;
			parameters[17].Value = model.TD_DL_FLG;
			parameters[18].Value = model.TD_DL_DT;
			parameters[19].Value = model.TD_DL_TM;
			parameters[20].Value = model.TD_MBSTMT_ADDR;
			parameters[21].Value = model.TD_CLSD_DT;
			parameters[22].Value = model.TD_OPAC_TLR_NO;
			parameters[23].Value = model.TD_OPAC_AMT;
			parameters[24].Value = model.TD_OPAC_INTS_DT;
			parameters[25].Value = model.TD_OPAC_DT;
			parameters[26].Value = model.TD_CUST_NO;
			parameters[27].Value = model.TD_ACCUM_DEP_AMT;
			parameters[28].Value = model.TD_ACCUM_PDT;
			parameters[29].Value = model.TD_ACCUM_DRW_AMT;
			parameters[30].Value = model.TD_PPRD_DRW_AMT;
			parameters[31].Value = model.TD_QPSWD;
			parameters[32].Value = model.TD_ACTU_AMT;
			parameters[33].Value = model.TD_AS_EXC_FLAG;
			parameters[34].Value = model.TD_DW_RANG;
			parameters[35].Value = model.TD_ADV_DRW_DT;
			parameters[36].Value = model.TD_ADV_DRW_DSGN;
			parameters[37].Value = model.TD_CACCT_TLR_NO;
			parameters[38].Value = model.TD_NACCT_NO;
			parameters[39].Value = model.TD_OACCT_NO;
			parameters[40].Value = model.TD_PRDS_DEP_PRD1_N;
			parameters[41].Value = model.TD_PRDS_DEP_PRD2_N;
			parameters[42].Value = model.TD_ACCT_TYP;
			parameters[43].Value = model.TD_CVRT_FXR;
			parameters[44].Value = model.TD_DRW_TYP;
			parameters[45].Value = model.TD_LHYPO_FLG;
			parameters[46].Value = model.TD_CYCL_DEP_AMT;
			parameters[47].Value = model.TD_TRNO_ACC_NO;
			parameters[48].Value = model.TD_TRND_TDP_INT;
			parameters[49].Value = model.TD_TRND_DUEDT;
			parameters[50].Value = model.TD_TRND_AMT;
			parameters[51].Value = model.TD_TRND_INTC_DT;
			parameters[52].Value = model.TD_TRNT_TM_N;
			parameters[53].Value = model.TD_MNG_DEP_KND;
			parameters[54].Value = model.TD_ACCT_STS;
			parameters[55].Value = model.TD_PSBK_NO_N;
			parameters[56].Value = model.TD_LST_TX_DT;
			parameters[57].Value = model.TD_DEP_TYP;
			parameters[58].Value = model.TD_OPAC_INSTN_NO;
			parameters[59].Value = model.TD_CACCT_INSTN_NO;
			parameters[60].Value = model.TD_ACCT_CHAR;
			parameters[61].Value = model.TD_TDP_PSBK_FLG;
			parameters[62].Value = model.TD_PSWD_STS;
			parameters[63].Value = model.TD_PSWD_DL_DT;
			parameters[64].Value = model.TD_SEAL_STS;
			parameters[65].Value = model.TD_SEAL_DL_DT;
			parameters[66].Value = model.TD_MNG_FLG;
			parameters[67].Value = model.TD_MNG_ACC_NO;
			parameters[68].Value = model.TD_CLSD_INT;
			parameters[69].Value = model.TD_PART_DRW_FLG;
			parameters[70].Value = model.TD_INT_AMT;
			parameters[71].Value = model.TD_PRT_FLG;
			parameters[72].Value = model.TD_CUST_NAME;
			parameters[73].Value = model.TD_ACC1_NO;
			parameters[74].Value = model.TD_DOC_TYP;
			parameters[75].Value = model.TD_CURR_CHAR;
			parameters[76].Value = model.TD_PSBK_SQ_NO_N;
			parameters[77].Value = model.TD_ADV_DRW_AMT;
			parameters[78].Value = model.TD_CURR_IDEN;
			parameters[79].Value = model.TD_PSWD_DL_TM;
			parameters[80].Value = model.TD_SEAL_DL_TM;
			parameters[81].Value = model.TD_WK_DATE;
			parameters[82].Value = model.TD_TX_DT;
			parameters[83].Value = model.TD_TX_TM;
			parameters[84].Value = model.TD_CERT_NUM;
			parameters[85].Value = model.TD_PRT_NUM;
			parameters[86].Value = model.TD_TRT_VAL;
			parameters[87].Value = model.TD_INT_TAX_RPT_FLG;
			parameters[88].Value = model.TD_TAX_FLG;
			parameters[89].Value = model.TD_CONNTR_NO;
			parameters[90].Value = model.TD_LARGE_DEP_FLG;
			parameters[91].Value = model.TD_FLTR_TYP;
			parameters[92].Value = model.TD_FLTR_FVR_SIGN;
			parameters[93].Value = model.TD_INPUT_INTR_FLG;
			parameters[94].Value = model.TD_BELONG_TO_FLG;
			parameters[95].Value = model.TD_TRNO_ACC_BRCH_NO;
			parameters[96].Value = model.TD_ORG_OPAC_AMT;
			parameters[97].Value = model.TD_ADV_NO_N;
			parameters[98].Value = model.TD_ACCUM_SA_PDT;
			parameters[99].Value = model.TD_TDP_PSBK_PRT_NO;
			parameters[100].Value = model.TD_PDP_CODE;
			parameters[101].Value = model.TD_PDP_CODE_C1;
			parameters[102].Value = model.TD_PDP_CODE_C2;
			parameters[103].Value = model.TD_INTR_COD;
			parameters[104].Value = model.TD_DP_RANG;
			parameters[105].Value = model.TD_SLCRD_NO;
			parameters[106].Value = model.TD_CERT_PRT_NO;
			parameters[107].Value = model.TD_PSWD_RULE;
			parameters[108].Value = model.TD_PSWD_VRSN_NO1;
			parameters[109].Value = model.TD_PSWD_ERR_TIMES_N;
			parameters[110].Value = model.TD_PART_FRZ_AMT;
			parameters[111].Value = model.TD_CERT_TYP;
			parameters[112].Value = model.TD_CERT_ID;
			parameters[113].Value = model.TD_BELONG_INSTN_COD;
			parameters[114].Value = model.TD_PEND_INT;
			parameters[115].Value = model.TD_PEND_INTTAX;
			parameters[116].Value = model.TD_JUR_FRZ_STS;
			parameters[117].Value = model.TD_JUR_PART_FRZ_AMT;
			parameters[118].Value = model.TD_JUR_FRZ_DT;
			parameters[119].Value = model.TD_JUR_FRZ_TM;
			parameters[120].Value = model.TD_CLSD_TAXINT;
			parameters[121].Value = model.TD_CLSD_INTTAX;
			parameters[122].Value = model.TD_ASES_INSTN_COD;
			parameters[123].Value = model.TD_DB_PART_ID;

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
			strSql.Append("delete from CBOD_TDACNACN ");
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
		public MZSYCORE.Model.Model_CBOD_TDACNACN GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ETLDT,TDACN_LL,TD_TD_ACCT_NO,TDACN_DB_TIMESTAMP,TD_VRSN_NO_N,TD_CURR_COD,TD_VIP_ACCT_FLG,TD_BACK,TD_TDP_INTR,TD_DEP_PRD_N,TD_DEP_DRW_CYCL_N,TD_DUE_DT,TD_TD_RMRK,TD_FRZ_STS,TD_FRZ_DT,TD_FRZ_TM,TD_FLTR_FVR,TD_DL_FLG,TD_DL_DT,TD_DL_TM,TD_MBSTMT_ADDR,TD_CLSD_DT,TD_OPAC_TLR_NO,TD_OPAC_AMT,TD_OPAC_INTS_DT,TD_OPAC_DT,TD_CUST_NO,TD_ACCUM_DEP_AMT,TD_ACCUM_PDT,TD_ACCUM_DRW_AMT,TD_PPRD_DRW_AMT,TD_QPSWD,TD_ACTU_AMT,TD_AS_EXC_FLAG,TD_DW_RANG,TD_ADV_DRW_DT,TD_ADV_DRW_DSGN,TD_CACCT_TLR_NO,TD_NACCT_NO,TD_OACCT_NO,TD_PRDS_DEP_PRD1_N,TD_PRDS_DEP_PRD2_N,TD_ACCT_TYP,TD_CVRT_FXR,TD_DRW_TYP,TD_LHYPO_FLG,TD_CYCL_DEP_AMT,TD_TRNO_ACC_NO,TD_TRND_TDP_INT,TD_TRND_DUEDT,TD_TRND_AMT,TD_TRND_INTC_DT,TD_TRNT_TM_N,TD_MNG_DEP_KND,TD_ACCT_STS,TD_PSBK_NO_N,TD_LST_TX_DT,TD_DEP_TYP,TD_OPAC_INSTN_NO,TD_CACCT_INSTN_NO,TD_ACCT_CHAR,TD_TDP_PSBK_FLG,TD_PSWD_STS,TD_PSWD_DL_DT,TD_SEAL_STS,TD_SEAL_DL_DT,TD_MNG_FLG,TD_MNG_ACC_NO,TD_CLSD_INT,TD_PART_DRW_FLG,TD_INT_AMT,TD_PRT_FLG,TD_CUST_NAME,TD_ACC1_NO,TD_DOC_TYP,TD_CURR_CHAR,TD_PSBK_SQ_NO_N,TD_ADV_DRW_AMT,TD_CURR_IDEN,TD_PSWD_DL_TM,TD_SEAL_DL_TM,TD_WK_DATE,TD_TX_DT,TD_TX_TM,TD_CERT_NUM,TD_PRT_NUM,TD_TRT_VAL,TD_INT_TAX_RPT_FLG,TD_TAX_FLG,TD_CONNTR_NO,TD_LARGE_DEP_FLG,TD_FLTR_TYP,TD_FLTR_FVR_SIGN,TD_INPUT_INTR_FLG,TD_BELONG_TO_FLG,TD_TRNO_ACC_BRCH_NO,TD_ORG_OPAC_AMT,TD_ADV_NO_N,TD_ACCUM_SA_PDT,TD_TDP_PSBK_PRT_NO,TD_PDP_CODE,TD_PDP_CODE_C1,TD_PDP_CODE_C2,TD_INTR_COD,TD_DP_RANG,TD_SLCRD_NO,TD_CERT_PRT_NO,TD_PSWD_RULE,TD_PSWD_VRSN_NO1,TD_PSWD_ERR_TIMES_N,TD_PART_FRZ_AMT,TD_CERT_TYP,TD_CERT_ID,TD_BELONG_INSTN_COD,TD_PEND_INT,TD_PEND_INTTAX,TD_JUR_FRZ_STS,TD_JUR_PART_FRZ_AMT,TD_JUR_FRZ_DT,TD_JUR_FRZ_TM,TD_CLSD_TAXINT,TD_CLSD_INTTAX,TD_ASES_INSTN_COD,TD_DB_PART_ID from CBOD_TDACNACN ");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
			};

			MZSYCORE.Model.Model_CBOD_TDACNACN model=new MZSYCORE.Model.Model_CBOD_TDACNACN();
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
		public MZSYCORE.Model.Model_CBOD_TDACNACN DataRowToModel(DataRow row)
		{
			MZSYCORE.Model.Model_CBOD_TDACNACN model=new MZSYCORE.Model.Model_CBOD_TDACNACN();
			if (row != null)
			{
				if(row["ETLDT"]!=null)
				{
					model.ETLDT=row["ETLDT"].ToString();
				}
				if(row["TDACN_LL"]!=null && row["TDACN_LL"].ToString()!="")
				{
					model.TDACN_LL=decimal.Parse(row["TDACN_LL"].ToString());
				}
				if(row["TD_TD_ACCT_NO"]!=null)
				{
					model.TD_TD_ACCT_NO=row["TD_TD_ACCT_NO"].ToString();
				}
				if(row["TDACN_DB_TIMESTAMP"]!=null && row["TDACN_DB_TIMESTAMP"].ToString()!="")
				{
					model.TDACN_DB_TIMESTAMP=decimal.Parse(row["TDACN_DB_TIMESTAMP"].ToString());
				}
				if(row["TD_VRSN_NO_N"]!=null && row["TD_VRSN_NO_N"].ToString()!="")
				{
					model.TD_VRSN_NO_N=decimal.Parse(row["TD_VRSN_NO_N"].ToString());
				}
				if(row["TD_CURR_COD"]!=null)
				{
					model.TD_CURR_COD=row["TD_CURR_COD"].ToString();
				}
				if(row["TD_VIP_ACCT_FLG"]!=null)
				{
					model.TD_VIP_ACCT_FLG=row["TD_VIP_ACCT_FLG"].ToString();
				}
				if(row["TD_BACK"]!=null)
				{
					model.TD_BACK=row["TD_BACK"].ToString();
				}
				if(row["TD_TDP_INTR"]!=null && row["TD_TDP_INTR"].ToString()!="")
				{
					model.TD_TDP_INTR=decimal.Parse(row["TD_TDP_INTR"].ToString());
				}
				if(row["TD_DEP_PRD_N"]!=null && row["TD_DEP_PRD_N"].ToString()!="")
				{
					model.TD_DEP_PRD_N=decimal.Parse(row["TD_DEP_PRD_N"].ToString());
				}
				if(row["TD_DEP_DRW_CYCL_N"]!=null && row["TD_DEP_DRW_CYCL_N"].ToString()!="")
				{
					model.TD_DEP_DRW_CYCL_N=decimal.Parse(row["TD_DEP_DRW_CYCL_N"].ToString());
				}
				if(row["TD_DUE_DT"]!=null)
				{
					model.TD_DUE_DT=row["TD_DUE_DT"].ToString();
				}
				if(row["TD_TD_RMRK"]!=null)
				{
					model.TD_TD_RMRK=row["TD_TD_RMRK"].ToString();
				}
				if(row["TD_FRZ_STS"]!=null)
				{
					model.TD_FRZ_STS=row["TD_FRZ_STS"].ToString();
				}
				if(row["TD_FRZ_DT"]!=null)
				{
					model.TD_FRZ_DT=row["TD_FRZ_DT"].ToString();
				}
				if(row["TD_FRZ_TM"]!=null)
				{
					model.TD_FRZ_TM=row["TD_FRZ_TM"].ToString();
				}
				if(row["TD_FLTR_FVR"]!=null && row["TD_FLTR_FVR"].ToString()!="")
				{
					model.TD_FLTR_FVR=decimal.Parse(row["TD_FLTR_FVR"].ToString());
				}
				if(row["TD_DL_FLG"]!=null)
				{
					model.TD_DL_FLG=row["TD_DL_FLG"].ToString();
				}
				if(row["TD_DL_DT"]!=null)
				{
					model.TD_DL_DT=row["TD_DL_DT"].ToString();
				}
				if(row["TD_DL_TM"]!=null)
				{
					model.TD_DL_TM=row["TD_DL_TM"].ToString();
				}
				if(row["TD_MBSTMT_ADDR"]!=null)
				{
					model.TD_MBSTMT_ADDR=row["TD_MBSTMT_ADDR"].ToString();
				}
				if(row["TD_CLSD_DT"]!=null)
				{
					model.TD_CLSD_DT=row["TD_CLSD_DT"].ToString();
				}
				if(row["TD_OPAC_TLR_NO"]!=null)
				{
					model.TD_OPAC_TLR_NO=row["TD_OPAC_TLR_NO"].ToString();
				}
				if(row["TD_OPAC_AMT"]!=null && row["TD_OPAC_AMT"].ToString()!="")
				{
					model.TD_OPAC_AMT=decimal.Parse(row["TD_OPAC_AMT"].ToString());
				}
				if(row["TD_OPAC_INTS_DT"]!=null)
				{
					model.TD_OPAC_INTS_DT=row["TD_OPAC_INTS_DT"].ToString();
				}
				if(row["TD_OPAC_DT"]!=null)
				{
					model.TD_OPAC_DT=row["TD_OPAC_DT"].ToString();
				}
				if(row["TD_CUST_NO"]!=null)
				{
					model.TD_CUST_NO=row["TD_CUST_NO"].ToString();
				}
				if(row["TD_ACCUM_DEP_AMT"]!=null && row["TD_ACCUM_DEP_AMT"].ToString()!="")
				{
					model.TD_ACCUM_DEP_AMT=decimal.Parse(row["TD_ACCUM_DEP_AMT"].ToString());
				}
				if(row["TD_ACCUM_PDT"]!=null && row["TD_ACCUM_PDT"].ToString()!="")
				{
					model.TD_ACCUM_PDT=decimal.Parse(row["TD_ACCUM_PDT"].ToString());
				}
				if(row["TD_ACCUM_DRW_AMT"]!=null && row["TD_ACCUM_DRW_AMT"].ToString()!="")
				{
					model.TD_ACCUM_DRW_AMT=decimal.Parse(row["TD_ACCUM_DRW_AMT"].ToString());
				}
				if(row["TD_PPRD_DRW_AMT"]!=null && row["TD_PPRD_DRW_AMT"].ToString()!="")
				{
					model.TD_PPRD_DRW_AMT=decimal.Parse(row["TD_PPRD_DRW_AMT"].ToString());
				}
				if(row["TD_QPSWD"]!=null)
				{
					model.TD_QPSWD=row["TD_QPSWD"].ToString();
				}
				if(row["TD_ACTU_AMT"]!=null && row["TD_ACTU_AMT"].ToString()!="")
				{
					model.TD_ACTU_AMT=decimal.Parse(row["TD_ACTU_AMT"].ToString());
				}
				if(row["TD_AS_EXC_FLAG"]!=null)
				{
					model.TD_AS_EXC_FLAG=row["TD_AS_EXC_FLAG"].ToString();
				}
				if(row["TD_DW_RANG"]!=null)
				{
					model.TD_DW_RANG=row["TD_DW_RANG"].ToString();
				}
				if(row["TD_ADV_DRW_DT"]!=null)
				{
					model.TD_ADV_DRW_DT=row["TD_ADV_DRW_DT"].ToString();
				}
				if(row["TD_ADV_DRW_DSGN"]!=null)
				{
					model.TD_ADV_DRW_DSGN=row["TD_ADV_DRW_DSGN"].ToString();
				}
				if(row["TD_CACCT_TLR_NO"]!=null)
				{
					model.TD_CACCT_TLR_NO=row["TD_CACCT_TLR_NO"].ToString();
				}
				if(row["TD_NACCT_NO"]!=null)
				{
					model.TD_NACCT_NO=row["TD_NACCT_NO"].ToString();
				}
				if(row["TD_OACCT_NO"]!=null)
				{
					model.TD_OACCT_NO=row["TD_OACCT_NO"].ToString();
				}
				if(row["TD_PRDS_DEP_PRD1_N"]!=null && row["TD_PRDS_DEP_PRD1_N"].ToString()!="")
				{
					model.TD_PRDS_DEP_PRD1_N=decimal.Parse(row["TD_PRDS_DEP_PRD1_N"].ToString());
				}
				if(row["TD_PRDS_DEP_PRD2_N"]!=null && row["TD_PRDS_DEP_PRD2_N"].ToString()!="")
				{
					model.TD_PRDS_DEP_PRD2_N=decimal.Parse(row["TD_PRDS_DEP_PRD2_N"].ToString());
				}
				if(row["TD_ACCT_TYP"]!=null)
				{
					model.TD_ACCT_TYP=row["TD_ACCT_TYP"].ToString();
				}
				if(row["TD_CVRT_FXR"]!=null && row["TD_CVRT_FXR"].ToString()!="")
				{
					model.TD_CVRT_FXR=decimal.Parse(row["TD_CVRT_FXR"].ToString());
				}
				if(row["TD_DRW_TYP"]!=null)
				{
					model.TD_DRW_TYP=row["TD_DRW_TYP"].ToString();
				}
				if(row["TD_LHYPO_FLG"]!=null)
				{
					model.TD_LHYPO_FLG=row["TD_LHYPO_FLG"].ToString();
				}
				if(row["TD_CYCL_DEP_AMT"]!=null && row["TD_CYCL_DEP_AMT"].ToString()!="")
				{
					model.TD_CYCL_DEP_AMT=decimal.Parse(row["TD_CYCL_DEP_AMT"].ToString());
				}
				if(row["TD_TRNO_ACC_NO"]!=null)
				{
					model.TD_TRNO_ACC_NO=row["TD_TRNO_ACC_NO"].ToString();
				}
				if(row["TD_TRND_TDP_INT"]!=null && row["TD_TRND_TDP_INT"].ToString()!="")
				{
					model.TD_TRND_TDP_INT=decimal.Parse(row["TD_TRND_TDP_INT"].ToString());
				}
				if(row["TD_TRND_DUEDT"]!=null)
				{
					model.TD_TRND_DUEDT=row["TD_TRND_DUEDT"].ToString();
				}
				if(row["TD_TRND_AMT"]!=null && row["TD_TRND_AMT"].ToString()!="")
				{
					model.TD_TRND_AMT=decimal.Parse(row["TD_TRND_AMT"].ToString());
				}
				if(row["TD_TRND_INTC_DT"]!=null)
				{
					model.TD_TRND_INTC_DT=row["TD_TRND_INTC_DT"].ToString();
				}
				if(row["TD_TRNT_TM_N"]!=null && row["TD_TRNT_TM_N"].ToString()!="")
				{
					model.TD_TRNT_TM_N=decimal.Parse(row["TD_TRNT_TM_N"].ToString());
				}
				if(row["TD_MNG_DEP_KND"]!=null)
				{
					model.TD_MNG_DEP_KND=row["TD_MNG_DEP_KND"].ToString();
				}
				if(row["TD_ACCT_STS"]!=null)
				{
					model.TD_ACCT_STS=row["TD_ACCT_STS"].ToString();
				}
				if(row["TD_PSBK_NO_N"]!=null && row["TD_PSBK_NO_N"].ToString()!="")
				{
					model.TD_PSBK_NO_N=decimal.Parse(row["TD_PSBK_NO_N"].ToString());
				}
				if(row["TD_LST_TX_DT"]!=null)
				{
					model.TD_LST_TX_DT=row["TD_LST_TX_DT"].ToString();
				}
				if(row["TD_DEP_TYP"]!=null)
				{
					model.TD_DEP_TYP=row["TD_DEP_TYP"].ToString();
				}
				if(row["TD_OPAC_INSTN_NO"]!=null)
				{
					model.TD_OPAC_INSTN_NO=row["TD_OPAC_INSTN_NO"].ToString();
				}
				if(row["TD_CACCT_INSTN_NO"]!=null)
				{
					model.TD_CACCT_INSTN_NO=row["TD_CACCT_INSTN_NO"].ToString();
				}
				if(row["TD_ACCT_CHAR"]!=null)
				{
					model.TD_ACCT_CHAR=row["TD_ACCT_CHAR"].ToString();
				}
				if(row["TD_TDP_PSBK_FLG"]!=null)
				{
					model.TD_TDP_PSBK_FLG=row["TD_TDP_PSBK_FLG"].ToString();
				}
				if(row["TD_PSWD_STS"]!=null)
				{
					model.TD_PSWD_STS=row["TD_PSWD_STS"].ToString();
				}
				if(row["TD_PSWD_DL_DT"]!=null)
				{
					model.TD_PSWD_DL_DT=row["TD_PSWD_DL_DT"].ToString();
				}
				if(row["TD_SEAL_STS"]!=null)
				{
					model.TD_SEAL_STS=row["TD_SEAL_STS"].ToString();
				}
				if(row["TD_SEAL_DL_DT"]!=null)
				{
					model.TD_SEAL_DL_DT=row["TD_SEAL_DL_DT"].ToString();
				}
				if(row["TD_MNG_FLG"]!=null)
				{
					model.TD_MNG_FLG=row["TD_MNG_FLG"].ToString();
				}
				if(row["TD_MNG_ACC_NO"]!=null)
				{
					model.TD_MNG_ACC_NO=row["TD_MNG_ACC_NO"].ToString();
				}
				if(row["TD_CLSD_INT"]!=null && row["TD_CLSD_INT"].ToString()!="")
				{
					model.TD_CLSD_INT=decimal.Parse(row["TD_CLSD_INT"].ToString());
				}
				if(row["TD_PART_DRW_FLG"]!=null)
				{
					model.TD_PART_DRW_FLG=row["TD_PART_DRW_FLG"].ToString();
				}
				if(row["TD_INT_AMT"]!=null && row["TD_INT_AMT"].ToString()!="")
				{
					model.TD_INT_AMT=decimal.Parse(row["TD_INT_AMT"].ToString());
				}
				if(row["TD_PRT_FLG"]!=null)
				{
					model.TD_PRT_FLG=row["TD_PRT_FLG"].ToString();
				}
				if(row["TD_CUST_NAME"]!=null)
				{
					model.TD_CUST_NAME=row["TD_CUST_NAME"].ToString();
				}
				if(row["TD_ACC1_NO"]!=null)
				{
					model.TD_ACC1_NO=row["TD_ACC1_NO"].ToString();
				}
				if(row["TD_DOC_TYP"]!=null)
				{
					model.TD_DOC_TYP=row["TD_DOC_TYP"].ToString();
				}
				if(row["TD_CURR_CHAR"]!=null)
				{
					model.TD_CURR_CHAR=row["TD_CURR_CHAR"].ToString();
				}
				if(row["TD_PSBK_SQ_NO_N"]!=null && row["TD_PSBK_SQ_NO_N"].ToString()!="")
				{
					model.TD_PSBK_SQ_NO_N=decimal.Parse(row["TD_PSBK_SQ_NO_N"].ToString());
				}
				if(row["TD_ADV_DRW_AMT"]!=null && row["TD_ADV_DRW_AMT"].ToString()!="")
				{
					model.TD_ADV_DRW_AMT=decimal.Parse(row["TD_ADV_DRW_AMT"].ToString());
				}
				if(row["TD_CURR_IDEN"]!=null)
				{
					model.TD_CURR_IDEN=row["TD_CURR_IDEN"].ToString();
				}
				if(row["TD_PSWD_DL_TM"]!=null)
				{
					model.TD_PSWD_DL_TM=row["TD_PSWD_DL_TM"].ToString();
				}
				if(row["TD_SEAL_DL_TM"]!=null)
				{
					model.TD_SEAL_DL_TM=row["TD_SEAL_DL_TM"].ToString();
				}
				if(row["TD_WK_DATE"]!=null)
				{
					model.TD_WK_DATE=row["TD_WK_DATE"].ToString();
				}
				if(row["TD_TX_DT"]!=null)
				{
					model.TD_TX_DT=row["TD_TX_DT"].ToString();
				}
				if(row["TD_TX_TM"]!=null)
				{
					model.TD_TX_TM=row["TD_TX_TM"].ToString();
				}
				if(row["TD_CERT_NUM"]!=null && row["TD_CERT_NUM"].ToString()!="")
				{
					model.TD_CERT_NUM=decimal.Parse(row["TD_CERT_NUM"].ToString());
				}
				if(row["TD_PRT_NUM"]!=null && row["TD_PRT_NUM"].ToString()!="")
				{
					model.TD_PRT_NUM=decimal.Parse(row["TD_PRT_NUM"].ToString());
				}
				if(row["TD_TRT_VAL"]!=null && row["TD_TRT_VAL"].ToString()!="")
				{
					model.TD_TRT_VAL=decimal.Parse(row["TD_TRT_VAL"].ToString());
				}
				if(row["TD_INT_TAX_RPT_FLG"]!=null)
				{
					model.TD_INT_TAX_RPT_FLG=row["TD_INT_TAX_RPT_FLG"].ToString();
				}
				if(row["TD_TAX_FLG"]!=null)
				{
					model.TD_TAX_FLG=row["TD_TAX_FLG"].ToString();
				}
				if(row["TD_CONNTR_NO"]!=null)
				{
					model.TD_CONNTR_NO=row["TD_CONNTR_NO"].ToString();
				}
				if(row["TD_LARGE_DEP_FLG"]!=null)
				{
					model.TD_LARGE_DEP_FLG=row["TD_LARGE_DEP_FLG"].ToString();
				}
				if(row["TD_FLTR_TYP"]!=null)
				{
					model.TD_FLTR_TYP=row["TD_FLTR_TYP"].ToString();
				}
				if(row["TD_FLTR_FVR_SIGN"]!=null)
				{
					model.TD_FLTR_FVR_SIGN=row["TD_FLTR_FVR_SIGN"].ToString();
				}
				if(row["TD_INPUT_INTR_FLG"]!=null)
				{
					model.TD_INPUT_INTR_FLG=row["TD_INPUT_INTR_FLG"].ToString();
				}
				if(row["TD_BELONG_TO_FLG"]!=null)
				{
					model.TD_BELONG_TO_FLG=row["TD_BELONG_TO_FLG"].ToString();
				}
				if(row["TD_TRNO_ACC_BRCH_NO"]!=null)
				{
					model.TD_TRNO_ACC_BRCH_NO=row["TD_TRNO_ACC_BRCH_NO"].ToString();
				}
				if(row["TD_ORG_OPAC_AMT"]!=null && row["TD_ORG_OPAC_AMT"].ToString()!="")
				{
					model.TD_ORG_OPAC_AMT=decimal.Parse(row["TD_ORG_OPAC_AMT"].ToString());
				}
				if(row["TD_ADV_NO_N"]!=null && row["TD_ADV_NO_N"].ToString()!="")
				{
					model.TD_ADV_NO_N=decimal.Parse(row["TD_ADV_NO_N"].ToString());
				}
				if(row["TD_ACCUM_SA_PDT"]!=null && row["TD_ACCUM_SA_PDT"].ToString()!="")
				{
					model.TD_ACCUM_SA_PDT=decimal.Parse(row["TD_ACCUM_SA_PDT"].ToString());
				}
				if(row["TD_TDP_PSBK_PRT_NO"]!=null)
				{
					model.TD_TDP_PSBK_PRT_NO=row["TD_TDP_PSBK_PRT_NO"].ToString();
				}
				if(row["TD_PDP_CODE"]!=null)
				{
					model.TD_PDP_CODE=row["TD_PDP_CODE"].ToString();
				}
				if(row["TD_PDP_CODE_C1"]!=null)
				{
					model.TD_PDP_CODE_C1=row["TD_PDP_CODE_C1"].ToString();
				}
				if(row["TD_PDP_CODE_C2"]!=null)
				{
					model.TD_PDP_CODE_C2=row["TD_PDP_CODE_C2"].ToString();
				}
				if(row["TD_INTR_COD"]!=null)
				{
					model.TD_INTR_COD=row["TD_INTR_COD"].ToString();
				}
				if(row["TD_DP_RANG"]!=null)
				{
					model.TD_DP_RANG=row["TD_DP_RANG"].ToString();
				}
				if(row["TD_SLCRD_NO"]!=null)
				{
					model.TD_SLCRD_NO=row["TD_SLCRD_NO"].ToString();
				}
				if(row["TD_CERT_PRT_NO"]!=null)
				{
					model.TD_CERT_PRT_NO=row["TD_CERT_PRT_NO"].ToString();
				}
				if(row["TD_PSWD_RULE"]!=null)
				{
					model.TD_PSWD_RULE=row["TD_PSWD_RULE"].ToString();
				}
				if(row["TD_PSWD_VRSN_NO1"]!=null)
				{
					model.TD_PSWD_VRSN_NO1=row["TD_PSWD_VRSN_NO1"].ToString();
				}
				if(row["TD_PSWD_ERR_TIMES_N"]!=null && row["TD_PSWD_ERR_TIMES_N"].ToString()!="")
				{
					model.TD_PSWD_ERR_TIMES_N=decimal.Parse(row["TD_PSWD_ERR_TIMES_N"].ToString());
				}
				if(row["TD_PART_FRZ_AMT"]!=null && row["TD_PART_FRZ_AMT"].ToString()!="")
				{
					model.TD_PART_FRZ_AMT=decimal.Parse(row["TD_PART_FRZ_AMT"].ToString());
				}
				if(row["TD_CERT_TYP"]!=null)
				{
					model.TD_CERT_TYP=row["TD_CERT_TYP"].ToString();
				}
				if(row["TD_CERT_ID"]!=null)
				{
					model.TD_CERT_ID=row["TD_CERT_ID"].ToString();
				}
				if(row["TD_BELONG_INSTN_COD"]!=null)
				{
					model.TD_BELONG_INSTN_COD=row["TD_BELONG_INSTN_COD"].ToString();
				}
				if(row["TD_PEND_INT"]!=null && row["TD_PEND_INT"].ToString()!="")
				{
					model.TD_PEND_INT=decimal.Parse(row["TD_PEND_INT"].ToString());
				}
				if(row["TD_PEND_INTTAX"]!=null && row["TD_PEND_INTTAX"].ToString()!="")
				{
					model.TD_PEND_INTTAX=decimal.Parse(row["TD_PEND_INTTAX"].ToString());
				}
				if(row["TD_JUR_FRZ_STS"]!=null)
				{
					model.TD_JUR_FRZ_STS=row["TD_JUR_FRZ_STS"].ToString();
				}
				if(row["TD_JUR_PART_FRZ_AMT"]!=null && row["TD_JUR_PART_FRZ_AMT"].ToString()!="")
				{
					model.TD_JUR_PART_FRZ_AMT=decimal.Parse(row["TD_JUR_PART_FRZ_AMT"].ToString());
				}
				if(row["TD_JUR_FRZ_DT"]!=null)
				{
					model.TD_JUR_FRZ_DT=row["TD_JUR_FRZ_DT"].ToString();
				}
				if(row["TD_JUR_FRZ_TM"]!=null)
				{
					model.TD_JUR_FRZ_TM=row["TD_JUR_FRZ_TM"].ToString();
				}
				if(row["TD_CLSD_TAXINT"]!=null && row["TD_CLSD_TAXINT"].ToString()!="")
				{
					model.TD_CLSD_TAXINT=decimal.Parse(row["TD_CLSD_TAXINT"].ToString());
				}
				if(row["TD_CLSD_INTTAX"]!=null && row["TD_CLSD_INTTAX"].ToString()!="")
				{
					model.TD_CLSD_INTTAX=decimal.Parse(row["TD_CLSD_INTTAX"].ToString());
				}
				if(row["TD_ASES_INSTN_COD"]!=null)
				{
					model.TD_ASES_INSTN_COD=row["TD_ASES_INSTN_COD"].ToString();
				}
				if(row["TD_DB_PART_ID"]!=null)
				{
					model.TD_DB_PART_ID=row["TD_DB_PART_ID"].ToString();
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
			strSql.Append("select ETLDT,TDACN_LL,TD_TD_ACCT_NO,TDACN_DB_TIMESTAMP,TD_VRSN_NO_N,TD_CURR_COD,TD_VIP_ACCT_FLG,TD_BACK,TD_TDP_INTR,TD_DEP_PRD_N,TD_DEP_DRW_CYCL_N,TD_DUE_DT,TD_TD_RMRK,TD_FRZ_STS,TD_FRZ_DT,TD_FRZ_TM,TD_FLTR_FVR,TD_DL_FLG,TD_DL_DT,TD_DL_TM,TD_MBSTMT_ADDR,TD_CLSD_DT,TD_OPAC_TLR_NO,TD_OPAC_AMT,TD_OPAC_INTS_DT,TD_OPAC_DT,TD_CUST_NO,TD_ACCUM_DEP_AMT,TD_ACCUM_PDT,TD_ACCUM_DRW_AMT,TD_PPRD_DRW_AMT,TD_QPSWD,TD_ACTU_AMT,TD_AS_EXC_FLAG,TD_DW_RANG,TD_ADV_DRW_DT,TD_ADV_DRW_DSGN,TD_CACCT_TLR_NO,TD_NACCT_NO,TD_OACCT_NO,TD_PRDS_DEP_PRD1_N,TD_PRDS_DEP_PRD2_N,TD_ACCT_TYP,TD_CVRT_FXR,TD_DRW_TYP,TD_LHYPO_FLG,TD_CYCL_DEP_AMT,TD_TRNO_ACC_NO,TD_TRND_TDP_INT,TD_TRND_DUEDT,TD_TRND_AMT,TD_TRND_INTC_DT,TD_TRNT_TM_N,TD_MNG_DEP_KND,TD_ACCT_STS,TD_PSBK_NO_N,TD_LST_TX_DT,TD_DEP_TYP,TD_OPAC_INSTN_NO,TD_CACCT_INSTN_NO,TD_ACCT_CHAR,TD_TDP_PSBK_FLG,TD_PSWD_STS,TD_PSWD_DL_DT,TD_SEAL_STS,TD_SEAL_DL_DT,TD_MNG_FLG,TD_MNG_ACC_NO,TD_CLSD_INT,TD_PART_DRW_FLG,TD_INT_AMT,TD_PRT_FLG,TD_CUST_NAME,TD_ACC1_NO,TD_DOC_TYP,TD_CURR_CHAR,TD_PSBK_SQ_NO_N,TD_ADV_DRW_AMT,TD_CURR_IDEN,TD_PSWD_DL_TM,TD_SEAL_DL_TM,TD_WK_DATE,TD_TX_DT,TD_TX_TM,TD_CERT_NUM,TD_PRT_NUM,TD_TRT_VAL,TD_INT_TAX_RPT_FLG,TD_TAX_FLG,TD_CONNTR_NO,TD_LARGE_DEP_FLG,TD_FLTR_TYP,TD_FLTR_FVR_SIGN,TD_INPUT_INTR_FLG,TD_BELONG_TO_FLG,TD_TRNO_ACC_BRCH_NO,TD_ORG_OPAC_AMT,TD_ADV_NO_N,TD_ACCUM_SA_PDT,TD_TDP_PSBK_PRT_NO,TD_PDP_CODE,TD_PDP_CODE_C1,TD_PDP_CODE_C2,TD_INTR_COD,TD_DP_RANG,TD_SLCRD_NO,TD_CERT_PRT_NO,TD_PSWD_RULE,TD_PSWD_VRSN_NO1,TD_PSWD_ERR_TIMES_N,TD_PART_FRZ_AMT,TD_CERT_TYP,TD_CERT_ID,TD_BELONG_INSTN_COD,TD_PEND_INT,TD_PEND_INTTAX,TD_JUR_FRZ_STS,TD_JUR_PART_FRZ_AMT,TD_JUR_FRZ_DT,TD_JUR_FRZ_TM,TD_CLSD_TAXINT,TD_CLSD_INTTAX,TD_ASES_INSTN_COD,TD_DB_PART_ID ");
			strSql.Append(" FROM CBOD_TDACNACN ");
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
			strSql.Append("select count(1) FROM CBOD_TDACNACN ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from CBOD_TDACNACN T ");
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
			parameters[0].Value = "CBOD_TDACNACN";
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

