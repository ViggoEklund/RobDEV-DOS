using System;
using System.Collections.Generic;
using System.Text;

namespace RDOS.gui
{
    class mouse
    {
        public static bool left()
        {
            var m = new Cosmos.HAL.Mouse();
            if (Cosmos.HAL.Mouse.MouseState.Left == true)
            {

            }
        }
    }
}
