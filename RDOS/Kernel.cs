using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;
using System.IO;

namespace RobDEV_DOS
{
    public class Kernel : Sys.Kernel
    {
        string VersionNum = "0.1";
        string Versiont = "A";
        protected override void BeforeRun()
        {
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("RDOS Type help for commands!");
        }

        protected override void Run()
        {

            Console.Write("#Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
            //File
            foreach (string a in input.Split('\n'))
            {
                if (a.StartsWith("mkdir "))
                {
                    Sys.FileSystem.VFS.VFSManager.CreateDirectory("0:" + a.Substring(6));
                    Console.WriteLine("Done!");
                }
                if (a.StartsWith("mkfile "))
                {
                    Sys.FileSystem.VFS.VFSManager.CreateFile("0:" + a.Substring(7));
                    //Sys.FileSystem.VFS.VFSManager.CreateFile("0:\file.txt");
                    Console.WriteLine("Done!");
                }
                if (a.StartsWith("deldir "))
                {
                    Sys.FileSystem.VFS.VFSManager.DeleteDirectory("0:" + a.Substring(8), true);
                    Console.WriteLine("Done!");
                }
                if (a.StartsWith("delfile "))
                {
                    Sys.FileSystem.VFS.VFSManager.DeleteDirectory("0:" + a.Substring(9), true);
                    Console.WriteLine("Done!");
                }


                if (a.StartsWith("run "))
                {
                    string program = Sys.FileSystem.VFS.VFSManager.GetFile("0:\\program.txt").ToString();
                    RDOS.hardware.Program.Load(program);
                }

                if (a.StartsWith("mkprogram "))
                {
                    
                    Sys.FileSystem.VFS.VFSManager.CreateFile("0:\\program.txtaaa");
                    StreamWriter file = new StreamWriter("0:\\program.txt");
                    file.WriteLine(a.Substring(11));
                    file.Close();
                }
                if (a.StartsWith("print "))
                {
                    Console.Write(a.Substring(6));
                }

                if (a.StartsWith("randomnumber"))
                {
                    var ran = new AIC_Framework.Random();
                    ran.Next(0, 999999999);
                    string num = ran.ToString();
                    Console.WriteLine(num);
                  
                }




                if (a.StartsWith("code editor "))
                {
                    Console.Clear();
                    AIC_Framework.AConsole.Menu.Reset();
                    RDOS.CodeEditor.Run(a.Substring(13));
                    
                }

                if (input == "gui")
                {
                    Console.Clear();
                 
                    RDOS.gui.gl.gll();
                }

                if (input == "files")
                {
                    string Files = Sys.FileSystem.VFS.VFSManager.InternalGetFileDirectoryNames("0:\\", "0:\\", "", true, true, System.IO.SearchOption.AllDirectories).ToString();
                    Console.WriteLine(Files);
                }
                if (a.StartsWith("speaker a"))
                {
                    AIC.Core.PCSpeaker.sound_on();
                    AIC.Core.PCSpeaker.Beep(x);
                    AIC.Core.PCSpeaker.sound_off();
                }
                if (input == "about")
                {
                    string ram = AIC.Core.GetRAM.GetAmountOfRAM.ToString();
                    Console.WriteLine("Version:" + VersionNum + Versiont);
                    Console.WriteLine("Ram Memory:" + ram);
                }
                if (input == "shutdown")
                {
                    AIC.Core.ACPI.Shutdown();
                }
                if (input == "reboot")
                {
                    AIC.Core.ACPI.Reboot();
                }
                if (input == "time")
                {
                    string time = AIC.Hardware.RTC.Now.GetTime(AIC.Hardware.RTC.Now.TimeFormat.hh_mm_ss);
                    string date = AIC.Hardware.RTC.Now.GetDate(AIC.Hardware.RTC.Now.DateFormat.DD_MM_YYYY);
                    Console.WriteLine("time:" + time);
                    Console.WriteLine("date:" + date);

                }
                if (input == "test")
                {
                    AIC_Framework.Bluescreen.Init("RD 0001", "cannot enter undone things", true);

                }

                if (input == "RobDEV Basic")
                {
                    AIC_Framework.Bluescreen.Init("RD 0001", "cannot enter undone things", true);

                }



                if (input == "help")
                {
                    Console.WriteLine("mkdir 0:/dirname  creats a directory");
                    Console.WriteLine("mkfile 0:/filename  creats a file");
                    Console.WriteLine("deldir 0:/dirname  delets a directory");
                    Console.WriteLine("delfile 0:/filename  delets a file");
                    Console.WriteLine("files  shows all files and directorys");
                    Console.WriteLine("speaker play a sound");
                    Console.WriteLine("about  shows all the system version and ram memory");
                    Console.WriteLine("time shows the time and date");
                    Console.WriteLine("reboot  reboots the computer");
                    Console.WriteLine("shutdown shutdown the computer");




                }
            }


        }


    }
}
