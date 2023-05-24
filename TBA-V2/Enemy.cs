using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextBasedAdventureV2
{
    internal class Enemy
    {
        private UtilityFunctions rand = new UtilityFunctions();
        private static int[][] randarrs =
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
            StreamReader ItmLdr = new StreamReader(path);
            name = ItmLdr.ReadLine();
            hp = Array.ConvertAll(ItmLdr.ReadLine().Split(";"), s => float.Parse(s));
            ItmLdr.Close();
        }

        

        private string name;
        private float[] hp =
        {
            100,//h
            100,//t
            100,//la
            100,//ra
            100,//lh
            100,//rh
            100,//ll
            100,//rl
            100,//lf
            100//rf
        };
        private float[] armr =
        {
            0.1F,//h
            0.1F,//t
            0.1F,//la
            0.1F,//ra
            0.1F,//lh
            0.1F,//rh
            0.1F,//ll
            0.1F,//rl
            0.1F,//lf
            0.1F//rf
        };

        public void save(int x, int y, int z)
        {
            StreamWriter Mos = new StreamWriter($"Data\\S\\{Program.player.name}\\Map\\{x}{y}{z}.mon");
            Mos.WriteLine(name);
            Mos.Write($"{hp[0]};{hp[1]};{hp[2]};{hp[3]};{hp[4]};{hp[5]};{hp[6]};{hp[7]};{hp[8]};{hp[9]}");
            Mos.Close();
        }

        public bool hit(float acc, float dmg, int hit)
        {
            float aacc = (1 - armr[hit]) * acc;
            if (aacc >= rand.pro())
            {
                hp[hit] -= dmg;
                return true;
            }
            return false;
        }
    }
}
