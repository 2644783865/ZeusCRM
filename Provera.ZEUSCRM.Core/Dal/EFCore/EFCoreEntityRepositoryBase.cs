using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Provera.ZEUSCRM.Core.Entity;

namespace Provera.ZEUSCRM.Core.Dal.EFCore
{
    public class EFCoreEntityRepositoryBase<TEntity/*, TContext*/> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        //where TContext : DbContext, new()

    {
        
        protected readonly DbContext context;

        public EFCoreEntityRepositoryBase(DbContext _context)
        {
            context = _context;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            
                return context.Set<TEntity>().SingleOrDefault(filter);

            

        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {

            
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            




        }

        public void Add(TEntity entity)
        {
            
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            




        }

        public void Update(TEntity entity)
        {
            
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            




        }

        public void Delete(TEntity entity)
        {
            
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            




        }
    }
}
