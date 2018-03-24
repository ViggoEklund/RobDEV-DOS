using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS.OS.program.CodeEditor
{
    class ProgramCD
    {
        public static string fl = "";
        public static string code = "";
        public static string code1 = "";
        public static string code2 = "";
        public static string code3 = "";
        public static string code4 = "";
        public static void init(string fileloc)
        {
            fl = fileloc;
            code = System.IO.File.ReadAllText(@"0:\" + fl);
            Console.WriteLine("f1 to save  f2 to exit");
            Console.WriteLine("Code:");
            Console.WriteLine("1>" + code1);
            Console.WriteLine("2>" + code2);
            Console.WriteLine("3>" + code3);
            Console.WriteLine("4>" + code4);
        }

        public static void loop()
        {
            Console.Clear();
            Console.WriteLine("f1 to save  f2 to exit");
            Console.WriteLine("Code:");
            Console.WriteLine("1>" + code1);
            Console.WriteLine("2>" + code2);
            Console.WriteLine("3>" + code3);
            Console.WriteLine("4>" + code4);

        }
    }
}
