using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using System.Data;

namespace MZSYCORE.DAL
{
    public class DAL_employee_info
    {

        /// <summary>
        /// 根据客户经理编号获取姓名
        /// </summary>
        /// <param name="kehujingliid"></param>
        /// <returns></returns>
        public string FindNameByKehujingliId(string kehujingliid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select name from employee_info where kehujingli_id ='{0}'",kehujingliid);
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return kehujingliid;
            }
            else
            {
                return obj.ToString();
            }
            
        }

        /// <summary>
        /// 通过名字判断是否存在该记录
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistsByName(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from employee_info ");
            strSql.Append(" where name=@name ");
            SqlParameter[] parameters = { new SqlParameter("@name", SqlDbType.NVarChar, 20) };
            parameters[0].Value = name;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据条件，获取记录总数。条件为空表示获取总记录
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from employee_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
                return 0;
            else
                return Convert.ToInt32(obj);
        }

        /// <summary>
        /// 根据条件获取数据列表。如果条件为空，那么获得全部数据
        /// </summary>
        /// <param name="strWhere">例如："employee_id='00000155'"</param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select employee_id, guiyuan_id, kehujingli_id, name, birthday, identity_card_number, phone_number_1, phone_number_2, short_phone_number_1, short_phone_number_2, department, job_level, operate_level, ruhang_date, login_pwd ");
            strSql.Append(" from employee_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据条件获得所需字段
        /// </summary>
        /// <param name="XX">所需字段,仅限单条记录</param>
        /// <param name="TiaoJian">条件</param>
        /// <returns></returns>
        public object GetXXByTiaoJian(string XX, string TiaoJian)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select {0} from employee_info where {1}",XX,TiaoJian);
            return DbHelperSQL.GetSingle(sb.ToString());
 
        }


        /// <summary>
        /// 根据条件获取所需要的数据列表。如果条件为空，那么获得全部数据。数据列表字段不能为空
        /// </summary>
        /// <param name="XX">数据列表字段不能为空，包括“employee_id, guiyuan_id, kehujingli_id, name, birthday, identity_card_number, phone_number_1, phone_number_2, short_phone_number_1, short_phone_number_2, department, job_level, operate_level, ruhang_date, login_pwd”</param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetXXList(string XX, string strWhere)
        {

            if (!string.IsNullOrEmpty(XX))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.AppendFormat("select {0} ", XX);
                strSql.Append(" from employee_info ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                }
                return DbHelperSQL.Query(strSql.ToString());
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据设定的页面大小和页码数，获得数据列表。默认按照行员号排序，不可更改
        /// </summary>
        /// <param name="pageSize">页面大小</param>
        /// <param name="pageIndex">页码数</param>
        /// <returns></returns>
        public DataSet GetListByPage(int pageSize, int pageIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("select top {0} employee_id, guiyuan_id, kehujingli_id, name, birthday, identity_card_number, phone_number_1, phone_number_2, short_phone_number_1, short_phone_number_2, department, job_level, operate_level, ruhang_date, login_pwd ", pageSize);
            strSql.Append(" from employee_info where employee_id not in");
            strSql.AppendFormat(" (select top {0} employee_id from employee_info order by employee_id) order by employee_id", pageSize * (pageIndex - 1));
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据行员号，获得一个对象实体模型
        /// </summary>
        /// <param name="employee_id"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_employee_info GetModelById(string employee_id)
        {
            //拼接sql语句
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select employee_id, guiyuan_id, kehujingli_id, name, birthday, identity_card_number, phone_number_1, phone_number_2, short_phone_number_1, short_phone_number_2, department, job_level, operate_level, ruhang_date, login_pwd ");
            strSql.Append(" from employee_info ");
            strSql.Append(" where employee_id=@employee_id ");
            SqlParameter[] parameters ={
                                      new SqlParameter("@employee_id",System.Data.SqlDbType.VarChar,8)
                                       };
            parameters[0].Value = employee_id;

            //创建model对象。如果存在记录，那么就将dataset转换为model对象。
            MZSYCORE.Model.Model_employee_info model = new Model.Model_employee_info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
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
        /// 根据行员姓名，获得一个对象实体模型
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_employee_info GetModelByName(string name)
        {
            //拼接sql语句
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select employee_id, guiyuan_id, kehujingli_id, name, birthday, identity_card_number, phone_number_1, phone_number_2, short_phone_number_1, short_phone_number_2, department, job_level, operate_level, ruhang_date, login_pwd ");
            strSql.Append(" from employee_info ");
            strSql.Append(" where name=@name ");
            SqlParameter[] parameters ={
                                      new SqlParameter("@name",System.Data.SqlDbType.NVarChar,20)
                                       };
            parameters[0].Value = name;

            //创建model对象。如果存在记录，那么就将dataset转换为model对象。
            MZSYCORE.Model.Model_employee_info model = new Model.Model_employee_info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
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
        /// 将datarow转换为对象实体。
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_employee_info DataRowToModel(DataRow row)
        {
            Model.Model_employee_info model = new Model.Model_employee_info();
            if (row != null)
            {
                if (row["employee_id"] != null)
                {
                    model.employee_id = row["employee_id"].ToString();
                }
                if (row["guiyuan_id"] != null)
                {
                    model.guiyuan_id = row["guiyuan_id"].ToString();
                }
                if (row["kehujingli_id"] != null)
                {
                    model.kehujingli_id = row["kehujingli_id"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["birthday"] != null && row["birthday"].ToString() != "")
                {
                    model.birthday = DateTime.Parse(row["birthday"].ToString());
                }
                if (row["identity_card_number"] != null)
                {
                    model.identity_card_number = row["identity_card_number"].ToString();
                }
                if (row["phone_number_1"] != null)
                {
                    model.phone_number_1 = row["phone_number_1"].ToString();
                }
                if (row["phone_number_2"] != null)
                {
                    model.phone_number_2 = row["phone_number_2"].ToString();
                }
                if (row["short_phone_number_1"] != null)
                {
                    model.short_phone_number_1 = row["short_phone_number_1"].ToString();
                }
                if (row["short_phone_number_2"] != null)
                {
                    model.short_phone_number_2 = row["short_phone_number_2"].ToString();
                }
                if (row["department"] != null)
                {
                    model.department = row["department"].ToString();
                }
                if (row["job_level"] != null)
                {
                    model.job_level = row["job_level"].ToString();
                }
                if (row["operate_level"] != null)
                {
                    model.operate_level = row["operate_level"].ToString();
                }
                if (row["ruhang_date"] != null && row["ruhang_date"].ToString() != "")
                {
                    model.ruhang_date = DateTime.Parse(row["ruhang_date"].ToString());
                }
                if (row["login_pwd"] != null)
                {
                    model.login_pwd = row["login_pwd"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 根据用户名，修改密码
        /// </summary>
        /// <param name="employee_id"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public bool ChangePwd(string employee_id, string newPwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update employee_info set ");
            strSql.Append("login_pwd=@login_pwd ");
            strSql.Append(" where employee_id=@employee_id ");

            SqlParameter[] parameters = {
                                             new SqlParameter("@login_pwd",SqlDbType.NVarChar,50),
                                             new SqlParameter("@employee_id",SqlDbType.VarChar,8)
                                        };
            parameters[0].Value = newPwd;
            parameters[1].Value = employee_id;
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
        /// 更新一条数据
        /// </summary>
        ///
        public bool Update(Model.Model_employee_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update employee_info set ");
            strSql.Append("guiyuan_id=@guiyuan_id,");
            strSql.Append("kehujingli_id=@kehujingli_id,");
            strSql.Append("name=@name,");
            strSql.Append("birthday=@birthday,");
            strSql.Append("identity_card_number=@identity_card_number,");
            strSql.Append("phone_number_1=@phone_number_1,");
            strSql.Append("phone_number_2=@phone_number_2,");
            strSql.Append("short_phone_number_1=@short_phone_number_1,");
            strSql.Append("short_phone_number_2=@short_phone_number_2,");
            strSql.Append("department=@department,");
            strSql.Append("job_level=@job_level,");
            strSql.Append("operate_level=@operate_level,");
            strSql.Append("ruhang_date=@ruhang_date,");
            strSql.Append("login_pwd=@login_pwd");
            strSql.Append(" where employee_id=@employee_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@guiyuan_id", SqlDbType.VarChar,12),
					new SqlParameter("@kehujingli_id", SqlDbType.VarChar,7),
					new SqlParameter("@name", SqlDbType.NVarChar,20),
					new SqlParameter("@birthday", SqlDbType.Date,3),
					new SqlParameter("@identity_card_number", SqlDbType.VarChar,18),
					new SqlParameter("@phone_number_1", SqlDbType.VarChar,11),
					new SqlParameter("@phone_number_2", SqlDbType.VarChar,11),
					new SqlParameter("@short_phone_number_1", SqlDbType.VarChar,4),
					new SqlParameter("@short_phone_number_2", SqlDbType.VarChar,4),
					new SqlParameter("@department", SqlDbType.NVarChar,50),
					new SqlParameter("@job_level", SqlDbType.NVarChar,50),
					new SqlParameter("@operate_level", SqlDbType.VarChar,3),
					new SqlParameter("@ruhang_date", SqlDbType.Date,3),
					new SqlParameter("@login_pwd", SqlDbType.NVarChar,50),
					new SqlParameter("@employee_id", SqlDbType.VarChar,8)};
            parameters[0].Value = model.guiyuan_id;
            parameters[1].Value = model.kehujingli_id;
            parameters[2].Value = model.name;
            parameters[3].Value = model.birthday;
            parameters[4].Value = model.identity_card_number;
            parameters[5].Value = model.phone_number_1;
            parameters[6].Value = model.phone_number_2;
            parameters[7].Value = model.short_phone_number_1;
            parameters[8].Value = model.short_phone_number_2;
            parameters[9].Value = model.department;
            parameters[10].Value = model.job_level;
            parameters[11].Value = model.operate_level;
            parameters[12].Value = model.ruhang_date;
            parameters[13].Value = model.login_pwd;
            parameters[14].Value = model.employee_id;

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

    }
}
