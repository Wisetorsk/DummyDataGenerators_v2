using System;
using DummyDataGenerators.TransactionGenerator;
using DummyDataGenerators.DTO.DummyTransactionDTO;
using DummyDataGenerators;


namespace DummyDataGenerators.Repository
{
    public class TransactionRepository : IRepository<DummyTransaction>
    {
        private IGenerator<DummyTransaction> _generator;
        public string SqlTableConnection { get; set; }

        public TransactionRepository()
        {
            _generator = new DummyTransactionGenerator();
        }


        public DummyTransaction GetSingleDataset()
        {
            return _generator.Generate();
        }

        public bool InsertIntoTable(DummyTransaction dataSet)
        {
            throw new NotImplementedException();
        }
    }
}
