using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyErrorDTO
{
    public interface IDummyError
    {
        DateTime? Date { get; set; }
        string ErrorMessage { get; set; }
        string Path { get; set; }
        string OS { get; set; }
        Severity ErrorSeverity { get; set; }
        string ErrorCode { get; set; }
        byte[] IP { get; set; }
        string Comment { get; set }
    }
}
