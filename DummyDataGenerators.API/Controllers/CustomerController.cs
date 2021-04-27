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
        private CustomerGenerator.CustomerGenerator _generator;
        public CustomerController()
        {
            _generator = new CustomerGenerator.CustomerGenerator();
        }

        [HttpGet]
        public DummyCustomer Get()
        {
            return _generator.Generate();
        }

        [HttpGet("{number}")]
        public DummyCustomer[] Get(int number)
        {
            var customerArray = new DummyCustomer[number];

            for (int index = 0; index < number; index++)
            {
                customerArray[index] = _generator.Generate();
            }

            return customerArray;
        }

    }
}
