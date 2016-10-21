using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    public class DAL_DianziYinhangShuju
    {
        public System.Data.DataSet GetYinhangkaYouxiaohuHushuDS()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("select a.SA_DB_PART_ID as JGM, count(b.sa_intc_amt) as COUNT ");
            sb.AppendFormat(" from jsrun.cbod_saacnacn a left join jsrun.cbod_SAACNAMT b on  a.sa_acct_no = b.fk_saacn_key ");
            sb.AppendFormat("where a.sa_acct_no like '{0}%'  and  a.SA_CACCT_DT is  null and a.SA_CARD_NO is not null and b.sa_intc_amt >=1000 group by a.SA_DB_PART_ID", DAL_Constant.Jigouma);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
        }

        public System.Data.DataSet GetShoujiYinhangJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select jgm as JGM, count(amount) as JYBS, sum(amount) as JYJE,count(distinct acseq) as JYZHS from jsrun.wsyh_cjnltransfer ");
            sb.AppendFormat("where jgm like '{0}%'    and    CTRANSFERDATE >= '{1}' and CTRANSFERDATE<= '{2}' group by jgm ", DAL_Constant.Jigouma, tongjiRiqiQian, tongjiRiqiHou);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
        }

        public System.Data.DataSet GetGerenwangyinJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select t1.jgm as JGM, count(t1.AMOUNT) as JYBS,sum(t1.amount) as JYJE, count(distinct t1.acseq) as JYZHS ");
            sb.AppendFormat("from jsrun.wsyh_pjnltransfer t1 join ( select JNLNO,TRANSTIME  from jsrun.wsyh_pjnl where jgm like '{0}%' and transdate>='{1}' and transdate<='{2}' ) t2 ", DAL_Constant.Jigouma, tongjiRiqiQian, tongjiRiqiHou);
            sb.AppendFormat("on t1.JNLNO=t2.JNLNO where jgm like '{0}%' group by t1.jgm", DAL_Constant.Jigouma);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
        }

        public System.Data.DataSet GetQiyewangyinJiaoyiQingkuang(string tongjiRiqiQian, string tongjiRiqiHou)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select t1.jgm as JGM, count(t1.AMOUNT) as JYBS,sum(t1.amount) as JYJE, count(distinct t1.acseq) as JYZHS ");
            sb.AppendFormat("from jsrun.wsyh_EJnlTransfer t1 join ( select JNLNO,TRANSTIME  from jsrun.wsyh_ejnl where jgm like '{0}%' and transdate>='{1}' and transdate<='{2}' ) t2 ", DAL_Constant.Jigouma, tongjiRiqiQian, tongjiRiqiHou);
            sb.AppendFormat("on t1.JNLNO=t2.JNLNO where jgm like '{0}%' group by t1.jgm", DAL_Constant.Jigouma);
            return DBUtility.DbHelperOleDb.Query(sb.ToString(), "Jsbmov");
        }
    }
}
