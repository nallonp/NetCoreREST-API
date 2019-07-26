using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStore.Domain.Entities;
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
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                _logger.LogInformation("\nReceived get request!\nGetAll()");
                return Ok(_service.GetAll());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
        [HttpGet("{maker}")]
        public ActionResult<Car> Get([FromRoute]String maker)
        {
            try
            {
                _logger.LogInformation($"\nReceived get request by maker:\n{maker}");
                return Ok(_service.SearchByMaker(maker));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
        [HttpPost]
        public ActionResult<string> Post(Car car)
        {
            try
            {
                _logger.LogInformation($"\nReceived post request\n{car}");
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
        [HttpPut("{guid}")]
        public ActionResult<string> Put(Car car)
        {
            try
            {
                _logger.LogInformation($"\nReceived put request!\n{car}");
                if (ModelState.IsValid)
                {
                    _service.Update(car);
                    return Ok("Sucess!");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return new StatusCodeResult(500);
            }
        }
        [HttpDelete("{guid}")]
        public ActionResult<string> Delete([FromRoute] string guid)
        {
            try
            {
                _logger.LogInformation($"\nReceived delete request guid\n{guid}");
                _service.Delete(guid);
                return Ok("Sucess");
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}