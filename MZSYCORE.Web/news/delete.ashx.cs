using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MZSYCORE.Web.news
{
    /// <summary>
    /// delete 的摘要说明
    /// </summary>
    public class delete : IHttpHandler
    {
        MZSYCORE.BLL.BLL_news bll = new BLL.BLL_news();
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            if (context.Request["news_id"] != null)
            {
                int news_id = Convert.ToInt32(context.Request["news_id"]);
                if (bll.DeleteById(news_id))
                {
                    context.Response.Write("<script language=javascript>alert('删除成功');location.href='../news/index.aspx';</script>");
                }
                else
                {
                    context.Response.Write("<script language=javascript>alert('删除失败');location.href='../news/index.aspx';</script>");
                }

            }
            else
            {
                context.Response.Write("<script language=javascript>alert('参数缺失');location.href='../news/index.aspx';</script>");
            }            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}