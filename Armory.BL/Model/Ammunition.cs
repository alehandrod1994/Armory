using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class Ammunition
    {
		public int ID { get; set; }
		public string? Type { get; set; }
		public List<Act> Acts { get; set; } = new();

        public override string ToString() => Type!;
    }
}
