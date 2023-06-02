using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextBasedAdventureV2
{
    internal class Enemy
    {
        private readonly UtilityFunctions rand = new();
        private readonly static int[][] randarrs =
        {
            new int[]{
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            new int[]{
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            new int[]{
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            },
            new int[]{
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            }
        };


        public Enemy(int floor)
        {
            name = "placeholder";
        }
        public Enemy(string path)
        {
            StreamReader ItmLdr = new(path);
            name = ItmLdr.ReadLine();
            hp = float.Parse(ItmLdr.ReadLine());
            armr = float.Parse(ItmLdr.ReadLine());
            ItmLdr.Close();
        }

        

        private string name;
        private float hp = 100;
        private float armr = 0.1F;
        public float dmg = 5;
        public bool Ded()
        {
            return (hp >= 0);
        }
        public void Print()
        {
            IO.Clear();
            Console.SetCursorPosition(4, 5);
            Console.Write($"{name}");
            Console.SetCursorPosition(4, 6);
            Console.Write($"hp: {hp}");
        }
        public static Enemy Currentget()
        {
            return Program.move.enemy[Program.move.x, Program.move.y, Program.move.z];
        }
        public void Save(int x, int y, int z)
        { 
            StreamWriter Mos = new($"Data\\S\\{Program.player.name}\\Map\\{x};{y};{z}.mon");
            if (Program.move.map[x, y, z, 3] == 0)
            {
                Mos.WriteLine("N/A");
                Mos.Close();
                return;
            }
            Mos.WriteLine(name);
            Mos.WriteLine(hp);
            Mos.WriteLine(armr);
            Mos.Close();
        }

        public bool Hit(float acc, float dmg)
        {
            float aacc = (1 - armr) * acc;
            if (aacc >= rand.Pro())
            {
                hp -= dmg;
                return true;
            }
            return false;
        }
    }
}
