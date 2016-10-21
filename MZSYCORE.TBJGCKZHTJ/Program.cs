using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZSYCORE.TBJGCKZHTJ
{
    class Program
    {
        static void Main(string[] args)
        {

            string Jigouma = "410826";
            BLL.BLL_LSB_CKZH bll_LSB_CKZH = new BLL.BLL_LSB_CKZH();
            List<string> kehuhaoList = new List<string>();
            List<decimal> jineList = new List<decimal>();
            List<Model.Model_LSB_CKZH> modelList = new List<Model.Model_LSB_CKZH>();
            ///1.获取所有的数据集
            ///2.对数据集进行加工
            ///     根据科目号，筛选出个人存款、单位存款、代理财政性存款
            ///     根据存款种类及利率，计算出存款的利息
            modelList = bll_LSB_CKZH.GetModelList(string.Format("zhdh like '{0}%' ", Jigouma));

            //循环数据集
            for (int i = 0; i < modelList.Count; i++)
            {
                
            }

        }
    }
}
