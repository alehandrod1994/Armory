using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Armory.BL.Model
{
	public class ArmoryContext : DbContext
	{
		public ArmoryContext()
		{
			//Database.EnsureCreated();
		}

		public DbSet<Act> Acts { get; set; } = null!;
		public DbSet<Airport> Airports { get; set; } = null!;
		public DbSet<Ammunition> Ammunitions { get; set; } = null!;
		public DbSet<City> Cities { get; set; } = null!;
		public DbSet<CrewMember> CrewMembers { get; set; } = null!;
		public DbSet<Flight> Flights { get; set; } = null!;       	
		public DbSet<Plane> Planes { get; set; } = null!;
		public DbSet<Position> Positions { get; set; } = null!;
		public DbSet<SecurityOfficer> SecurityOfficers { get; set; } = null!;
		public DbSet<Weapon> Weapons { get; set; } = null!;
		public DbSet<WeaponType> WeaponTypes { get; set; } = null!;
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=armory.db");
		}
 
	}
}
