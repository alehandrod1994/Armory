using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class City
    {
		public int ID { get; set; }
		public string? Name { get; set; }		
		public List<Act> Acts { get; set; } = new();

        public override string ToString() => Name!;
    }
}
