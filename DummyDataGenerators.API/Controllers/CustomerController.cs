using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DummyDataGenerators.DTO.DummyCustomerDTO;
using DummyDataGenerators.CustomerGenerator;
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
        private DummyCustomerGenerator _generator;
        public CustomerController()
        {
            _generator = new DummyCustomerGenerator();
        }

        [HttpGet]
        public DummyCustomer Get()
        {
            return _generator.Generate();
        }

        [HttpGet("{numberOfCustomers}")]
        public DummyCustomer[] Get(int numberOfCustomers)
        {
            var customerArray = new DummyCustomer[numberOfCustomers];

            for (int index = 0; index < numberOfCustomers; index++)
            {
                customerArray[index] = _generator.Generate();
            }

            return customerArray;
        }

    }
}
