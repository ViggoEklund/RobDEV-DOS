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
                //prg values
                int value1 = 0;
                int value2 = 0;
                int value3 = 0;
                int value4 = 0;
                int value5 = 0;
                bool usev1 = false;
                bool usev2 = false;
                bool usev3 = false;
                bool usev4 = false;
                bool usev5 = false;

                //loadlines
                string codeline1 = a.Substring(0, a.LastIndexOf("1E") + 1);
                string codeline2 = a.Substring(codeline1.Length, a.LastIndexOf("2E") + 1);
                string codeline3 = a.Substring(codeline1.Length + codeline2.Length, a.LastIndexOf("3E") + 1);
                string codeline4 = a.Substring(codeline1.Length + codeline2.Length + codeline3.Length, a.LastIndexOf("4E") + 1);
                string codeline5 = a.Substring(codeline1.Length + codeline2.Length + codeline3.Length + codeline4.Length, a.LastIndexOf("5E") + 1);


                if (codeline1.StartsWith("print "))
                {
                    Console.WriteLine(a.Substring(6));
                }

                if (codeline1.StartsWith("input == "))
                {
                    string input = Console.ReadLine();
                }

                if (codeline1.StartsWith("num "))
                {
                    usev1 = true;
                }


            }


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
