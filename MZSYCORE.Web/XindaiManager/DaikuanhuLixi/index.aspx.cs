using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using Tools;
using System.IO;

namespace MZSYCORE.Web.XindaiManager.DaikuanhuLixi
{
    public partial class index : MZSYCORE.Web.Tools.BasePage
    {

        BLL.BLL_DaikuanhuLixi bll = new BLL.BLL_DaikuanhuLixi();

        protected void Page_Load(object sender, EventArgs e)
        {
                     
        }


    
     
    

        //点击查询导出按钮
        protected void btn_export_Click(object sender, EventArgs e)
        {
            ///点击查询按钮，不管其他操作，根据当前用户的客户经理编号，查询到数据集，并导出为excel
            ///

            string employee_id;
            #region 判断客户经理权限
            //1.如果当前客户经理编号为空，那么判断是否为总经理以上权限，如果是则将客户经理编号设定为K090000。如果不是，弹出提示消息
            //2.如果客户经理不为空，那么查询客户经理名下贷款信息。
            if (string.IsNullOrEmpty(model_employee_info.kehujingli_id))
            {
                if (Convert.ToInt32(model_employee_info.operate_level) > 400)
                {
                    employee_id = "K090000";
                }
                else
                {
                    Response.Write("<script language=javascript>alert('对不起，您不具有相应的权限。');</script>");
                    return;
                }
            }
            else
            {
                employee_id = model_employee_info.kehujingli_id;
            }

            #endregion

            //获取数据集        
            string bumenbianhao = ddl_danwei.SelectedValue;
            string daxiaoe = ddl_daxiaoe.SelectedValue;
            DataSet ds = bll.GetList(employee_id, bumenbianhao,daxiaoe);


            if (ds.Equals(null))
            {
                Response.Write("<script language=javascript>alert('对不起，您所查询的数据为空。');</script>");
            }

            //据集转变为stringwriter ,导出到excel。网上下载的
            #region 导出到excel
            //并将数据集转变为stringwriter 
            string strHeader = "客户经理\t客户姓名\t贷款总额\t贷款余额\t计息利率\t放款日期\t到期日期\t结清日期\t还款账号\t账户余额\t计息天数\t应收利息\t扣款后盈余\t";
            StringWriter sw = ExportToExcel.DataTableExportToExcel(ds.Tables[0], strHeader);
            //网上下载的
            string attachment_filename = string.Format("attachment; filename={0}.xls", DateTime.Now.ToString("yyyyMM") + model_employee_info.name +daxiaoe+ "贷款户结息数据");
            Response.AddHeader("Content-Disposition", attachment_filename);
            Response.ContentType = "application/ms-excel";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            Response.Write(sw);
            Response.End(); 
            #endregion
        }
    }
}