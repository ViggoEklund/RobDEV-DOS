using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS.hardware
{
    class Program
    {
        public static void Load(string Code)
        {
            foreach (string a in Code.Split('\n'))
            {
                if (a.StartsWith("print "))
                {
                    Console.Write(a.Substring(6));
                }

                if (a.StartsWith("shutdown"))
                {
                    AIC_Framework.userACPI.Shutdown();
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
        }
    }
}
