using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web
{
    public partial class Default : System.Web.UI.Page
    {
        BLL.BLL_news bll = new BLL.BLL_news();
        public int PageSize = 10;//页面显示信息条数
        public int PageIndex, PageCount, DataCount;
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果是首次加载，那么默认显示第一页内容，并将所有的数据条数和总页数显示到分页控件中去
            if (!IsPostBack)
            {
                lbl_pageIndex.Text = "1";
                int dataCount = bll.GetRecordCount("");
                int pageCount = (dataCount % PageSize) == 0 ? dataCount / PageSize : dataCount / PageSize + 1;
                lbl_dataCount.Text = dataCount.ToString();
                lbl_pageCount.Text = pageCount.ToString();
                BindRepeater();
            }
        }

        /// <summary>
        /// 根据当前页面大小和页码，获得数据列表，并绑定到repeaer控件中去
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        protected void BindRepeater()
        {
            ///绑定数据到repeater
            ///1.根据当前页面，获取数据集。
            ///2.重新设置分页中的按钮使能

            PageIndex=Convert.ToInt32(lbl_pageIndex.Text);
            int startRow = (PageIndex - 1) * PageSize + 1;
            int endRow = PageIndex * PageSize;
            DataSet ds = bll.GetListByPage(startRow, endRow);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            EnableLabel();

        }

        /// <summary>
        /// 设定分页的标签权限
        /// </summary>
        protected void EnableLabel()
        {
            lbtn_firstPage.Enabled = Convert.ToInt32(lbl_pageIndex.Text) > 1;
            lbtn_prePage.Enabled = Convert.ToInt32(lbl_pageIndex.Text) > 1;
            lbtn_lastPage.Enabled = Convert.ToInt32(lbl_pageIndex.Text) < Convert.ToInt32(lbl_pageCount.Text);
            lbtn_nextPage.Enabled = lbtn_lastPage.Enabled;
        }

       /// <summary>
       /// 点击首页
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void lbtn_firstPage_Click(object sender, EventArgs e)
        {
            lbl_pageIndex.Text = "1";
            BindRepeater();
        }

        /// <summary>
        /// 点击末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtn_lastPage_Click(object sender, EventArgs e)
        {
            lbl_pageIndex.Text = lbl_pageCount.Text;
            BindRepeater();
        }
        /// <summary>
        /// 点击上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtn_prePage_Click(object sender, EventArgs e)
        {
            lbl_pageIndex.Text = (Convert.ToInt32(lbl_pageIndex.Text) - 1).ToString();
            BindRepeater();
        }
        /// <summary>
        /// 点击下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtn_nextPage_Click(object sender, EventArgs e)
        {
            lbl_pageIndex.Text = (Convert.ToInt32(lbl_pageIndex.Text) + 1).ToString();
            BindRepeater();

        }


       
    }
}