using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    /// <summary>
    /// BLL_CBOD_CRATMDET
    /// </summary>
    public partial class BLL_CBOD_CRATMDET
    {
        private readonly MZSYCORE.DAL.DAL_CBOD_CRATMDET dal = new MZSYCORE.DAL.DAL_CBOD_CRATMDET();
        public BLL_CBOD_CRATMDET()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ETLDT, decimal CRDET_LL, string FK_CRATM_KEY, string CR_TX_DT, string CR_ATM_TX_SQ_NO, decimal CRDET_DB_TIMESTAMP, string CR_BELONGTO_BRH, string CR_RSV_FLG, string CR_CURR_COD, string CR_EC_FLG, string CR_OPR_EC, string CR_ENTR_DT, string CR_TX_NO, decimal CR_TX_AMT, string CR_TX_LOG_NO, string CR_TX_TM, string CR_TX_NETP_NO, string CR_CRD_NO, string CR_CPU_DT, string CR_GCRD_TX_SQ_NO, string CR_DRGN_CRD_TX_SQ_NO, string CR_CONF_FLG, string CR_DSCRP_COD, string CR_TRNI_SAV_NO, string CR_TRNO_SAV_NO, decimal CR_PSBK_SQ_NO_N, string CR_DB_PART_ID)
        {
            return dal.Exists(ETLDT, CRDET_LL, FK_CRATM_KEY, CR_TX_DT, CR_ATM_TX_SQ_NO, CRDET_DB_TIMESTAMP, CR_BELONGTO_BRH, CR_RSV_FLG, CR_CURR_COD, CR_EC_FLG, CR_OPR_EC, CR_ENTR_DT, CR_TX_NO, CR_TX_AMT, CR_TX_LOG_NO, CR_TX_TM, CR_TX_NETP_NO, CR_CRD_NO, CR_CPU_DT, CR_GCRD_TX_SQ_NO, CR_DRGN_CRD_TX_SQ_NO, CR_CONF_FLG, CR_DSCRP_COD, CR_TRNI_SAV_NO, CR_TRNO_SAV_NO, CR_PSBK_SQ_NO_N, CR_DB_PART_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MZSYCORE.Model.Model_CBOD_CRATMDET model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MZSYCORE.Model.Model_CBOD_CRATMDET model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ETLDT, decimal CRDET_LL, string FK_CRATM_KEY, string CR_TX_DT, string CR_ATM_TX_SQ_NO, decimal CRDET_DB_TIMESTAMP, string CR_BELONGTO_BRH, string CR_RSV_FLG, string CR_CURR_COD, string CR_EC_FLG, string CR_OPR_EC, string CR_ENTR_DT, string CR_TX_NO, decimal CR_TX_AMT, string CR_TX_LOG_NO, string CR_TX_TM, string CR_TX_NETP_NO, string CR_CRD_NO, string CR_CPU_DT, string CR_GCRD_TX_SQ_NO, string CR_DRGN_CRD_TX_SQ_NO, string CR_CONF_FLG, string CR_DSCRP_COD, string CR_TRNI_SAV_NO, string CR_TRNO_SAV_NO, decimal CR_PSBK_SQ_NO_N, string CR_DB_PART_ID)
        {

            return dal.Delete(ETLDT, CRDET_LL, FK_CRATM_KEY, CR_TX_DT, CR_ATM_TX_SQ_NO, CRDET_DB_TIMESTAMP, CR_BELONGTO_BRH, CR_RSV_FLG, CR_CURR_COD, CR_EC_FLG, CR_OPR_EC, CR_ENTR_DT, CR_TX_NO, CR_TX_AMT, CR_TX_LOG_NO, CR_TX_TM, CR_TX_NETP_NO, CR_CRD_NO, CR_CPU_DT, CR_GCRD_TX_SQ_NO, CR_DRGN_CRD_TX_SQ_NO, CR_CONF_FLG, CR_DSCRP_COD, CR_TRNI_SAV_NO, CR_TRNO_SAV_NO, CR_PSBK_SQ_NO_N, CR_DB_PART_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MZSYCORE.Model.Model_CBOD_CRATMDET GetModel(string ETLDT, decimal CRDET_LL, string FK_CRATM_KEY, string CR_TX_DT, string CR_ATM_TX_SQ_NO, decimal CRDET_DB_TIMESTAMP, string CR_BELONGTO_BRH, string CR_RSV_FLG, string CR_CURR_COD, string CR_EC_FLG, string CR_OPR_EC, string CR_ENTR_DT, string CR_TX_NO, decimal CR_TX_AMT, string CR_TX_LOG_NO, string CR_TX_TM, string CR_TX_NETP_NO, string CR_CRD_NO, string CR_CPU_DT, string CR_GCRD_TX_SQ_NO, string CR_DRGN_CRD_TX_SQ_NO, string CR_CONF_FLG, string CR_DSCRP_COD, string CR_TRNI_SAV_NO, string CR_TRNO_SAV_NO, decimal CR_PSBK_SQ_NO_N, string CR_DB_PART_ID)
        {

            return dal.GetModel(ETLDT, CRDET_LL, FK_CRATM_KEY, CR_TX_DT, CR_ATM_TX_SQ_NO, CRDET_DB_TIMESTAMP, CR_BELONGTO_BRH, CR_RSV_FLG, CR_CURR_COD, CR_EC_FLG, CR_OPR_EC, CR_ENTR_DT, CR_TX_NO, CR_TX_AMT, CR_TX_LOG_NO, CR_TX_TM, CR_TX_NETP_NO, CR_CRD_NO, CR_CPU_DT, CR_GCRD_TX_SQ_NO, CR_DRGN_CRD_TX_SQ_NO, CR_CONF_FLG, CR_DSCRP_COD, CR_TRNI_SAV_NO, CR_TRNO_SAV_NO, CR_PSBK_SQ_NO_N, CR_DB_PART_ID);
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
        public List<MZSYCORE.Model.Model_CBOD_CRATMDET> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<MZSYCORE.Model.Model_CBOD_CRATMDET> DataTableToList(DataTable dt)
        {
            List<MZSYCORE.Model.Model_CBOD_CRATMDET> modelList = new List<MZSYCORE.Model.Model_CBOD_CRATMDET>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                MZSYCORE.Model.Model_CBOD_CRATMDET model;
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
