using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS
{
    class RBasic
    {
        public static void loop()
        {
            Console.Write("RBasic: ");
            string input = Console.ReadLine();
            foreach (string a in input.Split('\n'))
            {
                if (a.StartsWith("print "))
                {
                    Console.WriteLine(a.Substring(6));
                }

                if (a.StartsWith("exit"))
                {
                    Cosmos.HAL.Power.ACPIShutdown();
                }
                if (a.StartsWith("mkdir "))
                {
                    Sys.FileSystem.VFS.VFSManager.CreateDirectory("0:" + a.Substring(6));
                    Console.WriteLine(a.Substring(6) + "Created!");
                }
                if (a.StartsWith("mkfile "))
                {
                    Sys.FileSystem.VFS.VFSManager.CreateFile("0:" + a.Substring(7));
                    Console.WriteLine(a.Substring(7) + "Created!");
                }

            }


                loop();
        }
    }
}
