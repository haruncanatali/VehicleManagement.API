using VehicleManagement.API.Entities.Abstract;
using VehicleManagement.API.Entities.Base;

namespace VehicleManagement.API.Entities.Main
{
    public class Car:Vehicle,IEntity
    {
        public short HP { get; set; }
    }
}
