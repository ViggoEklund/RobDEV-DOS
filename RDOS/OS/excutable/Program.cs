using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS.OS.hardware
{
    class Program
    {
            static int varv;
        static string strv;
        static string color = "8";
        static bool iff = false;
            public static void load(string code)
            {
            /*
                foreach (string a in code.Split('\n'))
                {
                    int num;

                    //vars
                    if (a.StartsWith("var = "))
                    {
                        int x = Int32.Parse(a.Substring(6));
                        varv = x;
                    }
                    else if (a.StartsWith("var += "))
                    {
                        int x = Int32.Parse(a.Substring(7));
                        varv += x;
                    }
                    else if (a.StartsWith("var -= "))
                    {
                        int x = Int32.Parse(a.Substring(7));
                        varv -= x;
                    }
                    else if (a.StartsWith("string = "))
                    {
                        strv = a.Substring(9);
                    }

                    //IF
                    else if (a.StartsWith("if var == "))
                    {
                        int x = Int32.Parse(a.Substring(10));
                        if (varv == x)
                        {
                            iff = true;
                        }
                        else iff = false;
                    }
                    else if (a.StartsWith("   print "))
                    {
                        if (iff == true)
                        {
                            int s = 9;
                            if (color.StartsWith("1"))
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("2"))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("3"))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("4"))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("5"))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("6"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("7"))
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(a.Substring(s));
                            }
                            if (color.StartsWith("8"))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(a.Substring(s));
                            }
                        }
                    }
                    else if (a.StartsWith("   printline "))
                    {
                        if (iff == true)
                        {
                            int s = 13;
                            if (color.StartsWith("1"))
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("2"))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("3"))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("4"))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("5"))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("6"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("7"))
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(a.Substring(s));
                            }
                            if (color.StartsWith("8"))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(a.Substring(s));
                            }
                        }
                    }
                    else if (a.StartsWith("end"))
                    {
                        iff = false;
                    }


                    //print
                    else if (a.StartsWith("var.print"))
                    {

                        if (color.StartsWith("1"))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("2"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("3"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("4"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("5"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("6"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("7"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(varv);
                        }
                        if (color.StartsWith("8"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(varv);
                        }
                    }
                    else if (a.StartsWith("color = "))
                    {
                        color = a.Substring(8);
                    }

                    else if (a.StartsWith("var.printline"))
                    {
   
                        if (color.StartsWith("1"))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("2"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("3"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("4"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("5"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("6"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("7"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(varv);
                        }
                        if (color.StartsWith("8"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(varv);
                        }
                    }
                    else if (a.StartsWith("string.print"))
                    {
                    
                        if (color.StartsWith("1"))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("2"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("3"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("4"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("5"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("6"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("7"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(strv);
                        }
                        if (color.StartsWith("8"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(strv);
                        }
                    }
                    else if (a.StartsWith("string.printline"))
                    {
                
                        if (color.StartsWith("1"))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("2"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("3"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("4"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("5"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("6"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("7"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(strv);
                        }
                        if (color.StartsWith("8"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(strv);
                        }
                    }
                    else if (a.StartsWith("print "))
                    {
                        int s = 6;
                        if (color.StartsWith("1"))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("2"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("3"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("4"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("5"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("6"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("7"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(a.Substring(s));
                        }
                        if (color.StartsWith("8"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(a.Substring(s));
                        }
                    }
                    else if (a.StartsWith("printline "))
                    {
                        int s = 10;
                        if (color.StartsWith("1"))
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("2"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("3"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("4"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("5"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("6"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("7"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(a.Substring(s));
                        }
                        if (color.StartsWith("8"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(a.Substring(s));
                        }
                    }

                    //console
                    else if (a == "read")
                    {
                        Console.Read();
                    }
                    else if (a.StartsWith("clear"))
                    {
                        Console.Clear();
                    }
                    else if (a == "exit")
                    {
                        break;
                    }
                }
                */
            }

        }

    }