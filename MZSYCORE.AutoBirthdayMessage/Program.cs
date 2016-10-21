using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MZSYCORE.AutoMessage
{
    class Program
    {

        static void Main(string[] args)
        {
            ///首次运行该程序时，确定是否要发送今日短信。如果选否，那么等待明日执行。如果选是，今日就开始执行。
            ///

            DateTime dtFirstDay = DateTime.Now;//设定首次运行的时间
            string strDuiBiDay = dtFirstDay.ToString("yyyy-MM-dd");
            Console.WriteLine("首次运行的时间为：{0}", dtFirstDay.ToString());

            //设置总的标志，每次开机时执行一次。
            bool zongBiaoZhi;
            Console.WriteLine("今天的短信是否还要发送，如果需要，请输入y，否则输入任意键不发送。。。");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                    zongBiaoZhi = true;
                    break;
                case "Y":
                    zongBiaoZhi = true;
                    break;
                default:
                    zongBiaoZhi = false;
                    break;
            }

            //一直循环执行
            while (true)
            {
                //
                if (!zongBiaoZhi)
                {
                    ///根据对比时间，设置下次执行时间。如果当前日期和执行日期相等，那么就判断钟点数。如果点数合适，那就执行
                    DateTime nextExecuteDay = Tools.ConventToDateTime.ConventStringToDateTime(strDuiBiDay).AddDays(1);
                    if (nextExecuteDay.Date == DateTime.Now.Date)
                    {
                        if (DateTime.Now.Hour >= 7)
                        {
                            zongBiaoZhi = true;
                        }
                    }
                }
                while (zongBiaoZhi)
                {
                    #region 执行今日任务
                    //设置短信是否发送的标志，默认为false未发送。
                    bool isOkBirthdayMessage =false, isOkMrdqdcMessage = false;
                    //bool isOkBirthdayMessage = true, isOkMrdqdcMessage = true;//测试语句
                    bool isOkDailyMessage = true;

                    //如果有任意一个短信发送未成功，则循环不停。
                    while ((!isOkBirthdayMessage) || (!isOkMrdqdcMessage) || (!isOkDailyMessage))
                    {
                        //如果未发送，那么执行发送方法，同时设定其标志位true
                        if (!isOkBirthdayMessage)
                        {
                            if (SendBirthdayMessage())
                            {
                                isOkBirthdayMessage = true;
                                Console.WriteLine();
                                Console.WriteLine("==================================================");
                                Console.WriteLine("=============今日生日短信已经发送完毕=============");
                                Console.WriteLine("==================================================");
                                Console.WriteLine();
                            }
                        }

                        if (!isOkMrdqdcMessage)
                        {
                            if (SendMRDQDCMessage())
                            {
                                isOkMrdqdcMessage = true;
                                Console.WriteLine();
                                Console.WriteLine("==================================================");
                                Console.WriteLine("=============今日定期提醒已经发送完毕=============");
                                Console.WriteLine("==================================================");
                                Console.WriteLine();
                            }
                        }

                        if (!isOkDailyMessage)
                        {
                            if (SendDailyMessage())
                            {
                                isOkDailyMessage = true;
                                Console.WriteLine();
                                Console.WriteLine("==================================================");
                                Console.WriteLine("=============今日总行日报已经发送完毕=============");
                                Console.WriteLine("==================================================");
                                Console.WriteLine();
                            }
                        }

                        if ((isOkBirthdayMessage) && (isOkMrdqdcMessage) && (isOkDailyMessage))
                        {
                            break;
                        }
                        Console.WriteLine("等待60秒之后重新执行。。。");
                        Thread.Sleep(60000);
                    }
                    Console.WriteLine();
                    Console.WriteLine("==================================================");
                    Console.WriteLine("=================所有任务执行完毕=================");
                    Console.WriteLine("==================================================");

                    //今天任务执行完毕之后，将对比时间设置为当前时间，并将标志设置为false，退出循环。
                    strDuiBiDay = DateTime.Now.ToString("yyyy-MM-dd");
                    zongBiaoZhi = false;//任务执行完毕后将总标志设置为false，退出循环
                    //Console.ReadLine();//调试用，要注释掉 
                    #endregion
                }
                Console.WriteLine("当前时间为：{0}，执行时间未到，请继续等待。", DateTime.Now.ToString());
                Thread.Sleep(1000 * 60 * 30);
            }
        }

        /// <summary>
        /// 发送总行日报短信
        /// </summary>
        private static bool SendDailyMessage()
        {
            ///首先查询是否有内部帐余额，如果没有，那么自动跳出，等待。
            ///如果有内部帐余额，那么查询是否有财管系统数据，如果没有，那么跳出，等待
            ///如果有财管系统数据，则拼接存放同业短信，拼接每日短信
            ///发送
            ///

            bool flag = false;

            DateTime daynow = DateTime.Now;
            string yesterdayStr = daynow.AddDays(-1).ToString("yyyyMMdd");//正常语句
            //string yesterdayStr = daynow.AddDays(1).ToString("yyyyMMdd");//测试语句

            BLL.BLL_CBOD_GLACAACA bll_cbod_glacaaca = new BLL.BLL_CBOD_GLACAACA();
            Dictionary<string, decimal> cunFangTongYeDic = bll_cbod_glacaaca.GetCunFangTongYeDic("410826001", yesterdayStr);

            BLL.BLL_FNIE_KMRJB bll_fnie_kmrjb = new BLL.BLL_FNIE_KMRJB();
            Dictionary<string, Model.Model_FNIE_KMRJB> KmrjbDic = bll_fnie_kmrjb.GetMessageModelDic(yesterdayStr, "410826000");

            int successCout = 0, falseCount = 0;
            if (cunFangTongYeDic != null)
            {
                if (KmrjbDic != null)
                {
                    List<string> messageList = SendMessage.CreatDailyMessage(cunFangTongYeDic, KmrjbDic);
                    Console.WriteLine("日报短信已经生成：");
                    Console.WriteLine(messageList[0]);
                    List<string> telphone = CreatDailyMessageTelephoneList();
                    //科目日记表和存放同业的数据都存在，那么开始发送短信。
                    for (int i = 0; i < telphone.Count; i++)
                    {
                        SendMessage sms = new SendMessage();
                        if (sms.SendToPasDB(telphone[i], messageList[2]) && sms.SendToPasDB(telphone[i], messageList[3]) && sms.SendToPasDB(telphone[i], messageList[4]) && sms.SendToPasDB(telphone[i], messageList[5]))
                        {
                            successCout++;
                            Console.WriteLine(" {0} 的日报短信已经发送成功。", telphone[i]);
                        }
                        else
                        {
                            falseCount++;
                        }

                    }
                    flag = true;
                }
                else
                {
                    Console.WriteLine("财管系统数据尚未到达，请稍后：");
                    return flag;
                }
            }
            else
            {
                Console.WriteLine("存放同业数据尚未到达，请稍后：");
                return flag;
            }
            return flag;
        }


        /// <summary>
        /// 发送明日到期定存提醒短信
        /// </summary>
        private static bool SendMRDQDCMessage()
        {
            bool flag = false;
            //获取需要的相关时间
            DateTime today = DateTime.Now;
            DateTime tomorrow = today.AddDays(2);
            string tomorrowDate = tomorrow.ToString("yyyyMMdd");

            //获取数据列表
            BLL.MyCode.BLL_ZiZao_MRDQDC_CBOD_TDACNACN bll_zizao_mrdqdc_cbod_tdacnacn = new BLL.MyCode.BLL_ZiZao_MRDQDC_CBOD_TDACNACN();
            List<Model.Model_ZiZao_MRDQDC_CBOD_TDACNACN> modelList = bll_zizao_mrdqdc_cbod_tdacnacn.GetModelList(tomorrowDate);

            int successCount = 0, falseCount = 0;
            //循环数据列表并发送短信
            if (modelList != null)
            {
                Console.WriteLine("提醒：今天总共有{0}条后天到期提醒短信需要发送", modelList.Count);
                for (int i = 0; i < modelList.Count; i++)
                {
                    SendMessage sms = new SendMessage();
                    if (sms.SendToPasDB(modelList[i]))
                    {
                        successCount++;
                        Console.WriteLine(" {0} 的短信已经发送成功。", modelList[i].Td_conntr_no);
                    }
                    else
                    {
                        falseCount++;
                        Console.WriteLine(" {0} 的短信已经发送失败。", modelList[i].Td_conntr_no);
                    }
                    // Console.ReadLine();//调试用，要注释掉

                }
                flag = true;
                Console.WriteLine("到期存单提醒短信已经发送，其中成功：{0}条，失败{1}条", successCount, falseCount);
            }
            else
            {
                Console.WriteLine("后天没有相关的定期存款到期提醒短信需要发送！");

            }
            return flag;
        }

        /// <summary>
        /// 发送生日提醒短信
        /// </summary>
        /// <returns></returns>
        private static bool SendBirthdayMessage()
        {
            bool flag = false;
            DateTime today = DateTime.Now;
            string todayMMdd = today.ToString("MM") + "-" + today.ToString("dd");


            BLL.BLL_XTB_DXTZ bll_xtb_dxtz = new BLL.BLL_XTB_DXTZ();
            BLL.MyCode.BLL_ZiZao_BirthdayMessage bll_zizao_birthdaymessage = new BLL.MyCode.BLL_ZiZao_BirthdayMessage();

            //获取当天生日的客户列表
            List<Model.Model_ZiZao_BirthdayMessage> modelList = new List<Model.Model_ZiZao_BirthdayMessage>();
            modelList = bll_zizao_birthdaymessage.GetModelList(todayMMdd);

            int successCount = 0, falseCount = 0;

            //循环该列表，并发送短信
            if (modelList != null)
            {
                Console.WriteLine("提醒：今天总共有{0}条生日祝福短信需要发送", modelList.Count);
                for (int i = 0; i < modelList.Count; i++)
                {
                    SendMessage sms = new SendMessage();
                    Model.Model_ZiZao_BirthdayMessage model = modelList[i];
                    if (sms.SendToPasDB(model))
                    {
                        successCount++;
                        Console.WriteLine(" {0} 的短信已经发送成功。", modelList[i].CUST_NAME);
                    }
                    else
                    {
                        falseCount++;
                        Console.WriteLine(" {0} 的短信发送失败。", modelList[i].CUST_NAME);
                    }
                    // Console.ReadLine();//调试用，要注释掉
                }
                flag = true;
                Console.WriteLine("生日短信已经发送，其中成功：{0}条，失败{1}条", successCount, falseCount);
            }
            else
            {
                Console.WriteLine("今天没有生日的人。");
            }
            return flag;
        }


        /// <summary>
        /// 生成每日短信的短信列表，也可以理解为初始化。
        /// </summary>
        public static List<string> CreatDailyMessageTelephoneList()
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
            //telephone.Add("");//谢丹

            //信贷
            telephone.Add("18339715856");//陈晓宁
            telephone.Add("15713910058");//马玉晓
            telephone.Add("18239126633");//马明


            return telephone;
        }


    }
}
