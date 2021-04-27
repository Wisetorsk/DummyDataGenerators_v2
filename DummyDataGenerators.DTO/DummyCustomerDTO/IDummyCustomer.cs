using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyCustomerDTO
{
    public interface IDummyCustomer
    {
        Guid Kundeid { get; set; }
        string Kundenavn { get; set; }
        string Applikasjon { get; set; }
        string Brukernavn { get; set; }
        string PassordHash { get; set; }
        bool Aktivisert { get; set; }
        bool TilgangFeiing { get; set; }
        bool TilgangPrivatVa { get; set; }
        bool TilgangVA { get; set; }
        bool TilgangGebyr { get; set; }
        bool TilgangRenovasjonsApp { get; set; }
        int Rolle { get; set; }
        string Visningsnavn { get; set; }
        string Klientnavn { get; set; }
    }
}
