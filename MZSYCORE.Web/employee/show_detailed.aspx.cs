using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.employee
{
    public partial class show_detailed : System.Web.UI.Page
    {
        public Model.Model_employee_info model;
        BLL.BLL_employee_info bll = new BLL.BLL_employee_info();
        protected void Page_Load(object sender, EventArgs e)
        {
            string employee_id = Request["employee_id"];
            model = bll.GetModelById(employee_id);
        }

        protected void lbtn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}