using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZSYCORE.Model
{
    public class Model_news
    {
        #region Model
        private int _news_id;
        private DateTime _publish_date;
        private string _publish_person;
        private string _news_title;
        private string _news_content;
        private string _attachment_path;
        /// <summary>
        /// 
        /// </summary>
        public int news_id
        {
            set { _news_id = value; }
            get { return _news_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime publish_date
        {
            set { _publish_date = value; }
            get { return _publish_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string publish_person
        {
            set { _publish_person = value; }
            get { return _publish_person; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string news_title
        {
            set { _news_title = value; }
            get { return _news_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string news_content
        {
            set { _news_content = value; }
            get { return _news_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attachment_path
        {
            set { _attachment_path = value; }
            get { return _attachment_path; }
        }
        #endregion Model
    }
}
