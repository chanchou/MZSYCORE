using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZSYCORE.Model
{
   public class Model_employee_info
    {
        #region Model
        private string _employee_id;
        private string _guiyuan_id;
        private string _kehujingli_id;
        private string _name;
        private DateTime? _birthday;
        private string _identity_card_number;
        private string _phone_number_1;
        private string _phone_number_2;
        private string _short_phone_number_1;
        private string _short_phone_number_2;
        private string _department;
        private string _job_level;
        private string _operate_level;
        private DateTime? _ruhang_date;
        private string _login_pwd;
        /// <summary>
        /// 
        /// </summary>
        public string employee_id
        {
            set { _employee_id = value; }
            get { return _employee_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string guiyuan_id
        {
            set { _guiyuan_id = value; }
            get { return _guiyuan_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string kehujingli_id
        {
            set { _kehujingli_id = value; }
            get { return _kehujingli_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string identity_card_number
        {
            set { _identity_card_number = value; }
            get { return _identity_card_number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string phone_number_1
        {
            set { _phone_number_1 = value; }
            get { return _phone_number_1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string phone_number_2
        {
            set { _phone_number_2 = value; }
            get { return _phone_number_2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string short_phone_number_1
        {
            set { _short_phone_number_1 = value; }
            get { return _short_phone_number_1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string short_phone_number_2
        {
            set { _short_phone_number_2 = value; }
            get { return _short_phone_number_2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string department
        {
            set { _department = value; }
            get { return _department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string job_level
        {
            set { _job_level = value; }
            get { return _job_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string operate_level
        {
            set { _operate_level = value; }
            get { return _operate_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ruhang_date
        {
            set { _ruhang_date = value; }
            get { return _ruhang_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string login_pwd
        {
            set { _login_pwd = value; }
            get { return _login_pwd; }
        }
        #endregion Model

        
    }
}
