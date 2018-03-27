using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS.OS.hardware
{
    class Program
    {
        public static void Load(string Code)
        {


            foreach (string a in Code.Split('\n'))
            {
                if (a.StartsWith("1: print "))
                {
                    string input = a;

                }
                if (a.StartsWith("2: print "))
                {
                    Console.Write(a.Substring(9));
                }
                if (a.StartsWith("3: print "))
                {
                    Console.Write(a.Substring(9));
                }
                if (a.StartsWith("4: print "))
                {
                    Console.Write(a.Substring(9));
                }
                if (a.StartsWith("5: print "))
                {
                    Console.Write(a.Substring(9));
                }

            }
        }
    }
}
