using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehiclesSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        BusManager _busManager = new BusManager(new EfBusRepository());
        [HttpGet]
        public IActionResult ListBus()
        {
            var values = _busManager.GetList();
            return Ok(values);
        }
        [HttpGet("{string}")]
        public IActionResult ListBusWithColor(string color)
        {
            var values = _busManager.GetBusListWithColor(color);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBus(Bus p)
        {
            _busManager.TAdd(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBus(int id)
        {
            var value = _busManager.TGetById(id);
            _busManager.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBus(Car p)
        {
            var value = _busManager.TGetById(p.Id);
            value.Color = p.Color;
            _busManager.TUpdate(value);
            return Ok();
        }
    }
}
