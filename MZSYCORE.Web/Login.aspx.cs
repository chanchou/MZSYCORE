using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web
{
    public partial class Login : System.Web.UI.Page
    {
        public string employee_id;
        BLL.BLL_employee_info bll = new BLL.BLL_employee_info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["employee_id"] != null)
            {
                employee_id = Request.Cookies["employee_id"].ToString();
            }
        }

        /// <summary>
        /// 点击登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_login_Click(object sender, EventArgs e)
        {
            //获取请求行员号和密码
            string employee_id = tbox_employee_id.Text.Trim();
            string login_pwd = tbox_loginpwd.Text;

            //创建实体模型，并根据行员号获得
            Model.Model_employee_info model = new Model.Model_employee_info();
            model = bll.GetModelById(employee_id);

            //如果model为空，那么提示不存在此行员。
            if (model == null)
            {
                //Tools.PageHelper.Alert(this,"不存在此行员，请重新输入","~/Login.aspx");
                Response.Write("<script lanague='javascript'>alert('不存在此行员，请重新输入')</script>");
                
                
            }
            else
            {
                //对比实体模型中的密码，如果一致，提示登录成功，并将model存入session。否则提示密码错误。
                if (model.login_pwd == login_pwd)
                {
                   Session["employee_info"] = model;
                   Response.Write("<script >alert('登录成功');window.location.href='Manager.aspx'</script>");
                   
                }
                else
                {
                    Response.Write("<script>alert('密码错误，请重新输入')</script>");
                    //Response.Redirect("../Login.aspx");

                }
            }

        }
    }
}