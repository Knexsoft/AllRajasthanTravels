using AllRajasthan.DAL.Configurations;
using AllRajasthan.DAL.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL
{
    public class AllRajasthanDbContext:DbContext
    {
       public  AllRajasthanDbContext(DbContextOptions<AllRajasthanDbContext> options) : base(options) { }


        #region Entity DBSets Properties
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageType> PackageTypes { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        #region Enity Model Configuration Event
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PackagesConfiguration(modelBuilder.Entity<Package>());
            new ItinerariesConfiguration(modelBuilder.Entity<Itinerary>());
            new PackageTypeConfiguration(modelBuilder.Entity<PackageType>());

        }
        #endregion

    }
}
