using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO
{
    public interface IDTO
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
    }
}
