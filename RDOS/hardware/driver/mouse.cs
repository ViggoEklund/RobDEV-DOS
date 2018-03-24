using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;
using RDOS.gui;

namespace RDOS.gui
{
    class Mousedriver
    {
        static Canvas canvas;
        public static Cosmos.HAL.Mouse mouse = new Cosmos.HAL.Mouse();
        public static Cosmos.HAL.Mouse m = new Cosmos.HAL.Mouse();
        public static void init()
        {

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
        public static void drawmouse()
        {
            Pen pen = new Pen(Color.White);
            canvas.DrawFilledRectangle(pen, RDOS.gui.Mousedriver.m.X, RDOS.gui.Mousedriver.m.Y, 50, 50);
        }
    
    }
}
