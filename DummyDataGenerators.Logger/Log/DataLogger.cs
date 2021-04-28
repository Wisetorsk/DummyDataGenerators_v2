using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.Logger.Log
{
    public class DataLogger : ILogger
    {
        //public StringBuilder LogString { get; set; }
        public string FileName { get; }
        public string FilePath { get; }
        public string FullPath => $"{FilePath}/{FileName}{_extention}";

        private string _extention = ".txt";


        public DataLogger(string filePath = null, string fileName = null)
        {
            FilePath = filePath ?? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
            FileName = fileName ?? "log";
        }

        public void Log(string data)
        {
            try
            {
                using StreamWriter sw = File.AppendText(FullPath);
                WriteLog(data, sw);
            } catch (Exception e)
            {
                Console.WriteLine("Error in Logger.Log: " + e.Message);
            }
        }

        private void WriteLog(string data, TextWriter writer)
        {
            try
            {
                writer.Write("\nLog: ");
                writer.WriteLine($"{DateTime.Now.ToLongTimeString()}\t{DateTime.Now.ToLongDateString()}");
                writer.WriteLine(data);
                writer.WriteLine("=========================================");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in logger.WriteLog: " + e.Message);
            }
        }
    }
}
