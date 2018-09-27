using System;
using System.Collections.Generic;
using System.Text;

namespace AllRajasthan.DAL.Abstract
{
    public interface IDbFactory:IDisposable
    {
        AllRajasthanDbContext Init();
    }
}
