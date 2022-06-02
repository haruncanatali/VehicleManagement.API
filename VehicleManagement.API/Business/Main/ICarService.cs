using VehicleManagement.API.Business.Base;
using VehicleManagement.API.Entities.Base;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.Business.Main
{
    public interface ICarService:IBaseRepository<Car>,IServiceSignature
    {
        void CheckCarHeadlights(int carId,bool state);
        void DeleteCarById(int carId);
    }
}
