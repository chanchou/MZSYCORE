using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MZSYCORE.Web.Tools
{
    public class BasePage : System.Web.UI.Page
    {
        /// <summary>
        /// BasePage用户判断用户是否登录，如果没有登录，切换到主页面。
        /// </summary>

        public Model.Model_employee_info model_employee_info;
        public BasePage()
        {
            this.Load += new EventHandler(BasePage_Load);
        }
        void BasePage_Load(object sender, EventArgs e)
        {
            if (Session["employee_info"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else { 
            model_employee_info=Session["employee_info"] as Model.Model_employee_info;
            }
        }
    }
}
