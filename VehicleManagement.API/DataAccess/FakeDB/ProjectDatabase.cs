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
            var carID = 1;
            Vehicle car = new Car
            {
                Id = carID,
                Color = "Blue",
                HP = 256,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                }
            };

            carID++;

            Vehicle car1 = new Car
            {
                Id = carID,
                Color = "Blue",
                HP = 255,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                }
            };

            carID++;

            Vehicle car2 = new Car
            {
                Id = carID,
                Color = "Orange",
                HP = 255,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                }
            };

            carID++;

            Vehicle bus = new Bus()
            {
                Id = carID,
                Color = "Blue",
                NumberOfSeats = 55,
                Headlights = new List<Headlight>
                {
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Headlight
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    }
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
                    },
                    new Wheel
                    {
                        Id = rnd.Next(1,1000000),
                        VehicleId = carID
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
