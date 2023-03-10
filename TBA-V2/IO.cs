using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TBA_V2
{
    internal class IO
    {
        private static int outint;
        private static string outtxt;
        private static int cursororig;
        public static string IOtxt(string in1, string in2)
        {
            Console.Write(in1);
            outtxt = Console.ReadLine();
            Console.SetCursorPosition(in1.Length + outtxt.Length, 0);
            Console.Write(in2);
            return outtxt;
        }
        public static string IOtxt(string in1)
        {
            cursororig = Console.CursorLeft;
            Console.Write(in1);
            outtxt = Console.ReadLine();
            Console.SetCursorPosition((cursororig + outtxt.Length), (Console.CursorTop - 1));

        }
        public static int IOint(string in1, string in2)
        {
            Console.Write(in1);
            while (true)
            {
                cursororig = Console.CursorLeft;
                try
                {
                    outint = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("INCORRECT INPUT");
                    Console.Read();
                    Console.SetCursorPosition((cursororig), (Console.CursorTop - 1));
                }
            }
            Console.SetCursorPosition(in1.Length + outint.ToString().Length, 0);
            Console.WriteLine(in2);
            return outint;
        }
        public static void O(string in1)
        {
            Console.Write(in1);
        }
        public static string Itxt()
        {
            cursororig = Console.CursorLeft;
            outtxt = Console.ReadLine();

            Console.SetCursorPosition((cursororig + outtxt.Length), (Console.CursorTop - 1));
            return outtxt;
        }
        public static int Iint()
        {
            while (true)
            {
                cursororig = Console.CursorLeft;
                try
                {
                    outint = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("INCORRECT INPUT");
                    Console.Read();
                    Console.SetCursorPosition((cursororig), (Console.CursorTop - 1));
                }
            }
            Console.SetCursorPosition((cursororig + outint.ToString().Length), (Console.CursorTop - 1));
            return outint;
        }
    }
}
