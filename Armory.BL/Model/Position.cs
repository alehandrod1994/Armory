using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class Position
    {
		public int ID { get; set; }
		public string? Name { get; set; }
		public List<SecurityOfficer> SecurityOfficers { get; set; } = new();

        public override string ToString() => Name!;
    }
}
