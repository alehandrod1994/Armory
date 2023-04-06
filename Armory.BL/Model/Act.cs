using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public class Act
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int AirportID { get; set; }
        public Airport? Airport { get; set; }
        public int WeaponID { get; set; }
        public Weapon? Weapon { get; set; }
        public string? WeaponRegistrationNumber { get; set; }
        public string? WeaponCharacteristics { get; set; }
        public string? WeaponBaggageTagNumber { get; set; }
        public int AmmunitionID { get; set; }
        public Ammunition? Ammunition { get; set; }
        public int AmmunitionCount { get; set; }
        public double AmmunitionWeight { get; set; }
        public string? AmmunitionBaggageTagNumber { get; set; }
        public int SecurityOfficerID { get; set; }
        public SecurityOfficer? SecurityOfficer { get; set; }
        public int CityID { get; set; }
        public City? City { get; set; }
        public int FlightID { get; set; }
        public Flight? Flight { get; set; }
        public int PlaneID { get; set; }
        public Plane? Plane { get; set; }
        public int CrewMemberID { get; set; }
        public CrewMember? CrewMember { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Акт №{Number} от {Date:dd.MM.yy}";
        }
    }
}
