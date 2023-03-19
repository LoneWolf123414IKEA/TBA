using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            { 3, 0},
            { 3, 1},
            { 3, 2},
            { 3, 3},
            { 3, 4},
            { 3, 5},
            { 3, 6},
            { 3, 7},
            { 3, 8},
            { 3, 9},
            { 3, 10},
            { 3, 11},
            { 3, 12},
            { 3, 13},
            { 3, 14},
            { 3, 15},
            { 3, 16},
            { 3, 17},
            { 3, 18},
            { 3, 19},
            { 3, 20},
            { 3, 21},
            { 3, 22},
            { 3, 23},
            { 3, 24},
            { 3, 25},
            { 3, 26},
            { 3, 27},
            { 3, 28},
            { 3, 29}
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
            "Cloth Coif",
            "Mail Coif",
            "Kettle Helm",
            "Brigandine",
            "Hauberk",
            "Cuirass",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
        };
        public Armour[] Armours =
        {

        };

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
