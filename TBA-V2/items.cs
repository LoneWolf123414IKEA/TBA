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
            { 2, 10}
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
            "Stimpack"
        };

        public List<int> inv = new List<int>();
        public int maxinv;

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

        public void loot()
        {
            int loot = rand.wh();
            if (loot == names.Length + 1)
            {
                Program.player.res += 0.1F;
            }
            else if (loot == names.Length + 2) ;
            else if (inv.Count() <= maxinv)
            {

                Console.WriteLine("do you want " + names[loot] + "?");
                if (Console.ReadLine() == "y") inv.Add(loot);
            }
            else if (inv.Count() > maxinv)
            {
                Console.WriteLine("do you want " + names[loot] + "?");
                if (Console.ReadLine() == "y")
                {
                    for (int i = 0; i < inv.Count(); i++)
                    {
                        Console.WriteLine(i + 1 + " " + names[inv[i]]);
                    }
                    Console.WriteLine("\nchoose item to discard");
                    try
                    {
                        inv.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                    }
                    catch
                    {
                        Console.WriteLine("out of range, removing first object");
                        inv.RemoveAt(0);
                    }
                    inv.Add(loot);
                }
            }
            Program.move.map[Program.move.x, Program.move.y, 2]--;
        }
    }
}
