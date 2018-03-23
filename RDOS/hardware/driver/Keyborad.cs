using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.HAL;

namespace RDOS
{
    public class keyboard
    {
        public static bool Key_down(Cosmos.System.ConsoleKeyEx key)
        {

            var key2 = Cosmos.System.KeyboardManager.ReadKey();
            if (key2.Key == key)
            {
                return true;
            }
            else return false;
        }

        public static bool Key_UP(Cosmos.System.ConsoleKeyEx key)
        {

            var key2 = Cosmos.System.KeyboardManager.ReadKey();
            if (key2.Key == key)
            {
                return false;
            }
            else return true;
        }

    }
}
