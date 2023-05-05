using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureV2
{
    internal class CharacterCode
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
        };
        public int?[] slotfilled =
        {
            null,//undercoif                0
            null,//chain coif               1
            null,//torso underarmour        2    
            null,//torso chain              3
            null,//left arm underarmour     4
            null,//left arm chain           5
            null,//right arm underarmour    6
            null,//right arm chain          7
            null,//left under gauntlet/glove  8
            null,//right under gauntlet/glove 9
            null,//legs underarmour         10
            null,//legs chain               11
            null,//left shoe                12
            null,//right shoe               13    
            
            null,//head - top               14
            null,//head - under             15
            null,//torso - front            16
            null,//torso - back             17
            null,//left rerebrace           18
            null,//left vambrace            19
            null,//right rerebrace          20
            null,//right vambrace           21
            null,//left gauntlet            22
            null,//right gauntlet           23
            null,//hips                     24
            null,//left thighs              25
            null,//left calves              26
            null,//right thighs             27
            null,//right calves             28
            null,//left heel                29
            null,//left toes                30
            null,//right heel               31
            null//right toes                32
        };
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
            hp = Array.ConvertAll(Chl.ReadLine().Split("¦"), float.Parse);
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
            StreamWriter Chs = new StreamWriter($"Data\\S\\{name}.save");
            Chs.WriteLine(name);
            
            Chs.Write(hp[0]);
            for (int i = 1; i < hp.Length; i++) Chs.Write("¦" + hp[i]);
            Chs.WriteLine();
            
            Chs.Write(slotfilled[0]);
            for (int i = 1; i < slotfilled.Length; i++)
            {
                if (slotfilled[i] != null) Chs.Write("¦" + slotfilled[i]);
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
