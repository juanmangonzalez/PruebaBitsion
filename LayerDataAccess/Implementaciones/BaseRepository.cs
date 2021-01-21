using LayerDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Implementaciones
{
    public class BaseRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        protected readonly Context context;
        protected DbSet<TEntity> dbSet;

        public BaseRepository(IContext context)
        {
            this.context = (Context)context;
            dbSet = ((Context)context).Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(TId entity)
        {
            var item = dbSet.Find(entity);

            dbSet.Remove(item);
            context.SaveChanges();
        }

        public TEntity Get(TId key)
        {
            return dbSet.Find(key);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void UpdateValues(TEntity oldObject, TEntity newObject)
        {
            context.Entry(oldObject).CurrentValues.SetValues(newObject);
            context.SaveChanges();
        }
    }
}
