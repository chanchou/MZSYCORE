using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.PersonManager.CunKuanYeJiMingXi
{
    public partial class index : Tools.BasePage
    {
        BLL.BLL_CXYGMXCKZHMX bll_cxygmxckzhmx = new BLL.BLL_CXYGMXCKZHMX();
        BLL.BLL_pasinfo bll_pasinfo = new BLL.BLL_pasinfo();
        BLL.BLL_employee_info bll_employee_info = new BLL.BLL_employee_info();


        protected void Page_Load(object sender, EventArgs e)
        {
            BindDatasoure();
        }

        private void BindDatasoure()
        {
            ///1.根据行员号获得考核对象代号
            ///2.根据考核对象代号，获得数据列表
            ///3.将数据列表绑定到repeate控件。
            ///

            int khdxdh = bll_pasinfo.GetKaoHeDuiXiangDaiHaoByHangYuanHao(model_employee_info.employee_id);//根据行员号获得绩效系统的考核对象代号。
            DataSet ds = bll_cxygmxckzhmx.GetCunKuanMingXiList(khdxdh);//根据考核对象代号，获得该员工名下的存款明细。
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            
            
            if (model_employee_info.identity_card_number.Length == 18)//如果存在正规的身份证号，那么判断性别弹出消息。
            {
                int xingbie = int.Parse(model_employee_info.identity_card_number.Substring(16, 1)) % 2;
                if (xingbie != 0)
                {
                    Response.Write("<script lanague='javascript'>alert('唉哟喂！大爷楼上请。。。')</script>");
                }
                else
                {
                    Response.Write("<script lanague='javascript'>alert('这姑娘可真俊啊！')</script>");
                }
            }
        }

        public string ChangeChanPinHao(object chanpinhao)
        {
            switch (chanpinhao.ToString())
            {
                case "999TD110700":
                    return "单位通知存款";
                case "999TD110100":
                    return "单位定期存款";
                case "999SA110100":
                    return "单位活期";

                case "999SA000100":
                    return "银行卡";
                case "999SA000101":
                    return "个人活期存折";
                case "999TD000700":
                    return "个人通知存款";
                case "999TD000200":
                    return "个人定期";
                case "999TD000203":
                    return "益农存";
                case "":
                    return "";

                default:
                    return chanpinhao.ToString();
            }

        }
    }
}