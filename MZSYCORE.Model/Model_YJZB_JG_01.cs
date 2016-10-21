using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{

    /// <summary>
    /// Model_YJZB_JG_01:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Model_YJZB_JG_01
    {
        public Model_YJZB_JG_01()
        { }
        #region Model
        private int _tjrq;
        private int _zbdh;
        private int _khdxdh;
        private string _sdbs;
        private string _tjkj;
        private string _bz;
        private decimal? _zbz;
        /// <summary>
        /// 统计日期
        /// </summary>
        public int TJRQ
        {
            set { _tjrq = value; }
            get { return _tjrq; }
        }
        /// <summary>
        /// 指标代号
        /// </summary>
        public int ZBDH
        {
            set { _zbdh = value; }
            get { return _zbdh; }
        }
        /// <summary>
        /// 考核对象代号
        /// </summary>
        public int KHDXDH
        {
            set { _khdxdh = value; }
            get { return _khdxdh; }
        }
        /// <summary>
        /// 时段标识
        /// </summary>
        public string SDBS
        {
            set { _sdbs = value; }
            get { return _sdbs; }
        }
        /// <summary>
        /// 统计口径
        /// </summary>
        public string TJKJ
        {
            set { _tjkj = value; }
            get { return _tjkj; }
        }
        /// <summary>
        /// 币种
        /// </summary>
        public string BZ
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 指标值
        /// </summary>
        public decimal? ZBZ
        {
            set { _zbz = value; }
            get { return _zbz; }
        }
        #endregion Model
    }
}

