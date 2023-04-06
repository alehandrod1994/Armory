using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class WeaponType
    {
		public int ID { get; set; }
		public string? Name { get; set; }
		public List<Weapon> Weapons{ get; set; } = new();

        public override string ToString() => Name!;
    }
}
