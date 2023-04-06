using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class Report
    {
		// public Passenger(string name, string lastname, string middlename, PassengerPassport passport)
		// {
			// if (string.IsNullOrWhiteSpace(name))
			// {
				// throw new ArgumentNullException("Имя пассажира не может быть пустым.", nameof(name));
			// }
			
			// if (string.IsNullOrWhiteSpace(lastname))
			// {
				// throw new ArgumentNullException("Фамилия пассажира не может быть пустой.", nameof(lastname));
			// }
			
			// if (string.IsNullOrWhiteSpace(middlename))
			// {
				// throw new ArgumentNullException("Отчество пассажира не может быть пустым.", nameof(middlename));
			// }
			
			// if (passport is null)
			// {
				// throw new ArgumentNullException("Пасспорт пассажира не может быть пустым.", nameof(middlename));
			// }
			
			// Name = name;
			// Lastname = lastname;
			// Middlename = middlename;
			// Passport = passport;
		// }
		
		//public ReportResult Result { get; private set; }
		
		//private bool OpenConnection()
		//{
		//	// TODO: Подключение к файлу. 
		//}
		
		//private bool CloseConnection()
		//{
		//	// TODO: Закрытие подключения к файлу.
		//}
		
		//public bool ReportAct(Act act, Passenger passenger)
		//{
		//	if (!OpenConnection())
		//	{
		//		Result = ReportResult.FailedConnection;
		//		return false;
		//	}
			
		//	SetData(act, passenger);
		//	FormatData();	
			
		//	if (!Save(act))
		//	{
		//		Result = ReportResult.NotSaved;
		//		return false;
		//	}
							
		//	CloseConnection();
		//	Result = ReportResult.Successfully;
		//	return true;
		//}
		
		//private void SetData(Act act, Passenger passenger)
		//{			
		//	_sheet.cell[3,2] += act.Number;
			
		//	var date = new Date();
		//	var month = date.GetTodayMonth(); // date.Months[DateTime.Today.Month - 1];
		//	_sheet.cell[6,2] += $"\"{act.Date.Day}\" {month.OfName.ToLower()} {act.Date.Year} г.";
			
		//	_sheet.cell[7,2] = act.Airport.Name;
						
		//	_sheet.cell[10,2] = $"{act.SecurityOfficer.Position.Name}, {act.SecurityOfficer.Name}";
			
		//	_sheet.cell[12,2] += $"{passenger.Name} {passenger.LastName} {passenger.MiddleName}";
		//	_sheet.cell[13,2] = $"{passenger.Passport.Seria}, {passenger.Passport.Number}, {passenger.Passport.WhenGiven}, {passenger.Passport.WhoGiven}";
			
		//	_sheet.cell[15,2] += $"{act.Flight.Number}";
		//	_sheet.cell[16,2] += $"{act.City.Name}";
		//	_sheet.cell[17,2] += $"{act.Plane.Number}";
			
		//	_sheet.cell[18,2] += $"{act.Weapon.Type}, {act.Weapon.Model}, {act.WeaponRegistrationNumber}";
		//	_sheet.cell[20,2] = $"{act.WeaponCharacteristics}, {act.WeaponBaggageTagNumber}";			
		//	_sheet.cell[21,2] += $"{act.AmmunitionCount}, {act.AmmunitionWeight}, {act.Ammunition.Type}, {act.AmmunitionBaggageTagNumber}";
			
		//	_sheet.cell[25,2] = $"{passenger.LastName} {passenger.Name.Substring(1)}.{passenger.MiddleName.Substring(1)}";
			
		//	_sheet.cell[28,2] = $"{act.CrewMember.Name}";
		//}		 
		
		//private void FormatData()
		//{
		//	// Длина строки - 88 символов при размере шрифта 10пт.
		//	int maxLength = 88;
			
		//	ApplyUnderlineCenter(7, 2, maxLength);
			
		//	var rows = new int[] { 10, 12, 13, 15, 16, 17, 18, 20, 21, 25, 28};			
		//	foreach (row in rows)
		//	{
		//		ApplyUnderlineLeft(row, 2, maxLength);
		//	}
						
		//}
		////(33, 55)
		// _______________________________________________________
		
		
		//private void ApplyUnderline(int x, int y)
		//{
		//	// TODO: Применить нижнее подчёркивание к тексту.
		//}
		
		//private void ApplyUnderlineLeft(int x, int y, int cellLength)
		//{
		//	int whiteSpaceCount = cellLength - ToString(x, y).Length;
			
		//	AddWhiteSpace(x, y, count);	
			
		//	ApplyUnderline(x, y);	
		//}
		
		//private void ApplyUnderlineCenter(int x, int y, int cellLength)
		//{
		//	int whiteSpaceCount = (cellLength - ToString(x, y).Length) / 2;
		//	var value = ToString(_sheet.cell[x,y]);
			
		//	_sheet.cell[x,y] = "";			
		//	AddWhiteSpace(x, y, count);		
		//	_sheet.cell[x,y] += value;			
		//	AddWhiteSpace(x, y, count);		
			
		//	ApplyUnderline(x, y);	
		//}
		
		//private void AddWhiteSpace(int x, int y, int count)
		//{
		//	for (int i = 0; i < count; i++)
		//	{
		//		_sheet.cell[x,y] += " ";
		//	}
		//}
		
		//private bool Save(Act act)
		//{
		//	string directory = $"reports\\{DateTime.Today.Year}";
		//	if (!Directory.Exist(directory))
		//	{
		//		Directory.Create(directory);
		//	}
						
		//	try
		//	{
		//		_doc.Save($"{directory}\\{act}");
		//		return true;
		//	}
		//	catch
		//	{
		//		return false;
		//	}			
		//}
    }
}
