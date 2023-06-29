using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;

namespace Armory.BL.Model
{
    public class Report : DocumentBase
    {
        //Длина строки -88 символов при размере шрифта 10пт.
        //Ширина столбца 89px.
        private readonly int _maxColumnLength = 88;
        private int _rowIncrement = 0;

        public Report()
        {
            Path = $"{Directory.GetCurrentDirectory()}\\samples\\Акт досмотр.xlsx";
        }


        /// <summary>
        /// Путь нового файла для сохранения.
        /// </summary>
        public string? NewFilePath { get; private set; }
       
	
        public DocumentResult ReportAct(Act act, Passenger passenger)
		{
			if (!OpenConnection())
			{
				return Result;
			}

			SetData(act, passenger);
			//FormatData();

			if (!Save(act))
			{				
				return Result;
			}

			CloseConnection();
			Result = DocumentResult.Saved;
			return Result;
		}

		private void SetData(Act act, Passenger passenger)
		{
            var data = new List<string>();
            var date = new Date();
            var month = date.GetTodayMonth();

            sheet!.Cells[3, 2] = $"{ToString(3, 2)}{act.Number}";                       
            sheet!.Cells[6, 2] = $"{ToString(6, 2)}\"{act.Date.Day}\" {month.OfName.ToLower()} {act.Date.Year} г.";

            sheet!.Cells[7, 2] = act.DepartureAirport!.Name;
           
            data.Add(act.SecurityOfficer!.Position!.Name! + ", ");
            data.Add(act.SecurityOfficer.Name!);
            InsertData(10 + _rowIncrement, 2, data);

            data.Clear();
            data.Add(passenger.Surname + ", ");
            data.Add(passenger.Name + ", ");
            data.Add(passenger!.Patronymic!);
            InsertData(12 + _rowIncrement, 2, data);

            data.Clear();
            data.Add(passenger.Passport!.Seria + ", ");
            data.Add(passenger.Passport.Number + ", ");
            data.Add(passenger.Passport.WhenGiven.ToShortDateString() + ", ");
            data.Add(passenger.Passport!.WhoGiven!);
            InsertData(13 + _rowIncrement, 2, data);          

            sheet!.Cells[15, 2] = $"{ToString(15, 2)}{act.Flight!.Number}";
            sheet!.Cells[16, 2] = $"{ToString(16, 2)}{act.ArrivalAirport!.City!.Name}";
            sheet!.Cells[17, 2] = $"{ToString(17, 2)}{act.Plane!.Number}";

            data.Clear();
            data.Add(act.Weapon!.Type + ", ");
            data.Add(act.Weapon.Model + ", ");
            data.Add(act.WeaponRegistrationNumber!);
            InsertData(18 + _rowIncrement, 2, data);

            data.Clear();
            data.Add(act.WeaponCharacteristics + ", ");
            data.Add(act.WeaponBaggageTagNumber!);
            InsertData(20 + _rowIncrement, 2, data);

            data.Clear();
            data.Add(act.AmmunitionCount + ", ");
            data.Add(act.AmmunitionWeight + ", ");
            data.Add(act.Ammunition!.Type + ", ");
            data.Add(act.AmmunitionBaggageTagNumber!);
            InsertData(21 + _rowIncrement, 2, data);
           
            sheet!.Cells[25, 2] = $"{passenger.Surname} {passenger.Name![..1]}.{passenger.Patronymic![..1]}.";

            sheet!.Cells[28, 2] = $"{act.CrewMember!.Name}";
		}

		private void FormatData()
		{       
            ApplyUnderlineCenter(7, 2);

            var rows = new int[] { 10, 12, 13, 15, 16, 17, 18, 20, 21, 25, 28 };
            foreach (int row in rows)
            {
                ApplyUnderlineLeft(row, 2);
            }

        }
        //(33, 55)
        //_______________________________________________________


        private bool CheckColumnLength(int length)
        {
            return (_maxColumnLength - length) > 0;
        }

        private void ApplyUnderline(int x, int y)
        {
            Excel.Range range;

            range = sheet!.Cells[x, y];
            range.get_Characters().Font.Underline = true;
        }

        private void ApplyUnderlineLeft(int x, int y)
        {
            int whiteSpaceCount = _maxColumnLength - ToString(x, y).Length;

            AddWhiteSpace(x, y, whiteSpaceCount);

            ApplyUnderline(x, y);
        }

        private void ApplyUnderlineCenter(int x, int y)
        {
            int whiteSpaceCount = (_maxColumnLength - ToString(x, y).Length) / 2;
            var value = ToString(x, y);

            sheet!.Cells[x, y] = "";
            AddWhiteSpace(x, y, whiteSpaceCount);
            sheet.Cells[x, y] = ToString(x, y) + value;
            AddWhiteSpace(x, y, whiteSpaceCount);

            ApplyUnderline(x, y);
        }

        private void AddWhiteSpace(int x, int y, int count)
		{
			for (int i = 0; i < count; i++)
			{
				sheet!.Cells[x, y] = ToString(x, y) + " ";
			}
		}

        private void InsertData(int i, int j, List<string> values)
        {
            int columnLength = sheet!.Cells[i, j].Text.Length;
            int currentRow = i;
            var rows = new List<int>();

            foreach (var value in values)
            {
                columnLength = value.Length + columnLength;

                if (!CheckColumnLength(columnLength))
                {
                    InsertNewRow(currentRow, j);
                    columnLength = value.Length;
                    currentRow++;                  
                    _rowIncrement++;
                }
                               
                rows.Add(currentRow);
            }

            for (int index = 0; index < values.Count; index++)
            {
                sheet!.Cells[rows[index], j] = ToString(rows[index], j) + values[index];
            }
        }

        private void InsertNewRow(int x, int y)
        {
            Excel.Range range = sheet!.Cells[x, y];

            range = range.EntireRow;
            range.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
        }

        private void SetRowHeight(int startX, string startY, int lastX, string lastY, int height)
        {
            Excel.Range range;

            range = sheet!.Range[startY + startX + ":" + lastY + lastX];
            range.RowHeight = height;
        }
     
        private bool Save(Act act)
		{
			string directory = $"{Directory.GetCurrentDirectory()}\\reports\\{DateTime.Today.Year}";
            string newFilePath = $"{directory}\\{act}.xlsx";

            if (!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

            try
            {
                book!.SaveAs(newFilePath);
                NewFilePath = newFilePath;
            }
            catch
            {
                Result = DocumentResult.NotSaved;
                CloseConnection();
                return false;
            }

            return true;
        }
	}
}
