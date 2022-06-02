using VehicleManagement.API.Business.Base;
using VehicleManagement.API.Entities.Abstract;

namespace VehicleManagement.API.Models
{
    public interface IInstanceFactory
    {
        IEntity GetVehicle(VehicleType type);
        IEntity GetWheel();
        IEntity GetHeadlight();
        IServiceSignature GetService(ServiceType type);
    }

    public enum VehicleType
    {
        Boat = 1,
        Bus = 2,
        Car = 3
    }

    public enum ServiceType
    {
        Boat = 1,
        Bus = 2,
        Car = 3
    }
}
