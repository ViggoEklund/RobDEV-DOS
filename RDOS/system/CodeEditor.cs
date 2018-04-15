using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using RobDEV_DOS;

namespace RDOS
{
    class CodeEditor
    {
        static string locelation = "";
        static string line1 = "";
        static string line2 = "";
        static string line3 = "";
        static string line4 = "";
        static string line5 = "";
        static int lineon = 1;


        public static void Run(string file)
        {
            locelation = file;
            Program();
        }

        public static void Program()
        {
            var key = new RDOS.keyboard();
            if (keyboard.Key_down(Sys.ConsoleKeyEx.DownArrow))
            {
                if (lineon == 5)
                {
                    lineon = 1;
                }

                if (lineon == 4)
                {
                    lineon = 5;
                }

                if (lineon == 3)
                {
                    lineon = 4;
                }

                if (lineon == 2)
                {
                    lineon = 3;
                }

                if (lineon == 1)
                {
                    lineon = 2;
                }
            }

            if (keyboard.Key_down(Sys.ConsoleKeyEx.Spacebar))
            {
                keyyy(" ");
            }


            if (keyboard.Key_down(Sys.ConsoleKeyEx.Backspace))
            {
                if (lineon == 5)
                {
                    line5.Remove(line5.Length + -1);
                }

                if (lineon == 4)
                {
                    line4.Remove(line4.Length + -1);
                }

                if (lineon == 3)
                {
                    line3.Remove(line3.Length + -1);
                }

                if (lineon == 2)
                {
                    line2.Remove(line2.Length + -1);
                }

                if (lineon == 1)
                {
                    line1.Remove(line1.Length + -1);
                }
            }


            if (keyboard.Key_down(Sys.ConsoleKeyEx.A))
            {
                keyyy("a");
            }
            Console.WriteLine("F1 to save | F2 to exit");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);



            Console.Clear();
            Program();
        }

        public static void keyyy(string kkk)
        {
            if (lineon == 5)
            {
                line5 += kkk;
            }

            if (lineon == 4)
            {
                line4 += kkk;
            }

            if (lineon == 3)
            {
                line3 += kkk;
            }

            if (lineon == 2)
            {
                line2 += kkk;
            }

            if (lineon == 1)
            {
                line1 += kkk;
            }
        }


        public static void save(string line1)
        {
           // string[] text = { line1 };
           // RDOS.VFS.write(@"0:\" + locelation, text);
        }
    }
}
