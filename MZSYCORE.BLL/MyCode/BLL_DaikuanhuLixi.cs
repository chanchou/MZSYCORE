using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_DaikuanhuLixi
    {
        DAL.DAL_DaikuanhuLixi dal = new DAL.DAL_DaikuanhuLixi();


        /// <summary>
        /// 根据客户经理编号，获取记录数
        /// </summary>
        /// <param name="kehujinglibianhao">不可为空</param>
        /// <returns></returns>
        public int GetRecordCount(string kehujinglibianhao)
        {
            return dal.GetRecordCount(kehujinglibianhao);
        }

        /// <summary>
        /// 根据客户经理编号，计息天数，每页开始行，每页结束行，来获取贷款户利息数据集。
        /// </summary>
        /// <param name="kehujinglibianhao">客户经理编号，不可为空，为空即不执行</param>
        /// <param name="dayCount">计息天数</param>
        /// <param name="rowStart">开始条数，（页码-1）*页面条数+1</param>
        /// <param name="rowEnd">结束条数，页码*页面条数</param>
        /// <returns></returns>
        public DataSet GetListByPage(string kehujinglibianhao, int dayCount, int rowStart, int rowEnd)
        {
            return dal.GetListByPage(kehujinglibianhao, dayCount, rowStart, rowEnd);
        }


        /// <summary>
        /// 根据客户经理编号，计息天数，来获取全量贷款户利息数据集
        /// </summary>
        /// <param name="kehujinglibianhao">客户经理编号，不可为空，为空即不执行</param>
        /// <param name="dayCount">计息天数</param>
        /// <returns></returns>
        public DataSet GetList(string kehujinglibianhao, int dayCount)
        {
            return dal.GetList(kehujinglibianhao, dayCount);
        }


        /// <summary>
        /// 根据客户经理编号和所选部门编号，来获取贷款户利息数据集
        /// </summary>
        /// <param name="kehujinglibianhao"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataSet GetList(string kehujinglibianhao,string bumenbianhao)
        {
            return dal.GetList(kehujinglibianhao,bumenbianhao);
        }


         /// <summary>
        /// 根据客户经理编号和用户所选择的部门、大小额类别，来获取贷款户利息数据集
        /// </summary>
        /// <param name="kehujinglibianhao"></param>
        /// <param name="bumen"></param>
        /// <param name="daxiaoe"></param>
        /// <returns></returns>
        public DataSet GetList(string kehujinglibianhao, string bumen, string daxiaoe)
        {
            return dal.GetList(kehujinglibianhao, bumen, daxiaoe);
        }
    }
}
