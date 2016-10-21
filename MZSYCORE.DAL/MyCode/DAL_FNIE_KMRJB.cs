using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MZSYCORE.DAL.MyCode;
using System.Data;

namespace MZSYCORE.DAL
{
    public partial class DAL_FNIE_KMRJB
    {
        /// <summary>
        /// 根据日期和所属部门，获取实体的字典。其中键为科目编号，值为实体模型
        /// 存储顺序为：数据日期0，机构编码1，部门号2，科目编码3，币种4，昨日借方余额5，昨日贷方余额6，本日借方发生额7，本日贷方发生额8，本日借方余额9，本日贷方余额10，上月末借方余额11，上月末贷方余额12，本月借方发生额13，本月大方发生额14
        /// </summary>
        /// <param name="date"></param>
        /// <param name="departcode"></param>
        /// <returns></returns>
        public Dictionary<string, Model.Model_FNIE_KMRJB> GetMessageModelDic(string date, string departcode)
        {

            Dictionary<string, Model.Model_FNIE_KMRJB> myDic = new Dictionary<string, Model.Model_FNIE_KMRJB>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DATA_DATE,UNITCODE,DEPTCODE,SUBJECT_CD,CURRENCY_CD,PREDAY_DEBIT_BALANCE,PREDAY_CREDIT_BALANCE,TODAY_DEBIT_AMT,TODAY_CREDIT_AMT,TODAY_DEBIT_BALANCE,TODAY_CREDIT_BALANCE,LASTMONTH_DEBIT_BALANCE,LASTMONTH_CREDIT_BALANCE,THISMONTH_DEBIT_AMT,THISMONTH_CREDIT_AMT from jsrun.FNIE_KMRJB ");
            strSql.Append(" where (length(SUBJECT_CD)=4 or SUBJECT_CD ='12219905' or SUBJECT_CD ='22419915' or SUBJECT_CD ='200405' or SUBJECT_CD ='200425' or SUBJECT_CD ='200435' ) ");
            strSql.AppendFormat(" and data_date='{0}' ", date);
            if (departcode == string.Format("{0}000",DAL_Constant.Jigouma))
            {
                strSql.AppendFormat(" and unitcode ='{0}000' and  DEPTCODE is null ", DAL_Constant.Jigouma);
            }
            else
            {
                strSql.AppendFormat(" DEPTCODE ='{0}' ", departcode);
            }
            Model.Model_FNIE_KMRJB model = new Model.Model_FNIE_KMRJB();
            DataSet ds = DBUtility.DbHelperOleDb.Query(strSql.ToString());
            //如果存在数据，那么遍历数据集，并将数据集转换为实体，然后添加到实体的list集合中
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    model = DataRowToModel(ds.Tables[0].Rows[i]);
                    myDic.Add(model.SUBJECT_CD, model);
                }
            }
            else
            {
                return null;
            }

            return myDic;

        }

        /// <summary>
        /// 得到实体对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public Model.Model_FNIE_KMRJB DataRowToModel(DataRow row)
        {
            Model.Model_FNIE_KMRJB model = new Model.Model_FNIE_KMRJB();
            if (row != null)
            {
                if (row["DATA_DATE"] != null)
                {
                    model.DATA_DATE = row["DATA_DATE"].ToString();
                }
                if (row["UNITCODE"] != null)
                {
                    model.UNITCODE = row["UNITCODE"].ToString();
                }
                if (row["DEPTCODE"] != null)
                {
                    model.DEPTCODE = row["DEPTCODE"].ToString();
                }
                if (row["SUBJECT_CD"] != null)
                {
                    model.SUBJECT_CD = row["SUBJECT_CD"].ToString();
                }
                if (row["CURRENCY_CD"] != null)
                {
                    model.CURRENCY_CD = row["CURRENCY_CD"].ToString();
                }
                if (row["PREDAY_DEBIT_BALANCE"] != null && row["PREDAY_DEBIT_BALANCE"].ToString() != "")
                {
                    model.PREDAY_DEBIT_BALANCE = decimal.Parse(row["PREDAY_DEBIT_BALANCE"].ToString());
                }
                if (row["PREDAY_CREDIT_BALANCE"] != null && row["PREDAY_CREDIT_BALANCE"].ToString() != "")
                {
                    model.PREDAY_CREDIT_BALANCE = decimal.Parse(row["PREDAY_CREDIT_BALANCE"].ToString());
                }
                if (row["TODAY_DEBIT_AMT"] != null && row["TODAY_DEBIT_AMT"].ToString() != "")
                {
                    model.TODAY_DEBIT_AMT = decimal.Parse(row["TODAY_DEBIT_AMT"].ToString());
                }
                if (row["TODAY_CREDIT_AMT"] != null && row["TODAY_CREDIT_AMT"].ToString() != "")
                {
                    model.TODAY_CREDIT_AMT = decimal.Parse(row["TODAY_CREDIT_AMT"].ToString());
                }
                if (row["TODAY_DEBIT_BALANCE"] != null && row["TODAY_DEBIT_BALANCE"].ToString() != "")
                {
                    model.TODAY_DEBIT_BALANCE = decimal.Parse(row["TODAY_DEBIT_BALANCE"].ToString());
                }
                if (row["TODAY_CREDIT_BALANCE"] != null && row["TODAY_CREDIT_BALANCE"].ToString() != "")
                {
                    model.TODAY_CREDIT_BALANCE = decimal.Parse(row["TODAY_CREDIT_BALANCE"].ToString());
                }
                if (row["LASTMONTH_DEBIT_BALANCE"] != null && row["LASTMONTH_DEBIT_BALANCE"].ToString() != "")
                {
                    model.LASTMONTH_DEBIT_BALANCE = decimal.Parse(row["LASTMONTH_DEBIT_BALANCE"].ToString());
                }
                if (row["LASTMONTH_CREDIT_BALANCE"] != null && row["LASTMONTH_CREDIT_BALANCE"].ToString() != "")
                {
                    model.LASTMONTH_CREDIT_BALANCE = decimal.Parse(row["LASTMONTH_CREDIT_BALANCE"].ToString());
                }
                if (row["THISMONTH_DEBIT_AMT"] != null && row["THISMONTH_DEBIT_AMT"].ToString() != "")
                {
                    model.THISMONTH_DEBIT_AMT = decimal.Parse(row["THISMONTH_DEBIT_AMT"].ToString());
                }
                if (row["THISMONTH_CREDIT_AMT"] != null && row["THISMONTH_CREDIT_AMT"].ToString() != "")
                {
                    model.THISMONTH_CREDIT_AMT = decimal.Parse(row["THISMONTH_CREDIT_AMT"].ToString());
                }
            }
            return model;
        }


        /// <summary>
        /// 是否存在制定日期的数据，日期格式为20140101
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool ExistDataByDate(string date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select * from jsrun.fnie_kmrjb where unitcode ='{0}000' and data_date='{1}' ",DAL_Constant.Jigouma, date);
            return DBUtility.DbHelperOleDb.Exists(strSql.ToString());
        }



    }
}
