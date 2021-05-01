using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators
{
    public interface IGenerator<T>
    {
        public T Generate();
    }
}
