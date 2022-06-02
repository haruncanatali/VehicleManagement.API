using System.Linq;
using System.Linq.Expressions;
using VehicleManagement.API.Business.Main;
using VehicleManagement.API.DataAccess.FakeDB;
using VehicleManagement.API.Entities.Base;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.DataAccess.Main
{
    public class CarDal:ICarService
    {
        public void Add(Car entity) => ProjectDatabase.Cars.Add(entity);
        

        public void Update(Car entity) => ProjectDatabase.Cars[ProjectDatabase.Cars.IndexOf(ProjectDatabase.Cars.Find(c => c.Id == entity.Id))] = entity;
        

        public void Delete(Car entity) => ProjectDatabase.Cars.Remove(entity);
        

        public List<Car> GetEntities(Expression<Func<Car, bool>> filter = null) => filter == null ? ProjectDatabase.Cars : ( ProjectDatabase.Cars.AsQueryable() ).Where(filter).ToList();
        

        public Car GetEntity(Expression<Func<Car, bool>> filter) => (ProjectDatabase.Cars.AsQueryable()).SingleOrDefault(filter);
        

        public void CheckCarHeadlights(int carId, bool state)
        {
            Vehicle car = ProjectDatabase.Cars.Find(c => c.Id == carId)!;

            if (car.Headlights.Count()>0)
            {
                if ( state )
                {
                    foreach ( var item in car.Headlights )
                    {
                        item.State = true;
                    }
                }
                else
                {
                    foreach ( var item in car.Headlights )
                    {
                        item.State = false;
                    }
                }
            }
            else
            {
                throw new NullReferenceException("The car has no wheels.");
            }
        }

        public void DeleteCarById(int carId)
        {
            Vehicle car = ProjectDatabase.Cars.Find(c => c.Id == carId);

            if (car == null)
            {
                throw new NullReferenceException("The vehicle to be deleted from the system was not found.");
            }
            else
            {
                ProjectDatabase.Cars.Remove((Car)car);
            }
        }
    }
}
