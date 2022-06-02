using System.Security.Cryptography;
using VehicleManagement.API.Entities.Helper;

namespace VehicleManagement.API.Entities.Base
{
    public class Vehicle
    {
        public Vehicle()
        {
            Headlights = new List<Headlight>();
            Wheels = new List<Wheel>();
        }

        public int Id { get; set; }
        public string Color { get; set; }

        public IEnumerable<Headlight> Headlights { get; set; }
        public IEnumerable<Wheel> Wheels { get; set; }
    }
}
