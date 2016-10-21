using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public class ConventToDateTime
    {
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

     
    }
}
