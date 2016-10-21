using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.Xiaogongju.daikuanlilvjisuan
{
    public partial class index2 : System.Web.UI.Page
    {
        BLL.BLL_XDXT_BUSINESS_DUEBILL bll_XDXT_BUSINESS_DUEBILL = new BLL.BLL_XDXT_BUSINESS_DUEBILL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_chaxun_Click(object sender, EventArgs e)
        {
            string name = tbox_daiKuanRenName.Text;
            if (string.IsNullOrEmpty(name))
            {
                Context.Response.Write("<script language=javascript>alert('请输入客户姓名');</script>");
            }
            else
            {
                List<Model.Model_XDXT_BUSINESS_DUEBILL> lst = bll_XDXT_BUSINESS_DUEBILL.GetModelListByName(name);
                if (lst == null)
                {
                    Context.Response.Write("<script language=javascript>alert('没有这个客户');</script>");
                }
                else
                {
                    lst = UpdateZhengChangLiXi(lst);
                    this.Repeater1.DataSource = lst;
                    this.Repeater1.DataBind();
                    Context.Response.Write("<script language=javascript>alert('查询成功');</script>");
                }
            }
        }

        private List<Model.Model_XDXT_BUSINESS_DUEBILL> UpdateZhengChangLiXi(List<Model.Model_XDXT_BUSINESS_DUEBILL> lst)
        {
            if (lst != null)
            {
                foreach (Model.Model_XDXT_BUSINESS_DUEBILL model in lst)
                {
                    //把NORMALBALANCE "正常金额"借用改成 正常利息
                    BLL.BLL_ZiZao_DaiKuanLiXiMingXi bll_ZiZao_DaiKuanLiXiMingXi = new BLL.BLL_ZiZao_DaiKuanLiXiMingXi();
                    DateTime fangkuanRiqi = Common.Common.ConventStringToDateTime(model.PUTOUTDATE);
                    DateTime daoqiRiqi = Common.Common.ConventStringToDateTime(model.MATURITY);
                    decimal benJin =decimal.Parse(model.BUSINESSSUM.ToString());
                    decimal liLv = decimal.Parse(model.ACTUALBUSINESSRATE.ToString());
                    model.NORMALBALANCE = bll_ZiZao_DaiKuanLiXiMingXi.GetInterest(benJin, liLv, fangkuanRiqi, daoqiRiqi);
                }
            }
            return lst;
        }


    }
}