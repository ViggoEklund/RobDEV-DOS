using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS
{
    class testkeyboard
    {
        public static void test()
        {
            Console.WriteLine("Press A");
            if (RDOS.keyboard.Key_down(Cosmos.System.ConsoleKeyEx.A))
            {
                Console.WriteLine("Nice :)");

            }
        }
    }
}
