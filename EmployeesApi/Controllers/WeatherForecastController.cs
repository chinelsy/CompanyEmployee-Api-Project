using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           //_repository.Company.AnyMethodFromCompanyRepository();
           //_repository.Employee.AnyMethodFromEmployeeRepository();
            return new string[] { "value1", "value2" };

        }
         

}   }


    /*private ILoggerManager _logger;
    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");
        return new string[] { "value1", "value2" };
    }*/

 


