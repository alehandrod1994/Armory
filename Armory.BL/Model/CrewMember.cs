using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Armory.BL.Model
{
	public class CrewMember
	{
		public int ID { get; set; }

        [DisplayName("Èìÿ")]
        public string? Name { get; set; }
		public List<Act> Acts { get; set; } = new();

		public override string ToString() => Name!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is CrewMember crewMember)
		//	{
		//		return Name == crewMember.Name;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Name!.GetHashCode();
		//}
	}
}
