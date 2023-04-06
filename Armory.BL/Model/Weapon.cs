using System;
using System.Collections.Generic;

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
    }
}
