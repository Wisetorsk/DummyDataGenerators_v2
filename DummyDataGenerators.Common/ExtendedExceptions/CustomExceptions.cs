using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerators.Common.ExtendedExceptions
{
    class YouDoneGoofedException : Exception 
    {
        public YouDoneGoofedException(string message) : base (Oof(message))
        {
            
        }

        private static string Oof(string original)
        {
            return "OOF! You done goofed...\n" + original;
        }
    }


    class BooBooError : Exception
    {
        public BooBooError(string message) : base (IdidA(message))
        {

        }

        private static string IdidA(string original)
        {
            return "Marius did a boo boo...\n" + original;
        }
    }


    public enum CustomErrorCodes 
    {
        MARIUS_DID_A_BOO_BOO = 542,
        YOU_DONE_GOOFED = 469
    }
}
