using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TBA_V2
{
    internal class battlescript
    {
        private Random r = new Random();
        private rand rand = new rand();
        private string name;
        private float hp;
        private float res;
        private int dmg;
        private int id;
        public void mongen(int type)
        {
            switch (type)
            {
                case 0:
                    name = "skeleton";
                    hp = r.Next(10, 21);
                    res = r.Next(5, 14) / 100;
                    dmg = r.Next(5, 11);
                    break;
                case 1:
                    name = "knight";
                    hp = r.Next(23, 31);
                    res = r.Next(95, 100) / 100;
                    dmg = r.Next(15, 20);
                    break;
                default:
                    break;
            }
        }
        public bool? battle()
        {
            return null;
        }
    }
}
