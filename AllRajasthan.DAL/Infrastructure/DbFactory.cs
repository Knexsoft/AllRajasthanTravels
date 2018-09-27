using AllRajasthan.DAL.Abstract;

namespace AllRajasthan.DAL.Infrastructure
{
    public class DbFactory:IDbFactory
    {
        AllRajasthanDbContext _dbContext;
        public DbFactory(AllRajasthanDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AllRajasthanDbContext Init()
        {
            return _dbContext;

        }
        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
