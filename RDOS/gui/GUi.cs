using Cosmos.HAL;
using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDOS
{
    class GUi
    {

       static Canvas canvas;
        public static void init(int wich)
        {
           
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(Color.Black);
            canvas.Mode = new Mode(800, 600, ColorDepth.ColorDepth32);
        }
        public static void DrawCircle(int x,int y, int z ,int c)
        {
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);
            Pen pen3 = new Pen(Color.Green);
            Pen pen4 = new Pen(Color.Blue);
            Pen pen5 = new Pen(Color.Yellow);
            Pen pen6 = new Pen(Color.Cyan);
            Pen pen7 = new Pen(Color.Purple);
            Pen pen8 = new Pen(Color.White);
            if (c == 1)
            {
                canvas.DrawCircle(pen1, x, y, z);
            }
            if (c == 2)
            {
                canvas.DrawCircle(pen2, x, y, z);
            }
            if (c == 3)
            {
                canvas.DrawCircle(pen3, x, y, z);
            }
            if (c == 4)
            {
                canvas.DrawCircle(pen4, x, y, z);
            }
            if (c == 5)
            {
                canvas.DrawCircle(pen5, x, y, z);
            }
            if (c == 6)
            {
                canvas.DrawCircle(pen6, x, y, z);
            }
            if (c == 7)
            {
                canvas.DrawCircle(pen7, x, y, z);
            }
            if (c == 8)
            {
                canvas.DrawCircle(pen8, x, y, z);
            }
        }

        public static void DrawLine(int x, int y, int x2, int y2, int c)
        {
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);
            Pen pen3 = new Pen(Color.Green);
            Pen pen4 = new Pen(Color.Blue);
            Pen pen5 = new Pen(Color.Yellow);
            Pen pen6 = new Pen(Color.Cyan);
            Pen pen7 = new Pen(Color.Purple);
            Pen pen8 = new Pen(Color.White);
            if (c == 1)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 2)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 3)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 4)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 5)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 6)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 7)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
            if (c == 8)
            {
                canvas.DrawLine(pen1, x, y, y2, x2);
            }
        }

        public static void DrawSquare(int x, int y, int size , int c)
        {
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);
            Pen pen3 = new Pen(Color.Green);
            Pen pen4 = new Pen(Color.Blue);
            Pen pen5 = new Pen(Color.Yellow);
            Pen pen6 = new Pen(Color.Cyan);
            Pen pen7 = new Pen(Color.Purple);
            Pen pen8 = new Pen(Color.White);
            Point point = new Point(x, y);
            if (c == 1)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 2)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 3)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 4)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 5)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 6)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 7)
            {
                canvas.DrawSquare(pen1, point, size);
            }
            if (c == 8)
            {
                canvas.DrawSquare(pen1, point, size);
                
            }
        }
    }
    
}
