using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MZSYCORE.Web.XindaiManager.DaikuanQianXi
{
    public partial class index : System.Web.UI.Page
    {
        BLL.BLL_XDXT_BUSINESS_DUEBILL bll_xdxt_business_duebill = new BLL.BLL_XDXT_BUSINESS_DUEBILL();
        BLL.BLL_employee_info bll_employee_info = new BLL.BLL_employee_info();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果是首次加载，那么绑定数据
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        public void BindRepeater()
        {
            DataSet ds = bll_xdxt_business_duebill.GetYuQiList("qianxi", "MANAGEUSERID");
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        public string BindJiGou(object obj)
        {
            string str = obj.ToString();
            if (str == Web_Constant.YingyebuJigouma)
            {
                return Web_Constant.YingyebuMingcheng;
            }
            else if (str == Web_Constant.XiguoJigouma )
            {
                return Web_Constant.XiguoMingcheng;
            }
            else if (str == Web_Constant.HuagongJigouma)
            {
                return Web_Constant.HuagongMingcheng;
            }
            else if (str == Web_Constant.NanzhuangJigouma)
            {
                return Web_Constant.NanzhuangMingcheng;
            }
            else 
            {
                return "未知";
            }
          
        }

        /// <summary>
        /// 根据客户经理查询客户姓名
        /// </summary>
        /// <param name="managerid"></param>
        /// <returns></returns>
        public string FindName(object managerid)
        {
            return bll_employee_info.FindNameByKehujingliId(managerid.ToString());
        }
        /// <summary>
        /// 根据字段求和
        /// </summary>
        /// <param name="ziduan"></param>
        /// <returns></returns>
        public decimal GetSum(string ziduan)
        {
           return bll_xdxt_business_duebill.GetSum(ziduan,"qianxi");
        }
        /// <summary>
        /// 根据字段计数
        /// </summary>
        /// <param name="ziduan"></param>
        /// <returns></returns>
        public int GetCount(string ziduan)
        {
            return bll_xdxt_business_duebill.GetCount(ziduan,"qianxi");
        }
        
    }
}