using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MZSYCORE.Web.PersonManager.DaoqiCunkuan
{
    public partial class index : Tools.BasePage
    {
        BLL.BLL_CBOD_TDACNACN bll = new BLL.BLL_CBOD_TDACNACN();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = bll.GetDaoQiDingCunList(model_employee_info);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            Response.Write("<script lanague='javascript'>alert('查询成功！')</script>");
        }
    }
}