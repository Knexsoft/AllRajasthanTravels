using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.EntityModel
{
    public class PackageType:IBaseEntity
    {
        public Guid ID { get; set; }
        public Guid PackageID { get; set; }
        public string PackageTypeName { get; set; }
        public int  Amount { get; set; }
        public string Inclusions { get; set; }
        public int Sort { get; set; }

        public virtual Package Package{ get; set; }
    }
}
