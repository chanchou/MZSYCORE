using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.Xiaogongju.DaiKuanLiXiMingXi
{
    public partial class index : System.Web.UI.Page
    {
        BLL.BLL_ZiZao_DaiKuanLiXiMingXi bll_ZiZao_DaiKuanLiXiMingXi = new BLL.BLL_ZiZao_DaiKuanLiXiMingXi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 单击 计算按钮之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_jisuan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_daiKuanJinE.Text) && !string.IsNullOrEmpty(tbox_daiKuanLiLv.Text) && !string.IsNullOrEmpty(tbox_day_qian.Text) && !string.IsNullOrEmpty(tbox_day_hou.Text))
            {
                decimal benJin = Convert.ToDecimal(tbox_daiKuanJinE.Text);
                decimal liLv = Convert.ToDecimal(tbox_daiKuanLiLv.Text);
                DateTime qiShiRiQi = Common.Common.ConventStringToDateTime(tbox_day_qian.Text);
                DateTime jieShuRiQi = Common.Common.ConventStringToDateTime(tbox_day_hou.Text);
                Dictionary<string, decimal> dic = bll_ZiZao_DaiKuanLiXiMingXi.GetDaiKuanLiXiMingXi(qiShiRiQi, jieShuRiQi, liLv, benJin);
                this.Repeater1.DataSource = dic;
                this.Repeater1.DataBind();

            }
            else
            {
                Response.Write("<script language=javascript>alert('请将信息填写完整再计算！');</script>");
                return;
            }


        }
    }
}