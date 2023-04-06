using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
    public class Flight
    {
		public int ID { get; set; }
		public string? Number { get; set; }

        public override string ToString() => Number!;
    }
}
