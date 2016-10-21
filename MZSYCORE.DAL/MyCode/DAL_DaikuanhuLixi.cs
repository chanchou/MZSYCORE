using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DBUtility;

namespace MZSYCORE.DAL
{
    public class DAL_DaikuanhuLixi
    {
        /// <summary>
        /// 根据客户经理编号，获取记录数
        /// </summary>
        /// <param name="kehujinglibianhao">不可为空</param>
        /// <returns></returns>
        public int GetRecordCount(string kehujinglibianhao)
        {
            //拼接sql语句
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1)  ");
            strSql.AppendFormat("from jsrun.cbod_lnlnslns where ln_db_part_id like '{0}%' and  ",DAL_Constant.Jigouma);

            //如果本月是季度，那么就显示所有，否则，只显示大额
            List<int> jidu = new List<int>() { 3, 6, 9, 12 };
            if (jidu.Contains(DateTime.Now.Month))
            {
                strSql.Append(" LN_LN_BAL>0 ");
            }
            else
            {
                strSql.Append(" LN_LN_BAL>50000 ");
            }

            //如果客户经理编号为空，那么就不查询。否则，检查是否为管理员，来查询全行或者本人
            if (!string.IsNullOrEmpty(kehujinglibianhao))
            {
                if (kehujinglibianhao !=DAL_Constant.XindaixitongGuanliyuanID)
                {
                    strSql.AppendFormat(" and LN_ZHIBIAO_NO ='{0}'", kehujinglibianhao);
                }
            }
            else
            {
                return 0;
            }

            object obj = DbHelperOleDb.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }


        }

        /// <summary>
        /// 根据客户经理编号，计息天数，每页开始行，每页结束行，来获取贷款户利息数据集。
        /// </summary>
        /// <param name="kehujinglibianhao">客户经理编号，不可为空，为空即不执行</param>
        /// <param name="dayCount">计息天数</param>
        /// <param name="rowStart"></param>
        /// <param name="rowEnd"></param>
        /// <returns></returns>
        public DataSet GetListByPage(string kehujinglibianhao, int dayCount, int rowStart, int rowEnd)
        {

            //拼接sql语句
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Row,LN_ZHIBIAO_NO,LN_CUST_NAME,LN_TOTL_LN_AMT_HYPO_AMT,LN_LN_BAL,ln_frst_intc_intr, LN_FRST_ALFD_DT_N, LN_DUE_DT_N, ln_clsd_dt_n,sa_avl_bal,yingshoulixi,huankuanzhuzhanghao,koukuanhouyingyu from ( ");
            strSql.Append(" select ROW_NUMBER() OVER ()AS Row, t1.*,t2.sa_avl_bal ,t2.sa_avl_bal-t1.yingshoulixi koukuanhouyingyu from ( ");
            strSql.Append("select LN_ZHIBIAO_NO, LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT , LN_LN_BAL, ln_frst_intc_intr, LN_FRST_ALFD_DT_N, LN_DUE_DT_N, ln_clsd_dt_n,  ");
            strSql.AppendFormat(" ln_totl_ln_amt_hypo_amt*ln_frst_intc_intr/100/360*{0} yingshoulixi, ", dayCount);
            strSql.Append(" case when length(LN_DEP_ACCT_NO)=22 then LN_DEP_ACCT_NO else (select cr_rsv_acct_no from jsrun.cbod_crcrdcom where fk_crcrd_key=LN_AUTO_DEDU_DEP_ACCT_NO_1) end huankuanzhuzhanghao ");
            strSql.AppendFormat(" from jsrun.cbod_lnlnslns where  ln_db_part_id like '{0}%' and  ",DAL_Constant.Jigouma);

            //如果本月是季度，那么就显示所有，否则，只显示大额
            List<int> jidu = new List<int>() { 3, 6, 9, 12 };
            if (jidu.Contains(DateTime.Now.Month))
            {
                strSql.Append(" LN_LN_BAL>0 ");
            }
            else
            {
                strSql.Append(" LN_LN_BAL>50000 ");
            }

            //如果客户经理编号为空，那么就不查询。否则，检查是否为管理员，来查询全行或者本人
            if (!string.IsNullOrEmpty(kehujinglibianhao))
            {
                if (kehujinglibianhao != DAL_Constant.XindaixitongGuanliyuanID)
                {
                    strSql.AppendFormat(" and LN_ZHIBIAO_NO ='{0}'", kehujinglibianhao);
                }
            }
            else
            {
                return null;
            }
            strSql.Append(")t1 left join jsrun.cbod_saacnamt t2 on t1.huankuanzhuzhanghao=t2.fk_saacn_key ) TT ");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1} ", rowStart, rowEnd);

            return DbHelperOleDb.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据客户经理编号，计息天数，来获取全量贷款户利息数据集
        /// </summary>
        /// <param name="kehujinglibianhao">客户经理编号，不可为空，为空即不执行</param>
        /// <param name="dayCount">计息天数</param>
        /// <returns></returns>
        public DataSet GetList(string kehujinglibianhao, int dayCount)
        {

            //拼接sql语句
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LN_ZHIBIAO_NO,LN_CUST_NAME,LN_TOTL_LN_AMT_HYPO_AMT,LN_LN_BAL,ln_frst_intc_intr, LN_FRST_ALFD_DT_N, LN_DUE_DT_N, ln_clsd_dt_n,huankuanzhuzhanghao,sa_avl_bal,yingshoulixi,sa_avl_bal-yingshoulixi koukuanhouyingyu from( ");
            strSql.Append("select LN_ZHIBIAO_NO , LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT , LN_LN_BAL , ln_frst_intc_intr , LN_FRST_ALFD_DT_N , LN_DUE_DT_N , ln_clsd_dt_n 	, LN_AUTO_DEDU_DEP_ACCT_NO_1,");
            strSql.AppendFormat("  ln_totl_ln_amt_hypo_amt*ln_frst_intc_intr/100/360*{0} 	yingshoulixi, ", dayCount);
            strSql.Append(" case when length(LN_DEP_ACCT_NO)=22 then LN_DEP_ACCT_NO else (select cr_rsv_acct_no from jsrun.cbod_crcrdcom where fk_crcrd_key=LN_AUTO_DEDU_DEP_ACCT_NO_1)	end  huankuanzhuzhanghao ");
            strSql.AppendFormat(" from jsrun.cbod_lnlnslns where  ln_db_part_id like '{0}%' and  ",DAL_Constant.Jigouma);

            //如果本月是季度，那么就显示所有，否则，只显示大额
            List<int> jidu = new List<int>() { 3, 6, 9, 12 };
            if (jidu.Contains(DateTime.Now.Month))
            {
                strSql.Append(" LN_LN_BAL>0 ");
            }
            else
            {
                strSql.Append(" LN_LN_BAL>50000 ");
            }

            //如果客户经理编号为空，那么就不查询。否则，检查是否为管理员，来查询全行或者本人
            if (!string.IsNullOrEmpty(kehujinglibianhao))
            {
                if (kehujinglibianhao != DAL_Constant.XindaixitongGuanliyuanID)
                {
                    strSql.AppendFormat(" and LN_ZHIBIAO_NO ='{0}'", kehujinglibianhao);
                }
            }
            else
            {
                return null;
            }
            strSql.Append(")t1 left join jsrun.cbod_saacnamt t2 on t1.huankuanzhuzhanghao=t2.fk_saacn_key  for read only with ur ");


            return DbHelperOleDb.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据客户经理编号，来获取贷款户利息数据集
        /// </summary>
        /// <param name="kehujinglibianhao"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataSet GetList(string kehujinglibianhao, string bumen)
        {
            //根据当前月，来设置计息开始时间和结束时间
            DateTime dtEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21);
            DateTime dtStart = dtEnd.AddMonths(-1);
            string dtStartStr = dtStart.ToString("yyyy-MM-dd");
            string dtEndStr = dtEnd.ToString("yyyy-MM-dd");
            int dtStartInt = Convert.ToInt32(dtStart.ToString("yyyyMMdd"));

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LN_ZHIBIAO_NO,LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT, LN_LN_BAL, ln_frst_intc_intr, LN_FRST_ALFD_DT_N, LN_DUE_DT_N, ln_clsd_dt_n, LN_AUTO_DEDU_DEP_ACCT_NO_1, sa_avl_bal,jixitianshu, yingshoulixi,sa_avl_bal-yingshoulixi koukuanhouyingyu ");
            strSql.Append(" from (");
            strSql.Append(" select LN_ZHIBIAO_NO,LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT , LN_LN_BAL , ln_frst_intc_intr , LN_FRST_ALFD_DT_N , LN_DUE_DT_N , ln_clsd_dt_n, LN_AUTO_DEDU_DEP_ACCT_NO_1, jixitianshu,  ln_totl_ln_amt_hypo_amt*ln_frst_intc_intr/100/360*jixitianshu yingshoulixi,sa_avl_bal ");
            strSql.Append(" from (");
            strSql.Append(" select LN_ZHIBIAO_NO,LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT , LN_LN_BAL , ln_frst_intc_intr , LN_FRST_ALFD_DT_N , LN_DUE_DT_N , ln_clsd_dt_n, LN_AUTO_DEDU_DEP_ACCT_NO_1, ");
            strSql.AppendFormat(" case when  (LN_FRST_ALFD_DT_N >= {0}) then (days('{1}')-days(left(char(LN_FRST_ALFD_DT_N),4)||'-'||substr(char(LN_FRST_ALFD_DT_N),5,2)||'-'||substr(char(LN_FRST_ALFD_DT_N),7,2))) else (days('{1}')-days('{2}')) end jixitianshu, ", dtStartInt, dtEndStr, dtStartStr);
            strSql.Append(" case when length(LN_DEP_ACCT_NO)=22 then LN_DEP_ACCT_NO else (select cr_rsv_acct_no from jsrun.cbod_crcrdcom where fk_crcrd_key=LN_AUTO_DEDU_DEP_ACCT_NO_1) end  huankuanzhuzhanghao ");
            strSql.AppendFormat("  from jsrun.cbod_lnlnslns where  ln_db_part_id like '{0}' and  ", bumen);



            //如果本月是季度，那么就显示所有，否则，只显示大额
            List<int> jidu = new List<int>() { 3, 6, 9, 12 };
            if (jidu.Contains(DateTime.Now.Month))
            {
                strSql.Append(" LN_LN_BAL>0 ");
            }
            else
            {
                strSql.Append(" LN_LN_BAL>50000 ");
            }

            //如果客户经理编号为空，那么就不查询。否则，检查是否为管理员，来查询全行或者本人
            if (!string.IsNullOrEmpty(kehujinglibianhao))
            {
                if (kehujinglibianhao != DAL_Constant.XindaixitongGuanliyuanID)
                {
                    strSql.AppendFormat(" and LN_ZHIBIAO_NO ='{0}'", kehujinglibianhao);
                }
            }
            else
            {
                return null;
            }
            strSql.Append(")T1 left join jsrun.cbod_saacnamt T2 on T1.huankuanzhuzhanghao=T2.fk_saacn_key)  for read only with ur ");


            return DbHelperOleDb.Query(strSql.ToString());

        }



        /// <summary>
        /// 根据客户经理编号和用户所选择的部门、大小额类别，来获取贷款户利息数据集
        /// </summary>
        /// <param name="kehujinglibianhao"></param>
        /// <param name="bumen"></param>
        /// <param name="daxiaoe"></param>
        /// <returns></returns>
        public DataSet GetList(string kehujinglibianhao, string bumen, string daxiaoe)
        {
            //根据当前月，来设置计息开始时间和结束时间           
            DateTime dtEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21);
            DateTime dtStart = dtEnd.AddMonths(-1);
            ///如果选择的是查询大额，那么计息开始时间为上个月的21号。否则查询的是小额，计息开始时间为上个季度底的21号
            if (daxiaoe == "大额")
            {
                dtStart = dtEnd.AddMonths(-1);
            }
            else
            {
                float flag = (float)(dtEnd.Month / 3);
                if (flag <= 1)
                {
                    dtStart = new DateTime((dtEnd.Year - 1), 12, 21);

                }
                else
                {
                    if (flag <= 2)
                    {
                        dtStart = new DateTime(dtEnd.Year, 3, 21);
                    }
                    else
                    {
                        if (flag <= 3)
                        {
                            dtStart = new DateTime(dtEnd.Year, 6, 21);
                        }
                        else
                        {
                            if (flag <= 4)
                            {
                                dtStart = new DateTime(dtEnd.Year, 9, 21);
                            }
                        }
                    }
                }
                //else 
                //else 
                //else 

            }
            string dtStartStr = dtStart.ToString("yyyy-MM-dd");
            string dtEndStr = dtEnd.ToString("yyyy-MM-dd");
            int dtStartInt = Convert.ToInt32(dtStart.ToString("yyyyMMdd"));

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LN_ZHIBIAO_NO,LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT, LN_LN_BAL, ln_frst_intc_intr, LN_FRST_ALFD_DT_N, LN_DUE_DT_N, ln_clsd_dt_n, LN_AUTO_DEDU_DEP_ACCT_NO_1, sa_avl_bal,jixitianshu, yingshoulixi,sa_avl_bal-yingshoulixi koukuanhouyingyu ");
            strSql.Append(" from (");
            strSql.Append(" select LN_ZHIBIAO_NO,LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT , LN_LN_BAL , ln_frst_intc_intr , LN_FRST_ALFD_DT_N , LN_DUE_DT_N , ln_clsd_dt_n, LN_AUTO_DEDU_DEP_ACCT_NO_1, jixitianshu,  LN_LN_BAL*ln_frst_intc_intr/100/360*jixitianshu yingshoulixi,sa_avl_bal ");
            strSql.Append(" from (");
            strSql.Append(" select LN_ZHIBIAO_NO,LN_CUST_NAME, LN_TOTL_LN_AMT_HYPO_AMT , LN_LN_BAL , ln_frst_intc_intr , LN_FRST_ALFD_DT_N , LN_DUE_DT_N , ln_clsd_dt_n, LN_AUTO_DEDU_DEP_ACCT_NO_1, ");
            strSql.AppendFormat(" case when  (LN_FRST_ALFD_DT_N >= {0}) then (days('{1}')-days(left(char(LN_FRST_ALFD_DT_N),4)||'-'||substr(char(LN_FRST_ALFD_DT_N),5,2)||'-'||substr(char(LN_FRST_ALFD_DT_N),7,2))) else (days('{1}')-days('{2}')) end jixitianshu, ", dtStartInt, dtEndStr, dtStartStr);
            strSql.Append(" case when length(LN_DEP_ACCT_NO)=22 then LN_DEP_ACCT_NO else (select cr_rsv_acct_no from jsrun.cbod_crcrdcom where fk_crcrd_key=LN_AUTO_DEDU_DEP_ACCT_NO_1) end  huankuanzhuzhanghao ");
            strSql.AppendFormat("  from jsrun.cbod_lnlnslns where  ln_db_part_id like '{0}' and  ", bumen);



            //如果本月是季度，那么就可以选择小额，否则就只能显示大额
            List<int> jidu = new List<int>() { 3, 6, 9, 12 };
            if (jidu.Contains(DateTime.Now.Month))//如果本月是季度月
            {
                if (daxiaoe == "大额")
                {
                    strSql.Append(" LN_TOTL_LN_AMT_HYPO_AMT>50000 and LN_LN_BAL>0  ");
                }
                else if (daxiaoe == "小额")
                {
                    strSql.Append(" LN_TOTL_LN_AMT_HYPO_AMT<=50000 and LN_LN_BAL>0");
                }

            }
            else
            {
                if (daxiaoe == "大额")
                {
                    strSql.Append(" LN_LN_BAL>50000 ");
                }
                else if (daxiaoe == "小额")
                {
                    return null;
                }
            }

            //如果客户经理编号为空，那么就不查询。否则，检查是否为管理员，来查询全行或者本人
            if (!string.IsNullOrEmpty(kehujinglibianhao))
            {
                if (kehujinglibianhao != DAL_Constant.XindaixitongGuanliyuanID)
                {
                    strSql.AppendFormat(" and LN_ZHIBIAO_NO ='{0}'", kehujinglibianhao);
                }
            }
            else
            {
                return null;
            }
            strSql.Append(")T1 left join jsrun.cbod_saacnamt T2 on T1.huankuanzhuzhanghao=T2.fk_saacn_key)  for read only with ur ");


            return DbHelperOleDb.Query(strSql.ToString());

        }
    }
}
