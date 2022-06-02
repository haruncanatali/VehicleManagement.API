using System.Linq.Expressions;
using VehicleManagement.API.Entities.Base;

namespace VehicleManagement.API.Business.Base
{
    public interface IBaseRepository<TEntity> where TEntity : Vehicle, new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetEntities(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetEntity(Expression<Func<TEntity, bool>> filter);
    }
}
