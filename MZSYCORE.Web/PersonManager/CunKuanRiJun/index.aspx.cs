using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.PersonManager.CunKuanRiJun
{
    public partial class index : System.Web.UI.Page
    {
        BLL.BLL_RiJun_SAACNACN_SAACNTXN bll_RiJun_SAACNACN_SAACNTXN = new BLL.BLL_RiJun_SAACNACN_SAACNTXN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_jisuan_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            string kaihuRiqi = string.Empty;
            int bishuCount = 0;
            decimal rijun = 0;
            string zhanghao = tbox_zhanghao.Text.Trim();
            DateTime qishiRiqi=DateTime.Now, jieshuRiqi=DateTime.Now;
            if (string.IsNullOrEmpty(tbox_day_qian.Text.Trim()) || string.IsNullOrEmpty(tbox_day_hou.Text.Trim()))
            {
                Response.Write("<script lanague='javascript'>alert('请选择起止日期。。。')</script>");
                return;
            }
            else
            {
                qishiRiqi = Common.Common.ConventStringToDateTime(tbox_day_qian.Text);
                jieshuRiqi = Common.Common.ConventStringToDateTime(tbox_day_hou.Text);
            }

            if (zhanghao.Length != 19 && zhanghao.Length != 22)
            {
                Response.Write("<script lanague='javascript'>alert('账号输入错误。。。')</script>");
                return;
            }
            else
            {
                rijun = bll_RiJun_SAACNACN_SAACNTXN.CountRiJun(zhanghao, qishiRiqi, jieshuRiqi, out name, out kaihuRiqi, out bishuCount);
                lbl_name.Text = name;
                lbl_kaihuriqi.Text = kaihuRiqi;
                lbl_yewubishu.Text = bishuCount.ToString();
                lbl_rijun.Text = rijun.ToString("0.00");
                Response.Write("<script lanague='javascript'>alert('计算完毕。')</script>");

            }
        }
    }
}