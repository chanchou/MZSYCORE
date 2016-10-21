using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.employee
{
    public partial class changePWD : Tools.BasePage
    {
        BLL.BLL_employee_info bll = new BLL.BLL_employee_info();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //点击更改按钮
        protected void btn_changepwd_Click(object sender, EventArgs e)
        {
            
            bool flag = bll.ChangePwd(model_employee_info.employee_id, tbox_NewPwd.Text.Trim(), tbox_NewPwd_repeat.Text.Trim());
            //修改之后，弹出窗口，并跳转到当前页面
            if (flag)
            {
                Response.Write("<script lanaguage=javascript>alert('修改成功');location.href='changePWD.aspx'</script>");
            }
            else {
                Response.Write("<script lanaguage=javascript>alert('修改失败');location.href='changePWD.aspx'</script>");
            }
        }
    }
}