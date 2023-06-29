using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Armory.BL.Model;

namespace Armory.BL.Configurations
{
    public class ActConfiguration : IEntityTypeConfiguration<Act>
    {
        public void Configure(EntityTypeBuilder<Act> builder)
        {
            builder.HasKey(a => a.ID);

            builder.HasOne(act => act.DepartureAirport).WithMany(airport => airport.ActsForDeparture)
                .HasForeignKey(act => act.DepartureAirportID).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(act => act.ArrivalAirport).WithMany(airport => airport.ActsForArrival)
                .HasForeignKey(act => act.ArrivalAirportID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
