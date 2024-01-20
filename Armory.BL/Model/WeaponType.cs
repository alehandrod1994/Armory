using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Armory.BL.Model
{
	public class WeaponType
	{
		public int ID { get; set; }

        [DisplayName("Имя")]
        public string? Name { get; set; }
		public List<Weapon> Weapons{ get; set; } = new();

		public override string ToString() => Name!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is WeaponType weaponType)
		//	{
		//		return Name == weaponType.Name;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Name!.GetHashCode();
		//}
	}
}
