using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public partial class DAL_YJZB_JG_01
    {
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Model_YJZB_JG_01 DataRowToModel(DataRow row)
        {
            Model.Model_YJZB_JG_01 model = new Model.Model_YJZB_JG_01();
            if (row != null)
            {
                if (row["TJRQ"] != null && row["TJRQ"].ToString() != "")
                {
                    model.TJRQ = int.Parse(row["TJRQ"].ToString());
                }
                if (row["ZBDH"] != null && row["ZBDH"].ToString() != "")
                {
                    model.ZBDH = int.Parse(row["ZBDH"].ToString());
                }
                if (row["KHDXDH"] != null && row["KHDXDH"].ToString() != "")
                {
                    model.KHDXDH = int.Parse(row["KHDXDH"].ToString());
                }
                if (row["SDBS"] != null)
                {
                    model.SDBS = row["SDBS"].ToString();
                }
                if (row["TJKJ"] != null)
                {
                    model.TJKJ = row["TJKJ"].ToString();
                }
                if (row["BZ"] != null)
                {
                    model.BZ = row["BZ"].ToString();
                }
                if (row["ZBZ"] != null && row["ZBZ"].ToString() != "")
                {
                    model.ZBZ = decimal.Parse(row["ZBZ"].ToString());
                }
            }
            return model;
        }
        /// <summary>
        /// 根据条件，获得数据列表
        /// </summary>
        /// <param name="tjkj">0会计口径，1考核口径</param>
        /// <param name="zbdh">40孟州射阳村镇银行，45孟州营业网点，47孟州营业部，77孟州西虢支行，86孟州化工支行，87孟州南庄支行</param>
        /// <param name="sdbs">1时点，2月日均，3季日均，4年日均，5月累计，6季累计，7年累计</param>
        /// <param name="khdxdh">查询表考核对象-行员 khdx_hy</param>
        /// <param name="tjrq">格式为yyyyMMdd</param>
        /// <returns></returns>
        public DataSet GetList(string tjkj, string zbdh, string sdbs, string khdxdh, string tjrq)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select tjrq , zbdh , khdxdh , sdbs, tjkj, bz , zbz from YJZB_JG_01");
            sb.AppendFormat(" where tjkj={0}  and zbdh in ({1}) and sdbs in({2})  and khdxdh in ({3}) and tjrq={4}", tjkj, zbdh, sdbs, khdxdh, tjrq);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Pas");
        }

        /// <summary>
        /// 根据条件，获得全量的数据列表，不仅仅包括我们需要的单位40孟州射阳村镇银行，45孟州营业网点，47孟州营业部，77孟州西虢支行，86孟州化工支行，87孟州南庄支行
        /// </summary>
        /// <param name="tjkj">0会计口径，1考核口径</param>
        /// <param name="sdbs">1时点，2月日均，3季日均，4年日均，5月累计，6季累计，7年累计</param>
        /// <param name="khdxdh">查询表考核对象-行员 khdx_hy</param>
        /// <param name="tjrq">格式为yyyyMMdd</param>
        /// <returns></returns>
        public DataSet GetList(string tjkj, string zbdh, string sdbs, string tjrq)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select tjrq , zbdh , khdxdh , sdbs, tjkj, bz , zbz from YJZB_JG_01");
            sb.AppendFormat(" where tjkj={0}  and zbdh in ({1}) and sdbs in({2})   and tjrq={3}", tjkj, zbdh, sdbs,  tjrq);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Pas");
        }
        /// <summary>
        /// 根据条件，获得数据列表
        /// </summary>
        /// <param name="tjkj">0会计口径，1考核口径</param>
        /// <param name="zbdh">40孟州射阳村镇银行，45孟州营业网点，47孟州营业部，77孟州西虢支行，86孟州化工支行，87孟州南庄支行</param>
        /// <param name="sdbs">1时点，2月日均，3季日均，4年日均，5月累计，6季累计，7年累计</param>
        /// <param name="khdxdh">查询表考核对象-行员 khdx_hy</param>
        /// <param name="tjrq">格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_YJZB_JG_01> GetModelList(string tjkj, string zbdh, string sdbs, string khdxdh, string tjrq)
        {
            List<Model.Model_YJZB_JG_01> lst = new List<Model.Model_YJZB_JG_01>();
            DataSet ds = GetList(tjkj, zbdh, sdbs, khdxdh, tjrq);
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Model.Model_YJZB_JG_01 model = new Model.Model_YJZB_JG_01();
                    model = DataRowToModel(dt.Rows[i]);
                    lst.Add(model);
                }
            }
            return lst;
        }

        /// <summary>
        /// 根据条件，获得数据列表
        /// </summary>
        /// <param name="tjkj">0会计口径，1考核口径</param>
        /// <param name="zbdh">
        /// <param name="sdbs">1时点，2月日均，3季日均，4年日均，5月累计，6季累计，7年累计</param>
        /// <param name="khdxdh">查询表考核对象-行员 khdx_hy</param>
        /// <param name="tjrq">格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_YJZB_JG_01> GetModelList(string tjkj, string zbdh, string sdbs,  string tjrq)
        {
            List<Model.Model_YJZB_JG_01> lst = new List<Model.Model_YJZB_JG_01>();
            DataSet ds = GetList(tjkj, zbdh, sdbs,tjrq);
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Model.Model_YJZB_JG_01 model = new Model.Model_YJZB_JG_01();
                    model = DataRowToModel(dt.Rows[i]);
                    lst.Add(model);
                }
            }
            return lst;
        }
    }
}
