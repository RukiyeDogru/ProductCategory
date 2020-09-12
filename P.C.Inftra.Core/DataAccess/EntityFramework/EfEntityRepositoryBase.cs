using Microsoft.EntityFrameworkCore;
using P.C.Inftra.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace P.C.Inftra.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
     where TContext : DbContext, new()

    {
        public IQueryable<TEntity> ListQueryableNoTracking => throw new NotImplementedException();

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(id);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void DeleteReal(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Insert(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Add(entity);
                context.SaveChanges();

                return entity;
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        TEntity IEntityRepository<TEntity>.Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
    }
}
