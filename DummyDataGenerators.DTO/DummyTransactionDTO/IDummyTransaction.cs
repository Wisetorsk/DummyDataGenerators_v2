using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyTransactionDTO
{
    public interface IDummyTransaction
    {
        int Id { get; set; }
        string Kundenavn { get; set; }
        string Bruker { get; set; }
        string Type { get; set; }
        string Data { get; set; }
        string Applikasjon { get; set; }
        DateTime Dato { get; set; }
    }
}
