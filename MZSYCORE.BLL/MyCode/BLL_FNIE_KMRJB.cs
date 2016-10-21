using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public partial class BLL_FNIE_KMRJB
    {
        DAL.DAL_FNIE_KMRJB dal = new DAL.DAL_FNIE_KMRJB();
        /// <summary>
        /// 根据日期和所属部门，获取实体的字典。日期格式为：20140101，所属部门为410826000，其中键为科目编号，值为实体模型
        /// 存储顺序为：数据日期0，机构编码1，部门号2，科目编码3，币种4，昨日借方余额5，昨日贷方余额6，本日借方发生额7，本日贷方发生额8，本日借方余额9，本日贷方余额10，上月末借方余额11，上月末贷方余额12，本月借方发生额13，本月大方发生额14
        /// </summary>
        /// <param name="date"></param>
        /// <param name="departcode"></param>
        /// <returns></returns>
        public Dictionary<string, Model.Model_FNIE_KMRJB> GetMessageModelDic(string date, string departcode)
        {
            return dal.GetMessageModelDic(date, departcode);
        }
    }
}
