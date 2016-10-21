using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MZSYCORE.DAL
{
    public class DAL_ZiZao_DaiKuanLiXiMingXi
    {
        /// <summary>
        /// 根据起始日期，结束日期，利率，本金，计算出贷款的应还利息，并用字典保存。键为期数，值为利息
        /// </summary>
        /// <param name="qiShiRiQi"></param>
        /// <param name="daoQiRiQi"></param>
        /// <param name="liLv">年利率，没有%，比如10，即表示年利率为10%</param>
        /// <param name="benJin"></param>
        /// <returns></returns>
        public Dictionary<string, decimal> GetDaiKuanLiXiMingXi(DateTime qiShiRiQi, DateTime daoQiRiQi, decimal liLv, decimal benJin)
        {
            Dictionary<string, decimal> dic = new Dictionary<string, decimal>();
            DateTime jieXiRiQi = new DateTime(qiShiRiQi.Year, qiShiRiQi.Month, 21);
            int qiShu = 0;
            ///1.如果计息开始日期，一直早于结息日期，那么一直循环
            ///2.在循环体内
            ///     1.如果计息开始日期，早于当前月的21号即结息日
            ///             1.如果结息日早于到期日，那么计算利息（结息日期-计息开始日期）*本金*利率，
            ///             2.如果结息日晚于或等于到期日，那么计算利息计算利息（到期日期-计息开始日期）*本金*利率
            ///     2.如果计息开始日期，晚于当前月的21号即结息日
            ///             1.到期时间，晚于下月计息日，那么计算利息（结息日期-计息开始日期）*本金*利率，
            ///             2.到期时间，早于下月计息日，那么计算利息（到期日期-计息开始日期）*本金*利率，
            while (DateTime.Compare(qiShiRiQi, daoQiRiQi) <0)
            {
                if (DateTime.Compare(qiShiRiQi, jieXiRiQi) < 0)
                {
                    decimal liXi = 0;
                    string key = string.Empty;
                    if (DateTime.Compare(jieXiRiQi, daoQiRiQi) < 0)
                    {
                        liXi = GetInterest(benJin, liLv, qiShiRiQi, jieXiRiQi);
                        qiShu++;
                        key = string.Format("{0}:{1}:{2}", qiShu, jieXiRiQi.ToString("yyyy-MM-dd"),CountDay(qiShiRiQi,jieXiRiQi));
                    }
                    else
                    {
                        liXi = GetInterest(benJin, liLv, qiShiRiQi, daoQiRiQi) + benJin;
                        qiShu++;
                        key = string.Format("{0}:{1}:{2}", qiShu, daoQiRiQi.ToString("yyyy-MM-dd"),CountDay(qiShiRiQi,daoQiRiQi));
                    }
                    dic.Add(key, liXi);
                    qiShiRiQi = jieXiRiQi;
                    jieXiRiQi = jieXiRiQi.AddMonths(1);


                }
                else if (DateTime.Compare(qiShiRiQi, jieXiRiQi) >= 0)
                {
                    if (DateTime.Compare(jieXiRiQi.AddMonths(1), daoQiRiQi) < 0)
                    {
                        jieXiRiQi = jieXiRiQi.AddMonths(1);
                    }
                    else
                    {
                        jieXiRiQi = daoQiRiQi;
                    }
                    //if (DateTime.Compare(daoQiRiQi, jieXiRiQi) > 0)
                    //{
                    //    decimal liXi = GetInterest(benJin, liLv, qiShiRiQi, jieXiRiQi);
                    //    qiShu++;
                    //    string key = string.Format("{0} {1}", qiShu, jieXiRiQi.ToString("yyyy-MM-dd"));
                    //    dic.Add(key, liXi);
                    //    qiShiRiQi = jieXiRiQi;
                    //    if (DateTime.Compare(jieXiRiQi.AddMonths(1), daoQiRiQi) < 0)
                    //    {
                    //        jieXiRiQi = jieXiRiQi.AddMonths(1);
                    //    }
                    //    else
                    //    {
                    //        jieXiRiQi = daoQiRiQi;
                    //    }
                    //}
                    //else if (DateTime.Compare(daoQiRiQi, jieXiRiQi) <= 0)
                    //{
                    //    decimal liXi = GetInterest(benJin, liLv, qiShiRiQi, daoQiRiQi) + benJin;
                    //    qiShu++;
                    //    string key = string.Format("{0} {1}", qiShu, jieXiRiQi.ToString("yyyy-MM-dd"));
                    //    dic.Add(key, liXi);
                    //    qiShiRiQi = jieXiRiQi;
                    //    if (DateTime.Compare(jieXiRiQi.AddMonths(1), daoQiRiQi) < 0)
                    //    {
                    //        jieXiRiQi = jieXiRiQi.AddMonths(1);
                    //    }
                    //    else
                    //    {
                    //        jieXiRiQi = daoQiRiQi;
                    //    }
                    //}
                }
            }
            return dic;
        }

        /// <summary>
        /// 根据本金，年利率，天数来计算利息
        /// </summary>
        /// <param name="benJin">本金</param>
        /// <param name="liLv">年利率，格式为不含百分号。如10表示年利率10%</param>
        /// <param name="days">存放天数</param>
        /// <returns></returns>
        public decimal GetInterest(decimal benJin, decimal liLv, int days)
        {
            decimal liXi = benJin * liLv / 100 / 360 * days;
            return liXi;

        }
        /// <summary>
        /// 根据本金，年利率，时间段来计算利息
        /// </summary>
        /// <param name="benJin">本金</param>
        /// <param name="liLv">年利率，格式为不含百分号。如10表示年利率10%</param>
        /// <param name="qiShiRiQi">起始时间</param>
        /// <param name="jieShuRiQi">结束时间</param>
        /// <returns></returns>
        public decimal GetInterest(decimal benJin, decimal liLv, DateTime qiShiRiQi, DateTime jieShuRiQi)
        {
            int days = CountDay(qiShiRiQi, jieShuRiQi);
            return GetInterest(benJin, liLv, days);

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
