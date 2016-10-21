using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
   public partial class BLL_CBOD_GLACAACA
    {
       DAL.DAL_CBOD_GLACAACA dal = new DAL.DAL_CBOD_GLACAACA();

       /// <summary>
       /// 根据时间和部门，获取存放同业内部帐的数据字典。键值为内部帐账号，值值为内部帐余额
       /// </summary>
       /// <param name="department"></param>
       /// <param name="date"></param>
       /// <returns></returns>
       public Dictionary<string, decimal> GetCunFangTongYeDic(string department, string date)
       {
           return dal.GetCunFangTongYeDic(department, date);
       }
    }
}
