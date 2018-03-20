using System;
using System.Collections.Generic;
using System.Text;
using RDOS.gui;

namespace RDOS.gui
{
    class Mousedriver
    {
        public static Cosmos.HAL.Mouse mouse = new Cosmos.HAL.Mouse();
        public static void Init(int width, int height)
        {
            mouse.Initialize((uint)width, (uint)height);
        }

        public static int GetX()
        {
            return mouse.X;
        }

        public static int GetY()
        {
            return mouse.Y;
        }

        public static void DrawMouse()
        {
            int x = GetX();
            int y = GetY();
            int color = 1;

            //if you try to draw something outside the screen it crashes
            if (x >= 0 && x < GUi.GetWidth() && y >= 0 && y < GUi.GetHeight())
            {
                if (GetLeftButton())
                    color = 4;
                else if (GetRightButton())
                    color = 5;
                else if (GetMiddleButton())
                    color = 6;

  GUi.SetPixel(x, y, color);
                GUi.SetPixel(x + 1, y, color);
                GUi.SetPixel(x + 2, y, color);
                GUi.SetPixel(x + 3, y, color);

                GUi.SetPixel(x, y + 1, color);
                GUi.SetPixel(x, y + 2, color);
                GUi.SetPixel(x, y + 3, color);

                GUi.SetPixel(x + 1, y + 1, color);
                GUi.SetPixel(x + 2, y + 2, color);
                GUi.SetPixel(x + 3, y + 3, color);
            }
        }

        public static bool GetLeftButton()
        {
            return mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Left;
        }

        public static bool GetRightButton()
        {
            return mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Right;
        }

        public static bool GetMiddleButton()
        {
            return mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Middle;
        }
    }
}
