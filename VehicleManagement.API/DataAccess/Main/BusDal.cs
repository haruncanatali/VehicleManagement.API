using System.Linq;
using System.Linq.Expressions;
using VehicleManagement.API.Business.Main;
using VehicleManagement.API.DataAccess.FakeDB;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.DataAccess.Main
{
    public class BusDal:IBusService
    {
        public void Add(Bus entity) => ProjectDatabase.Buses.Add(entity);
        

        public void Update(Bus entity) => ProjectDatabase.Buses[ProjectDatabase.Buses.IndexOf(ProjectDatabase.Buses.Find(c => c.Id == entity.Id))] = entity;
        

        public void Delete(Bus entity) => ProjectDatabase.Buses.Remove(entity);
        

        public List<Bus> GetEntities(Expression<Func<Bus, bool>> filter = null) => filter == null ? ProjectDatabase.Buses : ( ProjectDatabase.Buses.AsQueryable() ).Where(filter).ToList();
        
        public Bus GetEntity(Expression<Func<Bus, bool>> filter) => ( ProjectDatabase.Buses.AsQueryable() ).SingleOrDefault(filter);
        
    }
}
