using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public class Act
    {
        public int ID { get; set; }

        [DisplayName("Номер")]
        public int Number { get; set; }
        public int DepartureAirportID { get; set; }

        [DisplayName("Аэропорт отправления")]
        public Airport? DepartureAirport { get; set; }
        public int ArrivalAirportID { get; set; }

        [DisplayName("Аэропорт назначения")]
        public Airport? ArrivalAirport { get; set; }       
        public int WeaponID { get; set; }

        [DisplayName("Оружие")]
        public Weapon? Weapon { get; set; }

        [DisplayName("Регистр. номер оружия")]
        public string? WeaponRegistrationNumber { get; set; }

        [DisplayName("Характер. признаки оружия")]
        public string? WeaponCharacteristics { get; set; }

        [DisplayName("Номера багаж. бирок оружия")]
        public string? WeaponBaggageTagNumber { get; set; }
        public int AmmunitionID { get; set; }

        [DisplayName("Патроны")]
        public Ammunition? Ammunition { get; set; }

        [DisplayName("Количество патронов")]
        public int AmmunitionCount { get; set; }

        [DisplayName("Вес патронов")]
        public double AmmunitionWeight { get; set; }

        [DisplayName("Номера багаж. бирок патронов")]
        public string? AmmunitionBaggageTagNumber { get; set; }
        public int SecurityOfficerID { get; set; }

        [DisplayName("Сотрудник СТАБ")]
        public SecurityOfficer? SecurityOfficer { get; set; }
        public int FlightID { get; set; }

        [DisplayName("Рейс")]
        public Flight? Flight { get; set; }
        public int PlaneID { get; set; }

        [DisplayName("Самолёт")]
        public Plane? Plane { get; set; }
        public int CrewMemberID { get; set; }

        [DisplayName("Экипаж")]
        public CrewMember? CrewMember { get; set; }

        [DisplayName("Дата")]
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Акт №{Number} от {Date:dd.MM.yy}";
        }

        //public override bool Equals(object? obj)
        //{
        //    if (obj is Act act)
        //    {
        //        return Number == act.Number && Date == act.Date;
        //    }

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return Number.GetHashCode();
        //}
    }
}
