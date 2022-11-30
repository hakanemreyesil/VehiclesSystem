using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehiclesSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        BoatManager _boatManager = new BoatManager(new EfBoatRepository());
        [HttpGet]
        public IActionResult ListBus()
        {
            var values = _boatManager.GetList();
            return Ok(values);
        }
        [HttpGet("{string}")]
        public IActionResult ListBoatWithColor(string color)
        {
            var values = _boatManager.GetBoatListWithColor(color);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBus(Boat p)
        {
            _boatManager.TAdd(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBus(int id)
        {
            var value = _boatManager.TGetById(id);
            _boatManager.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBus(Car p)
        {
            var value = _boatManager.TGetById(p.Id);
            value.Color = p.Color;
            _boatManager.TUpdate(value);
            return Ok();
        }
    }
}
