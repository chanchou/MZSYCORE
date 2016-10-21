using DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public partial class DAL_XTB_DXTZ
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Model_XTB_DXTZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("insert into pas.xtb_dxtz (tel,content,zt) values('{0}','{1}','{2}' );",model.TEL, model.CONTENT,model.ZT);
            //strSql.AppendFormat("insert into pas.xtb_dxtz (tel,content,sj,zt) values('{0}','{1}','{2}','{3}');", model.TEL, model.CONTENT, model.SJ, model.ZT);
            #region 放弃代码
            //strSql.Append("insert into XTB_DXTZ(");
            //strSql.Append("HYDH,TEL,CONTENT,SJ,ZT)");
            //strSql.Append(" values (");
            //strSql.Append("@TEL,@CONTENT,@SJ,@ZT)");
            //OleDbParameter[] parameters = {					
            //        new OleDbParameter("@HYDH", OleDbType.VarChar,12),
            //        new OleDbParameter("@TEL", OleDbType.VarChar,12),
            //        new OleDbParameter("@CONTENT", OleDbType.VarChar,1024),
            //        new OleDbParameter("@SJ", OleDbType.Date),
            //        new OleDbParameter("@ZT", OleDbType.VarChar,1)};

            //parameters[0].Value = model.HYDH;
            //parameters[1].Value = model.TEL;
            //parameters[2].Value = model.CONTENT;
            //parameters[3].Value = model.SJ;
            //parameters[4].Value = model.ZT; 
            #endregion

            int rows = DbHelperOleDb.ExecuteSql("pas", strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
