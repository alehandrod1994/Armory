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

        public Integrator(ArmoryContext db)
        {
            _db = db;

            SheetNumber = 1;
            StartRow = 2;
        }

        public int SheetNumber { get; set; }
        public int StartRow { get; set; }


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

        public ArmoryContext? ImportAll()
        {
            if (!OpenConnection())
            {
                return null;
            }

            // TODO: Сделать порядок добавления как в AddAct.
            // TODO: Импортировать по названию листа или номеру.
            // TODO: Если такой страницы нет.

            SheetNumber = 4;
            List<City>? cities = ImportCitiesData();

            if (cities != null)
            {
                _db!.Cities.AddRange(cities);
            }

            SheetNumber = 2;
            List<Airport>? airports = ImportAirportsData();

            if (airports != null)
            {
                _db!.Airports.AddRange(airports);
            }

            SheetNumber = 8;
            List<Position>? positions = ImportPositionsData();

            if (positions != null)
            {
                _db!.Positions.AddRange(positions);
            }

            SheetNumber = 9;
            List<SecurityOfficer>? securityOfficers = ImportSecurityOfficersData();

            if (securityOfficers != null)
            {
                _db!.SecurityOfficers.AddRange(securityOfficers);
            }

            SheetNumber = 6;
            List<Flight>? flights = ImportFlightsData();

            if (flights != null)
            {
                _db!.Flights.AddRange(flights);
            }

            SheetNumber = 7;
            List<Plane>? planes = ImportPlanesData();

            if (planes != null)
            {
                _db!.Planes.AddRange(planes);
            }

            SheetNumber = 5;
            List<CrewMember>? crewMembers = ImportCrewMembersData();

            if (crewMembers != null)
            {
                _db!.CrewMembers.AddRange(crewMembers);
            }

            SheetNumber = 11;
            List<WeaponType>? weaponTypes = ImportWeaponTypesData();

            if (weaponTypes != null)
            {
                _db!.WeaponTypes.AddRange(weaponTypes);
            }

            SheetNumber = 10;
            List<Weapon>? weapons = ImportWeaponsData();

            if (weapons != null)
            {
                _db!.Weapons.AddRange(weapons);
            }

            SheetNumber = 3;
            List<Ammunition>? ammunitions = ImportAmmunitionsData();

            if (ammunitions != null)
            {
                _db!.Ammunitions.AddRange(ammunitions);
            }

            SheetNumber = 1;
            List<Act>? acts = ImportActsData();

            if (acts != null)
            {
                _db!.Acts.AddRange(acts);
            }

            if (acts == null && airports == null && ammunitions == null && cities == null
            && crewMembers == null && flights == null && planes == null && positions == null
            && securityOfficers == null && weapons == null && weaponTypes == null)
            {
                CloseConnection();
                Result = MessageResult.NotSaved;
                return _db;
            }        

            CloseConnection();
            Result = MessageResult.Imported;
            return _db;
        }

        private List<Act>? ImportActsData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
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
                Result = MessageResult.UnknownData;
                return null;
            }

            var acts = new List<Act>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, numberColumn)) break;

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
            }

            return acts;
        }

        public List<Act>? ImportActs()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Act>? acts = ImportActsData();
            if (acts != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return acts;
        }

        private List<Airport>? ImportAirportsData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int nameColumn = GetColumnIndex("АЭРОПОРТ");
            int cityColumn = GetColumnIndex("ГОРОД");

            if (nameColumn == 0 || cityColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var airports = new List<Airport>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, nameColumn)) break;

                var city = new City() { Name = ToString(i, cityColumn) };
                city = DbHelper.EnsureHasItem(_db!.Cities, city);

                var airport = new Airport()
                {
                    Name = ToString(i, nameColumn),
                    City = city
                };
                airports.Add(airport);               
            }

            return airports;
        }

        public List<Airport>? ImportAirports()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Airport>? airports = ImportAirportsData();
            if (airports != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return airports;
        }

        private List<Ammunition>? ImportAmmunitionsData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int typeColumn = GetColumnIndex("ТИП");
            if (typeColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var ammunitions = new List<Ammunition>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, typeColumn)) break;

                var ammunition = new Ammunition() { Type = ToString(i, typeColumn) };
                ammunitions.Add(ammunition);                
            }

            return ammunitions;
        }

        public List<Ammunition>? ImportAmmunitions()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Ammunition>? ammunitions = ImportAmmunitionsData();
            if (ammunitions != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return ammunitions;
        }

        private List<City>? ImportCitiesData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }           

            int nameColumn = GetColumnIndex("ГОРОД");
            if (nameColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var cities = new List<City>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, nameColumn)) break;

                var city = new City() { Name = ToString(i, nameColumn) };
                cities.Add(city);               
            }

            return cities;
        }

        public List<City>? ImportCities()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<City>? cities = ImportCitiesData();
            if (cities != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return cities;
        }

        private List<CrewMember>? ImportCrewMembersData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int nameColumn = GetColumnIndex("ФИО");
            if (nameColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var crewMembers = new List<CrewMember>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, nameColumn)) break;

                var crewMember = new CrewMember() { Name = ToString(i, nameColumn) };
                crewMembers.Add(crewMember);               
            }

            return crewMembers;
        }

        public List<CrewMember>? ImportCrewMembers()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<CrewMember>? crewMembers = ImportCrewMembersData();
            if (crewMembers != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return crewMembers;
        }

        private List<Flight>? ImportFlightsData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int numberColumn = GetColumnIndex("НОМЕР");
            if (numberColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var flights = new List<Flight>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, numberColumn)) break;

                var flight = new Flight() { Number = ToString(i, numberColumn) };
                flights.Add(flight);                
            }

            return flights;
        }

        public List<Flight>? ImportFlights()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Flight>? flights = ImportFlightsData();
            if (flights != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return flights;
        }

        private List<Plane>? ImportPlanesData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int numberColumn = GetColumnIndex("НОМЕР");
            if (numberColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var planes = new List<Plane>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, numberColumn)) break;

                var plane = new Plane() { Number = ToString(i, numberColumn) };
                planes.Add(plane);               
            }

            return planes;
        }

        public List<Plane>? ImportPlanes()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Plane>? planes = ImportPlanesData();
            if (planes != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return planes;
        }

        private List<Position>? ImportPositionsData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int nameColumn = GetColumnIndex("ДОЛЖНОСТЬ");
            if (nameColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var positions = new List<Position>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, nameColumn)) break;

                var position = new Position() { Name = ToString(i, nameColumn) };
                positions.Add(position);             
            }

            return positions;
        }

        public List<Position>? ImportPositions()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Position>? positions = ImportPositionsData();
            if (positions != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return positions;
        }

        private List<SecurityOfficer>? ImportSecurityOfficersData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int nameColumn = GetColumnIndex("ФИО");
            int positionColumn = GetColumnIndex("ДОЛЖНОСТЬ");

            if (nameColumn == 0 || positionColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var securityOfficers = new List<SecurityOfficer>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, nameColumn)) break;

                var position = new Position() { Name = ToString(i, positionColumn) };
                position = DbHelper.EnsureHasItem(_db!.Positions, position);

                var securityOfficer = new SecurityOfficer()
                {
                    Name = ToString(i, nameColumn),
                    Position = position
                };
                securityOfficers.Add(securityOfficer);                
            }

            return securityOfficers;
        }

        public List<SecurityOfficer>? ImportSecurityOfficers()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<SecurityOfficer>? securityOfficers = ImportSecurityOfficersData();
            if (securityOfficers != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return securityOfficers;
        }

        private List<Weapon>? ImportWeaponsData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int modelColumn = GetColumnIndex("МОДЕЛЬ");
            int typeColumn = GetColumnIndex("ТИП");

            if (modelColumn == 0 || typeColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var weapons = new List<Weapon>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, modelColumn)) break;

                var type = new WeaponType() { Name = ToString(i, typeColumn) };
                type = DbHelper.EnsureHasItem(_db!.WeaponTypes, type);

                var weapon = new Weapon()
                {
                    Model = ToString(i, modelColumn),
                    Type = type
                };
                weapons.Add(weapon);               
            }

            return weapons;
        }

        public List<Weapon>? ImportWeapons()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<Weapon>? weapons = ImportWeaponsData();
            if (weapons != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return weapons;
        }

        private List<WeaponType>? ImportWeaponTypesData()
        {
            if (book!.Sheets.Count >= SheetNumber)
            {
                sheet = book!.Sheets[SheetNumber];
            }
            else
            {
                Result = MessageResult.NoSheet;
                return null;
            }

            int nameColumn = GetColumnIndex("ТИП");
            if (nameColumn == 0)
            {
                Result = MessageResult.UnknownData;
                return null;
            }

            var types = new List<WeaponType>();
            for (int i = StartRow; i < 10000; i++)
            {
                if (CheckSheetEnd(i, nameColumn)) break;

                var type = new WeaponType() { Name = ToString(i, nameColumn) };
                types.Add(type);                
            }

            return types;
        }

        public List<WeaponType>? ImportWeaponTypes()
        {
            if (!OpenConnection())
            {
                return null;
            }

            List<WeaponType>? types = ImportWeaponTypesData();
            if (types != null)
            {
                Result = MessageResult.Imported;
            }

            CloseConnection();
            return types;
        }               
    }
}

