using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.DTO.DummyErrorDTO
{
    public enum ErrorClass
    {
        ImportPrivatVa2Jobb = 0,
        ExportError = 1,
        ImportError = 2,
        UpdateError = 3,
        MethodError = 4,
        GeneralConnectionError = 5,
        ConnectionInterruptedError = 6,
        NoConnectionError = 7
    }
}
