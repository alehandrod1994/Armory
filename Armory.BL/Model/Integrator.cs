using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    // TODO: Выбор нужного листа в Excel после открытия.

    public class Integrator : DocumentBase
    {
        private readonly ArmoryContext? _db;

        public Integrator(ArmoryContext db, string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(path), "Путь файла не может быть пустым.");
            }

            Path = path;
            _db = db;
        }

        private int GetColumnIndex(string columnName)
        {
            for (int j = 1; j < 20; j++)
            {
                if (Contains(1, j, columnName))
                {
                    return j;
                }
            }

            return 0;
        }

        public List<Act>? ImportActData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int numberColumn = GetColumnIndex("НОМЕР");
            int departureAirportColumn = GetColumnIndex("АЭРОПОРТ ОТПРАВЛЕНИЯ");
            int arrivalAirportColumn = GetColumnIndex("АЭРОПОРТ НАЗНАЧЕНИЯ");
            int departureCityColumn = GetColumnIndex("ГОРОД ОТПРАВЛЕНИЯ");
            int arrivalCityColumn = GetColumnIndex("ГОРОД НАЗНАЧЕНИЯ");
            int weaponTypeColumn = GetColumnIndex("ТИП ОРУЖИЯ");
            int weaponColumn = GetColumnIndex("МОДЕЛЬ ОРУЖИЯ");
            int weaponRegistrationNumberColumn = GetColumnIndex("РЕГИСТРАЦ");
            int weaponCharacteristicsColumn = GetColumnIndex("ХАРАКТЕР");
            int weaponBaggageTagNumberColumn = GetColumnIndex("НОМЕРА БАГАЖНЫХ БИРОК ОРУЖИЯ");
            int ammunitionColumn = GetColumnIndex("ПАТРОН");
            int ammunitionCountColumn = GetColumnIndex("КОЛИЧЕСТВО");
            int ammunitionWeightColumn = GetColumnIndex("ВЕС");
            int ammunitionBaggageTagNumberColumn = GetColumnIndex("НОМЕРА БАГАЖНЫХ БИРОК ПАТРОНОВ");
            int securityOfficerColumn = GetColumnIndex("СОТРУДНИК СТАБ");
            int positionColumn = GetColumnIndex("ДОЛЖНОСТЬ");
            int flightColumn = GetColumnIndex("РЕЙС");
            int planeColumn = GetColumnIndex("БОРТ");
            int crewMemberColumn = GetColumnIndex("ЭКИПАЖ");
            int dateColumn = GetColumnIndex("ДАТА");

            if (numberColumn == 0 || departureAirportColumn == 0 || arrivalAirportColumn == 0 ||
            departureCityColumn == 0 || arrivalCityColumn == 0 || weaponRegistrationNumberColumn == 0 ||
            weaponCharacteristicsColumn == 0 || weaponBaggageTagNumberColumn == 0 || ammunitionCountColumn == 0 ||
            ammunitionWeightColumn == 0 || ammunitionBaggageTagNumberColumn == 0 || securityOfficerColumn == 0 ||
            flightColumn == 0 || planeColumn == 0 || crewMemberColumn == 0 || dateColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var acts = new List<Act>();
            for (int i = 2; i < 10000; i++)
            {
                var departureCity = new City() { Name = ToString(i, departureCityColumn) };
                departureCity = DbHelper.EnsureHasItem(_db!.Cities, departureCity);

                var departureAirport = new Airport()
                {
                    Name = ToString(i, departureAirportColumn),
                    City = departureCity
                };
                departureAirport = DbHelper.EnsureHasItem(_db!.Airports, departureAirport);

                var arrivalCity = new City() { Name = ToString(i, arrivalCityColumn) };
                arrivalCity = DbHelper.EnsureHasItem(_db!.Cities, arrivalCity);

                var arrivalAirport = new Airport()
                {
                    Name = ToString(i, arrivalAirportColumn),
                    City = arrivalCity
                };
                arrivalAirport = DbHelper.EnsureHasItem(_db!.Airports, arrivalAirport);

                var position = new Position() { Name = ToString(i, positionColumn) };
                position = DbHelper.EnsureHasItem(_db!.Positions, position);

                var securityOfficer = new SecurityOfficer()
                {
                    Name = ToString(i, securityOfficerColumn),
                    Position = position
                };
                securityOfficer = DbHelper.EnsureHasItem(_db!.SecurityOfficers, securityOfficer);

                var flight = new Flight() { Number = ToString(i, flightColumn) };
                flight = DbHelper.EnsureHasItem(_db!.Flights, flight);

                var plane = new Plane() { Number = ToString(i, planeColumn) };
                plane = DbHelper.EnsureHasItem(_db!.Planes, plane);

                var crewMember = new CrewMember() { Name = ToString(i, crewMemberColumn) };
                crewMember = DbHelper.EnsureHasItem(_db!.CrewMembers, crewMember);

                var weaponType = new WeaponType() { Name = ToString(i, weaponTypeColumn) };
                weaponType = DbHelper.EnsureHasItem(_db!.WeaponTypes, weaponType);

                var weapon = new Weapon()
                {
                    Model = ToString(i, weaponColumn),
                    Type = weaponType
                };
                weapon = DbHelper.EnsureHasItem(_db!.Weapons, weapon);

                var ammunition = new Ammunition() { Type = ToString(i, ammunitionColumn) };
                ammunition = DbHelper.EnsureHasItem(_db!.Ammunitions, ammunition);

                var number = Parser.ParseInt(ToString(i, numberColumn));
                number ??= 0;

                var ammunitionCount = Parser.ParseInt(ToString(i, ammunitionCountColumn));
                ammunitionCount ??= 0;

                var ammunitionWeight = Parser.ParseDouble(ToString(i, ammunitionWeightColumn));
                ammunitionWeight ??= 0;

                var date = Parser.ParseDateTime(ToString(i, dateColumn));
                date ??= default;

                var act = new Act()
                {
                    Number = (int)number,
                    DepartureAirport = departureAirport,
                    ArrivalAirport = arrivalAirport,
                    Weapon = weapon,
                    WeaponRegistrationNumber = ToString(i, weaponRegistrationNumberColumn),
                    WeaponCharacteristics = ToString(i, weaponCharacteristicsColumn),
                    WeaponBaggageTagNumber = ToString(i, weaponBaggageTagNumberColumn),
                    Ammunition = ammunition,
                    AmmunitionCount = (int)ammunitionCount,
                    AmmunitionWeight = (double)ammunitionWeight,
                    AmmunitionBaggageTagNumber = ToString(i, ammunitionBaggageTagNumberColumn),
                    SecurityOfficer = securityOfficer,
                    Flight = flight,
                    Plane = plane,
                    CrewMember = crewMember,
                    Date = (DateTime)date,
                };
                acts.Add(act);


                if (CheckSheetEnd(i, numberColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return acts;
        }

        public List<Airport>? ImportAirportData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int nameColumn = GetColumnIndex("АЭРОПОРТ");
            int cityColumn = GetColumnIndex("ГОРОД");

            if (nameColumn == 0 || cityColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var airports = new List<Airport>();
            for (int i = 2; i < 10000; i++)
            {
                var city = new City() { Name = ToString(i, cityColumn) };
                city = DbHelper.EnsureHasItem(_db!.Cities, city);

                var airport = new Airport()
                {
                    Name = ToString(i, nameColumn),
                    City = city
                };
                airports.Add(airport);

                if (CheckSheetEnd(i, nameColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return airports;
        }

        public List<Ammunition>? ImportAmmunitionData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int typeColumn = GetColumnIndex("ТИП");
            if (typeColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var ammunitions = new List<Ammunition>();
            for (int i = 2; i < 10000; i++)
            {
                var ammunition = new Ammunition() { Type = ToString(i, typeColumn) };
                ammunitions.Add(ammunition);

                if (CheckSheetEnd(i, typeColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return ammunitions;
        }

        public List<City>? ImportCityData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int nameColumn = GetColumnIndex("ГОРОД");
            if (nameColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var cities = new List<City>();
            for (int i = 2; i < 10000; i++)
            {
                var city = new City() { Name = ToString(i, nameColumn) };
                cities.Add(city);

                if (CheckSheetEnd(i, nameColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return cities;
        }

        public List<CrewMember>? ImportCrewMemberData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int nameColumn = GetColumnIndex("ФИО");
            if (nameColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var crewMembers = new List<CrewMember>();
            for (int i = 2; i < 10000; i++)
            {
                var crewMember = new CrewMember() { Name = ToString(i, nameColumn) };
                crewMembers.Add(crewMember);

                if (CheckSheetEnd(i, nameColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return crewMembers;
        }

        public List<Flight>? ImportFlightData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int numberColumn = GetColumnIndex("НОМЕР");
            if (numberColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var flights = new List<Flight>();
            for (int i = 2; i < 10000; i++)
            {
                var flight = new Flight() { Number = ToString(i, numberColumn) };
                flights.Add(flight);

                if (CheckSheetEnd(i, numberColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return flights;
        }

        public List<Plane>? ImportPlaneData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int numberColumn = GetColumnIndex("НОМЕР");
            if (numberColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var planes = new List<Plane>();
            for (int i = 2; i < 10000; i++)
            {
                var plane = new Plane() { Number = ToString(i, numberColumn) };
                planes.Add(plane);

                if (CheckSheetEnd(i, numberColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return planes;
        }

        public List<Position>? ImportPositionData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int nameColumn = GetColumnIndex("ДОЛЖНОСТЬ");
            if (nameColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var positions = new List<Position>();
            for (int i = 2; i < 10000; i++)
            {
                var position = new Position() { Name = ToString(i, nameColumn) };
                positions.Add(position);

                if (CheckSheetEnd(i, nameColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return positions;
        }

        public List<SecurityOfficer>? ImportSecurityOfficerData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int nameColumn = GetColumnIndex("ФИО");
            int positionColumn = GetColumnIndex("ДОЛЖНОСТЬ");

            if (nameColumn == 0 || positionColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var securityOfficers = new List<SecurityOfficer>();
            for (int i = 2; i < 10000; i++)
            {
                var position = new Position() { Name = ToString(i, positionColumn) };
                position = DbHelper.EnsureHasItem(_db!.Positions, position);

                var securityOfficer = new SecurityOfficer()
                {
                    Name = ToString(i, nameColumn),
                    Position = position
                };
                securityOfficers.Add(securityOfficer);

                if (CheckSheetEnd(i, nameColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return securityOfficers;
        }

        public List<Weapon>? ImportWeaponData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int modelColumn = GetColumnIndex("МОДЕЛЬ");
            int typeColumn = GetColumnIndex("ТИП");

            if (modelColumn == 0 || typeColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var weapons = new List<Weapon>();
            for (int i = 2; i < 10000; i++)
            {
                var type = new WeaponType() { Name = ToString(i, typeColumn) };
                type = DbHelper.EnsureHasItem(_db!.WeaponTypes, type);

                var weapon = new Weapon()
                {
                    Model = ToString(i, modelColumn),
                    Type = type
                };
                weapons.Add(weapon);

                if (CheckSheetEnd(i, modelColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return weapons;
        }

        public List<WeaponType>? ImportWeaponTypeData()
        {
            if (!OpenConnection())
            {
                return null;
            }

            int nameColumn = GetColumnIndex("ТИП");
            if (nameColumn == 0)
            {
                Result = DocumentResult.UnknownData;
                return null;
            }

            var types = new List<WeaponType>();
            for (int i = 2; i < 10000; i++)
            {
                var type = new WeaponType() { Name = ToString(i, nameColumn) };
                types.Add(type);

                if (CheckSheetEnd(i, nameColumn)) break;
            }

            CloseConnection();
            Result = DocumentResult.Added;
            return types;
        }        
    }
}

