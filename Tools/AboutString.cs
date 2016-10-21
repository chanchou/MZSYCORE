using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools
{
    public class AboutString
    {
        /// <summary>
        /// 判断字符串是否为空，为0
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool StringIsNullOrZero(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            else
            {
                if (str.Trim() == "0")
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
}
