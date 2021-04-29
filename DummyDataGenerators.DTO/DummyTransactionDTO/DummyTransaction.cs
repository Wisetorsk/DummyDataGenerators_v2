using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyTransactionDTO
{
    public class DummyTransaction : IDummyTransaction
    {
        public string Id { get; set; }
        public string Kundenavn { get; set; }
        public string Bruker { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public string Applikasjon { get; set; }
        public DateTime Dato { get; set; }
    }
}
