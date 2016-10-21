using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tools;

namespace MZSYCORE.Web.Xiaogongju.CunkuanLilvJisuan
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //点击计算按钮
        protected void btn_jisuan_Click(object sender, EventArgs e)
        {
            ///根据用户的选择，来调用不同的利率计算方法
            ///
            DateTime dt_qian=DateTime.Now, dt_hou=dt_qian;
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
            //创建数组用于保存计算结果
            List<decimal> lst = new List<decimal>();
            //获取本金和利率
            decimal benJin = Convert.ToDecimal(tbox_jine.Text);

            decimal liLv = Convert.ToDecimal(tbox_lilv.Text);
            if (liLv <= 0)
            {
                Context.Response.Write("<script language=javascript>alert('请输入正确的存款利率');</script>");               
            }
            //根据类型选择计算方法
            switch (ddl_leixing.SelectedItem.Text)
            {
                case "活期":
                    lst = CalInterest.CalInterestHuoQi(benJin, liLv, dt_qian, dt_hou);                                
                    break;
                case "整存整取三个月":
                    lst = CalInterest.CalInterestDingQiZhuanCun(benJin, liLv, 0.35m, 3, dt_qian, dt_hou);
                    break;
                case "整存整取六个月":
                    lst = CalInterest.CalInterestDingQiZhuanCun(benJin, liLv, 0.35m, 6, dt_qian, dt_hou);
                    break;
                case "整存整取一年":
                    lst = CalInterest.CalInterestDingQiZhuanCun(benJin, liLv, 0.35m, 12, dt_qian, dt_hou);
                    break;
                case "整存整取两年":
                    lst = CalInterest.CalInterestDingQiZhuanCun(benJin, liLv, 0.35m, 24, dt_qian, dt_hou);
                    break;
                case "整存整取三年":
                    lst = CalInterest.CalInterestDingQiZhuanCun(benJin, liLv, 0.35m, 36, dt_qian, dt_hou);
                    break;
                case "整存整取五年":
                    lst = CalInterest.CalInterestDingQiZhuanCun(benJin, liLv, 0.35m, 60, dt_qian, dt_hou);
                    break;
                case "通知一天":
                    lst = CalInterest.CalInterestTongZhi(benJin, liLv, 1, dt_qian, dt_hou);
                    break;
                case "通知七天":
                    lst = CalInterest.CalInterestTongZhi(benJin, liLv, 7, dt_qian, dt_hou);
                    break;
                default:
                    break;

            }
            //前台显示本息
            if (lst.Count!= 0)
            {
                tbox_benxizonge.Text = Math.Round(lst[2], 2).ToString();
            }

        }

        //选定存款类型之后，默认利率显示出来。
        protected void ddl_leixing_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_lilv.Text = ddl_leixing.SelectedValue;
        }
    }
}