using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MZSYCORE.BLL;
using MZSYCORE.Model;
using System.Data;

namespace Tools
{
    public class SendMessageFromPasDB
    {

        BLL_XTB_DXTZ bll_xtb_dxtz = new BLL_XTB_DXTZ();
        BLL_employee_info bll_employee_info = new BLL_employee_info();


        /// <summary>
        /// 往绩效系统数据库的短信通知表中写入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SendToPasDB(Model_XTB_DXTZ model)
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
                Model_XTB_DXTZ model = new Model_XTB_DXTZ();
                model.HYDH = "4102";
                model.SJ = DateTime.Now;
                model.TEL = tel;
                model.CONTENT = content;
                model.ZT = "0";//如果测试，就改成1，只写数据库不发送。正常情况下改为0.
               // model.ZT = "1";//如果测试，就改成1，只写数据库不发送。正常情况下改为0.
                return SendToPasDB(model);
            }
        }


        /// <summary>
        /// 发布新闻之后，给全行员工发送提醒
        /// </summary>
        /// <param name="publishPerson"></param>
        /// <param name="newsTitle"></param>
        /// <returns></returns>
        public void SendNewsMessage(string publishPerson, string newsTitle)
        {
            ///组装拼接短信内容
            ///提取电话号码，然后循环发送
            ///
           
            //拼接短信内容
            StringBuilder message = new StringBuilder();
            message.AppendFormat("{0}刚刚在核心数据系统上发布了一条消息，标题为：“{1}”。如您需要，请登录 http://32.188.144.8 浏览！", publishPerson, newsTitle);

            //提取电话号码
            DataSet ds = bll_employee_info.GetXXList("phone_number_1", "");

            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    SendToPasDB(ds.Tables[0].Rows[i][0].ToString(), message.ToString());
                }
            }

        }

    }

}
