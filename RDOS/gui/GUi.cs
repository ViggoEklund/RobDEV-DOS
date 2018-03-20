using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDOS
{
    class GUi
    {
        protected static VGAScreen screen = new VGAScreen();
        private static int width, height;
        private static byte[] buffer;
        private static byte[] screenBuffer;

        public static void Init()
        {

        }

        public static void SetPixel(int x, int y, int c)
        {
            buffer[y * width + x] = (byte)c;
        }

        public static byte GetPixel(int x, int y)
        {
            return (byte)screen.GetPixel320x200x8((uint)x, (uint)y);
        }

        public static void Clear()
        {
            Clear(0);
        }

        public static void Clear(int c)
        {
            screen.Clear(c);
        }

        public static int GetWidth()
        {
            return width;
        }

        public static int GetHeight()
        {
            return height;
        }

        public static void SetPixelRaw(int x, int y, int c)
        {
            screen.SetPixel320x200x8((uint)x, (uint)y, (uint)c);

        }

        public static void ReDraw() 
        {
            int c = 0;
            byte cl;
            byte dl;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cl = screenBuffer[c]; 
                    dl = buffer[c];
                    if (cl > dl || cl < dl) 
                    {
                        screen.SetPixel320x200x8((uint)x, (uint)y, buffer[c]);
                        screenBuffer[c] = buffer[c];
                    }
                    buffer[c] = 0;
                    c++;
                }
            }
        }

        public static void DrawFilledRectangle(int x0, int y0, int x1, int y1, int color)
        {
            for (int i = 0; i < x1 - x0; i++)
            {
                for (int h = 0; h < y1 - y0; h++)
                {
                    SetPixel((x0 + i), (y0 + h), color);
                }
            }
        }
    }
    
}
