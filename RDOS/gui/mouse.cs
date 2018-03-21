using System;
using System.Collections.Generic;
using System.Text;
using RDOS.gui;

namespace RDOS.gui
{
    class Mousedriver
    {
        public static Cosmos.HAL.Mouse mouse = new Cosmos.HAL.Mouse();

        public static void init()
        {
            mouse.Initialize(800, 60);
        }

        public static int x()
        {
            return mouse.X;
        }

        public static int y()
        {
            return mouse.Y;
        }

        public static bool leftclick(int x, int y)
        {
            if (mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Left)
            {
                return true;
            }
            else
                return false;
        }
    
    }
}
