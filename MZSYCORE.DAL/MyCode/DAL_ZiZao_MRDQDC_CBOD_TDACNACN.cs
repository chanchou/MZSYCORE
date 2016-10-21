using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL.MyCode
{

    public class DAL_ZiZao_MRDQDC_CBOD_TDACNACN
    {
        /// <summary>
        /// 根据到期日期，获取明日到期定存实体模型。日期格式为：20150101
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN> GetModelList(string date)
        {
            List<Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN> modelList = new List<Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN>();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select etldt,td_td_acct_no, td_dep_prd_n, td_due_dt, td_opac_dt, td_actu_amt, td_cust_name, td_conntr_no from jsrun.cbod_TDACNACN where TD_OPAC_INSTN_NO like '{0}%' and  td_cacct_tlr_no is null and td_conntr_no is not null and td_dep_prd_n >7 and ",DAL_Constant.Jigouma);
            sb.AppendFormat(" td_due_dt ={0} ", date);

            DataSet ds = DBUtility.DbHelperOleDb.Query(sb.ToString());
            if (ds.Tables[0] != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN model = new Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN();
                    model = DataRowToModel_ZiZao_MRDQDC_CBOD_TDACNACN(ds.Tables[0].Rows[i]);
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 将DataRow转换为实体模型
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN DataRowToModel_ZiZao_MRDQDC_CBOD_TDACNACN(DataRow dataRow)
        {
            Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN model = new Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN();
            if (dataRow != null)
            {
                if (dataRow["etldt"] != null)
                {
                    model.Etldt = dataRow["etldt"].ToString();
                }
                if (dataRow["td_td_acct_no"] != null)
                {
                    model.Td_td_acct_no = dataRow["td_td_acct_no"].ToString();
                }
                if (dataRow["td_dep_prd_n"] != null)
                {
                    model.Td_dep_prd_n = decimal.Parse(dataRow["td_dep_prd_n"].ToString());
                }
                if (dataRow["td_due_dt"] != null)
                {
                    model.Td_due_dt = dataRow["td_due_dt"].ToString();
                }
                if (dataRow["td_opac_dt"] != null)
                {
                    model.Td_opac_dt = dataRow["td_opac_dt"].ToString();
                }
                if (dataRow["td_actu_amt"] != null)
                {
                    model.Td_actu_amt = decimal.Parse(dataRow["td_actu_amt"].ToString());
                }
                if (dataRow["td_cust_name"] != null)
                {
                    model.Td_cust_name = dataRow["td_cust_name"].ToString();

                }
                if (dataRow["td_conntr_no"] != null)
                {
                    model.Td_conntr_no = dataRow["td_conntr_no"].ToString();
                }

            }
            return model;
        }

    }
}
