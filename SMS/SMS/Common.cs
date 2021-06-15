using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace SMS
{
    public static class Common
    {
        public static string LOGINTYPE;
        public static int LOGINFK;
        public static string LOGINNAME;

        public static void RoundBorderForm(Form frm,int CornerRadius)
        {

            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
            frm.Show();
        }

        public static void SetHint(this TextBox textBox, string prompt)
        {
            textBox.Text = prompt;
            bool wma = true;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += (source, ex) =>
            {
                if (((TextBox)source).ForeColor == Color.Black)
                    return;
                if (wma || textBox.Text == prompt)
                {
                    wma = false;
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (source, ex) =>
            {
                TextBox t = ((TextBox)source);
                if (t.Text.Length == 0)
                {
                    t.Text = prompt;
                    t.ForeColor = Color.Gray;
                    return;
                }
                if (!wma && string.IsNullOrEmpty(textBox.Text))
                {
                    wma = true;
                    textBox.Text = prompt;
                    textBox.ForeColor = Color.Gray;
                }
            };
            textBox.TextChanged += (source, ex) =>
            {
                if (((TextBox)source).Text.Length > 0)
                {
                    textBox.ForeColor = Color.Black;
                }
            };
        }

        public enum DepartmentType
        {
            ADMIN, TEACHER, HR , ACCOUNTS , STUDENT
        }

        public static void Green(this Label label)
        {
          label.BackColor = Color.Green;
        }

        public static void Red(this Label label)
        {
            label.BackColor = Color.Red;
        }

        public static void Transparent(this Label label)
        {
            label.BackColor = Color.Transparent;
        }

        public static DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            foreach (DataRow dRow in duplicateList)
            {
                dTable.Rows.Remove(dRow);
            }

            return dTable;
        }

        public static bool IsNumberAndNotNull(this string txt)
        {
            return txt.All(char.IsDigit) && txt != "";
        }

        public static void ExportToExcel(this DataTable tbl, string excelFilePath = null)
        {
            string[] abc = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();

                if (excelApp == null)
                {
                    new Alert("Excel is not properly installed!!",Alert.AlertType.ERROR,8);
                    return;
                }

                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }


                Excel.Range formatRange;
                formatRange = workSheet.get_Range("a1",abc[tbl.Columns.Count-1]+"1");
                formatRange.Font.Bold = true;
                formatRange.ColumnWidth = 16;
                formatRange.Font.Color = Color.Red;
                formatRange.Font.Size = 14;
                formatRange.WrapText = true;
                formatRange.EntireColumn.AutoFit();
                formatRange.EntireRow.AutoFit();
                formatRange.Interior.Color = ColorTranslator.ToOle(Color.LightBlue);

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        new Alert("Excel file saved!",Alert.AlertType.SUCCESS);

                        Marshal.ReleaseComObject(workSheet);
                        Marshal.ReleaseComObject(excelApp);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception)
            {
                new Alert("Export Error",Alert.AlertType.ERROR);
            }
        }
    }
}
