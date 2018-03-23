using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS
{
    class test
    {
        public static void tast()
        {
            if (RDOS.keyboard.Key_down(Sys.ConsoleKeyEx.A))
            {
                Console.WriteLine("a pressed");
            }
        }
    }
}
