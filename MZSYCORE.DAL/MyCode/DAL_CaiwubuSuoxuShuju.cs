using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace MZSYCORE.DAL
{

    public class DAL_CaiwubuSuoxuShuju
    {
     
        public DataSet GetDianziyinhangCountList(string whichTable, string date)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select JGM, count(JGM) as Count from jsrun.{0} where jgm like '{1}%' and CLOSEDATE is null and  OPENDATE <'{2}'group by JGM", whichTable,DAL_Constant.Jigouma, date);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
        }
        /// <summary>
        /// 获取电子银行的汇总求和集
        /// </summary>
        /// <param name="whichTable">wsyh_puser个人网银，wsyh_cuser手机银行，wsyh_eaccount企业网银</param>
        /// <param name="date">格式为yyyy-MM-dd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetDianziyinhangModelList(string whichTable, string date)
        {
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            DataSet ds = GetDianziyinhangCountList(whichTable, date);
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


        /// <summary>
        /// 根据日期，计算各机构银行开户数
        /// </summary>
        /// <param name="date">时间格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetYinhangkaCountModelList(string date)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select CR_OPUN_COD as JGM, count(CR_OPUN_COD) as Count from jsrun.cbod_CRCRDCRD where CR_OFC_CARD_BRH = '{0}'  and cr_cust_name is not null and CR_CRD_STS in ('1','2','4') and CR_OPCR_DATE<='{1}'group by CR_OPUN_COD",DAL_Constant.GuanlijigouJigouma ,date);
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            DataSet ds = DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
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

        /// <summary>
        /// 根据日期，计算各机构未结清贷款的数据
        /// </summary>
        /// <param name="date">时间格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetWeijieqingDaikuanhushuCountModelList(string date)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select ln_db_part_id as JGM,count(*) as Count from jsrun.cbod_lnlnslns where ln_db_part_id like '{0}%' and ln_ln_bal>0 group by ln_db_part_id",DAL_Constant.Jigouma);
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            DataSet ds = DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
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

        /// <summary>
        /// 根据日期，计算各机构本季度累放贷款
        /// </summary>
        /// <param name="date">时间格式为yyyyMMdd</param>
        /// <returns></returns>
        public List<Model.Model_Zizao_Count> GetBenjiduLeifangDaikuanCountModelList(string qishiRiqi, string jieshuRiqi)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select ln_db_part_id as JGM ,count(*) as Count,sum(ln_totl_ln_amt_hypo_amt) as Number from jsrun.cbod_lnlnslns where ln_db_part_id like '{0}%' and ln_frst_alfd_dt_n>={1} and ln_frst_alfd_dt_n<={2} group by ln_db_part_id",DAL_Constant.Jigouma, qishiRiqi, jieshuRiqi);
            List<Model.Model_Zizao_Count> lst = new List<Model.Model_Zizao_Count>();
            DataSet ds = DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
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

        /// <summary>
        /// 计算当前日期的信息员存款总余额
        /// </summary>
        /// <param name="date">yyyyMMdd</param>
        /// <returns></returns>
        public decimal SumXinxiyuanCunkuan(string date)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select sum(zbz) as Number from YJZB_HY_01 where tjrq={0} and zbdh=1007 and sdbs in(1) and khdxdh=any(select khdxdh from KHDX_JGCY where jgkhdxdh={1} and hydh not like 'XN%'  and qsrq<={0} and jsrq>={0})group by sdbs", date,DAL_Constant.JixiaoxitongXinxiyuanKHDXDH);
            decimal result = -1;
            object obj = DBUtility.DbHelperOleDb.GetSingle(sb.ToString(), "Pas");
            if (obj != null)
            {
                result = decimal.Parse(obj.ToString());
            }
            return result;

        }
        /// <summary>
        /// 获得当前月一个月内的到期定存，不包括定活两便和通知七天，不包括自动转存
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public decimal SumYigeyueDaoqiDingcun(DateTime date)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select sum(td_actu_amt) from jsrun.cbod_TDACNACN where td_td_acct_no like '{0}%'  and  td_cacct_tlr_no is null and td_dep_prd_n>7 and  td_due_dt like '{1}'", DAL_Constant.Jigouma, string.Format("{0}%", date.ToString("yyyyMM")));
            decimal result = -1;
            object obj = DBUtility.DbHelperOleDb.GetSingle(sb.ToString(), "Jsbmov");
            if (obj != null)
            {
                result = decimal.Parse(obj.ToString());
            }
            return result;
        }


        public Model.Model_Zizao_Count DataRowToModel(DataRow dr)
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
    }
}
