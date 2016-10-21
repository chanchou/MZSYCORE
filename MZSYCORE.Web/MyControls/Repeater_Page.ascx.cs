using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MZSYCORE.Web.MyControls
{
    /// <summary>
    /// 用户自定义分页控件。调用该控件，需要将给该插件的PageSize、DataCount赋值
    /// </summary>
    public partial class Repeater_Page : System.Web.UI.UserControl
    {
        //定义控件的属性，包括记录条数，当前页码，每页显示条数
        /// <summary>
        /// 每页显示记录条数，如不设置，默认为10.
        /// </summary>
        private int pageSize;
        public int PageSize
        {
            //如果不设置，name默认为10.
            get
            {
                if (pageSize.Equals(0))
                {
                    pageSize = 10;
                }
                return pageSize;
            }
            set { pageSize = value; }
        }
        /// <summary>
        ///当前页码。如不设置，默认为1. 
        /// </summary>

        private int pageIndex;
        public int PageIndex
        {
            get
            {
                if (pageIndex.Equals(0))
                {
                    pageIndex = 1;
                }
                return pageIndex;
            }
            set { pageIndex = value; }
        }
        /// <summary>
        /// 记录总条数
        /// </summary>       
        public int DataCount
        {
            private get;
            set;
        }




        protected void Page_Load(object sender, EventArgs e)
        {           
                BindPagingHelperControl();           
        }

        /// <summary>
        /// 绑定分页控件的页码显示
        /// </summary>
        private void BindPageCount()
        {
            //计算出页码总数。
            int PageCount = (DataCount % PageSize) == 0 ? DataCount / PageSize : DataCount / PageSize + 1;
            //显示数据至控件
            lbl_datacount.Text = DataCount.ToString();
            lbl_pageCount.Text = PageCount.ToString();
            lbl_Index.Text = PageIndex.ToString();

        }

        /// <summary>
        /// 绑定分页控件。根据页面显示大小和当前页码数，绑定显示控件中的相关lable控件。并为控件中的lbtn按钮添加额外的参数。
        /// </summary>
        private void BindPagingHelperControl()
        {

            //计算出页码总数。
            int PageCount = (DataCount % PageSize) == 0 ? DataCount / PageSize : DataCount / PageSize + 1;
            //显示数据至控件
            lbl_datacount.Text = DataCount.ToString();
            lbl_pageCount.Text = PageCount.ToString();
            lbl_Index.Text = PageIndex.ToString();



            //使能。根据当前页码数设置控件的显示状态
            lbtn_firstPage.Enabled = PageIndex > 1;
            lbtn_prePage.Enabled = PageIndex > 1;
            lbtn_lastPage.Enabled = PageIndex < PageCount;
            lbtn_nextPage.Enabled = pageIndex < PageCount;

            //命令。为lbtn按钮设置相关的额外参数。参数为点击之后需要显示的页码。“首页”就是第一页，“末页”就是最后一页。上一页就是当前页-1，下一页就是当前页+1.
            lbtn_firstPage.CommandArgument = "1";
            lbtn_prePage.CommandArgument = (PageIndex - 1).ToString();
            lbtn_nextPage.CommandArgument = (PageIndex + 1).ToString();
            lbtn_lastPage.CommandArgument = PageCount.ToString();

        }
        /// <summary>
        /// 按照字面意思理解，为重新绑定数据。参数为当前页码，也就是说根据当前要显示的页码重新绑定数据。
        /// </summary>
        /// <param name="pageIndex">需要显示的页码数</param>
        private void ReBindData(int pageIndex)
        {
            PageIndex = pageIndex;
            //执行委托
            OnPageIndexChanged(new EventArgs());
            //重新绑定控件，使显示正常
            BindPagingHelperControl();
        }
        //定义一个委托类型
        public delegate void PageIndexChangedEventHandler(object sender, EventArgs e);
        public event PageIndexChangedEventHandler PageIndexChanged;
        protected virtual void OnPageIndexChanged(EventArgs e)
        {
            PageIndexChangedEventHandler handler = PageIndexChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //按钮点击事件
        //无论点击那个按钮，都是执行这个方法。根据他们额外参数commandargument的不同来执行重新绑定操作。
        protected void lbtnPage_Click(object sender, EventArgs e)
        {
            LinkButton lbtn = sender as LinkButton;
            ReBindData(int.Parse(lbtn.CommandArgument));
        }
    }
}