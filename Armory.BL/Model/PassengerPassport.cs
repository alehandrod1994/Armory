using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
	public class PassengerPassport
	{
		public PassengerPassport(string seria, string number, DateTime whenGiven, string whoGiven)
		{
			if (string.IsNullOrWhiteSpace(seria))
			{
				throw new ArgumentNullException(nameof(seria), "Серия паспорта не может быть пустой.");
			}
			
			if (string.IsNullOrWhiteSpace(number))
			{
				throw new ArgumentNullException(nameof(number), "Номер паспорта не может быть пустым.");
			}
			
			if (whenGiven.Year < 1975)
			{
				throw new ArgumentException(nameof(number), "Дата выдачи паспорта не может быть ранее 1975 года.");
			}
			
			if (string.IsNullOrWhiteSpace(whoGiven))
			{
				throw new ArgumentNullException(nameof(whoGiven), "Отделение выдачи паспорта не может быть пустым.");
			}
			
			Seria = seria;
			Number = number;
			WhenGiven = whenGiven;
			WhoGiven = whoGiven;
		}
		
		public string? Seria { get; set; }
		public string? Number { get; set; }
		public DateTime WhenGiven { get; set; }
		public string? WhoGiven { get; set; }
		
		public override string ToString()
		{
			return Seria + " " + Number;
		}
	}
}
