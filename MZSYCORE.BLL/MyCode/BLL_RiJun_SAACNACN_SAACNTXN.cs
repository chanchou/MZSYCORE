using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MZSYCORE.BLL
{
    public class BLL_RiJun_SAACNACN_SAACNTXN
    {
        DAL.DAL_RiJun_SAACNACN_SAACNTXN dal_RiJun_SAACNACN_SAACNTXN = new DAL.DAL_RiJun_SAACNACN_SAACNTXN();


        public decimal CountRiJun(string zhanghao, DateTime qishiRiQi, DateTime jieshuRiqi, out string name, out string kaihuRiqi, out int bishuCount)
        {
            List<Model.Model_RiJun_SAACNACN_SAACNTXN> lst = GetModelList(zhanghao, qishiRiQi, jieshuRiqi);
            decimal huocunJiShu = 0;
            decimal result = 0;
            if (lst != null)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (i + 1 < lst.Count)
                    {
                        if (lst[i].ETLDT == lst[i + 1].ETLDT)
                        {
                            continue;
                        }
                        else
                        {
                            DateTime kaishiRiqi = Common.Common.ConventStringToDateTime(lst[i].ETLDT);
                            DateTime jiezhiRiqi = Common.Common.ConventStringToDateTime(lst[i + 1].ETLDT);
                            huocunJiShu += Common.Common.CountDay(kaishiRiqi, jiezhiRiqi) * (decimal)lst[i].SA_DDP_ACCT_BAL;
                        }
                    }
                    else
                    {
                        DateTime kaishiRiqi = Common.Common.ConventStringToDateTime(lst[i].ETLDT);
                        if (DateTime.Compare(kaishiRiqi, jieshuRiqi) == 0)
                        {
                            huocunJiShu += (decimal)lst[i].SA_DDP_ACCT_BAL;
                        }
                        else
                        {
                            huocunJiShu += (Common.Common.CountDay(kaishiRiqi, jieshuRiqi)) * (decimal)lst[i].SA_DDP_ACCT_BAL;
                        }
                    }
                }
                name = lst[0].SA_CUST_NAME;
                kaihuRiqi = lst[0].SA_OPAC_DT;
                bishuCount = lst.Count;
                result = huocunJiShu / Common.Common.CountDay(qishiRiQi, jieshuRiqi);
            }
            else
            {
                name = "";
                kaihuRiqi = "";
                bishuCount = 0;
            }
            return result;
        }

        public List<Model.Model_RiJun_SAACNACN_SAACNTXN> GetModelList(string zhanghao, DateTime qishiRiqi, DateTime jieshuRiqi)
        {
            return GetModelList(zhanghao, qishiRiqi.ToString("yyyyMMdd"), jieshuRiqi.ToString("yyyyMMdd"));
        }

        public List<Model.Model_RiJun_SAACNACN_SAACNTXN> GetModelList(string zhangHao, string qishiRiqi, string jieshuRiqi)
        {
            List<Model.Model_RiJun_SAACNACN_SAACNTXN> lst = new List<Model.Model_RiJun_SAACNACN_SAACNTXN>();
            DataSet ds = new DataSet();
            ds = dal_RiJun_SAACNACN_SAACNTXN.GetList(zhangHao, qishiRiqi, jieshuRiqi);
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Model.Model_RiJun_SAACNACN_SAACNTXN model = new Model.Model_RiJun_SAACNACN_SAACNTXN();
                    model = DataRowToModel(ds.Tables[0].Rows[i]);
                    lst.Add(model);
                }
            }
            return lst;
        }

        public Model.Model_RiJun_SAACNACN_SAACNTXN DataRowToModel(DataRow dr)
        {
            Model.Model_RiJun_SAACNACN_SAACNTXN model = new Model.Model_RiJun_SAACNACN_SAACNTXN();
            if (dr != null)
            {
                if (dr["ETLDT"] != null)
                {
                    model.ETLDT = dr["ETLDT"].ToString();
                }
                if (dr["SA_ACCT_NO"] != null)
                {
                    model.SA_ACCT_NO = dr["SA_ACCT_NO"].ToString();
                }
                if (dr["SA_CARD_NO"] != null)
                {
                    model.SA_CARD_NO = dr["SA_CARD_NO"].ToString();
                }
                if (dr["SA_OPAC_DT"] != null)
                {
                    model.SA_OPAC_DT = dr["SA_OPAC_DT"].ToString();
                }
                if (dr["SA_CUST_NAME"] != null)
                {
                    model.SA_CUST_NAME = dr["SA_CUST_NAME"].ToString();
                }
                if (dr["SA_CONNTR_NO"] != null)
                {
                    model.SA_CONNTR_NO = dr["SA_CONNTR_NO"].ToString();
                }
                if (dr["SA_CR_AMT"] != null)
                {
                    model.SA_CR_AMT = decimal.Parse(dr["SA_CR_AMT"].ToString());
                }
                if (dr["SA_DDP_ACCT_BAL"] != null)
                {
                    model.SA_DDP_ACCT_BAL = decimal.Parse(dr["SA_DDP_ACCT_BAL"].ToString());
                }
                if (dr["SA_DR_AMT"] != null)
                {
                    model.SA_DR_AMT = decimal.Parse(dr["SA_DR_AMT"].ToString());
                }
                if (dr["SA_TX_AMT"] != null)
                {
                    model.SA_TX_AMT = decimal.Parse(dr["SA_TX_AMT"].ToString());
                }
                if (dr["SA_RMRK"] != null)
                {
                    model.SA_RMRK = dr["SA_RMRK"].ToString();
                }
            }
            return model;
        }
    }
}
