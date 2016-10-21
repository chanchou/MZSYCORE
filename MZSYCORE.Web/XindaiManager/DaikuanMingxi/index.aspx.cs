using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Tools;

namespace MZSYCORE.Web.XindaiManager.DaikuanMingxi
{
    public partial class index : MZSYCORE.Web.Tools.BasePage
    {
        BLL.BLL_CBOD_LNLNSLNS bll = new BLL.BLL_CBOD_LNLNSLNS();
        public string employee_kehujinglibianhao;
        public string strWhere;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 根据所选项，生成查询条件语句。
        /// </summary>
        /// <returns></returns>
        private string CreatstrWhere(string employee_kehujinglibianhao)
        {
            StringBuilder str = new StringBuilder();
            //所属单位选择
            if (ddl_suoshudanwei.SelectedValue != "-1")
            {
                str.AppendFormat(" ln_belong_instn_cod = '{0}' ", ddl_suoshudanwei.SelectedValue);
            }
            else
            {
                str.AppendFormat("   ln_belong_instn_cod like '{0}%' ",Web_Constant.Jigouma);
            }
            //如果操作权限小于800，则证明为普通用户。否则为管理员，可以查看全部
            if (!string.IsNullOrEmpty(employee_kehujinglibianhao))
            {
                str.AppendFormat(" and ln_zhibiao_no='{0}' ", employee_kehujinglibianhao);
            }
            //账户状态选择
            if (ddl_zhanghuzhuangtai.SelectedValue != "-1")
            {
                str.AppendFormat(" and ln_acct_sts ='{0}' ", ddl_zhanghuzhuangtai.SelectedValue);
            }

            //客户类别选择
            if (ddl_kehuleibie.SelectedValue != "-1")
            {
                str.AppendFormat(" and LN_CUST_TYP = '{0}' ", ddl_kehuleibie.SelectedValue);
            }

            //选择未结清客户
            str.Append(" and ln_ln_bal >0 ");

            return str.ToString();
        }


        //点击查询按钮
        protected void btn_chaxun_Click(object sender, EventArgs e)
        {

            #region 判断客户经理权限
            //1.如果当前客户经理编号为空，那么判断是否为总经理以上权限，如果是则将客户经理编号设定为空。如果不是，弹出提示消息
            //2.如果客户经理不为空，那么查询客户经理名下贷款信息。
            if (string.IsNullOrEmpty(model_employee_info.kehujingli_id))
            {
                if (Convert.ToInt32(model_employee_info.operate_level) > 400)
                {
                    employee_kehujinglibianhao = "";
                }
                else
                {
                    Response.Write("<script language=javascript>alert('对不起，您不具有相应的权限。');</script>");
                    return;
                }
            }
            else
            {
                employee_kehujinglibianhao = model_employee_info.kehujingli_id;
            }

            #endregion
            strWhere = CreatstrWhere(employee_kehujinglibianhao);
            DataSet ds = bll.GetListKehujingliTaizhang(strWhere);
            string strHeader = "日期\t所属单位\t客户经理编号\t账户状态\t客户名称\t客户类别\t贷款总额\t贷款余额\t计息利率\t拨款日期\t到期日期\t结清日期\t";
            StringWriter sw = ExportToExcel.DataTableExportToExcel(ds.Tables[0], strHeader);

            //导出到excel。网上下载的
            string attachment_filename = string.Format("attachment; filename={0}.xls", DateTime.Now.ToString("yyyyMMdd") + model_employee_info.name + "贷款台账");
            Response.AddHeader("Content-Disposition", attachment_filename);
            Response.ContentType = "application/ms-excel";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            Response.Write(sw);
            Response.End();

        }


        /// <summary>
        /// 绑定显示到账户状态
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        protected string Bind_ln_acct_sts(object obj)
        {
            string str = obj.ToString();
            switch (str)
            {
                case "1":
                    return "正常";
                case "2":
                    return "逾期";
                case "3":
                    return "非应计";
                case "5":
                    return "结清";
                case "6":
                    return "部分逾期";
                default:
                    return "未知";
            }
        }

        /// <summary>
        /// 绑定显示到客户类别
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        protected string Bind_LN_CUST_TYP(object obj)
        {
            switch (obj.ToString())
            {
                case "1":
                    return "对私";
                case "2":
                    return "对公";
                default:
                    return "未知";
            }
        }

        /// <summary>
        /// 绑定显示所属单位
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        protected string Bind_ln_belong_instn_cod(object obj)
        {
            string str = obj.ToString();
            if (str == Web_Constant.YingyebuJigouma)
            {
                return Web_Constant.YingyebuMingcheng;
            }
            else if (str == Web_Constant.XiguoJigouma)
            {
                return Web_Constant.XiguoMingcheng;
            }
            else if (str == Web_Constant.HuagongJigouma)
            {
                return Web_Constant.HuagongMingcheng;
            }
            else if (str == Web_Constant.NanzhuangJigouma)
            {
                return Web_Constant.NanzhuangMingcheng;
            }
            else
            {
                return "未知";
            }
        }
    }
}