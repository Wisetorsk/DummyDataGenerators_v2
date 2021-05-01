using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyDataGenerators.DTO.DummyTransactionDTO;

namespace DummyDataGenerators.TransactionGenerator
{
    public class DummyTransactionGenerator : IGenerator<DummyTransaction>
    {
        #region fields

        private readonly string[] _customerNames = {
        "Lillehammer Kommune",
            "Bodø Kommune",
            "Lillestrøm IKS",
            "Norkart AS",
            "IKOMM as",
            "Alvdal Kommune",
            "Vinje Kommune"
        };

        private readonly string[] _userNames = {
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

        private readonly string[] _transactionTypes = {
            "Data fra kunde",
            "Feilsituasjon",
            "Data fra felt eller web",
            "Data til kommunen"
        };

        private readonly string[] _applicationNames = {
            "VAtilsyn",
            "Gebyr",
            "Feiing",
            "Va",
            "MinRenovasjon",
            "RenovasjonApp"
        };

        private readonly string[] _dataExamples = {
            @"Ren_Kjoereplan_Stoppepunkt_Aktivitet. Rader:1. EndringsNrMax:4412790. Tid:0.3593858s",
            @"ImportPrivatVa2Jobb.StartJobben feilet: (Feil ved kjøring av SQL (kode 800).) -> (Feil ved kjøring av SQL (kode 800).) -> (Feil ved kjøring av SQL (kode 800).) Stacktrace: Server stack trace: at System.ServiceModel.Channels.ServiceChannel.HandleReply(ProxyOperationRuntime operation, ProxyRpc& rpc) at System.ServiceModel.Channels.ServiceChannel.Call(String action, Boolean oneway, ProxyOperationRuntime operation, Object[] ins, Object[] outs, TimeSpan timeout) at System.ServiceModel.Channels.ServiceChannelProxy.InvokeService(IMethodCallMessage methodCall, ProxyOperationRuntime operation) at System.ServiceModel.Channels.ServiceChannelProxy.Invoke(IMessage message) Exception rethrown at [0]: at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg) at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type) at IVaPrivatServiceEkstern.UpdateAnleggEkstern(VaPrivatEksterntAnleggDto anleggEksternDto) at VaPrivatServiceEksternClient.UpdateAnleggEkstern(VaPrivatEksterntAnleggDto anleggEksternDto) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\KomtekServices\Proxy\VaPrivatEksternProxy.cs:line 925 at KomTek.Sky.Agent.Jobber.ImportPrivatVa2Jobb.<>c__DisplayClass12_1.<ImporterAnleggsendringerVap>b__2(IVaPrivatServiceEkstern klient) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportPrivatVa2Jobb.cs:line 115 at KomTek.Sky.Agent.Data.KomtekServiceHjelper.Using(Action`1 action, KundeModel kundemodell) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Data\KomtekServiceHjelper.cs:line 45 at KomTek.Sky.Agent.Jobber.ImportPrivatVa2Jobb.ImporterAnleggsendringerVap(String kundeId, String skybrukernavn, KundeModel kundeModel) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportPrivatVa2Jobb.cs:line 135 at KomTek.Sky.Agent.Jobber.ImportPrivatVa2Jobb.StartJobben(KundeModel kundemodell) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportPrivatVa2Jobb.cs:line 69",
            @"3966,176480,B : 3966,176480,B : FEILET! Årsak fra servicelaget :Bestillingen kvittert.",
            @"Get Fraksjoner. Kommunenr: 1535",
            @"Oppdatering av anleggsdata feilet, årsak: Identifikator: 4820. Feilmelding: Object reference not set to an instance of an object. . AnleggId:0. AnlLnr:4820",
            @"Import av synkjobb feilet: (Feil ved validering (kode 200).) -> (Feil ved validering (kode 200).) -> (Feil ved validering (kode 200).) Stacktrace: Server stack trace: ved System.ServiceModel.Channels.ServiceChannel.HandleReply(ProxyOperationRuntime operation, ProxyRpc& rpc) ved System.ServiceModel.Channels.ServiceChannel.Call(String action, Boolean oneway, ProxyOperationRuntime operation, Object[] ins, Object[] outs, TimeSpan timeout) ved System.ServiceModel.Channels.ServiceChannelProxy.InvokeService(IMethodCallMessage methodCall, ProxyOperationRuntime operation) ved System.ServiceModel.Channels.ServiceChannelProxy.Invoke(IMessage message) Exception rethrown at [0]: ved System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg) ved System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type) ved Nkgs.Komtek.SynkEksternProxy.ISynkServiceEkstern.PerformSynk(Int32 synkJobId) ved Nkgs.Komtek.SynkEksternProxy.SynkServiceEksternClient.PerformSynk(Int32 synkJobId) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\KomtekServices\Proxy\SynkEksternProxy.cs:linje 275 ved KomTek.Sky.Agent.Jobber.ImportSynkJobb.<>c__DisplayClass10_1.<StartJobben>b__1(ISynkServiceEkstern client) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportSynkjobb.cs:linje 58 ved KomTek.Sky.Agent.Data.KomtekServiceHjelper.Using(Action`1 action, KundeModel kundemodell) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Data\KomtekServiceHjelper.cs:linje 109 ved KomTek.Sky.Agent.Jobber.ImportSynkJobb.StartJobben(KundeModel kundemodell) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportSynkjobb.cs:linje 58",
            @"KT_MA_Matrikkelenhet. Rader:1. EndringsNrMax:32246. Tid:0,0624621s",
            @"VAP_Komponent_KT_MA_Bruksenhet. Rader:1. EndringsNrMax:571860. Tid:0,4388113s"
        };

        #endregion

        private DateTime _start;
        private Random RNG { get; set; }
        public string TransactionID => RNG.Next(999999999).ToString("D9");
        public string CustomerName => _customerNames[RNG.Next(_customerNames.Length)];
        public string UserName => _userNames[RNG.Next(_userNames.Length)];
        public string TransactionType => _transactionTypes[RNG.Next(_transactionTypes.Length)];
        public string TransactionData => _dataExamples[RNG.Next(_dataExamples.Length)];
        public string Application => _applicationNames[RNG.Next(_applicationNames.Length)];

        public DateTime Date => _start.AddDays(RNG.Next((DateTime.Today - _start).Days)).AddHours(RNG.Next(24)).AddMinutes(RNG.Next(60)).AddSeconds(RNG.Next(60));


        public DummyTransactionGenerator()
        {
            _start = new DateTime(2018, 1, 1);
            RNG = new Random();
        }

        public DummyTransaction Generate()
        {
            DummyTransaction transaction = new() { 
                Id = TransactionID,
                Kundenavn = CustomerName,
                Bruker = UserName,
                Type = TransactionType,
                Data = TransactionData,
                Applikasjon = Application,
                Dato = Date
            };

            return transaction;
        }
    }
}
