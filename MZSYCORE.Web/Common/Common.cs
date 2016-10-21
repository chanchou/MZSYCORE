using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MZSYCORE.Web.Common
{
    public class Common
    {
        /// <summary>
        /// 从webconfig中获取配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfigByWeb(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        /// <summary>
        /// 根据字符串返回datetime，字符串格式为：20151210或2015-12-10。
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime ConventStringToDateTime(string datetime)
        {
            if (datetime.Length == 8)
            {
                datetime = datetime.Substring(0, 4) + "-" + datetime.Substring(4, 2) + "-" + datetime.Substring(6, 2);
            }
            datetime = datetime.Replace('/', '-');
            return DateTime.ParseExact(datetime, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// 计算前后两个日期的天数（算头不算尾）
        /// </summary>
        /// <param name="dtQian"></param>
        /// <param name="endDay"></param>
        /// <returns></returns>
        public static int CountDay(DateTime startDay, DateTime endDay)
        {
            TimeSpan span = endDay.Subtract(startDay);
            return span.Days;

        }
        /// <summary>
        /// 字符串运算。运算符为+-*/
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operate"></param>
        /// <returns></returns>
        public static double StringYunsuan(string num1, string num2, string operate)
        {
            double result = -1024;
            double flt1 = double.Parse(num1);
            double flt2 = double.Parse(num2);
            switch (operate)
            {
                case "+":
                    result = flt1 + flt2;
                    break;
                case "-":
                    result = flt1 - flt2;
                    break;
                case "*":
                    result = flt1 * flt2;
                    break;
                case "/":
                    result = flt1 / flt2;
                    break;
            }
            return result;
        }
    }
}