using System.Linq;
using System.Linq.Expressions;
using VehicleManagement.API.Business.Main;
using VehicleManagement.API.DataAccess.FakeDB;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.DataAccess.Main
{
    public class BoatDal:IBoatService
    {
        public void Add(Boat entity) => ProjectDatabase.Boats.Add(entity);
        

        public void Update(Boat entity) => ProjectDatabase.Boats[ProjectDatabase.Boats.IndexOf(ProjectDatabase.Boats.Find(c => c.Id == entity.Id))] = entity;
        

        public void Delete(Boat entity) => ProjectDatabase.Boats.Remove(entity);
        

        public List<Boat> GetEntities(Expression<Func<Boat, bool>> filter = null) => filter == null ? ProjectDatabase.Boats : (ProjectDatabase.Boats.AsQueryable()).Where(filter).ToList();
        

        public Boat GetEntity(Expression<Func<Boat, bool>> filter) => (ProjectDatabase.Boats.AsQueryable()).SingleOrDefault(filter);
        
    }
}
