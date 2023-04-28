using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string name;
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
        public void gen(int diff)
        {
            switch (rand.wh(randarrs[diff]))
            {
                default:
                    break;
            }
        }
    }
}
