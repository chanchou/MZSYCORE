using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    [Serializable]
    public class Model_FNIE_KMRJB
    {
        /// <summary>
        /// Model_FNIE_KMRJB:实体类(属性说明自动提取数据库字段的描述信息)
        /// </summary>


        public Model_FNIE_KMRJB()
        { }
        #region Model
        private string _data_date;
        private string _unitcode;
        private string _deptcode;
        private string _subject_cd;
        private string _currency_cd;
        private decimal? _preday_debit_balance;
        private decimal? _preday_credit_balance;
        private decimal? _today_debit_amt;
        private decimal? _today_credit_amt;
        private decimal? _today_debit_balance;
        private decimal? _today_credit_balance;
        private decimal? _lastmonth_debit_balance;
        private decimal? _lastmonth_credit_balance;
        private decimal? _thismonth_debit_amt;
        private decimal? _thismonth_credit_amt;
        /// <summary>
        /// 
        /// </summary>
        public string DATA_DATE
        {
            set { _data_date = value; }
            get { return _data_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UNITCODE
        {
            set { _unitcode = value; }
            get { return _unitcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DEPTCODE
        {
            set { _deptcode = value; }
            get { return _deptcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SUBJECT_CD
        {
            set { _subject_cd = value; }
            get { return _subject_cd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CURRENCY_CD
        {
            set { _currency_cd = value; }
            get { return _currency_cd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PREDAY_DEBIT_BALANCE
        {
            set { _preday_debit_balance = value; }
            get { return _preday_debit_balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PREDAY_CREDIT_BALANCE
        {
            set { _preday_credit_balance = value; }
            get { return _preday_credit_balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TODAY_DEBIT_AMT
        {
            set { _today_debit_amt = value; }
            get { return _today_debit_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TODAY_CREDIT_AMT
        {
            set { _today_credit_amt = value; }
            get { return _today_credit_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TODAY_DEBIT_BALANCE
        {
            set { _today_debit_balance = value; }
            get { return _today_debit_balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TODAY_CREDIT_BALANCE
        {
            set { _today_credit_balance = value; }
            get { return _today_credit_balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? LASTMONTH_DEBIT_BALANCE
        {
            set { _lastmonth_debit_balance = value; }
            get { return _lastmonth_debit_balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? LASTMONTH_CREDIT_BALANCE
        {
            set { _lastmonth_credit_balance = value; }
            get { return _lastmonth_credit_balance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? THISMONTH_DEBIT_AMT
        {
            set { _thismonth_debit_amt = value; }
            get { return _thismonth_debit_amt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? THISMONTH_CREDIT_AMT
        {
            set { _thismonth_credit_amt = value; }
            get { return _thismonth_credit_amt; }
        }
        #endregion Model

    }
}
