using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Moni\Documents\Visual Studio 2015\Projects\ObjFilesExeptions\EXCELlentKnowledge\bin\Debug\sample_table.xlsx");
        Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        Excel.Range xlRange = xlWorksheet.UsedRange;
        int rowsCount = xlRange.Rows.Count;
        int columesCount = xlRange.Columns.Count;
        List<string> rows = new List<string>();
        for (int i = 1; i <=rowsCount; i++)
        {
            string final = "";
            for (int j = 1; j <= columesCount; j++)
            {
                if(xlRange.Cells[i,j] != null && xlRange.Cells[i,j].Value != null)
                {
                    final += xlRange.Cells[i, j].Value2.ToString() + "|";
                }
            }
            rows.Add(final);
        }
        foreach (var row in rows)
        {
            File.AppendAllText("final_file.txt", row);
            File.AppendAllText("final_file.txt", Environment.NewLine);
        }
    }
}
