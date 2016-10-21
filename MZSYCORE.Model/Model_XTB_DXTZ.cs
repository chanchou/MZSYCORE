using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    /// <summary>
    /// Model_XTB_DXTZ:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Model_XTB_DXTZ
    {
        public Model_XTB_DXTZ()
        { }
        #region Model
        //private int _id;
        private string _hydh;
        private string _tel;
        private string _content;
        private DateTime? _sj;
        private string _zt;

        ///// <summary>
        ///// 这个字段为自增长字段，我认为删除掉不用
        ///// </summary>
        //public int ID
        //{
        //    set { _id = value; }
        //    get { return _id; }
        //}
        /// <summary>
        /// 这个字段可以不用
        /// </summary>
        public string HYDH
        {
            set { _hydh = value; }
            get { return _hydh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TEL
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTENT
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SJ
        {
            set { _sj = value; }
            get { return _sj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZT
        {
            set { _zt = value; }
            get { return _zt; }
        }
        #endregion Model

    }
}