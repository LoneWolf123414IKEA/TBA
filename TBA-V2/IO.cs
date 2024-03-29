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
using System.Xml.Linq;

namespace TextBasedAdventureV2
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
                files = System.IO.Directory.GetFiles("Data\\S", "*.save");
            }
            catch 
            {
#pragma warning disable CA1825 // Avoid zero-length array allocations
                files = new string[0];
#pragma warning restore CA1825 // Avoid zero-length array allocations
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
                            System.IO.Directory.CreateDirectory($"Data\\S\\{Program.player.name}");
                            System.IO.Directory.CreateDirectory($"Data\\S\\{Program.player.name}\\Map");
                            Program.inv.Invgen("¦");
                            Program.move.Mapgen("¦");
                        }
                        else
                        {
                            Program.player.Chload(files[pos - 4]);
                            Program.inv.Invgen(Program.player.name);
                            Program.move.Mapgen(Program.player.name);
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
                    if (Program.player.hp[0] <= 0) return;
                    else if (Program.player.hp[0] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[0] < 50) && (Program.player.hp[0] > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hp[0] == 100) Console.Write("00");
                    else if (Program.player.hp[0] == 0) Console.Write("00");
                    else if (Program.player.hp[0] < 10) Console.Write($"0{Program.player.hp[0].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[0].ToString()[0] - '0'}{Program.player.hp[0].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 6);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[0] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[1] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[14] != null && Program.player.slotfilled[15] != null) Console.Write("E");
                    else if (Program.player.slotfilled[14] != null || Program.player.slotfilled[15] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "T":
                    if (Program.player.hp[1] <= 0) return;
                    else if (Program.player.hp[1] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[1] < 50) && (Program.player.hp[1] > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hp[1] == 100) Console.Write("00");
                    else if (Program.player.hp[1] == 0) Console.Write("00");
                    else if (Program.player.hp[1] < 10) Console.Write($"0{Program.player.hp[1].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[1].ToString()[0] - '0'}{Program.player.hp[1].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 7);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[2] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[3] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[16] != null && Program.player.slotfilled[17] != null && Program.player.slotfilled[24] != null) Console.Write("E");
                    else if (Program.player.slotfilled[16] != null || Program.player.slotfilled[17] != null || Program.player.slotfilled[24] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "La":
                    if (Program.player.hp[2] <= 0) return;
                    else if (Program.player.hp[2] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[2] < 50) && (Program.player.hp[2] > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hp[2] == 100) Console.Write("00");
                    else if (Program.player.hp[2] == 0) Console.Write("00");
                    else if (Program.player.hp[2] < 10) Console.Write($"0{Program.player.hp[2].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[2].ToString()[0] - '0'}{Program.player.hp[2].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 8);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[4] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[5] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[18] != null && Program.player.slotfilled[19] != null) Console.Write("E");
                    else if (Program.player.slotfilled[18] != null || Program.player.slotfilled[19] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "Ra":
                    if (Program.player.hp[3] <= 0) return;
                    else if (Program.player.hp[3] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[3] < 50) && (Program.player.hp[3] > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hp[3] == 100) Console.Write("00");
                    else if (Program.player.hp[3] == 0) Console.Write("00");
                    else if (Program.player.hp[3] < 10) Console.Write($"0{Program.player.hp[3].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[3].ToString()[0] - '0'}{Program.player.hp[3].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 9);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[6] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[7] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[20] != null && Program.player.slotfilled[21] != null) Console.Write("E");
                    else if (Program.player.slotfilled[20] != null || Program.player.slotfilled[21] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "Lh":
                    if (Program.player.hp[4] <= 0) return;
                    else if (Program.player.hp[4] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[4] < 50) && (Program.player.hp[4] > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(96, 18);
                    Console.Write("██▌");
                    Console.SetCursorPosition(130, 10);
                    if (Program.player.hp[4] == 100) Console.Write("00");
                    else if (Program.player.hp[4] == 0) Console.Write("00");
                    else if (Program.player.hp[4] < 10) Console.Write($"0{Program.player.hp[4].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[4].ToString()[0] - '0'}{Program.player.hp[4].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 10);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[8] != null) Console.Write("E|");
                    else Console.Write("N|");
                    if (Program.player.slotfilled[22] != null) Console.Write("E");
                    else Console.Write("N");
                    break;
                case "Rh":
                    if (Program.player.hp[5] <= 0) return;
                    else if (Program.player.hp[5] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[5] < 50) && (Program.player.hp[5] > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(113, 18);
                    Console.Write("▐██");
                    Console.SetCursorPosition(130, 11);
                    if (Program.player.hp[5] == 100) Console.Write("00");
                    else if (Program.player.hp[5] == 0) Console.Write("00");
                    else if (Program.player.hp[5] < 10) Console.Write($"0{Program.player.hp[5].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[5].ToString()[0] - '0'}{Program.player.hp[5].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 11);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[9] != null) Console.Write("E|");
                    else Console.Write("N|");
                    if (Program.player.slotfilled[23] != null) Console.Write("E");
                    else Console.Write("N");
                    break;
                case "Ll":
                    if (Program.player.hp[6] <= 0) return;
                    else if (Program.player.hp[6] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[6] < 50) && (Program.player.hp[6] > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hp[6] == 100) Console.Write("00");
                    else if (Program.player.hp[6] == 0) Console.Write("00");
                    else if (Program.player.hp[6] < 10) Console.Write($"0{Program.player.hp[6].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[6].ToString()[0] - '0'}{Program.player.hp[6].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 12);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[10] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[11] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[25] != null && Program.player.slotfilled[26] != null) Console.Write("E");
                    else if (Program.player.slotfilled[25] != null || Program.player.slotfilled[26] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "Rl":
                    if (Program.player.hp[7] <= 0) return;
                    else if (Program.player.hp[7] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[7] < 50) && (Program.player.hp[7] > 15)) Console.ForegroundColor = ChrHalf;
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
                    if (Program.player.hp[7] == 100) Console.Write("00");
                    else if (Program.player.hp[7] == 0) Console.Write("00");
                    else if (Program.player.hp[7] < 10) Console.Write($"0{Program.player.hp[7].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[7].ToString()[0] - '0'}{Program.player.hp[7].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 13);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[10] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[11] != null) Console.Write("E");
                    else Console.Write("N");
                    if (Program.player.slotfilled[27] != null && Program.player.slotfilled[28] != null) Console.Write("E");
                    else if (Program.player.slotfilled[27] != null || Program.player.slotfilled[28] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "Lf":
                    if (Program.player.hp[8] <= 0) return;
                    else if (Program.player.hp[8] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[8] < 50) && (Program.player.hp[8] > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(100, 27);
                    Console.Write("████▌");
                    Console.SetCursorPosition(130, 14);
                    if (Program.player.hp[8] == 100) Console.Write("00");
                    else if (Program.player.hp[8] == 0) Console.Write("00");
                    else if (Program.player.hp[8] < 10) Console.Write($"0{Program.player.hp[8].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[8].ToString()[0] - '0'}{Program.player.hp[8].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 14);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[12] != null) Console.Write("E|");
                    else Console.Write("N|");
                    if (Program.player.slotfilled[29] != null && Program.player.slotfilled[30] != null) Console.Write("E");
                    else if (Program.player.slotfilled[29] != null || Program.player.slotfilled[30] != null) Console.Write("H");
                    else Console.Write("N");
                    break;
                case "Rf":
                    if (Program.player.hp[9] <= 0) return;
                    else if (Program.player.hp[9] > 50) Console.ForegroundColor = ChrFull;
                    else if ((Program.player.hp[9] < 50) && (Program.player.hp[9] > 15)) Console.ForegroundColor = ChrHalf;
                    else Console.ForegroundColor = ChrCrit;

                    Console.SetCursorPosition(107, 27);
                    Console.Write("▐████");
                    Console.SetCursorPosition(130, 15);
                    if (Program.player.hp[9] == 100) Console.Write("00");
                    else if (Program.player.hp[9] == 0) Console.Write("00");
                    else if (Program.player.hp[9] < 10) Console.Write($"0{Program.player.hp[9].ToString()[0] - '0'}");
                    else Console.Write($"{Program.player.hp[9].ToString()[0] - '0'}{Program.player.hp[9].ToString()[1] - '0'}");
                    Console.SetCursorPosition(134, 15);
                    Console.ForegroundColor = GenFore;
                    if (Program.player.slotfilled[13] != null) Console.Write("E|");
                    else Console.Write("N|");
                    if (Program.player.slotfilled[31] != null && Program.player.slotfilled[32] != null) Console.Write("E");
                    else if (Program.player.slotfilled[31] != null || Program.player.slotfilled[32] != null) Console.Write("H");
                    else Console.Write("N");
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
                    if (Program.player.hp[0] >= 15)
                    {
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
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                y++;
            }
            Console.SetCursorPosition(131, 32);
            if (Program.player.hp[0] <= 15) Console.Write("   ");
            else if (Program.move.x > 99) Console.Write(Program.move.x);
            else if (Program.move.x < 10) Console.Write($"00{Program.move.x}");
            else Console.Write($"0{Program.move.x}");

            Console.SetCursorPosition(131, 34);
            if (Program.player.hp[0] <= 15) Console.Write("   ");
            else if (Program.move.y > 99) Console.Write(Program.move.y);
            else if (Program.move.y < 10) Console.Write($"00{Program.move.y}");
            else Console.Write($"0{Program.move.y}");

            Console.SetCursorPosition(132, 36);
            if (Program.player.hp[0] <= 15) Console.Write(" ");
            else Console.Write(Program.move.z);

            Console.SetCursorPosition(132, 38);
            if (Program.player.hp[0] <= 15) Console.Write(" ");
            else if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 2] > 0) Console.Write("Y");
            else Console.Write("N");

            Console.SetCursorPosition(132, 39);
            if (Program.player.hp[0] <= 15) Console.Write(" ");
            else if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 0] == 1)
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
            if (Program.player.hp[0] <= 15) Console.Write(" ");
            else if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 4] == 1) Console.Write("↓");
            else if (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 4] == 2) Console.Write("↑");
            else Console.Write("N");
        }
        public static void Wait()
        {
            while (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 0] == 1 && Enemy.Currentget().Ded())
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
                        Program.move.Reuturn();
                        return;
                    case ConsoleKey.I:
                        //inventory
                        break;
                    case ConsoleKey.Enter:
                        BattleScript.Battle();
                        return;
                    case ConsoleKey.S:
                        Program.player.Chsave();
                        Program.move.Mapsave(Program.player.name);
                        Program.inv.Invsave(Program.player.name);
                        break;
                    case ConsoleKey.Backspace:
                        Program.player.Chsave();
                        Program.move.Mapsave(Program.player.name);
                        Program.inv.Invsave(Program.player.name);
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        public static bool BtlWait()
        {
            while (Program.move.map[Program.move.x, Program.move.y, Program.move.z, 0] == 1)
            {
                Clear();
                Console.ForegroundColor = GenFore;
                Console.BackgroundColor = GenBack;
                Console.SetCursorPosition(4, 4);
                Console.Write("if you exit now it will not save!");
                Enemy.Currentget().Print();
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        Settings();
                        Refresh("");
                        break;
                    case ConsoleKey.M:
                        Enemy.Currentget().Hit(Program.player.hp[4] / 100, Program.player.dmgm);
                        return false;
                    case ConsoleKey.O:
                        Enemy.Currentget().Hit(Program.player.hp[5] / 100, Program.player.dmgo);
                        return false;
                    case ConsoleKey.I:
                        //if inventoy thingy{
                        //    return false;
                        //}
                        break;
                    case ConsoleKey.Backspace:
                        return true;
                        break;
                    default:
                        break;
                }
            }
            return true;
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
                        Program.inv.Loot();
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
                        Program.move.Mapsave(Program.player.name);
                        Program.inv.Invsave(Program.player.name);
                        break;
                    case ConsoleKey.Backspace:
                        Program.player.Chsave();
                        Program.move.Mapsave(Program.player.name);
                        Program.inv.Invsave(Program.player.name);
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
#pragma warning disable IDE0066 // Convert switch statement to expression
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
#pragma warning restore IDE0066 // Convert switch statement to expression
        }
    }
}
