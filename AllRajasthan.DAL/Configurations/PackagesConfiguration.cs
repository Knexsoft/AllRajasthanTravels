using AllRajasthan.DAL.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.Configurations
{
    internal class PackagesConfiguration : IEntityTypeConfiguration<Package>
    {
        public PackagesConfiguration(EntityTypeBuilder<Package> entityTypeBuilder)
        {
            Configure(entityTypeBuilder);
        }

        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasIndex(x => x.PackageName).IsUnique();
            builder.Property(x => x.Overview).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.Exclusions).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.CancellationPolicy).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.Notes).HasColumnType("ntext");
            builder.Property(x => x.Images).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.TotalDays).IsRequired();

            builder.HasMany(x => x.Itineraries).WithOne(x => x.Package);
            builder.HasMany(x => x.PackageTypes).WithOne(x => x.Package);
        }
    }
}
