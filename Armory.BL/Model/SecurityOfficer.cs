using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armory.BL.Model
{
	public class SecurityOfficer
	{
		public int ID { get; set; }

        [DisplayName("Имя")]
        public string? Name { get; set; }		
        public int PositionID { get; set; }

        [DisplayName("Должность")]
        public Position? Position { get; set; }		
		public List<Act> Acts { get; set; } = new();

		public override string ToString() => Name!;

		//public override bool Equals(object? obj)
		//{
		//	if (obj is SecurityOfficer officer)
		//	{
		//		return Name == officer.Name && Position!.Name == officer.Position!.Name;
		//	}

		//	return false;
		//}

		//public override int GetHashCode()
		//{
		//	return Name!.GetHashCode();
		//}
	}
}
