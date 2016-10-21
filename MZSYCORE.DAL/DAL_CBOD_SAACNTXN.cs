using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    /// <summary>
    /// 数据访问类:DAL_CBOD_SAACNTXN
    /// </summary>
    public partial class DAL_CBOD_SAACNTXN
    {
        public DAL_CBOD_SAACNTXN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ETLDT, decimal SATXN_LL, string FK_SAACN_KEY, decimal SA_DDP_ACCT_NO_DET_N, decimal SATXN_DB_TIMESTAMP, string SA_CURR_COD, string SA_OPR_NO, string SA_CURR_IDEN, string SA_EC_FLG, decimal SA_EC_DET_NO_N, decimal SA_CR_AMT, decimal SA_DDP_ACCT_BAL, decimal SA_TX_AMT, string SA_TX_CRD_NO, string SA_TX_TYP, string SA_TX_LOG_NO, decimal SA_DR_AMT, string SA_DOC_NO, string SA_DOC_TYP, string SA_VAL_DT, decimal SA_SVC, string SA_AUTH_NO, string SA_CUST_DOCAG_STNO, string SA_OPUN_COD, string SA_DSCRP_COD, string SA_RMRK, string SA_TX_TM, string SA_TX_DT, string SA_SYS_DT, decimal SA_DDP_PDT, string SA_APP_TX_CODE, string SA_ETX_FLG, string SA_OTX_FLG, string SA_FLX_FLG, string SA_GUIJI_FLAG, string SA_PRT_FLG, string SA_FILLER, string SA_RMRK_1, string SA_OP_CUST_NAME, string SA_AGT_CERT_TYP, string SA_AGT_CERT_ID, string SA_AGT_CUST_NAME, string SA_BELONG_INSTN_COD, string SA_CHANNEL_FLAG, string SA_PDP_CODE, string SA_OP_ACCT_NO_32, string SA_OP_BANK_NO, string SA_SUP_TLR, string SA_DB_PART_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CBOD_SAACNTXN");
            strSql.Append(" where ETLDT=@ETLDT and SATXN_LL=@SATXN_LL and FK_SAACN_KEY=@FK_SAACN_KEY and SA_DDP_ACCT_NO_DET_N=@SA_DDP_ACCT_NO_DET_N and SATXN_DB_TIMESTAMP=@SATXN_DB_TIMESTAMP and SA_CURR_COD=@SA_CURR_COD and SA_OPR_NO=@SA_OPR_NO and SA_CURR_IDEN=@SA_CURR_IDEN and SA_EC_FLG=@SA_EC_FLG and SA_EC_DET_NO_N=@SA_EC_DET_NO_N and SA_CR_AMT=@SA_CR_AMT and SA_DDP_ACCT_BAL=@SA_DDP_ACCT_BAL and SA_TX_AMT=@SA_TX_AMT and SA_TX_CRD_NO=@SA_TX_CRD_NO and SA_TX_TYP=@SA_TX_TYP and SA_TX_LOG_NO=@SA_TX_LOG_NO and SA_DR_AMT=@SA_DR_AMT and SA_DOC_NO=@SA_DOC_NO and SA_DOC_TYP=@SA_DOC_TYP and SA_VAL_DT=@SA_VAL_DT and SA_SVC=@SA_SVC and SA_AUTH_NO=@SA_AUTH_NO and SA_CUST_DOCAG_STNO=@SA_CUST_DOCAG_STNO and SA_OPUN_COD=@SA_OPUN_COD and SA_DSCRP_COD=@SA_DSCRP_COD and SA_RMRK=@SA_RMRK and SA_TX_TM=@SA_TX_TM and SA_TX_DT=@SA_TX_DT and SA_SYS_DT=@SA_SYS_DT and SA_DDP_PDT=@SA_DDP_PDT and SA_APP_TX_CODE=@SA_APP_TX_CODE and SA_ETX_FLG=@SA_ETX_FLG and SA_OTX_FLG=@SA_OTX_FLG and SA_FLX_FLG=@SA_FLX_FLG and SA_GUIJI_FLAG=@SA_GUIJI_FLAG and SA_PRT_FLG=@SA_PRT_FLG and SA_FILLER=@SA_FILLER and SA_RMRK_1=@SA_RMRK_1 and SA_OP_CUST_NAME=@SA_OP_CUST_NAME and SA_AGT_CERT_TYP=@SA_AGT_CERT_TYP and SA_AGT_CERT_ID=@SA_AGT_CERT_ID and SA_AGT_CUST_NAME=@SA_AGT_CUST_NAME and SA_BELONG_INSTN_COD=@SA_BELONG_INSTN_COD and SA_CHANNEL_FLAG=@SA_CHANNEL_FLAG and SA_PDP_CODE=@SA_PDP_CODE and SA_OP_ACCT_NO_32=@SA_OP_ACCT_NO_32 and SA_OP_BANK_NO=@SA_OP_BANK_NO and SA_SUP_TLR=@SA_SUP_TLR and SA_DB_PART_ID=@SA_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@SATXN_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_SAACN_KEY", OleDbType.VarChar,28),
					new OleDbParameter("@SA_DDP_ACCT_NO_DET_N", OleDbType.Decimal),
					new OleDbParameter("@SATXN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@SA_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@SA_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@SA_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_DET_NO_N", OleDbType.Decimal),
					new OleDbParameter("@SA_CR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DDP_ACCT_BAL", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_TX_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_DR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DOC_NO", OleDbType.VarChar,16),
					new OleDbParameter("@SA_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@SA_VAL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SVC", OleDbType.Decimal),
					new OleDbParameter("@SA_AUTH_NO", OleDbType.VarChar,6),
					new OleDbParameter("@SA_CUST_DOCAG_STNO", OleDbType.VarChar,15),
					new OleDbParameter("@SA_OPUN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@SA_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@SA_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@SA_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SYS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_DDP_PDT", OleDbType.Decimal),
					new OleDbParameter("@SA_APP_TX_CODE", OleDbType.VarChar,4),
					new OleDbParameter("@SA_ETX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_OTX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FLX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_GUIJI_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FILLER", OleDbType.VarChar,1),
					new OleDbParameter("@SA_RMRK_1", OleDbType.VarChar,40),
					new OleDbParameter("@SA_OP_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@SA_AGT_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_AGT_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@SA_AGT_CUST_NAME", OleDbType.VarChar,60),
					new OleDbParameter("@SA_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_CHANNEL_FLAG", OleDbType.VarChar,2),
					new OleDbParameter("@SA_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@SA_OP_ACCT_NO_32", OleDbType.VarChar,32),
					new OleDbParameter("@SA_OP_BANK_NO", OleDbType.VarChar,9),
					new OleDbParameter("@SA_SUP_TLR", OleDbType.VarChar,12),
					new OleDbParameter("@SA_DB_PART_ID", OleDbType.VarChar,9)			};
            parameters[0].Value = ETLDT;
            parameters[1].Value = SATXN_LL;
            parameters[2].Value = FK_SAACN_KEY;
            parameters[3].Value = SA_DDP_ACCT_NO_DET_N;
            parameters[4].Value = SATXN_DB_TIMESTAMP;
            parameters[5].Value = SA_CURR_COD;
            parameters[6].Value = SA_OPR_NO;
            parameters[7].Value = SA_CURR_IDEN;
            parameters[8].Value = SA_EC_FLG;
            parameters[9].Value = SA_EC_DET_NO_N;
            parameters[10].Value = SA_CR_AMT;
            parameters[11].Value = SA_DDP_ACCT_BAL;
            parameters[12].Value = SA_TX_AMT;
            parameters[13].Value = SA_TX_CRD_NO;
            parameters[14].Value = SA_TX_TYP;
            parameters[15].Value = SA_TX_LOG_NO;
            parameters[16].Value = SA_DR_AMT;
            parameters[17].Value = SA_DOC_NO;
            parameters[18].Value = SA_DOC_TYP;
            parameters[19].Value = SA_VAL_DT;
            parameters[20].Value = SA_SVC;
            parameters[21].Value = SA_AUTH_NO;
            parameters[22].Value = SA_CUST_DOCAG_STNO;
            parameters[23].Value = SA_OPUN_COD;
            parameters[24].Value = SA_DSCRP_COD;
            parameters[25].Value = SA_RMRK;
            parameters[26].Value = SA_TX_TM;
            parameters[27].Value = SA_TX_DT;
            parameters[28].Value = SA_SYS_DT;
            parameters[29].Value = SA_DDP_PDT;
            parameters[30].Value = SA_APP_TX_CODE;
            parameters[31].Value = SA_ETX_FLG;
            parameters[32].Value = SA_OTX_FLG;
            parameters[33].Value = SA_FLX_FLG;
            parameters[34].Value = SA_GUIJI_FLAG;
            parameters[35].Value = SA_PRT_FLG;
            parameters[36].Value = SA_FILLER;
            parameters[37].Value = SA_RMRK_1;
            parameters[38].Value = SA_OP_CUST_NAME;
            parameters[39].Value = SA_AGT_CERT_TYP;
            parameters[40].Value = SA_AGT_CERT_ID;
            parameters[41].Value = SA_AGT_CUST_NAME;
            parameters[42].Value = SA_BELONG_INSTN_COD;
            parameters[43].Value = SA_CHANNEL_FLAG;
            parameters[44].Value = SA_PDP_CODE;
            parameters[45].Value = SA_OP_ACCT_NO_32;
            parameters[46].Value = SA_OP_BANK_NO;
            parameters[47].Value = SA_SUP_TLR;
            parameters[48].Value = SA_DB_PART_ID;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MZSYCORE.Model.Model_CBOD_SAACNTXN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CBOD_SAACNTXN(");
            strSql.Append("ETLDT,SATXN_LL,FK_SAACN_KEY,SA_DDP_ACCT_NO_DET_N,SATXN_DB_TIMESTAMP,SA_CURR_COD,SA_OPR_NO,SA_CURR_IDEN,SA_EC_FLG,SA_EC_DET_NO_N,SA_CR_AMT,SA_DDP_ACCT_BAL,SA_TX_AMT,SA_TX_CRD_NO,SA_TX_TYP,SA_TX_LOG_NO,SA_DR_AMT,SA_DOC_NO,SA_DOC_TYP,SA_VAL_DT,SA_SVC,SA_AUTH_NO,SA_CUST_DOCAG_STNO,SA_OPUN_COD,SA_DSCRP_COD,SA_RMRK,SA_TX_TM,SA_TX_DT,SA_SYS_DT,SA_DDP_PDT,SA_APP_TX_CODE,SA_ETX_FLG,SA_OTX_FLG,SA_FLX_FLG,SA_GUIJI_FLAG,SA_PRT_FLG,SA_FILLER,SA_RMRK_1,SA_OP_CUST_NAME,SA_AGT_CERT_TYP,SA_AGT_CERT_ID,SA_AGT_CUST_NAME,SA_BELONG_INSTN_COD,SA_CHANNEL_FLAG,SA_PDP_CODE,SA_OP_ACCT_NO_32,SA_OP_BANK_NO,SA_SUP_TLR,SA_DB_PART_ID)");
            strSql.Append(" values (");
            strSql.Append("@ETLDT,@SATXN_LL,@FK_SAACN_KEY,@SA_DDP_ACCT_NO_DET_N,@SATXN_DB_TIMESTAMP,@SA_CURR_COD,@SA_OPR_NO,@SA_CURR_IDEN,@SA_EC_FLG,@SA_EC_DET_NO_N,@SA_CR_AMT,@SA_DDP_ACCT_BAL,@SA_TX_AMT,@SA_TX_CRD_NO,@SA_TX_TYP,@SA_TX_LOG_NO,@SA_DR_AMT,@SA_DOC_NO,@SA_DOC_TYP,@SA_VAL_DT,@SA_SVC,@SA_AUTH_NO,@SA_CUST_DOCAG_STNO,@SA_OPUN_COD,@SA_DSCRP_COD,@SA_RMRK,@SA_TX_TM,@SA_TX_DT,@SA_SYS_DT,@SA_DDP_PDT,@SA_APP_TX_CODE,@SA_ETX_FLG,@SA_OTX_FLG,@SA_FLX_FLG,@SA_GUIJI_FLAG,@SA_PRT_FLG,@SA_FILLER,@SA_RMRK_1,@SA_OP_CUST_NAME,@SA_AGT_CERT_TYP,@SA_AGT_CERT_ID,@SA_AGT_CUST_NAME,@SA_BELONG_INSTN_COD,@SA_CHANNEL_FLAG,@SA_PDP_CODE,@SA_OP_ACCT_NO_32,@SA_OP_BANK_NO,@SA_SUP_TLR,@SA_DB_PART_ID)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@SATXN_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_SAACN_KEY", OleDbType.VarChar,28),
					new OleDbParameter("@SA_DDP_ACCT_NO_DET_N", OleDbType.Decimal),
					new OleDbParameter("@SATXN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@SA_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@SA_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@SA_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_DET_NO_N", OleDbType.Decimal),
					new OleDbParameter("@SA_CR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DDP_ACCT_BAL", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_TX_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_DR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DOC_NO", OleDbType.VarChar,16),
					new OleDbParameter("@SA_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@SA_VAL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SVC", OleDbType.Decimal),
					new OleDbParameter("@SA_AUTH_NO", OleDbType.VarChar,6),
					new OleDbParameter("@SA_CUST_DOCAG_STNO", OleDbType.VarChar,15),
					new OleDbParameter("@SA_OPUN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@SA_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@SA_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@SA_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SYS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_DDP_PDT", OleDbType.Decimal),
					new OleDbParameter("@SA_APP_TX_CODE", OleDbType.VarChar,4),
					new OleDbParameter("@SA_ETX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_OTX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FLX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_GUIJI_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FILLER", OleDbType.VarChar,1),
					new OleDbParameter("@SA_RMRK_1", OleDbType.VarChar,40),
					new OleDbParameter("@SA_OP_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@SA_AGT_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_AGT_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@SA_AGT_CUST_NAME", OleDbType.VarChar,60),
					new OleDbParameter("@SA_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_CHANNEL_FLAG", OleDbType.VarChar,2),
					new OleDbParameter("@SA_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@SA_OP_ACCT_NO_32", OleDbType.VarChar,32),
					new OleDbParameter("@SA_OP_BANK_NO", OleDbType.VarChar,9),
					new OleDbParameter("@SA_SUP_TLR", OleDbType.VarChar,12),
					new OleDbParameter("@SA_DB_PART_ID", OleDbType.VarChar,9)};
            parameters[0].Value = model.ETLDT;
            parameters[1].Value = model.SATXN_LL;
            parameters[2].Value = model.FK_SAACN_KEY;
            parameters[3].Value = model.SA_DDP_ACCT_NO_DET_N;
            parameters[4].Value = model.SATXN_DB_TIMESTAMP;
            parameters[5].Value = model.SA_CURR_COD;
            parameters[6].Value = model.SA_OPR_NO;
            parameters[7].Value = model.SA_CURR_IDEN;
            parameters[8].Value = model.SA_EC_FLG;
            parameters[9].Value = model.SA_EC_DET_NO_N;
            parameters[10].Value = model.SA_CR_AMT;
            parameters[11].Value = model.SA_DDP_ACCT_BAL;
            parameters[12].Value = model.SA_TX_AMT;
            parameters[13].Value = model.SA_TX_CRD_NO;
            parameters[14].Value = model.SA_TX_TYP;
            parameters[15].Value = model.SA_TX_LOG_NO;
            parameters[16].Value = model.SA_DR_AMT;
            parameters[17].Value = model.SA_DOC_NO;
            parameters[18].Value = model.SA_DOC_TYP;
            parameters[19].Value = model.SA_VAL_DT;
            parameters[20].Value = model.SA_SVC;
            parameters[21].Value = model.SA_AUTH_NO;
            parameters[22].Value = model.SA_CUST_DOCAG_STNO;
            parameters[23].Value = model.SA_OPUN_COD;
            parameters[24].Value = model.SA_DSCRP_COD;
            parameters[25].Value = model.SA_RMRK;
            parameters[26].Value = model.SA_TX_TM;
            parameters[27].Value = model.SA_TX_DT;
            parameters[28].Value = model.SA_SYS_DT;
            parameters[29].Value = model.SA_DDP_PDT;
            parameters[30].Value = model.SA_APP_TX_CODE;
            parameters[31].Value = model.SA_ETX_FLG;
            parameters[32].Value = model.SA_OTX_FLG;
            parameters[33].Value = model.SA_FLX_FLG;
            parameters[34].Value = model.SA_GUIJI_FLAG;
            parameters[35].Value = model.SA_PRT_FLG;
            parameters[36].Value = model.SA_FILLER;
            parameters[37].Value = model.SA_RMRK_1;
            parameters[38].Value = model.SA_OP_CUST_NAME;
            parameters[39].Value = model.SA_AGT_CERT_TYP;
            parameters[40].Value = model.SA_AGT_CERT_ID;
            parameters[41].Value = model.SA_AGT_CUST_NAME;
            parameters[42].Value = model.SA_BELONG_INSTN_COD;
            parameters[43].Value = model.SA_CHANNEL_FLAG;
            parameters[44].Value = model.SA_PDP_CODE;
            parameters[45].Value = model.SA_OP_ACCT_NO_32;
            parameters[46].Value = model.SA_OP_BANK_NO;
            parameters[47].Value = model.SA_SUP_TLR;
            parameters[48].Value = model.SA_DB_PART_ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(MZSYCORE.Model.Model_CBOD_SAACNTXN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CBOD_SAACNTXN set ");
            strSql.Append("ETLDT=@ETLDT,");
            strSql.Append("SATXN_LL=@SATXN_LL,");
            strSql.Append("FK_SAACN_KEY=@FK_SAACN_KEY,");
            strSql.Append("SA_DDP_ACCT_NO_DET_N=@SA_DDP_ACCT_NO_DET_N,");
            strSql.Append("SATXN_DB_TIMESTAMP=@SATXN_DB_TIMESTAMP,");
            strSql.Append("SA_CURR_COD=@SA_CURR_COD,");
            strSql.Append("SA_OPR_NO=@SA_OPR_NO,");
            strSql.Append("SA_CURR_IDEN=@SA_CURR_IDEN,");
            strSql.Append("SA_EC_FLG=@SA_EC_FLG,");
            strSql.Append("SA_EC_DET_NO_N=@SA_EC_DET_NO_N,");
            strSql.Append("SA_CR_AMT=@SA_CR_AMT,");
            strSql.Append("SA_DDP_ACCT_BAL=@SA_DDP_ACCT_BAL,");
            strSql.Append("SA_TX_AMT=@SA_TX_AMT,");
            strSql.Append("SA_TX_CRD_NO=@SA_TX_CRD_NO,");
            strSql.Append("SA_TX_TYP=@SA_TX_TYP,");
            strSql.Append("SA_TX_LOG_NO=@SA_TX_LOG_NO,");
            strSql.Append("SA_DR_AMT=@SA_DR_AMT,");
            strSql.Append("SA_DOC_NO=@SA_DOC_NO,");
            strSql.Append("SA_DOC_TYP=@SA_DOC_TYP,");
            strSql.Append("SA_VAL_DT=@SA_VAL_DT,");
            strSql.Append("SA_SVC=@SA_SVC,");
            strSql.Append("SA_AUTH_NO=@SA_AUTH_NO,");
            strSql.Append("SA_CUST_DOCAG_STNO=@SA_CUST_DOCAG_STNO,");
            strSql.Append("SA_OPUN_COD=@SA_OPUN_COD,");
            strSql.Append("SA_DSCRP_COD=@SA_DSCRP_COD,");
            strSql.Append("SA_RMRK=@SA_RMRK,");
            strSql.Append("SA_TX_TM=@SA_TX_TM,");
            strSql.Append("SA_TX_DT=@SA_TX_DT,");
            strSql.Append("SA_SYS_DT=@SA_SYS_DT,");
            strSql.Append("SA_DDP_PDT=@SA_DDP_PDT,");
            strSql.Append("SA_APP_TX_CODE=@SA_APP_TX_CODE,");
            strSql.Append("SA_ETX_FLG=@SA_ETX_FLG,");
            strSql.Append("SA_OTX_FLG=@SA_OTX_FLG,");
            strSql.Append("SA_FLX_FLG=@SA_FLX_FLG,");
            strSql.Append("SA_GUIJI_FLAG=@SA_GUIJI_FLAG,");
            strSql.Append("SA_PRT_FLG=@SA_PRT_FLG,");
            strSql.Append("SA_FILLER=@SA_FILLER,");
            strSql.Append("SA_RMRK_1=@SA_RMRK_1,");
            strSql.Append("SA_OP_CUST_NAME=@SA_OP_CUST_NAME,");
            strSql.Append("SA_AGT_CERT_TYP=@SA_AGT_CERT_TYP,");
            strSql.Append("SA_AGT_CERT_ID=@SA_AGT_CERT_ID,");
            strSql.Append("SA_AGT_CUST_NAME=@SA_AGT_CUST_NAME,");
            strSql.Append("SA_BELONG_INSTN_COD=@SA_BELONG_INSTN_COD,");
            strSql.Append("SA_CHANNEL_FLAG=@SA_CHANNEL_FLAG,");
            strSql.Append("SA_PDP_CODE=@SA_PDP_CODE,");
            strSql.Append("SA_OP_ACCT_NO_32=@SA_OP_ACCT_NO_32,");
            strSql.Append("SA_OP_BANK_NO=@SA_OP_BANK_NO,");
            strSql.Append("SA_SUP_TLR=@SA_SUP_TLR,");
            strSql.Append("SA_DB_PART_ID=@SA_DB_PART_ID");
            strSql.Append(" where ETLDT=@ETLDT and SATXN_LL=@SATXN_LL and FK_SAACN_KEY=@FK_SAACN_KEY and SA_DDP_ACCT_NO_DET_N=@SA_DDP_ACCT_NO_DET_N and SATXN_DB_TIMESTAMP=@SATXN_DB_TIMESTAMP and SA_CURR_COD=@SA_CURR_COD and SA_OPR_NO=@SA_OPR_NO and SA_CURR_IDEN=@SA_CURR_IDEN and SA_EC_FLG=@SA_EC_FLG and SA_EC_DET_NO_N=@SA_EC_DET_NO_N and SA_CR_AMT=@SA_CR_AMT and SA_DDP_ACCT_BAL=@SA_DDP_ACCT_BAL and SA_TX_AMT=@SA_TX_AMT and SA_TX_CRD_NO=@SA_TX_CRD_NO and SA_TX_TYP=@SA_TX_TYP and SA_TX_LOG_NO=@SA_TX_LOG_NO and SA_DR_AMT=@SA_DR_AMT and SA_DOC_NO=@SA_DOC_NO and SA_DOC_TYP=@SA_DOC_TYP and SA_VAL_DT=@SA_VAL_DT and SA_SVC=@SA_SVC and SA_AUTH_NO=@SA_AUTH_NO and SA_CUST_DOCAG_STNO=@SA_CUST_DOCAG_STNO and SA_OPUN_COD=@SA_OPUN_COD and SA_DSCRP_COD=@SA_DSCRP_COD and SA_RMRK=@SA_RMRK and SA_TX_TM=@SA_TX_TM and SA_TX_DT=@SA_TX_DT and SA_SYS_DT=@SA_SYS_DT and SA_DDP_PDT=@SA_DDP_PDT and SA_APP_TX_CODE=@SA_APP_TX_CODE and SA_ETX_FLG=@SA_ETX_FLG and SA_OTX_FLG=@SA_OTX_FLG and SA_FLX_FLG=@SA_FLX_FLG and SA_GUIJI_FLAG=@SA_GUIJI_FLAG and SA_PRT_FLG=@SA_PRT_FLG and SA_FILLER=@SA_FILLER and SA_RMRK_1=@SA_RMRK_1 and SA_OP_CUST_NAME=@SA_OP_CUST_NAME and SA_AGT_CERT_TYP=@SA_AGT_CERT_TYP and SA_AGT_CERT_ID=@SA_AGT_CERT_ID and SA_AGT_CUST_NAME=@SA_AGT_CUST_NAME and SA_BELONG_INSTN_COD=@SA_BELONG_INSTN_COD and SA_CHANNEL_FLAG=@SA_CHANNEL_FLAG and SA_PDP_CODE=@SA_PDP_CODE and SA_OP_ACCT_NO_32=@SA_OP_ACCT_NO_32 and SA_OP_BANK_NO=@SA_OP_BANK_NO and SA_SUP_TLR=@SA_SUP_TLR and SA_DB_PART_ID=@SA_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@SATXN_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_SAACN_KEY", OleDbType.VarChar,28),
					new OleDbParameter("@SA_DDP_ACCT_NO_DET_N", OleDbType.Decimal),
					new OleDbParameter("@SATXN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@SA_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@SA_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@SA_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_DET_NO_N", OleDbType.Decimal),
					new OleDbParameter("@SA_CR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DDP_ACCT_BAL", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_TX_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_DR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DOC_NO", OleDbType.VarChar,16),
					new OleDbParameter("@SA_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@SA_VAL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SVC", OleDbType.Decimal),
					new OleDbParameter("@SA_AUTH_NO", OleDbType.VarChar,6),
					new OleDbParameter("@SA_CUST_DOCAG_STNO", OleDbType.VarChar,15),
					new OleDbParameter("@SA_OPUN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@SA_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@SA_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@SA_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SYS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_DDP_PDT", OleDbType.Decimal),
					new OleDbParameter("@SA_APP_TX_CODE", OleDbType.VarChar,4),
					new OleDbParameter("@SA_ETX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_OTX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FLX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_GUIJI_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FILLER", OleDbType.VarChar,1),
					new OleDbParameter("@SA_RMRK_1", OleDbType.VarChar,40),
					new OleDbParameter("@SA_OP_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@SA_AGT_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_AGT_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@SA_AGT_CUST_NAME", OleDbType.VarChar,60),
					new OleDbParameter("@SA_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_CHANNEL_FLAG", OleDbType.VarChar,2),
					new OleDbParameter("@SA_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@SA_OP_ACCT_NO_32", OleDbType.VarChar,32),
					new OleDbParameter("@SA_OP_BANK_NO", OleDbType.VarChar,9),
					new OleDbParameter("@SA_SUP_TLR", OleDbType.VarChar,12),
					new OleDbParameter("@SA_DB_PART_ID", OleDbType.VarChar,9)};
            parameters[0].Value = model.ETLDT;
            parameters[1].Value = model.SATXN_LL;
            parameters[2].Value = model.FK_SAACN_KEY;
            parameters[3].Value = model.SA_DDP_ACCT_NO_DET_N;
            parameters[4].Value = model.SATXN_DB_TIMESTAMP;
            parameters[5].Value = model.SA_CURR_COD;
            parameters[6].Value = model.SA_OPR_NO;
            parameters[7].Value = model.SA_CURR_IDEN;
            parameters[8].Value = model.SA_EC_FLG;
            parameters[9].Value = model.SA_EC_DET_NO_N;
            parameters[10].Value = model.SA_CR_AMT;
            parameters[11].Value = model.SA_DDP_ACCT_BAL;
            parameters[12].Value = model.SA_TX_AMT;
            parameters[13].Value = model.SA_TX_CRD_NO;
            parameters[14].Value = model.SA_TX_TYP;
            parameters[15].Value = model.SA_TX_LOG_NO;
            parameters[16].Value = model.SA_DR_AMT;
            parameters[17].Value = model.SA_DOC_NO;
            parameters[18].Value = model.SA_DOC_TYP;
            parameters[19].Value = model.SA_VAL_DT;
            parameters[20].Value = model.SA_SVC;
            parameters[21].Value = model.SA_AUTH_NO;
            parameters[22].Value = model.SA_CUST_DOCAG_STNO;
            parameters[23].Value = model.SA_OPUN_COD;
            parameters[24].Value = model.SA_DSCRP_COD;
            parameters[25].Value = model.SA_RMRK;
            parameters[26].Value = model.SA_TX_TM;
            parameters[27].Value = model.SA_TX_DT;
            parameters[28].Value = model.SA_SYS_DT;
            parameters[29].Value = model.SA_DDP_PDT;
            parameters[30].Value = model.SA_APP_TX_CODE;
            parameters[31].Value = model.SA_ETX_FLG;
            parameters[32].Value = model.SA_OTX_FLG;
            parameters[33].Value = model.SA_FLX_FLG;
            parameters[34].Value = model.SA_GUIJI_FLAG;
            parameters[35].Value = model.SA_PRT_FLG;
            parameters[36].Value = model.SA_FILLER;
            parameters[37].Value = model.SA_RMRK_1;
            parameters[38].Value = model.SA_OP_CUST_NAME;
            parameters[39].Value = model.SA_AGT_CERT_TYP;
            parameters[40].Value = model.SA_AGT_CERT_ID;
            parameters[41].Value = model.SA_AGT_CUST_NAME;
            parameters[42].Value = model.SA_BELONG_INSTN_COD;
            parameters[43].Value = model.SA_CHANNEL_FLAG;
            parameters[44].Value = model.SA_PDP_CODE;
            parameters[45].Value = model.SA_OP_ACCT_NO_32;
            parameters[46].Value = model.SA_OP_BANK_NO;
            parameters[47].Value = model.SA_SUP_TLR;
            parameters[48].Value = model.SA_DB_PART_ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(string ETLDT, decimal SATXN_LL, string FK_SAACN_KEY, decimal SA_DDP_ACCT_NO_DET_N, decimal SATXN_DB_TIMESTAMP, string SA_CURR_COD, string SA_OPR_NO, string SA_CURR_IDEN, string SA_EC_FLG, decimal SA_EC_DET_NO_N, decimal SA_CR_AMT, decimal SA_DDP_ACCT_BAL, decimal SA_TX_AMT, string SA_TX_CRD_NO, string SA_TX_TYP, string SA_TX_LOG_NO, decimal SA_DR_AMT, string SA_DOC_NO, string SA_DOC_TYP, string SA_VAL_DT, decimal SA_SVC, string SA_AUTH_NO, string SA_CUST_DOCAG_STNO, string SA_OPUN_COD, string SA_DSCRP_COD, string SA_RMRK, string SA_TX_TM, string SA_TX_DT, string SA_SYS_DT, decimal SA_DDP_PDT, string SA_APP_TX_CODE, string SA_ETX_FLG, string SA_OTX_FLG, string SA_FLX_FLG, string SA_GUIJI_FLAG, string SA_PRT_FLG, string SA_FILLER, string SA_RMRK_1, string SA_OP_CUST_NAME, string SA_AGT_CERT_TYP, string SA_AGT_CERT_ID, string SA_AGT_CUST_NAME, string SA_BELONG_INSTN_COD, string SA_CHANNEL_FLAG, string SA_PDP_CODE, string SA_OP_ACCT_NO_32, string SA_OP_BANK_NO, string SA_SUP_TLR, string SA_DB_PART_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CBOD_SAACNTXN ");
            strSql.Append(" where ETLDT=@ETLDT and SATXN_LL=@SATXN_LL and FK_SAACN_KEY=@FK_SAACN_KEY and SA_DDP_ACCT_NO_DET_N=@SA_DDP_ACCT_NO_DET_N and SATXN_DB_TIMESTAMP=@SATXN_DB_TIMESTAMP and SA_CURR_COD=@SA_CURR_COD and SA_OPR_NO=@SA_OPR_NO and SA_CURR_IDEN=@SA_CURR_IDEN and SA_EC_FLG=@SA_EC_FLG and SA_EC_DET_NO_N=@SA_EC_DET_NO_N and SA_CR_AMT=@SA_CR_AMT and SA_DDP_ACCT_BAL=@SA_DDP_ACCT_BAL and SA_TX_AMT=@SA_TX_AMT and SA_TX_CRD_NO=@SA_TX_CRD_NO and SA_TX_TYP=@SA_TX_TYP and SA_TX_LOG_NO=@SA_TX_LOG_NO and SA_DR_AMT=@SA_DR_AMT and SA_DOC_NO=@SA_DOC_NO and SA_DOC_TYP=@SA_DOC_TYP and SA_VAL_DT=@SA_VAL_DT and SA_SVC=@SA_SVC and SA_AUTH_NO=@SA_AUTH_NO and SA_CUST_DOCAG_STNO=@SA_CUST_DOCAG_STNO and SA_OPUN_COD=@SA_OPUN_COD and SA_DSCRP_COD=@SA_DSCRP_COD and SA_RMRK=@SA_RMRK and SA_TX_TM=@SA_TX_TM and SA_TX_DT=@SA_TX_DT and SA_SYS_DT=@SA_SYS_DT and SA_DDP_PDT=@SA_DDP_PDT and SA_APP_TX_CODE=@SA_APP_TX_CODE and SA_ETX_FLG=@SA_ETX_FLG and SA_OTX_FLG=@SA_OTX_FLG and SA_FLX_FLG=@SA_FLX_FLG and SA_GUIJI_FLAG=@SA_GUIJI_FLAG and SA_PRT_FLG=@SA_PRT_FLG and SA_FILLER=@SA_FILLER and SA_RMRK_1=@SA_RMRK_1 and SA_OP_CUST_NAME=@SA_OP_CUST_NAME and SA_AGT_CERT_TYP=@SA_AGT_CERT_TYP and SA_AGT_CERT_ID=@SA_AGT_CERT_ID and SA_AGT_CUST_NAME=@SA_AGT_CUST_NAME and SA_BELONG_INSTN_COD=@SA_BELONG_INSTN_COD and SA_CHANNEL_FLAG=@SA_CHANNEL_FLAG and SA_PDP_CODE=@SA_PDP_CODE and SA_OP_ACCT_NO_32=@SA_OP_ACCT_NO_32 and SA_OP_BANK_NO=@SA_OP_BANK_NO and SA_SUP_TLR=@SA_SUP_TLR and SA_DB_PART_ID=@SA_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@SATXN_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_SAACN_KEY", OleDbType.VarChar,28),
					new OleDbParameter("@SA_DDP_ACCT_NO_DET_N", OleDbType.Decimal),
					new OleDbParameter("@SATXN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@SA_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@SA_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@SA_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_DET_NO_N", OleDbType.Decimal),
					new OleDbParameter("@SA_CR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DDP_ACCT_BAL", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_TX_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_DR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DOC_NO", OleDbType.VarChar,16),
					new OleDbParameter("@SA_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@SA_VAL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SVC", OleDbType.Decimal),
					new OleDbParameter("@SA_AUTH_NO", OleDbType.VarChar,6),
					new OleDbParameter("@SA_CUST_DOCAG_STNO", OleDbType.VarChar,15),
					new OleDbParameter("@SA_OPUN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@SA_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@SA_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@SA_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SYS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_DDP_PDT", OleDbType.Decimal),
					new OleDbParameter("@SA_APP_TX_CODE", OleDbType.VarChar,4),
					new OleDbParameter("@SA_ETX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_OTX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FLX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_GUIJI_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FILLER", OleDbType.VarChar,1),
					new OleDbParameter("@SA_RMRK_1", OleDbType.VarChar,40),
					new OleDbParameter("@SA_OP_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@SA_AGT_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_AGT_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@SA_AGT_CUST_NAME", OleDbType.VarChar,60),
					new OleDbParameter("@SA_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_CHANNEL_FLAG", OleDbType.VarChar,2),
					new OleDbParameter("@SA_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@SA_OP_ACCT_NO_32", OleDbType.VarChar,32),
					new OleDbParameter("@SA_OP_BANK_NO", OleDbType.VarChar,9),
					new OleDbParameter("@SA_SUP_TLR", OleDbType.VarChar,12),
					new OleDbParameter("@SA_DB_PART_ID", OleDbType.VarChar,9)			};
            parameters[0].Value = ETLDT;
            parameters[1].Value = SATXN_LL;
            parameters[2].Value = FK_SAACN_KEY;
            parameters[3].Value = SA_DDP_ACCT_NO_DET_N;
            parameters[4].Value = SATXN_DB_TIMESTAMP;
            parameters[5].Value = SA_CURR_COD;
            parameters[6].Value = SA_OPR_NO;
            parameters[7].Value = SA_CURR_IDEN;
            parameters[8].Value = SA_EC_FLG;
            parameters[9].Value = SA_EC_DET_NO_N;
            parameters[10].Value = SA_CR_AMT;
            parameters[11].Value = SA_DDP_ACCT_BAL;
            parameters[12].Value = SA_TX_AMT;
            parameters[13].Value = SA_TX_CRD_NO;
            parameters[14].Value = SA_TX_TYP;
            parameters[15].Value = SA_TX_LOG_NO;
            parameters[16].Value = SA_DR_AMT;
            parameters[17].Value = SA_DOC_NO;
            parameters[18].Value = SA_DOC_TYP;
            parameters[19].Value = SA_VAL_DT;
            parameters[20].Value = SA_SVC;
            parameters[21].Value = SA_AUTH_NO;
            parameters[22].Value = SA_CUST_DOCAG_STNO;
            parameters[23].Value = SA_OPUN_COD;
            parameters[24].Value = SA_DSCRP_COD;
            parameters[25].Value = SA_RMRK;
            parameters[26].Value = SA_TX_TM;
            parameters[27].Value = SA_TX_DT;
            parameters[28].Value = SA_SYS_DT;
            parameters[29].Value = SA_DDP_PDT;
            parameters[30].Value = SA_APP_TX_CODE;
            parameters[31].Value = SA_ETX_FLG;
            parameters[32].Value = SA_OTX_FLG;
            parameters[33].Value = SA_FLX_FLG;
            parameters[34].Value = SA_GUIJI_FLAG;
            parameters[35].Value = SA_PRT_FLG;
            parameters[36].Value = SA_FILLER;
            parameters[37].Value = SA_RMRK_1;
            parameters[38].Value = SA_OP_CUST_NAME;
            parameters[39].Value = SA_AGT_CERT_TYP;
            parameters[40].Value = SA_AGT_CERT_ID;
            parameters[41].Value = SA_AGT_CUST_NAME;
            parameters[42].Value = SA_BELONG_INSTN_COD;
            parameters[43].Value = SA_CHANNEL_FLAG;
            parameters[44].Value = SA_PDP_CODE;
            parameters[45].Value = SA_OP_ACCT_NO_32;
            parameters[46].Value = SA_OP_BANK_NO;
            parameters[47].Value = SA_SUP_TLR;
            parameters[48].Value = SA_DB_PART_ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        public MZSYCORE.Model.Model_CBOD_SAACNTXN GetModel(string ETLDT, decimal SATXN_LL, string FK_SAACN_KEY, decimal SA_DDP_ACCT_NO_DET_N, decimal SATXN_DB_TIMESTAMP, string SA_CURR_COD, string SA_OPR_NO, string SA_CURR_IDEN, string SA_EC_FLG, decimal SA_EC_DET_NO_N, decimal SA_CR_AMT, decimal SA_DDP_ACCT_BAL, decimal SA_TX_AMT, string SA_TX_CRD_NO, string SA_TX_TYP, string SA_TX_LOG_NO, decimal SA_DR_AMT, string SA_DOC_NO, string SA_DOC_TYP, string SA_VAL_DT, decimal SA_SVC, string SA_AUTH_NO, string SA_CUST_DOCAG_STNO, string SA_OPUN_COD, string SA_DSCRP_COD, string SA_RMRK, string SA_TX_TM, string SA_TX_DT, string SA_SYS_DT, decimal SA_DDP_PDT, string SA_APP_TX_CODE, string SA_ETX_FLG, string SA_OTX_FLG, string SA_FLX_FLG, string SA_GUIJI_FLAG, string SA_PRT_FLG, string SA_FILLER, string SA_RMRK_1, string SA_OP_CUST_NAME, string SA_AGT_CERT_TYP, string SA_AGT_CERT_ID, string SA_AGT_CUST_NAME, string SA_BELONG_INSTN_COD, string SA_CHANNEL_FLAG, string SA_PDP_CODE, string SA_OP_ACCT_NO_32, string SA_OP_BANK_NO, string SA_SUP_TLR, string SA_DB_PART_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ETLDT,SATXN_LL,FK_SAACN_KEY,SA_DDP_ACCT_NO_DET_N,SATXN_DB_TIMESTAMP,SA_CURR_COD,SA_OPR_NO,SA_CURR_IDEN,SA_EC_FLG,SA_EC_DET_NO_N,SA_CR_AMT,SA_DDP_ACCT_BAL,SA_TX_AMT,SA_TX_CRD_NO,SA_TX_TYP,SA_TX_LOG_NO,SA_DR_AMT,SA_DOC_NO,SA_DOC_TYP,SA_VAL_DT,SA_SVC,SA_AUTH_NO,SA_CUST_DOCAG_STNO,SA_OPUN_COD,SA_DSCRP_COD,SA_RMRK,SA_TX_TM,SA_TX_DT,SA_SYS_DT,SA_DDP_PDT,SA_APP_TX_CODE,SA_ETX_FLG,SA_OTX_FLG,SA_FLX_FLG,SA_GUIJI_FLAG,SA_PRT_FLG,SA_FILLER,SA_RMRK_1,SA_OP_CUST_NAME,SA_AGT_CERT_TYP,SA_AGT_CERT_ID,SA_AGT_CUST_NAME,SA_BELONG_INSTN_COD,SA_CHANNEL_FLAG,SA_PDP_CODE,SA_OP_ACCT_NO_32,SA_OP_BANK_NO,SA_SUP_TLR,SA_DB_PART_ID from CBOD_SAACNTXN ");
            strSql.Append(" where ETLDT=@ETLDT and SATXN_LL=@SATXN_LL and FK_SAACN_KEY=@FK_SAACN_KEY and SA_DDP_ACCT_NO_DET_N=@SA_DDP_ACCT_NO_DET_N and SATXN_DB_TIMESTAMP=@SATXN_DB_TIMESTAMP and SA_CURR_COD=@SA_CURR_COD and SA_OPR_NO=@SA_OPR_NO and SA_CURR_IDEN=@SA_CURR_IDEN and SA_EC_FLG=@SA_EC_FLG and SA_EC_DET_NO_N=@SA_EC_DET_NO_N and SA_CR_AMT=@SA_CR_AMT and SA_DDP_ACCT_BAL=@SA_DDP_ACCT_BAL and SA_TX_AMT=@SA_TX_AMT and SA_TX_CRD_NO=@SA_TX_CRD_NO and SA_TX_TYP=@SA_TX_TYP and SA_TX_LOG_NO=@SA_TX_LOG_NO and SA_DR_AMT=@SA_DR_AMT and SA_DOC_NO=@SA_DOC_NO and SA_DOC_TYP=@SA_DOC_TYP and SA_VAL_DT=@SA_VAL_DT and SA_SVC=@SA_SVC and SA_AUTH_NO=@SA_AUTH_NO and SA_CUST_DOCAG_STNO=@SA_CUST_DOCAG_STNO and SA_OPUN_COD=@SA_OPUN_COD and SA_DSCRP_COD=@SA_DSCRP_COD and SA_RMRK=@SA_RMRK and SA_TX_TM=@SA_TX_TM and SA_TX_DT=@SA_TX_DT and SA_SYS_DT=@SA_SYS_DT and SA_DDP_PDT=@SA_DDP_PDT and SA_APP_TX_CODE=@SA_APP_TX_CODE and SA_ETX_FLG=@SA_ETX_FLG and SA_OTX_FLG=@SA_OTX_FLG and SA_FLX_FLG=@SA_FLX_FLG and SA_GUIJI_FLAG=@SA_GUIJI_FLAG and SA_PRT_FLG=@SA_PRT_FLG and SA_FILLER=@SA_FILLER and SA_RMRK_1=@SA_RMRK_1 and SA_OP_CUST_NAME=@SA_OP_CUST_NAME and SA_AGT_CERT_TYP=@SA_AGT_CERT_TYP and SA_AGT_CERT_ID=@SA_AGT_CERT_ID and SA_AGT_CUST_NAME=@SA_AGT_CUST_NAME and SA_BELONG_INSTN_COD=@SA_BELONG_INSTN_COD and SA_CHANNEL_FLAG=@SA_CHANNEL_FLAG and SA_PDP_CODE=@SA_PDP_CODE and SA_OP_ACCT_NO_32=@SA_OP_ACCT_NO_32 and SA_OP_BANK_NO=@SA_OP_BANK_NO and SA_SUP_TLR=@SA_SUP_TLR and SA_DB_PART_ID=@SA_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@SATXN_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_SAACN_KEY", OleDbType.VarChar,28),
					new OleDbParameter("@SA_DDP_ACCT_NO_DET_N", OleDbType.Decimal),
					new OleDbParameter("@SATXN_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@SA_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@SA_OPR_NO", OleDbType.VarChar,12),
					new OleDbParameter("@SA_CURR_IDEN", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_EC_DET_NO_N", OleDbType.Decimal),
					new OleDbParameter("@SA_CR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DDP_ACCT_BAL", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_TX_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_TX_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@SA_DR_AMT", OleDbType.Decimal),
					new OleDbParameter("@SA_DOC_NO", OleDbType.VarChar,16),
					new OleDbParameter("@SA_DOC_TYP", OleDbType.VarChar,4),
					new OleDbParameter("@SA_VAL_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SVC", OleDbType.Decimal),
					new OleDbParameter("@SA_AUTH_NO", OleDbType.VarChar,6),
					new OleDbParameter("@SA_CUST_DOCAG_STNO", OleDbType.VarChar,15),
					new OleDbParameter("@SA_OPUN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@SA_RMRK", OleDbType.VarChar,40),
					new OleDbParameter("@SA_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@SA_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_SYS_DT", OleDbType.VarChar,8),
					new OleDbParameter("@SA_DDP_PDT", OleDbType.Decimal),
					new OleDbParameter("@SA_APP_TX_CODE", OleDbType.VarChar,4),
					new OleDbParameter("@SA_ETX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_OTX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FLX_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_GUIJI_FLAG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_PRT_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@SA_FILLER", OleDbType.VarChar,1),
					new OleDbParameter("@SA_RMRK_1", OleDbType.VarChar,40),
					new OleDbParameter("@SA_OP_CUST_NAME", OleDbType.VarChar,122),
					new OleDbParameter("@SA_AGT_CERT_TYP", OleDbType.VarChar,1),
					new OleDbParameter("@SA_AGT_CERT_ID", OleDbType.VarChar,18),
					new OleDbParameter("@SA_AGT_CUST_NAME", OleDbType.VarChar,60),
					new OleDbParameter("@SA_BELONG_INSTN_COD", OleDbType.VarChar,9),
					new OleDbParameter("@SA_CHANNEL_FLAG", OleDbType.VarChar,2),
					new OleDbParameter("@SA_PDP_CODE", OleDbType.VarChar,11),
					new OleDbParameter("@SA_OP_ACCT_NO_32", OleDbType.VarChar,32),
					new OleDbParameter("@SA_OP_BANK_NO", OleDbType.VarChar,9),
					new OleDbParameter("@SA_SUP_TLR", OleDbType.VarChar,12),
					new OleDbParameter("@SA_DB_PART_ID", OleDbType.VarChar,9)			};
            parameters[0].Value = ETLDT;
            parameters[1].Value = SATXN_LL;
            parameters[2].Value = FK_SAACN_KEY;
            parameters[3].Value = SA_DDP_ACCT_NO_DET_N;
            parameters[4].Value = SATXN_DB_TIMESTAMP;
            parameters[5].Value = SA_CURR_COD;
            parameters[6].Value = SA_OPR_NO;
            parameters[7].Value = SA_CURR_IDEN;
            parameters[8].Value = SA_EC_FLG;
            parameters[9].Value = SA_EC_DET_NO_N;
            parameters[10].Value = SA_CR_AMT;
            parameters[11].Value = SA_DDP_ACCT_BAL;
            parameters[12].Value = SA_TX_AMT;
            parameters[13].Value = SA_TX_CRD_NO;
            parameters[14].Value = SA_TX_TYP;
            parameters[15].Value = SA_TX_LOG_NO;
            parameters[16].Value = SA_DR_AMT;
            parameters[17].Value = SA_DOC_NO;
            parameters[18].Value = SA_DOC_TYP;
            parameters[19].Value = SA_VAL_DT;
            parameters[20].Value = SA_SVC;
            parameters[21].Value = SA_AUTH_NO;
            parameters[22].Value = SA_CUST_DOCAG_STNO;
            parameters[23].Value = SA_OPUN_COD;
            parameters[24].Value = SA_DSCRP_COD;
            parameters[25].Value = SA_RMRK;
            parameters[26].Value = SA_TX_TM;
            parameters[27].Value = SA_TX_DT;
            parameters[28].Value = SA_SYS_DT;
            parameters[29].Value = SA_DDP_PDT;
            parameters[30].Value = SA_APP_TX_CODE;
            parameters[31].Value = SA_ETX_FLG;
            parameters[32].Value = SA_OTX_FLG;
            parameters[33].Value = SA_FLX_FLG;
            parameters[34].Value = SA_GUIJI_FLAG;
            parameters[35].Value = SA_PRT_FLG;
            parameters[36].Value = SA_FILLER;
            parameters[37].Value = SA_RMRK_1;
            parameters[38].Value = SA_OP_CUST_NAME;
            parameters[39].Value = SA_AGT_CERT_TYP;
            parameters[40].Value = SA_AGT_CERT_ID;
            parameters[41].Value = SA_AGT_CUST_NAME;
            parameters[42].Value = SA_BELONG_INSTN_COD;
            parameters[43].Value = SA_CHANNEL_FLAG;
            parameters[44].Value = SA_PDP_CODE;
            parameters[45].Value = SA_OP_ACCT_NO_32;
            parameters[46].Value = SA_OP_BANK_NO;
            parameters[47].Value = SA_SUP_TLR;
            parameters[48].Value = SA_DB_PART_ID;

            MZSYCORE.Model.Model_CBOD_SAACNTXN model = new MZSYCORE.Model.Model_CBOD_SAACNTXN();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public MZSYCORE.Model.Model_CBOD_SAACNTXN DataRowToModel(DataRow row)
        {
            MZSYCORE.Model.Model_CBOD_SAACNTXN model = new MZSYCORE.Model.Model_CBOD_SAACNTXN();
            if (row != null)
            {
                if (row["ETLDT"] != null)
                {
                    model.ETLDT = row["ETLDT"].ToString();
                }
                if (row["SATXN_LL"] != null && row["SATXN_LL"].ToString() != "")
                {
                    model.SATXN_LL = decimal.Parse(row["SATXN_LL"].ToString());
                }
                if (row["FK_SAACN_KEY"] != null)
                {
                    model.FK_SAACN_KEY = row["FK_SAACN_KEY"].ToString();
                }
                if (row["SA_DDP_ACCT_NO_DET_N"] != null && row["SA_DDP_ACCT_NO_DET_N"].ToString() != "")
                {
                    model.SA_DDP_ACCT_NO_DET_N = decimal.Parse(row["SA_DDP_ACCT_NO_DET_N"].ToString());
                }
                if (row["SATXN_DB_TIMESTAMP"] != null && row["SATXN_DB_TIMESTAMP"].ToString() != "")
                {
                    model.SATXN_DB_TIMESTAMP = decimal.Parse(row["SATXN_DB_TIMESTAMP"].ToString());
                }
                if (row["SA_CURR_COD"] != null)
                {
                    model.SA_CURR_COD = row["SA_CURR_COD"].ToString();
                }
                if (row["SA_OPR_NO"] != null)
                {
                    model.SA_OPR_NO = row["SA_OPR_NO"].ToString();
                }
                if (row["SA_CURR_IDEN"] != null)
                {
                    model.SA_CURR_IDEN = row["SA_CURR_IDEN"].ToString();
                }
                if (row["SA_EC_FLG"] != null)
                {
                    model.SA_EC_FLG = row["SA_EC_FLG"].ToString();
                }
                if (row["SA_EC_DET_NO_N"] != null && row["SA_EC_DET_NO_N"].ToString() != "")
                {
                    model.SA_EC_DET_NO_N = decimal.Parse(row["SA_EC_DET_NO_N"].ToString());
                }
                if (row["SA_CR_AMT"] != null && row["SA_CR_AMT"].ToString() != "")
                {
                    model.SA_CR_AMT = decimal.Parse(row["SA_CR_AMT"].ToString());
                }
                if (row["SA_DDP_ACCT_BAL"] != null && row["SA_DDP_ACCT_BAL"].ToString() != "")
                {
                    model.SA_DDP_ACCT_BAL = decimal.Parse(row["SA_DDP_ACCT_BAL"].ToString());
                }
                if (row["SA_TX_AMT"] != null && row["SA_TX_AMT"].ToString() != "")
                {
                    model.SA_TX_AMT = decimal.Parse(row["SA_TX_AMT"].ToString());
                }
                if (row["SA_TX_CRD_NO"] != null)
                {
                    model.SA_TX_CRD_NO = row["SA_TX_CRD_NO"].ToString();
                }
                if (row["SA_TX_TYP"] != null)
                {
                    model.SA_TX_TYP = row["SA_TX_TYP"].ToString();
                }
                if (row["SA_TX_LOG_NO"] != null)
                {
                    model.SA_TX_LOG_NO = row["SA_TX_LOG_NO"].ToString();
                }
                if (row["SA_DR_AMT"] != null && row["SA_DR_AMT"].ToString() != "")
                {
                    model.SA_DR_AMT = decimal.Parse(row["SA_DR_AMT"].ToString());
                }
                if (row["SA_DOC_NO"] != null)
                {
                    model.SA_DOC_NO = row["SA_DOC_NO"].ToString();
                }
                if (row["SA_DOC_TYP"] != null)
                {
                    model.SA_DOC_TYP = row["SA_DOC_TYP"].ToString();
                }
                if (row["SA_VAL_DT"] != null)
                {
                    model.SA_VAL_DT = row["SA_VAL_DT"].ToString();
                }
                if (row["SA_SVC"] != null && row["SA_SVC"].ToString() != "")
                {
                    model.SA_SVC = decimal.Parse(row["SA_SVC"].ToString());
                }
                if (row["SA_AUTH_NO"] != null)
                {
                    model.SA_AUTH_NO = row["SA_AUTH_NO"].ToString();
                }
                if (row["SA_CUST_DOCAG_STNO"] != null)
                {
                    model.SA_CUST_DOCAG_STNO = row["SA_CUST_DOCAG_STNO"].ToString();
                }
                if (row["SA_OPUN_COD"] != null)
                {
                    model.SA_OPUN_COD = row["SA_OPUN_COD"].ToString();
                }
                if (row["SA_DSCRP_COD"] != null)
                {
                    model.SA_DSCRP_COD = row["SA_DSCRP_COD"].ToString();
                }
                if (row["SA_RMRK"] != null)
                {
                    model.SA_RMRK = row["SA_RMRK"].ToString();
                }
                if (row["SA_TX_TM"] != null)
                {
                    model.SA_TX_TM = row["SA_TX_TM"].ToString();
                }
                if (row["SA_TX_DT"] != null)
                {
                    model.SA_TX_DT = row["SA_TX_DT"].ToString();
                }
                if (row["SA_SYS_DT"] != null)
                {
                    model.SA_SYS_DT = row["SA_SYS_DT"].ToString();
                }
                if (row["SA_DDP_PDT"] != null && row["SA_DDP_PDT"].ToString() != "")
                {
                    model.SA_DDP_PDT = decimal.Parse(row["SA_DDP_PDT"].ToString());
                }
                if (row["SA_APP_TX_CODE"] != null)
                {
                    model.SA_APP_TX_CODE = row["SA_APP_TX_CODE"].ToString();
                }
                if (row["SA_ETX_FLG"] != null)
                {
                    model.SA_ETX_FLG = row["SA_ETX_FLG"].ToString();
                }
                if (row["SA_OTX_FLG"] != null)
                {
                    model.SA_OTX_FLG = row["SA_OTX_FLG"].ToString();
                }
                if (row["SA_FLX_FLG"] != null)
                {
                    model.SA_FLX_FLG = row["SA_FLX_FLG"].ToString();
                }
                if (row["SA_GUIJI_FLAG"] != null)
                {
                    model.SA_GUIJI_FLAG = row["SA_GUIJI_FLAG"].ToString();
                }
                if (row["SA_PRT_FLG"] != null)
                {
                    model.SA_PRT_FLG = row["SA_PRT_FLG"].ToString();
                }
                if (row["SA_FILLER"] != null)
                {
                    model.SA_FILLER = row["SA_FILLER"].ToString();
                }
                if (row["SA_RMRK_1"] != null)
                {
                    model.SA_RMRK_1 = row["SA_RMRK_1"].ToString();
                }
                if (row["SA_OP_CUST_NAME"] != null)
                {
                    model.SA_OP_CUST_NAME = row["SA_OP_CUST_NAME"].ToString();
                }
                if (row["SA_AGT_CERT_TYP"] != null)
                {
                    model.SA_AGT_CERT_TYP = row["SA_AGT_CERT_TYP"].ToString();
                }
                if (row["SA_AGT_CERT_ID"] != null)
                {
                    model.SA_AGT_CERT_ID = row["SA_AGT_CERT_ID"].ToString();
                }
                if (row["SA_AGT_CUST_NAME"] != null)
                {
                    model.SA_AGT_CUST_NAME = row["SA_AGT_CUST_NAME"].ToString();
                }
                if (row["SA_BELONG_INSTN_COD"] != null)
                {
                    model.SA_BELONG_INSTN_COD = row["SA_BELONG_INSTN_COD"].ToString();
                }
                if (row["SA_CHANNEL_FLAG"] != null)
                {
                    model.SA_CHANNEL_FLAG = row["SA_CHANNEL_FLAG"].ToString();
                }
                if (row["SA_PDP_CODE"] != null)
                {
                    model.SA_PDP_CODE = row["SA_PDP_CODE"].ToString();
                }
                if (row["SA_OP_ACCT_NO_32"] != null)
                {
                    model.SA_OP_ACCT_NO_32 = row["SA_OP_ACCT_NO_32"].ToString();
                }
                if (row["SA_OP_BANK_NO"] != null)
                {
                    model.SA_OP_BANK_NO = row["SA_OP_BANK_NO"].ToString();
                }
                if (row["SA_SUP_TLR"] != null)
                {
                    model.SA_SUP_TLR = row["SA_SUP_TLR"].ToString();
                }
                if (row["SA_DB_PART_ID"] != null)
                {
                    model.SA_DB_PART_ID = row["SA_DB_PART_ID"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ETLDT,SATXN_LL,FK_SAACN_KEY,SA_DDP_ACCT_NO_DET_N,SATXN_DB_TIMESTAMP,SA_CURR_COD,SA_OPR_NO,SA_CURR_IDEN,SA_EC_FLG,SA_EC_DET_NO_N,SA_CR_AMT,SA_DDP_ACCT_BAL,SA_TX_AMT,SA_TX_CRD_NO,SA_TX_TYP,SA_TX_LOG_NO,SA_DR_AMT,SA_DOC_NO,SA_DOC_TYP,SA_VAL_DT,SA_SVC,SA_AUTH_NO,SA_CUST_DOCAG_STNO,SA_OPUN_COD,SA_DSCRP_COD,SA_RMRK,SA_TX_TM,SA_TX_DT,SA_SYS_DT,SA_DDP_PDT,SA_APP_TX_CODE,SA_ETX_FLG,SA_OTX_FLG,SA_FLX_FLG,SA_GUIJI_FLAG,SA_PRT_FLG,SA_FILLER,SA_RMRK_1,SA_OP_CUST_NAME,SA_AGT_CERT_TYP,SA_AGT_CERT_ID,SA_AGT_CUST_NAME,SA_BELONG_INSTN_COD,SA_CHANNEL_FLAG,SA_PDP_CODE,SA_OP_ACCT_NO_32,SA_OP_BANK_NO,SA_SUP_TLR,SA_DB_PART_ID ");
            strSql.Append(" FROM jsrun.CBOD_SAACNTXN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CBOD_SAACNTXN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.SA_DB_PART_ID desc");
            }
            strSql.Append(")AS Row, T.*  from CBOD_SAACNTXN T ");
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
            parameters[0].Value = "CBOD_SAACNTXN";
            parameters[1].Value = "SA_DB_PART_ID";
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
