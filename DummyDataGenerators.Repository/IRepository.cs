using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.Repository
{
    public interface IRepository<T>
    {
        string SqlTableConnection { get; set; }
        T GetSingleDataset();
        bool InsertIntoTable(T dataSet);
    }
}
