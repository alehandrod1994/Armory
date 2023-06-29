using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Armory.BL.Model
{
	public class Plane
	{
		public int ID { get; set; }
		public string? Number { get; set; }

		public override string ToString() => Number!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is Plane plane)
		//	{
		//		return Number == plane.Number;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Number!.GetHashCode();
		//}
	}
}
