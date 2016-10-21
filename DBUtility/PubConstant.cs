using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public class PubConstant
    {
       /// <summary>
       /// 获取连接字符串。此方法默认获取的是web.config里的字符串。可根据实际需要修改。
       /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["mzsycore"].ConnectionString;
                return _connectionString;
            }
        }

        /// <summary>
        /// 获取web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName">数据库连接名称</param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[configName].ConnectionString;
            return connectionString;
        }

    }
}
