using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Armory.BL.Model
{
    public abstract class DocumentBase
    {
        protected Application? app;
        protected Workbook? book;
        protected Worksheet? sheet;

        /// <summary>
		/// Путь файла.
		/// </summary>
        public string? Path { get; set; }

        public MessageResult Result { get; protected set; }

        /// <summary>
		/// Открывает подключение к документу.
		/// </summary>
		/// <returns> True, если подключение прошло успешно; в противном случае - false. </returns>
        protected bool OpenConnection()
        {
            app = new Application();
            book = null;

            try
            {
                book = app.Workbooks.Open(Path);
            }
            catch
            {
                Result = MessageResult.FailedConnection;
                return false;
            }

            app.DisplayAlerts = false;
            sheet = book.Sheets[1];
            return true;
        }

        /// <summary>
		/// Закрывает подключение к документу.
		/// </summary>
		/// <returns> True, если закрытие подключения прошло успешно; в противном случае - false. </returns>
        protected bool CloseConnection()
        {
            try
            {
                book!.Close();
                app!.Quit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected bool CreateConnection()
        {
            app = new Application();
            book = null;

            try
            {
                book = app.Workbooks.Add();
            }
            catch
            {
                Result = MessageResult.FailedConnection;
                return false;
            }

            app.DisplayAlerts = false;

            sheet = book.Sheets[1];
            sheet.Name = "Лист 1";
            return true;
        }

        public string DragDrop(string path)
        {
            var fi = new FileInfo(path);

            if (fi.Extension.Contains(".xls"))
            {
                Path = path;
            }

            return Path!;
        }

        protected void FillBackground(int startX, string startY, int lastX, string lastY, int R, int G, int B)
        {
            Excel.Range range;

            range = sheet!.Range[startY + startX + ":" + lastY + lastX];
            range.Interior.Color = Color.FromArgb(R, G, B);
        }

        protected void AutoFitColumn(int startX, string startY, int lastX, string lastY)
        {
            Excel.Range range;

            range = sheet!.Range[startY + startX + ":" + lastY + lastX];
            range.EntireColumn.AutoFit();
        }

        protected void DrawBorder(int startX, string startY, int lastX, string lastY)
        {
            Excel.Range range;

            range = sheet!.Range[startY + startX + ":" + lastY + lastX];
            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        protected bool CheckSheetEnd(int i, int j)
        {
            return Equals(i, j, "") && Equals(i + 1, j, "") && Equals(i + 2, j, "");
        }

        /// <summary>
		/// Проверяет, равны ли значение в ячейке Excel и введённое значение.
		/// </summary>
		/// <param name="i"> Номер строки. </param>
		/// <param name="j"> Номер столбца. </param>
		/// <param name="value"> Текст. </param>
		/// <returns> Возвращает true, если равны; в противном случае - false. </returns>
		protected bool Equals(int i, int j, string value)
        {
            return ToString(i, j).Equals(value, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Проверяет, содержит ли ячейка Excel введённую подстроку. 
        /// </summary>
        /// <param name="i"> Номер строки. </param>
        /// <param name="j"> Номер столбца. </param>
        /// <param name="value"> Текст. </param>
        /// <returns> Возвращает true, если содержит; в противном случае - false. </returns>
        protected bool Contains(int i, int j, string value)
        {
            return ToString(i, j).ToUpper().Contains(value.ToUpper());
        }

        /// <summary>
		/// Приводит значение из ячейки Excel к строке.
		/// </summary>
		/// <param name="i"> Номер строки. </param>
		/// <param name="j"> Номер столбца. </param>
		/// <returns> Результат приведения. </returns>
        protected string ToString(int i, int j)
        {
            // TODO: Проверить, если упростить.
            Excel.Range range = sheet!.Cells[i, j];
            return range.Value?.ToString() ?? "";
        }
    }
}
