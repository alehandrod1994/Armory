using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public class Airport
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public override string ToString() => Name!;
    }
}
