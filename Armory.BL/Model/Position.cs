using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Armory.BL.Model
{
	public class Position
	{
		public int ID { get; set; }

        [DisplayName("Имя")]
        public string? Name { get; set; }
		public List<SecurityOfficer> SecurityOfficers { get; set; } = new();

		public override string ToString() => Name!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is Position position)
		//	{
		//		return Name == position.Name;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Name!.GetHashCode();
		//}
	}
}
