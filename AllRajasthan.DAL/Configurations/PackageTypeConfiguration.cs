using AllRajasthan.DAL.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.Configurations
{
    internal class PackageTypeConfiguration : IEntityTypeConfiguration<PackageType>
    {
        public PackageTypeConfiguration(EntityTypeBuilder<PackageType> entityTypeBuilder)
        {
            Configure(entityTypeBuilder);
        }
        public void Configure(EntityTypeBuilder<PackageType> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.PackageID).IsRequired();
            builder.Property(x => x.PackageTypeName).IsRequired();
            builder.Property(x => x.Inclusions).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.Amount).IsRequired();

            builder.HasOne(x => x.Package).WithMany(x => x.PackageTypes).HasForeignKey(x => x.PackageID);
        }
    }
}
