using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public class IncomeTax
    {
        ///// <summary>
        ///// 税前收入
        ///// </summary>
        //private decimal grossIncome;
        //public decimal GrossIncome
        //{
        //    get { return grossIncome; }
        //    set { grossIncome = value; }
        //}

        ///// <summary>
        ///// 五险一金
        ///// </summary>
        //private decimal insurance;
        //public decimal Insurance
        //{
        //    get { return insurance; }
        //    set { insurance = value; }
        //}
        ///// <summary>
        ///// 起征点
        ///// </summary>
        //private decimal threshold; 
        //public decimal Threshold
        //{
        //    get { return threshold; }
        //    set { threshold = value; }
        //}
        ///// <summary>
        ///// 年终奖
        ///// </summary>
        //private decimal yearAward;
        //public decimal YearAward
        //{
        //    get { return yearAward; }
        //    set { yearAward = value; }
        //}

        ///// <summary>
        ///// 构造函数
        ///// </summary>
        ///// <param name="grossIncome"></param>
        ///// <param name="insurance"></param>
        //public IncomeTax(decimal grossIncome, decimal insurance)
        //{
        //    this.grossIncome = grossIncome;
        //    this.insurance = insurance;
        //}
        //public IncomeTax(decimal grossIncome, decimal insurance,decimal threshold):this(grossIncome,insurance)
        //{
        //    this.Threshold = threshold;
        //}
        //public IncomeTax(decimal yearAward)
        //{
        //    this.yearAward = yearAward;
        //}
        //public IncomeTax(decimal grossIncome, decimal insurance, decimal yearAward)
        //    : this(grossIncome, insurance)
        //{
        //    this.yearAward = yearAward;
        //}

        /// <summary>
        /// 工资所得税计算，根据税前工资和五险一金来计算。
        /// </summary>
        /// <param name="grossIncome"></param>
        /// <param name="insurance"></param>
        /// <returns></returns>
        public static decimal CalSalaryIncomeTax(decimal grossIncome, decimal insurance,decimal threshold)
        {
            //应纳税收入为税前收入减去五险一金减去起征点
            decimal taxableIncome = grossIncome - insurance-threshold;
            decimal fatal = 0;
            //根据应纳税收入来计算应纳税额
            if (taxableIncome > 0 && taxableIncome <= 1500)
            {
                fatal = taxableIncome * 0.03m - 0;
            }
            else if (taxableIncome > 1500 && taxableIncome <= 4500)
            {
                fatal = taxableIncome * 0.1m - 105;
            }
            else if (taxableIncome > 4500 && taxableIncome <= 9000)
            {
                fatal = taxableIncome * 0.2m - 555;
            }
            else if (taxableIncome > 9000 && taxableIncome <= 35000)
            {
                fatal = taxableIncome * 0.25m - 1005;
            }
            else if (taxableIncome > 35000 && taxableIncome <= 55000)
            {
                fatal = taxableIncome * 0.3m - 2775;
            }
            else if (taxableIncome > 55000 && taxableIncome <= 80000)
            {
                fatal = taxableIncome * 0.35m - 5505;
            }
            else if (taxableIncome > 80000)
            {
                fatal = taxableIncome * 0.45m - 13505;
            }
            return fatal;
        }
        /// <summary>
        /// 年终奖所得税计算
        /// </summary>
        /// <param name="yearAward"></param>
        /// <returns></returns>
        public static decimal CalYearawardTax(decimal yearAward) 
        {
            decimal fatal = 0;
            //根据年终奖除以12所得，来选择对应的税率来计算。
            decimal flag = yearAward / 12;
            if (flag > 0 && flag <= 1500)
            {
                fatal = yearAward * 0.03m - 0;
            }
            else if (flag > 1500 && flag <= 4500)
            {
                fatal = yearAward * 0.1m - 105;
            }
            else if (flag > 4500 && flag <= 9000)
            {
                fatal = yearAward * 0.2m - 555;
            }
            else if (flag > 9000 && flag <= 35000)
            {
                fatal = yearAward * 0.25m - 1005;
            }
            else if (flag > 35000 && flag <= 55000)
            {
                fatal = yearAward * 0.3m - 2775;
            }
            else if (flag > 55000 && flag <= 80000)
            {
                fatal = yearAward * 0.35m - 5505;
            }
            else if (flag > 80000)
            {
                fatal = yearAward * 0.45m - 13505;
            }
            return fatal;
        }
    }
}
