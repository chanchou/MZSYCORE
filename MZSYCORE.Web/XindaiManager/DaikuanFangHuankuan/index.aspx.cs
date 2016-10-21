using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.XindaiManager.DaikuanFangHuankuan
{
    public partial class index : System.Web.UI.Page
    {
        BLL.BLL_DaikuanFangHuankuan bll = new BLL.BLL_DaikuanFangHuankuan();
        public string date, huanfangkuanflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果不是首次加载，那么创建查询语句
            if (IsPostBack)
            {
                CreatStrSql();
            }
        }
        /// <summary>
        /// 根据前端用户所选，创建sql查询条件
        /// </summary>
        protected void CreatStrSql()
        {
            //如果没有选定日期
            if (tbox_date.Text != "")
            {
                //如果所选日期大于今日
                DateTime dt_tbox = DateTime.ParseExact(tbox_date.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                if (dt_tbox > DateTime.Now.AddDays(-1))
                {
                    Response.Write("<script language=javascript>alert('所选日期大于系统统计日期');</script>");
                }
                else
                {
                    //将时间转变为标准的时间，2014-11-11转变为20141111
                    string[] temp = tbox_date.Text.Split('-');
                    date = string.Join("", temp);
                    if (ddl_jiehuanflag.SelectedValue == "-1")
                    {
                        huanfangkuanflag = "";
                    }
                    else
                    {
                        huanfangkuanflag = ddl_jiehuanflag.SelectedValue;
                    }
                }
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        protected void BindRepeater()
        {
            DataSet ds = bll.GetList(date, huanfangkuanflag);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        /// <summary>
        /// 绑定查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(date))
            {
                BindRepeater();
            }
            else
            {
                Response.Write("<script language=javascript>alert('请选择查询日期');</script>");
            }
        }



        public string Bind_LN_DR_CR_COD(object obj)
        {
            switch (obj.ToString())
            {
                case "C":
                    return "还款";
                case "D":
                    return "放款";
                default:
                    return "未知";
            }
        }

        public string Bind_LN_ACCD_TYP(object obj)
        {
            switch (obj.ToString())
            {
                case "1":
                    return "正常放款";
                case "2":
                    return "垫付款";
                case "3":
                    return "催收款";
                case "4":
                    return "呆账";
                case "5":
                    return "什项收入";
                case "6":
                    return "保管款";
                default:
                    return "未知";
            }
        }

        public string Bind_LN_TX_OPUN_NO(object obj)
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
        public string Bind_LN_ACCD_SUB_CLSFN(object obj)
        {
            switch (obj.ToString())
            {
                case "S":
                    return "正常本金";
                case "T":
                    return "逾期本金";
                case "U":
                    return "非应计本金";                
                default:
                    return "未知";
            }
        }

    }
}