using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyDataGenerators.API
{
    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }

    public class TableNames
    {
        public string Errors { get; set; }
        public string Transactions { get; set; }
        public string Customers { get; set; }
        public string Access_Permissions { get; set; }
        public string Agents { get; set; }
    }
}
