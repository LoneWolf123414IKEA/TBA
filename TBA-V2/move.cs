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
        public int[,,,] map = new int[260, 260, 4, 5];
        /*
        first indicats x coordinate
        second indicates y coordinate
        third indicates z coordinate
        fourth indicates function
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
            for pos 4:
                stairroom, 0 no, 1 down, 2 up
            
        */
        public int x;
        public int y;
        public int z = 0;
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
                        map[x1, y1, 0, 0] = rand.wh(new int[] { 1, 90 });
                        if (map[x1, y1, 0, 0] == 0) map[x1, y1, 0, 1] = 1;
                        else map[x1, y1, 0, 1] = rand.wh(new int[] { 9, 1 });
                        map[x1, y1, 0, 2] = rand.wh(new int[] { 10, 35, 4, 1 });
                        map[x1, y1, 0, 3] = 0;
                    }
                }
                map[0, 0, 0, 1] = 1;
                map[0, 0, 0, 0] = 0;
                map[0, 0, 0, 2] = 1;
                map[0, 0, 0, 3] = 1;

                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 1, 0] = rand.wh(new int[] { 1, 90 });
                        if (map[x1, y1, 1, 0] == 0) map[x1, y1, 1, 1] = 1;
                        else map[x1, y1, 1, 1] = rand.wh(new int[] { 1, 6, 3 });
                        map[x1, y1, 1, 2] = rand.wh(new int[] { 2, 5, 10, 35, 4, 1 });
                        map[x1, y1, 1, 3] = 0;
                    }
                }

                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 2, 0] = rand.wh(new int[] { 1, 90 });
                        if (map[x1, y1, 2, 0] == 0) map[x1, y1, 2, 1] = 1;
                        else map[x1, y1, 2, 1] = rand.wh(new int[] { 0, 1, 6, 3 });
                        map[x1, y1, 2, 2] = rand.wh(new int[] { 0, 1, 5, 10, 35, 4, 1 });
                        map[x1, y1, 2, 3] = 0;
                    }
                }

                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 3, 0] = rand.wh(new int[] { 1, 90 });
                        if (map[x1, y1, 3, 0] == 0) map[x1, y1, 3, 1] = 1;
                        else map[x1, y1, 3, 1] = rand.wh(new int[] { 0, 0, 1, 6, 3 });
                        map[x1, y1, 3, 2] = rand.wh(new int[] { 1, 0, 0, 1, 2, 10, 20, 38, 10 });
                        map[x1, y1, 3, 3] = 0;
                    }
                }

                map[255, 1, 3, 0] = 0;
                map[255, 1, 3, 1] = 0;
                map[255, 1, 3, 2] = 9;

                map[20, 34, 3, 0] = 2;
                map[20, 34, 3, 1] = 0;
                map[20, 34, 3, 2] = 9;

                map[200, 43, 3, 0] = 2;
                map[200, 43, 3, 1] = 1;
                map[200, 43, 3, 2] = 9;

                map[32, 150, 3, 0] = 2;
                map[32, 150, 3, 1] = 1;
                map[32, 150, 3, 2] = 9;

                map[2, 21, 3, 0] = 2;
                map[2, 21, 3, 1] = 1;
                map[2, 21, 3, 2] = 9;

            }
            else
            {
                StreamReader mapl = new StreamReader(name + ".map");
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 0, 0] = mapl.Read() - '0';
                        map[x1, y1, 0, 1] = mapl.Read() - '0';
                        map[x1, y1, 0, 2] = mapl.Read() - '0';
                        map[x1, y1, 0, 3] = mapl.Read() - '0';
                        map[x1, y1, 0, 4] = mapl.Read() - '0';
                    }
                }
                mapl.ReadLine();
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 1, 0] = mapl.Read() - '0';
                        map[x1, y1, 1, 1] = mapl.Read() - '0';
                        map[x1, y1, 1, 2] = mapl.Read() - '0';
                        map[x1, y1, 1, 3] = mapl.Read() - '0';
                        map[x1, y1, 1, 4] = mapl.Read() - '0';
                    }
                }
                mapl.ReadLine();
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 2, 0] = mapl.Read() - '0';
                        map[x1, y1, 2, 1] = mapl.Read() - '0';
                        map[x1, y1, 2, 2] = mapl.Read() - '0';
                        map[x1, y1, 2, 3] = mapl.Read() - '0';
                        map[x1, y1, 2, 4] = mapl.Read() - '0';
                    }
                }
                mapl.ReadLine();
                for (int y1 = 0; y1 < 260; y1++)
                {
                    for (int x1 = 0; x1 < 260; x1++)
                    {
                        map[x1, y1, 3, 0] = mapl.Read() - '0';
                        map[x1, y1, 3, 1] = mapl.Read() - '0';
                        map[x1, y1, 3, 2] = mapl.Read() - '0';
                        map[x1, y1, 3, 3] = mapl.Read() - '0';
                        map[x1, y1, 3, 4] = mapl.Read() - '0';
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
            for (int y1 = 0; y1 < 260; y1++)
            {
                for (int x1 = 0; x1 < 260; x1++)
                {
                    Mps.Write(map[x1, y1, 0, 0]);
                    Mps.Write(map[x1, y1, 0, 1]);
                    Mps.Write(map[x1, y1, 0, 2]);
                    Mps.Write(map[x1, y1, 0, 3]);
                    Mps.Write(map[x1, y1, 0, 4]);
                }
            }
            Mps.Write('\n');
            for (int y1 = 0; y1 < 260; y1++)
            {
                for (int x1 = 0; x1 < 260; x1++)
                {
                    Mps.Write(map[x1, y1, 0, 0]);
                    Mps.Write(map[x1, y1, 0, 1]);
                    Mps.Write(map[x1, y1, 0, 2]);
                    Mps.Write(map[x1, y1, 0, 3]);
                    Mps.Write(map[x1, y1, 0, 4]);
                }
            }
            Mps.Write('\n');
            for (int y1 = 0; y1 < 260; y1++)
            {
                for (int x1 = 0; x1 < 260; x1++)
                {
                    Mps.Write(map[x1, y1, 0, 0]);
                    Mps.Write(map[x1, y1, 0, 1]);
                    Mps.Write(map[x1, y1, 0, 2]);
                    Mps.Write(map[x1, y1, 0, 3]);
                    Mps.Write(map[x1, y1, 0, 4]);
                }
            }
            Mps.Write('\n');
            for (int y1 = 0; y1 < 260; y1++)
            {
                for (int x1 = 0; x1 < 260; x1++)
                {
                    Mps.Write(map[x1, y1, 0, 0]);
                    Mps.Write(map[x1, y1, 0, 1]);
                    Mps.Write(map[x1, y1, 0, 2]);
                    Mps.Write(map[x1, y1, 0, 3]);
                    Mps.Write(map[x1, y1, 0, 4]);
                }
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
                if (map[x - 1, y, z, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lastx = x;
                    x--;
                    map[x, y, z, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp[6]--;
                Program.player.ill++;
            }

        }
        public void South()
        {
            if (x != 255)
            {
                if (map[x + 1, y, z, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lastx = x;
                    x++;
                    map[x, y, z, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp[6]--;
                Program.player.ill++;
            }
        }
        public void East()
        {
            if (y != 255)
            {
                if (map[x, y + 1, z, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lasty = y;
                    y++;
                    map[x, y, z, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp[6]--;
                Program.player.ill++;
            }
        }
        public void West()
        {
            if (y != 0)
            {
                if (map[x, y - 1, z, 0] == 2)
                {
                    Program.player.ill++;
                }
                else
                {
                    lasty = y;
                    y--;
                    map[x, y, z, 3] = 1;
                    Program.player.spll++;
                }
            }
            else
            {
                Program.player.hp[6]--;
                Program.player.ill++;
            }
        }
        public void reuturn()
        {
            x = lastx;
            y = lasty;
            IO.Map();
        }
    }
}
