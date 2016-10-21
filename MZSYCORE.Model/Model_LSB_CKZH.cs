using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    public class Model_LSB_CKZH
    {
        public Model_LSB_CKZH()
        { }
        #region Model
        private int _jxdxdh;
        private int _tjrq;
        private string _zhdh;
        private string _zzh;
        private string _zhhm;
        private string _bz;
        private string _cph;
        private string _kmh;
        private string _pzh;
        private string _fhdh;
        private string _jgdh;
        private string _khh;
        private int? _khrq;
        private int? _qxrq;
        private int? _dqrq;
        private int? _xhrq;
        private string _zhzt;
        private string _zhsx;
        private string _qx;
        private string _lldh;
        private decimal? _nll;
        private decimal? _khje;
        private decimal? _zhye;
        private string _zhbs;
        private string _hydh;
        private string _czyh;
        private string _gxhslx;
        private int? _khdxdh;
        private decimal? _xdje;
        private decimal? _xdll;
        private int? _xdbz;
        private decimal? _njs;
        private decimal? _zhnrjye;
        private string _psckbz;
        /// <summary>
        /// 绩效对象代号
        /// </summary>
        public int JXDXDH
        {
            set { _jxdxdh = value; }
            get { return _jxdxdh; }
        }
        /// <summary>
        /// 统计日期
        /// </summary>
        public int TJRQ
        {
            set { _tjrq = value; }
            get { return _tjrq; }
        }
        /// <summary>
        /// 账号
        /// </summary>
        public string ZHDH
        {
            set { _zhdh = value; }
            get { return _zhdh; }
        }
        /// <summary>
        /// 子账号
        /// </summary>
        public string ZZH
        {
            set { _zzh = value; }
            get { return _zzh; }
        }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string ZHHM
        {
            set { _zhhm = value; }
            get { return _zhhm; }
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
        /// 产品号
        /// </summary>
        public string CPH
        {
            set { _cph = value; }
            get { return _cph; }
        }
        /// <summary>
        /// 科目号
        /// </summary>
        public string KMH
        {
            set { _kmh = value; }
            get { return _kmh; }
        }
        /// <summary>
        /// 凭证号
        /// </summary>
        public string PZH
        {
            set { _pzh = value; }
            get { return _pzh; }
        }
        /// <summary>
        /// 分行代号
        /// </summary>
        public string FHDH
        {
            set { _fhdh = value; }
            get { return _fhdh; }
        }
        /// <summary>
        /// 机构代号
        /// </summary>
        public string JGDH
        {
            set { _jgdh = value; }
            get { return _jgdh; }
        }
        /// <summary>
        /// 客户号
        /// </summary>
        public string KHH
        {
            set { _khh = value; }
            get { return _khh; }
        }
        /// <summary>
        /// 开户日期
        /// </summary>
        public int? KHRQ
        {
            set { _khrq = value; }
            get { return _khrq; }
        }
        /// <summary>
        /// 起息日期
        /// </summary>
        public int? QXRQ
        {
            set { _qxrq = value; }
            get { return _qxrq; }
        }
        /// <summary>
        /// 到期日期
        /// </summary>
        public int? DQRQ
        {
            set { _dqrq = value; }
            get { return _dqrq; }
        }
        /// <summary>
        /// 销户日期
        /// </summary>
        public int? XHRQ
        {
            set { _xhrq = value; }
            get { return _xhrq; }
        }
        /// <summary>
        /// 账户状态
        /// </summary>
        public string ZHZT
        {
            set { _zhzt = value; }
            get { return _zhzt; }
        }
        /// <summary>
        /// 账户属性
        /// </summary>
        public string ZHSX
        {
            set { _zhsx = value; }
            get { return _zhsx; }
        }
        /// <summary>
        /// 期限
        /// </summary>
        public string QX
        {
            set { _qx = value; }
            get { return _qx; }
        }
        /// <summary>
        /// 利率代号
        /// </summary>
        public string LLDH
        {
            set { _lldh = value; }
            get { return _lldh; }
        }
        /// <summary>
        /// 年利率
        /// </summary>
        public decimal? NLL
        {
            set { _nll = value; }
            get { return _nll; }
        }
        /// <summary>
        /// 开户金额
        /// </summary>
        public decimal? KHJE
        {
            set { _khje = value; }
            get { return _khje; }
        }
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal? ZHYE
        {
            set { _zhye = value; }
            get { return _zhye; }
        }
        /// <summary>
        /// 账户标识
        /// </summary>
        public string ZHBS
        {
            set { _zhbs = value; }
            get { return _zhbs; }
        }
        /// <summary>
        /// 行员代号
        /// </summary>
        public string HYDH
        {
            set { _hydh = value; }
            get { return _hydh; }
        }
        /// <summary>
        /// 操作员号
        /// </summary>
        public string CZYH
        {
            set { _czyh = value; }
            get { return _czyh; }
        }
        /// <summary>
        /// 关系函数类型
        /// </summary>
        public string GXHSLX
        {
            set { _gxhslx = value; }
            get { return _gxhslx; }
        }
        /// <summary>
        /// 考核对象代号
        /// </summary>
        public int? KHDXDH
        {
            set { _khdxdh = value; }
            get { return _khdxdh; }
        }
        /// <summary>
        /// 协定金额
        /// </summary>
        public decimal? XDJE
        {
            set { _xdje = value; }
            get { return _xdje; }
        }
        /// <summary>
        /// 协定利率
        /// </summary>
        public decimal? XDLL
        {
            set { _xdll = value; }
            get { return _xdll; }
        }
        /// <summary>
        /// 协定标志
        /// </summary>
        public int? XDBZ
        {
            set { _xdbz = value; }
            get { return _xdbz; }
        }
        /// <summary>
        /// 年积数
        /// </summary>
        public decimal? NJS
        {
            set { _njs = value; }
            get { return _njs; }
        }
        /// <summary>
        /// 账户年日均余额
        /// </summary>
        public decimal? ZHNRJYE
        {
            set { _zhnrjye = value; }
            get { return _zhnrjye; }
        }
        /// <summary>
        /// 派生存款标识
        /// </summary>
        public string PSCKBZ
        {
            set { _psckbz = value; }
            get { return _psckbz; }
        }
        #endregion Model

    }
}
