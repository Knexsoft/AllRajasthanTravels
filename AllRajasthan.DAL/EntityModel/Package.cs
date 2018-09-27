using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.EntityModel
{
    public class Package : IBaseEntity
    {
        public Guid ID { get; set; }
        public string PackageName { get; set; }
        public string Overview { get; set; }
        public string Exclusions { get; set; }
        public string CancellationPolicy { get; set; }
        public string Notes { get; set; }
        public string Images { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int TotalDays { get; set; }


        public virtual ICollection<Itinerary> Itineraries { get; set; }
        public virtual ICollection<PackageType> PackageTypes { get; set; }
    }
}
