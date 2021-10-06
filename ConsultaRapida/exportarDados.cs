using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsultaRapida
{
    class exportarDados
    {
        public static void Excel(DataGridView dgv)
        {

            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null)
            {
                MessageBox.Show("Você não possui o Excel instalado nesse computador!");
            }
            else
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                try
                {
                    Loading load = new Loading();
                    load.Show();                    

                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                    Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                    int StartCol = 1;
                    int StartRow = 1;
                    int j = 0, i = 0;

                    //Escrever o Header
                    for (j = 0; j < dgv.Columns.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                        myRange.Value2 = dgv.Columns[j].HeaderText;
                        myRange.Interior.Color = Color.FromArgb(84, 26, 156);
                        myRange.Font.Color = Color.WhiteSmoke;
                    }

                    StartRow++;

                    //Escrever conteudo do datagridview
                    for (i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (j = 0; j < dgv.Columns.Count; j++)
                        {
                            try
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                                myRange.Value2 = dgv[j, i].Value == null ? "" : dgv[j, i].Value;
                                myRange.Interior.Color = Color.FromArgb(205,223,246);
                            }
                            catch
                            {
                                ;
                            }
                        }
                    }
                    StartRow = 2;
                    i = 0;

                    
                    sheet1.Columns.AutoFit();
                    sheet1.Rows.AutoFit();                   

                    sheet1.Rows.Cells.WrapText = false;
                    excel.Visible = true;

                    load.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

    }
}
