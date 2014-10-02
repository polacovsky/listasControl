using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CapaConexion
{
   public class Funciones
    {

        public static string devolverfiltrado(string campo, string textoPaFiltrar)
        {
            string[] words = textoPaFiltrar.Split(new char[] { ' ' });
            string filtro = "";
            string word = null;
            foreach (string word_loopVariable in words)
            {
                word = word_loopVariable;
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro += "CONVERT(" + campo + ", 'System.String')  like '%" + word.Trim() + "%'";
                }
                else
                {
                    filtro += " and CONVERT(" + campo + ", 'System.String')  like '%" + word.Trim() + "%'";
                }
            }

            return filtro;
        }

        //requires: Microsoft.Office.Interop.Excel to be added as reference
        public static void ExportGridToExcel(DataGridView grid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass excelSheet = new Microsoft.Office.Interop.Excel.ApplicationClass();
                excelSheet.Application.Workbooks.Add(true);
                int columnIndex = 0;
                //Columns Heading of Datagridview     
                foreach (DataGridViewColumn column in grid.Columns)
                {
                   
                        columnIndex++;
                        excelSheet.Cells[1, columnIndex] = column.HeaderText;                      
                  
                }
                var x = Convert.ToChar(grid.Columns.Count + 64);
                Microsoft.Office.Interop.Excel.Range rng = excelSheet.get_Range("A1", x +"1"); //excelSheet.Cells[ 1  , grid.Columns.Count] as  Microsoft.Office.Interop.Excel.Range;
                rng.Font.Bold = true;                
                int rowIndex = 0;              
                foreach (DataGridViewRow row in grid.Rows)
                {
                    rowIndex++;
                    columnIndex = 0;
                    foreach (DataGridViewColumn column in grid.Columns)
                    {                    
                            columnIndex++;
                            excelSheet.Cells[rowIndex + 1, columnIndex] = row.Cells[column.Name].FormattedValue;                    
                    }
                }
                excelSheet.Visible = true;
                Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelSheet.ActiveSheet;
                //workSheet.Activate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
   
   }
}
