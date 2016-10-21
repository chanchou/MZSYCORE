using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBUtility
{
    public class DbHelperSQL
    {

        /// <summary>
        ///获取数据库连接字符串（web.config来配置）
        /// </summary>
        public static string connectionString_mzsycore = "server=32.188.144.8;database=mzsycore;uid=sa;pwd=sqlservermzsy";
        public static string connectionString_nhjjda = "server=32.188.144.9;database=nonghuxinxidangan;uid=sa;pwd=sa";

        public static bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            //执行当前语句，获得查询结果
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            //如果查询结果不为空，那么转换为数字，返回true。否则为0，返回false
            if ((object.Equals(obj, null)) || (object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }

            if (cmdresult == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 命令执行的预处理程序
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParms"></param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            //如果连接没有打开，那么打开连接
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            //制定sqlcommand对象cmd的连接，sql语句
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            //如果参数不为空，那么将参数添加到cmd对象中去。
            if (cmdParms != null)
            {
                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="strSql">查询语句</param>
        /// <returns></returns>
        public static DataSet Query(string strSql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString_mzsycore))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(strSql, connection);
                    sda.Fill(ds, "ds");
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);

                }
                return ds;
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet  mzsycore  nhjjda
        /// </summary>
        /// <param name="strSql">查询语句</param>
        /// <returns></returns>
        public static DataSet Query(string whichDB,string strSql)
        {
           
            string connectionStr = null;
            if (whichDB == "mzsycore")
            {
                connectionStr = connectionString_mzsycore;
            }
            else if (whichDB == "nhjjda")
            {
                connectionStr = connectionString_nhjjda;
            }
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(strSql, connection);
                    sda.Fill(ds, "ds");
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);

                }
                return ds;
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static DataSet Query(string strSql, params SqlParameter[] cmdParms)
        {
            //创建sql连接
            using (SqlConnection connection = new SqlConnection(connectionString_mzsycore))
            {
                //创建sqlcomm对象
                using (SqlCommand cmd = new SqlCommand())
                {
                    //预处理sqlcommand对象
                    PrepareCommand(cmd, connection, null, strSql, cmdParms);
                    //创建sqldataadapter对象
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            //将sda对象填充到ds中去，并命名为ds
                            sda.Fill(ds, "ds");
                            cmd.Parameters.Clear();
                        }
                        catch (SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        return ds;
                    }
                }
            }
        }


        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）
        /// </summary>
        /// <param name="strSql">计算查询结果语句</param>
        /// <returns></returns>
        public static object GetSingle(string strSql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString_mzsycore))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((object.Equals(obj, null) || (object.Equals(obj, System.DBNull.Value))))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (SqlException ex)
                    {
                        connection.Close();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 执行一条查询结果语句，返回查询结果（object）
        /// </summary>
        /// <param name="strSql">计算查询结果语句</param>
        /// <param name="cmdParms">查询结果语句的参数</param>
        /// <returns></returns>
        public static object GetSingle(string strSql, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString_mzsycore))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, strSql, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((object.Equals(obj, null)) || (object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static int ExecuteSql(string strSql, params SqlParameter[] cmdParms)
        {
            using(SqlConnection connection=new SqlConnection(connectionString_mzsycore))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, strSql, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (SystemException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数. mzsycore  nhjjda
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static int ExecuteSql(string whichDB,string strSql, params SqlParameter[] cmdParms)
        {
            string connectionStr = null;
            if(whichDB=="mzsycore")
            {
                connectionStr = connectionString_mzsycore;
            }
            else if (whichDB == "nhjjda")
            {
                connectionStr = connectionString_nhjjda;
            }
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, strSql, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (SystemException e)
                    {
                        throw e;
                    }
                }
            }
        }


        public static DataSet Query(string whichDB, string strSql, params SqlParameter[] cmdParms)
        {
            string connectionStr = null;
            if (whichDB == "mzsycore")
            {
                connectionStr = connectionString_mzsycore;
            }
            else if (whichDB == "nhjjda")
            {
                connectionStr = connectionString_nhjjda;
            }
            //创建sql连接
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                //创建sqlcomm对象
                using (SqlCommand cmd = new SqlCommand())
                {
                    //预处理sqlcommand对象
                    PrepareCommand(cmd, connection, null, strSql, cmdParms);
                    //创建sqldataadapter对象
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            //将sda对象填充到ds中去，并命名为ds
                            sda.Fill(ds, "ds");
                            cmd.Parameters.Clear();
                        }
                        catch (SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        return ds;
                    }
                }
            }
        }
    }
}
