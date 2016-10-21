using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MZSYCORE.BLL
{
    public class BLL_employee_info
    {
        DAL.DAL_employee_info dal = new DAL.DAL_employee_info();


         /// <summary>
        /// 根据条件获得所需字段
        /// </summary>
        /// <param name="XX">所需字段,仅限单条记录</param>
        /// <param name="TiaoJian">条件</param>
        /// <returns></returns>
        public object GetXXByTiaoJian(string XX, string TiaoJian)
        {
            return dal.GetXXByTiaoJian(XX, TiaoJian);
        }

        /// <summary>
        /// 根据客户经理编号获取姓名
        /// </summary>
        /// <param name="kehujingliid"></param>
        /// <returns></returns>
        public string FindNameByKehujingliId(string kehujingliid)
        {
            return dal.FindNameByKehujingliId(kehujingliid);
        }

        /// <summary>
        /// 通过名字判断是否存在该记录
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistsByName(string name)
        {
            return dal.ExistsByName(name);
        }
        /// <summary>
        /// 根据条件，获取记录总数。条件为空表示获取总记录
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 根据条件获取数据列表。如果条件为空，那么获得全部数据
        /// </summary>
        /// <param name="strWhere">例如："employee_id='00000155'"</param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 根据条件获取所需要的数据列表。如果条件为空，那么获得全部数据。数据列表字段不能为空
        /// </summary>
        /// <param name="XX">数据列表字段不能为空，包括“employee_id, guiyuan_id, kehujingli_id, name, birthday, identity_card_number, phone_number_1, phone_number_2, short_phone_number_1, short_phone_number_2, department, job_level, operate_level, ruhang_date, login_pwd”</param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetXXList(string XX, string strWhere)
        {
            return dal.GetXXList(XX, strWhere);
        }

        /// <summary>
        /// 根据设定的页面大小和页码数，获得数据列表。默认按照行员号排序，不可更改
        /// </summary>
        /// <param name="pageSize">页面大小</param>
        /// <param name="pageIndex">页码数</param>
        /// <returns></returns>
        public DataSet GetListByPage(int pageSize, int pageIndex)
        {
            return dal.GetListByPage(pageSize, pageIndex);
        }

        /// <summary>
        /// 根据行员号，获得一个对象实体模型
        /// </summary>
        /// <param name="employee_id"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_employee_info GetModelById(string employee_id)
        {
            return dal.GetModelById(employee_id);
        }



        /// <summary>
        /// 根据行员姓名，获得一个对象实体模型
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public MZSYCORE.Model.Model_employee_info GetModelByName(string name)
        {
            return dal.GetModelByName(name);
        }

        /// <summary>
        /// 根据用户名，修改密码。两个密码应当输入一致
        /// </summary>
        /// <param name="employee_id"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public bool ChangePwd(string employee_id, string newPwd, string newPwd2)
        {
            if (string.Equals(newPwd, newPwd2))
            {
                return dal.ChangePwd(employee_id, newPwd);
            }
            else
            {
                return false;
            }
        }
    }
}
