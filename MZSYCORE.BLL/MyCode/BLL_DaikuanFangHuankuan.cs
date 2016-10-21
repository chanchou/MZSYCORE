using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_DaikuanFangHuankuan
    {
        DAL.DAL_DaikuanFangHuankuan dal = new DAL.DAL_DaikuanFangHuankuan();


        /// <summary>
        /// 根据日期和借还标志，获取数据列表。日期不可为空，借还标志可为空
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="huanfangkuanflag">借还标志，即位借贷标志</param>
        /// <returns></returns>
        public DataSet GetList(string date, string huanfangkuanflag)
        {
            return dal.GetList(date, huanfangkuanflag);
        }
    }
}
