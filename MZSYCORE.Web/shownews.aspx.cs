using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web
{
    public partial class shownews : System.Web.UI.Page
    {
        BLL.BLL_news bll = new BLL.BLL_news();
        Model.Model_news model = new Model.Model_news();
        protected void Page_Load(object sender, EventArgs e)
        {
            string news_id = Context.Request["news_id"];
            model = bll.GetModelById(Convert.ToInt32(news_id));

            if (!IsPostBack)
            {
                lbl_person.Text = model.publish_person;
                lbl_date.Text = model.publish_date.ToShortDateString();
                lbl_title.Text = model.news_title;
                tbox_content.Text = model.news_content;      
                lbtn_attachment.Text = System.IO.Path.GetFileName(model.attachment_path);
            }
        }

        //单击下载附件的连接
        protected void lbtn_attachment_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(model.attachment_path);
                Response.Clear();
                Response.Charset = "GB2312";
                Response.ContentEncoding = System.Text.Encoding.UTF8;
                // 添加头信息，为"文件下载/另存为"对话框指定默认文件名
                Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode(System.IO.Path.GetFileName(model.attachment_path)));
                // 添加头信息，指定文件大小，让浏览器能够显示下载进度
                Response.AddHeader("Content-Length", file.Length.ToString());
                // 指定返回的是一个不能被客户端读取的流，必须被下载
                Response.ContentType = "application/ms-excel";
                // 把文件流发送到客户端
                Response.WriteFile(file.FullName);
                // 停止页面的执行
                //Response.End();     
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('系统出现以下错误://n" + ex.Message + "!//n请尽快与管理员联系.')</script>");
            }

        }
    }
}