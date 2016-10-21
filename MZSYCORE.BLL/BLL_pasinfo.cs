using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_pasinfo
    {
        DAL.DAL_pasinfo dal = new DAL.DAL_pasinfo();

        /// <summary>
        /// 根据核心系统行员号获得绩效系统考核对象代号
        /// </summary>
        /// <param name="hangyuanhao">核心系统行员号</param>
        /// <returns></returns>
        public int GetKaoHeDuiXiangDaiHaoByHangYuanHao(string hangyuanhao)
        {
            return dal.GetKaoHeDuiXiangDaiHaoByHangYuanHao(hangyuanhao);
        }
    }
}
