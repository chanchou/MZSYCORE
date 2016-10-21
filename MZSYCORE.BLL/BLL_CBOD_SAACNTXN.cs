using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    /// <summary>
    /// BLL_CBOD_SAACNTXN
    /// </summary>
    public partial class BLL_CBOD_SAACNTXN
    {
        private readonly MZSYCORE.DAL.DAL_CBOD_SAACNTXN dal = new MZSYCORE.DAL.DAL_CBOD_SAACNTXN();
        public BLL_CBOD_SAACNTXN()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ETLDT, decimal SATXN_LL, string FK_SAACN_KEY, decimal SA_DDP_ACCT_NO_DET_N, decimal SATXN_DB_TIMESTAMP, string SA_CURR_COD, string SA_OPR_NO, string SA_CURR_IDEN, string SA_EC_FLG, decimal SA_EC_DET_NO_N, decimal SA_CR_AMT, decimal SA_DDP_ACCT_BAL, decimal SA_TX_AMT, string SA_TX_CRD_NO, string SA_TX_TYP, string SA_TX_LOG_NO, decimal SA_DR_AMT, string SA_DOC_NO, string SA_DOC_TYP, string SA_VAL_DT, decimal SA_SVC, string SA_AUTH_NO, string SA_CUST_DOCAG_STNO, string SA_OPUN_COD, string SA_DSCRP_COD, string SA_RMRK, string SA_TX_TM, string SA_TX_DT, string SA_SYS_DT, decimal SA_DDP_PDT, string SA_APP_TX_CODE, string SA_ETX_FLG, string SA_OTX_FLG, string SA_FLX_FLG, string SA_GUIJI_FLAG, string SA_PRT_FLG, string SA_FILLER, string SA_RMRK_1, string SA_OP_CUST_NAME, string SA_AGT_CERT_TYP, string SA_AGT_CERT_ID, string SA_AGT_CUST_NAME, string SA_BELONG_INSTN_COD, string SA_CHANNEL_FLAG, string SA_PDP_CODE, string SA_OP_ACCT_NO_32, string SA_OP_BANK_NO, string SA_SUP_TLR, string SA_DB_PART_ID)
        {
            return dal.Exists(ETLDT, SATXN_LL, FK_SAACN_KEY, SA_DDP_ACCT_NO_DET_N, SATXN_DB_TIMESTAMP, SA_CURR_COD, SA_OPR_NO, SA_CURR_IDEN, SA_EC_FLG, SA_EC_DET_NO_N, SA_CR_AMT, SA_DDP_ACCT_BAL, SA_TX_AMT, SA_TX_CRD_NO, SA_TX_TYP, SA_TX_LOG_NO, SA_DR_AMT, SA_DOC_NO, SA_DOC_TYP, SA_VAL_DT, SA_SVC, SA_AUTH_NO, SA_CUST_DOCAG_STNO, SA_OPUN_COD, SA_DSCRP_COD, SA_RMRK, SA_TX_TM, SA_TX_DT, SA_SYS_DT, SA_DDP_PDT, SA_APP_TX_CODE, SA_ETX_FLG, SA_OTX_FLG, SA_FLX_FLG, SA_GUIJI_FLAG, SA_PRT_FLG, SA_FILLER, SA_RMRK_1, SA_OP_CUST_NAME, SA_AGT_CERT_TYP, SA_AGT_CERT_ID, SA_AGT_CUST_NAME, SA_BELONG_INSTN_COD, SA_CHANNEL_FLAG, SA_PDP_CODE, SA_OP_ACCT_NO_32, SA_OP_BANK_NO, SA_SUP_TLR, SA_DB_PART_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MZSYCORE.Model.Model_CBOD_SAACNTXN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MZSYCORE.Model.Model_CBOD_SAACNTXN model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ETLDT, decimal SATXN_LL, string FK_SAACN_KEY, decimal SA_DDP_ACCT_NO_DET_N, decimal SATXN_DB_TIMESTAMP, string SA_CURR_COD, string SA_OPR_NO, string SA_CURR_IDEN, string SA_EC_FLG, decimal SA_EC_DET_NO_N, decimal SA_CR_AMT, decimal SA_DDP_ACCT_BAL, decimal SA_TX_AMT, string SA_TX_CRD_NO, string SA_TX_TYP, string SA_TX_LOG_NO, decimal SA_DR_AMT, string SA_DOC_NO, string SA_DOC_TYP, string SA_VAL_DT, decimal SA_SVC, string SA_AUTH_NO, string SA_CUST_DOCAG_STNO, string SA_OPUN_COD, string SA_DSCRP_COD, string SA_RMRK, string SA_TX_TM, string SA_TX_DT, string SA_SYS_DT, decimal SA_DDP_PDT, string SA_APP_TX_CODE, string SA_ETX_FLG, string SA_OTX_FLG, string SA_FLX_FLG, string SA_GUIJI_FLAG, string SA_PRT_FLG, string SA_FILLER, string SA_RMRK_1, string SA_OP_CUST_NAME, string SA_AGT_CERT_TYP, string SA_AGT_CERT_ID, string SA_AGT_CUST_NAME, string SA_BELONG_INSTN_COD, string SA_CHANNEL_FLAG, string SA_PDP_CODE, string SA_OP_ACCT_NO_32, string SA_OP_BANK_NO, string SA_SUP_TLR, string SA_DB_PART_ID)
        {

            return dal.Delete(ETLDT, SATXN_LL, FK_SAACN_KEY, SA_DDP_ACCT_NO_DET_N, SATXN_DB_TIMESTAMP, SA_CURR_COD, SA_OPR_NO, SA_CURR_IDEN, SA_EC_FLG, SA_EC_DET_NO_N, SA_CR_AMT, SA_DDP_ACCT_BAL, SA_TX_AMT, SA_TX_CRD_NO, SA_TX_TYP, SA_TX_LOG_NO, SA_DR_AMT, SA_DOC_NO, SA_DOC_TYP, SA_VAL_DT, SA_SVC, SA_AUTH_NO, SA_CUST_DOCAG_STNO, SA_OPUN_COD, SA_DSCRP_COD, SA_RMRK, SA_TX_TM, SA_TX_DT, SA_SYS_DT, SA_DDP_PDT, SA_APP_TX_CODE, SA_ETX_FLG, SA_OTX_FLG, SA_FLX_FLG, SA_GUIJI_FLAG, SA_PRT_FLG, SA_FILLER, SA_RMRK_1, SA_OP_CUST_NAME, SA_AGT_CERT_TYP, SA_AGT_CERT_ID, SA_AGT_CUST_NAME, SA_BELONG_INSTN_COD, SA_CHANNEL_FLAG, SA_PDP_CODE, SA_OP_ACCT_NO_32, SA_OP_BANK_NO, SA_SUP_TLR, SA_DB_PART_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MZSYCORE.Model.Model_CBOD_SAACNTXN GetModel(string ETLDT, decimal SATXN_LL, string FK_SAACN_KEY, decimal SA_DDP_ACCT_NO_DET_N, decimal SATXN_DB_TIMESTAMP, string SA_CURR_COD, string SA_OPR_NO, string SA_CURR_IDEN, string SA_EC_FLG, decimal SA_EC_DET_NO_N, decimal SA_CR_AMT, decimal SA_DDP_ACCT_BAL, decimal SA_TX_AMT, string SA_TX_CRD_NO, string SA_TX_TYP, string SA_TX_LOG_NO, decimal SA_DR_AMT, string SA_DOC_NO, string SA_DOC_TYP, string SA_VAL_DT, decimal SA_SVC, string SA_AUTH_NO, string SA_CUST_DOCAG_STNO, string SA_OPUN_COD, string SA_DSCRP_COD, string SA_RMRK, string SA_TX_TM, string SA_TX_DT, string SA_SYS_DT, decimal SA_DDP_PDT, string SA_APP_TX_CODE, string SA_ETX_FLG, string SA_OTX_FLG, string SA_FLX_FLG, string SA_GUIJI_FLAG, string SA_PRT_FLG, string SA_FILLER, string SA_RMRK_1, string SA_OP_CUST_NAME, string SA_AGT_CERT_TYP, string SA_AGT_CERT_ID, string SA_AGT_CUST_NAME, string SA_BELONG_INSTN_COD, string SA_CHANNEL_FLAG, string SA_PDP_CODE, string SA_OP_ACCT_NO_32, string SA_OP_BANK_NO, string SA_SUP_TLR, string SA_DB_PART_ID)
        {

            return dal.GetModel(ETLDT, SATXN_LL, FK_SAACN_KEY, SA_DDP_ACCT_NO_DET_N, SATXN_DB_TIMESTAMP, SA_CURR_COD, SA_OPR_NO, SA_CURR_IDEN, SA_EC_FLG, SA_EC_DET_NO_N, SA_CR_AMT, SA_DDP_ACCT_BAL, SA_TX_AMT, SA_TX_CRD_NO, SA_TX_TYP, SA_TX_LOG_NO, SA_DR_AMT, SA_DOC_NO, SA_DOC_TYP, SA_VAL_DT, SA_SVC, SA_AUTH_NO, SA_CUST_DOCAG_STNO, SA_OPUN_COD, SA_DSCRP_COD, SA_RMRK, SA_TX_TM, SA_TX_DT, SA_SYS_DT, SA_DDP_PDT, SA_APP_TX_CODE, SA_ETX_FLG, SA_OTX_FLG, SA_FLX_FLG, SA_GUIJI_FLAG, SA_PRT_FLG, SA_FILLER, SA_RMRK_1, SA_OP_CUST_NAME, SA_AGT_CERT_TYP, SA_AGT_CERT_ID, SA_AGT_CUST_NAME, SA_BELONG_INSTN_COD, SA_CHANNEL_FLAG, SA_PDP_CODE, SA_OP_ACCT_NO_32, SA_OP_BANK_NO, SA_SUP_TLR, SA_DB_PART_ID);
        }

       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<MZSYCORE.Model.Model_CBOD_SAACNTXN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<MZSYCORE.Model.Model_CBOD_SAACNTXN> DataTableToList(DataTable dt)
        {
            List<MZSYCORE.Model.Model_CBOD_SAACNTXN> modelList = new List<MZSYCORE.Model.Model_CBOD_SAACNTXN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                MZSYCORE.Model.Model_CBOD_SAACNTXN model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
