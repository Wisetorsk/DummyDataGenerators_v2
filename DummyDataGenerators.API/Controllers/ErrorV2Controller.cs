using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyDataGenerators.ErrorGenerator;
using DummyDataGenerators.DTO.DummyErrorDTO;
using DummyDataGenerators.Logger.Log;
using System.Configuration;

namespace DummyDataGenerators.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorV2Controller : ControllerBase
    {

        private readonly LoggingModes _logMode = (LoggingModes)int.Parse(ConfigurationManager.AppSettings["logMode"]);
        private readonly DummyErrorGenerator_V2 _generator;
        private readonly DataLogger _logger;


        public ErrorV2Controller()
        {
            _generator = new();
            _logger = new();
        }

        [HttpGet]
        public ErrorData Get()
        {
            var response = _generator.Generate();

            _logger.LogHttpRequest(Request, "Single Request", (int)_logMode);

            return response;
        }


        [HttpGet("{numberOfErrors}")]
        public ErrorData[] Get(int numberOfErrors)
        {
            var errorArray = new ErrorData[numberOfErrors];
            _logger.LogHttpRequest(Request, $"Multiple Requests: {numberOfErrors}", (int)_logMode);
            for (int index = 0; index < numberOfErrors; index++)
            {
                errorArray[index] = _generator.Generate();
            }

            return errorArray;
        }

    }
}
