using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyDataGenerators.CustomerGenerator;
using DummyDataGenerators.DTO.DummyCustomerDTO;

namespace DummyDataGenerators.Repository
{
    public class CustomerRepository : IRepository<DummyCustomer>
    {
        private IGenerator<DummyCustomer> _generator;
        public string SqlTableConnection { get; set; }

        public CustomerRepository(string sqlString, string tableString)
        {
            _generator = new DummyCustomerGenerator();
        }

        public DummyCustomer GetSingleDataset()
        {
            return _generator.Generate();
        }

        public bool InsertIntoTable(DummyCustomer dataSet)
        {
            throw new NotImplementedException();
        }
    }
}
