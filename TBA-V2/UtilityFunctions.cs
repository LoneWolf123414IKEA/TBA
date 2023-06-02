using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureV2
{
    internal class UtilityFunctions
    {
        private readonly Random r = new();
        public float Pro()
        {
            return r.Next() / int.MaxValue;
        }
        public int Wh(int[] wheights)
        {
            int totw = 0;
            foreach (int i in wheights) totw += i;

            int sel = r.Next(totw);
            int curr = 0;
            for (int i = 0; i < wheights.Length; i++)
            {
                for (int j = 0; j < wheights[i]; j++)
                {
                    if (curr == sel) return i;
                    curr++;
                }
            }
            return 0;
        }
        public int Wh()
        {
            int[] wheights =
            {
                9,
                9,
                0,
                5,
                25,
                20,
                9,
                4,
                7,
                4//this is for nothing
            };
            int totw = 0;
            foreach (int i in wheights) totw += i;

            int sel = r.Next(totw);
            int curr = 0;
            for (int i = 0; i < wheights.Length; i++)
            {
                for (int j = 0; j < wheights[i]; j++)
                {
                    if (curr == sel) return i;
                    curr++;
                }
            }
            return 0;
        }
        public bool Wh(int x, int y)
        {
            if (r.Next(x + y) > x) return false;
            return true;
        }

    }
}
