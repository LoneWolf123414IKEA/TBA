using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA_V2
{
    internal class chr
    {
        public string name = "";
        public float[] hp = 
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
        }
        public int?[] slotfilled = 
        {
            null,//undercoif
            null,//chain coif
            null,//torso underarmour
            null,//torso chain
            null,//left arm underarmour
            null,//left arm chain
            null,//right arm underarmour
            null,//right arm chain
            null,//left under gauntlet/glove
            null,//right under gauntlet/glove
            null,//legs underarmour
            null,//legs chain
            null,//left shoe
            null,//right shoe
            
            null,//head - top
            null,//head - under
            null,//torso - front
            null,//torso - back
            null,//left rerebrace
            null,//left vambrace
            null,//right rerebrace
            null,//right vambrace
            null,//left gauntlet
            null,//right gauntlet
            null,//hips
            null,//left thighs
            null,//left calves
            null,//right thighs
            null,//right calves
            null,//left heel
            null,//left toes
            null,//right heel
            null//right toes
        }
        public int dmgm;
        public int dmgo;
        public int xp;
        public int ill;
        public int spll;
        public int kills;
        public bool alive = true;
        public void Chgen()
        {
            dmgm = 5;
            dmgo = 2;

            xp = 0;
            ill = 0;
            spll = 0;
            kills = 0;
        }
        public void Chload(string nam)
        {
            int i = 0;
            TextReader Chl = new StreamReader(nam);
            name = Chl.ReadLine();
            hp = Chl.ReadLine().Split("¦").Select(float.Parse)
            foreach (string j in Chl.ReadLine().Split("¦"))
            {
                if (j == "N") slotfilled[i] = null;
                else slotfilled[i] = int.Parse(j);
                i++;
            }
                

            dmgm = int.Parse(Chl.ReadLine());
            dmgo = int.Parse(Chl.ReadLine());

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
            
            Chs.Write(hp[0]);
            for (int i = 1; i < hp.Length; i++) Chs.Write("¦" + hp[i]);
            Chs.WriteLine();
            
            Chs.Write(slotsfilled[0]);
            for (int i = 1; i < slotsfilled.Lenth; i++) 
            {
                if (slotsfilled[i] != null] Chs.Write("¦" + slotsfilled[i]);
                else Chs.Write("¦N");
            }
            Chs.WriteLine();
            
            Chs.WriteLine(dmgm);
            Chs.WriteLine(dmgo);
            
            Chs.WriteLine(xp);
            Chs.WriteLine(ill);
            Chs.WriteLine(spll);
            Chs.WriteLine(kills);
            Chs.Close();
        }
    }
}
