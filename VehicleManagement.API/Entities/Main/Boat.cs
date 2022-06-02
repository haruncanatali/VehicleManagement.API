using VehicleManagement.API.Entities.Abstract;
using VehicleManagement.API.Entities.Base;

namespace VehicleManagement.API.Entities.Main
{
    public class Boat:Vehicle,IEntity
    {
        public decimal Price { get; set; }
    }
}
