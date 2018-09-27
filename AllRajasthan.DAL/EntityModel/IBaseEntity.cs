using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.EntityModel
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
    }
}
