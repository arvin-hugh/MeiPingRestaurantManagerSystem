using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MeiPingRestaurantManagerSystem
{
    /// <summary>
    /// 文档导出
    /// </summary>
    public static class Export
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        /// <summary>
        /// 数据导出[不要动]
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool ExportInfo(System.Data.DataTable dt)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls";
            sfd.Title = "Excel文件导出";
            string fileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName.Substring(sfd.FileName.LastIndexOf("\\") + 1);
                try
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    try
                    {
                        app.Visible = false;
                        Microsoft.Office.Interop.Excel.Workbook wBook = app.Workbooks.Add(true);
                        Microsoft.Office.Interop.Excel.Worksheet wSheet = wBook.Sheets[1];
                        wSheet.Name = fileName;

                        object[,] objData = new object[dt.Rows.Count + 1, dt.Columns.Count];
                        //首先将数据写入到一个二维数组中  
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            objData[0, i] = dt.Columns[i].ColumnName;
                        }
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    if (dt.Rows[i][j].Equals(float.NaN))//查询过来的float.NaN
                                        objData[i + 1, j] = "-";
                                    //else if (String.IsNullOrEmpty(dt.Rows[i][j].ToString()) && dt.Rows[i][j].Equals(DBNull.Value))//有dbnull的数据，需要屏蔽掉——在数据源处理了
                                    //    objData[i + 1, j] = dt.Rows[i][j];
                                    else
                                        objData[i + 1, j] = dt.Rows[i][j];
                                }
                            }
                        }

                        string startCol = "A";//这里关键，计算要替换的区域
                        int iCnt = ((dt.Columns.Count - 1) / 26);//当列数是26时 不-1 会出现问题，自己试试就明白了
                        string endColSignal = (iCnt == 0 ? "" : ((char)('A' + (iCnt - 1))).ToString());
                        string endCol = endColSignal + ((char)('A' + dt.Columns.Count - iCnt * 26 - 1)).ToString();
                        Microsoft.Office.Interop.Excel.Range range = wSheet.get_Range(startCol + "1", endCol + (dt.Rows.Count + 1).ToString());

                        range.Value = objData; //给Exccel中的Range整体赋值  
                        range.EntireColumn.AutoFit(); //设定Excel列宽度自适应  
                        wSheet.get_Range(startCol + "1", endCol + "1").Font.Bold = 1;//Excel文件列名 字体设定为Bold  


                        //设置禁止弹出保存和覆盖的询问提示框   
                        app.DisplayAlerts = false;
                        app.AlertBeforeOverwriting = false;
                        //保存工作簿 
                        wSheet.SaveAs(sfd.FileName.ToString());
                        wBook.Close();
                        //保存excel文件   
                        app.Quit();
                        GC.Collect();
                        return true;
                    }
                    catch (Exception err)//这里还有些问题，比如 对方安装的是WPS 不会提示中文错误，没有安装office 也不会弹出该错误
                    {
                        MessageBox.Show("导出Excel出错！错误原因：" + err.Message, "提示信息",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //强制结束excel进程
                        IntPtr t = new IntPtr(app.Hwnd);
                        int k = 0;
                        GetWindowThreadProcessId(t, out k);
                        System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(k);
                        p.Kill();
                        return false;
                    }
                    return true;
                }
                catch (System.Exception exc)
                {
                    MessageBox.Show("excel运行错误：" + exc.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
