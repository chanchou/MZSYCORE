using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MZSYCORE.BLL
{
   public partial class BLL_CBOD_TDACNACN
    {
       DAL.DAL_CBOD_TDACNACN dal = new DAL.DAL_CBOD_TDACNACN();
       /// <summary>
        /// 根据员工号和当前时间获取到期一个月内的存款列表
        /// </summary>
        /// <param name="employee_id"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
       public DataSet GetDaoQiDingCunList(string employee_id)
       {
           //获取当前系统时间
           DateTime dt = DateTime.Now;
           return dal.GetDaoQiDingCunList(employee_id, dt);
       }

       public DataSet GetDaoQiDingCunList(Model.Model_employee_info model)
       {
           string employee_id;
           employee_id = model.employee_id;
           #region 权限调整。暂时禁用。
           //int operate_level = Convert.ToInt32(model.operate_level);
           ////如果操作权限为副行长以上，那么为admin,可以查询全行的。否则只能查询自己的
           //if (operate_level > 500)
           //{
           //    employee_id = "admin";
           //}
           //else
           //{
           //    employee_id = model.employee_id;
           //} 
           #endregion
           return GetDaoQiDingCunList(employee_id);
       }
    }
}
