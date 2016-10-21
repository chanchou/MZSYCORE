using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZSYCORE.BLL
{
   partial class BLL_CBOD_LNLNSLNS
    {
      
        /// <summary>
        /// 根据客户经理，所属单位和账户状态来获得数据列表
        /// </summary>
        /// <param name="suoshudanwei">所属单位</param>
        /// <param name="kehujingli">客户经理编号</param>
        /// <param name="zhanghuzhuangtai">账户状态</param>
        /// <returns></returns>
       public DataSet GetList(string suoshudanwei, string kehujingli, string zhanghuzhuangtai)
       {
           return dal.GetList(suoshudanwei, kehujingli, zhanghuzhuangtai);
       }

       public DataSet GetListKehujingliTaizhang(string strWhere)
       {
           return dal.GetListKehujingliTaizhang(strWhere);
       }
    }
}
