using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DummyDataGenerators.DTO.DummyCustomerDTO;
using DummyDataGenerators.Repository;
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
        private readonly IRepository<DummyCustomer> _repository;
        private readonly DataLogger _logger;
        private readonly string _sqlString;
        private readonly string _tableName;
        public CustomerController()
        {
            _repository = new CustomerRepository(_sqlString, _tableName);
            _logger = new();
        }

        [HttpGet]
        public DummyCustomer Get()
        {
            _logger.LogHttpRequest(Request, "Single Request", (int)_logMode);
            return _repository.GetSingleDataset();
        }

        [HttpGet("{numberOfCustomers}")]
        public DummyCustomer[] Get(int numberOfCustomers)
        {
            var customerArray = new DummyCustomer[numberOfCustomers];
            _logger.LogHttpRequest(Request, $"Multiple Requests: {numberOfCustomers}", (int)_logMode);

            for (int index = 0; index < numberOfCustomers; index++)
            {
                customerArray[index] = _repository.GetSingleDataset();
            }

            return customerArray;
        }

        [HttpPost]
        public void Post(DummyCustomer customer)
        {
            _logger.LogHttpRequest(Request, "Single Request", (int)_logMode);

        }
    }
}
