using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_ToubaoJigouCunkuanZhanghuTongjibiao
    {
        BLL.BLL_LSB_CKZH bll_lsb_ckzh = new BLL_LSB_CKZH();
        public string GetShujuRiqi(string jigouma)
        {
            //select tjrq from lsb_ckzh where zhdh like '410826%' fetch first 1 rows only
            return bll_lsb_ckzh.GetSingZiduan("tjrq", string.Format(" zhdh like '{0}%' fetch first 1 rows only", jigouma)).ToString();
        }

        public List<Model.Model_LSB_CKZH> GetModelList(string jigouma)
        {
            string where = string.Format(" zhdh like '{0}%' ", jigouma);
            return bll_lsb_ckzh.GetModelList(where);
        }

        public string GetCunkuanZonge(string jigouma)
        {
            //select sum(zhye) from lsb_ckzh where zhdh like '410826%'
            return bll_lsb_ckzh.GetSingZiduan("sum(zhye)", string.Format(" zhdh like '{0}%'", jigouma)).ToString();
        }

        /// <summary>
        ///  根据客户号，从境内存款中筛选出。
        /// </summary>
        /// <param name="dicJingneiCunkuan"></param>
        /// <param name="gaoguanKehuhao"></param>
        /// <returns></returns>
        public Dictionary<string,decimal> GetGaoguancunkuan(Dictionary<string, decimal> dicJingneiCunkuan, List<string> gaoguanKehuhao)
        {
            Dictionary<string, decimal> dicResult = new Dictionary<string, decimal>();
            if (gaoguanKehuhao.Count != 0)
            {
                
                for (int i = 0; i < gaoguanKehuhao.Count; i++)
                {
                    if(dicJingneiCunkuan.ContainsKey(gaoguanKehuhao[i]))
                    {
                        dicResult.Add(gaoguanKehuhao[i], dicJingneiCunkuan[gaoguanKehuhao[i]]);
                    }
                }
            }
            return dicResult;
        }
    }
}
