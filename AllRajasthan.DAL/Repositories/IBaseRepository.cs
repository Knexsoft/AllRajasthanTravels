using AllRajasthan.DAL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AllRajasthan.DAL.Repositories
{
    public interface IBaseRepository<T> where T:class,IBaseEntity, new()
    {
        T Add(T t);

        Task<T> AddAsync(T t);

        int Count();

        Task<int> CountAsync();
        void Delete(T entity);
        Task<int> DeleteAsync(T entity);
        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        T Get(Guid ID);
        Task<T> GetAsync(Guid ID);
        IEnumerable<T> All { get; }
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        void Save();
        Task<int> SaveAsync();
        T Update(T t, object key);
        Task<T> UpdateAsync(T t, object key);
    }
}
