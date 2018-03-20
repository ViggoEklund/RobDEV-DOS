using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.HAL;

namespace RDOS.hardware
{
    public class KeyboardDriver
    {
            public PS2Keyboard keyboard;

            public KeyboardDriver()
            {
                keyboard = new PS2Keyboard();
            }

            public String readKey()
            {

            }

    }
}
