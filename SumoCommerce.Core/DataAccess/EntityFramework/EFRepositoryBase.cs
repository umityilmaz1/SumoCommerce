using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Core.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext, new()
    {
        TContext _ctx = EFSingletonContext<TContext>.GetInstance();

        public int Add(TEntity entity)
        {
            _ctx.Set<TEntity>().Add(entity);
            return _ctx.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            entity.IsActive = false;
            _ctx.Entry(entity).State = EntityState.Modified;
            return _ctx.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _ctx.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
                return _ctx.Set<TEntity>().ToList();
            else
                return _ctx.Set<TEntity>().Where(filter).ToList();
        }

        public int Update(TEntity entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            return _ctx.SaveChanges();
        }
    }
}
