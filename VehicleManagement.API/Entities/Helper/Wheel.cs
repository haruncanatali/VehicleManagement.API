using VehicleManagement.API.Entities.Abstract;
using VehicleManagement.API.Entities.Base;

namespace VehicleManagement.API.Entities.Helper
{
    public class Wheel:IEntity
    {
        public int Id { get; set; }
        public bool IsSnowTire { get; set; }

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle{ get; set; }
    }
}
