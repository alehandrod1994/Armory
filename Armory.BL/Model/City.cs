using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
	public class City
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public List<Airport> Airports { get; set; } = new();

		public override string ToString() => Name!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is City city)
		//	{
		//		return Name == city.Name;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Name!.GetHashCode();
		//}
	}
}
