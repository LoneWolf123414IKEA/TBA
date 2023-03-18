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
        private static string EmtRoom = "░░";
        private static string MonRoom = "▒▒";
        private static string SpcRoom = "▓▓";
        private static string ChrRoom = "╟╢";
        private static string NanRoom = "[]";
        public static void Refresh(string type)
        {
            switch (type)
            {
                case "I":
                    break;
                default:
                    Console.SetWindowSize(137, 43);
                    Console.BackgroundColor = GenBack;
                    Console.ForegroundColor = GenFore;
                    Console.Clear();
                    Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████" +
                              "\r\n████▌                ▐███████████████████████████████████████████████████████████████████████████████████████████████████████████████████" +
                              "\r\n█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████" +
                              "\r\n█▌╔════════════════════════════════════════════════════════════════════════════════════════╗▐██");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                    Console.BackgroundColor = GenBack;
                    Console.Write("████████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►HE◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►TO◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►LA◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►RA◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►LH◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►RH◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►LL◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►RL◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►LF◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐███████►RF◄▌  ▐▌ ▐█");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐█");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▌                      ▐");
                    Console.BackgroundColor = GenBack;
                    Console.Write("███████████████████\r\n█▌║                                                                                        ║▐██");
                    Console.BackgroundColor = ChrBack;
                    Console.Write("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.BackgroundColor = GenBack;
                    Console.Write("████████████████████\r\n█▌║                                                                                        ║▐████████████████████████████████████████████" +
                              "\r\n█▌║                                                                                        ║▐████████████████████████████████████████████" +
                              "\r\n█▌╚════════════════════════════════════════════════════════════════════════════════════════╝▐██████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ████████████████");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n███████████████████████████████████████████████████████████████████████████████████████████████████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►X◄▌   ▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ ▌████▌██▌████▌███");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ████████████████");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n███████▌main hand▐▌                ▐█████████████████████████████████████████████ █▐████▐█▐████▐███");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►Y◄▌   ▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ █▌████▌▌████▌████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ████████████████");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n███████▌off  hand▐▌                ▐█████████████████████████████████████████████ ██▐████▐████▐████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►Z◄▌≡ ≡▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ ██▌███▌▌███▌█████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ████████████████");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ ███▐██▐█▐██▐█████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►L◄▌≡ ≡▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ ███▌█▌██▌█▌██████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►M◄▌≡ ≡▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ ████ ▐███ ▐██████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►D◄▌≡ ≡▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ████████████████");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                    Chrmodl("H");
                    Chrmodl("T");
                    Chrmodl("La");
                    Chrmodl("Ra");
                    Chrmodl("Lh");
                    Chrmodl("Rh");
                    Chrmodl("Ll");
                    Chrmodl("Rl");
                    Chrmodl("Lf");
                    Chrmodl("Rf");
                    break;
            }
        }
        public static void Chrmodl(string part)
        {
            Console.BackgroundColor = ChrBack;
            switch (part)
            {
                case "H":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;
                    Console.SetCursorPosition(95, 4);
                    Console.Write("        ▄████▄        ");
                    Console.SetCursorPosition(95, 5);
                    Console.Write("       ████████       ");
                    Console.SetCursorPosition(95, 6);
                    Console.Write("      ▐████████▌      ");
                    Console.SetCursorPosition(95, 7);
                    Console.Write("       ████████       ");
                    Console.SetCursorPosition(95, 8);
                    Console.Write("       ▀██████▀       ");
                    Console.SetCursorPosition(130, 6);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 6);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "T":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;
                    Console.SetCursorPosition(104, 9);
                    Console.Write("▄▄▄▄");
                    Console.SetCursorPosition(100, 10);
                    Console.Write("████████████");
                    Console.SetCursorPosition(100, 11);
                    Console.Write("▐██████████▌");
                    Console.SetCursorPosition(101, 12);
                    Console.Write("██████████");
                    Console.SetCursorPosition(101, 13);
                    Console.Write("▀████████▀");
                    Console.SetCursorPosition(102, 14);
                    Console.Write("████████");
                    Console.SetCursorPosition(102, 15);
                    Console.Write("████████");
                    Console.SetCursorPosition(101, 16);
                    Console.Write("▐████████▌");
                    Console.SetCursorPosition(101, 17);
                    Console.Write("██████████");
                    Console.SetCursorPosition(101, 18);
                    Console.Write("▀▀▀████▀▀▀");
                    Console.SetCursorPosition(130, 7);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 7);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "La":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(98, 10);
                    Console.Write("▄");
                    Console.SetCursorPosition(97, 11);
                    Console.Write("██▌");
                    Console.SetCursorPosition(96, 12);
                    Console.Write("████");
                    Console.SetCursorPosition(95, 13);
                    Console.Write("████");
                    Console.SetCursorPosition(95, 14);
                    Console.Write("████");
                    Console.SetCursorPosition(95, 15);
                    Console.Write("████");
                    Console.SetCursorPosition(96, 16);
                    Console.Write("███");
                    Console.SetCursorPosition(96, 17);
                    Console.Write("▀▀");
                    Console.SetCursorPosition(130, 8);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 8);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Ra":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(113, 10);
                    Console.Write("▄");
                    Console.SetCursorPosition(112, 11);
                    Console.Write("▐██");
                    Console.SetCursorPosition(112, 12);
                    Console.Write("████");
                    Console.SetCursorPosition(113, 13);
                    Console.Write("████");
                    Console.SetCursorPosition(113, 14);
                    Console.Write("████");
                    Console.SetCursorPosition(113, 15);
                    Console.Write("████");
                    Console.SetCursorPosition(113, 16);
                    Console.Write("███");
                    Console.SetCursorPosition(114, 17);
                    Console.Write("▀▀");
                    Console.SetCursorPosition(130, 9);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 9);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Lh":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(96, 18);
                    Console.Write("██▌");
                    Console.SetCursorPosition(130, 10);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 10);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Rh":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(113, 18);
                    Console.Write("▐██");
                    Console.SetCursorPosition(130, 11);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 11);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Ll":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(100, 19);
                    Console.Write("███▄▄");
                    Console.SetCursorPosition(99, 20);
                    Console.Write("▐█████");
                    Console.SetCursorPosition(99, 21);
                    Console.Write("▐█████");
                    Console.SetCursorPosition(100, 22);
                    Console.Write("████▌");
                    Console.SetCursorPosition(101, 23);
                    Console.Write("███");
                    Console.SetCursorPosition(101, 24);
                    Console.Write("███");
                    Console.SetCursorPosition(101, 25);
                    Console.Write("███");
                    Console.SetCursorPosition(101, 26);
                    Console.Write("▀▀▀");
                    Console.SetCursorPosition(130, 12);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 12);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Rl":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(107, 19);
                    Console.Write("▄▄███");
                    Console.SetCursorPosition(107, 20);
                    Console.Write("█████▌");
                    Console.SetCursorPosition(107, 21);
                    Console.Write("█████▌");
                    Console.SetCursorPosition(107, 22);
                    Console.Write("▐████");
                    Console.SetCursorPosition(108, 23);
                    Console.Write("███");
                    Console.SetCursorPosition(108, 24);
                    Console.Write("███");
                    Console.SetCursorPosition(108, 25);
                    Console.Write("███");
                    Console.SetCursorPosition(108, 26);
                    Console.Write("▀▀▀");
                    Console.SetCursorPosition(130, 13);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 13);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Lf":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(100, 27);
                    Console.Write("████▌");
                    Console.SetCursorPosition(130, 14);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 14);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "Rf":
                    if (Program.player.hp <= 0) return;
                    else if (Program.player.hp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp < 50) && (Program.player.hp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(107, 27);
                    Console.Write("▐████");
                    Console.SetCursorPosition(130, 15);
                    if (Program.player.hp == 100) Console.Write("00");
                    else if (Program.player.hp == 0) Console.Write("00");
                    else if (Program.player.hp < 10) Console.Write($"0{Program.player.hp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp.ToString()[0] - '0'}{Program.player.hp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 15);
                    Console.ForegroundColor = GenFore;
                    switch ("")
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public static void Map()
        {
            int y = 31;
            Console.BackgroundColor = MapBack;
            for (int i = Program.move.x - 6; i < Program.move.x + 5; i++)
            {
                Console.SetCursorPosition(99, y);
                for (int j = Program.move.y - 6; j < Program.move.y + 5; j++)
                {
                    Console.ForegroundColor = MapFore;
                    if (i == Program.move.x && j == Program.move.y) Console.Write(ChrRoom);
                    else if (i < -1 || i > 260 || j < -1 || j > 260) Console.Write("  ");
                    else if (i == -1 && j == -1) Console.Write("╔═");
                    else if (i == -1 && j == 260) Console.Write("╚═");
                    else if (i == 260 && j == -1) Console.Write("═╗");
                    else if (i == 260 && j == 260) Console.Write("═╝");
                    else if (j == -1) Console.Write("║ ");
                    else if (j == 260) Console.Write(" ║");
                    else if (i == -1 || i == 260) Console.Write("══");
                    else if (Program.move.map[i, j, Program.move.z, 0] == 2 && Program.move.map[i, j, Program.move.z, 1] == 0/*will be next boss*/)
                    {
                        Console.ForegroundColor= MapLoot;
                        Console.Write(SpcRoom);
                    }
                    else if (Program.move.map[i, j, Program.move.z, 0] == 2 || (Program.move.map[i, j, Program.move.z, 0] == 0 && Program.move.map[i, j, Program.move.z, 1] == 0)) Console.Write(SpcRoom);
                    else if (Program.move.map[i, j, Program.move.z, 3] == 0) Console.Write(NanRoom);
                    else
                    {
                        if (Program.move.map[i, j, Program.move.z, 2] > 0) Console.ForegroundColor = MapLoot;
                        if (Program.move.map[i, j, Program.move.z, 0] == 0) Console.Write(EmtRoom);
                        else Console.Write(MonRoom);
                    }
                }
                y++;
            }
            Console.SetCursorPosition(131, 32);
            if (Program.move.x > 99) Console.Write(Program.move.x);
            else if (Program.move.x < 10) Console.Write($"00{Program.move.x}");
            else Console.Write($"0{Program.move.x}");

            Console.SetCursorPosition(131, 34);
            if (Program.move.y > 99) Console.Write(Program.move.y);
            else if (Program.move.y < 10) Console.Write($"00{Program.move.y}");
            else Console.Write($"0{Program.move.y}");

            Console.SetCursorPosition(132, 36);
            Console.Write(Program.move.z);

            Console.SetCursorPosition(132, 38);
            if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 2] > 0) Console.Write("Y");
            else Console.Write("N");

            Console.SetCursorPosition(132, 39);
            if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 0] == 1)
            {
                switch (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 1])
                {
                    case 0:
                        Console.Write("S");
                        break;
                    case 1:
                        Console.Write("K");
                        break;
                    default:
                        break;
                }
            }
            else Console.Write("N");

            Console.SetCursorPosition(132, 40);
            if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 4] == 1) Console.Write("↓");
            else if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 4] == 2) Console.Write("↑");
            else Console.Write("N");
        }
        public static void Menu()
        {
            Console.SetCursorPosition(4, 4);
            Console.Write("Room is safe, choose what to do!");
            while (true)
            {
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        //settings
                        return;
                    case ConsoleKey.L:
                        //loot
                        return;
                    case ConsoleKey.UpArrow:
                        //north
                        return;
                    case ConsoleKey.DownArrow:
                        //south
                        return;
                    case ConsoleKey.LeftArrow:
                        //west
                        return;
                    case ConsoleKey.RightArrow:
                        //east
                        return;
                    case ConsoleKey.I:
                        //inventory
                        return;
                    case ConsoleKey.Enter:
                        //use stairs
                        return;
                    case ConsoleKey.S:
                        //save
                        return;
                    case ConsoleKey.Backspace:
                        //exit game and save
                        return;
                    default:
                        break;
                }
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
