using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Armory.BL.Model
{
	public class Weapon
	{
		public int ID { get; set; }
		public string? Model { get; set; }
		public int TypeID { get; set; }
		public WeaponType? Type { get; set; }		
		public List<Act> Acts { get; set; } = new();

		public override string ToString() => Model!;


		//public override bool Equals(object? obj)
		//{
		//	if (obj is Weapon weapon)
		//	{
		//		return Model == weapon.Model && Type!.Name == weapon.Type!.Name;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Model!.GetHashCode();
		//}
	}
}
