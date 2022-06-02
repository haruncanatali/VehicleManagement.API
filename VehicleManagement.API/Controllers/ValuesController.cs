using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleManagement.API.Business.Main;
using VehicleManagement.API.DataAccess.FakeDB;
using VehicleManagement.API.DataAccess.Main;
using VehicleManagement.API.Entities.Base;
using VehicleManagement.API.Entities.Main;
using VehicleManagement.API.Models;
using VehicleManagement.API.Models.Dtos;

namespace VehicleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IInstanceFactory factory;
        private ICarService carService;
        private IBusService busService;
        private IBoatService boatService;

        public ValuesController()
        {
            factory = new InstanceFactory();

            carService = (ICarService)factory.GetService(ServiceType.Car);
            boatService = (IBoatService)factory.GetService(ServiceType.Boat);
            busService = (IBusService)factory.GetService(ServiceType.Bus);

            if (ProjectDatabase.Cars.Count == 0 && ProjectDatabase.Buses.Count == 0)
            {
                ProjectDatabase.FakeDB();
            }
        }

        [HttpPost]
        [Route("headlightsState")]
        public IActionResult HeadlightsState([FromBody]HeadlightsStateDto model)
        {
            try
            {
                Vehicle car = (Car) carService.GetEntity(c => c.Id == model.Id);
                carService.CheckCarHeadlights(car.Id, model.State);

                var msg = model.State
                    ? $"The headlights of the vehicle with {car.Id} ID tag were turned on."
                    : $"The headlights of the vehicle with {car.Id} ID tag were turned off.";

                return Ok(new string[] { msg });
            }
            catch (ArgumentNullException)
            {
                return BadRequest(new string[] { "Vehicle not found." });
            }
            catch (Exception e)
            {
                return BadRequest(new string[] { e.Message });
            }
        }

        [HttpGet]
        [Route("getVehiclesByColor")]
        public IActionResult GetVehicles([FromBody]GetVehiclesByColorDto model)
        {
            if (!String.IsNullOrEmpty(model.Color) && !String.IsNullOrEmpty(model.VehicleType))
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                switch (model.VehicleType.ToLower())
                {
                    case "car":
                        vehicles.AddRange(carService.GetEntities(c => c.Color.ToLower() == model.Color.ToLower()));
                        break;
                    case "boat":
                        vehicles.AddRange(boatService.GetEntities(c => c.Color.ToLower() == model.Color.ToLower()));
                        break;
                    case "bus":
                        vehicles.AddRange(busService.GetEntities(c => c.Color.ToLower() == model.Color.ToLower()));
                        break;
                    default:
                        return BadRequest(new string[] { "Vehicle type not found!" });
                }

                if (vehicles.Count == 0)
                {
                    return BadRequest(new string[] { "This color vehicle of the requested type was not found." });
                }

                return Ok(vehicles);
            }
            else
            {
                return BadRequest(new string[] { "Bad format!" });
            }
        }

        [HttpDelete]
        [Route("deleteCarById")]
        public IActionResult DeleteCarById(int id)
        {
            try
            {
                carService.DeleteCarById(id);
                return Ok(new string[] { $"Vehicle with {id} ID has been deleted." });
            }
            catch (NullReferenceException e)
            {
                return BadRequest(new string[] { e.Message });
            }
            catch (Exception e)
            {
                return BadRequest(new string[] { "Error :" + e.Message });
            }
        }

    }
}
