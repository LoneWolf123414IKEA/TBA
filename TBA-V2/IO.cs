using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public static void Load()
        {
            Console.BackgroundColor = GenBack;
            Console.ForegroundColor = GenFore;
            string[] files;
            try
            {
                files = System.IO.Directory.GetFiles("C:\\Users\\Pontus\\source\\repos\\TBA\\TBA-V2\\bin\\Debug\\net6.0", "*.save");
            }
            catch 
            {
                files = new string[0];
            }
            for (int i = 0; i < files.Length; i++)
            {
                Console.SetCursorPosition(5, i + 4);
                Console.Write(files[i]);
            }
            Console.SetCursorPosition(5, files.Length + 4);
            Console.Write("New save");
            Console.SetCursorPosition(4, 4);
            Console.Write('►');
            int pos = 4;
            string opt;
            while (true)
            {
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (pos != 4)
                        {
                            Console.SetCursorPosition(4, pos);
                            Console.Write(' ');
                            pos--;
                            Console.SetCursorPosition(4, pos);
                            Console.Write('►');
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (pos != files.Length+4)
                        {
                            Console.SetCursorPosition(4, pos);
                            Console.Write(' ');
                            pos++;
                            Console.SetCursorPosition(4, pos);
                            Console.Write('►');
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (pos == files.Length + 4)
                        {
                            Program.player.Chgen();
                            do
                            {
                                Console.SetCursorPosition(5, 4);
                                Console.Write("Please enter a name of less than 17 characters:                                       ");
                                Console.SetCursorPosition(53, 4);
                                Program.player.name = Console.ReadLine();
                            } while (Program.player.name.Length > 16);
                            Program.inv.invgen("¦");
                            Program.move.mapgen("¦");
                        }
                        else
                        {
                            Program.player.Chload(files[pos - 4]);
                            Program.inv.invgen(Program.player.name);
                            Program.move.mapgen(Program.player.name);
                        }
                        return;
                    default:
                        break;
                }
            }
        }
        public static void Clear()
        {
            Console.BackgroundColor = GenBack;
            Console.ForegroundColor = GenBack;
            for (int i = 4; i < 31; i++)
            {
                Console.SetCursorPosition(3, i);
                Console.Write("1234567890123456789012345678901212345678901234567890123456789012123456789012345678901234");
            }
            Console.ForegroundColor = GenFore;
            Console.BackgroundColor = GenBack;
        }
        public static void Refresh(string type)
        {
            Console.CursorVisible = false;
            switch (type)
            {
                case "I":
                    break;
                default:
                    Console.SetWindowSize(137, 43);
                    Console.BackgroundColor = GenBack;
                    Console.ForegroundColor = GenFore;
                    Console.Clear();
                    Console.Write("█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\r\n████▌");
                    Console.Write(Program.player.name);
                    for (int i = 0; i < 16-Program.player.name.Length; i++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write("▐███████████████████████████████████████████████████████████████████████████████████████████████████████████████████\r\n█████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\r\n█▌╔════════════════════════════════════════════════════════════════════════════════════════╗▐██");
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
                    Console.Write("████████████████████\r\n█▌║                                                                                        ║▐████████████████████████████████████████████\r\n█▌║                                                                                        ║▐████████████████████████████████████████████\r\n█▌╚════════════════════════════════════════════════════════════════════════════════════════╝▐██████");
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
                    Console.Write("\r\n███████▌main hand▐▌");
                    try
                    {
                        Console.Write(Program.inv.names[Program.inv.inv[Program.inv.mainhand]]);
                        for (int i = 0; i < 16- Program.inv.names[Program.inv.inv[Program.inv.mainhand]].Length; i++)
                        {
                            Console.Write(' ');
                        }
                    }
                    catch
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            Console.Write(' ');
                        }
                    }                    Console.Write("▐█████████████████████████████████████████████ █▐████▐█▐████▐███");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ██████►Y◄▌   ▐██");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n█████████████████████████████████████████████████████████████████████████████████ █▌████▌▌████▌████");
                    Console.BackgroundColor = MapBack;
                    Console.Write("                      ████████████████");
                    Console.BackgroundColor = GenBack;
                    Console.Write("\r\n███████▌off  hand▐▌");
                    try
                    {
                        Console.Write(Program.inv.names[Program.inv.inv[Program.inv.offhand]]);
                        for (int i = 0; i < 16- Program.inv.names[Program.inv.inv[Program.inv.offhand]].Length; i++)
                        {
                            Console.Write(' ');
                        }
                    }
                    catch
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.Write("▐█████████████████████████████████████████████ ██▐████▐████▐████");
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
                    Chrmodl();
                    break;
            }
        }
        public static void Chrmodl()
        {
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
        }
        public static void Chrmodl(string part)
        {
            Console.BackgroundColor = ChrBack;
            switch (part)
            {
                case "H":
                    if (Program.player.hhp <= 0) return;
                    else if (Program.player.hhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hhp < 50) && (Program.player.hhp > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hhp == 100) Console.Write("00");
                    else if (Program.player.hhp == 0) Console.Write("00");
                    else if (Program.player.hhp < 10) Console.Write($"0{Program.player.hhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hhp.ToString()[0] - '0'}{Program.player.hhp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 6);
                    Console.ForegroundColor = GenFore;
                    switch (Program.player.ha)
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "T":
                    if (Program.player.thp <= 0) return;
                    else if (Program.player.thp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.thp < 50) && (Program.player.thp > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.thp == 100) Console.Write("00");
                    else if (Program.player.thp == 0) Console.Write("00");
                    else if (Program.player.thp < 10) Console.Write($"0{Program.player.thp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.thp.ToString()[0] - '0'}{Program.player.thp.ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 7);
                    Console.ForegroundColor = GenFore;
                    switch (Program.player.ta)
                    {
                        default:
                            Console.Write("N");
                            break;
                    }
                    break;
                case "La":
                    if (Program.player.lahp <= 0) return;
                    else if (Program.player.lahp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.lahp < 50) && (Program.player.lahp > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.lahp == 100) Console.Write("00");
                    else if (Program.player.lahp == 0) Console.Write("00");
                    else if (Program.player.lahp < 10) Console.Write($"0{Program.player.lahp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.lahp.ToString()[0] - '0'}{Program.player.lahp.ToString()[1] - '0'}");
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
                    if (Program.player.rahp <= 0) return;
                    else if (Program.player.rahp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.rahp < 50) && (Program.player.rahp > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.rahp == 100) Console.Write("00");
                    else if (Program.player.rahp == 0) Console.Write("00");
                    else if (Program.player.rahp < 10) Console.Write($"0{Program.player.rahp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.rahp.ToString()[0] - '0'}{Program.player.rahp.ToString()[1] - '0'}");
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
                    if (Program.player.lhhp <= 0) return;
                    else if (Program.player.lhhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.lhhp < 50) && (Program.player.lhhp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(96, 18);
                    Console.Write("██▌");
                    Console.SetCursorPosition(130, 10);
                    if (Program.player.lhhp == 100) Console.Write("00");
                    else if (Program.player.lhhp == 0) Console.Write("00");
                    else if (Program.player.lhhp < 10) Console.Write($"0{Program.player.lhhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.lhhp.ToString()[0] - '0'}{Program.player.lhhp.ToString()[1] - '0'}");
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
                    if (Program.player.rhhp <= 0) return;
                    else if (Program.player.rhhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.rhhp < 50) && (Program.player.rhhp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(113, 18);
                    Console.Write("▐██");
                    Console.SetCursorPosition(130, 11);
                    if (Program.player.rhhp == 100) Console.Write("00");
                    else if (Program.player.rhhp == 0) Console.Write("00");
                    else if (Program.player.rhhp < 10) Console.Write($"0{Program.player.rhhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.rhhp.ToString()[0] - '0'}{Program.player.rhhp.ToString()[1] - '0'}");
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
                    if (Program.player.llhp <= 0) return;
                    else if (Program.player.llhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.llhp < 50) && (Program.player.llhp > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.llhp == 100) Console.Write("00");
                    else if (Program.player.llhp == 0) Console.Write("00");
                    else if (Program.player.llhp < 10) Console.Write($"0{Program.player.llhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.llhp.ToString()[0] - '0'}{Program.player.llhp.ToString()[1] - '0'}");
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
                    if (Program.player.rlhp <= 0) return;
                    else if (Program.player.rlhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.rlhp < 50) && (Program.player.rlhp > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.rlhp == 100) Console.Write("00");
                    else if (Program.player.rlhp == 0) Console.Write("00");
                    else if (Program.player.rlhp < 10) Console.Write($"0{Program.player.rlhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.rlhp.ToString()[0] - '0'}{Program.player.rlhp.ToString()[1] - '0'}");
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
                    if (Program.player.lfhp <= 0) return;
                    else if (Program.player.lfhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.lfhp < 50) && (Program.player.lfhp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(100, 27);
                    Console.Write("████▌");
                    Console.SetCursorPosition(130, 14);
                    if (Program.player.lfhp == 100) Console.Write("00");
                    else if (Program.player.lfhp == 0) Console.Write("00");
                    else if (Program.player.lfhp < 10) Console.Write($"0{Program.player.lfhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.lfhp.ToString()[0] - '0'}{Program.player.lfhp.ToString()[1] - '0'}");
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
                    if (Program.player.rfhp <= 0) return;
                    else if (Program.player.rfhp > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.rfhp < 50) && (Program.player.rfhp > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(107, 27);
                    Console.Write("▐████");
                    Console.SetCursorPosition(130, 15);
                    if (Program.player.rfhp == 100) Console.Write("00");
                    else if (Program.player.rfhp == 0) Console.Write("00");
                    else if (Program.player.rfhp < 10) Console.Write($"0{Program.player.rfhp.ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.rfhp.ToString()[0] - '0'}{Program.player.rfhp.ToString()[1] - '0'}");
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
        public static void Wait()
        {
            while (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 0] == 1)
            {
                Clear();
                Console.ForegroundColor = GenFore;
                Console.BackgroundColor = GenBack;
                Console.SetCursorPosition(4, 4);
                Console.Write("There is a monster in the room, it hasn't noticed you yet!");
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        Settings();
                        Refresh("");
                        break;
                    case ConsoleKey.R:
                        Program.move.reuturn();
                        return;
                    case ConsoleKey.I:
                        //inventory
                        break;
                    case ConsoleKey.Enter:
                        //battle
                        return;
                    case ConsoleKey.S:
                        Program.player.Chsave();
                        Program.move.mapsave(Program.player.name);
                        Program.inv.invsave(Program.player.name);
                        break;
                    case ConsoleKey.Backspace:
                        Program.player.Chsave();
                        Program.move.mapsave(Program.player.name);
                        Program.inv.invsave(Program.player.name);
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Menu()
        {
            while (true)
            {
                Clear();
                Console.ForegroundColor = GenFore;
                Console.BackgroundColor = GenBack;
                Console.SetCursorPosition(4, 4);
                Console.Write("Room is safe, choose what to do!");
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        Settings();
                        Refresh("");
                        break;
                    case ConsoleKey.L:
                        Program.inv.loot();
                        return;
                    case ConsoleKey.UpArrow:
                        Program.move.North();
                        return;
                    case ConsoleKey.DownArrow:
                        Program.move.South();
                        return;
                    case ConsoleKey.LeftArrow:
                        Program.move.West();
                        return;
                    case ConsoleKey.RightArrow:
                        Program.move.East();
                        return;
                    case ConsoleKey.I:
                        Program.inv.Inv();
                        return;
                    case ConsoleKey.Enter:
                        //use stairs
                        return;
                    case ConsoleKey.S:
                        Program.player.Chsave();
                        Program.move.mapsave(Program.player.name);
                        Program.inv.invsave(Program.player.name);
                        break;
                    case ConsoleKey.Backspace:
                        Program.player.Chsave();
                        Program.move.mapsave(Program.player.name);
                        Program.inv.invsave(Program.player.name);
                        Environment.Exit(0);
                        return;
                    default:
                        break;
                }
            }
            
        }
        public static void Settings()
        {
            Console.SetCursorPosition(4, 4);
            Console.Write("Settings menu:                                 to set a map point enter two characters");
            Console.SetCursorPosition(5, 5);
            Console.Write("Colour:                                                                 Colour legend");
            Console.SetCursorPosition(6, 6);
            Console.Write("Map Fore:                                                                  Bl   Wh");
            Console.SetCursorPosition(6, 7);
            Console.Write("Map Back:                                                                  Lb   Dw");
            Console.SetCursorPosition(6, 8);
            Console.Write("Map Loot:                                                                  Dr   Rd");
            Console.SetCursorPosition(6, 9);
            Console.Write("Chr Full:                                                                  Dg   Gr");
            Console.SetCursorPosition(6, 10);
            Console.Write("Chr Half:                                                                  Db   Bu");
            Console.SetCursorPosition(6, 11);
            Console.Write("Chr Crit:                                                                  Dy   Yl");
            Console.SetCursorPosition(6, 12);
            Console.Write("Chr Back:                                                                  Dm   Mg");
            Console.SetCursorPosition(6, 13);
            Console.Write("Gen Fore:                                                                  Dc   Cy");
            Console.SetCursorPosition(6, 14);
            Console.Write("Gen Back:");
            Console.SetCursorPosition(5, 15);
            Console.Write("Legend:");
            Console.SetCursorPosition(6, 16);
            Console.Write("Nan Room:");
            Console.SetCursorPosition(6, 17);
            Console.Write("Emt Room:");
            Console.SetCursorPosition(6, 18);
            Console.Write("Mon Room:");
            Console.SetCursorPosition(6, 19);
            Console.Write("Spc Room:");
            Console.SetCursorPosition(6, 20);
            Console.Write("Chr Room:");
            Console.SetCursorPosition(5, 21);
            Console.Write("Other:");
            Console.SetCursorPosition(6, 22);
            Console.Write("Chr hand:");

            Console.SetCursorPosition(79, 6);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 7);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 8);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 9);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 10);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 11);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 12);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("■");
            Console.SetCursorPosition(79, 13);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("■");

            Console.SetCursorPosition(84, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 7);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 8);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 12);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("■");
            Console.SetCursorPosition(84, 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("■");
            Console.ForegroundColor = GenFore;

            Console.SetCursorPosition(16, 6);
            Clr(MapFore);
            Console.SetCursorPosition(16, 7);
            Clr(MapBack);
            Console.SetCursorPosition(16, 8);
            Clr(MapLoot);
            Console.SetCursorPosition(16, 9);
            Clr(ChrFull);
            Console.SetCursorPosition(16, 10);
            Clr(ChrHalf);
            Console.SetCursorPosition(16, 11);
            Clr(ChrCrit);
            Console.SetCursorPosition(16, 12);
            Clr(ChrBack);
            Console.SetCursorPosition(16, 13);
            Clr(GenFore);
            Console.SetCursorPosition(16, 14);
            Clr(GenBack);

            Console.SetCursorPosition(16, 16);
            Console.Write(NanRoom);
            Console.SetCursorPosition(16, 17);
            Console.Write(EmtRoom);
            Console.SetCursorPosition(16, 18);
            Console.Write(MonRoom);
            Console.SetCursorPosition(16, 19);
            Console.Write(SpcRoom);
            Console.SetCursorPosition(16, 20);
            Console.Write(ChrRoom);




            Console.SetCursorPosition(19, 6);
            Console.Write('◄');
            int pos = 6;
            string opt;
            while (true)
            {
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.UpArrow:
                        if (pos != 6)
                        {
                            Console.SetCursorPosition(19, pos);
                            Console.Write(' ');
                            if (pos == 16 || pos == 22) pos -= 2;
                            else pos--;
                            Console.SetCursorPosition(19, pos);
                            Console.Write('◄');
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (pos != 22)
                        {
                            Console.SetCursorPosition(19, pos);
                            Console.Write(' ');
                            if (pos == 14 || pos == 20) pos += 2;
                            else pos++;
                            Console.SetCursorPosition(19, pos);
                            Console.Write('◄');
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        Console.SetCursorPosition(16, pos);
                        switch (pos)
                        {
                            case 6:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                MapFore = Clr(opt);
                                break;
                            case 7:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                MapBack = Clr(opt);
                                break;
                            case 8:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                MapLoot = Clr(opt);
                                break;
                            case 9:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                ChrFull = Clr(opt);
                                break;
                            case 10:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                ChrHalf = Clr(opt);
                                break;
                            case 11:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                ChrCrit = Clr(opt);
                                break;
                            case 12:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                ChrBack = Clr(opt);
                                break;
                            case 13:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                GenFore = Clr(opt);
                                break;
                            case 14:
                                opt = "";
                                opt += (char)Console.Read();
                                opt += (char)Console.Read();
                                GenBack = Clr(opt);
                                break;
                            case 16:
                                NanRoom = "";
                                NanRoom += (char)Console.Read();
                                NanRoom += (char)Console.Read();
                                break;
                            case 17:
                                EmtRoom = "";
                                EmtRoom += (char)Console.Read();
                                EmtRoom += (char)Console.Read();
                                break;
                            case 18:
                                MonRoom = "";
                                MonRoom += (char)Console.Read();
                                MonRoom += (char)Console.Read();
                                break;
                            case 19:
                                SpcRoom = "";
                                SpcRoom += (char)Console.Read();
                                SpcRoom += (char)Console.Read();
                                break;
                            case 20:
                                ChrRoom = "";
                                ChrRoom += (char)Console.Read();
                                ChrRoom += (char)Console.Read();
                                break;
                            case 22:
                                opt = "";
                                opt += (char)Console.Read();
                                switch (opt)
                                {
                                    case "L":
                                        break;
                                    case "R":
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default: 
                                break;
                        }
                        Console.CursorVisible = false;
                        Map();
                        Chrmodl();
                        Console.ForegroundColor = GenFore;
                        Console.BackgroundColor = GenBack;
                        break;
                }
            }
        }
        private static void Clr(ConsoleColor clr)
        {
            switch (clr)
            {
                case ConsoleColor.Black:
                    Console.Write("Bl");
                    break;
                case ConsoleColor.White:
                    Console.Write("Wh");
                    break;
                case ConsoleColor.DarkGray:
                    Console.Write("Lb");
                    break;
                case ConsoleColor.Gray:
                    Console.Write("Dw");
                    break;
                case ConsoleColor.DarkRed:
                    Console.Write("Dr");
                    break;
                case ConsoleColor.Red:
                    Console.Write("Rd");
                    break;
                case ConsoleColor.DarkGreen:
                    Console.Write("Dg");
                    break;
                case ConsoleColor.Green:
                    Console.Write("Gr");
                    break;
                case ConsoleColor.DarkBlue:
                    Console.Write("Db");
                    break;
                case ConsoleColor.Blue:
                    Console.Write("Bu");
                    break;
                case ConsoleColor.DarkYellow:
                    Console.Write("Dy");
                    break;
                case ConsoleColor.Yellow:
                    Console.Write("Yl");
                    break;
                case ConsoleColor.DarkMagenta:
                    Console.Write("Dm");
                    break;
                case ConsoleColor.Magenta:
                    Console.Write("Mg");
                    break;
                case ConsoleColor.DarkCyan:
                    Console.Write("Dc");
                    break;
                case ConsoleColor.Cyan:
                    Console.Write("Cy");
                    break;
            }
        }
        private static ConsoleColor Clr(string clr)
        {
            switch (clr)
            {
                case "Bl":
                    return ConsoleColor.Black;
                case "Wh":
                    return ConsoleColor.White;
                case "Lb":
                    return ConsoleColor.DarkGray;
                case "Dw":
                    return ConsoleColor.Gray;
                case "Dr":
                    return ConsoleColor.DarkRed;
                case "Rd":
                    return ConsoleColor.Red;
                case "Dg":
                    return ConsoleColor.DarkGreen;
                case "Gr":
                    return ConsoleColor.Green;
                case "Db":
                    return ConsoleColor.DarkBlue;
                case "Bu":
                    return ConsoleColor.Blue;
                case "Dy":
                    return ConsoleColor.DarkYellow;
                case "Yl":
                    return ConsoleColor.Yellow;
                case "Dm":
                    return ConsoleColor.DarkMagenta;
                case "Mg":
                    return ConsoleColor.Magenta;
                case "Dc":
                    return ConsoleColor.DarkCyan;
                case "Cy":
                    return ConsoleColor.Cyan;
                default:
                    return ConsoleColor.Black;
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
