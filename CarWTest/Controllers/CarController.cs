using Business.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarWTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // GET: api/<CarController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await carService.GetCars());
        }

        [HttpGet("sp")]
        public async Task<ActionResult> GetInfoSp()
        {
            return Ok(await carService.GetInfoCar());
        }
    }
}
