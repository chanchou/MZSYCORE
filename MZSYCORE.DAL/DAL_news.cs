using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using System.Data.SqlClient;

namespace MZSYCORE.DAL
{
    public class DAL_news
    {
        /// <summary>
        /// 根据发布人姓名判断是否存在该记录.
        /// </summary>
        /// <param name="publish_person">发布人姓名</param>
        /// <returns></returns>
        public bool ExistsByName(string publish_person)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from news");
            strSql.Append(" where publish_person=@publish_person");
            SqlParameter[] parameters = {
					new SqlParameter("@publish_person", SqlDbType.NVarChar,20)
			};
            parameters[0].Value = publish_person;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条新闻
        /// </summary>
        public int Add(MZSYCORE.Model.Model_news model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into news(");
            strSql.Append("publish_date,publish_person,news_title,news_content,attachment_path)");
            strSql.Append(" values (");
            strSql.Append("@publish_date,@publish_person,@news_title,@news_content,@attachment_path)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@publish_date", SqlDbType.Date,3),
					new SqlParameter("@publish_person", SqlDbType.NVarChar,20),
					new SqlParameter("@news_title", SqlDbType.NVarChar,-1),
					new SqlParameter("@news_content", SqlDbType.NVarChar,-1),
					new SqlParameter("@attachment_path", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.publish_date;
            parameters[1].Value = model.publish_person;
            parameters[2].Value = model.news_title;
            parameters[3].Value = model.news_content;
            parameters[4].Value = model.attachment_path;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 删除一条新闻
        /// </summary>
        /// <param name="news_id"></param>
        /// <returns></returns>
        public bool DeleteById(int news_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from news ");
            strSql.Append(" where news_id=@news_id");
            SqlParameter[] parameters = { 
                                        new SqlParameter("@news_id",SqlDbType.Int,4)
                                        };
            parameters[0].Value = news_id;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 根据新闻编号，获得一个对象实体
        /// </summary>
        /// <param name="news_id"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_news GetModelById(int news_id)
        {
            //创建sql语句
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select news_id, publish_date, publish_person, news_title, news_content, attachment_path from news where news_id=@news_id");
            //为sql语句设置参数
            SqlParameter[] parameters = { 
                                        new SqlParameter("@news_id",SqlDbType.Int)};
            parameters[0].Value = news_id;
            MZSYCORE.Model.Model_news model = new Model.Model_news();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            //如果返回来的ds中的datatable中的行数大于0，那么将第一行转换为model对象返回，否则返回null
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
        /// <param name="row"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_news DataRowToModel(DataRow row)
        {
            MZSYCORE.Model.Model_news model = new Model.Model_news();
            if (row != null)
            {
                if (row["news_id"] != null && row["news_id"].ToString() != "")
                {
                    model.news_id = int.Parse(row["news_id"].ToString());
                }
                if (row["publish_date"] != null && row["publish_date"].ToString() != "")
                {
                    model.publish_date = DateTime.Parse(row["publish_date"].ToString());
                }
                if (row["publish_person"] != null)
                {
                    model.publish_person = row["publish_person"].ToString();
                }
                if (row["news_title"] != null)
                {
                    model.news_title = row["news_title"].ToString();
                }
                if (row["news_content"] != null)
                {
                    model.news_content = row["news_content"].ToString();
                }
                if (row["attachment_path"] != null)
                {
                    model.attachment_path = row["attachment_path"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 按某个字段排序获得前n个数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="OrderByField"></param>
        /// <returns></returns>
        public DataSet GetListOrderBy(int topnum, string strWhere, string OrderByField)
        {
            //拼接字符串
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (topnum > 0)
            {
                strSql.Append(" top " + topnum + " ");
            }
            strSql.Append(" news_id, publish_date, publish_person, news_title, news_content, attachment_path from news ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (OrderByField.Trim() != "")
            {
                strSql.Append(" order by " + OrderByField);
            }
            return DbHelperSQL.Query(strSql.ToString());

        }

        /// <summary>
        /// 获得数据列表，如果查询条件为空，那么就是获得所有数据
        /// </summary>
        /// <param name="strWhere">例如：news_id=1</param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select news_id,publish_date,publish_person,news_title,news_content,attachment_path ");
            strSql.Append(" FROM news ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  ");
            return DbHelperSQL.Query(strSql.ToString());
        }


        ///// <summary>
        ///// 根据设定的页面大小和页码数，获得数据列表。默认按照行员号排序，不可更改
        ///// </summary>
        ///// <param name="pageSize">页面大小</param>
        ///// <param name="pageIndex">页码数</param>
        ///// <returns></returns>
        //public DataSet GetListByPage(int pageSize, int pageIndex)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.AppendFormat("select top {0} news_id, publish_date, publish_person, news_title, news_content, attachment_path ", pageSize);
        //    strSql.Append(" from news where news_id not in");
        //    strSql.AppendFormat(" (select top {0} news_id from news order by news_id desc) order by news_id desc ", pageSize * (pageIndex - 1));
        //    return DbHelperSQL.Query(strSql.ToString());
        //}

        /// <summary>
        /// 根据开始条数和结束条数，来获取数据集
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="startRow"></param>
        /// <param name="endRow"></param>
        /// <returns></returns>
        public DataSet GetListByPage(int startRow, int endRow)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select news_id, publish_date, publish_person, news_title, news_content, attachment_path ");
            strSql.Append(" from ");
            strSql.Append("( select ROW_NUMBER() over 	( order by T.news_id desc)as Row, T.* from news T ) TT");
            strSql.AppendFormat(" where TT.Row between {0} and {1}",startRow,endRow);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据设定的页面大小、页码数和新闻发布人，获得数据列表。默认按照行员号排序，不可更改
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="publish_person"></param>
        /// <returns></returns>
        public DataSet GetListByPagePerson(int pageSize, int pageIndex,string publish_person)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select top {0} news_id, publish_date, publish_person, news_title, news_content, attachment_path ", pageSize);
            strSql.Append(" from news where ");
            if (publish_person != "")
            {
                strSql.AppendFormat(" publish_person = '{0}' and ",publish_person);              
            }
            strSql.Append("  news_id not in");
            strSql.AppendFormat(" (select top {0} news_id from news order by news_id) order by news_id desc ", pageSize * (pageIndex - 1));
           
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总条数。如果strwhere为空，那么就是取得所有的数据总条数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from news ");
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

    }
}
