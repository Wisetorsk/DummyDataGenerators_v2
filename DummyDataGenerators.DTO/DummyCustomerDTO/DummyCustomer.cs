using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyCustomerDTO
{
    public class DummyCustomer : IDummyCustomer
    {
        public Guid Kundeid { get; set; }
        public string Kundenavn { get; set; }
        public string Applikasjon { get; set; }
        public string Brukernavn { get; set; }
        public string PassordHash { get; set; }
        public bool Aktivisert { get; set; }
        public bool TilgangFeiing { get; set; }
        public bool TilgangPrivatVa { get; set; }
        public bool TilgangVA { get; set; }
        public bool TilgangGebyr { get; set; }
        public bool TilgangRenovasjonsApp { get; set; }
        public int Rolle { get; set; }
        public string Visningsnavn { get; set; }
        public string Klientnavn { get; set; }
    }
}
