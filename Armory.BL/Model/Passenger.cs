using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
	public class Passenger
	{
		public Passenger(string name, string surname, string patronymic, PassengerPassport passport)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException(nameof(name), "Имя пассажира не может быть пустым.");
			}
			
			if (string.IsNullOrWhiteSpace(surname))
			{
				throw new ArgumentNullException(nameof(surname), "Фамилия пассажира не может быть пустой.");
			}
			
			if (string.IsNullOrWhiteSpace(patronymic))
			{
				throw new ArgumentNullException(nameof(patronymic), "Отчество пассажира не может быть пустым.");
			}
			
			if (passport is null)
			{
				throw new ArgumentNullException(nameof(passport), "Паспорт пассажира не может быть пустым.");
			}
			
			Name = name;
			Surname = surname;
			Patronymic = patronymic;
			Passport = passport;
		}
		
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Patronymic { get; set; }
		public PassengerPassport? Passport { get; set; }
				
		public override string ToString()
		{
			return Surname + Name + Patronymic;
		}
	}
}
