using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TBA_V2
{
    internal class move
    {
        private rand rand = new rand();
        public int[,,] map = new int[260, 260, 4];
        /*
        first indicats x coordinate
        second indicates y coordinate
        third indicates function
            for pos 0:
                0 = special
                1 = monster
                2 = boss
            for pos 1:
                this one indicates witch iddiration
                for special:
                    0 = end
                    1 = nothing
                for boss:
                    0 = first boss
                    1 = second and so on
                for monster;
                    same as boss but for monsters
            for pos 2:
                this only indicates lootability, 0 is no loot and anytitng above is amount of times
            for pos 3:
                visited or not, 0 or a 1
            
        */
        public int x;
        public int y;
        private int lastx;
        private int lasty;
        public void mapgen(string name)
        {
            if (name == "¦")
            {
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 0] = rand.wh(new int[] { 1, 90 });
                        if (map[x1, y1, 0] == 0) map[x1, y1, 1] = 1;
                        else map[x1, y1, 1] = rand.wh(new int[] { 9, 1 });
                        map[x1, y1, 2] = rand.wh(new int[] { 10, 35, 4, 1 });

                        map[x1, y1, 3] = 0;

                        
                    }
                }
                map[0, 0, 1] = 1;
                map[0, 0, 0] = 0;
                map[0, 0, 2] = 1;
                map[0, 0, 3] = 1;

                map[255, 1, 0] = 0;
                map[255, 1, 1] = 0;
                map[255, 1, 2] = 0;

                map[20, 34, 0] = 2;
                map[20, 34, 1] = 0;
                map[20, 34, 2] = 5;

                map[200, 43, 0] = 2;
                map[200, 43, 1] = 1;
                map[200, 43, 2] = 7;

                map[32, 150, 0] = 2;
                map[32, 150, 1] = 1;
                map[32, 150, 2] = 8;

                map[2, 21, 0] = 2;
                map[2, 21, 1] = 1;
                map[2, 21, 2] = 9;

            }
            else
            {
                StreamReader mapl = new StreamReader(name + ".map");
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 0] = mapl.Read() - '0';
                        map[x1, y1, 1] = mapl.Read() - '0';
                        map[x1, y1, 2] = mapl.Read() - '0';
                        map[x1, y1, 3] = mapl.Read() - '0';

                    }
                }
                mapl.ReadLine();
                y = int.Parse(mapl.ReadLine());
                x = int.Parse(mapl.ReadLine());
                lastx = int.Parse(mapl.ReadLine());
                lasty = int.Parse(mapl.ReadLine());
                mapl.Close();
            }

        }
        public void mapsave(string name)
        {
            StreamWriter Mps = new StreamWriter(name + ".map");
            foreach (int i in map)
            {
                Mps.Write(i);
            }
            Mps.Write('\n');
            Mps.WriteLine(y);
            Mps.WriteLine(x);
            Mps.WriteLine(lastx);
            Mps.WriteLine(lasty);
            Mps.Close();
        }
        public void North()
        {
            if (x != 0)
            {
                if (map[x - 1, y, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lastx = x;
                    x--;
                    map[x, y, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }

        }
        public void South()
        {
            if (x != 255)
            {
                if (map[x + 1, y, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lastx = x;
                    x++;
                    map[x, y, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }
        }
        public void East()
        {
            if (y != 255)
            {
                if (map[x, y + 1, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lasty = y;
                    y++;
                    map[x, y, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }
        }
        public void West()
        {
            if (y != 0)
            {
                if (map[x, y - 1, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lasty = y;
                    y--;
                    map[x, y, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp--;
                Program.player.ill++;
            }
        }

        public void reuturn()
        {
            x = lastx;
            y = lasty;
        }
        public void show()
        {
            Console.Clear();
            for (int y1 = 0; y1 < 260; y1++)
            {
                for (int x1 = 0; x1 < 260; x1++)
                {
                    if ((map[x1, y1, 3]) == 0) IO.O("■");
                    else if (x1 == x && y1 == y) IO.O("▣");
                    else
                    {
                        switch (map[x1, y1, 1])
                        {
                            case 0:
                                if ((map[x1, y1, 1]) == 0) IO.O("▩");
                                else if ((map[x1, y1, 2]) == 0) IO.O("□");
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    IO.O("▦");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                IO.O("▧");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                IO.O("▧");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;

                        }
                    }
                }
                IO.O("\n");
            }
            Console.Clear();
        }
    }
}
