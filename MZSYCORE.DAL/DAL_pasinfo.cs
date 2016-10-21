using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
   public class DAL_pasinfo
    {
       /// <summary>
       /// 根据核心系统行员号获得绩效系统考核对象代号
       /// </summary>
       /// <param name="hangyuanhao">核心系统行员号</param>
       /// <returns></returns>
       public int GetKaoHeDuiXiangDaiHaoByHangYuanHao(string hangyuanhao)
       {
           StringBuilder sb = new StringBuilder();
           sb.AppendFormat("select jxxtkhdxdh from pasinfo where hxxthyh='{0}'",hangyuanhao);
           Object obj = DBUtility.DbHelperSQL.GetSingle(sb.ToString());
           if (obj == null)
           {
               return 0;
           }
           else
           {
               return Convert.ToInt32(obj);
           }
       }
    }
}
