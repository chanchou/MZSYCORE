using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    public class Model_XDXT_BUSINESS_DUEBILL
    {


        private string _manageuserid;
        /// <summary>
        /// 客户经理编号
        /// </summary>
        public string MANAGEUSERID
        {
            set { _manageuserid = value; }
            get { return _manageuserid; }
        }
        private string _serialno;
        /// <summary>
        /// 贷款账号
        /// </summary>
        public string SERIALNO
        {
            set { _serialno = value; }
            get { return _serialno; }
        }
        private string _payinterestaccount;
        /// <summary>
        /// 还息账号
        /// </summary>
        public string PAYINTERESTACCOUNT
        {
            set { _payinterestaccount = value; }
            get { return _payinterestaccount; }
        }
        private string _customername;
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CUSTOMERNAME
        {
            set { _customername = value; }
            get { return _customername; }
        }
        private string _putoutdate;
        /// <summary>
        /// 发放日期
        /// </summary>
        public string PUTOUTDATE
        {
            set { _putoutdate = value; }
            get { return _putoutdate; }
        }
        private string _maturity;
        /// <summary>
        /// 到期日
        /// </summary>
        public string MATURITY
        {
            set { _maturity = value; }
            get { return _maturity; }
        }
        private decimal? _businesssum;
        /// <summary>
        /// 金额
        /// </summary>
        public decimal? BUSINESSSUM
        {
            set { _businesssum = value; }
            get { return _businesssum; }
        }
        private decimal? _actualbusinessrate;
        /// <summary>
        /// 执行利率
        /// </summary>
        public decimal? ACTUALBUSINESSRATE
        {
            set { _actualbusinessrate = value; }
            get { return _actualbusinessrate; }
        }
        private decimal? _balance;
        /// <summary>
        /// 借据金额
        /// </summary>
        public decimal? BALANCE
        {
            set { _balance = value; }
            get { return _balance; }
        }
        private decimal? _normalbalance;
        /// <summary>
        /// 正常余额
        /// </summary>
        public decimal? NORMALBALANCE
        {
            set { _normalbalance = value; }
            get { return _normalbalance; }
        }
        private decimal? _overduebalance;
        /// <summary>
        /// 逾期余额
        /// </summary>
        public decimal? OVERDUEBALANCE
        {
            set { _overduebalance = value; }
            get { return _overduebalance; }
        }
        private decimal? _dullbalance;
        /// <summary>
        /// 呆滞信息
        /// </summary>
        public decimal? DULLBALANCE
        {
            set { _dullbalance = value; }
            get { return _dullbalance; }
        }
        private decimal? _badbalance;
        /// <summary>
        /// 呆账余额
        /// </summary>
        public decimal? BADBALANCE
        {
            set { _badbalance = value; }
            get { return _badbalance; }
        }
        private decimal? _interestbalance1;
        /// <summary>
        /// 表内欠息余额
        /// </summary>
        public decimal? INTERESTBALANCE1
        {
            set { _interestbalance1 = value; }
            get { return _interestbalance1; }
        }
        private decimal? _interestbalance2;
        /// <summary>
        /// 表外欠息余额
        /// </summary>
        public decimal? INTERESTBALANCE2
        {
            set { _interestbalance2 = value; }
            get { return _interestbalance2; }
        }
        private decimal? _finebalance1;
        /// <summary>
        /// 本金罚息
        /// </summary>
        public decimal? FINEBALANCE1
        {
            set { _finebalance1 = value; }
            get { return _finebalance1; }
        }
        private decimal? _finebalance2;
        /// <summary>
        /// 利息罚息
        /// </summary>
        public decimal? FINEBALANCE2
        {
            set { _finebalance2 = value; }
            get { return _finebalance2; }
        }
        private string _updatedate;
        /// <summary>
        /// 更新日期
        /// </summary>
        public string UPDATEDATE
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        private string _manageorgid;
        /// <summary>
        /// 所属机构
        /// </summary>
        public string MANAGEORGID
        {
            set { _manageorgid = value; }
            get { return _manageorgid; }
        }
    }
}
