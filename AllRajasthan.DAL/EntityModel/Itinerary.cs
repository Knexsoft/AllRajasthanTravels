using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.EntityModel
{
    public class Itinerary : IBaseEntity
    {
        public Guid ID { get; set; }
        public Guid PackageID { get; set; }
        public int Day { get; set; }
        public string Description { get; set; }

        public virtual Package Package { get; set; }
    }
}
