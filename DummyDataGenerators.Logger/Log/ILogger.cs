using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.Logger.Log
{
    interface ILogger
    {

        string FileName { get; }
        string FilePath { get; }
        string FullPath { get; }
        void Log(string data);
        void LogHttpRequest(HttpRequestData request, int logMode);
    }
}
