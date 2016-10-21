using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
   public class BLL_XTB_DXTZ
    {
       DAL.DAL_XTB_DXTZ dal = new DAL.DAL_XTB_DXTZ();
       /// <summary>
        /// 增加一条数据
        /// </summary>
       public bool Add(Model.Model_XTB_DXTZ model)
       {
           return dal.Add(model);
       }

       
    }
}
