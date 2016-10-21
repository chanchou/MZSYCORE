using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MZSYCORE.Web.employee
{
    public partial class index : System.Web.UI.Page
    {
        MZSYCORE.BLL.BLL_employee_info bll = new BLL.BLL_employee_info();

        //定义默认的页面大小和页面索引
        public int PageSize = 10, PageIndex;
        //定义数据总条数和页面总数
        public int PageCount, DataCount;


        protected void Page_Load(object sender, EventArgs e)
        {
            //当页面首次加载时
            if (!IsPostBack)
            {
                //首次加载时,当前页码为1.
                PageIndex = 1;

                //计算数据总条数和总页码,并显示到页面上
                DataCount = bll.GetRecordCount("");
                PageCount = (DataCount % PageSize) == 0 ? (DataCount / PageSize) : (DataCount / PageSize)+1;
                lbl_count.Text = DataCount.ToString();
                lbl_pageCount.Text = PageCount.ToString();

                //绑定数据源
                BindRepeater(PageSize, PageIndex);
            }

        }

        private void BindRepeater(int pageSize, int pageIndex)
        {
            DataSet ds = bll.GetListByPage(PageSize, pageIndex);
            Repeater1.DataSource = ds.Tables[0];
            Repeater1.DataBind();
            lbl_currentIndex.Text = pageIndex.ToString();

        }

        //点击首页按钮时，显示第一页内容
        protected void lbtn_firstPage_Click(object sender, EventArgs e)
        {
            PageSize = 10;
            PageIndex = 1;
            BindRepeater(PageSize, PageIndex);
        }

        //点击末页按钮，显示最后一页内容
        protected void lbtn_lastPage_Click(object sender, EventArgs e)
        {
            PageCount = Convert.ToInt32(lbl_pageCount.Text);
            BindRepeater(PageSize, PageCount);
        }

        //单击上一页按钮
        protected void lbtn_prePage_Click(object sender, EventArgs e)
        {
            //判断当前是否为第一页，如果是，那么不执行任何操作。
            PageIndex = Convert.ToInt32(lbl_currentIndex.Text);
            PageCount = Convert.ToInt32(lbl_pageCount.Text);
            int PageCurrent = Convert.ToInt32(lbl_currentIndex.Text);
            if (PageIndex == 1)
            {
                return;
            }
            else
            {
                BindRepeater(PageSize, PageIndex - 1);
            }
        }

        //点击下一页按钮
        protected void lbtn_nextPage_Click(object sender, EventArgs e)
        {
            //判断当前是否为最后一页，如果是，那么不执行任何操作。
            PageIndex = Convert.ToInt32(lbl_currentIndex.Text);
            PageCount = Convert.ToInt32(lbl_pageCount.Text);
            int PageCurrent = Convert.ToInt32(lbl_currentIndex.Text);
            if (PageIndex == PageCount)
            {
                return;
            }
            else
            {
                BindRepeater(PageSize, PageIndex + 1);
            }

        }
        //单击查询按钮
        protected void btn_Search_Click(object sender, EventArgs e)
        {
            //点击查询按钮，先确定是否存在记录，如果不存在，弹出消息。如果存在记录，那么显示该记录。
            string name=Request["username"];
            if(bll.ExistsByName(name))
            {
                List<Model.Model_employee_info> lst = new List<Model.Model_employee_info>();
                Model.Model_employee_info model = bll.GetModelByName(name);
                lst.Add(model);
                Repeater1.DataSource = lst;
                Repeater1.DataBind();
            }
            else
            {

            }
        }
    }
}