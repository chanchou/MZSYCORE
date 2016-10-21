using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public partial class DAL_CBOD_GLACAACA
    {
        /// <summary>
        /// 根据时间和部门，获取存放同业内部帐的数据集
        /// </summary>
        /// <param name="department"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataSet GetCunFangTongYeList(string department, string date)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select GL_ACCT_NO, GL_ACCT_FACE_BAL from jsrun.CBOD_GLACAACA");
            sb.AppendFormat(" where GL_DB_PART_ID='{0}' and GL_FIRST_LEVEL_LG_COD='1011' and etldt={1}", department, date);
            return DBUtility.DbHelperOleDb.Query(sb.ToString());
        }

        /// <summary>
        /// 根据时间和部门，获取存放同业内部帐的数据字典。键值为内部帐账号，值值为内部帐余额
        /// </summary>
        /// <param name="department"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Dictionary<string, decimal> GetCunFangTongYeDic(string department, string date)
        {
            Dictionary<string, decimal> dic = new Dictionary<string, decimal>();
            DataSet ds = GetCunFangTongYeList(department, date);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dic.Add(ds.Tables[0].Rows[i][0].ToString(), (decimal)ds.Tables[0].Rows[i][1]);
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            return dic;
        }
    }
}
