using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace Armory.BL.Model
{
	public class Flight
	{
		public int ID { get; set; }

        [DisplayName("Номер")]
        public string? Number { get; set; }

		public override string ToString() => Number!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is Flight flight)
		//	{
		//		return Number == flight.Number;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Number!.GetHashCode();
		//}
	}
}
