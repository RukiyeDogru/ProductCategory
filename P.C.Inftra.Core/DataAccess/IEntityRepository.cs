using P.C.Inftra.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace P.C.Inftra.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> ListQueryableNoTracking { get; }
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
        void DeleteReal(T entity);
    }
}
