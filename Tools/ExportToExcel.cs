using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Tools
{
    public class ExportToExcel
    {
        /// <summary>
        /// 根据数据集和表头，返回stringwriter。表头的格式为：“编号\t帐号\t姓名\t电话\t地址\t金额\t。。。”
        /// </summary>
        /// <param name="thisDataTable"></param>
        /// <param name="strHeader"></param>
        /// <returns></returns>
        public static StringWriter DataTableExportToExcel(DataTable thisDataTable,string strHeader)
        {
            
            if (thisDataTable != null)
            {
                StringWriter sw = new StringWriter();
                sw.WriteLine(strHeader);
                foreach (DataRow dr in thisDataTable.Rows)
                {
                    for (int i = 0; i < thisDataTable.Columns.Count; i++)
                    {
                        sw.Write(dr[i] + "\t");
                    }
                    sw.WriteLine();
                }
                sw.Close();
                return sw;
            }
            else
            {
                return null;
            }
        }
    }
}
