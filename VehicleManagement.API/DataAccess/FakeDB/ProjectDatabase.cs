using VehicleManagement.API.Entities.Base;
using VehicleManagement.API.Entities.Helper;
using VehicleManagement.API.Entities.Main;

namespace VehicleManagement.API.DataAccess.FakeDB
{
    public class ProjectDatabase
    {
        public static List<Car> Cars = new List<Car>();
        public static List<Bus> Buses = new List<Bus>();
        public static List<Boat> Boats = new List<Boat>();

        public static void FakeDB()
        {
            Random rnd = new Random();
            var vehicleId = 1;
            Vehicle car = new Car
            {
                Id = vehicleId,
                Color = "Blue",
                HP = 256,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                }
            };

            vehicleId++;

            Vehicle car1 = new Car
            {
                Id = vehicleId,
                Color = "Blue",
                HP = 255,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                }
            };

            vehicleId++;

            Vehicle car2 = new Car
            {
                Id = vehicleId,
                Color = "Orange",
                HP = 255,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                }
            };

            vehicleId++;

            Vehicle bus = new Bus()
            {
                Id = vehicleId,
                Color = "Blue",
                NumberOfSeats = 55,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = vehicleId
                    }
                }
            };

            Cars.Add((Car)car);
            Cars.Add((Car)car1);
            Cars.Add((Car)car2);
            Buses.Add((Bus)bus);
        }
    }
}
