using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public class DAL_CXYGMXCKZHMX
    {
        /// <summary>
        /// 根据绩效系统考核对象代号，获得该员工名下的存款账户明细。
        /// </summary>
        /// <param name="khdxdh"></param>
        /// <returns></returns>
        public DataSet GetCunKuanMingXiList(int khdxdh)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select ");
            sb.Append("T2.jxdxdh , T2.zhdh , T2.zhhm , T2.cph , T2.khrq, T2.dqrq, T2.nll, T2.zhye,  T2.tjrq, T2.khdxdh , T1.zlbl ");
            sb.Append("from DXGX_HYYJGX_CK T1 inner join jxdx_ckzh T2 on T1.jxdxdh=T2.jxdxdh ");
            sb.AppendFormat("where T1.khdxdh={0} and T1.jsrq=29991231 and T2.zhzt='0' and T2.xhrq > VARCHAR_FORMAT((current date),'yyyymmdd') ", khdxdh);
            sb.Append("union all ");
            sb.Append("select ");
            sb.Append("jxdxdh, zhdh, zhhm , cph, khrq, dqrq, nll, zhye,  tjrq, khdxdh, 100 ");
            sb.AppendFormat("from jxdx_ckzh where khdxdh={0} and gxhslx ='0'  and zhzt='0'", khdxdh);

            return DBUtility.DbHelperOleDb.Query(sb.ToString(),"Pas");

        }
    }
}
