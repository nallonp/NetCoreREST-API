using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Service.Interfaces;

namespace WebStoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _service;
        private readonly ILogger<CarController> _logger;
        public CarController(ICarService service, ILogger<CarController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ICar>> Get()
        {
            try
            {
                _logger.LogInformation("Received get request!");
                return Ok(_service.ListAll());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
        [HttpGet("{manufacturer}")]
        public ActionResult<ICar> Get([FromRoute]String manufacturer)
        {
            try
            {
                _logger.LogInformation("Received get request!");
                return Ok(_service.FindByManufacturer(manufacturer));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
        [HttpPost]
        public ActionResult<string> Post([FromBody]Car car)
        {
            try
            {
                _logger.LogInformation("Received post request");
                if (ModelState.IsValid)
                {
                    _service.Add(car);
                    return Ok("Success!");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}