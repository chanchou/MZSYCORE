using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
   public  class CountDate
    {
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
