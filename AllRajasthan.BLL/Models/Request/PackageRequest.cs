using System;
using System.Collections.Generic;

namespace AllRajasthan.BLL.Models.Request
{
    public class PackageRequest
    {
        public Guid PackageID { get; set; }
        public string PackageName { get; set; }
        public string Overview { get; set; }
        public string Exclusions { get; set; }
        public string CancellationPolicy { get; set; }
        public string Notes { get; set; }
        public string Images { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int TotalDays { get; set; }

        public virtual ICollection<PackageTypeRequest> PackageTypeRequests { get; set; }    
    }

    public class PackageTypeRequest
    {
        public Guid ID { get; set; }
        public Guid PackageID { get; set; }
        public string PackageTypeName { get; set; }
        public int Amount { get; set; }
        public string Inclusions { get; set; }
        public int Sort { get; set; }
    }

    public class ItineraryRequest
    {
        public Guid ID { get; set; }
        public Guid PackageID { get; set; }
        public int Day { get; set; }
        public string Description { get; set; }
    }
}
