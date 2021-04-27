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
            return ErrorStrings.GenerateError();
        }

        [HttpGet("{number}")]
        public DummyError[] Get(int number)
        {
            var errorArray = new DummyError[number];

            for (int index = 0; index < number; index++)
            {
                errorArray[index] = ErrorStrings.GenerateError();
            }

            return errorArray;
        }
    }
}
