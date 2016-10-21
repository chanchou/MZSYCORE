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
    /// 数据访问类:DAL_CBOD_CRATMDET
    /// </summary>
    public partial class DAL_CBOD_CRATMDET
    {
        public DAL_CBOD_CRATMDET()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ETLDT, decimal CRDET_LL, string FK_CRATM_KEY, string CR_TX_DT, string CR_ATM_TX_SQ_NO, decimal CRDET_DB_TIMESTAMP, string CR_BELONGTO_BRH, string CR_RSV_FLG, string CR_CURR_COD, string CR_EC_FLG, string CR_OPR_EC, string CR_ENTR_DT, string CR_TX_NO, decimal CR_TX_AMT, string CR_TX_LOG_NO, string CR_TX_TM, string CR_TX_NETP_NO, string CR_CRD_NO, string CR_CPU_DT, string CR_GCRD_TX_SQ_NO, string CR_DRGN_CRD_TX_SQ_NO, string CR_CONF_FLG, string CR_DSCRP_COD, string CR_TRNI_SAV_NO, string CR_TRNO_SAV_NO, decimal CR_PSBK_SQ_NO_N, string CR_DB_PART_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CBOD_CRATMDET");
            strSql.Append(" where ETLDT=@ETLDT and CRDET_LL=@CRDET_LL and FK_CRATM_KEY=@FK_CRATM_KEY and CR_TX_DT=@CR_TX_DT and CR_ATM_TX_SQ_NO=@CR_ATM_TX_SQ_NO and CRDET_DB_TIMESTAMP=@CRDET_DB_TIMESTAMP and CR_BELONGTO_BRH=@CR_BELONGTO_BRH and CR_RSV_FLG=@CR_RSV_FLG and CR_CURR_COD=@CR_CURR_COD and CR_EC_FLG=@CR_EC_FLG and CR_OPR_EC=@CR_OPR_EC and CR_ENTR_DT=@CR_ENTR_DT and CR_TX_NO=@CR_TX_NO and CR_TX_AMT=@CR_TX_AMT and CR_TX_LOG_NO=@CR_TX_LOG_NO and CR_TX_TM=@CR_TX_TM and CR_TX_NETP_NO=@CR_TX_NETP_NO and CR_CRD_NO=@CR_CRD_NO and CR_CPU_DT=@CR_CPU_DT and CR_GCRD_TX_SQ_NO=@CR_GCRD_TX_SQ_NO and CR_DRGN_CRD_TX_SQ_NO=@CR_DRGN_CRD_TX_SQ_NO and CR_CONF_FLG=@CR_CONF_FLG and CR_DSCRP_COD=@CR_DSCRP_COD and CR_TRNI_SAV_NO=@CR_TRNI_SAV_NO and CR_TRNO_SAV_NO=@CR_TRNO_SAV_NO and CR_PSBK_SQ_NO_N=@CR_PSBK_SQ_NO_N and CR_DB_PART_ID=@CR_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@CRDET_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_CRATM_KEY", OleDbType.VarChar,12),
					new OleDbParameter("@CR_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_ATM_TX_SQ_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CRDET_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@CR_BELONGTO_BRH", OleDbType.VarChar,9),
					new OleDbParameter("@CR_RSV_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@CR_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_OPR_EC", OleDbType.VarChar,12),
					new OleDbParameter("@CR_ENTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_TX_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@CR_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_NETP_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_CPU_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_GCRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_DRGN_CRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_CONF_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@CR_TRNI_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_TRNO_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@CR_DB_PART_ID", OleDbType.VarChar,9)			};
            parameters[0].Value = ETLDT;
            parameters[1].Value = CRDET_LL;
            parameters[2].Value = FK_CRATM_KEY;
            parameters[3].Value = CR_TX_DT;
            parameters[4].Value = CR_ATM_TX_SQ_NO;
            parameters[5].Value = CRDET_DB_TIMESTAMP;
            parameters[6].Value = CR_BELONGTO_BRH;
            parameters[7].Value = CR_RSV_FLG;
            parameters[8].Value = CR_CURR_COD;
            parameters[9].Value = CR_EC_FLG;
            parameters[10].Value = CR_OPR_EC;
            parameters[11].Value = CR_ENTR_DT;
            parameters[12].Value = CR_TX_NO;
            parameters[13].Value = CR_TX_AMT;
            parameters[14].Value = CR_TX_LOG_NO;
            parameters[15].Value = CR_TX_TM;
            parameters[16].Value = CR_TX_NETP_NO;
            parameters[17].Value = CR_CRD_NO;
            parameters[18].Value = CR_CPU_DT;
            parameters[19].Value = CR_GCRD_TX_SQ_NO;
            parameters[20].Value = CR_DRGN_CRD_TX_SQ_NO;
            parameters[21].Value = CR_CONF_FLG;
            parameters[22].Value = CR_DSCRP_COD;
            parameters[23].Value = CR_TRNI_SAV_NO;
            parameters[24].Value = CR_TRNO_SAV_NO;
            parameters[25].Value = CR_PSBK_SQ_NO_N;
            parameters[26].Value = CR_DB_PART_ID;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MZSYCORE.Model.Model_CBOD_CRATMDET model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CBOD_CRATMDET(");
            strSql.Append("ETLDT,CRDET_LL,FK_CRATM_KEY,CR_TX_DT,CR_ATM_TX_SQ_NO,CRDET_DB_TIMESTAMP,CR_BELONGTO_BRH,CR_RSV_FLG,CR_CURR_COD,CR_EC_FLG,CR_OPR_EC,CR_ENTR_DT,CR_TX_NO,CR_TX_AMT,CR_TX_LOG_NO,CR_TX_TM,CR_TX_NETP_NO,CR_CRD_NO,CR_CPU_DT,CR_GCRD_TX_SQ_NO,CR_DRGN_CRD_TX_SQ_NO,CR_CONF_FLG,CR_DSCRP_COD,CR_TRNI_SAV_NO,CR_TRNO_SAV_NO,CR_PSBK_SQ_NO_N,CR_DB_PART_ID)");
            strSql.Append(" values (");
            strSql.Append("@ETLDT,@CRDET_LL,@FK_CRATM_KEY,@CR_TX_DT,@CR_ATM_TX_SQ_NO,@CRDET_DB_TIMESTAMP,@CR_BELONGTO_BRH,@CR_RSV_FLG,@CR_CURR_COD,@CR_EC_FLG,@CR_OPR_EC,@CR_ENTR_DT,@CR_TX_NO,@CR_TX_AMT,@CR_TX_LOG_NO,@CR_TX_TM,@CR_TX_NETP_NO,@CR_CRD_NO,@CR_CPU_DT,@CR_GCRD_TX_SQ_NO,@CR_DRGN_CRD_TX_SQ_NO,@CR_CONF_FLG,@CR_DSCRP_COD,@CR_TRNI_SAV_NO,@CR_TRNO_SAV_NO,@CR_PSBK_SQ_NO_N,@CR_DB_PART_ID)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@CRDET_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_CRATM_KEY", OleDbType.VarChar,12),
					new OleDbParameter("@CR_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_ATM_TX_SQ_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CRDET_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@CR_BELONGTO_BRH", OleDbType.VarChar,9),
					new OleDbParameter("@CR_RSV_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@CR_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_OPR_EC", OleDbType.VarChar,12),
					new OleDbParameter("@CR_ENTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_TX_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@CR_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_NETP_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_CPU_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_GCRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_DRGN_CRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_CONF_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@CR_TRNI_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_TRNO_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@CR_DB_PART_ID", OleDbType.VarChar,9)};
            parameters[0].Value = model.ETLDT;
            parameters[1].Value = model.CRDET_LL;
            parameters[2].Value = model.FK_CRATM_KEY;
            parameters[3].Value = model.CR_TX_DT;
            parameters[4].Value = model.CR_ATM_TX_SQ_NO;
            parameters[5].Value = model.CRDET_DB_TIMESTAMP;
            parameters[6].Value = model.CR_BELONGTO_BRH;
            parameters[7].Value = model.CR_RSV_FLG;
            parameters[8].Value = model.CR_CURR_COD;
            parameters[9].Value = model.CR_EC_FLG;
            parameters[10].Value = model.CR_OPR_EC;
            parameters[11].Value = model.CR_ENTR_DT;
            parameters[12].Value = model.CR_TX_NO;
            parameters[13].Value = model.CR_TX_AMT;
            parameters[14].Value = model.CR_TX_LOG_NO;
            parameters[15].Value = model.CR_TX_TM;
            parameters[16].Value = model.CR_TX_NETP_NO;
            parameters[17].Value = model.CR_CRD_NO;
            parameters[18].Value = model.CR_CPU_DT;
            parameters[19].Value = model.CR_GCRD_TX_SQ_NO;
            parameters[20].Value = model.CR_DRGN_CRD_TX_SQ_NO;
            parameters[21].Value = model.CR_CONF_FLG;
            parameters[22].Value = model.CR_DSCRP_COD;
            parameters[23].Value = model.CR_TRNI_SAV_NO;
            parameters[24].Value = model.CR_TRNO_SAV_NO;
            parameters[25].Value = model.CR_PSBK_SQ_NO_N;
            parameters[26].Value = model.CR_DB_PART_ID;

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
        public bool Update(MZSYCORE.Model.Model_CBOD_CRATMDET model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CBOD_CRATMDET set ");
            strSql.Append("ETLDT=@ETLDT,");
            strSql.Append("CRDET_LL=@CRDET_LL,");
            strSql.Append("FK_CRATM_KEY=@FK_CRATM_KEY,");
            strSql.Append("CR_TX_DT=@CR_TX_DT,");
            strSql.Append("CR_ATM_TX_SQ_NO=@CR_ATM_TX_SQ_NO,");
            strSql.Append("CRDET_DB_TIMESTAMP=@CRDET_DB_TIMESTAMP,");
            strSql.Append("CR_BELONGTO_BRH=@CR_BELONGTO_BRH,");
            strSql.Append("CR_RSV_FLG=@CR_RSV_FLG,");
            strSql.Append("CR_CURR_COD=@CR_CURR_COD,");
            strSql.Append("CR_EC_FLG=@CR_EC_FLG,");
            strSql.Append("CR_OPR_EC=@CR_OPR_EC,");
            strSql.Append("CR_ENTR_DT=@CR_ENTR_DT,");
            strSql.Append("CR_TX_NO=@CR_TX_NO,");
            strSql.Append("CR_TX_AMT=@CR_TX_AMT,");
            strSql.Append("CR_TX_LOG_NO=@CR_TX_LOG_NO,");
            strSql.Append("CR_TX_TM=@CR_TX_TM,");
            strSql.Append("CR_TX_NETP_NO=@CR_TX_NETP_NO,");
            strSql.Append("CR_CRD_NO=@CR_CRD_NO,");
            strSql.Append("CR_CPU_DT=@CR_CPU_DT,");
            strSql.Append("CR_GCRD_TX_SQ_NO=@CR_GCRD_TX_SQ_NO,");
            strSql.Append("CR_DRGN_CRD_TX_SQ_NO=@CR_DRGN_CRD_TX_SQ_NO,");
            strSql.Append("CR_CONF_FLG=@CR_CONF_FLG,");
            strSql.Append("CR_DSCRP_COD=@CR_DSCRP_COD,");
            strSql.Append("CR_TRNI_SAV_NO=@CR_TRNI_SAV_NO,");
            strSql.Append("CR_TRNO_SAV_NO=@CR_TRNO_SAV_NO,");
            strSql.Append("CR_PSBK_SQ_NO_N=@CR_PSBK_SQ_NO_N,");
            strSql.Append("CR_DB_PART_ID=@CR_DB_PART_ID");
            strSql.Append(" where ETLDT=@ETLDT and CRDET_LL=@CRDET_LL and FK_CRATM_KEY=@FK_CRATM_KEY and CR_TX_DT=@CR_TX_DT and CR_ATM_TX_SQ_NO=@CR_ATM_TX_SQ_NO and CRDET_DB_TIMESTAMP=@CRDET_DB_TIMESTAMP and CR_BELONGTO_BRH=@CR_BELONGTO_BRH and CR_RSV_FLG=@CR_RSV_FLG and CR_CURR_COD=@CR_CURR_COD and CR_EC_FLG=@CR_EC_FLG and CR_OPR_EC=@CR_OPR_EC and CR_ENTR_DT=@CR_ENTR_DT and CR_TX_NO=@CR_TX_NO and CR_TX_AMT=@CR_TX_AMT and CR_TX_LOG_NO=@CR_TX_LOG_NO and CR_TX_TM=@CR_TX_TM and CR_TX_NETP_NO=@CR_TX_NETP_NO and CR_CRD_NO=@CR_CRD_NO and CR_CPU_DT=@CR_CPU_DT and CR_GCRD_TX_SQ_NO=@CR_GCRD_TX_SQ_NO and CR_DRGN_CRD_TX_SQ_NO=@CR_DRGN_CRD_TX_SQ_NO and CR_CONF_FLG=@CR_CONF_FLG and CR_DSCRP_COD=@CR_DSCRP_COD and CR_TRNI_SAV_NO=@CR_TRNI_SAV_NO and CR_TRNO_SAV_NO=@CR_TRNO_SAV_NO and CR_PSBK_SQ_NO_N=@CR_PSBK_SQ_NO_N and CR_DB_PART_ID=@CR_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@CRDET_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_CRATM_KEY", OleDbType.VarChar,12),
					new OleDbParameter("@CR_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_ATM_TX_SQ_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CRDET_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@CR_BELONGTO_BRH", OleDbType.VarChar,9),
					new OleDbParameter("@CR_RSV_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@CR_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_OPR_EC", OleDbType.VarChar,12),
					new OleDbParameter("@CR_ENTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_TX_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@CR_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_NETP_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_CPU_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_GCRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_DRGN_CRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_CONF_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@CR_TRNI_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_TRNO_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@CR_DB_PART_ID", OleDbType.VarChar,9)};
            parameters[0].Value = model.ETLDT;
            parameters[1].Value = model.CRDET_LL;
            parameters[2].Value = model.FK_CRATM_KEY;
            parameters[3].Value = model.CR_TX_DT;
            parameters[4].Value = model.CR_ATM_TX_SQ_NO;
            parameters[5].Value = model.CRDET_DB_TIMESTAMP;
            parameters[6].Value = model.CR_BELONGTO_BRH;
            parameters[7].Value = model.CR_RSV_FLG;
            parameters[8].Value = model.CR_CURR_COD;
            parameters[9].Value = model.CR_EC_FLG;
            parameters[10].Value = model.CR_OPR_EC;
            parameters[11].Value = model.CR_ENTR_DT;
            parameters[12].Value = model.CR_TX_NO;
            parameters[13].Value = model.CR_TX_AMT;
            parameters[14].Value = model.CR_TX_LOG_NO;
            parameters[15].Value = model.CR_TX_TM;
            parameters[16].Value = model.CR_TX_NETP_NO;
            parameters[17].Value = model.CR_CRD_NO;
            parameters[18].Value = model.CR_CPU_DT;
            parameters[19].Value = model.CR_GCRD_TX_SQ_NO;
            parameters[20].Value = model.CR_DRGN_CRD_TX_SQ_NO;
            parameters[21].Value = model.CR_CONF_FLG;
            parameters[22].Value = model.CR_DSCRP_COD;
            parameters[23].Value = model.CR_TRNI_SAV_NO;
            parameters[24].Value = model.CR_TRNO_SAV_NO;
            parameters[25].Value = model.CR_PSBK_SQ_NO_N;
            parameters[26].Value = model.CR_DB_PART_ID;

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
        public bool Delete(string ETLDT, decimal CRDET_LL, string FK_CRATM_KEY, string CR_TX_DT, string CR_ATM_TX_SQ_NO, decimal CRDET_DB_TIMESTAMP, string CR_BELONGTO_BRH, string CR_RSV_FLG, string CR_CURR_COD, string CR_EC_FLG, string CR_OPR_EC, string CR_ENTR_DT, string CR_TX_NO, decimal CR_TX_AMT, string CR_TX_LOG_NO, string CR_TX_TM, string CR_TX_NETP_NO, string CR_CRD_NO, string CR_CPU_DT, string CR_GCRD_TX_SQ_NO, string CR_DRGN_CRD_TX_SQ_NO, string CR_CONF_FLG, string CR_DSCRP_COD, string CR_TRNI_SAV_NO, string CR_TRNO_SAV_NO, decimal CR_PSBK_SQ_NO_N, string CR_DB_PART_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CBOD_CRATMDET ");
            strSql.Append(" where ETLDT=@ETLDT and CRDET_LL=@CRDET_LL and FK_CRATM_KEY=@FK_CRATM_KEY and CR_TX_DT=@CR_TX_DT and CR_ATM_TX_SQ_NO=@CR_ATM_TX_SQ_NO and CRDET_DB_TIMESTAMP=@CRDET_DB_TIMESTAMP and CR_BELONGTO_BRH=@CR_BELONGTO_BRH and CR_RSV_FLG=@CR_RSV_FLG and CR_CURR_COD=@CR_CURR_COD and CR_EC_FLG=@CR_EC_FLG and CR_OPR_EC=@CR_OPR_EC and CR_ENTR_DT=@CR_ENTR_DT and CR_TX_NO=@CR_TX_NO and CR_TX_AMT=@CR_TX_AMT and CR_TX_LOG_NO=@CR_TX_LOG_NO and CR_TX_TM=@CR_TX_TM and CR_TX_NETP_NO=@CR_TX_NETP_NO and CR_CRD_NO=@CR_CRD_NO and CR_CPU_DT=@CR_CPU_DT and CR_GCRD_TX_SQ_NO=@CR_GCRD_TX_SQ_NO and CR_DRGN_CRD_TX_SQ_NO=@CR_DRGN_CRD_TX_SQ_NO and CR_CONF_FLG=@CR_CONF_FLG and CR_DSCRP_COD=@CR_DSCRP_COD and CR_TRNI_SAV_NO=@CR_TRNI_SAV_NO and CR_TRNO_SAV_NO=@CR_TRNO_SAV_NO and CR_PSBK_SQ_NO_N=@CR_PSBK_SQ_NO_N and CR_DB_PART_ID=@CR_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@CRDET_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_CRATM_KEY", OleDbType.VarChar,12),
					new OleDbParameter("@CR_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_ATM_TX_SQ_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CRDET_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@CR_BELONGTO_BRH", OleDbType.VarChar,9),
					new OleDbParameter("@CR_RSV_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@CR_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_OPR_EC", OleDbType.VarChar,12),
					new OleDbParameter("@CR_ENTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_TX_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@CR_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_NETP_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_CPU_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_GCRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_DRGN_CRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_CONF_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@CR_TRNI_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_TRNO_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@CR_DB_PART_ID", OleDbType.VarChar,9)			};
            parameters[0].Value = ETLDT;
            parameters[1].Value = CRDET_LL;
            parameters[2].Value = FK_CRATM_KEY;
            parameters[3].Value = CR_TX_DT;
            parameters[4].Value = CR_ATM_TX_SQ_NO;
            parameters[5].Value = CRDET_DB_TIMESTAMP;
            parameters[6].Value = CR_BELONGTO_BRH;
            parameters[7].Value = CR_RSV_FLG;
            parameters[8].Value = CR_CURR_COD;
            parameters[9].Value = CR_EC_FLG;
            parameters[10].Value = CR_OPR_EC;
            parameters[11].Value = CR_ENTR_DT;
            parameters[12].Value = CR_TX_NO;
            parameters[13].Value = CR_TX_AMT;
            parameters[14].Value = CR_TX_LOG_NO;
            parameters[15].Value = CR_TX_TM;
            parameters[16].Value = CR_TX_NETP_NO;
            parameters[17].Value = CR_CRD_NO;
            parameters[18].Value = CR_CPU_DT;
            parameters[19].Value = CR_GCRD_TX_SQ_NO;
            parameters[20].Value = CR_DRGN_CRD_TX_SQ_NO;
            parameters[21].Value = CR_CONF_FLG;
            parameters[22].Value = CR_DSCRP_COD;
            parameters[23].Value = CR_TRNI_SAV_NO;
            parameters[24].Value = CR_TRNO_SAV_NO;
            parameters[25].Value = CR_PSBK_SQ_NO_N;
            parameters[26].Value = CR_DB_PART_ID;

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
        public MZSYCORE.Model.Model_CBOD_CRATMDET GetModel(string ETLDT, decimal CRDET_LL, string FK_CRATM_KEY, string CR_TX_DT, string CR_ATM_TX_SQ_NO, decimal CRDET_DB_TIMESTAMP, string CR_BELONGTO_BRH, string CR_RSV_FLG, string CR_CURR_COD, string CR_EC_FLG, string CR_OPR_EC, string CR_ENTR_DT, string CR_TX_NO, decimal CR_TX_AMT, string CR_TX_LOG_NO, string CR_TX_TM, string CR_TX_NETP_NO, string CR_CRD_NO, string CR_CPU_DT, string CR_GCRD_TX_SQ_NO, string CR_DRGN_CRD_TX_SQ_NO, string CR_CONF_FLG, string CR_DSCRP_COD, string CR_TRNI_SAV_NO, string CR_TRNO_SAV_NO, decimal CR_PSBK_SQ_NO_N, string CR_DB_PART_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ETLDT,CRDET_LL,FK_CRATM_KEY,CR_TX_DT,CR_ATM_TX_SQ_NO,CRDET_DB_TIMESTAMP,CR_BELONGTO_BRH,CR_RSV_FLG,CR_CURR_COD,CR_EC_FLG,CR_OPR_EC,CR_ENTR_DT,CR_TX_NO,CR_TX_AMT,CR_TX_LOG_NO,CR_TX_TM,CR_TX_NETP_NO,CR_CRD_NO,CR_CPU_DT,CR_GCRD_TX_SQ_NO,CR_DRGN_CRD_TX_SQ_NO,CR_CONF_FLG,CR_DSCRP_COD,CR_TRNI_SAV_NO,CR_TRNO_SAV_NO,CR_PSBK_SQ_NO_N,CR_DB_PART_ID from CBOD_CRATMDET ");
            strSql.Append(" where ETLDT=@ETLDT and CRDET_LL=@CRDET_LL and FK_CRATM_KEY=@FK_CRATM_KEY and CR_TX_DT=@CR_TX_DT and CR_ATM_TX_SQ_NO=@CR_ATM_TX_SQ_NO and CRDET_DB_TIMESTAMP=@CRDET_DB_TIMESTAMP and CR_BELONGTO_BRH=@CR_BELONGTO_BRH and CR_RSV_FLG=@CR_RSV_FLG and CR_CURR_COD=@CR_CURR_COD and CR_EC_FLG=@CR_EC_FLG and CR_OPR_EC=@CR_OPR_EC and CR_ENTR_DT=@CR_ENTR_DT and CR_TX_NO=@CR_TX_NO and CR_TX_AMT=@CR_TX_AMT and CR_TX_LOG_NO=@CR_TX_LOG_NO and CR_TX_TM=@CR_TX_TM and CR_TX_NETP_NO=@CR_TX_NETP_NO and CR_CRD_NO=@CR_CRD_NO and CR_CPU_DT=@CR_CPU_DT and CR_GCRD_TX_SQ_NO=@CR_GCRD_TX_SQ_NO and CR_DRGN_CRD_TX_SQ_NO=@CR_DRGN_CRD_TX_SQ_NO and CR_CONF_FLG=@CR_CONF_FLG and CR_DSCRP_COD=@CR_DSCRP_COD and CR_TRNI_SAV_NO=@CR_TRNI_SAV_NO and CR_TRNO_SAV_NO=@CR_TRNO_SAV_NO and CR_PSBK_SQ_NO_N=@CR_PSBK_SQ_NO_N and CR_DB_PART_ID=@CR_DB_PART_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ETLDT", OleDbType.VarChar,8),
					new OleDbParameter("@CRDET_LL", OleDbType.Decimal),
					new OleDbParameter("@FK_CRATM_KEY", OleDbType.VarChar,12),
					new OleDbParameter("@CR_TX_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_ATM_TX_SQ_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CRDET_DB_TIMESTAMP", OleDbType.Decimal),
					new OleDbParameter("@CR_BELONGTO_BRH", OleDbType.VarChar,9),
					new OleDbParameter("@CR_RSV_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_CURR_COD", OleDbType.VarChar,2),
					new OleDbParameter("@CR_EC_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_OPR_EC", OleDbType.VarChar,12),
					new OleDbParameter("@CR_ENTR_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_TX_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_AMT", OleDbType.Decimal),
					new OleDbParameter("@CR_TX_LOG_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_TX_TM", OleDbType.VarChar,9),
					new OleDbParameter("@CR_TX_NETP_NO", OleDbType.VarChar,9),
					new OleDbParameter("@CR_CRD_NO", OleDbType.VarChar,19),
					new OleDbParameter("@CR_CPU_DT", OleDbType.VarChar,8),
					new OleDbParameter("@CR_GCRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_DRGN_CRD_TX_SQ_NO", OleDbType.VarChar,8),
					new OleDbParameter("@CR_CONF_FLG", OleDbType.VarChar,1),
					new OleDbParameter("@CR_DSCRP_COD", OleDbType.VarChar,4),
					new OleDbParameter("@CR_TRNI_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_TRNO_SAV_NO", OleDbType.VarChar,28),
					new OleDbParameter("@CR_PSBK_SQ_NO_N", OleDbType.Decimal),
					new OleDbParameter("@CR_DB_PART_ID", OleDbType.VarChar,9)			};
            parameters[0].Value = ETLDT;
            parameters[1].Value = CRDET_LL;
            parameters[2].Value = FK_CRATM_KEY;
            parameters[3].Value = CR_TX_DT;
            parameters[4].Value = CR_ATM_TX_SQ_NO;
            parameters[5].Value = CRDET_DB_TIMESTAMP;
            parameters[6].Value = CR_BELONGTO_BRH;
            parameters[7].Value = CR_RSV_FLG;
            parameters[8].Value = CR_CURR_COD;
            parameters[9].Value = CR_EC_FLG;
            parameters[10].Value = CR_OPR_EC;
            parameters[11].Value = CR_ENTR_DT;
            parameters[12].Value = CR_TX_NO;
            parameters[13].Value = CR_TX_AMT;
            parameters[14].Value = CR_TX_LOG_NO;
            parameters[15].Value = CR_TX_TM;
            parameters[16].Value = CR_TX_NETP_NO;
            parameters[17].Value = CR_CRD_NO;
            parameters[18].Value = CR_CPU_DT;
            parameters[19].Value = CR_GCRD_TX_SQ_NO;
            parameters[20].Value = CR_DRGN_CRD_TX_SQ_NO;
            parameters[21].Value = CR_CONF_FLG;
            parameters[22].Value = CR_DSCRP_COD;
            parameters[23].Value = CR_TRNI_SAV_NO;
            parameters[24].Value = CR_TRNO_SAV_NO;
            parameters[25].Value = CR_PSBK_SQ_NO_N;
            parameters[26].Value = CR_DB_PART_ID;

            MZSYCORE.Model.Model_CBOD_CRATMDET model = new MZSYCORE.Model.Model_CBOD_CRATMDET();
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
        public MZSYCORE.Model.Model_CBOD_CRATMDET DataRowToModel(DataRow row)
        {
            MZSYCORE.Model.Model_CBOD_CRATMDET model = new MZSYCORE.Model.Model_CBOD_CRATMDET();
            if (row != null)
            {
                if (row["ETLDT"] != null)
                {
                    model.ETLDT = row["ETLDT"].ToString();
                }
                if (row["CRDET_LL"] != null && row["CRDET_LL"].ToString() != "")
                {
                    model.CRDET_LL = decimal.Parse(row["CRDET_LL"].ToString());
                }
                if (row["FK_CRATM_KEY"] != null)
                {
                    model.FK_CRATM_KEY = row["FK_CRATM_KEY"].ToString();
                }
                if (row["CR_TX_DT"] != null)
                {
                    model.CR_TX_DT = row["CR_TX_DT"].ToString();
                }
                if (row["CR_ATM_TX_SQ_NO"] != null)
                {
                    model.CR_ATM_TX_SQ_NO = row["CR_ATM_TX_SQ_NO"].ToString();
                }
                if (row["CRDET_DB_TIMESTAMP"] != null && row["CRDET_DB_TIMESTAMP"].ToString() != "")
                {
                    model.CRDET_DB_TIMESTAMP = decimal.Parse(row["CRDET_DB_TIMESTAMP"].ToString());
                }
                if (row["CR_BELONGTO_BRH"] != null)
                {
                    model.CR_BELONGTO_BRH = row["CR_BELONGTO_BRH"].ToString();
                }
                if (row["CR_RSV_FLG"] != null)
                {
                    model.CR_RSV_FLG = row["CR_RSV_FLG"].ToString();
                }
                if (row["CR_CURR_COD"] != null)
                {
                    model.CR_CURR_COD = row["CR_CURR_COD"].ToString();
                }
                if (row["CR_EC_FLG"] != null)
                {
                    model.CR_EC_FLG = row["CR_EC_FLG"].ToString();
                }
                if (row["CR_OPR_EC"] != null)
                {
                    model.CR_OPR_EC = row["CR_OPR_EC"].ToString();
                }
                if (row["CR_ENTR_DT"] != null)
                {
                    model.CR_ENTR_DT = row["CR_ENTR_DT"].ToString();
                }
                if (row["CR_TX_NO"] != null)
                {
                    model.CR_TX_NO = row["CR_TX_NO"].ToString();
                }
                if (row["CR_TX_AMT"] != null && row["CR_TX_AMT"].ToString() != "")
                {
                    model.CR_TX_AMT = decimal.Parse(row["CR_TX_AMT"].ToString());
                }
                if (row["CR_TX_LOG_NO"] != null)
                {
                    model.CR_TX_LOG_NO = row["CR_TX_LOG_NO"].ToString();
                }
                if (row["CR_TX_TM"] != null)
                {
                    model.CR_TX_TM = row["CR_TX_TM"].ToString();
                }
                if (row["CR_TX_NETP_NO"] != null)
                {
                    model.CR_TX_NETP_NO = row["CR_TX_NETP_NO"].ToString();
                }
                if (row["CR_CRD_NO"] != null)
                {
                    model.CR_CRD_NO = row["CR_CRD_NO"].ToString();
                }
                if (row["CR_CPU_DT"] != null)
                {
                    model.CR_CPU_DT = row["CR_CPU_DT"].ToString();
                }
                if (row["CR_GCRD_TX_SQ_NO"] != null)
                {
                    model.CR_GCRD_TX_SQ_NO = row["CR_GCRD_TX_SQ_NO"].ToString();
                }
                if (row["CR_DRGN_CRD_TX_SQ_NO"] != null)
                {
                    model.CR_DRGN_CRD_TX_SQ_NO = row["CR_DRGN_CRD_TX_SQ_NO"].ToString();
                }
                if (row["CR_CONF_FLG"] != null)
                {
                    model.CR_CONF_FLG = row["CR_CONF_FLG"].ToString();
                }
                if (row["CR_DSCRP_COD"] != null)
                {
                    model.CR_DSCRP_COD = row["CR_DSCRP_COD"].ToString();
                }
                if (row["CR_TRNI_SAV_NO"] != null)
                {
                    model.CR_TRNI_SAV_NO = row["CR_TRNI_SAV_NO"].ToString();
                }
                if (row["CR_TRNO_SAV_NO"] != null)
                {
                    model.CR_TRNO_SAV_NO = row["CR_TRNO_SAV_NO"].ToString();
                }
                if (row["CR_PSBK_SQ_NO_N"] != null && row["CR_PSBK_SQ_NO_N"].ToString() != "")
                {
                    model.CR_PSBK_SQ_NO_N = decimal.Parse(row["CR_PSBK_SQ_NO_N"].ToString());
                }
                if (row["CR_DB_PART_ID"] != null)
                {
                    model.CR_DB_PART_ID = row["CR_DB_PART_ID"].ToString();
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
            strSql.Append("select ETLDT,CRDET_LL,FK_CRATM_KEY,CR_TX_DT,CR_ATM_TX_SQ_NO,CRDET_DB_TIMESTAMP,CR_BELONGTO_BRH,CR_RSV_FLG,CR_CURR_COD,CR_EC_FLG,CR_OPR_EC,CR_ENTR_DT,CR_TX_NO,CR_TX_AMT,CR_TX_LOG_NO,CR_TX_TM,CR_TX_NETP_NO,CR_CRD_NO,CR_CPU_DT,CR_GCRD_TX_SQ_NO,CR_DRGN_CRD_TX_SQ_NO,CR_CONF_FLG,CR_DSCRP_COD,CR_TRNI_SAV_NO,CR_TRNO_SAV_NO,CR_PSBK_SQ_NO_N,CR_DB_PART_ID ");
            strSql.Append(" FROM jsrun.CBOD_CRATMDET ");
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
            strSql.Append("select count(1) FROM CBOD_CRATMDET ");
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
                strSql.Append("order by T.CR_DB_PART_ID desc");
            }
            strSql.Append(")AS Row, T.*  from CBOD_CRATMDET T ");
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
            parameters[0].Value = "CBOD_CRATMDET";
            parameters[1].Value = "CR_DB_PART_ID";
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
