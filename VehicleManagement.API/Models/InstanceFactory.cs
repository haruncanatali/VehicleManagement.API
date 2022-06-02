using VehicleManagement.API.Business.Base;
using VehicleManagement.API.DataAccess.Main;
using VehicleManagement.API.Entities.Abstract;
using VehicleManagement.API.Entities.Helper;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.Models
{
    public class InstanceFactory:IInstanceFactory
    {
        public IEntity GetVehicle(VehicleType type)
        {
            IEntity instance = null!;
            switch (type)
            {
                case VehicleType.Boat:
                    instance = new Boat();
                    break;
                case VehicleType.Bus:
                    instance = new Bus();
                    break;
                case VehicleType.Car:
                    instance = new Car();
                    break;
            }

            return instance!;
        }

        public IEntity GetWheel()
        {
            return new Wheel();
        }

        public IEntity GetHeadlight()
        {
            return new Headlight();
        }

        public IServiceSignature GetService(ServiceType type)
        {
            IServiceSignature instance = null;
            switch (type)
            {
                case ServiceType.Boat:
                    instance = new BoatDal();
                    break;
                case ServiceType.Bus:
                    instance = new BusDal();
                    break;
                case ServiceType.Car:
                    instance = new CarDal();
                    break;
            }

            return instance;
        }
    }
}
