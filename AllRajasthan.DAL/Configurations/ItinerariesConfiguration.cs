using AllRajasthan.DAL.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.Configurations
{
    internal class ItinerariesConfiguration : IEntityTypeConfiguration<Itinerary>
    {
        public ItinerariesConfiguration(EntityTypeBuilder<Itinerary> entityTypeBuilder)
        {
            Configure(entityTypeBuilder);
        }

        public void Configure(EntityTypeBuilder<Itinerary> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.PackageID).IsRequired();
            builder.Property(x => x.Day).IsRequired();
            builder.Property(x => x.Description).HasColumnType("ntext").IsRequired();

            builder.HasOne(x => x.Package).WithMany(x => x.Itineraries).HasForeignKey(x => x.PackageID);
        }
    }
}
