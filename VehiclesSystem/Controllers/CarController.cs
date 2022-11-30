using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehiclesSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        CarManager _carManager = new CarManager(new EfCarRepository());
        [HttpGet]
        public IActionResult ListCar()
        {
            var values = _carManager.GetList();
            return Ok(values);
        }
        [HttpGet("{string}")]
        public IActionResult ListCarWithColor(string color)
        {
            var values = _carManager.GetCarListWithColor(color);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCar(Car p)
        {
            _carManager.TAdd(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var value = _carManager.TGetById(id);
            _carManager.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCar(Car p)
        {
            var value = _carManager.TGetById(p.Id);
            value.Color = p.Color;
            value.Wheels = p.Wheels;
            value.Headlights= p.Headlights;
            _carManager.TUpdate(value);
            return Ok();
        }
    }
}
