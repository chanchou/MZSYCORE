using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_DianziYinhangShuju
    {
        DAL.DAL_DianziYinhangShuju dal_DianziYinhangShuju = new DAL.DAL_DianziYinhangShuju();


        public DataSet GetYinhangkaYouxiaohuHushuDS()
        {
            DataSet ds = dal_DianziYinhangShuju.GetYinhangkaYouxiaohuHushuDS();
            return ds;
        }

        public List<Model.Model_Zizao_Count> GetYinhangkaYouxiaohuHushuLst()
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            DataSet ds = GetYinhangkaYouxiaohuHushuDS();
            if (ds != null)
            {
                DataTable dr = ds.Tables[0];
                for (int i = 0; i < dr.Rows.Count; i++)
                {
                    Model.Model_Zizao_Count model = new Model.Model_Zizao_Count();
                    model = DataRowToModel(dr.Rows[i]);
                    lst.Add(model);
                }
            }
            return lst;
        }

        private Model.Model_Zizao_Count DataRowToModel(DataRow dr)
        {
            Model.Model_Zizao_Count model = new Model.Model_Zizao_Count();
            if (dr != null)
            {
                if (dr["JGM"] != null)
                {
                    model.JGM = dr["JGM"].ToString();
                }
                if (dr["Count"] != null)
                {
                    model.Count = decimal.Parse(dr["Count"].ToString());
                }
                try
                {
                    if (dr["Number"] != null)
                    {
                        model.Number = decimal.Parse(dr["Number"].ToString());
                    }
                }
                catch
                { }
            }
            return model;
        }

        public DataSet GetGerenwangyinJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            return dal_DianziYinhangShuju.GetGerenwangyinJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);
        }

        public DataSet GetQiyewangyinJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            return dal_DianziYinhangShuju.GetQiyewangyinJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);
        }

        public DataSet GetShoujiYinhangJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            return dal_DianziYinhangShuju.GetShoujiYinhangJiaoyiQingkuang(tongjiRiqiQian, tongjiRiqiHou);
        }
    }
}
