using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace MZSYCORE.BLL.Common
{
    public class Common
    {
        /// <summary>
        /// 根据字符串返回datetime。
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
        /// 将yyyyMMdd格式的日期变为yyyy-MM-dd
        /// </summary>
        /// <param name="yyyyMMdd"></param>
        /// <returns></returns>
        public static string yyyyMMddToYegang(string yyyyMMdd)
        {
            if (yyyyMMdd.Length == 8)
            {
                yyyyMMdd = yyyyMMdd.Substring(0, 4) + "-" + yyyyMMdd.Substring(4, 2) + "-" + yyyyMMdd.Substring(6, 2);
            }
            else
            {
                yyyyMMdd = "";
            }
            return yyyyMMdd;
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
    }
}
