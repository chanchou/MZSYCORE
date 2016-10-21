using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    /// <summary>
    /// BLL_LSB_CKZH
    /// </summary>
    public partial class BLL_LSB_CKZH
    {
        private readonly MZSYCORE.DAL.DAL_LSB_CKZH dal = new MZSYCORE.DAL.DAL_LSB_CKZH();
        public BLL_LSB_CKZH()
        { }
        #region  BasicMethod
        public object GetSingZiduan(string ziduan, string where)
        {
            return dal.GetSingleZiduan(ziduan, where);
        }
        

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        {
            return dal.Exists(JXDXDH, TJRQ, ZHDH, ZZH, ZHHM, BZ, CPH, KMH, PZH, FHDH, JGDH, KHH, KHRQ, QXRQ, DQRQ, XHRQ, ZHZT, ZHSX, QX, LLDH, NLL, KHJE, ZHYE, ZHBS, HYDH, CZYH, GXHSLX, KHDXDH, XDJE, XDLL, XDBZ, NJS, ZHNRJYE, PSCKBZ);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MZSYCORE.Model.Model_LSB_CKZH model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MZSYCORE.Model.Model_LSB_CKZH model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        {

            return dal.Delete(JXDXDH, TJRQ, ZHDH, ZZH, ZHHM, BZ, CPH, KMH, PZH, FHDH, JGDH, KHH, KHRQ, QXRQ, DQRQ, XHRQ, ZHZT, ZHSX, QX, LLDH, NLL, KHJE, ZHYE, ZHBS, HYDH, CZYH, GXHSLX, KHDXDH, XDJE, XDLL, XDBZ, NJS, ZHNRJYE, PSCKBZ);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MZSYCORE.Model.Model_LSB_CKZH GetModel(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        {

            return dal.GetModel(JXDXDH, TJRQ, ZHDH, ZZH, ZHHM, BZ, CPH, KMH, PZH, FHDH, JGDH, KHH, KHRQ, QXRQ, DQRQ, XHRQ, ZHZT, ZHSX, QX, LLDH, NLL, KHJE, ZHYE, ZHBS, HYDH, CZYH, GXHSLX, KHDXDH, XDJE, XDLL, XDBZ, NJS, ZHNRJYE, PSCKBZ);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public MZSYCORE.Model.Model_LSB_CKZH GetModelByCache(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        //{

        //    string CacheKey = "Model_LSB_CKZHModel-" + JXDXDH + TJRQ + ZHDH + ZZH + ZHHM + BZ + CPH + KMH + PZH + FHDH + JGDH + KHH + KHRQ + QXRQ + DQRQ + XHRQ + ZHZT + ZHSX + QX + LLDH + NLL + KHJE + ZHYE + ZHBS + HYDH + CZYH + GXHSLX + KHDXDH + XDJE + XDLL + XDBZ + NJS + ZHNRJYE + PSCKBZ;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(JXDXDH, TJRQ, ZHDH, ZZH, ZHHM, BZ, CPH, KMH, PZH, FHDH, JGDH, KHH, KHRQ, QXRQ, DQRQ, XHRQ, ZHZT, ZHSX, QX, LLDH, NLL, KHJE, ZHYE, ZHBS, HYDH, CZYH, GXHSLX, KHDXDH, XDJE, XDLL, XDBZ, NJS, ZHNRJYE, PSCKBZ);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (MZSYCORE.Model.Model_LSB_CKZH)objModel;
        //}

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
        public List<MZSYCORE.Model.Model_LSB_CKZH> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<MZSYCORE.Model.Model_LSB_CKZH> DataTableToList(DataTable dt)
        {
            List<MZSYCORE.Model.Model_LSB_CKZH> modelList = new List<MZSYCORE.Model.Model_LSB_CKZH>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                MZSYCORE.Model.Model_LSB_CKZH model;
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
