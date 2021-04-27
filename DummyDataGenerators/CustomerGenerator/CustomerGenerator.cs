using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DummyDataGenerators.DTO.DummyCustomerDTO;

namespace DummyDataGenerators.CustomerGenerator
{
    public class CustomerGenerator
    {
        #region fields
        private  readonly string[] _customerNames = {
            "Lillehammer Kommune",
            "Bodø Kommune",
            "Lillestrøm IKS",
            "Norkart AS",
            "IKOMM as",
            "Alvdal Kommune",
            "Vinje Kommune"
        };

        private  readonly string[] _applicationNames =
        {
            "VAtilsyn",
            "Gebyr",
            "Feiing",
            "Va",
            "MinRenovasjon",
            "RenovasjonApp"
        };

        private  readonly string[] _userNames =
        {
            "Aaliyah Osorio",
            "Amina Hardie",
            "Axel Schneider",
            "Blaine Meador",
            "Bo Bedard",
            "Clare Appleton",
            "Emme Millan",
            "Gia Pippin",
            "Jesse Mayo",
            "Jules Pacheco",
            "Kallie Tucker",
            "Katie Briley",
            "Kyleigh Noonan",
            "Kyson Stroud",
            "Leif Lehr",
            "Livia Harry",
            "Malachi Kaye",
            "Malaya Kerley",
            "Mekhi Dunlop",
            "Miah Dehart",
            "Pepper Easter",
            "Sierra Masse",
            "Tori Ramsay",
            "Troy Frith",
            "Willow Montez"
        };

        private  readonly string[] _displayNames =
        {
            "Moderne Norkart",
            "Mega Norkart",
            "Attentive Norkart",
            "Cunning Norkart",
            "Cute Norkart",
            "Astute Norkart",
            "Cagy Norkart",
            "Norkart the Aptitude",
            "Norkart the Brains",
            "Norkart the Ache",
            "Cagey Norkart",
            "Clever Norkart",
            "Innviklet Norkart",
            "Regular Norkart",
            "Unspellable Norkart"
        };

        private  readonly string[] _clientNames =
        {
            "ClientA","ClientB","ClientB","ClientC","ClientD","ClientE","ClientF","ClientG","ClientH"
        };

        private byte[] _dataArray => Enumerable.Range(0, 16).Select(i => (byte)RNG.Next(256)).ToArray(); // Generates a 16 byte array of random values

        #endregion

        #region Properties
        private bool[] AccessVariables => Enumerable.Range(0, 6).Select(i => RNG.Next(2) > 0).ToArray();

        private string GeneratePasswordHash => Convert.ToBase64String(SHA256.Create().ComputeHash(_dataArray)); // Generates a hash from the byte array
        private Random RNG { get; set; }
        private Guid GenerateKundeGUID => new();
        private  string GenerateCustomerName => _customerNames[RNG.Next(_customerNames.Length)];
        private  string GenerateApplicationName => _applicationNames[RNG.Next(_applicationNames.Length)];
        private  string GenerateUserName => _userNames[RNG.Next(_userNames.Length)].Replace(" ", "");
        private  string GenerateDisplayName => _displayNames[RNG.Next(_displayNames.Length)];
        private  string GenerateClientName => _clientNames[RNG.Next(_clientNames.Length)];
        private  int GenerateRole => RNG.Next(10);
        #endregion

        public CustomerGenerator()
        {
            RNG = new Random();
        }
        public DummyCustomer Generate()
        {
            return new DummyCustomer() {
                Kundeid = GenerateKundeGUID,
                Kundenavn = GenerateCustomerName,
                Applikasjon = GenerateApplicationName,
                Brukernavn = GenerateUserName,
                PassordHash = GeneratePasswordHash,
                Aktivisert = AccessVariables[0],
                TilgangFeiing = AccessVariables[1],
                TilgangPrivatVa = AccessVariables[2],
                TilgangVA = AccessVariables[3],
                TilgangGebyr = AccessVariables[4],
                TilgangRenovasjonsApp = AccessVariables[5],
                Rolle = GenerateRole,
                Visningsnavn = GenerateDisplayName,
                Klientnavn = GenerateClientName
            };
        }
    }
}
