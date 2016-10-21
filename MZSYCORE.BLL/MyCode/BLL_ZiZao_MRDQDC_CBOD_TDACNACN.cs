using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL.MyCode
{
    public class BLL_ZiZao_MRDQDC_CBOD_TDACNACN
    {
        DAL.MyCode.DAL_ZiZao_MRDQDC_CBOD_TDACNACN dal = new DAL.MyCode.DAL_ZiZao_MRDQDC_CBOD_TDACNACN();
          /// <summary>
        /// 根据到期日期，获取明日到期定存实体模型。日期格式为：20150101
        /// </summary>
        /// <param name="tomorrowdate"></param>
        /// <returns></returns>
        public List<Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN> GetModelList(string tomorrowdate)
        {
            return dal.GetModelList(tomorrowdate);
        }
    }
}
