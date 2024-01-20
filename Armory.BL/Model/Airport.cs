using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public class Airport
    {
        public int ID { get; set; }

        [DisplayName("Имя")]
        public string? Name { get; set; }
        public List<Act> ActsForDeparture { get; set; } = new();
        public List<Act> ActsForArrival { get; set; } = new();
        public int CityID { get; set; }

        [DisplayName("Город")]
        public City? City { get; set; }

        public override string ToString() => Name!;

        //public override bool Equals(object? obj)
        //{
        //    if (obj is Airport airport)
        //    {
        //        return Name == airport.Name;
        //    }

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return Name!.GetHashCode();
        //}
    }
}
