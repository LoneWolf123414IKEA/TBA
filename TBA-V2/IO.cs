using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TBA_V2
{
    internal class IO
    {
        private static ConsoleColor MapFore = ConsoleColor.White;
        private static ConsoleColor MapBack = ConsoleColor.Black;
        private static ConsoleColor MapLoot = ConsoleColor.Yellow;
        private static ConsoleColor ChrFull = ConsoleColor.White;
        private static ConsoleColor ChrHalf = ConsoleColor.Red;
        private static ConsoleColor ChrCrit = ConsoleColor.DarkRed;
        private static ConsoleColor ChrBack = ConsoleColor.Black;
        private static ConsoleColor GenFore = ConsoleColor.DarkGray;
        private static ConsoleColor GenBack = ConsoleColor.Gray;
        public static void Refresh(string type)
        {
            switch (type)
            {
                case "I":
                    break;
                default:
                    Console.Clear();
                    Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████" +
                              "\r\n████▌                ▐███████████████████████████████████████████████████████████████████████████████████████████████████████████████████" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████" +
                              "\r\n█▌╔════════════════════════════════════════════════════════════════════════════════════════╗▐██▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►HE◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►TO◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►LA◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►RA◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►LH◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►RH◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►LL◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►RL◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►LF◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████►RF◄▌  ▐▌ ▐█" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐█▌                      ▐███████████████████" +
                              "\r\n█▌║                                                                                        ║▐██▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄████████████████████" +
                              "\r\n█▌║                                                                                        ║▐████████████████████████████████████████████" +
                              "\r\n█▌║                                                                                        ║▐████████████████████████████████████████████" +
                              "\r\n█▌╚════════════════════════════════════════════════════════════════════════════════════════╝▐██████                      ████████████████" +
                              "\r\n███████████████████████████████████████████████████████████████████████████████████████████████████                      ██████►X◄▌   ▐██" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ ▌████▌██▌████▌███                      ████████████████" +
                              "\r\n███████▌main hand▐▌                ▐█████████████████████████████████████████████ █▐████▐█▐████▐███                      ██████►Y◄▌   ▐██" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ █▌████▌▌████▌████                      ████████████████" +
                              "\r\n███████▌off  hand▐▌                ▐█████████████████████████████████████████████ ██▐████▐████▐████                      ██████►Z◄▌≡ ≡▐██" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ ██▌███▌▌███▌█████                      ████████████████" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ ███▐██▐█▐██▐█████                      ██████►L◄▌≡ ≡▐██" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ ███▌█▌██▌█▌██████                      ██████►M◄▌≡ ≡▐██" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ ████ ▐███ ▐██████                      ██████►D◄▌≡ ≡▐██" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█                      ████████████████" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    break;
            }
        }
        public static void Chrmodl(string part)
        {
            switch (part)
            {
                case "H":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;
                    Console.SetCursorPosition(96, 5);
                    Console.Write("        ▄████▄        ");
                    Console.SetCursorPosition(96, 6);
                    Console.Write("       ████████       ");
                    Console.SetCursorPosition(96, 7);
                    Console.Write("      ▐████████▌      ");
                    Console.SetCursorPosition(96, 7);
                    Console.Write("       ████████       ");
                    Console.SetCursorPosition(96, 7);
                    Console.Write("       ▀██████▀       ");
                    break;
                case "T":
                    break;
                case "La":
                    break;
                case "Ra":
                    break;
                case "Lh":
                    break;
                case "Rh":
                    break;
                case "Ll":
                    break;
                case "Rl":
                    break;
                case "Lf":
                    break;
                case "Rf":
                    break;
                default:
                    break;
            }
        }
        public static string IOtxt(string in1, string in2)
        {
            return "";
        }
        public static string IOtxt(string in1)
        {
            return "";

        }
        public static int IOint(string in1, string in2)
        {
            return 0;
        }
        public static void O(string in1)
        {
            
        }
        public static string Itxt()
        {
            return "";
        }
        public static int Iint()
        {
            return 0;
        }
    }
}
