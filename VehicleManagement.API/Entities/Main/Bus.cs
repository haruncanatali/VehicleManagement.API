using VehicleManagement.API.Entities.Abstract;
using VehicleManagement.API.Entities.Base;

namespace VehicleManagement.API.Entities.Main
{
    public class Bus:Vehicle,IEntity
    {
        public short NumberOfSeats { get; set; }
    }
}
