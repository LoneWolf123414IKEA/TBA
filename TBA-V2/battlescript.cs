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
            int temp = 0;
            while (hp > 0 && Program.player.hp > 0)
            {
                Console.Clear();
                IO.O($"{name} statistics:\nhealth: {hp}\n{Program.player.name} statistics:\nhealth: {Program.player.hp}\ndmg: {Program.player.dmg}\nresistance: {Program.player.res}\n\nWaht will you do?\n");
                switch (IO.Itxt())
                {
                    case "attack":
                        Program.player.spll++;
                        if (rand.wh(12, 88))
                        {
                            hp -= r.Next(Program.player.dmg, Program.player.dmg + 5);
                        }
                        else
                        {
                            hp -= r.Next(Program.player.dmg, Program.player.dmg + 5) * (1 - res);
                        }
                        break;
                    case "item":
                        Program.player.spll++;
                        for (int i = 0; i < Program.inv.inv.Count(); i++)
                        {
                            IO.O("\n" + (i + 1) + ". " + Program.inv.names[Program.inv.inv[i]]);
                        }
                        try
                        {
                            temp = IO.Iint() - 1;
                            id = Program.inv.inv[temp];
                        }
                        catch
                        {
                            Program.player.ill++;
                            id = 3;
                        }
                        IO.O($"\n\n{Program.inv.id[id, 0]} { Program.inv.id[id, 1]}\n");
                        Console.Read();
                        switch (Program.inv.id[id, 0])
                        {
                            case 0:
                                switch (Program.inv.id[id, 1])
                                {
                                    case 0:
                                        hp += 20;
                                        res += 1;
                                        break;
                                    case 1:
                                        Program.player.res -= 0.1F;
                                        Program.player.dmg -= 2;
                                        Program.player.hp += 100;
                                        Program.inv.inv.RemoveAt(temp);
                                        break;
                                    case 2:
                                        if (res > 0.5F) hp -= r.Next(15, 20);
                                        else hp -= r.Next(5);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 1:
                                hp -= Program.inv.id[id, 1];
                                break;
                            case 2:
                                Program.player.hp += Program.inv.id[id, 1];
                                Program.inv.inv.RemoveAt(temp);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "run":
                        Program.player.spll++;
                        return false;
                    default:
                        Program.player.ill++;
                        break;

                }
                if (rand.wh(12, 88))
                {
                    Program.player.hp -= r.Next(dmg, dmg + 5);
                }
                else
                {
                    Program.player.hp -= r.Next(dmg, dmg + 5) * (1 - Program.player.res);
                }
            }
            if (Program.player.hp < 0) return null;
            return true;
        }
    }
}
