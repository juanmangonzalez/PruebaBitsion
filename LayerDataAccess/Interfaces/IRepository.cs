using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Interfaces
{
    public interface IRepository<TEntity, TId>
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);

        TEntity Get(TId key);

        void Delete(TId entity);

        IEnumerable<TEntity> GetAll();

        void UpdateValues(TEntity oldObject, TEntity newObject);

    }
}
