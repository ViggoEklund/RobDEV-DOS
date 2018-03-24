using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.IO;
using Cosmos.System.Graphics;
using Cosmos.HAL;

namespace RobDEV_DOS
{
    public class Kernel : Sys.Kernel
    {
        public static Cosmos.HAL.Mouse m = new Cosmos.HAL.Mouse();
        Canvas canvas;
        string VersionNum = "0.1";
        string Versiont = "A";
        bool gui = false;
        protected override void BeforeRun()
        {
            
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            m.Initialize(320, 200);
            Console.Clear();
            Console.WriteLine("RDOS Type help for commands!");
            if (gui == true)
            {

                // Create new instance of FullScreenCanvas, using default graphics mode
                canvas = FullScreenCanvas.GetFullScreenCanvas();    // canvas = GetFullScreenCanvas(start);
                RDOS.gui.Mousedriver.init();

                /* Clear the Screen with the color 'Blue' */
                canvas.Clear(Color.DarkCyan);
            }
            
            
        }



        public static bool Click(int x, int y)
        {
            if (m.Buttons == Mouse.MouseState.Left)
            {
                if (x == m.X)
                {
                    if (y == m.Y)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        protected override void Run()
        {
            if (gui == true)
            {
                if (Click(1, 1))
                {
                    mDebugger.Send("1x 1y clicked!");
                }
                Pen pen = new Pen(Color.White);
                canvas.Mode = new Mode(320, 200, ColorDepth.ColorDepth32);
                canvas.DrawFilledRectangle(pen, m.X, m.Y, 20, 20);
                canvas.Clear(Color.DarkCyan);
            }
            if (gui == false)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("# 0: ");
                var input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("Text typed: ");
                Console.WriteLine(input);
                Console.ForegroundColor = ConsoleColor.White;
                //File
                foreach (string a in input.Split('\n'))
                {
                    if (a.StartsWith("image"))
                    {
                        string image = System.IO.File.ReadAllText(@"0:\image.img");
                        RDOS.OS.excutable.image.load(image);
                    }
                    if (a.StartsWith("mkimage "))
                    {
                        string[] text = { a.Substring(8) };
                        RDOS.VFS.write(@"0:\image.img", text);
                    }
                    if (a.StartsWith("mkdir "))
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory("0:\\" + a.Substring(6));
                        Console.WriteLine("Done!");
                    }
                    if (a.StartsWith("mkfile "))
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile("0:\\" + a.Substring(7));
                        //Sys.FileSystem.VFS.VFSManager.CreateFile("0:\file.txt");
                        Console.WriteLine("Done!");
                    }
                    if (a.StartsWith("deldir "))
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory("0:\\" + a.Substring(8), true);
                        Console.WriteLine("Done!");
                    }
                    if (a.StartsWith("delfile"))
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory("0:\\" + a.Substring(9), true);
                        Console.WriteLine("Done!");
                    }


                    if (a.StartsWith("run"))
                    {
                        string program = System.IO.File.ReadAllText(@"0:\program.prg");
                        RDOS.OS.hardware.Program.Load(program);
                    }

                    if (a.StartsWith("mkprogram "))
                    {
                        string[] text = { a.Substring(10) };
                        RDOS.VFS.write(@"0:\program.prg", text);
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
                        RDOS.OS.program.CodeEditor.ProgramCD.init(a.Substring(12));

                    }

                    if (input == "gui")
                    {
                        Console.Clear();

                        RDOS.gui.gl.gll();
                    }

                    if (input == "files")
                    {
                        string[] test1 = { "txt" };
                        string[] test2 = { "" };

                        RDOS.VFS.files("0:", test1, test2);
                    }



                    if (a.StartsWith("speaker"))
                    {
                        AIC.Core.PCSpeaker.sound_on();
                        AIC.Core.PCSpeaker.Beep(0x001);
                        AIC.Core.PCSpeaker.sound_off();

                    }
                    if (a.StartsWith("speaker C#"))
                    {
                        AIC.Core.PCSpeaker.sound_on();
                        AIC.Core.PCSpeaker.Beep(01);
                        AIC.Core.PCSpeaker.sound_off();
                    }
                    if (a.StartsWith("speaker D"))
                    {
                        AIC.Core.PCSpeaker.sound_on();
                        AIC.Core.PCSpeaker.Beep(02);
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
                        AIC_Framework.Bluescreen.Init("RD 0001", "Cannot enter test mode", true);
                        //RDOS.testkeyboard.test();
                    }

                    if (input == "rdbasic")
                    {
                        Console.Clear();
                        RDOS.RBasic.loop();
                    }





                    if (input == "help")
                    {
                        Console.WriteLine("mkdir 0:/dirname  creats a directory");
                        Console.WriteLine("mkfile 0:/filename  creats a file");
                        Console.WriteLine("deldir 0:/dirname  delets a directory");
                        Console.WriteLine("delfile 0:/filename  delets a file");
                        Console.WriteLine("files  shows all files and directorys");
                        Console.WriteLine("speaker c d and more play a sound");
                        Console.WriteLine("about  shows all the system version and ram memory");
                        Console.WriteLine("time shows the time and date");
                        Console.WriteLine("reboot  reboots the computer");
                        Console.WriteLine("shutdown shutdown the computer");
                        Console.WriteLine("rdbasic RobDEVBasic a simple programming lanuge");
                        Console.WriteLine("clear to clear the console");
                        Console.WriteLine("gui  to boot gui");
                        Console.WriteLine("mkprogram code here to make a program :)");
                        Console.WriteLine("run to run the program");
                        Console.WriteLine("mkimage to make a image");
                        Console.WriteLine("image to show image");



                    }
                }

            }

        }


    }
}
