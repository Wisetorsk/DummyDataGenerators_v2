using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DummyDataGenerators.DTO.DummyCustomerDTO;
using DummyDataGenerators.CustomerGenerator;
using DummyDataGenerators.Logger.Log;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyDataGenerators.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly LoggingModes _logMode = (LoggingModes)int.Parse(ConfigurationManager.AppSettings["logMode"]);
        private readonly DummyCustomerGenerator _generator;
        private readonly DataLogger _logger;
        public CustomerController()
        {
            _generator = new();
            _logger = new();
        }

        [HttpGet]
        public DummyCustomer Get()
        {
            _logger.LogHttpRequest(Request, "Single Request", (int)_logMode);
            return _generator.Generate();
        }

        [HttpGet("{numberOfCustomers}")]
        public DummyCustomer[] Get(int numberOfCustomers)
        {
            var customerArray = new DummyCustomer[numberOfCustomers];
            _logger.LogHttpRequest(Request, $"Multiple Requests: {numberOfCustomers}", (int)_logMode);

            for (int index = 0; index < numberOfCustomers; index++)
            {
                customerArray[index] = _generator.Generate();
            }

            return customerArray;
        }

    }
}
