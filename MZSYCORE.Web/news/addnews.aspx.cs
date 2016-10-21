using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tools;

namespace MZSYCORE.Web.news
{
    public partial class addnews : MZSYCORE.Web.Tools.BasePage
    {
        BLL.BLL_news bll = new BLL.BLL_news();
        Model.Model_news model = new Model.Model_news();
        Model.Model_employee_info employeemodel = new Model.Model_employee_info();
        BLL.BLL_employee_info bll_employee_info = new BLL.BLL_employee_info();
        protected void Page_Load(object sender, EventArgs e)
        {
            employeemodel = Session["employee_info"] as Model.Model_employee_info;
        }

        protected void lbtn_save_Click(object sender, EventArgs e)
        {
            //执行上传文件操作
            if (fileupload.HasFile)
            {
                string upfilename = fileupload.FileName;
                string setpath = Server.MapPath("attachment");
                if (!System.IO.Directory.Exists(setpath))
                {
                    System.IO.Directory.CreateDirectory(setpath);
                }
                string newpath = setpath + "\\" + upfilename;
                fileupload.SaveAs(newpath);
                model.attachment_path = newpath;
            }

            else
            {
                model.attachment_path = null;
            }

            //为model各个属性赋值
            model.publish_date = DateTime.Now.Date;
            model.news_content = tbox_content.Text;
            model.news_title = tbox_title.Text;
            model.publish_person = employeemodel.name;

            //在数据库中添加新闻
            if (bll.Add(model) > 0)
            {
                //如果添加成功，那么给每个人发送短信，并弹出提示成功信息
                if (ckbSendMessage.Checked)
                {
                    ////注释项目，已被替换
                    //SendMessageFromPasDB sendmsg = new SendMessageFromPasDB();
                    //sendmsg.SendNewsMessage(model.publish_person, model.news_title);

                    SendNewsMessage(model.publish_person, model.news_title);

                }
                Response.Write("<script language=javascript>alert('添加成功');location.href='../news/index.aspx';</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('添加失败');location.href='../news/index.aspx';</script>");
            }
        }



        /// <summary>
        /// 发布新闻之后，给全行员工发送提醒
        /// </summary>
        /// <param name="publishPerson"></param>
        /// <param name="newsTitle"></param>
        /// <returns></returns>
        public void SendNewsMessage(string publishPerson, string newsTitle)
        {
            ///组装拼接短信内容
            ///提取电话号码，然后循环发送
            ///

            MZSY.XWPostMsg.XWPostMsg postMsg = new MZSY.XWPostMsg.XWPostMsg();

            //拼接短信内容
            StringBuilder message = new StringBuilder();
            message.AppendFormat("{0}刚刚在核心数据系统上发布了一条消息，标题为：“{1}”。如您需要，请登录 http://32.188.144.8 浏览！", publishPerson, newsTitle);

            //提取电话号码
            DataSet ds = bll_employee_info.GetXXList("phone_number_1", "");

            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    postMsg.PostSingle(message.ToString(), ds.Tables[0].Rows[i][0].ToString());
                }
            }

        }


    }
}