using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS.hardware.cmd
{
    class cmdgui
    {
        public static void draw(ConsoleColor color)
        {
            string pixel = "██";

            Console.ForegroundColor = color;
            Console.WriteLine(pixel);
        }

    }   
}
