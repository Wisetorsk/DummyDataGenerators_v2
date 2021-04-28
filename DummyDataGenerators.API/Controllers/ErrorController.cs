using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyDataGenerators.DTO.DummyErrorDTO;
using DummyDataGenerators.ErrorGenerator;

namespace DummyDataGenerators.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public DummyError Get()
        {
            return DummyErrorGenerator.GenerateError();
        }

        [HttpGet("{numberOfErrors}")]
        public DummyError[] Get(int numberOfErrors)
        {
            var errorArray = new DummyError[numberOfErrors];

            for (int index = 0; index < numberOfErrors; index++)
            {
                errorArray[index] = DummyErrorGenerator.GenerateError();
            }

            return errorArray;
        }
    }
}
