using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MZSYCORE.DAL
{
    /// <summary>
    /// 数据访问类:DAL_LSB_CKZH
    /// </summary>
    public partial class DAL_LSB_CKZH
    {
        public DAL_LSB_CKZH()
        { }
        #region  BasicMethod

        /// <summary>
        /// 获得单个字段属性；where代表条件，对应sql语句后面的where条件
        /// </summary>
        /// <param name="ziduan"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public object GetSingleZiduan(string ziduan, string where)
        {
            string strSql = string.Format("select {0} from  LSB_CKZH  where {1}", ziduan, where);
            return DbHelperOleDb.GetSingle(strSql, "Pas");
          

        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from LSB_CKZH");
            strSql.Append(" where JXDXDH=@JXDXDH and TJRQ=@TJRQ and ZHDH=@ZHDH and ZZH=@ZZH and ZHHM=@ZHHM and BZ=@BZ and CPH=@CPH and KMH=@KMH and PZH=@PZH and FHDH=@FHDH and JGDH=@JGDH and KHH=@KHH and KHRQ=@KHRQ and QXRQ=@QXRQ and DQRQ=@DQRQ and XHRQ=@XHRQ and ZHZT=@ZHZT and ZHSX=@ZHSX and QX=@QX and LLDH=@LLDH and NLL=@NLL and KHJE=@KHJE and ZHYE=@ZHYE and ZHBS=@ZHBS and HYDH=@HYDH and CZYH=@CZYH and GXHSLX=@GXHSLX and KHDXDH=@KHDXDH and XDJE=@XDJE and XDLL=@XDLL and XDBZ=@XDBZ and NJS=@NJS and ZHNRJYE=@ZHNRJYE and PSCKBZ=@PSCKBZ ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@JXDXDH", OleDbType.Integer,4),
					new OleDbParameter("@TJRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHDH", OleDbType.VarChar,40),
					new OleDbParameter("@ZZH", OleDbType.VarChar,40),
					new OleDbParameter("@ZHHM", OleDbType.VarChar,100),
					new OleDbParameter("@BZ", OleDbType.VarChar,3),
					new OleDbParameter("@CPH", OleDbType.VarChar,20),
					new OleDbParameter("@KMH", OleDbType.VarChar,20),
					new OleDbParameter("@PZH", OleDbType.VarChar,40),
					new OleDbParameter("@FHDH", OleDbType.VarChar,10),
					new OleDbParameter("@JGDH", OleDbType.VarChar,10),
					new OleDbParameter("@KHH", OleDbType.VarChar,20),
					new OleDbParameter("@KHRQ", OleDbType.Integer,4),
					new OleDbParameter("@QXRQ", OleDbType.Integer,4),
					new OleDbParameter("@DQRQ", OleDbType.Integer,4),
					new OleDbParameter("@XHRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHZT", OleDbType.VarChar,1),
					new OleDbParameter("@ZHSX", OleDbType.VarChar,2),
					new OleDbParameter("@QX", OleDbType.VarChar,4),
					new OleDbParameter("@LLDH", OleDbType.VarChar,8),
					new OleDbParameter("@NLL", OleDbType.Decimal),
					new OleDbParameter("@KHJE", OleDbType.Decimal),
					new OleDbParameter("@ZHYE", OleDbType.Decimal),
					new OleDbParameter("@ZHBS", OleDbType.VarChar,1),
					new OleDbParameter("@HYDH", OleDbType.VarChar,12),
					new OleDbParameter("@CZYH", OleDbType.VarChar,12),
					new OleDbParameter("@GXHSLX", OleDbType.VarChar,1),
					new OleDbParameter("@KHDXDH", OleDbType.Integer,4),
					new OleDbParameter("@XDJE", OleDbType.Decimal),
					new OleDbParameter("@XDLL", OleDbType.Decimal),
					new OleDbParameter("@XDBZ", OleDbType.Integer,4),
					new OleDbParameter("@NJS", OleDbType.Decimal),
					new OleDbParameter("@ZHNRJYE", OleDbType.Decimal),
					new OleDbParameter("@PSCKBZ", OleDbType.VarChar,1)			};
            parameters[0].Value = JXDXDH;
            parameters[1].Value = TJRQ;
            parameters[2].Value = ZHDH;
            parameters[3].Value = ZZH;
            parameters[4].Value = ZHHM;
            parameters[5].Value = BZ;
            parameters[6].Value = CPH;
            parameters[7].Value = KMH;
            parameters[8].Value = PZH;
            parameters[9].Value = FHDH;
            parameters[10].Value = JGDH;
            parameters[11].Value = KHH;
            parameters[12].Value = KHRQ;
            parameters[13].Value = QXRQ;
            parameters[14].Value = DQRQ;
            parameters[15].Value = XHRQ;
            parameters[16].Value = ZHZT;
            parameters[17].Value = ZHSX;
            parameters[18].Value = QX;
            parameters[19].Value = LLDH;
            parameters[20].Value = NLL;
            parameters[21].Value = KHJE;
            parameters[22].Value = ZHYE;
            parameters[23].Value = ZHBS;
            parameters[24].Value = HYDH;
            parameters[25].Value = CZYH;
            parameters[26].Value = GXHSLX;
            parameters[27].Value = KHDXDH;
            parameters[28].Value = XDJE;
            parameters[29].Value = XDLL;
            parameters[30].Value = XDBZ;
            parameters[31].Value = NJS;
            parameters[32].Value = ZHNRJYE;
            parameters[33].Value = PSCKBZ;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MZSYCORE.Model.Model_LSB_CKZH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into LSB_CKZH(");
            strSql.Append("JXDXDH,TJRQ,ZHDH,ZZH,ZHHM,BZ,CPH,KMH,PZH,FHDH,JGDH,KHH,KHRQ,QXRQ,DQRQ,XHRQ,ZHZT,ZHSX,QX,LLDH,NLL,KHJE,ZHYE,ZHBS,HYDH,CZYH,GXHSLX,KHDXDH,XDJE,XDLL,XDBZ,NJS,ZHNRJYE,PSCKBZ)");
            strSql.Append(" values (");
            strSql.Append("@JXDXDH,@TJRQ,@ZHDH,@ZZH,@ZHHM,@BZ,@CPH,@KMH,@PZH,@FHDH,@JGDH,@KHH,@KHRQ,@QXRQ,@DQRQ,@XHRQ,@ZHZT,@ZHSX,@QX,@LLDH,@NLL,@KHJE,@ZHYE,@ZHBS,@HYDH,@CZYH,@GXHSLX,@KHDXDH,@XDJE,@XDLL,@XDBZ,@NJS,@ZHNRJYE,@PSCKBZ)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@JXDXDH", OleDbType.Integer,4),
					new OleDbParameter("@TJRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHDH", OleDbType.VarChar,40),
					new OleDbParameter("@ZZH", OleDbType.VarChar,40),
					new OleDbParameter("@ZHHM", OleDbType.VarChar,100),
					new OleDbParameter("@BZ", OleDbType.VarChar,3),
					new OleDbParameter("@CPH", OleDbType.VarChar,20),
					new OleDbParameter("@KMH", OleDbType.VarChar,20),
					new OleDbParameter("@PZH", OleDbType.VarChar,40),
					new OleDbParameter("@FHDH", OleDbType.VarChar,10),
					new OleDbParameter("@JGDH", OleDbType.VarChar,10),
					new OleDbParameter("@KHH", OleDbType.VarChar,20),
					new OleDbParameter("@KHRQ", OleDbType.Integer,4),
					new OleDbParameter("@QXRQ", OleDbType.Integer,4),
					new OleDbParameter("@DQRQ", OleDbType.Integer,4),
					new OleDbParameter("@XHRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHZT", OleDbType.VarChar,1),
					new OleDbParameter("@ZHSX", OleDbType.VarChar,2),
					new OleDbParameter("@QX", OleDbType.VarChar,4),
					new OleDbParameter("@LLDH", OleDbType.VarChar,8),
					new OleDbParameter("@NLL", OleDbType.Decimal),
					new OleDbParameter("@KHJE", OleDbType.Decimal),
					new OleDbParameter("@ZHYE", OleDbType.Decimal),
					new OleDbParameter("@ZHBS", OleDbType.VarChar,1),
					new OleDbParameter("@HYDH", OleDbType.VarChar,12),
					new OleDbParameter("@CZYH", OleDbType.VarChar,12),
					new OleDbParameter("@GXHSLX", OleDbType.VarChar,1),
					new OleDbParameter("@KHDXDH", OleDbType.Integer,4),
					new OleDbParameter("@XDJE", OleDbType.Decimal),
					new OleDbParameter("@XDLL", OleDbType.Decimal),
					new OleDbParameter("@XDBZ", OleDbType.Integer,4),
					new OleDbParameter("@NJS", OleDbType.Decimal),
					new OleDbParameter("@ZHNRJYE", OleDbType.Decimal),
					new OleDbParameter("@PSCKBZ", OleDbType.VarChar,1)};
            parameters[0].Value = model.JXDXDH;
            parameters[1].Value = model.TJRQ;
            parameters[2].Value = model.ZHDH;
            parameters[3].Value = model.ZZH;
            parameters[4].Value = model.ZHHM;
            parameters[5].Value = model.BZ;
            parameters[6].Value = model.CPH;
            parameters[7].Value = model.KMH;
            parameters[8].Value = model.PZH;
            parameters[9].Value = model.FHDH;
            parameters[10].Value = model.JGDH;
            parameters[11].Value = model.KHH;
            parameters[12].Value = model.KHRQ;
            parameters[13].Value = model.QXRQ;
            parameters[14].Value = model.DQRQ;
            parameters[15].Value = model.XHRQ;
            parameters[16].Value = model.ZHZT;
            parameters[17].Value = model.ZHSX;
            parameters[18].Value = model.QX;
            parameters[19].Value = model.LLDH;
            parameters[20].Value = model.NLL;
            parameters[21].Value = model.KHJE;
            parameters[22].Value = model.ZHYE;
            parameters[23].Value = model.ZHBS;
            parameters[24].Value = model.HYDH;
            parameters[25].Value = model.CZYH;
            parameters[26].Value = model.GXHSLX;
            parameters[27].Value = model.KHDXDH;
            parameters[28].Value = model.XDJE;
            parameters[29].Value = model.XDLL;
            parameters[30].Value = model.XDBZ;
            parameters[31].Value = model.NJS;
            parameters[32].Value = model.ZHNRJYE;
            parameters[33].Value = model.PSCKBZ;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MZSYCORE.Model.Model_LSB_CKZH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update LSB_CKZH set ");
            strSql.Append("JXDXDH=@JXDXDH,");
            strSql.Append("TJRQ=@TJRQ,");
            strSql.Append("ZHDH=@ZHDH,");
            strSql.Append("ZZH=@ZZH,");
            strSql.Append("ZHHM=@ZHHM,");
            strSql.Append("BZ=@BZ,");
            strSql.Append("CPH=@CPH,");
            strSql.Append("KMH=@KMH,");
            strSql.Append("PZH=@PZH,");
            strSql.Append("FHDH=@FHDH,");
            strSql.Append("JGDH=@JGDH,");
            strSql.Append("KHH=@KHH,");
            strSql.Append("KHRQ=@KHRQ,");
            strSql.Append("QXRQ=@QXRQ,");
            strSql.Append("DQRQ=@DQRQ,");
            strSql.Append("XHRQ=@XHRQ,");
            strSql.Append("ZHZT=@ZHZT,");
            strSql.Append("ZHSX=@ZHSX,");
            strSql.Append("QX=@QX,");
            strSql.Append("LLDH=@LLDH,");
            strSql.Append("NLL=@NLL,");
            strSql.Append("KHJE=@KHJE,");
            strSql.Append("ZHYE=@ZHYE,");
            strSql.Append("ZHBS=@ZHBS,");
            strSql.Append("HYDH=@HYDH,");
            strSql.Append("CZYH=@CZYH,");
            strSql.Append("GXHSLX=@GXHSLX,");
            strSql.Append("KHDXDH=@KHDXDH,");
            strSql.Append("XDJE=@XDJE,");
            strSql.Append("XDLL=@XDLL,");
            strSql.Append("XDBZ=@XDBZ,");
            strSql.Append("NJS=@NJS,");
            strSql.Append("ZHNRJYE=@ZHNRJYE,");
            strSql.Append("PSCKBZ=@PSCKBZ");
            strSql.Append(" where JXDXDH=@JXDXDH and TJRQ=@TJRQ and ZHDH=@ZHDH and ZZH=@ZZH and ZHHM=@ZHHM and BZ=@BZ and CPH=@CPH and KMH=@KMH and PZH=@PZH and FHDH=@FHDH and JGDH=@JGDH and KHH=@KHH and KHRQ=@KHRQ and QXRQ=@QXRQ and DQRQ=@DQRQ and XHRQ=@XHRQ and ZHZT=@ZHZT and ZHSX=@ZHSX and QX=@QX and LLDH=@LLDH and NLL=@NLL and KHJE=@KHJE and ZHYE=@ZHYE and ZHBS=@ZHBS and HYDH=@HYDH and CZYH=@CZYH and GXHSLX=@GXHSLX and KHDXDH=@KHDXDH and XDJE=@XDJE and XDLL=@XDLL and XDBZ=@XDBZ and NJS=@NJS and ZHNRJYE=@ZHNRJYE and PSCKBZ=@PSCKBZ ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@JXDXDH", OleDbType.Integer,4),
					new OleDbParameter("@TJRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHDH", OleDbType.VarChar,40),
					new OleDbParameter("@ZZH", OleDbType.VarChar,40),
					new OleDbParameter("@ZHHM", OleDbType.VarChar,100),
					new OleDbParameter("@BZ", OleDbType.VarChar,3),
					new OleDbParameter("@CPH", OleDbType.VarChar,20),
					new OleDbParameter("@KMH", OleDbType.VarChar,20),
					new OleDbParameter("@PZH", OleDbType.VarChar,40),
					new OleDbParameter("@FHDH", OleDbType.VarChar,10),
					new OleDbParameter("@JGDH", OleDbType.VarChar,10),
					new OleDbParameter("@KHH", OleDbType.VarChar,20),
					new OleDbParameter("@KHRQ", OleDbType.Integer,4),
					new OleDbParameter("@QXRQ", OleDbType.Integer,4),
					new OleDbParameter("@DQRQ", OleDbType.Integer,4),
					new OleDbParameter("@XHRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHZT", OleDbType.VarChar,1),
					new OleDbParameter("@ZHSX", OleDbType.VarChar,2),
					new OleDbParameter("@QX", OleDbType.VarChar,4),
					new OleDbParameter("@LLDH", OleDbType.VarChar,8),
					new OleDbParameter("@NLL", OleDbType.Decimal),
					new OleDbParameter("@KHJE", OleDbType.Decimal),
					new OleDbParameter("@ZHYE", OleDbType.Decimal),
					new OleDbParameter("@ZHBS", OleDbType.VarChar,1),
					new OleDbParameter("@HYDH", OleDbType.VarChar,12),
					new OleDbParameter("@CZYH", OleDbType.VarChar,12),
					new OleDbParameter("@GXHSLX", OleDbType.VarChar,1),
					new OleDbParameter("@KHDXDH", OleDbType.Integer,4),
					new OleDbParameter("@XDJE", OleDbType.Decimal),
					new OleDbParameter("@XDLL", OleDbType.Decimal),
					new OleDbParameter("@XDBZ", OleDbType.Integer,4),
					new OleDbParameter("@NJS", OleDbType.Decimal),
					new OleDbParameter("@ZHNRJYE", OleDbType.Decimal),
					new OleDbParameter("@PSCKBZ", OleDbType.VarChar,1)};
            parameters[0].Value = model.JXDXDH;
            parameters[1].Value = model.TJRQ;
            parameters[2].Value = model.ZHDH;
            parameters[3].Value = model.ZZH;
            parameters[4].Value = model.ZHHM;
            parameters[5].Value = model.BZ;
            parameters[6].Value = model.CPH;
            parameters[7].Value = model.KMH;
            parameters[8].Value = model.PZH;
            parameters[9].Value = model.FHDH;
            parameters[10].Value = model.JGDH;
            parameters[11].Value = model.KHH;
            parameters[12].Value = model.KHRQ;
            parameters[13].Value = model.QXRQ;
            parameters[14].Value = model.DQRQ;
            parameters[15].Value = model.XHRQ;
            parameters[16].Value = model.ZHZT;
            parameters[17].Value = model.ZHSX;
            parameters[18].Value = model.QX;
            parameters[19].Value = model.LLDH;
            parameters[20].Value = model.NLL;
            parameters[21].Value = model.KHJE;
            parameters[22].Value = model.ZHYE;
            parameters[23].Value = model.ZHBS;
            parameters[24].Value = model.HYDH;
            parameters[25].Value = model.CZYH;
            parameters[26].Value = model.GXHSLX;
            parameters[27].Value = model.KHDXDH;
            parameters[28].Value = model.XDJE;
            parameters[29].Value = model.XDLL;
            parameters[30].Value = model.XDBZ;
            parameters[31].Value = model.NJS;
            parameters[32].Value = model.ZHNRJYE;
            parameters[33].Value = model.PSCKBZ;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from LSB_CKZH ");
            strSql.Append(" where JXDXDH=@JXDXDH and TJRQ=@TJRQ and ZHDH=@ZHDH and ZZH=@ZZH and ZHHM=@ZHHM and BZ=@BZ and CPH=@CPH and KMH=@KMH and PZH=@PZH and FHDH=@FHDH and JGDH=@JGDH and KHH=@KHH and KHRQ=@KHRQ and QXRQ=@QXRQ and DQRQ=@DQRQ and XHRQ=@XHRQ and ZHZT=@ZHZT and ZHSX=@ZHSX and QX=@QX and LLDH=@LLDH and NLL=@NLL and KHJE=@KHJE and ZHYE=@ZHYE and ZHBS=@ZHBS and HYDH=@HYDH and CZYH=@CZYH and GXHSLX=@GXHSLX and KHDXDH=@KHDXDH and XDJE=@XDJE and XDLL=@XDLL and XDBZ=@XDBZ and NJS=@NJS and ZHNRJYE=@ZHNRJYE and PSCKBZ=@PSCKBZ ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@JXDXDH", OleDbType.Integer,4),
					new OleDbParameter("@TJRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHDH", OleDbType.VarChar,40),
					new OleDbParameter("@ZZH", OleDbType.VarChar,40),
					new OleDbParameter("@ZHHM", OleDbType.VarChar,100),
					new OleDbParameter("@BZ", OleDbType.VarChar,3),
					new OleDbParameter("@CPH", OleDbType.VarChar,20),
					new OleDbParameter("@KMH", OleDbType.VarChar,20),
					new OleDbParameter("@PZH", OleDbType.VarChar,40),
					new OleDbParameter("@FHDH", OleDbType.VarChar,10),
					new OleDbParameter("@JGDH", OleDbType.VarChar,10),
					new OleDbParameter("@KHH", OleDbType.VarChar,20),
					new OleDbParameter("@KHRQ", OleDbType.Integer,4),
					new OleDbParameter("@QXRQ", OleDbType.Integer,4),
					new OleDbParameter("@DQRQ", OleDbType.Integer,4),
					new OleDbParameter("@XHRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHZT", OleDbType.VarChar,1),
					new OleDbParameter("@ZHSX", OleDbType.VarChar,2),
					new OleDbParameter("@QX", OleDbType.VarChar,4),
					new OleDbParameter("@LLDH", OleDbType.VarChar,8),
					new OleDbParameter("@NLL", OleDbType.Decimal),
					new OleDbParameter("@KHJE", OleDbType.Decimal),
					new OleDbParameter("@ZHYE", OleDbType.Decimal),
					new OleDbParameter("@ZHBS", OleDbType.VarChar,1),
					new OleDbParameter("@HYDH", OleDbType.VarChar,12),
					new OleDbParameter("@CZYH", OleDbType.VarChar,12),
					new OleDbParameter("@GXHSLX", OleDbType.VarChar,1),
					new OleDbParameter("@KHDXDH", OleDbType.Integer,4),
					new OleDbParameter("@XDJE", OleDbType.Decimal),
					new OleDbParameter("@XDLL", OleDbType.Decimal),
					new OleDbParameter("@XDBZ", OleDbType.Integer,4),
					new OleDbParameter("@NJS", OleDbType.Decimal),
					new OleDbParameter("@ZHNRJYE", OleDbType.Decimal),
					new OleDbParameter("@PSCKBZ", OleDbType.VarChar,1)			};
            parameters[0].Value = JXDXDH;
            parameters[1].Value = TJRQ;
            parameters[2].Value = ZHDH;
            parameters[3].Value = ZZH;
            parameters[4].Value = ZHHM;
            parameters[5].Value = BZ;
            parameters[6].Value = CPH;
            parameters[7].Value = KMH;
            parameters[8].Value = PZH;
            parameters[9].Value = FHDH;
            parameters[10].Value = JGDH;
            parameters[11].Value = KHH;
            parameters[12].Value = KHRQ;
            parameters[13].Value = QXRQ;
            parameters[14].Value = DQRQ;
            parameters[15].Value = XHRQ;
            parameters[16].Value = ZHZT;
            parameters[17].Value = ZHSX;
            parameters[18].Value = QX;
            parameters[19].Value = LLDH;
            parameters[20].Value = NLL;
            parameters[21].Value = KHJE;
            parameters[22].Value = ZHYE;
            parameters[23].Value = ZHBS;
            parameters[24].Value = HYDH;
            parameters[25].Value = CZYH;
            parameters[26].Value = GXHSLX;
            parameters[27].Value = KHDXDH;
            parameters[28].Value = XDJE;
            parameters[29].Value = XDLL;
            parameters[30].Value = XDBZ;
            parameters[31].Value = NJS;
            parameters[32].Value = ZHNRJYE;
            parameters[33].Value = PSCKBZ;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MZSYCORE.Model.Model_LSB_CKZH GetModel(int JXDXDH, int TJRQ, string ZHDH, string ZZH, string ZHHM, string BZ, string CPH, string KMH, string PZH, string FHDH, string JGDH, string KHH, int KHRQ, int QXRQ, int DQRQ, int XHRQ, string ZHZT, string ZHSX, string QX, string LLDH, decimal NLL, decimal KHJE, decimal ZHYE, string ZHBS, string HYDH, string CZYH, string GXHSLX, int KHDXDH, decimal XDJE, decimal XDLL, int XDBZ, decimal NJS, decimal ZHNRJYE, string PSCKBZ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select JXDXDH,TJRQ,ZHDH,ZZH,ZHHM,BZ,CPH,KMH,PZH,FHDH,JGDH,KHH,KHRQ,QXRQ,DQRQ,XHRQ,ZHZT,ZHSX,QX,LLDH,NLL,KHJE,ZHYE,ZHBS,HYDH,CZYH,GXHSLX,KHDXDH,XDJE,XDLL,XDBZ,NJS,ZHNRJYE,PSCKBZ from LSB_CKZH ");
            strSql.Append(" where JXDXDH=@JXDXDH and TJRQ=@TJRQ and ZHDH=@ZHDH and ZZH=@ZZH and ZHHM=@ZHHM and BZ=@BZ and CPH=@CPH and KMH=@KMH and PZH=@PZH and FHDH=@FHDH and JGDH=@JGDH and KHH=@KHH and KHRQ=@KHRQ and QXRQ=@QXRQ and DQRQ=@DQRQ and XHRQ=@XHRQ and ZHZT=@ZHZT and ZHSX=@ZHSX and QX=@QX and LLDH=@LLDH and NLL=@NLL and KHJE=@KHJE and ZHYE=@ZHYE and ZHBS=@ZHBS and HYDH=@HYDH and CZYH=@CZYH and GXHSLX=@GXHSLX and KHDXDH=@KHDXDH and XDJE=@XDJE and XDLL=@XDLL and XDBZ=@XDBZ and NJS=@NJS and ZHNRJYE=@ZHNRJYE and PSCKBZ=@PSCKBZ ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@JXDXDH", OleDbType.Integer,4),
					new OleDbParameter("@TJRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHDH", OleDbType.VarChar,40),
					new OleDbParameter("@ZZH", OleDbType.VarChar,40),
					new OleDbParameter("@ZHHM", OleDbType.VarChar,100),
					new OleDbParameter("@BZ", OleDbType.VarChar,3),
					new OleDbParameter("@CPH", OleDbType.VarChar,20),
					new OleDbParameter("@KMH", OleDbType.VarChar,20),
					new OleDbParameter("@PZH", OleDbType.VarChar,40),
					new OleDbParameter("@FHDH", OleDbType.VarChar,10),
					new OleDbParameter("@JGDH", OleDbType.VarChar,10),
					new OleDbParameter("@KHH", OleDbType.VarChar,20),
					new OleDbParameter("@KHRQ", OleDbType.Integer,4),
					new OleDbParameter("@QXRQ", OleDbType.Integer,4),
					new OleDbParameter("@DQRQ", OleDbType.Integer,4),
					new OleDbParameter("@XHRQ", OleDbType.Integer,4),
					new OleDbParameter("@ZHZT", OleDbType.VarChar,1),
					new OleDbParameter("@ZHSX", OleDbType.VarChar,2),
					new OleDbParameter("@QX", OleDbType.VarChar,4),
					new OleDbParameter("@LLDH", OleDbType.VarChar,8),
					new OleDbParameter("@NLL", OleDbType.Decimal),
					new OleDbParameter("@KHJE", OleDbType.Decimal),
					new OleDbParameter("@ZHYE", OleDbType.Decimal),
					new OleDbParameter("@ZHBS", OleDbType.VarChar,1),
					new OleDbParameter("@HYDH", OleDbType.VarChar,12),
					new OleDbParameter("@CZYH", OleDbType.VarChar,12),
					new OleDbParameter("@GXHSLX", OleDbType.VarChar,1),
					new OleDbParameter("@KHDXDH", OleDbType.Integer,4),
					new OleDbParameter("@XDJE", OleDbType.Decimal),
					new OleDbParameter("@XDLL", OleDbType.Decimal),
					new OleDbParameter("@XDBZ", OleDbType.Integer,4),
					new OleDbParameter("@NJS", OleDbType.Decimal),
					new OleDbParameter("@ZHNRJYE", OleDbType.Decimal),
					new OleDbParameter("@PSCKBZ", OleDbType.VarChar,1)			};
            parameters[0].Value = JXDXDH;
            parameters[1].Value = TJRQ;
            parameters[2].Value = ZHDH;
            parameters[3].Value = ZZH;
            parameters[4].Value = ZHHM;
            parameters[5].Value = BZ;
            parameters[6].Value = CPH;
            parameters[7].Value = KMH;
            parameters[8].Value = PZH;
            parameters[9].Value = FHDH;
            parameters[10].Value = JGDH;
            parameters[11].Value = KHH;
            parameters[12].Value = KHRQ;
            parameters[13].Value = QXRQ;
            parameters[14].Value = DQRQ;
            parameters[15].Value = XHRQ;
            parameters[16].Value = ZHZT;
            parameters[17].Value = ZHSX;
            parameters[18].Value = QX;
            parameters[19].Value = LLDH;
            parameters[20].Value = NLL;
            parameters[21].Value = KHJE;
            parameters[22].Value = ZHYE;
            parameters[23].Value = ZHBS;
            parameters[24].Value = HYDH;
            parameters[25].Value = CZYH;
            parameters[26].Value = GXHSLX;
            parameters[27].Value = KHDXDH;
            parameters[28].Value = XDJE;
            parameters[29].Value = XDLL;
            parameters[30].Value = XDBZ;
            parameters[31].Value = NJS;
            parameters[32].Value = ZHNRJYE;
            parameters[33].Value = PSCKBZ;

            MZSYCORE.Model.Model_LSB_CKZH model = new MZSYCORE.Model.Model_LSB_CKZH();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MZSYCORE.Model.Model_LSB_CKZH DataRowToModel(DataRow row)
        {
            MZSYCORE.Model.Model_LSB_CKZH model = new MZSYCORE.Model.Model_LSB_CKZH();
            if (row != null)
            {
                if (row["JXDXDH"] != null && row["JXDXDH"].ToString() != "")
                {
                    model.JXDXDH = int.Parse(row["JXDXDH"].ToString());
                }
                if (row["TJRQ"] != null && row["TJRQ"].ToString() != "")
                {
                    model.TJRQ = int.Parse(row["TJRQ"].ToString());
                }
                if (row["ZHDH"] != null)
                {
                    model.ZHDH = row["ZHDH"].ToString();
                }
                if (row["ZZH"] != null)
                {
                    model.ZZH = row["ZZH"].ToString();
                }
                if (row["ZHHM"] != null)
                {
                    model.ZHHM = row["ZHHM"].ToString();
                }
                if (row["BZ"] != null)
                {
                    model.BZ = row["BZ"].ToString();
                }
                if (row["CPH"] != null)
                {
                    model.CPH = row["CPH"].ToString();
                }
                if (row["KMH"] != null)
                {
                    model.KMH = row["KMH"].ToString();
                }
                if (row["PZH"] != null)
                {
                    model.PZH = row["PZH"].ToString();
                }
                if (row["FHDH"] != null)
                {
                    model.FHDH = row["FHDH"].ToString();
                }
                if (row["JGDH"] != null)
                {
                    model.JGDH = row["JGDH"].ToString();
                }
                if (row["KHH"] != null)
                {
                    model.KHH = row["KHH"].ToString();
                }
                if (row["KHRQ"] != null && row["KHRQ"].ToString() != "")
                {
                    model.KHRQ = int.Parse(row["KHRQ"].ToString());
                }
                if (row["QXRQ"] != null && row["QXRQ"].ToString() != "")
                {
                    model.QXRQ = int.Parse(row["QXRQ"].ToString());
                }
                if (row["DQRQ"] != null && row["DQRQ"].ToString() != "")
                {
                    model.DQRQ = int.Parse(row["DQRQ"].ToString());
                }
                if (row["XHRQ"] != null && row["XHRQ"].ToString() != "")
                {
                    model.XHRQ = int.Parse(row["XHRQ"].ToString());
                }
                if (row["ZHZT"] != null)
                {
                    model.ZHZT = row["ZHZT"].ToString();
                }
                if (row["ZHSX"] != null)
                {
                    model.ZHSX = row["ZHSX"].ToString();
                }
                if (row["QX"] != null)
                {
                    model.QX = row["QX"].ToString();
                }
                if (row["LLDH"] != null)
                {
                    model.LLDH = row["LLDH"].ToString();
                }
                if (row["NLL"] != null && row["NLL"].ToString() != "")
                {
                    model.NLL = decimal.Parse(row["NLL"].ToString());
                }
                if (row["KHJE"] != null && row["KHJE"].ToString() != "")
                {
                    model.KHJE = decimal.Parse(row["KHJE"].ToString());
                }
                if (row["ZHYE"] != null && row["ZHYE"].ToString() != "")
                {
                    model.ZHYE = decimal.Parse(row["ZHYE"].ToString());
                }
                if (row["ZHBS"] != null)
                {
                    model.ZHBS = row["ZHBS"].ToString();
                }
                if (row["HYDH"] != null)
                {
                    model.HYDH = row["HYDH"].ToString();
                }
                if (row["CZYH"] != null)
                {
                    model.CZYH = row["CZYH"].ToString();
                }
                if (row["GXHSLX"] != null)
                {
                    model.GXHSLX = row["GXHSLX"].ToString();
                }
                if (row["KHDXDH"] != null && row["KHDXDH"].ToString() != "")
                {
                    model.KHDXDH = int.Parse(row["KHDXDH"].ToString());
                }
                if (row["XDJE"] != null && row["XDJE"].ToString() != "")
                {
                    model.XDJE = decimal.Parse(row["XDJE"].ToString());
                }
                if (row["XDLL"] != null && row["XDLL"].ToString() != "")
                {
                    model.XDLL = decimal.Parse(row["XDLL"].ToString());
                }
                if (row["XDBZ"] != null && row["XDBZ"].ToString() != "")
                {
                    model.XDBZ = int.Parse(row["XDBZ"].ToString());
                }
                if (row["NJS"] != null && row["NJS"].ToString() != "")
                {
                    model.NJS = decimal.Parse(row["NJS"].ToString());
                }
                if (row["ZHNRJYE"] != null && row["ZHNRJYE"].ToString() != "")
                {
                    model.ZHNRJYE = decimal.Parse(row["ZHNRJYE"].ToString());
                }
                if (row["PSCKBZ"] != null)
                {
                    model.PSCKBZ = row["PSCKBZ"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select JXDXDH,TJRQ,ZHDH,ZZH,ZHHM,BZ,CPH,KMH,PZH,FHDH,JGDH,KHH,KHRQ,QXRQ,DQRQ,XHRQ,ZHZT,ZHSX,QX,LLDH,NLL,KHJE,ZHYE,ZHBS,HYDH,CZYH,GXHSLX,KHDXDH,XDJE,XDLL,XDBZ,NJS,ZHNRJYE,PSCKBZ ");
            strSql.Append(" FROM LSB_CKZH ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString(),"Pas");
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM LSB_CKZH ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.PSCKBZ desc");
            }
            strSql.Append(")AS Row, T.*  from LSB_CKZH T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            OleDbParameter[] parameters = {
                    new OleDbParameter("@tblName", OleDbType.VarChar, 255),
                    new OleDbParameter("@fldName", OleDbType.VarChar, 255),
                    new OleDbParameter("@PageSize", OleDbType.Integer),
                    new OleDbParameter("@PageIndex", OleDbType.Integer),
                    new OleDbParameter("@IsReCount", OleDbType.Boolean),
                    new OleDbParameter("@OrderType", OleDbType.Boolean),
                    new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
                    };
            parameters[0].Value = "LSB_CKZH";
            parameters[1].Value = "PSCKBZ";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
