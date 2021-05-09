using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.Common.Userobjects
{
    public class User
    {

        public Visible Visibilities { get; set; }
        public User()
        {
            Visibilities = new();
        }

        public class Visible
        {
            public bool Inputfield { get; set; } = false;
        }
    }
}
