using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyDataGenerators.TransactionGenerator;
using DummyDataGenerators.DTO.DummyTransactionDTO;
using DummyDataGenerators.Logger.Log;
using DummyDataGenerators.Repository;
using System.Configuration;
using System.Text;

namespace DummyDataGenerators.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly LoggingModes _logMode = (LoggingModes)int.Parse(ConfigurationManager.AppSettings["logMode"]);
        private readonly IRepository<DummyTransaction> _repository;
        private readonly DataLogger _logger;

        public TransactionController()
        {
            _repository = new TransactionRepository(); 
            _logger = new();
        }

        [HttpGet]
        public DummyTransaction Get()
        {
            var response = _repository.GetSingleDataset();
            // The Request should maybe be piped into a custom method on the logger that also takes in log mode argument to simplify code in controller...
            _logger.LogHttpRequest(Request, "Single Request", (int)_logMode);
            return response;
        }

        [HttpGet("{numberOfTransactions}")]
        public DummyTransaction[] Get(int numberOfTransactions)
        {
            var transactions = new DummyTransaction[numberOfTransactions];
            _logger.LogHttpRequest(Request, $"Multiple Requests: {numberOfTransactions}", (int)_logMode);
            for (int index = 0; index < numberOfTransactions; index++)
            {
                transactions[index] = _repository.GetSingleDataset();
            }
            return transactions;
        }

    }
}
