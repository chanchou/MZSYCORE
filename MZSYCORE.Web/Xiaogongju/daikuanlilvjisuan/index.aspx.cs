using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tools;

namespace MZSYCORE.Web.Xiaogongju.daikuanlilvjisuan
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //点击计算按钮
        protected void btn_jisuan_Click(object sender, EventArgs e)
        {
            DateTime dt_qian = DateTime.Now, dt_hou = dt_qian;
            //获取起止时间
            if (tbox_day_qian.Text != "" && tbox_day_hou.Text != "")
            {
                //获取开始时间，结束时间
                dt_qian = ConventToDateTime.ConventStringToDateTime(tbox_day_qian.Text);
                dt_hou = ConventToDateTime.ConventStringToDateTime(tbox_day_hou.Text);
            }
            else
            {
                Context.Response.Write("<script language=javascript>alert('请输入正确的起止时间');</script>");
            }
            //获取利率
            decimal liLv = Convert.ToDecimal(tbox_lilv.Text);
            if (liLv <= 0)
            {
                Context.Response.Write("<script language=javascript>alert('请输入正确的贷款利率');</script>");
            }
            //获取本金
            decimal benJin = Convert.ToDecimal(tbox_jine.Text);
            List<decimal> lst = new List<decimal>();
            lst = CalInterest.CalInterestHuoQi(benJin, liLv, dt_qian, dt_hou);

            if (lst.Count != 0)
            {
                tbox_lixi.Text = Math.Round(lst[1], 2).ToString();
            }
        }

        //选定存款类型之后，默认利率显示出来。
        protected void ddl_leixing_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_lilv.Text = ddl_leixing.SelectedValue;
        }
    }
}