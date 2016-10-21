using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL.MyCode
{
   public class BLL_ZiZao_BirthdayMessage
    {
       DAL.MyCode.DAL_ZiZao_BirthdayMessage dal = new DAL.MyCode.DAL_ZiZao_BirthdayMessage();
        /// <summary>
        /// 根据所输入的日期，获得对象列表。日期格式为："01-01"
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
       public List<MZSYCORE.Model.Model_ZiZao_BirthdayMessage> GetModelList(string MMdd)
       {
           return dal.GetModelList(MMdd);
       }
    }
}
