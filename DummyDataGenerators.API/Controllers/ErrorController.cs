using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyDataGenerators.DTO.DummyErrorDTO;
using DummyDataGenerators.ErrorGenerator;
using DummyDataGenerators.Logger.Log;
using System.Configuration;

namespace DummyDataGenerators.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly LoggingModes _logMode = (LoggingModes)int.Parse(ConfigurationManager.AppSettings["logMode"]);
        private readonly DataLogger _logger;

        public ErrorController()
        {
            _logger = new();
        }

        [HttpGet]
        public DummyError Get()
        {
            _logger.LogHttpRequest(Request, "Single Request", (int)_logMode);
            return DummyErrorGenerator.GenerateError();
        }

        [HttpGet("{numberOfErrors}")]
        public DummyError[] Get(int numberOfErrors)
        {
            var errorArray = new DummyError[numberOfErrors];
            _logger.LogHttpRequest(Request, $"Multiple Requests: {numberOfErrors}", (int)_logMode);
            for (int index = 0; index < numberOfErrors; index++)
            {
                errorArray[index] = DummyErrorGenerator.GenerateError();
            }

            return errorArray;
        }
    }
}
