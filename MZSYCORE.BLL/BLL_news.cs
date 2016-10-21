using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MZSYCORE.DAL;

namespace MZSYCORE.BLL
{
    public class BLL_news
    {
        DAL_news dal = new DAL_news();
        /// <summary>
        /// 按某个字段排序获得前n个数据列表
        /// </summary>
        /// <param name="topnum"></param>
        /// <param name="strWhere"></param>
        /// <param name="OrderByField"></param>
        /// <returns></returns>
        public DataSet GetListOrderBy(int topnum, string strWhere, string OrderByField)
        {
            return dal.GetListOrderBy(topnum, strWhere, OrderByField);
        }

        /// <summary>
        /// 增加一条新闻，如果不成功返回0。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(MZSYCORE.Model.Model_news model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 删除一条新闻
        /// </summary>
        /// <param name="news_id"></param>
        /// <returns></returns>
        public bool DeleteById(int news_id)
        {
            return dal.DeleteById(news_id);
        }

        /// <summary>
        /// 根据新闻编号，获得一个对象实体
        /// </summary>
        /// <param name="news_id"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_news GetModelById(int news_id)
        {
            return dal.GetModelById(news_id);
        }

        /// <summary>
        /// 获得数据列表，如果strwhere为空，那么就是获得所有数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<MZSYCORE.Model.Model_news> GetModeList(string strWhere)
        {
            //根据查询条件，获得所有的数据的数据集dataset
            DataSet ds = dal.GetList(strWhere);
            //将数据集转换为list集合
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 将datatable转换为list集合
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<MZSYCORE.Model.Model_news> DataTableToList(DataTable dt)
        {
            List<MZSYCORE.Model.Model_news> modeList = new List<MZSYCORE.Model.Model_news>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                MZSYCORE.Model.Model_news model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modeList.Add(model);
                    }
                }
            }
            return modeList;
        }

        ///// <summary>
        ///// 根据设定的页面大小和页码数，获得数据列表。默认按照行员号排序，不可更改
        ///// </summary>
        ///// <param name="pageSize">页面大小</param>
        ///// <param name="pageIndex">页码数</param>
        ///// <returns></returns>
        //public DataSet GetListByPage(int pageSize, int pageIndex)
        //{
        //    return dal.GetListByPage(pageSize, pageIndex);
        //}

        public DataSet GetListByPage(int startRow, int endRow)
        {
            return dal.GetListByPage(startRow, endRow);
        }



                /// <summary>
        /// 根据设定的页面大小、页码数和新闻发布人，获得数据列表。默认按照行员号排序，不可更改
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="publish_person"></param>
        /// <returns></returns>
        public DataSet GetListByPagePerson(int pageSize, int pageIndex, string publish_person)
        {
            //判断是否存在该用户publish_person发布的新闻，如果存在,那么执行。如果不存在，那么显示为空
            if (dal.ExistsByName(publish_person))
            {
                return dal.GetListByPagePerson(pageSize, pageIndex, publish_person);
            }
            else
                return null;
        }


        /// <summary>
        /// 获取记录总条数。如果strwhere为空，那么就是取得所有的数据总条数
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

    }
}
