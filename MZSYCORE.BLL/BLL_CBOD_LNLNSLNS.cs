using System;
using System.Data;
using System.Collections.Generic;
using MZSYCORE.Model;
namespace MZSYCORE.BLL
{
	/// <summary>
	/// BLL_CBOD_LNLNSLNS
	/// </summary>
	public partial class BLL_CBOD_LNLNSLNS
	{
		private readonly MZSYCORE.DAL.DAL_CBOD_LNLNSLNS dal=new MZSYCORE.DAL.DAL_CBOD_LNLNSLNS();
		public BLL_CBOD_LNLNSLNS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MZSYCORE.Model.Model_CBOD_LNLNSLNS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MZSYCORE.Model.Model_CBOD_LNLNSLNS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MZSYCORE.Model.Model_CBOD_LNLNSLNS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MZSYCORE.Model.Model_CBOD_LNLNSLNS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MZSYCORE.Model.Model_CBOD_LNLNSLNS> DataTableToList(DataTable dt)
		{
			List<MZSYCORE.Model.Model_CBOD_LNLNSLNS> modelList = new List<MZSYCORE.Model.Model_CBOD_LNLNSLNS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MZSYCORE.Model.Model_CBOD_LNLNSLNS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

