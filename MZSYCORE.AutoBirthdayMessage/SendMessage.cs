using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools;

namespace MZSYCORE.AutoMessage
{
    public class SendMessage
    {
        BLL.BLL_XTB_DXTZ bll_xtb_dxtz = new BLL.BLL_XTB_DXTZ();
        BLL.BLL_employee_info bll_employee_info = new BLL.BLL_employee_info();


        /// <summary>
        /// 生成明日到期定存提醒短信的通讯字典,键为行员号，值是地址列表对象
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, AddressList> CreatMRDQDCMessageTel()
        {
            Dictionary<string, AddressList> dic = new Dictionary<string, AddressList>();

            dic.Add("00000155", new AddressList("周东杰", "爷", "18839003210"));
            dic.Add("21710001", new AddressList("温国光", "温行长", "13569156325"));
            dic.Add("21710002", new AddressList("王景勇", "王总", "13803911400"));
            dic.Add("21710003", new AddressList("马园园", "马园园", "15039159933"));
            dic.Add("21710005", new AddressList("席卫华", "席师傅", "15713910777"));
            dic.Add("21710006", new AddressList("范小强", "范小强", "15839190540"));
            dic.Add("21710007", new AddressList("薛培", "亲爱的美貌与智慧并存", "15139121166"));
            dic.Add("21710008", new AddressList("冯颖", "姑奶奶", "18339757333"));
            dic.Add("21710009", new AddressList("杜艳艳", "杜艳艳", "18339775350"));
            dic.Add("21710011", new AddressList("谢丹丹", "谢丹丹", "15138077888"));
            dic.Add("21710012", new AddressList("徐峰", "徐行长", "15239139889"));
            dic.Add("21710014", new AddressList("盛佳霖", "盛佳霖", "13598533522"));
            dic.Add("21710015", new AddressList("陈晓宁", "陈晓宁", "18339715856"));
            dic.Add("21710016", new AddressList("李世贤", "李世贤", "13462462526"));
            dic.Add("21710017", new AddressList("柏凤林", "柏凤林", "15138065599"));
            dic.Add("21710024", new AddressList("武贵杰", "武贵杰", "13462481439"));
            dic.Add("21710085", new AddressList("王国成", "涛哥", "18239126711"));
            dic.Add("21710091", new AddressList("宋高磊", "宋高磊", "15838921256"));
            dic.Add("21710092", new AddressList("陈永乐", "乐儿哥", "15713910069"));
            dic.Add("21710093", new AddressList("张新亮", "阳光帅气", "15713910068"));
            dic.Add("21710094", new AddressList("袁海龙", "黑蛋", "15713910050"));
            dic.Add("21710096", new AddressList("马玉晓", "马玉晓", "15713910058"));
            dic.Add("21710097", new AddressList("王凯", "王凯", "15713910056"));
            dic.Add("21710100", new AddressList("魏伟", "小魏", "18739130390"));
            dic.Add("21710101", new AddressList("张旭莹", "张旭莹", "13623914870"));
            dic.Add("21710104", new AddressList("汤晓婷", "汤晓婷", "13608636995"));
            dic.Add("21710113", new AddressList("闫熠晴", "闫熠晴", "15036530303"));
            dic.Add("21710115", new AddressList("宋健", "宋健", "13839197093"));
            dic.Add("21710116", new AddressList("薛慧冰", "行花（就是最漂亮的大美女）", "15039129569"));
            dic.Add("21710121", new AddressList("王雪姣", "姣姐", "13462466964"));
            dic.Add("21710122", new AddressList("王亚丽", "王亚丽", "18336826166"));
            
            dic.Add("21710124", new AddressList("刘瑛", "刘瑛", "13939192790"));
            dic.Add("21710126", new AddressList("王辉", "王辉", "15893024882"));
            dic.Add("21710127", new AddressList("岳文浩", "蜘蛛侠", "15978771177"));
            dic.Add("21710128", new AddressList("籍彬彬", "籍彬彬", "15978749423"));
            dic.Add("21710130", new AddressList("李强", "李强", "15139161058"));
            dic.Add("21710131", new AddressList("郭亦轩", "郭亦轩", "18239109596"));
            dic.Add("21710133", new AddressList("毛泽方", "毛泽方", "15139156820"));
            dic.Add("21710145", new AddressList("李姗", "李姗", "15039121000"));
            dic.Add("21710152", new AddressList("王丰", "王丰", "13663912291"));
            dic.Add("21710153", new AddressList("张景阳", "张景阳", "18339706020"));
            dic.Add("21710154", new AddressList("马明", "马明", "18239126633"));
            dic.Add("21710155", new AddressList("范亚松", "范亚松", "15039100365"));
            dic.Add("21710156", new AddressList("乔磊", "乔磊", "13673915063"));
            dic.Add("21710158", new AddressList("韩中原", "韩中原", "13513816983"));
            dic.Add("21710160", new AddressList("汤晓楠", "汤晓楠", "13782863632"));
            dic.Add("21710161", new AddressList("赵花花", "赵花花", "15993719961"));
            dic.Add("21710162", new AddressList("苏亦璇", "苏亦璇", "15839163331"));
            dic.Add("21710163", new AddressList("李梦慧", "李梦慧", "15939154836"));
            dic.Add("21710164", new AddressList("李鉴", "小鉴鉴", "18239191655"));
            dic.Add("21710165", new AddressList("闫冬玲", "闫冬玲", "15993797540"));
            dic.Add("21710167", new AddressList("张丽娇", "张丽娇", "15138066628"));
            dic.Add("21710168", new AddressList("刘小芳", "刘小芳", "13569133959"));
            dic.Add("21710176", new AddressList("郭厚兴", "郭厚兴", "18336829626"));
            dic.Add("21710177", new AddressList("李蓓蕾", "李蓓蕾", "15039137422"));
            dic.Add("21710178", new AddressList("薛孟孟", "薛孟孟", "15139128704"));
            dic.Add("21710179", new AddressList("陈以光", "陈行长", "13707685759"));
            dic.Add("21710180", new AddressList("柴心静", "柴主任", "13849503888"));
            dic.Add("21710182", new AddressList("丹程", "丹程", "13839181660"));
            dic.Add("21710189", new AddressList("杨标标", "杨主任", "15225858458"));
            dic.Add("21710193", new AddressList("花亚飞", "美丽的花花", "18272736291"));
            dic.Add("21710196", new AddressList("李忠", "李忠", "18614939506"));
            dic.Add("21710197", new AddressList("丁宇阳", "丁宇阳", "13782753025"));
            dic.Add("21710199", new AddressList("范延辉", "范延辉", "15138008619"));
            dic.Add("21710200", new AddressList("和春玲", "和春玲", "13839108428"));
            dic.Add("21710204", new AddressList("周惠珍", "周惠珍", "15839191498"));
            dic.Add("21710205", new AddressList("李慧娟", "李慧娟", "13939119631"));
            dic.Add("21710206", new AddressList("吴月雪", "吴月雪", "18339752205"));
            dic.Add("21710208", new AddressList("赵超", "赵超", "18790213903"));
            dic.Add("21710209", new AddressList("米鹏", "米鹏", "15138063600"));
            dic.Add("21710210", new AddressList("杨定鼎", "杨定鼎", "18300620538"));
            dic.Add("21710211", new AddressList("党志远", "党志远", "18348266646"));
            dic.Add("21710212", new AddressList("侯培杰", "侯培杰", "15039139350"));
            dic.Add("21710213", new AddressList("郝燕杰", "郝燕杰", "15138051902"));
            dic.Add("21710214", new AddressList("张莫轩", "张莫轩", "18317278565"));
            dic.Add("21710215", new AddressList("李立鹏", "李立鹏", "18839160038"));
            dic.Add("21710216", new AddressList("张瑞鹏", "张瑞鹏", "18439131800"));
            dic.Add("21710217", new AddressList("王伟", "王伟", "13523355691"));
            dic.Add("21710218", new AddressList("李文涛", "李文涛", "15225828370"));
            dic.Add("21710219", new AddressList("李鹏飞", "李鹏飞", "18300622018"));
            dic.Add("21710220", new AddressList("罗东伟", "罗东伟", "15139111785"));
            dic.Add("21710221", new AddressList("郭晓怡", "郭晓怡", "18300620331"));
            dic.Add("21710222", new AddressList("薛佳佳", "薛佳佳", "15036528613"));
            dic.Add("21710223", new AddressList("耿春芳", "耿春芳", "13782728326"));
            dic.Add("21710224", new AddressList("谢凡", "谢凡", "15838900832"));
            dic.Add("21710225", new AddressList("郝洁", "郝洁", "15138033226"));
            dic.Add("21710226", new AddressList("行彩锦", "行彩锦", "13598530413"));
            dic.Add("21710227", new AddressList("崔小冬", "崔小冬", "15225806585"));
            dic.Add("21710228", new AddressList("申萌萌", "申萌萌", "15978762505"));
            dic.Add("21710229", new AddressList("李孟阳", "李孟阳", "18739181622"));
            dic.Add("21710232", new AddressList("卜庆洲", "卜庆洲", "13569187615"));


            return dic;
        }


        /// <summary>
        /// 生成每日短信的短信列表，也可以理解为初始化。
        /// </summary>
        public List<string> CreatDailyMessageTelephoneList()
        {
            List<string> telephone = new List<string>();
            //行级领导
            //telephone.Add("15371216333");//刘丰
            //telephone.Add("15366569866");//戴启庸
            telephone.Add("13569156325");//温国光
            telephone.Add("13569159269");//卞训勇
            telephone.Add("13849505722");//王伟
            telephone.Add("13707685759");//陈以光
            telephone.Add("13839181660");//丹程

            //部门经理
            telephone.Add("13803911400");//王景勇
            telephone.Add("15138065599");//柏枫林
            telephone.Add("13839197093");//宋健
            //telephone.Add("");//郭厚星
            //telephone.Add("");//柴心静

            //运维
            telephone.Add("18839003210");//周东杰
            telephone.Add("15139161058");//李强

            //会计
            telephone.Add("15838921256");//宋高磊
            telephone.Add("18339757333");//冯颖
            telephone.Add("15139121166");//薛培
            telephone.Add("15138077888");//谢丹
            telephone.Add("15139141993");//胡亚乐
            //telephone.Add("");//谢丹

            //信贷
            telephone.Add("18339715856");//陈晓宁
            telephone.Add("15713910058");//马玉晓

            return telephone;
        }

        /// <summary>
        /// 往绩效系统数据库的短信通知表中写入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SendToPasDB(Model.Model_XTB_DXTZ model)
        {
            //如果手机号或者内容为空，那么直接返回失败。否则，执行往数据库里查数据
            if (string.IsNullOrEmpty(model.TEL) || string.IsNullOrEmpty(model.CONTENT))
            {
                return false;

            }
            else
            {
                return bll_xtb_dxtz.Add(model);
            }

        }

        /// <summary>
        /// 根据手机号和内容，往绩效系统数据库的短信通知表中写入数据
        /// </summary>
        /// <param name="tel"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public bool SendToPasDB(string tel, string content)
        {
            //如果内容字数大于140个字，那么系统自动不发送。
            byte[] bytescontent = Encoding.Default.GetBytes(content);
            if (bytescontent.Length > 280)
            {
                return false;
            }
            else
            {
                Model.Model_XTB_DXTZ model = new Model.Model_XTB_DXTZ();
                model.HYDH = "4102";
                model.SJ = DateTime.Now;
                model.TEL = tel;
                model.CONTENT = content;
                model.ZT = "0";//如果测试，就改成1，只写数据库不发送。正常情况下改为0.

                return SendToPasDB(model);
            }
        }

        /// <summary>
        /// 根据自造的明日到期定存实体模型，给客户经理维护人发送短信
        /// </summary>
        /// <param name="model_zizao_mrdqdc_cbod_tdacnacn"></param>
        /// <returns></returns>
        public bool SendToPasDB(Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN model_zizao_mrdqdc_cbod_tdacnacn)
        {
            Dictionary<string, AddressList> dicTel = CreatMRDQDCMessageTel();
            //如果客户经理编号在地址表中存在，那么就发送短信，否则什么也不做
            if (dicTel.ContainsKey(model_zizao_mrdqdc_cbod_tdacnacn.Td_conntr_no))
            {
                AddressList addresslist = dicTel[model_zizao_mrdqdc_cbod_tdacnacn.Td_conntr_no];
                string content = CreatMRDQDCMessage(model_zizao_mrdqdc_cbod_tdacnacn, addresslist);
                return SendToPasDB(addresslist.Tel, content);
            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// 生成明日到期定存通知短信
        /// </summary>
        /// <param name="model_zizao_mrdqdc_cbod_tdacnacn"></param>
        /// <param name="model_employee_info"></param>
        /// <returns></returns>
        private string CreatMRDQDCMessage(Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN model_zizao_mrdqdc_cbod_tdacnacn, AddressList addresslist)
        {
            StringBuilder sb = new StringBuilder();
            string cunQi = "";
            switch (model_zizao_mrdqdc_cbod_tdacnacn.Td_dep_prd_n.ToString())
            {
                case "90":
                    cunQi = "三个月";
                    break;
                case "180":
                    cunQi = "半年";
                    break;
                case "360":
                    cunQi = "一年";
                    break;
                case "720":
                    cunQi = "两年";
                    break;
                case "1080":
                    cunQi = "三年";
                    break;
                case "1800":
                    cunQi = "五年";
                    break;

            }
            sb.AppendFormat("{0},你好。你的客户{1}有一个{2}期存款将于后天到期，存款账号为：{3}，请提前做好维护工作。",
                addresslist.Chenghu,
                model_zizao_mrdqdc_cbod_tdacnacn.Td_cust_name,
                cunQi,
                model_zizao_mrdqdc_cbod_tdacnacn.Td_td_acct_no);
            return sb.ToString();
        }

        /// <summary>
        /// 根据生日短信的实体模型，往绩效系统数据库的短信通知表中写入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SendToPasDB(Model.Model_ZiZao_BirthdayMessage model)
        {
            string content = CreatBirthdayMessage(model.CUST_NAME, model.GENDER);
            return SendToPasDB(model.ADDRESS, content);
        }

        /// <summary>
        /// 根据客户姓名和性别，拼接生日祝福短信。
        /// </summary>
        /// <param name="custname"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public string CreatBirthdayMessage(string custname, string gender)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("尊敬的{0}", custname);
            if (gender == "1")
            {
                sb.Append("先生，");
            }
            else
            {
                sb.Append("女士，");
            }
            sb.Append("您好，在这特别的日子，孟州射阳村镇银行诚挚为您献上生日祝福！愿您的每个日子都温馨幸福，村镇银行悉心服务永伴您左右！");
            return sb.ToString();

        }



        /// <summary>
        /// 根据日记表字典和存放同业内部帐字典，拼接短信内容。返回string列表，其中第一个为全量，第二个为存放同业，第三个为短信第一条，第四个为短信第一条,第五个为短信第一条，第六个为短信第一条。
        /// </summary>
        /// <param name="cunFangTongYeDic"></param>
        /// <param name="KmrjbDic"></param>
        /// <returns></returns>
        public static List<string> CreatDailyMessage(Dictionary<string, decimal> cunFangTongYeDic, Dictionary<string, Model.Model_FNIE_KMRJB> KmrjbDic)
        {
            List<string> lst = new List<string>();

            StringBuilder cunFangToneTeSb = new StringBuilder();
            StringBuilder dailyMessageSb = new StringBuilder();
            StringBuilder dxfg1Sb = new StringBuilder();
            StringBuilder dxfg2Sb = new StringBuilder();
            StringBuilder dxfg3Sb = new StringBuilder();
            StringBuilder dxfg4Sb = new StringBuilder();

            #region 获取存放同业的字符串
            //获取存放同业
            string ZhongHang = (Math.Round(cunFangTongYeDic["4108260011019110110510800000"] / 10000)).ToString();
            string GongHang = (Math.Round(cunFangTongYeDic["4108260011019110110510800001"] / 10000)).ToString();
            string JiaoHang = (Math.Round(cunFangTongYeDic["4108260011019110110510800002"] / 10000)).ToString();
            string NongShangHang = (Math.Round(cunFangTongYeDic["4108260011019110110515800000"] / 10000)).ToString();
            string NongHang = (Math.Round(cunFangTongYeDic["4108260011019110110515800001"] / 10000)).ToString();
            string JianHang = (Math.Round(cunFangTongYeDic["4108260011019110110515800002"] / 10000)).ToString();
            string YouChu = (Math.Round(cunFangTongYeDic["4108260011019110110515800003"] / 10000)).ToString();
            string SheYangNongShangHang = (Math.Round(cunFangTongYeDic["4108260011019110110515800004"] / 10000)).ToString();
            string ZhongXin = (Math.Round(cunFangTongYeDic["4108260011019110110515800005"] / 10000)).ToString();
            string ZhongHangDingQi = (Math.Round(cunFangTongYeDic["4108260011019110110555800000"] / 10000)).ToString();
            string GongHangDingQi = (Math.Round(cunFangTongYeDic["4108260011019110110555800001"] / 10000)).ToString();
            string NongHangDingQi = (Math.Round(cunFangTongYeDic["4108260011019110110555800002"] / 10000)).ToString();
            string JiaoHangDingQi = (Math.Round(cunFangTongYeDic["4108260011019110110555800003"] / 10000)).ToString();
            string ZhongXinDingQi = (Math.Round(cunFangTongYeDic["4108260011019110110555800004"] / 10000)).ToString();
            string JiaoZuoShangHangMengZhou = (Math.Round(cunFangTongYeDic["4108260011019110110560800001"] / 10000)).ToString();
            string JiaoZuoShangHangWuZhi = (Math.Round(cunFangTongYeDic["4108260011019110110560800002"] / 10000)).ToString();

            if (!AboutString.StringIsNullOrZero(ZhongHang))
            {
                cunFangToneTeSb.AppendFormat("中行{0}万元；", ZhongHang);
            }
            if (!AboutString.StringIsNullOrZero(GongHang))
            {
                cunFangToneTeSb.AppendFormat("工行{0}万元；", GongHang);
            }
            if (!AboutString.StringIsNullOrZero(JiaoHang))
            {
                cunFangToneTeSb.AppendFormat("交行{0}万元；", JiaoHang);
            }
            if (!AboutString.StringIsNullOrZero(NongShangHang))
            {
                cunFangToneTeSb.AppendFormat("农商行{0}万元；", NongShangHang);
            }
            if (!AboutString.StringIsNullOrZero(NongHang))
            {
                cunFangToneTeSb.AppendFormat("农行{0}万元；", NongHang);
            }
            if (!AboutString.StringIsNullOrZero(JianHang))
            {
                cunFangToneTeSb.AppendFormat("建行{0}万元；", JianHang);
            }
            if (!AboutString.StringIsNullOrZero(YouChu))
            {
                cunFangToneTeSb.AppendFormat("邮储{0}万元；", YouChu);
            }
            if (!AboutString.StringIsNullOrZero(ZhongXin))
            {
                cunFangToneTeSb.AppendFormat("中信{0}万元；", YouChu);
            }
            if (!AboutString.StringIsNullOrZero(SheYangNongShangHang))
            {
                cunFangToneTeSb.AppendFormat("射阳农商行定期{0}万元；", SheYangNongShangHang);
            }
            if (!AboutString.StringIsNullOrZero(ZhongHangDingQi))
            {
                cunFangToneTeSb.AppendFormat("中行定期{0}万元；", ZhongHangDingQi);
            }
            if (!AboutString.StringIsNullOrZero(GongHangDingQi))
            {
                cunFangToneTeSb.AppendFormat("工行定期{0}万元；", GongHangDingQi);
            }
            if (!AboutString.StringIsNullOrZero(NongHangDingQi))
            {
                cunFangToneTeSb.AppendFormat("农行定期{0}万元；", NongHangDingQi);
            }
            if (!AboutString.StringIsNullOrZero(JiaoHangDingQi))
            {
                cunFangToneTeSb.AppendFormat("交行定期{0}万元；", JiaoHangDingQi);
            }
            if (!AboutString.StringIsNullOrZero(ZhongXinDingQi))
            {
                cunFangToneTeSb.AppendFormat("中信定期{0}万元；", ZhongXinDingQi);
            }
            if (!AboutString.StringIsNullOrZero(JiaoZuoShangHangMengZhou))
            {
                cunFangToneTeSb.AppendFormat("焦作商行孟州支行{0}万元；", JiaoZuoShangHangMengZhou);
            }
            if (!AboutString.StringIsNullOrZero(JiaoZuoShangHangWuZhi))
            {
                cunFangToneTeSb.AppendFormat("焦作商行武陟支行{0}万元；", JiaoZuoShangHangWuZhi);
            }

            #endregion



            #region 定义所需的变量
            //定义所需的全部变量
            //现金,存放中央银行款项,存放同业款项,存放系统内款项,农户贷款,农村经济组织贷款,农村企业贷款,非农贷款,单位活期存款,个人活期存款,单位定期存款,个人定期存款,*个人整存整取,*个人通知存款,*个人定活两便,银行卡存款,财政性存款,保证金存款,*存放中行,*存放工行,*存放交行,*存放农商行,*存放农行,*存放建行,*存放邮政储蓄,*存放射阳农商行,*存放中行定期,*存放工行定期,*存放农行定期,*存放交行定期,*中国银联风险备付金,卡挂账手续费支出,卡挂账手续费收入,,可用头寸,贷款共计,活期存款小计,定期存款小计,各项存款小计
            decimal xianJin_Preday = 0, cunFangZhongYangYinHang_Preday = 0, cunFangTongYe_Preday = 0, cunFangXiTongNeiKuanXiang_Preday = 0, nongHUDaiKuan_Preday = 0, nongCunJingJiZuZhiDaiKuan_Preday = 0, nongCunQiYeDaiKuan_Preday = 0, feiNongDaiKuan_Preday = 0, danWeiHuoQiCunKuan_Preday = 0, geRenHuoQiCunKuan_Preday = 0, danWeiDingQiCunKuan_Preday = 0, geRenDingQiCunKuan_Preday = 0, geRenZhengCunZhengQu_Preday = 0, geRenTongZhiCunKuan_Preday = 0, geRenDingHuoLiangBian_Preday = 0, yinHangKaCunKuan_Preday = 0, caiZhengXingCunKuan_Preday = 0, baoZhengJinCunKuan_Preday = 0;

            decimal keYongTouCun_Preday = 0, TotalDaiKuan_Preday = 0, TotalHuoQiCunKuan_Preday = 0, TotalDingQiCunKuan_Preday = 0, TotalCunKuan_Preday = 0;

            decimal xianJin_Today = 0, cunFangZhongYangYinHang_Today = 0, cunFangTongYe_Today = 0, cunFangXiTongNeiKuanXiang_Today = 0, nongHUDaiKuan_Today = 0, nongCunJingJiZuZhiDaiKuan_Today = 0, nongCunQiYeDaiKuan_Today = 0, feiNongDaiKuan_Today = 0, danWeiHuoQiCunKuan_Today = 0, geRenHuoQiCunKuan_Today = 0, danWeiDingQiCunKuan_Today = 0, geRenDingQiCunKuan_Today = 0, geRenZhengCunZhengQu_Today = 0, geRenTongZhiCunKuan_Today = 0, geRenDingHuoLiangBian_Today = 0, yinHangKaCunKuan_Today = 0, caiZhengXingCunKuan_Today = 0, baoZhengJinCunKuan_Today = 0;
            decimal kaGuaZhangShouXuFeiZhiChu_Today = 0, kaGuaZhangShouXuFeiShouRu_Today = 0;
            decimal keYongTouCun_Today = 0, TotalDaiKuan_Today = 0, TotalHuoQiCunKuan_Today = 0, TotalDingQiCunKuan_Today = 0, TotalCunKuan_Today = 0, TotalDuiGongCunKuan_Today = 0, TotalChuXuCunKuan = 0;
            #endregion

            #region 从model模型中找到需要的变量值
            //现金是借方
            if (KmrjbDic.ContainsKey("1001"))
            {
                xianJin_Preday = (decimal)KmrjbDic["1001"].PREDAY_DEBIT_BALANCE;
                xianJin_Today = (decimal)KmrjbDic["1001"].TODAY_DEBIT_BALANCE;
            }
            //存放中央银行是借方
            if (KmrjbDic.ContainsKey("1002"))
            {
                cunFangZhongYangYinHang_Preday = (decimal)KmrjbDic["1002"].PREDAY_DEBIT_BALANCE;
                cunFangZhongYangYinHang_Today = (decimal)KmrjbDic["1002"].TODAY_DEBIT_BALANCE;
            }

            //存放同业是借方
            if (KmrjbDic.ContainsKey("1011"))
            {
                cunFangTongYe_Preday = (decimal)KmrjbDic["1011"].PREDAY_DEBIT_BALANCE;
                cunFangTongYe_Today = (decimal)KmrjbDic["1011"].TODAY_DEBIT_BALANCE;
            }

            //存放系统内款项是借方
            if (KmrjbDic.ContainsKey("1012"))
            {
                cunFangXiTongNeiKuanXiang_Preday = (decimal)KmrjbDic["1012"].PREDAY_DEBIT_BALANCE;
                cunFangXiTongNeiKuanXiang_Today = (decimal)KmrjbDic["1012"].TODAY_DEBIT_BALANCE;
            }

            //农户贷款是借方
            if (KmrjbDic.ContainsKey("1301"))
            {
                nongHUDaiKuan_Preday = (decimal)KmrjbDic["1301"].PREDAY_DEBIT_BALANCE;
                nongHUDaiKuan_Today = (decimal)KmrjbDic["1301"].TODAY_DEBIT_BALANCE;
            }


            //农村经济组织贷款是借方
            if (KmrjbDic.ContainsKey("1302"))
            {
                nongCunJingJiZuZhiDaiKuan_Preday = (decimal)KmrjbDic["1302"].PREDAY_DEBIT_BALANCE;
                nongCunJingJiZuZhiDaiKuan_Today = (decimal)KmrjbDic["1302"].TODAY_DEBIT_BALANCE;
            }

            //农村企业贷款是借方
            if (KmrjbDic.ContainsKey("1303"))
            {
                nongCunQiYeDaiKuan_Preday = (decimal)KmrjbDic["1303"].PREDAY_DEBIT_BALANCE;
                nongCunQiYeDaiKuan_Today = (decimal)KmrjbDic["1303"].TODAY_DEBIT_BALANCE;
            }


            //非农贷款是借方
            if (KmrjbDic.ContainsKey("1304"))
            {
                feiNongDaiKuan_Preday = (decimal)KmrjbDic["1304"].PREDAY_DEBIT_BALANCE;
                feiNongDaiKuan_Today = (decimal)KmrjbDic["1304"].TODAY_DEBIT_BALANCE;
            }
            //单位活期存款是贷方
            if (KmrjbDic.ContainsKey("2001"))
            {
                danWeiHuoQiCunKuan_Preday = (decimal)KmrjbDic["2001"].PREDAY_CREDIT_BALANCE;
                danWeiHuoQiCunKuan_Today = (decimal)KmrjbDic["2001"].TODAY_CREDIT_BALANCE;
            }
            //单位活期存款是贷方
            if (KmrjbDic.ContainsKey("2001"))
            {
                danWeiHuoQiCunKuan_Preday = (decimal)KmrjbDic["2001"].PREDAY_CREDIT_BALANCE;
                danWeiHuoQiCunKuan_Today = (decimal)KmrjbDic["2001"].TODAY_CREDIT_BALANCE;
            }
            //个人活期存款是贷方
            if (KmrjbDic.ContainsKey("2003"))
            {
                geRenHuoQiCunKuan_Preday = (decimal)KmrjbDic["2003"].PREDAY_CREDIT_BALANCE;
                geRenHuoQiCunKuan_Today = (decimal)KmrjbDic["2003"].TODAY_CREDIT_BALANCE;
            }
            //单位定期存款是贷方
            if (KmrjbDic.ContainsKey("2002"))
            {
                danWeiDingQiCunKuan_Preday = (decimal)KmrjbDic["2002"].PREDAY_CREDIT_BALANCE;
                danWeiDingQiCunKuan_Today = (decimal)KmrjbDic["2002"].TODAY_CREDIT_BALANCE;
            }
            //个人定期存款是贷方
            if (KmrjbDic.ContainsKey("2004"))
            {
                geRenDingQiCunKuan_Preday = (decimal)KmrjbDic["2004"].PREDAY_CREDIT_BALANCE;
                geRenDingQiCunKuan_Today = (decimal)KmrjbDic["2004"].TODAY_CREDIT_BALANCE;
            }

            //个人整存整取是贷方
            if (KmrjbDic.ContainsKey("200405"))
            {
                geRenZhengCunZhengQu_Preday = (decimal)KmrjbDic["200405"].PREDAY_CREDIT_BALANCE;
                geRenZhengCunZhengQu_Today = (decimal)KmrjbDic["200405"].TODAY_CREDIT_BALANCE;
            }
            //个人通知存款是贷方
            if (KmrjbDic.ContainsKey("200425"))
            {
                geRenTongZhiCunKuan_Preday = (decimal)KmrjbDic["200425"].PREDAY_CREDIT_BALANCE;
                geRenTongZhiCunKuan_Today = (decimal)KmrjbDic["200425"].TODAY_CREDIT_BALANCE;
            }
            //个人定活两便是贷方
            if (KmrjbDic.ContainsKey("200435"))
            {
                geRenDingHuoLiangBian_Preday = (decimal)KmrjbDic["200435"].PREDAY_CREDIT_BALANCE;
                geRenDingHuoLiangBian_Today = (decimal)KmrjbDic["200435"].TODAY_CREDIT_BALANCE;
            }

            //银行卡存款是贷方
            if (KmrjbDic.ContainsKey("2005"))
            {
                yinHangKaCunKuan_Preday = (decimal)KmrjbDic["2005"].PREDAY_CREDIT_BALANCE;
                yinHangKaCunKuan_Today = (decimal)KmrjbDic["2005"].TODAY_CREDIT_BALANCE;
            }
            //财政性存款是贷方
            if (KmrjbDic.ContainsKey("2006"))
            {
                caiZhengXingCunKuan_Preday = (decimal)KmrjbDic["2006"].PREDAY_CREDIT_BALANCE;
                caiZhengXingCunKuan_Today = (decimal)KmrjbDic["2006"].TODAY_CREDIT_BALANCE;
            }
            //保证金存款是贷方
            if (KmrjbDic.ContainsKey("2014"))
            {
                baoZhengJinCunKuan_Preday = (decimal)KmrjbDic["2014"].PREDAY_CREDIT_BALANCE;
                baoZhengJinCunKuan_Today = (decimal)KmrjbDic["2014"].TODAY_CREDIT_BALANCE;
            }


            //卡挂账手续费支出是借方发生额
            if (KmrjbDic.ContainsKey("12219905"))
            {
                kaGuaZhangShouXuFeiZhiChu_Today = (decimal)KmrjbDic["12219905"].TODAY_DEBIT_AMT;
            }
            //卡挂账手续费收入是贷方发生额
            if (KmrjbDic.ContainsKey("22419915"))
            {
                kaGuaZhangShouXuFeiShouRu_Today = (decimal)KmrjbDic["22419915"].TODAY_CREDIT_AMT;
            }
            #endregion

            //为需要计算的变量赋值
            //贷款=农户贷款+农村经济组织贷款+农村企业贷款+非农贷款
            TotalDaiKuan_Preday = nongHUDaiKuan_Preday + nongCunJingJiZuZhiDaiKuan_Preday + nongCunQiYeDaiKuan_Preday + feiNongDaiKuan_Preday;
            TotalDaiKuan_Today = nongHUDaiKuan_Today + nongCunJingJiZuZhiDaiKuan_Today + nongCunQiYeDaiKuan_Today + feiNongDaiKuan_Today;

            //活期存款合计=单位活期+个人活期
            TotalHuoQiCunKuan_Preday = danWeiHuoQiCunKuan_Preday + geRenHuoQiCunKuan_Preday;
            TotalHuoQiCunKuan_Today = danWeiHuoQiCunKuan_Today + geRenHuoQiCunKuan_Today;

            //对公存款=单位活期+单位定期+财政性存款+贷款保证金存款
            TotalDuiGongCunKuan_Today = danWeiHuoQiCunKuan_Today + danWeiDingQiCunKuan_Today + caiZhengXingCunKuan_Today + baoZhengJinCunKuan_Today;
            //储蓄存款=个人活期+个人定+银行卡存款
            TotalChuXuCunKuan = geRenHuoQiCunKuan_Today + geRenDingQiCunKuan_Today + yinHangKaCunKuan_Today;

            //定期存款合计=单位定期+个人定期
            TotalDingQiCunKuan_Preday = danWeiDingQiCunKuan_Preday + geRenDingQiCunKuan_Preday;
            TotalDingQiCunKuan_Today = danWeiDingQiCunKuan_Today + geRenDingQiCunKuan_Today;

            //总存款=活期存款+定期存款+银行卡存款+财政性存款+保证金存款
            TotalCunKuan_Preday = TotalHuoQiCunKuan_Preday + TotalDingQiCunKuan_Preday + yinHangKaCunKuan_Preday + caiZhengXingCunKuan_Preday + baoZhengJinCunKuan_Preday;
            TotalCunKuan_Today = TotalHuoQiCunKuan_Today + TotalDingQiCunKuan_Today + yinHangKaCunKuan_Today + caiZhengXingCunKuan_Today + baoZhengJinCunKuan_Today;

            //可用头寸=现金+存放同业款项+存放系统内款项-100万（省联社保证金）-总存款*0.14
            keYongTouCun_Preday = xianJin_Preday + cunFangTongYe_Preday + (cunFangXiTongNeiKuanXiang_Preday - 1000000) + cunFangZhongYangYinHang_Preday - TotalCunKuan_Preday * 0.105m;
            keYongTouCun_Today = xianJin_Today + cunFangTongYe_Today + (cunFangXiTongNeiKuanXiang_Today - 1000000) + cunFangZhongYangYinHang_Today - TotalCunKuan_Today * 0.105m;

            decimal TotalCunKuanBiShangRi = TotalCunKuan_Today - TotalCunKuan_Preday;
            decimal geRenZhengCunZhengQuBiShangRi = geRenZhengCunZhengQu_Today - geRenZhengCunZhengQu_Preday;
            decimal TotalDaiKuanBiShangRi = TotalDaiKuan_Today - TotalDaiKuan_Preday;
            decimal keYongTouCunBiShangRi = keYongTouCun_Today - keYongTouCun_Preday;

            string Head_Date = string.Format("截止到{0}月{1}日，", DateTime.Now.AddDays(-1).Month, DateTime.Now.AddDays(-1).Day);
            //拼接字符串，并用短信分割字符串临时保存，以便将来发送短信
            dailyMessageSb.Append(Head_Date);
            //dailyMessageSb.AppendFormat("一、我行各项存款余额为{0}万元，比上日{1}万元，其中活期存款{2}元，定期存款{3}万元(其中个人定存：{4}万元，比上日{5}万元)，银行卡存款{6}万元，财政性存款{7}万元，贷款保证金存款{8}万元。\r\n",
            //      Math.Round(TotalCunKuan_Today / 10000).ToString(),
            //      TotalCunKuanBiShangRi > 0 ? ("+" + Math.Round(TotalCunKuanBiShangRi / 10000).ToString()) : Math.Round(TotalCunKuanBiShangRi / 10000).ToString(),
            //     Math.Round(TotalHuoQiCunKuan_Today / 10000).ToString(),
            //     Math.Round(TotalDingQiCunKuan_Today / 10000).ToString(),
            //     Math.Round(geRenZhengCunZhengQu_Today / 10000).ToString(),
            //     geRenZhengCunZhengQuBiShangRi > 0 ? ("+" + Math.Round(geRenZhengCunZhengQuBiShangRi / 10000).ToString()) : (Math.Round(geRenZhengCunZhengQuBiShangRi / 10000).ToString()),
            //      Math.Round(yinHangKaCunKuan_Today / 10000).ToString(),
            //      Math.Round(caiZhengXingCunKuan_Today / 10000).ToString(),
            //      Math.Round(baoZhengJinCunKuan_Today / 10000).ToString());

            dailyMessageSb.AppendFormat("一，我行各项存款{0}万元，比上日{1}万元。对公存款{2}万元（其中单位活期{3}万元，单位定期{4}万元，财政性存款{5}万元，贷款保证金{6}万元）；储蓄存款{7}万元（其中个人活期{8}万元，银行卡存款{9}万元，定活两便{10}万元，通知存款{11}万元，个人定存{12}万元，比上日{13}万元）。\r\n",
                Math.Round(TotalCunKuan_Today / 10000).ToString(),
                 TotalCunKuanBiShangRi >= 0 ? ("+" + Math.Round(TotalCunKuanBiShangRi / 10000).ToString()) : Math.Round(TotalCunKuanBiShangRi / 10000).ToString(),
                 Math.Round(TotalDuiGongCunKuan_Today / 10000).ToString(),
                 Math.Round(danWeiHuoQiCunKuan_Today / 10000),
                 Math.Round(danWeiDingQiCunKuan_Today / 10000),
                 Math.Round(caiZhengXingCunKuan_Today / 10000),
                 Math.Round(baoZhengJinCunKuan_Today / 10000),
                 Math.Round(TotalChuXuCunKuan / 10000),
                 Math.Round(geRenHuoQiCunKuan_Today / 10000),
                 Math.Round(yinHangKaCunKuan_Today / 10000),
                 Math.Round(geRenDingHuoLiangBian_Today / 10000),
                 Math.Round(geRenTongZhiCunKuan_Today / 10000),
                 Math.Round(geRenZhengCunZhengQu_Today / 10000),
                  geRenZhengCunZhengQuBiShangRi >= 0 ? ("+" + Math.Round(geRenZhengCunZhengQuBiShangRi / 10000).ToString()) : (Math.Round(geRenZhengCunZhengQuBiShangRi / 10000).ToString())
                 );


            dailyMessageSb.AppendFormat("二、各项贷款余额为{0}万元，比上日{1}万元。\r\n",
                      Math.Round(TotalDaiKuan_Today / 10000),
                      TotalDaiKuanBiShangRi >= 0 ? ("+" + Math.Round(TotalDaiKuanBiShangRi / 10000).ToString()) : (Math.Round(TotalDaiKuanBiShangRi / 10000).ToString())).ToString();

            //存放省联社的可用头寸要减去300万，存放中央银行的可用头寸要减去存款准备金，总存款*0.14
            dailyMessageSb.AppendFormat("三、可用头寸为{0}万元（现金{1}万元；{2}存放江苏省联社{3}万元；存放中央银行{4}万元），比上日{5}万元。\r\n",
                Math.Round(keYongTouCun_Today / 10000),
                Math.Round(xianJin_Today / 10000),
                cunFangToneTeSb.ToString(),
                Math.Round((cunFangXiTongNeiKuanXiang_Today - 3000000) / 10000),
                Math.Round((cunFangZhongYangYinHang_Today - TotalCunKuan_Today * 0.105m) / 10000),
                keYongTouCunBiShangRi >= 0 ? ("+" + Math.Round(keYongTouCunBiShangRi / 10000).ToString()) : (Math.Round(keYongTouCunBiShangRi / 10000).ToString())
                );

            dailyMessageSb.AppendFormat("四、昨日银行卡手续费支出{0}元，手续费收入{1}元。",
               kaGuaZhangShouXuFeiZhiChu_Today.ToString("0"),
               kaGuaZhangShouXuFeiShouRu_Today.ToString("0")
               );


            //拼接字符串，并用短信分割字符串临时保存，以便将来发送短信           
            dxfg1Sb.Append(Head_Date);
            dxfg1Sb.AppendFormat("我行各项存款{0}万元，比上日{1}万元。对公存款{2}万元（其中单活{3}万元，单定{4}万元，财政性存款{5}万元，贷款保证金{6}万元）；储蓄存款{7}万元（其中个人活期{8}万元，银行卡存款{9}万元，定活{10}万元，通知{11}万元，个人定存{12}万元，比上日{13}万元）。\r\n",
              Math.Round(TotalCunKuan_Today / 10000).ToString(),
               TotalCunKuanBiShangRi >= 0 ? ("+" + Math.Round(TotalCunKuanBiShangRi / 10000).ToString()) : Math.Round(TotalCunKuanBiShangRi / 10000).ToString(),
               Math.Round(TotalDuiGongCunKuan_Today / 10000).ToString(),
               Math.Round(danWeiHuoQiCunKuan_Today / 10000),
               Math.Round(danWeiDingQiCunKuan_Today / 10000),
               Math.Round(caiZhengXingCunKuan_Today / 10000),
               Math.Round(baoZhengJinCunKuan_Today / 10000),
               Math.Round(TotalChuXuCunKuan / 10000),
               Math.Round(geRenHuoQiCunKuan_Today / 10000),
               Math.Round(yinHangKaCunKuan_Today / 10000),
               Math.Round(geRenDingHuoLiangBian_Today / 10000),
               Math.Round(geRenTongZhiCunKuan_Today / 10000),
               Math.Round(geRenZhengCunZhengQu_Today / 10000),
                geRenZhengCunZhengQuBiShangRi >= 0 ? ("+" + Math.Round(geRenZhengCunZhengQuBiShangRi / 10000).ToString()) : (Math.Round(geRenZhengCunZhengQuBiShangRi / 10000).ToString())
               );
            dxfg2Sb.Append(Head_Date);
            dxfg2Sb.AppendFormat("我行各项贷款余额为{0}万元，比上日{1}万元。\r\n",
                       Math.Round(TotalDaiKuan_Today / 10000),
                       TotalDaiKuanBiShangRi > 0 ? ("+" + Math.Round(TotalDaiKuanBiShangRi / 10000).ToString()) : (Math.Round(TotalDaiKuanBiShangRi / 10000).ToString())).ToString();

            //存放省联社的可用头寸要减去300万，存放中央银行的可用头寸要减去存款准备金，总存款*0.14
            dxfg3Sb.Append(Head_Date);
            dxfg3Sb.AppendFormat("我行的可用头寸为{0}万元（现金{1}万元；{2}存放江苏省联社{3}万元；存放中央银行{4}万元），比上日{5}万元。\r\n",
                 Math.Round(keYongTouCun_Today / 10000),
                 Math.Round(xianJin_Today / 10000),
                 cunFangToneTeSb.ToString(),
                 Math.Round((cunFangXiTongNeiKuanXiang_Today - 3000000) / 10000),
                 Math.Round((cunFangZhongYangYinHang_Today - TotalCunKuan_Today * 0.105m) / 10000),
                 keYongTouCunBiShangRi >= 0 ? ("+" + Math.Round(keYongTouCunBiShangRi / 10000).ToString()) : (Math.Round(keYongTouCunBiShangRi / 10000).ToString())
                 );
            dxfg4Sb.Append(Head_Date);
            dxfg4Sb.AppendFormat("我行昨日银行卡手续费支出{0}元，手续费收入{1}元。",
                kaGuaZhangShouXuFeiZhiChu_Today.ToString("0"),
                kaGuaZhangShouXuFeiShouRu_Today.ToString("0")
                );


            //decimal cunFangZhongHang, cunFangGongHang, cunFangJiaoHang, cunFangNongShangHang, cunFangNongHang, cunFangJianHang, cunFangYouZheng, cunFangSheYangNongShangHang, cunFangZhongHangDingQi, cunFangGongHangDingQi, cunFangJiaoHangDingQi, cunFangNongShangHangDingQi;//存放同业款项功能暂不公开
            lst.Add(dailyMessageSb.ToString());
            lst.Add(cunFangToneTeSb.ToString());
            lst.Add(dxfg1Sb.ToString());
            lst.Add(dxfg2Sb.ToString());
            lst.Add(dxfg3Sb.ToString());
            lst.Add(dxfg4Sb.ToString());

            return lst;




        }
    }
}
