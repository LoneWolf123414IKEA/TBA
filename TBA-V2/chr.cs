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
        public float hhp = 100;
        public float thp = 100;
        public float lahp = 100;
        public float rahp = 100;
        public float lhhp = 100;
        public float rhhp = 100;
        public float llhp = 100;
        public float rlhp = 100;
        public float lfhp = 100;
        public float rfhp = 100;
        public string ha;
        public string ta;
        public string laa;
        public string raa;
        public string lha;
        public string rha;
        public string rla;
        public string lla;
        public string rfa;
        public string lfa;
        public int dmgm;
        public int dmgo;
        public int xp;
        public int ill;
        public int spll;
        public int kills;
        public bool alive = true;
        public void Chgen()
        {



            hhp = 100;
            thp = 100;
            lahp = 100;
            rahp = 100;
            lhhp = 100;
            rhhp = 100;
            llhp = 100;
            rlhp = 100;
            lfhp = 100;
            rfhp = 100;

            ha = "";
            ta = "";
            laa = "";
            raa = "";
            lha = "";
            rha = "";
            lla = "";
            rla = "";
            lfa = "";
            rfa = "";

            dmgm = 5;
            dmgo = 2;

            xp = 0;
            ill = 0;
            spll = 0;
            kills = 0;
        }
        public void Chload(string nam)
        {
            TextReader Chl = new StreamReader(nam);
            name = Chl.ReadLine();
            hhp = float.Parse(Chl.ReadLine());
            thp = float.Parse(Chl.ReadLine());
            lahp = float.Parse(Chl.ReadLine());
            rahp = float.Parse(Chl.ReadLine());
            lhhp = float.Parse(Chl.ReadLine());
            rhhp = float.Parse(Chl.ReadLine());
            llhp = float.Parse(Chl.ReadLine());
            rlhp = float.Parse(Chl.ReadLine());
            lfhp = float.Parse(Chl.ReadLine());
            rfhp = float.Parse(Chl.ReadLine());

            ha = Chl.ReadLine();
            ta = Chl.ReadLine();
            laa = Chl.ReadLine();
            raa = Chl.ReadLine();
            lha = Chl.ReadLine();
            rha = Chl.ReadLine();
            lla = Chl.ReadLine();
            rla = Chl.ReadLine();
            lfa = Chl.ReadLine();
            rfa = Chl.ReadLine();

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

            Chs.WriteLine(hhp);
            Chs.WriteLine(thp);
            Chs.WriteLine(lahp);
            Chs.WriteLine(rahp);
            Chs.WriteLine(lhhp);
            Chs.WriteLine(rhhp);
            Chs.WriteLine(llhp);
            Chs.WriteLine(rlhp);
            Chs.WriteLine(lfhp);
            Chs.WriteLine(rfhp);

            Chs.WriteLine(ha);
            Chs.WriteLine(ta);
            Chs.WriteLine(laa);
            Chs.WriteLine(raa);
            Chs.WriteLine(lha);
            Chs.WriteLine(rha);
            Chs.WriteLine(lla);
            Chs.WriteLine(rla);
            Chs.WriteLine(lfa);
            Chs.WriteLine(rfa);

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
