using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.Model
{
    public class Model_ZiZao_BirthdayMessage
    {
        private string _cust_no;
        private string _cust_name;
        private string _gender;
        private string _birthday;
        private string _address;

        /// <summary>
        /// 客户编号
        /// </summary>
        public string CUST_NO
        {
            set { _cust_no = value; }
            get { return _cust_no; }
        }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string CUST_NAME
        {
            set { _cust_name = value; }
            get { return _cust_name; }
        }


        /// <summary>
        /// 客户性别，2是女，1是男
        /// </summary>
        public string GENDER
        {
            set { _gender = value; }
            get { return _gender; }
        }
        /// <summary>
        /// 生日日期，格式为2015-01-01
        /// </summary>
        public string BIRTHDAY
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        public string ADDRESS
        {
            set { _address = value; }
            get { return _address; }
        }
    }
}
