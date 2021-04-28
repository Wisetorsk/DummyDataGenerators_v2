using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyDataGenerators.TransactionGenerator;
using DummyDataGenerators.DTO.DummyTransactionDTO;
using DummyDataGenerators.Logger.Log;
using System.Configuration;
using System.Text;
using System.Linq;

namespace DummyDataGenerators.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private LoggingModes _logMode = (LoggingModes)int.Parse(ConfigurationManager.AppSettings["logMode"]);
        private DummyTransactionGenerator _generator;
        private DataLogger _logger;

        public TransactionController()
        {
            _generator = new();
            _logger = new();
        }

        [HttpGet]
        public DummyTransaction Get()
        {
            var response = _generator.Generate();
            // The Request should maybe be piped into a custom method on the logger that also takes in log mode argument to simplify code in controller...
            if (_logMode == LoggingModes.Full)
            {
                var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                var requestData = Request.HttpContext.Request.Headers.Select(i => i.ToString()).Aggregate((first, last) => first + " " +  last);
                var msg = new StringBuilder();
                msg.AppendLine("Request from: " + remoteIpAddress);
                msg.AppendLine("\nRequest Data: " + requestData);
                msg.AppendLine("\nResponse: " + response);
                _logger.Log(msg.ToString());
            } else if (_logMode == LoggingModes.Partial)
            {
                var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                var msg = new StringBuilder();
                msg.AppendLine("Request from: " + remoteIpAddress);
                msg.AppendLine("Response: " + response);
                _logger.Log(msg.ToString());
            }
            return response;
        }

        [HttpGet("{numberOfTransactions}")]
        public DummyTransaction[] Get(int numberOfTransactions)
        {
            var transactions = new DummyTransaction[numberOfTransactions];
            for (int index = 0; index < numberOfTransactions; index++)
            {
                transactions[index] = _generator.Generate();
            }
            return transactions;
        }

    }
}
