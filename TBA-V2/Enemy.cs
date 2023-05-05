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

        public void save(int x, int y, int z)
        {
            StreamWriter Mos = new StreamWriter($"Data\\S\\{name}\\Map\\{x}{y}{z}.mon");
            Mos.WriteLine(name);
            Mos.Write($"{hp[0]};{hp[1]};{hp[2]};{hp[3]};{hp[4]};{hp[5]};{hp[6]};{hp[7]};{hp[8]};{hp[9]}");
            Mos.Close();
        }
    }
}
