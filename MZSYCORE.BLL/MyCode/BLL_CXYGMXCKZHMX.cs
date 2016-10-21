using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    /// <summary>
    /// 查询员工名下存款账号明细
    /// </summary>
    public class BLL_CXYGMXCKZHMX
    {
        DAL.DAL_CXYGMXCKZHMX dal_cxygmxckzhmx = new DAL.DAL_CXYGMXCKZHMX();

        /// <summary>
        /// 根据绩效系统考核对象代号，获得该员工名下的存款账户明细。
        /// </summary>
        /// <param name="khdxdh"></param>
        /// <returns></returns>
        public DataSet GetCunKuanMingXiList(int khdxdh)
        {
            return dal_cxygmxckzhmx.GetCunKuanMingXiList(khdxdh);
        }
    }
}
