using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.AutoMessage
{
    public class AddressList
    {
        public AddressList(string name, string chenghu, string tel)
        {
            this._name = name;
            this._tel = tel;
            this._chenghu = chenghu;
        }
        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _tel;
        /// <summary>
        /// 手机号
        /// </summary>
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private string _chenghu;
        /// <summary>
        /// 称呼
        /// </summary>
        public string Chenghu
        {
            get { return _chenghu; }
            set { _chenghu = value; }
        }
        private string _employee_id;
        /// <summary>
        /// 行员号
        /// </summary>
        public string Employee_id
        {
            get { return _employee_id; }
            set { _employee_id = value; }
        }
    }
}
