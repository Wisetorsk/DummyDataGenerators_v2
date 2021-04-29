using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyDataGenerators.DTO.DummyErrorDTO;

namespace DummyDataGenerators.ErrorGenerator
{
    public class DummyErrorGenerator_V2
    {

        private DateTime _start = new DateTime(2020, 1, 1);
        public int Range { get; set; }
        public Random Rng { get; }
        public Guid ID => Guid.NewGuid();
        public string CustomerName => _customerNameExamples[Rng.Next(_customerNameExamples.Length)];
        public string UserName => _userNameExamples[Rng.Next(_userNameExamples.Length)];
        public DateTime Date => _start.AddDays(Range).AddHours(Rng.Next(24)).AddMinutes(Rng.Next(60)).AddSeconds(Rng.Next(60));
        public string Type => _typeExamples[Rng.Next(_typeExamples.Length)];
        public string Data => _dataExamples[Rng.Next(_dataExamples.Length)];
        public Severity ErrorSeverity => (Severity)Rng.Next(1, 5);
        public ErrorClass ErrorType => (ErrorClass)Rng.Next(8);

        private static readonly string[] _dataExamples = {
            @"Oppdatering av anleggsdata feilet, årsak: Identifikator: 4820. Feilmelding: Object reference not set to an instance of an object. . AnleggId:0. AnlLnr:4820",
            @"Import av synkjobb feilet: (Feil ved validering (kode 200).) -> (Feil ved validering (kode 200).) -> (Feil ved validering (kode 200).) Stacktrace: Server stack trace: ved System.ServiceModel.Channels.ServiceChannel.HandleReply(ProxyOperationRuntime operation, ProxyRpc& rpc) ved System.ServiceModel.Channels.ServiceChannel.Call(String action, Boolean oneway, ProxyOperationRuntime operation, Object[] ins, Object[] outs, TimeSpan timeout) ved System.ServiceModel.Channels.ServiceChannelProxy.InvokeService(IMethodCallMessage methodCall, ProxyOperationRuntime operation) ved System.ServiceModel.Channels.ServiceChannelProxy.Invoke(IMessage message) Exception rethrown at [0]: ved System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg) ved System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type) ved Nkgs.Komtek.SynkEksternProxy.ISynkServiceEkstern.PerformSynk(Int32 synkJobId) ved Nkgs.Komtek.SynkEksternProxy.SynkServiceEksternClient.PerformSynk(Int32 synkJobId) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\KomtekServices\Proxy\SynkEksternProxy.cs:linje 275 ved KomTek.Sky.Agent.Jobber.ImportSynkJobb.<>c__DisplayClass10_1.<StartJobben>b__1(ISynkServiceEkstern client) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportSynkjobb.cs:linje 58 ved KomTek.Sky.Agent.Data.KomtekServiceHjelper.Using(Action`1 action, KundeModel kundemodell) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Data\KomtekServiceHjelper.cs:linje 109 ved KomTek.Sky.Agent.Jobber.ImportSynkJobb.StartJobben(KundeModel kundemodell) i D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportSynkjobb.cs:linje 58",
            @"Feil under eksport. Venter og prøver igjen. System.Data.SqlClient.SqlException (0x80131904): A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified) at System.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, SqlCredential credential, Object providerInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString userConnectionOptions, SessionData reconnectSessionData, DbConnectionPool pool, String accessToken, Boolean applyTransientFaultHandling, SqlAuthenticationProviderManager sqlAuthProviderManager) at System.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, DbConnectionPoolKey poolKey, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection, DbConnectionOptions userOptions) at System.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnectionPool pool, DbConnection owningObject, DbConnectionOptions options, DbConnectionPoolKey poolKey, DbConnectionOptions userOptions) at System.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection) at System.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection) at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, UInt32 waitForMultipleObjectsTimeout, Boolean allowCreate, Boolean onlyOneCheckConnection, DbConnectionOptions userOptions, DbConnectionInternal& connection) at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal& connection) at System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection) at System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions) at System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions) at System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry) at System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry) at System.Data.SqlClient.SqlConnection.Open() at KomTek.Sky.Agent.Data.DataHjelper.GetMaxChangetrackDatabase(String connectionstring) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Data\DataHjelper.cs:line 124 at KomTek.Sky.Agent.Jobber.Eksportjobber.EksportJobb.DatabasenErEndret(String connectionstring, String kundeId) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\Eksportjobber\EksportJobb.cs:line 213 at KomTek.Sky.Agent.Jobber.Eksportjobber.EksportJobb.Start(KundeModel kundemodell) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\Eksportjobber\EksportJobb.cs:line 61 ClientConnectionId:00000000-0000-0000-0000-000000000000 Error Number:-1,State:0,Class:20",
            @"ImportPrivatVa2Jobb.StartJobben feilet: (The underlying provider failed on Open.) -> (The underlying provider failed on Open.) -> (The underlying provider failed on Open.) Stacktrace: Server stack trace: at System.ServiceModel.Channels.ServiceChannel.ThrowIfFaultUnderstood(Message reply, MessageFault fault, String action, MessageVersion version, FaultConverter faultConverter) at System.ServiceModel.Channels.ServiceChannel.HandleReply(ProxyOperationRuntime operation, ProxyRpc& rpc) at System.ServiceModel.Channels.ServiceChannel.Call(String action, Boolean oneway, ProxyOperationRuntime operation, Object[] ins, Object[] outs, TimeSpan timeout) at System.ServiceModel.Channels.ServiceChannelProxy.InvokeService(IMethodCallMessage methodCall, ProxyOperationRuntime operation) at System.ServiceModel.Channels.ServiceChannelProxy.Invoke(IMessage message) Exception rethrown at [0]: at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg) at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type) at KomTek.Sky.Agent.PrivatVaTjenesteWcf.IPrivatVaService.GetAvvikData() at KomTek.Sky.Agent.PrivatVaTjenesteWcf.PrivatVaServiceClient.GetAvvikData() in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Service References\PrivatVaTjenesteWcf\Reference.cs:line 129 at KomTek.Sky.Agent.Jobber.ImportPrivatVa2Jobb.<>c__DisplayClass13_0.<ImporterAvvikVap>b__0(IPrivatVaService x) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportPrivatVa2Jobb.cs:line 151 at KomTek.Sky.Agent.Data.ServiceHjelper.Using(Action`1 action, String kundeId) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Data\ServiceHjelper.cs:line 211 at KomTek.Sky.Agent.Jobber.ImportPrivatVa2Jobb.ImporterAvvikVap(String kundeId, String skybrukernavn, KundeModel kundeModel) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportPrivatVa2Jobb.cs:line 152 at KomTek.Sky.Agent.Jobber.ImportPrivatVa2Jobb.StartJobben(KundeModel kundemodell) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\ImportPrivatVa2Jobb.cs:line 68",
            @"EksportNoklerJobb.Start feilet: (The underlying connection was closed: A connection that was expected to be kept alive was closed by the server.) -> (The underlying connection was closed: A connection that was expected to be kept alive was closed by the server.) -> (Unable to read data from the transport connection: A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond.) Stacktrace: Server stack trace: at System.ServiceModel.Channels.HttpChannelUtilities.ProcessGetResponseWebException(WebException webException, HttpWebRequest request, HttpAbortReason abortReason) at System.ServiceModel.Channels.HttpChannelFactory`1.HttpRequestChannel.HttpChannelRequest.WaitForReply(TimeSpan timeout) at System.ServiceModel.Channels.RequestChannel.Request(Message message, TimeSpan timeout) at System.ServiceModel.Dispatcher.RequestChannelBinder.Request(Message message, TimeSpan timeout) at System.ServiceModel.Channels.ServiceChannel.Call(String action, Boolean oneway, ProxyOperationRuntime operation, Object[] ins, Object[] outs, TimeSpan timeout) at System.ServiceModel.Channels.ServiceChannelProxy.InvokeService(IMethodCallMessage methodCall, ProxyOperationRuntime operation) at System.ServiceModel.Channels.ServiceChannelProxy.Invoke(IMessage message) Exception rethrown at [0]: at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg) at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type) at KomTek.Sky.Agent.FellesDataTjenesteWcf.IFellesData.ErTidForRyddejobb(String kundeid) at KomTek.Sky.Agent.FellesDataTjenesteWcf.FellesDataClient.ErTidForRyddejobb(String kundeid) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Service References\FellesDataTjenesteWcf\Reference.cs:line 113 at KomTek.Sky.Agent.Jobber.Eksportjobber.EksportNoklerJobb.<>c__DisplayClass8_0.<Start>b__0(IFellesData fellesdata) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\Eksportjobber\EksportNoklerJobb.cs:line 38 at KomTek.Sky.Agent.Data.ServiceHjelper.Using(Action`1 action, String kundeId) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Data\ServiceHjelper.cs:line 71 at KomTek.Sky.Agent.Jobber.Eksportjobber.EksportNoklerJobb.Start(KundeModel kundemodell) in D:\Builds\27084\71\src\KomTek.Sky.Feie.Agent\Jobber\Eksportjobber\EksportNoklerJobb.cs:line 38",
            @"Fant ingen komponent tilknyttet anleggsLnr 803,db2c8b3e-d1d6-4cab-b7b3-a827cee1e1f0"
        };

        private static readonly string[] _typeExamples = {
            "Feilsituasjon"
        };

        private static readonly string[] _customerNameExamples = {
            "Steigen kommune",
            "FolloRen",
            "Tysfjord_Narvik",
            "Tonsberg nye kommune",
            "VOR",
            "Soerum_kurs",
            "Donna kommune",
            "Reno-Vest"
        };

        private static readonly string[] _userNameExamples = {
            "Steigen",
            "FolloRen",
            "TysVarv",
            "Tonsberg_service",
            "VOR",
            "sorumkurs",
            "Donna",
            "RenoVestVest"
        };

        public DummyErrorGenerator_V2()
        {
            Range = (DateTime.Today - _start).Days;
            Rng = new();
        }

        public ErrorData Generate()
        {
            return new ErrorData
            {
                ID = ID,
                Kundenavn = CustomerName,
                Data = Data,
                Type = Type,
                Dato = Date,
                Bruker = UserName,
                AlvorlighetsGrad = ErrorSeverity,
                FeilKlasse = ErrorType
            };
        }

    }
}
