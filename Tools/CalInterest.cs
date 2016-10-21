using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public class CalInterest
    {
        /// <summary>
        /// 活期利率计算。此方法不考虑复利，因为复利太难了。只是简单地根据天数计算。返回的数组，第一个是本金，第二个是利息，第三个是本息
        /// </summary>
        /// <param name="benJin">本金</param>
        /// <param name="liLv">年利率</param>
        /// <param name="dt_qian">开始时间</param>
        /// <param name="dt_hou">结束时间</param>
        /// <returns></returns>
        public static List<decimal> CalInterestHuoQi(decimal benJin, decimal liLv, DateTime dt_qian, DateTime dt_hou)
        {
            List<decimal> lst = new List<decimal>();
            lst.Add(benJin);
            int daycount = CountDate.CountDay(dt_qian, dt_hou);
            decimal lixi = benJin * liLv / 100 / 360 * daycount;
            lst.Add(lixi);
            decimal benxi = benJin + lixi;
            lst.Add(benxi);
            return lst;
        }

        /// <summary>
        /// 计算定存利率，全部按照自动转存来计算。返回list数组。第一个为本金，第二个为定存最后一期的利息，第三个为定存最后一期的本息。第四个为活期利息，第五个为活期本息。
        /// </summary>
        /// <param name="benJin">本金</param>
        /// <param name="dingCunliLv">定存利率</param>
        /// <param name="huoCunliLv">当前活存利率</param>
        /// <param name="cunQi">存期</param>
        /// <param name="dt_qian">开始时间</param>
        /// <param name="dt_hou">结束时间</param>
        /// <returns>返回list数组。第一个为本金，第二个为活期利息，第三个为活期本息。第四个是转存期数</returns>
        public static List<decimal> CalInterestDingQiZhuanCun(decimal benJin, decimal dingCunliLv, decimal huoCunliLv, int cunQi, DateTime dt_qian, DateTime dt_hou)
        {
            List<decimal> lst = new List<decimal>();
            //用于记录自动转存次数
            decimal count = 0;
            lst.Add(benJin);
            decimal dingCunliXi = 0, dingCunbenXi = 0;
            decimal huoCunliXi = 0, huocunbenXi = 0;
            ///如果结束时间大于开始时间加上存期，那么证明存期已满，在存期内享受定期利率。到期后如果还满足存期，那么一直循环。
            ///直到不再存期内的部分，享受活期利率。
            while (dt_hou >= dt_qian.AddMonths(cunQi))
            {
                int daycount = CountDate.CountDay(dt_qian, dt_qian.AddMonths(cunQi));
                dingCunliXi = benJin * dingCunliLv / 100 / 360 * daycount;
                dingCunbenXi = benJin + dingCunliXi;
                benJin = dingCunbenXi;
                dt_qian = dt_qian.AddMonths(cunQi);
                count++;
            }


            ///在存期内的定期利率计算完毕之后，开始计算活期利率
            ///
            //如果天数大于0，证明还有活期存在。那么就计算活期
            if (CountDate.CountDay(dt_qian, dt_hou) > 0)
            {
                huoCunliXi = dingCunbenXi * huoCunliLv / 100 / 360 * CountDate.CountDay(dt_qian, dt_hou);
                huocunbenXi = dingCunbenXi + huoCunliXi;
                lst.Add(huoCunliXi);
                lst.Add(huocunbenXi);
            }
            else
            {
                lst.Add(dingCunliXi);
                lst.Add(dingCunbenXi);
            }
            lst.Add(count);
            return lst;
        }
         /// <summary>
        /// 通知存款计提利息，不考虑是否存够天数
        /// </summary>
        /// <param name="benJin"></param>
        /// <param name="liLv"></param>

        /// <param name="dt_qian"></param>
        /// <param name="dt_hou"></param>
        /// <returns>返回list数组。第一个为本金，第二个为利息，第三个为本息</returns>
        public static decimal CalJitiLixi(decimal benJin, decimal liLv, DateTime dt_qian, DateTime dt_hou)
        {
            return CalInterestTongZhi(benJin, liLv, -1, dt_qian, dt_hou)[2];
        }

        /// <summary>
        /// 通知存款利率计算
        /// </summary>
        /// <param name="benJin"></param>
        /// <param name="liLv"></param>
        /// <param name="leiXing">选择是1还是7</param>
        /// <param name="dt_qian"></param>
        /// <param name="dt_hou"></param>
        /// <returns>返回list数组。第一个为本金，第二个为利息，第三个为本息</returns>
        public static List<decimal> CalInterestTongZhi(decimal benJin, decimal liLv, int leiXing, DateTime dt_qian, DateTime dt_hou)
        {
            List<decimal> lst = new List<decimal>();

            decimal liXi = 0, benXi = 0;
            int dayCount = CountDate.CountDay(dt_qian, dt_hou);
            //如果存够了通知天数，那么就按照相应利率执行。否则按照活期利率执行
            if (dayCount >= leiXing)
            {
                liXi = benJin * liLv / 100 / 360 * dayCount;
                benXi = liXi + benJin;
                lst.Add(benJin);
                lst.Add(liXi);
                lst.Add(benXi);
            }
            else
            {
                lst = CalInterestHuoQi(benJin, 0.385m, dt_qian, dt_hou);
            }
            return lst;
        }


    }
}
