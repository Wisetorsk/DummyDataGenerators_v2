using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyDataGenerators.ErrorGenerator;
using DummyDataGenerators.DTO.DummyErrorDTO;

namespace DummyDataGenerators.Repository
{
    public class ErrorRepository : IRepository<ErrorData>
    {
        private IGenerator<ErrorData> _generator;
        public ErrorRepository()
        {
            _generator = new DummyErrorGenerator_V2();
        }

        public string SqlTableConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ErrorData GetSingleDataset()
        {
            return _generator.Generate();
        }

        public bool InsertIntoTable(ErrorData dataSet)
        {
            throw new NotImplementedException();
        }
    }
}
