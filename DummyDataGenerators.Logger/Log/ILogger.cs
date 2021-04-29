using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DummyDataGenerators.Logger.Log
{
    interface ILogger
    {

        string FileName { get; }
        string FilePath { get; }
        string FullPath { get; }
        void Log(string data);
        void LogHttpRequest(HttpRequest request, string additionalInformation, int logMode, string response = null);
    }
}
