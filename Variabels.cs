using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_1942
{
    public static class variables
    {
        public static int lifespublic = 3;
        public static int scorespublic;
        public static void resetscores()
        {
            scorespublic = 0;
        }
        public static void resetlifes()
        {
            lifespublic = 3;

        }
    }
}
