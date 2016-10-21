using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_ZiZao_DaiKuanLiXiMingXi
    {
        DAL.DAL_ZiZao_DaiKuanLiXiMingXi dal = new DAL.DAL_ZiZao_DaiKuanLiXiMingXi();
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
            if (DateTime.Compare(qiShiRiQi, daoQiRiQi) < 0)
            {
                return dal.GetDaiKuanLiXiMingXi(qiShiRiQi, daoQiRiQi, liLv, benJin);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据本金，年利率，时间段来计算利息。在当期查询的，为当期应当结清利息。
        /// </summary>
        /// <param name="benJin">本金</param>
        /// <param name="liLv">年利率，格式为不含百分号。如10表示年利率10%</param>
        /// <param name="fangKuanRiQi">起始时间</param>
        /// <param name="daoQiRiQi">结束时间</param>
        /// <returns></returns>
        public decimal GetInterest(decimal benJin, decimal liLv, DateTime fangKuanRiQi, DateTime daoQiRiQi)
        {
            DateTime qiShiRiQi = fangKuanRiQi;
            DateTime jieShuRiQi = daoQiRiQi;
            //当前结息日，作为参照
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21);
            //结息周期一般为1个月，如果是小额贷款，那么是3个月。
            int period = 1;
            if (benJin <= 50000)
            {
                period = 3;
                dt = new DateTime(DateTime.Now.Year, (DateTime.Now.Month + (3 - DateTime.Now.Month % 3)), 21);
            }
            ///1.如果放款日期早于上个结息日，那么结息起始日为上个结息日，否则为放款日
            ///2.如果到期日期早于当前结息日，那么结息截止日为到日期，否则为本期结息日
            ///
            if (DateTime.Compare(fangKuanRiQi, dt.AddMonths(-period)) < 0)
            {
                qiShiRiQi = dt.AddMonths(-period);
            }
            if (DateTime.Compare(daoQiRiQi, dt) > 0)
            {
                jieShuRiQi = dt;
            }
            return dal.GetInterest(benJin, liLv, qiShiRiQi, jieShuRiQi);

        }


    }
}
