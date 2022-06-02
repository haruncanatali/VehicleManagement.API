using VehicleManagement.API.Business.Base;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.Business.Main
{
    public interface IBusService:IBaseRepository<Bus>,IServiceSignature
    {
    }
}
