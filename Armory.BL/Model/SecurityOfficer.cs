using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class SecurityOfficer
    {
		public int ID { get; set; }
		public string? Name { get; set; }
		public int PositionID { get; set; }
		public Position? Position { get; set; }		
		public List<Act> Acts { get; set; } = new();

        public override string ToString() => Name!;
    }
}
