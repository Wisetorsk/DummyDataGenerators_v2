using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyErrorDTO
{
    public class DummyError : IDummyError
    {
        public DateTime? Date { get; set; }
        public string ErrorMessage { get; set; }
        public string Path { get; set; }
        public string OS { get; set; }
        public Severity ErrorSeverity { get; set; }
        public string ErrorCode { get; set; }
        public string IP { get; set; }
        public string Comment { get; set; }
    }
}
