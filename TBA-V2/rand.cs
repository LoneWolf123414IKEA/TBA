using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA_V2
{
    internal class rand
    {
        private new Random r = new Random();
        public int wh(int[] wheights)
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
        public int wh()
        {
            int[] wheights =
            {
                12,
                12,
                0,
                5,
                10,
                4,
                32,
                20,
                10,//this is for armour
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
        public bool wh(int x, int y)
        {
            if (r.Next(x + y) > x) return false;
            return true;
        }
    }
}
