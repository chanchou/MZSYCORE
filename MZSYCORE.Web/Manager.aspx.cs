using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web
{
    public partial class Manager : MZSYCORE.Web.Tools.BasePage
    {
       // Model.Model_employee_info model_employee_info = new Model.Model_employee_info();
        public string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["employee_info"] != null)
            {
                model_employee_info = Session["employee_info"] as Model.Model_employee_info;
                name = model_employee_info.name;
            }
        }
    }
}