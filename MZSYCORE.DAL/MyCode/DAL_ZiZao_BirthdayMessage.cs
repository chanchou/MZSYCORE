using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL.MyCode
{
    public class DAL_ZiZao_BirthdayMessage
    {
        /// <summary>
        /// 根据所输入的日期，获得对象列表。日期格式为："01-01"
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public List<MZSYCORE.Model.Model_ZiZao_BirthdayMessage> GetModelList(string MMdd)
        {
            List<MZSYCORE.Model.Model_ZiZao_BirthdayMessage> lst = new List<Model.Model_ZiZao_BirthdayMessage>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CUST_NO, CUST_NAME, GENDER, BIRTHDAY, T2.ADDRESS from jsrun.dxpt_customer   T1 LEFT JOIN  jsrun.dxpt_ADDRESS   T2 ON T1.CUST_ID=T2.CUST_ID WHERE  T1.ORG_ID LIKE '410826%' ");
            strSql.AppendFormat(" and right(BIRTHDAY,5) ='{0}' ", MMdd);
            DataSet ds = DBUtility.DbHelperOleDb.Query(strSql.ToString());
            //如果数据列表不为空，那么就将它转换成实体模型
            if (ds.Tables[0] != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Model.Model_ZiZao_BirthdayMessage model = new Model.Model_ZiZao_BirthdayMessage();
                    DataRow row = ds.Tables[0].Rows[i];
                    if (row != null)
                    {
                        model = DataRowToModel(row);
                        lst.Add(model);
                    }
                }
            }
            return lst;
        }


        private Model.Model_ZiZao_BirthdayMessage DataRowToModel(DataRow dataRow)
        {
            Model.Model_ZiZao_BirthdayMessage model = new Model.Model_ZiZao_BirthdayMessage();
            if (dataRow != null)
            {
                if (dataRow["CUST_NO"] != null)
                {
                    model.CUST_NO = dataRow["CUST_NO"].ToString();
                }
                if (dataRow["CUST_NAME"] != null)
                {
                    model.CUST_NAME = dataRow["CUST_NAME"].ToString();
                }
                if (dataRow["GENDER"] != null)
                {
                    model.GENDER = dataRow["GENDER"].ToString();
                }
                if (dataRow["BIRTHDAY"] != null)
                {
                    model.BIRTHDAY = dataRow["BIRTHDAY"].ToString();
                }
                if (dataRow["ADDRESS"] != null)
                {
                    model.ADDRESS = dataRow["ADDRESS"].ToString();
                }
            }
            return model;
        }
    }
}
