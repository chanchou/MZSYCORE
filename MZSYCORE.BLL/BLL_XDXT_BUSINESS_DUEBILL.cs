using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MZSYCORE.BLL
{
    public class BLL_XDXT_BUSINESS_DUEBILL
    {
        private DAL.DAL_XDXT_BUSINESS_DUEBILL dal = new DAL.DAL_XDXT_BUSINESS_DUEBILL();
        /// <summary>
        /// 获取欠息贷款户的数据列表。参数可选为欠息qianxi，或者本金逾期benjinyuqi
        /// </summary>
        /// <returns></returns>
        public DataSet GetYuQiList(string kemu, string orderBy)
        {
            if (kemu == "qianxi")
            {
                //strSql.Append("  and (INTERESTBALANCE1 !=0 or INTERESTBALANCE2 !=0 or FINEBALANCE1 !=0 or FINEBALANCE2 !=0) ");
                kemu = "  and (INTERESTBALANCE1 !=0 or INTERESTBALANCE2 !=0 or FINEBALANCE1 !=0 ) ";
            }
            else if (kemu == "benjinyuqi")
            {
                kemu = "  and (OVERDUEBALANCE !=0 or DULLBALANCE !=0 or BADBALANCE !=0) ";
            }
            if (orderBy != "")
            {
                orderBy = string.Format(" order by  {0}", orderBy);
            }
            return dal.GetList(kemu, orderBy);
        }
        /// <summary>
        /// 根据所选择的字段，求和.科目可选为欠息qianxi，或者本金逾期benjinyuqi
        /// </summary>
        /// <param name="ziduan"></param>
        /// <returns></returns>
        public decimal GetSum(string ziduan, string kemu)
        {
            return dal.GetSum(ziduan, kemu);
        }

        /// <summary>
        /// 根据所选择的字段，计数科目可选为欠息qianxi，或者本金逾期benjinyuqi
        /// </summary>
        /// <param name="ziduan"></param>
        /// <returns></returns>
        public int GetCount(string ziduan, string kemu)
        {
            return dal.GetCount(ziduan, kemu);
        }
        /// <summary>
        /// 根据客户名称获得客户列表
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet GetListByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            else
            {
                name = string.Format(" and CUSTOMERNAME='{0}' ", name);
                return dal.GetList(name);
            }

        }

        public List<Model.Model_XDXT_BUSINESS_DUEBILL> GetModelListByName(string name)
        {
            DataSet ds = GetListByName(name);
            return DataTableToList(ds.Tables[0]);
        }
        public List<Model.Model_XDXT_BUSINESS_DUEBILL> DataTableToList(DataTable dt)
        {
            List<Model.Model_XDXT_BUSINESS_DUEBILL> lst = new List<Model.Model_XDXT_BUSINESS_DUEBILL>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Model.Model_XDXT_BUSINESS_DUEBILL model_XDXT_BUSINESS_DUEBILL = new Model.Model_XDXT_BUSINESS_DUEBILL();
                    model_XDXT_BUSINESS_DUEBILL = DataRowToModel(dt.Rows[i]);
                    if (model_XDXT_BUSINESS_DUEBILL != null)
                    {
                        lst.Add(model_XDXT_BUSINESS_DUEBILL);
                    }
                }
            }
            return lst;
        }

        public Model.Model_XDXT_BUSINESS_DUEBILL DataRowToModel(DataRow dr)
        {
            Model.Model_XDXT_BUSINESS_DUEBILL model_XDXT_BUSINESS_DUEBILL = new Model.Model_XDXT_BUSINESS_DUEBILL();
            if (dr != null)
            {
                if (dr["MANAGEUSERID"] != null)
                { model_XDXT_BUSINESS_DUEBILL.MANAGEUSERID = dr["MANAGEUSERID"].ToString(); }
                if (dr["SERIALNO"] != null)
                { model_XDXT_BUSINESS_DUEBILL.SERIALNO = dr["SERIALNO"].ToString(); }
                if (dr["PAYINTERESTACCOUNT"] != null)
                { model_XDXT_BUSINESS_DUEBILL.PAYINTERESTACCOUNT = dr["PAYINTERESTACCOUNT"].ToString(); }
                if (dr["CUSTOMERNAME"] != null)
                { model_XDXT_BUSINESS_DUEBILL.CUSTOMERNAME = dr["CUSTOMERNAME"].ToString(); }
                if (dr["PUTOUTDATE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.PUTOUTDATE = dr["PUTOUTDATE"].ToString(); }
                if (dr["MATURITY"] != null)
                { model_XDXT_BUSINESS_DUEBILL.MATURITY = dr["MATURITY"].ToString(); }
                if (dr["BUSINESSSUM"] != null)
                { model_XDXT_BUSINESS_DUEBILL.BUSINESSSUM = decimal.Parse(dr["BUSINESSSUM"].ToString()); }
                if (dr["ACTUALBUSINESSRATE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.ACTUALBUSINESSRATE = decimal.Parse(dr["ACTUALBUSINESSRATE"].ToString()); }
                if (dr["BALANCE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.BALANCE = decimal.Parse(dr["BALANCE"].ToString()); }
                if (dr["NORMALBALANCE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.NORMALBALANCE = decimal.Parse(dr["NORMALBALANCE"].ToString()); }
                if (dr["OVERDUEBALANCE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.OVERDUEBALANCE = decimal.Parse(dr["OVERDUEBALANCE"].ToString()); }
                if (dr["DULLBALANCE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.DULLBALANCE = decimal.Parse(dr["DULLBALANCE"].ToString()); }
                if (dr["BADBALANCE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.BADBALANCE = decimal.Parse(dr["BADBALANCE"].ToString()); }
                if (dr["INTERESTBALANCE1"] != null)
                { model_XDXT_BUSINESS_DUEBILL.INTERESTBALANCE1 = decimal.Parse(dr["INTERESTBALANCE1"].ToString()); }
                if (dr["INTERESTBALANCE2"] != null)
                { model_XDXT_BUSINESS_DUEBILL.INTERESTBALANCE2 = decimal.Parse(dr["INTERESTBALANCE2"].ToString()); }
                if (dr["FINEBALANCE1"] != null)
                { model_XDXT_BUSINESS_DUEBILL.FINEBALANCE1 = decimal.Parse(dr["FINEBALANCE1"].ToString()); }
                if (dr["FINEBALANCE2"] != null)
                { model_XDXT_BUSINESS_DUEBILL.FINEBALANCE2 = decimal.Parse(dr["FINEBALANCE2"].ToString()); }
                if (dr["UPDATEDATE"] != null)
                { model_XDXT_BUSINESS_DUEBILL.UPDATEDATE = dr["UPDATEDATE"].ToString(); }
                if (dr["MANAGEORGID"] != null)
                { model_XDXT_BUSINESS_DUEBILL.MANAGEORGID = dr["MANAGEORGID"].ToString(); }
            } return model_XDXT_BUSINESS_DUEBILL;

        }
    }
}
