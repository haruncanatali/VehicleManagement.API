using VehicleManagement.API.Entities.Abstract;
using VehicleManagement.API.Entities.Base;

namespace VehicleManagement.API.Entities.Helper
{
    public class Headlight:IEntity
    {
        public int Id { get; set; }
        public bool State { get; set; } = false;

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
