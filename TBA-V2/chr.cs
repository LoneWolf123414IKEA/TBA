using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA_V2
{
    internal class chr
    {
        public string name;
        public float hp = 100;
        public float res;
        public int dmg;
        public int xp;
        public int ill;
        public int spll;
        public int kills;
        public bool alive = true;
        public void Chgen()
        {


            hp = 125;
            res = 0.05F;
            dmg = 5;
            xp = 0;
            ill = 0;
            spll = 0;
            kills = 0;
        }
        public void Chload(string nam)
        {
            TextReader Chl = new StreamReader(nam + ".save");
            name = Chl.ReadLine();
            hp = float.Parse(Chl.ReadLine());
            res = float.Parse(Chl.ReadLine());
            dmg = int.Parse(Chl.ReadLine());
            xp = int.Parse(Chl.ReadLine());
            ill = int.Parse(Chl.ReadLine());
            spll = int.Parse(Chl.ReadLine());
            kills = int.Parse(Chl.ReadLine());
            Chl.Close();
        }
        public void Chsave()
        {
            StreamWriter Chs = new StreamWriter(name + ".save");
            Chs.WriteLine(name);
            Chs.WriteLine(hp);
            Chs.WriteLine(res);
            Chs.WriteLine(dmg);
            Chs.WriteLine(xp);
            Chs.WriteLine(ill);
            Chs.WriteLine(spll);
            Chs.WriteLine(kills);
            Chs.Close();
        }
    }
}
