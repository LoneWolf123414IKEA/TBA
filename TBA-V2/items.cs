using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TBA_V2
{
    internal class items
    {
        private rand rand = new rand();
        public float[,] id =
        {
            { 1, 10},
            { 1, 11},
            { 1, 4242},
            { 0, 0},
            { 2, 1 },
            { 2, 0.1F},
            { 0, 1},
            { 2, 10},
            { 0, 15},
        };
        public string[] names =
        {
            "Club",
            "Wood Sword",
            "Needle",
            "Anchient Weapon",
            "Small Heal",
            "Smaller Heal",
            "HealthKit",
            "Stimpack",
            "spear",
        };
        public static Item[] ItemList;
        public static void itemboot()
        {
            StreamReader Index = new StreamReader("Data\\Items\\Index.text");
            int ItmCnt = int.Parse(Index.ReadLine());
            ItemList = new Item[ItmCnt];
            for (int id = 0; id < ItmCnt; id++)
            {
                ItemList[id].Name = Index.ReadLine();
                ItemList[id].id = id;
                StreamReader ItmLdr = new StreamReader($"Data\\Items\\{id}_{ItemList[id].Name}.item");
                ItemList[id].invscript = ItmLdr.ReadLine();
                ItemList[id].btlscript = ItmLdr.ReadLine();
                ItemList[id].eatscript = ItmLdr.ReadLine();
                ItemList[id].eqpscript = ItmLdr.ReadLine();
                ItemList[id].x = int.Parse(ItmLdr.ReadLine());
                ItemList[id].y = int.Parse(ItmLdr.ReadLine());
                ItemList[id].z = int.Parse(ItmLdr.ReadLine());
                ItemList[id].stx = ItmLdr.ReadLine();
                ItemList[id].btx = ItmLdr.ReadLine();
                ItmLdr.Close();
            }
            Index.Close();
        }
        public static void NewItem()
        {
            Console.Clear();
            StreamWriter Index = new StreamWriter("Data\\Items\\Index.text");
            for (int i = 0; i < ItemList.Length; i++)
            {
                Index.WriteLine(ItemList[i].Name);
            }
            int id = ItemList.Length;
            Console.WriteLine("Input name of item");
            string name = Console.ReadLine();
            Index.WriteLine(name);
            Index.Close();
            StreamWriter New = new StreamWriter($"Data\\Items\\{id}_{name}.item");
            Console.WriteLine("Input Inventory script of item");
            New.WriteLine(Console.ReadLine());
            Console.WriteLine("Input Battle sctipt of item");
            New.WriteLine(Console.ReadLine());
            Console.WriteLine("Input Eat script of item");
            New.WriteLine(Console.ReadLine());
            Console.WriteLine("Input Equip script of item");
            New.WriteLine(Console.ReadLine());
            Console.WriteLine("Input x");
            New.WriteLine(Console.ReadLine());
            Console.WriteLine("Input y");
            New.WriteLine(Console.ReadLine());
            Console.WriteLine("Input z");
            New.WriteLine(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("███████████████████");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("█                 █");
            Console.WriteLine("███████████████████");
            Console.SetCursorPosition(1, 1);
            char[,] s = new char[18, 9];
            int x = 0;
            int y = 0;
            bool brk = true;
            Console.CursorVisible = true;
            while (brk)
            {
                s[x, y] = (char)Console.Read();
                Console.SetCursorPosition(x + 1, y + 1);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y != 0)
                        {
                            y--;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y != 8)
                        {
                            y++;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x != 0)
                        {
                            x--;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x != 17)
                        {
                            x++;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.Enter:
                        brk = false; 
                        break;
                }
            }
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (s[i, j] == null) s[i, j] = ' ';
                }
            }
            New.WriteLine(s);
            Console.Clear();
            Console.WriteLine("████████████████████████████████");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("█??????????????????????????????█");
            Console.WriteLine("████████████████████████████████");
            Console.SetCursorPosition(1, 1);
            s = new char[30, 15];
            x = 0;
            y = 0;
            brk = true;
            Console.CursorVisible = true;
            while (brk)
            {
                s[x, y] = (char)Console.Read();
                Console.SetCursorPosition(x + 1, y + 1);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y != 0)
                        {
                            y--;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y != 14)
                        {
                            y++;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x != 0)
                        {
                            x--;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x != 29)
                        {
                            x++;
                            Console.SetCursorPosition(x + 1, y + 1);
                        }
                        break;
                    case ConsoleKey.Enter:
                        brk = false;
                        break;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (s[i, j] == null) s[i, j] = ' ';
                }
            }
            New.WriteLine(s);
        }

        public List<int> inv = new List<int>();
        public int maxinv;
        public int mainhand;
        public int offhand;
        public void invgen(string name)
        {
            if (name == "¦")
            {
                maxinv = 3;
                inv.Add(2);
            }
            else
            {
                StreamReader inl = new StreamReader(name + ".inv");
                maxinv = int.Parse(inl.ReadLine());
                inv = inl.ReadLine().Split("¦").Select(int.Parse).ToList();
                inl.Close();
            }
        }

        public void invsave(string name)
        {
            StreamWriter ins = new StreamWriter(name + ".inv");
            ins.WriteLine(maxinv);
            ins.Write(inv[0]);
            for (int i = 1; i < inv.Count(); i++) ins.Write("¦" + inv[i]);
            ins.Close();
        }
        public void Inv()
        {
            IO.Clear();
            for (int i = 0; i < inv.Count(); i++)
            {
                Console.SetCursorPosition(5, i + 4);
                Console.Write(i + 1 + " " + names[inv[i]]);
            }
            Console.SetCursorPosition(4, 4);
            Console.Write('►');
            int pos = 4;
            while (true)
            {
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Escape:
                        return;
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
                        if (pos != inv.Count + 3)
                        {
                            Console.SetCursorPosition(4, pos);
                            Console.Write(' ');
                            pos++;
                            Console.SetCursorPosition(4, pos);
                            Console.Write('►');
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (id[inv[pos - 4], 0])
                        {
                            case 0:
                                break;
                            case 1:
                                Console.SetCursorPosition(5, 5+inv.Count);
                                Console.Write("main or offhand");
                                switch (Console.ReadKey(false).Key)
                                {
                                    case ConsoleKey.D1:
                                        mainhand = pos - 4;
                                        break;
                                    default:
                                        offhand = pos - 4;
                                        break;
                                }
                                break;
                            case 2:
                                //heal
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public void loot()
        {
            int loot = rand.wh();
            if (loot == names.Length);
            else if (inv.Count() <= maxinv)
            {
                IO.Clear();
                Console.SetCursorPosition(5, 4);
                Console.Write("do you want " + names[loot] + "?\n");
                if (Console.ReadKey(false).Key == ConsoleKey.Y)
                {
                    if (inv[0] == 2) inv.Clear();
                    inv.Add(loot);
                }
            }
            else if (inv.Count() > maxinv)
            {
                IO.Clear();
                Console.SetCursorPosition(5, 4);
                Console.Write("do you want " + names[loot] + "?\n");
                if (Console.ReadKey(false).Key == ConsoleKey.Y)
                {
                    for (int i = 0; i < inv.Count(); i++)
                    {
                        Console.SetCursorPosition(5, i+5);
                        Console.Write(i + 1 + " " + names[inv[i]]);
                    }
                    Console.SetCursorPosition(5, Console.CursorTop + 1);
                    Console.Write("choose item to discard: ");
                    try
                    {
                        inv.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                    }
                    catch
                    {
                        Console.SetCursorPosition(5, Console.CursorTop + 1);
                        Console.Write("out of range, removing first object\n");
                        inv.RemoveAt(0);
                    }
                    inv.Add(loot);
                }
            }
            Program.move.map[Program.move.x, Program.move.y, Program.move.z, 2]--;
        }
    }
}
