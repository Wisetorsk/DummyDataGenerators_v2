using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyErrorDTO
{
    public class ErrorData
    {
        public Guid ID { get; set; }
        public string Kundenavn { get; set; }
        public string Type { get; set; }
        public DateTime Dato { get; set; }
        public string Bruker { get; set; }
        public string Data { get; set; }
        public Severity AlvorlighetsGrad { get; set; }
        public ErrorClass FeilKlasse { get; set; }
    }
}
