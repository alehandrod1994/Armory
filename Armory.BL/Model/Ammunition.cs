using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace Armory.BL.Model
{
	public class Ammunition
	{
		public int ID { get; set; }

        [DisplayName("Тип")]
        public string? Type { get; set; }
		public List<Act> Acts { get; set; } = new();

		public override string ToString() => Type!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is Ammunition ammunition)
		//	{
		//		return Type == ammunition.Type;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Type!.GetHashCode();
		//}
	}
}
