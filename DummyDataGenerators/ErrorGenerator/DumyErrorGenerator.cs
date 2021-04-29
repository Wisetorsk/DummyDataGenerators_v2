using System;
using DummyDataGenerators.DTO.DummyErrorDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.ErrorGenerator
{
    public static class DummyErrorGenerator
    {
        public static DateTime Start { get; set; } = new DateTime(2019, 1, 1);
        public static int Range { get; set; } = (DateTime.Today - Start).Days;
        private static Random Rng { get; set; } = new Random(); // Naming violation???

        private static readonly string[] _drive = new string[] {
            "C:",
            "D:",
            "E:",
            "F:",
            "G:"
        };

        private static readonly string[] _firstIndex = new string[] {
            "/Server",
            "/Client",
            "/RoomA",
            "/Host",
            "/Windows",
            "/Home"
        };

        private static readonly string[] _secondIndex = new string[]
        {
            "/Norkart",
            "/KommuneA",
            "/KommuneB",
            "/KommuneC",
            "/KommuneD",
            "/KommuneE",
            "/Brannforebygging",
            "/Kommuneinnsikt"
        };

        private static readonly string[] _thirdIndex = new string[]
        {
            "/Brannforebygging.exe",
            "/Kundeinnsikt.exe",
            "/KomtekForvaltning.exe",
            "/SlamAPI.exe",
            "/VaTilsyn.exe"
        };

        private static readonly string[] _os = new string[] {
            "Windows_UnknownVersion",
            "Linux_UnknownDistro",
            "WinServer",
            "UbuntuServer",
            "FreeBSD",
            "ChromeOS",
            "Win10",
            "Win8",
            "Win7"
        };

        private static readonly string[] _messages = new string[] {
            "API_Error",
            "NullReferenceError",
            "Request Timeout"

        };

        private static readonly int[] _htmlEC = new int[] {
            100,101,203,204,205,206,300,301,302,303,304,305,400,401,402,403,
            404,405,406,407,408,409,410,411,412,413,414,415,418,500,501,502,503,504,505
        };

        public static string Comment { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt neque nec ante eleifend auctor. Quisque ultricies sed purus vel blandit. In et dapibus diam, ac faucibus felis. Integer vehicula condimentum condimentum. Proin vitae urna eu nulla auctor sollicitudin ut ut sem. Aliquam euismod placerat neque, eu tristique orci molestie sodales. Sed consectetur lorem ornare felis tristique, ut venenatis ex lobortis. Duis consectetur urna tortor, at vestibulum magna tristique vel. Suspendisse tempor orci in eros malesuada pellentesque. Donec facilisis nisl eu libero pretium tristique. Praesent at laoreet leo. Nam volutpat bibendum dictum. Nunc vehicula iaculis nisl ac molestie. Praesent nec orci leo. Suspendisse eros eros, iaculis vel scelerisque ac, suscipit at ipsum. Mauris eget tortor facilisis, venenatis ipsum ut, tempor diam.".Replace(",", "&#44");
        private static byte[] _codeArray => new byte[5] { (byte)Rng.Next(256), (byte)Rng.Next(256), (byte)Rng.Next(256), (byte)Rng.Next(256), (byte)Rng.Next(256) };
        public static string Path => _drive[Rng.Next(_drive.Length)] + _firstIndex[Rng.Next(_firstIndex.Length)] + _secondIndex[Rng.Next(_secondIndex.Length)] + _thirdIndex[Rng.Next(_thirdIndex.Length)];
        public static int[] IP => new int[4] { Rng.Next(60, 200), Rng.Next(70, 255), Rng.Next(100), Rng.Next(255) };
        public static string RandIP => $"{Rng.Next(60, 200)}.{Rng.Next(70, 255)}.{Rng.Next(100)}.{Rng.Next(255)}";
        public static string Message => _messages[Rng.Next(_messages.Length)];
        public static string OS => _os[Rng.Next(_os.Length)];
        public static DateTime Date => Start.AddDays(Rng.Next(Range)).AddHours(Rng.Next(0, 24)).AddMinutes(Rng.Next(0, 60)).AddSeconds(Rng.Next(0, 60));
        public static int HTMLError => _htmlEC[Rng.Next(_htmlEC.Length)];
        public static string EC => BitConverter.ToString(_codeArray).Replace("-", ".");
        public static int Severity => Rng.Next(1, 5);
        public static int ErrorNumber = 0; //Increment if needed

        public static DummyError GenerateError()
        {
            return new DummyError {
                Date = Date,
                ErrorMessage = Message,
                ErrorCode = EC,
                Path = Path,
                OS = OS,
                ErrorSeverity = (Severity)Severity,
                IP = RandIP,
                Comment = Comment
            };
        }

        public static new string ToString()
        {
            string msg = Message;
            return $"{Date}|{EC}|{OS}|{Path}|{((msg == "API_Error") ? $"API_Error {HTMLError}" : msg)}|{RandIP}|{Severity}|{Comment}";
        }

    }

}