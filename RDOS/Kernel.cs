using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.IO;
using Cosmos.System.Graphics;
using Cosmos.HAL;
using Cosmos.System.ExtendedASCII;
using RDOS;

namespace RobDEV_DOS
{
    public class Kernel : Sys.Kernel
    {
        public static Cosmos.HAL.VGAScreen VScreen = new Cosmos.HAL.VGAScreen();
       
        public static byte[] SBuffer = new byte[64000];
        public static Cosmos.HAL.Mouse m = new Cosmos.HAL.Mouse();
        private static Sys.FileSystem.CosmosVFS FS;
        public static string file;
        Canvas canvas;
        string VersionNum = "0.2.1";
        string Versiont = "A";
        string Open = "";
        bool gui = false;
        string logo = @"  ████████╗ █████████╗  ████████╗   ████████
 ██╔═════██╗██║     ██╗██║     ██╗██
 ██║     ██╝██║     ██║██║     ██║██╔════╗
 ████████║  ██║     ██║██║     ██║  ██████╗
 ██╔═════██╗██║     ██║██║     ██║        ██╗
 ██║     ██║██║     ██║██║     ██║   ╔════██║
 ██║     ██║█████████╔╝╚████████╔╝████████╔═╝
 ╚═╝     ╚═╝╚════════╝  ╚═══════╝ ╚═══════╝  ";
        protected override void BeforeRun()
        {
            
            FS = new Sys.FileSystem.CosmosVFS(); Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS); FS.Initialize();
            m.Initialize(320, 200);
            Console.Clear();
            Encoding.RegisterProvider(CosmosEncodingProvider.Instance);
            Console.InputEncoding = Encoding.GetEncoding(437);
            Console.OutputEncoding = Encoding.GetEncoding(437);
            Console.WriteLine(logo);
            Console.WriteLine("Type help for commands!");
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;
            gui = true;
            if (gui == true)
            {
                Console.WriteLine("Vga Driver Booting");
                VScreen.SetGraphicsMode(Cosmos.HAL.VGAScreen.ScreenSize.Size320x200, Cosmos.HAL.VGAScreen.ColorDepth.BitDepth8);
                VScreen.Clear(0);
                Console.WriteLine("Vga Driver Booted");
            }
        }

        public static void SetPixel(int x, int y, int color)
        {
            SBuffer[(y * 320) + x] = (byte)color;
        }

        public static void ReDraw()
        {
            // VScreen.Clear(0);

            int c = 0;

            for (int y = 0; y < 200; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    uint cl = VScreen.GetPixel320x200x8((uint)x, (uint)y);
                    if (cl != (uint)SBuffer[c])
                    {
                        VScreen.SetPixel320x200x8((uint)x, (uint)y, SBuffer[c]);
                    }
                    c++;
                }
            }
            for (int i = 0; i < 64000; i++)
            {
                SBuffer[i] = 0;
            }
        }

        public static void DrawFilledRectangle(uint x0, uint y0, int Width, int Height, int color)
        {
            for (uint i = 0; i < Width; i++)
            {
                for (uint h = 0; h < Height; h++)
                {
                    SetPixel((int)(x0 + i), (int)(y0 + h), color);
                }
            }
        }

        public static void drawm()
        {
            SetPixel(m.X, m.Y, 40);
            SetPixel(m.X + 1, m.Y, 40);
            SetPixel(m.X + 2, m.Y, 40);
            SetPixel(m.X, m.Y + 1, 40);
            SetPixel(m.X, m.Y + 2, 40);
            SetPixel(m.X + 1, m.Y + 1, 40);
            SetPixel(m.X + 2, m.Y + 2, 40);
            SetPixel(m.X + 3, m.Y + 3, 40);
        }


        public bool mousedown()
        {
            if (m.Buttons == Mouse.MouseState.Left)
            {
                return true;
            }
            else return false;
        }

        public void DrawButton(int x0, int y0, int Width, int Height)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int h = 0; h < Height; h++)
                {
                    setpixel((int)(x0 + i), (int)(y0 + h), Color.Black);
                }
            }
        }

        public void Drawmouse(int Width, int Height)
        {
            int x0 = m.X;
            int y0 = m.Y;
            
            for (int i = 0; i < Width; i++)
            {
                for (int h = 0; h < Height; h++)
                {
                    setpixel((int)(x0 + i), (int)(y0 + h), Color.White);
                }
            }
        }
        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        public void mouse()
        {
           
            WriteAt("#", m.X, m.Y);
            mouse();
        }

        public void setpixel(int x, int y, Cosmos.System.Graphics.Color color)
        {
            Pen pen = new Pen(color);
            canvas.DrawPoint(pen, x, y);
        }

        protected override void Run()
        {
            bool start = true;
            if (gui == true)
            {
                drawm();
                ReDraw();
            }
            else if (gui == false)
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
                    if (input == "gui")
                    {
                        canvas = FullScreenCanvas.GetFullScreenCanvas();
                        canvas.Clear(Color.Blue);
                        gui = true;
                        

                    }
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
                    if (a.StartsWith("read "))
                    {
                        string text = System.IO.File.ReadAllText(@"0:\" + a.Substring(5));
                        Console.WriteLine(text);
                    }
                    if (a.StartsWith("edit "))
                    {
                        string[] text = { a.Substring(5) };
                        RDOS.VFS.write("0:\\" + Open, text);
                    }
                    if (a.StartsWith("open "))
                    {
                        Open = a.Substring(5);
                    }
                    if (a.StartsWith("mkfile "))
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile("0:\\" + a.Substring(7));
                        //Sys.FileSystem.VFS.VFSManager.CreateFile("0:\file.txt");
                        Console.WriteLine("Done!");
                    }
                    if (a.StartsWith("deldir "))
                    {
                        RDOS.VFS.DelDir("0:\\" + a.Substring(8));
                        Console.WriteLine("Done!");
                    }
                    if (a.StartsWith("delfile"))
                    {
                        RDOS.VFS.Delfile("0:\\" + a.Substring(9));
                        Console.WriteLine("Done!");
                    }


                    if (a.StartsWith("run "))
                    {
                        string program = System.IO.File.ReadAllText(@"0:\" + a.Substring(4));
                        RDOS.OS.hardware.Program.load(program);
                    }

                    if (a.StartsWith("net -c"))
                    {
                        var maca = new Cosmos.System.Network.UdpClient();
                        maca.Connect(Sys.Network.IPv4.Address.Zero, 5000);
                        Console.WriteLine(maca.ToString());
                    }

                    if (a.StartsWith("net -c"))
                    {
                        var maca = new Cosmos.System.Network.UdpClient();
                        maca.Connect(Sys.Network.IPv4.Address.Zero, 5000);
                        mDebugger.Send("Done");

                    }
                    if (a.StartsWith("net -s"))
                    {
                        byte[] test = { 12 };
                        var maca = new Cosmos.System.Network.UdpClient();
                        
                        maca.Send(test, Sys.Network.IPv4.Address.Zero, 5001);                        
                        
                    }
                    if (a.StartsWith("net -r"))
                    {
                     
                    }


                    if (a.StartsWith("texteditor"))
                    {
                        
                    }
                    if (a.StartsWith("print "))
                    {
                        Console.Write(a.Substring(6));
                    }

                    if (a.StartsWith("randomnumber"))
                    {
                        
                    }




                    if (a.StartsWith("code editor "))
                    {
                        RDOS.OS.program.CodeEditor.ProgramCD.init(a.Substring(12));

                    }

                    if (input == "files")
                    {
                        string[] test1 = { "txt" };
                        string[] test2 = { "" };

                        RDOS.VFS.files("0:", test1, test2);
                    }



    


                    if (input == "about")
                    {
                        string ram = Cosmos.Core.CPU.GetAmountOfRAM().ToString();
                        string MACAddress = RDOS.Network.GetMACAddress();
                        
                        string date = "Month: " + RTC.Month.ToString() + " Day: " + RTC.DayOfTheMonth.ToString() + "\nYear: " + RTC.Year.ToString();
                        string time = RTC.Hour.ToString() + ":" + RTC.Minute.ToString() + ":" + RTC.Second.ToString();

                        Console.WriteLine("time: " + time);
                        Console.WriteLine("date: " + date);
                        Console.WriteLine("Version: " + VersionNum + Versiont);
                        Console.WriteLine("Ram Memory: " + ram);
                        Console.WriteLine("MACAddress: " + MACAddress);
                    }
                    if (input == "shutdown")
                    {
                        Cosmos.HAL.Power.ACPIShutdown();
                    }
                    if (input == "reboot")
                    {
                        Cosmos.HAL.Power.ACPIReboot();
                    }
                    if (input == "time")
                    {
                        string time = Cosmos.HAL.RTC.Hour.ToString() + " " + Cosmos.HAL.RTC.Minute.ToString();
                        string date = Cosmos.HAL.RTC.DayOfTheWeek.ToString() + " " + Cosmos.HAL.RTC.Month.ToString() + " " + Cosmos.HAL.RTC.Year.ToString();

                        Console.WriteLine("time:" + time);
                        Console.WriteLine("date:" + date);

                    }



                    if (input == "test")
                    {
                       
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
