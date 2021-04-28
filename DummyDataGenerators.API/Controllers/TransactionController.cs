using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyDataGenerators.TransactionGenerator;
using DummyDataGenerators.DTO.DummyTransactionDTO;

namespace DummyDataGenerators.API.Controllers
{

    

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {

        private DummyTransactionGenerator _generator;

        public TransactionController()
        {
            _generator = new();
        }

        [HttpGet]
        public DummyTransaction Get()
        {
            return _generator.Generate();
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
