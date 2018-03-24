using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS.OS.excutable
{
    class image
    {
        
        //2x2 image
        /*
         * 1 is black
         * 2 is red
         * 3 is green
         * 4 is blue
         * 5 is yellow
         * 6 is cyan
         * 7 is purple 
         * 8 is white
             */
        public static void load(string text)
        {
            foreach (string a in text.Split('\n'))
            {
                // 1x1
                if (a.Substring(0).StartsWith("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("8");
                }

                if (a.Substring(0).StartsWith("2"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("8");
                }

                if (a.Substring(0).StartsWith("3"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("8");
                }
                if (a.Substring(0).StartsWith("4"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("8");
                }

                if (a.Substring(0).StartsWith("5"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("8");
                }
                if (a.Substring(0).StartsWith("6"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("8");
                }
                if (a.Substring(0).StartsWith("7"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("8");
                }
                if (a.Substring(0).StartsWith("8"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("8");
                }

                // 1x2
                if (a.Substring(1).StartsWith("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("8");
                }

                if (a.Substring(1).StartsWith("2"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("8");
                }

                if (a.Substring(1).StartsWith("3"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("8");
                }
                if (a.Substring(1).StartsWith("4"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("8");
                }

                if (a.Substring(1).StartsWith("5"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("8");
                }
                if (a.Substring(1).StartsWith("6"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("8");
                }
                if (a.Substring(1).StartsWith("7"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("8");
                }
                if (a.Substring(1).StartsWith("8"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("8");
                }
                // 2x1
                if (a.Substring(2).StartsWith("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("8");
                }

                if (a.Substring(2).StartsWith("2"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("8");
                }

                if (a.Substring(2).StartsWith("3"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("8");
                }
                if (a.Substring(2).StartsWith("4"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("8");
                }

                if (a.Substring(2).StartsWith("5"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("8");
                }
                if (a.Substring(2).StartsWith("6"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("8");
                }
                if (a.Substring(2).StartsWith("7"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("8");
                }
                if (a.Substring(2).StartsWith("8"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("8");
                }
                // 2x2
                if (a.Substring(3).StartsWith("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("8");
                }

                if (a.Substring(3).StartsWith("2"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("8");
                }

                if (a.Substring(3).StartsWith("3"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("8");
                }
                if (a.Substring(3).StartsWith("4"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("8");
                }

                if (a.Substring(3).StartsWith("5"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("8");
                }
                if (a.Substring(3).StartsWith("6"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("8");
                }
                if (a.Substring(3).StartsWith("7"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("8");
                }
                if (a.Substring(3).StartsWith("8"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("8");
                }
            }
        }
    }
}
